USE MobileSolutionsDB;
GO

-- ============================================================================
-- 1. TABLA DE AUDITORÍA GENERAL DEL SISTEMA (AuditLog)
-- ============================================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'AuditLog' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE dbo.AuditLog (
        audit_id    INT IDENTITY(1,1) NOT NULL,
        [timestamp] DATETIME2(7)      NOT NULL CONSTRAINT DF_AuditLog_Timestamp DEFAULT GETDATE(),
        event_type  VARCHAR(50)       NOT NULL, -- 'Login', 'Logout', 'Backup Created', 'Database Restored', 'User Created', 'User Modified'
        actor       VARCHAR(100)      NOT NULL,
        outcome     VARCHAR(20)       NOT NULL, -- 'Success', 'Failure'
        details     VARCHAR(255)      NULL,

        CONSTRAINT PK_AuditLog PRIMARY KEY (audit_id)
    );

    CREATE NONCLUSTERED INDEX IX_AuditLog_Timestamp ON dbo.AuditLog([timestamp] DESC);
    CREATE NONCLUSTERED INDEX IX_AuditLog_EventType ON dbo.AuditLog(event_type, outcome);
    CREATE NONCLUSTERED INDEX IX_AuditLog_Actor ON dbo.AuditLog(actor);
END;
GO

-- ============================================================================
-- 2. TABLA DE AUDITORÍA DE PRECIOS DE PRODUCTOS (ProductPriceAudit)
-- ============================================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ProductPriceAudit' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE dbo.ProductPriceAudit (
        audit_id            INT IDENTITY(1,1) NOT NULL,
        product_id          INT               NOT NULL,
        product_code        VARCHAR(100)      NOT NULL,
        product_name        VARCHAR(100)      NOT NULL,
        old_purchase_price  DECIMAL(18, 2)    NOT NULL,
        new_purchase_price  DECIMAL(18, 2)    NOT NULL,
        old_sale_price      DECIMAL(18, 2)    NOT NULL,
        new_sale_price      DECIMAL(18, 2)    NOT NULL,
        change_date         DATETIME2(7)      NOT NULL CONSTRAINT DF_ProductPriceAudit_ChangeDate DEFAULT GETDATE(),

        CONSTRAINT PK_ProductPriceAudit PRIMARY KEY (audit_id)
    );

    CREATE NONCLUSTERED INDEX IX_ProductPriceAudit_Product ON dbo.ProductPriceAudit(product_id, change_date DESC);
END;
GO

-- ============================================================================
-- 3. TRIGGER: DETECCIÓN AUTOMÁTICA DE CAMBIOS DE PRECIOS EN PRODUCTOS
-- ============================================================================
CREATE OR ALTER TRIGGER dbo.trg_Product_PriceAudit
ON dbo.Product
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(sale_price) OR UPDATE(purchase_price)
    BEGIN
        INSERT INTO dbo.ProductPriceAudit (
            product_id,
            product_code,
            product_name,
            old_purchase_price,
            new_purchase_price,
            old_sale_price,
            new_sale_price,
            change_date
        )
        SELECT 
            i.product_id,
            i.product_code,
            i.name,
            d.purchase_price,
            i.purchase_price,
            d.sale_price,
            i.sale_price,
            GETDATE()
        FROM inserted i
        INNER JOIN deleted d ON i.product_id = d.product_id
        WHERE i.sale_price <> d.sale_price OR i.purchase_price <> d.purchase_price;
    END
END;
GO

-- ============================================================================
-- 4. SP: REGISTRO DE EVENTOS DE AUDITORÍA (sp_RecordAuditEvent)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_RecordAuditEvent
    @event_type VARCHAR(50),
    @actor      VARCHAR(100),
    @outcome    VARCHAR(20),
    @details    VARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.AuditLog (
        [timestamp],
        event_type,
        actor,
        outcome,
        details
    )
    VALUES (
        GETDATE(),
        @event_type,
        @actor,
        @outcome,
        @details
    );
END;
GO

-- ============================================================================
-- 5. SP: OBTENER MÉTRICAS DEL DASHBOARD DE ADMINISTRADOR (sp_GetAdminDashboardMetrics)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetAdminDashboardMetrics
AS
BEGIN
    SET NOCOUNT ON;

    -- Variables para AC1: Auditoría de Acceso y Sesiones
    DECLARE @MostActiveUser VARCHAR(100) = 'Sin datos';
    DECLARE @MostActiveUserLoginCount INT = 0;
    DECLARE @OrphanAccountsCount INT = 0;
    DECLARE @LastLoginUser VARCHAR(100) = 'Sin datos';
    DECLARE @LastLoginTimestamp DATETIME2(7) = NULL;
    DECLARE @FailedLoginsLast24Hours INT = 0;

    -- 1. Usuario con más logins
    SELECT TOP 1 
        @MostActiveUser = actor,
        @MostActiveUserLoginCount = COUNT(*)
    FROM dbo.AuditLog
    WHERE event_type = 'Login' AND outcome = 'Success'
    GROUP BY actor
    ORDER BY COUNT(*) DESC;

    -- 2. Cuentas Huérfanas / Inactivas: usuarios activos (status=1) sin login en los últimos 30 días o nunca
    SELECT @OrphanAccountsCount = COUNT(*)
    FROM dbo.[User] u
    WHERE u.status = 1
      AND (
          NOT EXISTS (
              SELECT 1 FROM dbo.AuditLog a 
              WHERE a.actor = u.username 
                AND a.event_type = 'Login' 
                AND a.outcome = 'Success'
          )
          OR (
              SELECT MAX(a.[timestamp]) FROM dbo.AuditLog a 
              WHERE a.actor = u.username 
                AND a.event_type = 'Login' 
                AND a.outcome = 'Success'
          ) < DATEADD(DAY, -30, GETDATE())
      );

    -- 3. Último login registrado
    SELECT TOP 1
        @LastLoginUser = actor,
        @LastLoginTimestamp = [timestamp]
    FROM dbo.AuditLog
    WHERE event_type = 'Login' AND outcome = 'Success'
    ORDER BY [timestamp] DESC, audit_id DESC;

    -- 4. Intentos fallidos en las últimas 24 horas
    SELECT @FailedLoginsLast24Hours = COUNT(*)
    FROM dbo.AuditLog
    WHERE event_type = 'Login'
      AND outcome = 'Failure'
      AND [timestamp] >= DATEADD(HOUR, -24, GETDATE());

    -- Variables para AC3 & AC4: Métricas de Base de Datos y Disaster Recovery
    DECLARE @DatabaseAllocatedMb DECIMAL(18, 2) = 0.0;
    DECLARE @DatabaseUsedMb DECIMAL(18, 2) = 0.0;
    DECLARE @TotalBackups INT = 0;
    DECLARE @TotalRestores INT = 0;
    DECLARE @LastRestoreTimestamp DATETIME2(7) = NULL;
    DECLARE @LastBackupTimestamp DATETIME2(7) = NULL;

    -- 5. Tamaño de base de datos asignado y usado (desde sys.database_files)
    SELECT 
        @DatabaseAllocatedMb = SUM(size * 8.0 / 1024.0),
        @DatabaseUsedMb = SUM(FILEPROPERTY(name, 'SpaceUsed') * 8.0 / 1024.0)
    FROM sys.database_files;

    -- 6. Totales y últimas fechas de Backups y Restores
    SELECT 
        @TotalBackups = COUNT(*),
        @LastBackupTimestamp = MAX([timestamp])
    FROM dbo.AuditLog
    WHERE event_type = 'Backup Created' AND outcome = 'Success';

    SELECT 
        @TotalRestores = COUNT(*),
        @LastRestoreTimestamp = MAX([timestamp])
    FROM dbo.AuditLog
    WHERE event_type = 'Database Restored' AND outcome = 'Success';

    -- Retornar resultado como un único registro
    SELECT 
        ISNULL(@MostActiveUser, 'Sin datos')             AS MostActiveUser,
        ISNULL(@MostActiveUserLoginCount, 0)             AS MostActiveUserLoginCount,
        ISNULL(@OrphanAccountsCount, 0)                  AS OrphanAccountsCount,
        ISNULL(@LastLoginUser, 'Sin registros')          AS LastLoginUser,
        @LastLoginTimestamp                              AS LastLoginTimestamp,
        ISNULL(@FailedLoginsLast24Hours, 0)              AS FailedLoginsLast24Hours,
        ISNULL(@DatabaseAllocatedMb, 0.0)                AS DatabaseAllocatedMb,
        ISNULL(@DatabaseUsedMb, 0.0)                     AS DatabaseUsedMb,
        ISNULL(@TotalBackups, 0)                         AS TotalBackups,
        ISNULL(@TotalRestores, 0)                        AS TotalRestores,
        @LastRestoreTimestamp                            AS LastRestoreTimestamp,
        @LastBackupTimestamp                             AS LastBackupTimestamp;
END;
GO

-- ============================================================================
-- 6. SP: OBTENER LOS ÚLTIMOS EVENTOS CRÍTICOS (sp_GetLastCriticalAuditEvents)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetLastCriticalAuditEvents
    @TopCount INT = 100
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (@TopCount)
        audit_id,
        [timestamp],
        event_type,
        actor,
        outcome,
        details
    FROM dbo.AuditLog
    ORDER BY [timestamp] DESC, audit_id DESC;
END;
GO

-- ============================================================================
-- 7. SP: OBTENER HISTORIAL DE AUDITORÍA DE PRECIOS (sp_GetProductPriceAuditHistory)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetProductPriceAuditHistory
    @TopCount INT = 100
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (@TopCount)
        audit_id,
        product_id,
        product_code,
        product_name,
        old_purchase_price,
        new_purchase_price,
        old_sale_price,
        new_sale_price,
        change_date,
        (new_sale_price - old_sale_price) AS sale_difference,
        CASE 
            WHEN old_sale_price > 0 THEN ((new_sale_price - old_sale_price) / old_sale_price) * 100.0
            ELSE 0.0
        END AS percentage_change
    FROM dbo.ProductPriceAudit
    ORDER BY change_date DESC, audit_id DESC;
END;
GO

-- ============================================================================
-- 8. DATOS SEMILLA INICIALES (Solo si las tablas están vacías)
-- ============================================================================
IF NOT EXISTS (SELECT 1 FROM dbo.AuditLog)
BEGIN
    -- Semilla de logins previos
    INSERT INTO dbo.AuditLog ([timestamp], event_type, actor, outcome, details)
    VALUES 
    (DATEADD(DAY, -4, GETDATE()), 'Login', 'admin', 'Success', 'Inicio de sesión exitoso'),
    (DATEADD(DAY, -3, GETDATE()), 'Login', 'admin', 'Success', 'Inicio de sesión exitoso'),
    (DATEADD(DAY, -2, GETDATE()), 'Login', 'admin', 'Success', 'Inicio de sesión exitoso'),
    (DATEADD(DAY, -1, GETDATE()), 'Login', 'admin', 'Success', 'Inicio de sesión exitoso'),
    (DATEADD(HOUR, -2, GETDATE()), 'Login', 'admin', 'Success', 'Inicio de sesión exitoso'),
    (DATEADD(HOUR, -3, GETDATE()), 'Login', 'nico', 'Failure', 'Contraseña incorrecta'),
    (DATEADD(DAY, -5, GETDATE()), 'Backup Created', 'admin', 'Success', 'MobileSolution-Backup-Full.bak generado'),
    (DATEADD(DAY, -12, GETDATE()), 'Database Restored', 'admin', 'Success', 'Restauración de prueba exitosa');
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.ProductPriceAudit)
BEGIN
    INSERT INTO dbo.ProductPriceAudit (product_id, product_code, product_name, old_purchase_price, new_purchase_price, old_sale_price, new_sale_price, change_date)
    VALUES
    (1, 'PROD-001', 'Samsung Galaxy A54', 280000.00, 295000.00, 390000.00, 420000.00, DATEADD(DAY, -2, GETDATE())),
    (2, 'PROD-002', 'iPhone 13 128GB', 820000.00, 850000.00, 1100000.00, 1180000.00, DATEADD(DAY, -1, GETDATE()));
END;
GO
