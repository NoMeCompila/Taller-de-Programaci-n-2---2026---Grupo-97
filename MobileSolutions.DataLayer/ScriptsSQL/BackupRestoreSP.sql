USE MobileSolutionsDB;
GO

-- ============================================================================
-- SP: GENERAR BACKUP COMPLETO DE LA BASE DE DATOS (sp_CreateDatabaseBackup)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_CreateDatabaseBackup
    @BackupPath NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Validación de parámetro
    IF @BackupPath IS NULL OR LTRIM(RTRIM(@BackupPath)) = ''
    BEGIN
        RAISERROR('La ruta de destino del archivo de backup no puede estar vacía.', 16, 1);
        RETURN;
    END;

    -- 2. Ejecución del Backup completo
    BEGIN TRY
        BACKUP DATABASE [MobileSolutionsDB]
        TO DISK = @BackupPath
        WITH 
            FORMAT,          -- Crea un nuevo conjunto de medios (no concatena en un backup set previo)
            INIT,            -- Sobrescribe cualquier conjunto existente en ese archivo destino
            NAME = N'MobileSolutionsDB - Full Backup',
            SKIP,
            NOREWIND,
            NOUNLOAD,
            STATS = 10;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

-- ============================================================================
-- SCRIPT / PROCEDIMIENTO DE RESTORE COMPLETO DESDE MASTER
-- Nota: La restauración de una base de datos activa se debe ejecutar conectándose
-- a la base de datos 'master' y forzando SINGLE_USER para terminar conexiones existentes.
-- ============================================================================
USE master;
GO

CREATE OR ALTER PROCEDURE dbo.sp_RestoreDatabaseFromBackup
    @BackupPath NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    IF @BackupPath IS NULL OR LTRIM(RTRIM(@BackupPath)) = ''
    BEGIN
        RAISERROR('La ruta del archivo de backup (.bak) no puede estar vacía.', 16, 1);
        RETURN;
    END;

    BEGIN TRY
        -- 1. Validar integridad preliminar del archivo de backup
        RESTORE VERIFYONLY FROM DISK = @BackupPath;

        -- 2. Forzar modo de usuario único cerrando conexiones abiertas inmediatamente
        ALTER DATABASE [MobileSolutionsDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

        -- 3. Restaurar la base de datos reemplazando la actual y dejándola operativa
        RESTORE DATABASE [MobileSolutionsDB]
        FROM DISK = @BackupPath
        WITH REPLACE, RECOVERY;

        -- 4. Reestablecer el modo multiusuario para acceso inmediato de la aplicación
        ALTER DATABASE [MobileSolutionsDB] SET MULTI_USER;
    END TRY
    BEGIN CATCH
        -- Asegurar que la base de datos regrese a MULTI_USER en caso de excepción
        IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'MobileSolutionsDB' AND user_access_desc = 'SINGLE_USER')
        BEGIN
            ALTER DATABASE [MobileSolutionsDB] SET MULTI_USER;
        END;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

USE MobileSolutionsDB;
GO
