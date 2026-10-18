USE MobileSolutionsDB;
GO

-- ============================================================================
-- SALE SPs UNIFICADOS (SaleHeader + SaleDetail)
-- ============================================================================
-- Objetivo: CRUD de ventas completo con impacto controlado sobre stock.
-- - Al CONFIRMAR venta: se descuenta stock (sp_CreateSale)
-- - Al CANCELAR venta: se devuelve stock (sp_CancelSale)
-- - Al REACTIVAR venta: se valida stock y se vuelve a descontar (sp_ReactivateSale)
-- - "Reservar" stock NO se hace al agregar al carrito. Solo validación en UI.
-- ============================================================================
GO

-- 1. TABLE VALUED PARAMETER PARA DETALLES DE VENTA
-- ============================================================================
IF TYPE_ID('dbo.SaleDetailType') IS NULL
BEGIN
    CREATE TYPE dbo.SaleDetailType AS TABLE
    (
        product_id  INT             NOT NULL,
        quantity    INT             NOT NULL,
        price       DECIMAL(18, 2)  NOT NULL
    );
END;
GO

-- ============================================================================
-- 2. OBTENER VENTAS ACTIVAS (sp_GetActiveSales)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetActiveSales
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        sh.sale_id          AS sale_id,
        sh.sale_number      AS sale_number,
        sh.sale_date        AS sale_date,
        sh.total_sale       AS total_sale,
        sh.status           AS status,
        sh.payment_type_id  AS payment_type_id,
        pt.description      AS payment_type,
        sh.customer_id      AS customer_id,
        c.dni               AS customer_dni,
        c.name              AS customer_name,
        c.lastname         AS customer_lastname,
        sh.user_id          AS user_id,
        u.username          AS user_username,
        u.name              AS seller_name,
        u.lastname         AS seller_lastname
    FROM SaleHeader AS sh
    INNER JOIN Customer AS c ON c.customer_id = sh.customer_id
    INNER JOIN [User]   AS u ON u.user_id     = sh.user_id
    INNER JOIN PaymentType AS pt ON pt.payment_type_id = sh.payment_type_id
    WHERE sh.status = 1
    ORDER BY sh.sale_date DESC, sh.sale_id DESC;
END;
GO

-- ============================================================================
-- 3. OBTENER VENTAS INACTIVAS/CANCELADAS (sp_GetInactiveSales)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetInactiveSales
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        sh.sale_id          AS sale_id,
        sh.sale_number      AS sale_number,
        sh.sale_date        AS sale_date,
        sh.total_sale       AS total_sale,
        sh.status           AS status,
        sh.payment_type_id  AS payment_type_id,
        pt.description      AS payment_type,
        sh.customer_id      AS customer_id,
        c.dni               AS customer_dni,
        c.name              AS customer_name,
        c.lastname         AS customer_lastname,
        sh.user_id          AS user_id,
        u.username          AS user_username,
        u.name              AS seller_name,
        u.lastname         AS seller_lastname
    FROM SaleHeader AS sh
    INNER JOIN Customer AS c ON c.customer_id = sh.customer_id
    INNER JOIN [User]   AS u ON u.user_id     = sh.user_id
    INNER JOIN PaymentType AS pt ON pt.payment_type_id = sh.payment_type_id
    WHERE sh.status = 0
    ORDER BY sh.sale_date DESC, sh.sale_id DESC;
END;
GO

-- ============================================================================
-- 4. OBTENER DETALLES DE UNA VENTA (sp_GetSaleDetailsBySaleId)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetSaleDetailsBySaleId
    @sale_id INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @sale_id IS NULL
    BEGIN
        RAISERROR('El parámetro @sale_id no puede ser nulo.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM SaleHeader WHERE sale_id = @sale_id)
    BEGIN
        RAISERROR('La venta indicada no existe.', 16, 1);
        RETURN;
    END

    SELECT 
        sd.sale_detail_id   AS sale_detail_id,
        sd.sale_id          AS sale_id,
        sd.product_id       AS product_id,
        p.product_code      AS product_code,
        p.name              AS product_name,
        b.name              AS brand_name,
        sd.quantity         AS quantity,
        sd.price            AS unit_price,
        (sd.quantity * sd.price) AS subtotal
    FROM SaleDetail AS sd
    INNER JOIN Product AS p ON p.product_id = sd.product_id
    INNER JOIN Brand   AS b ON b.brand_id   = p.brand_id
    WHERE sd.sale_id = @sale_id
    ORDER BY sd.sale_detail_id ASC;
END;
GO

-- ============================================================================
-- 5. BUSCAR VENTAS ACTIVAS CON FILTRO DINÁMICO (sp_SearchActiveSales)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_SearchActiveSales
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SET @SearchTerm = NULLIF(LTRIM(RTRIM(@SearchTerm)), '');

    SELECT 
        sh.sale_id          AS sale_id,
        sh.sale_number      AS sale_number,
        sh.sale_date        AS sale_date,
        sh.total_sale       AS total_sale,
        sh.payment_type_id  AS payment_type_id,
        pt.description      AS payment_type,
        c.dni               AS customer_dni,
        c.name              AS customer_name,
        c.lastname         AS customer_lastname,
        u.username          AS user_username,
        u.name              AS seller_name,
        u.lastname         AS seller_lastname
    FROM SaleHeader AS sh
    INNER JOIN Customer AS c ON c.customer_id = sh.customer_id
    INNER JOIN [User]   AS u ON u.user_id     = sh.user_id
    INNER JOIN PaymentType AS pt ON pt.payment_type_id = sh.payment_type_id
    WHERE 
        sh.status = 1
        AND (
            @SearchTerm IS NULL
            OR sh.sale_number   LIKE '%' + @SearchTerm + '%'
            OR c.dni            LIKE '%' + @SearchTerm + '%'
            OR c.name           LIKE '%' + @SearchTerm + '%'
            OR c.lastname       LIKE '%' + @SearchTerm + '%'
            OR u.username       LIKE '%' + @SearchTerm + '%'
            OR u.name           LIKE '%' + @SearchTerm + '%'
            OR u.lastname       LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY sh.sale_date DESC, sh.sale_id DESC;
END;
GO

-- ============================================================================
-- 6. BUSCAR VENTAS INACTIVAS CON FILTRO DINÁMICO (sp_SearchInactiveSales)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_SearchInactiveSales
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SET @SearchTerm = NULLIF(LTRIM(RTRIM(@SearchTerm)), '');

    SELECT 
        sh.sale_id          AS sale_id,
        sh.sale_number      AS sale_number,
        sh.sale_date        AS sale_date,
        sh.total_sale       AS total_sale,
        sh.payment_type_id  AS payment_type_id,
        pt.description      AS payment_type,
        c.dni               AS customer_dni,
        c.name              AS customer_name,
        c.lastname         AS customer_lastname,
        u.username          AS user_username,
        u.name              AS seller_name,
        u.lastname         AS seller_lastname
    FROM SaleHeader AS sh
    INNER JOIN Customer AS c ON c.customer_id = sh.customer_id
    INNER JOIN [User]   AS u ON u.user_id     = sh.user_id
    INNER JOIN PaymentType AS pt ON pt.payment_type_id = sh.payment_type_id
    WHERE 
        sh.status = 0
        AND (
            @SearchTerm IS NULL
            OR sh.sale_number   LIKE '%' + @SearchTerm + '%'
            OR c.dni            LIKE '%' + @SearchTerm + '%'
            OR c.name           LIKE '%' + @SearchTerm + '%'
            OR c.lastname       LIKE '%' + @SearchTerm + '%'
            OR u.username       LIKE '%' + @SearchTerm + '%'
            OR u.name           LIKE '%' + @SearchTerm + '%'
            OR u.lastname       LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY sh.sale_date DESC, sh.sale_id DESC;
END;
GO

-- ============================================================================
-- 7. BUSCAR HISTORIAL DE VENTAS CON FILTROS COMBINADOS (sp_SearchSalesHistory)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_SearchSalesHistory
    @StartDate  DATE           = NULL,
    @EndDate    DATE           = NULL,
    @SaleNumber NVARCHAR(50)   = NULL,
    @ClientName NVARCHAR(100)  = NULL,
    @UserId     INT            = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SET @SaleNumber = NULLIF(LTRIM(RTRIM(@SaleNumber)), '');
    SET @ClientName = NULLIF(LTRIM(RTRIM(@ClientName)), '');

    DECLARE @EndDateTime DATETIME = NULL;
    IF @EndDate IS NOT NULL
        SET @EndDateTime = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(@EndDate AS DATETIME)));

    SELECT 
        sh.sale_id          AS sale_id,
        sh.sale_number      AS sale_number,
        sh.sale_date        AS sale_date,
        sh.total_sale       AS total_sale,
        sh.status           AS status,
        sh.payment_type_id  AS payment_type_id,
        pt.description      AS payment_type,
        sh.customer_id      AS customer_id,
        c.dni               AS customer_dni,
        c.name              AS customer_name,
        c.lastname         AS customer_lastname,
        sh.user_id          AS user_id,
        u.username          AS user_username,
        u.name              AS seller_name,
        u.lastname         AS seller_lastname
    FROM SaleHeader AS sh
    INNER JOIN Customer AS c ON c.customer_id = sh.customer_id
    INNER JOIN [User]   AS u ON u.user_id     = sh.user_id
    INNER JOIN PaymentType AS pt ON pt.payment_type_id = sh.payment_type_id
    WHERE 
        sh.status = 1
        AND (@StartDate IS NULL OR sh.sale_date >= CAST(@StartDate AS DATETIME))
        AND (@EndDateTime IS NULL OR sh.sale_date <= @EndDateTime)
        AND (@SaleNumber IS NULL OR sh.sale_number LIKE '%' + @SaleNumber + '%')
        AND (
            @ClientName IS NULL
            OR c.dni      LIKE '%' + @ClientName + '%'
            OR c.name     LIKE '%' + @ClientName + '%'
            OR c.lastname LIKE '%' + @ClientName + '%'
        )
        AND (@UserId IS NULL OR sh.user_id = @UserId)
    ORDER BY sh.sale_date DESC, sh.sale_id DESC;
END;
GO

-- ============================================================================
-- 8. CREAR VENTA (CABECERA + DETALLES + DESCUENTO DE STOCK)
--    - Genera sale_number: NV-000X-00000001 (correlativo por vendedor)
--    - Transaccional: todo o nada
--    - Valida stock suficiente antes de descontar
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_CreateSale
    @payment_type_id    INT,
    @customer_id        INT,
    @user_id            INT,
    @details            dbo.SaleDetailType READONLY
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @sale_id INT;
    DECLARE @sale_number VARCHAR(100);
    DECLARE @seq INT;
    DECLARE @userCode4 VARCHAR(4);
    DECLARE @total_sale DECIMAL(18,2);

    -- Validaciones básicas
    IF @payment_type_id IS NULL OR @customer_id IS NULL OR @user_id IS NULL
    BEGIN
        RAISERROR('payment_type_id, customer_id y user_id son obligatorios.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM PaymentType WHERE payment_type_id = @payment_type_id AND status = 1)
    BEGIN
        RAISERROR('El tipo de pago indicado no existe o no está activo.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Customer WHERE customer_id = @customer_id AND status = 1)
    BEGIN
        RAISERROR('El cliente indicado no existe o no está activo.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM [User] WHERE user_id = @user_id AND status = 1)
    BEGIN
        RAISERROR('El vendedor indicado no existe o no está activo.', 16, 1);
        RETURN;
    END

    -- Validar que el TVP tenga al menos un ítem
    IF NOT EXISTS (SELECT 1 FROM @details)
    BEGIN
        RAISERROR('La venta debe tener al menos un producto en el detalle.', 16, 1);
        RETURN;
    END

    -- Validar cantidad > 0 y precio >= 0
    IF EXISTS (SELECT 1 FROM @details WHERE quantity <= 0 OR price < 0)
    BEGIN
        RAISERROR('Cantidad debe ser mayor a 0 y precio >= 0 para todos los ítems.', 16, 1);
        RETURN;
    END

    -- Validar existencia/estado de productos y stock suficiente
    IF EXISTS (
        SELECT 1
        FROM @details d
        LEFT JOIN Product p ON p.product_id = d.product_id
        WHERE p.product_id IS NULL OR p.status = 0
    )
    BEGIN
        RAISERROR('Existe al menos un producto inválido o inactivo en el detalle.', 16, 1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1
        FROM @details d
        INNER JOIN Product p ON p.product_id = d.product_id
        WHERE d.quantity > p.stock
    )
    BEGIN
        RAISERROR('Stock insuficiente para al menos uno de los productos. Verificá disponibilidad antes de confirmar.', 16, 1);
        RETURN;
    END

    -- Calcular total
    SELECT @total_sale = ISNULL(SUM(quantity * price), 0)
    FROM @details;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Generar sale_number: NV-000X-00000001 (correlativo por vendedor)
        SET @userCode4 = RIGHT('0000' + CAST(@user_id AS VARCHAR(10)), 4);

        SELECT @seq = ISNULL(MAX(CAST(RIGHT(sale_number, 8) AS INT)), 0) + 1
        FROM SaleHeader WITH (UPDLOCK, HOLDLOCK)
        WHERE user_id = @user_id
          AND sale_number LIKE 'NV-' + @userCode4 + '-%';

        SET @sale_number = 'NV-' + @userCode4 + '-' + RIGHT('00000000' + CAST(@seq AS VARCHAR(8)), 8);

        -- Insertar cabecera
        INSERT INTO SaleHeader (
            payment_type_id,
            customer_id,
            user_id,
            sale_number,
            sale_date,
            total_sale,
            status
        )
        VALUES (
            @payment_type_id,
            @customer_id,
            @user_id,
            @sale_number,
            GETDATE(),
            @total_sale,
            1
        );

        SET @sale_id = SCOPE_IDENTITY();

        -- Insertar detalles
        INSERT INTO SaleDetail (
            sale_id,
            product_id,
            quantity,
            price
        )
        SELECT
            @sale_id,
            d.product_id,
            d.quantity,
            d.price
        FROM @details d;

        -- Descontar stock (solo al confirmar)
        UPDATE p
        SET p.stock = p.stock - d.quantity
        FROM Product p
        INNER JOIN @details d ON d.product_id = p.product_id
        WHERE p.stock >= d.quantity; -- doble validación por seguridad

        COMMIT TRANSACTION;

        -- Retornar datos de la venta creada
        SELECT 
            @sale_id     AS sale_id,
            @sale_number AS sale_number,
            @total_sale  AS total_sale;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @errMsg NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@errMsg, 16, 1);
        RETURN;
    END CATCH
END;
GO

-- ============================================================================
-- 9. CANCELAR VENTA (status = 0 + DEVOLVER STOCK)
--    Diferencia con DELETE: no borra, anula y repone stock
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_CancelSale
    @sale_id INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    IF @sale_id IS NULL
    BEGIN
        RAISERROR('El parámetro @sale_id no puede ser nulo.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM SaleHeader WHERE sale_id = @sale_id)
    BEGIN
        RAISERROR('La venta indicada no existe.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM SaleHeader WHERE sale_id = @sale_id AND status = 0)
    BEGIN
        RAISERROR('La venta ya se encuentra cancelada.', 16, 1);
        RETURN;
    END

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Devolver stock con base en detalles existentes
        UPDATE p
        SET p.stock = p.stock + sd.quantity
        FROM Product p
        INNER JOIN SaleDetail sd ON sd.product_id = p.product_id
        WHERE sd.sale_id = @sale_id;

        -- Cancelar cabecera
        UPDATE SaleHeader
        SET status = 0
        WHERE sale_id = @sale_id;

        COMMIT TRANSACTION;

        SELECT 1 AS Success, 'Venta cancelada correctamente. Stock devuelto.' AS Message;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @errMsg2 NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@errMsg2, 16, 1);
        RETURN;
    END CATCH
END;
GO

-- ============================================================================
-- 10. REACTIVAR VENTA (status = 1 + VOLVER A DESCONTAR STOCK)
--    Valida que haya stock suficiente para TODOS los ítems antes de reactivar
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_ReactivateSale
    @sale_id INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    IF @sale_id IS NULL
    BEGIN
        RAISERROR('El parámetro @sale_id no puede ser nulo.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM SaleHeader WHERE sale_id = @sale_id)
    BEGIN
        RAISERROR('La venta indicada no existe.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM SaleHeader WHERE sale_id = @sale_id AND status = 1)
    BEGIN
        RAISERROR('La venta ya se encuentra activa.', 16, 1);
        RETURN;
    END

    -- Validar stock suficiente para reactivar
    IF EXISTS (
        SELECT 1
        FROM SaleDetail sd
        INNER JOIN Product p ON p.product_id = sd.product_id
        WHERE sd.sale_id = @sale_id
          AND sd.quantity > p.stock
    )
    BEGIN
        RAISERROR('No hay stock suficiente para reactivar esta venta. Algunos productos quedaron sin stock desde su cancelación.', 16, 1);
        RETURN;
    END

    -- Validar que todos los productos sigan activos
    IF EXISTS (
        SELECT 1
        FROM SaleDetail sd
        INNER JOIN Product p ON p.product_id = sd.product_id
        WHERE sd.sale_id = @sale_id
          AND p.status = 0
    )
    BEGIN
        RAISERROR('No se puede reactivar: al menos un producto de esta venta se encuentra inactivo.', 16, 1);
        RETURN;
    END

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Volver a descontar stock
        UPDATE p
        SET p.stock = p.stock - sd.quantity
        FROM Product p
        INNER JOIN SaleDetail sd ON sd.product_id = p.product_id
        WHERE sd.sale_id = @sale_id
          AND p.stock >= sd.quantity;

        -- Reactivar cabecera
        UPDATE SaleHeader
        SET status = 1
        WHERE sale_id = @sale_id;

        COMMIT TRANSACTION;

        SELECT 1 AS Success, 'Venta reactivada correctamente. Stock descontado nuevamente.' AS Message;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @errMsg3 NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@errMsg3, 16, 1);
        RETURN;
    END CATCH
END;
GO

-- ============================================================================
-- VERIFICACIÓN RÁPIDA
-- ============================================================================
SELECT 
    SCHEMA_NAME(schema_id) AS Esquema,
    name AS NombreProcedimiento,
    create_date AS FechaCreacion,
    modify_date AS UltimaModificacion
FROM sys.procedures
WHERE name LIKE 'sp_%Sale%'
ORDER BY name;
GO

IF NOT EXISTS (SELECT 1 FROM PaymentType WHERE description = 'Efectivo')
    INSERT INTO PaymentType (description, status) VALUES ('Efectivo', 1);

IF NOT EXISTS (SELECT 1 FROM PaymentType WHERE description = 'Transferencia')
    INSERT INTO PaymentType (description, status) VALUES ('Transferencia', 1);

SELECT * FROM SaleHeader;