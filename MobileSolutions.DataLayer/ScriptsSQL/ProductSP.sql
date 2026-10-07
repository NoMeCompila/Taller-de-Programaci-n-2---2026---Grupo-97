USE MobileSolutionsDB;
GO

-- Product Table Store Procedures
-- ============================================================================
-- 1. OBTENER TODOS LOS PRODUCTOS ACTIVOS (sp_GetActiveProducts)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetActiveProducts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.product_id       AS product_id,
        p.brand_id         AS brand_id,
        b.name             AS Marca,
        p.product_code     AS Codigo,
        p.name             AS Nombre,
        p.stock            AS Stock,
        p.purchase_price   AS PrecioCompra,
        p.sale_price       AS PrecioVenta,
        p.image            AS Imagen
    FROM Product AS p
    INNER JOIN Brand AS b 
        ON p.brand_id = b.brand_id
    WHERE p.status = 1
    ORDER BY b.name ASC, p.name ASC;
END;
GO

-- ============================================================================
-- 2. OBTENER TODOS LOS PRODUCTOS INACTIVOS (sp_GetInactiveProducts)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetInactiveProducts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.product_id       AS product_id,
        p.brand_id         AS brand_id,
        b.name             AS Marca,
        p.product_code     AS Codigo,
        p.name             AS Nombre,
        p.stock            AS Stock,
        p.purchase_price   AS PrecioCompra,
        p.sale_price       AS PrecioVenta,
        p.image            AS Imagen
    FROM Product AS p
    INNER JOIN Brand AS b 
        ON p.brand_id = b.brand_id
    WHERE p.status = 0
    ORDER BY b.name ASC, p.name ASC;
END;
GO

-- ============================================================================
-- 3. CREAR UN NUEVO PRODUCTO (sp_CreateProduct)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_CreateProduct
    @brand_id           INT,
    @product_code       VARCHAR(100),
    @name               VARCHAR(100),
    @stock              INT,
    @purchase_price     DECIMAL(18, 2),
    @sale_price         DECIMAL(18, 2),
    @image              VARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar que los campos obligatorios no vengan vacíos, nulos ni con puros espacios
    IF @brand_id IS NULL
       OR ISNULL(LTRIM(RTRIM(@product_code)), '') = ''
       OR ISNULL(LTRIM(RTRIM(@name)), '') = ''
       OR @stock IS NULL
       OR @purchase_price IS NULL
       OR @sale_price IS NULL
    BEGIN
        RAISERROR('Los campos obligatorios no pueden estar vacíos o contener solo espacios.', 16, 1);
        RETURN;
    END

    -- Validación: el stock no puede ser negativo
    IF @stock < 0
    BEGIN
        RAISERROR('El stock no puede ser negativo.', 16, 1);
        RETURN;
    END

    -- Validación: los precios no pueden ser negativos
    IF @purchase_price < 0 OR @sale_price < 0
    BEGIN
        RAISERROR('Los precios no pueden ser negativos.', 16, 1);
        RETURN;
    END

    -- Validación: el precio de venta no puede ser menor al precio de compra
    IF @sale_price < @purchase_price
    BEGIN
        RAISERROR('El precio de venta no puede ser menor al precio de compra.', 16, 1);
        RETURN;
    END

    -- Validación: la marca debe existir y estar activa
    IF NOT EXISTS (SELECT 1 FROM Brand WHERE brand_id = @brand_id AND status = 1)
    BEGIN
        RAISERROR('La marca indicada no existe o no está activa.', 16, 1);
        RETURN;
    END

    -- Validación: el código de producto debe ser único
    IF EXISTS (SELECT 1 FROM Product WHERE product_code = @product_code)
    BEGIN
        RAISERROR('Ya existe un producto con ese código.', 16, 1);
        RETURN;
    END

    INSERT INTO Product (
        brand_id, product_code, name, stock, 
        purchase_price, sale_price, status, image
    )
    VALUES (
        @brand_id, @product_code, @name, @stock, 
        @purchase_price, @sale_price, 1, @image
    );

    -- Retorna el ID autogenerado para el nuevo producto
    SELECT SCOPE_IDENTITY() AS NewProductId;
END;
GO

-- ============================================================================
-- 4. MODIFICAR UN PRODUCTO EXISTENTE (sp_UpdateProduct)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_UpdateProduct
    @product_id         INT,
    @brand_id           INT,
    @product_code       VARCHAR(100),
    @name               VARCHAR(100),
    @stock              INT,
    @purchase_price     DECIMAL(18, 2),
    @sale_price         DECIMAL(18, 2),
    @image              VARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT OFF; -- Permite que ExecuteNonQuery() en C# reciba las filas afectadas

    -- Validar que los campos obligatorios no vengan vacíos, nulos ni con puros espacios
    IF @product_id IS NULL
       OR @brand_id IS NULL
       OR ISNULL(LTRIM(RTRIM(@product_code)), '') = ''
       OR ISNULL(LTRIM(RTRIM(@name)), '') = ''
       OR @stock IS NULL
       OR @purchase_price IS NULL
       OR @sale_price IS NULL
    BEGIN
        RAISERROR('Los campos obligatorios no pueden estar vacíos o contener solo espacios.', 16, 1);
        RETURN;
    END

    -- Validación: el stock no puede ser negativo
    IF @stock < 0
    BEGIN
        RAISERROR('El stock no puede ser negativo.', 16, 1);
        RETURN;
    END

    -- Validación: los precios no pueden ser negativos
    IF @purchase_price < 0 OR @sale_price < 0
    BEGIN
        RAISERROR('Los precios no pueden ser negativos.', 16, 1);
        RETURN;
    END

    -- Validación: el precio de venta no puede ser menor al precio de compra
    IF @sale_price < @purchase_price
    BEGIN
        RAISERROR('El precio de venta no puede ser menor al precio de compra.', 16, 1);
        RETURN;
    END

    -- Validación: la marca debe existir y estar activa
    IF NOT EXISTS (SELECT 1 FROM Brand WHERE brand_id = @brand_id AND status = 1)
    BEGIN
        RAISERROR('La marca indicada no existe o no está activa.', 16, 1);
        RETURN;
    END

    -- Validación: el código de producto debe ser único (excluyendo el propio registro)
    IF EXISTS (SELECT 1 FROM Product WHERE product_code = @product_code AND product_id <> @product_id)
    BEGIN
        RAISERROR('Ya existe un producto con ese código.', 16, 1);
        RETURN;
    END

    UPDATE Product
    SET 
        brand_id       = @brand_id,
        product_code   = @product_code,
        name           = @name,
        stock          = @stock,
        purchase_price = @purchase_price,
        sale_price     = @sale_price,
        image          = @image
    WHERE product_id = @product_id;
END;
GO

-- ============================================================================
-- 5. BORRADO LÓGICO DE UN PRODUCTO (sp_DeleteProduct)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_DeleteProduct
    @product_id INT
AS
BEGIN
    SET NOCOUNT OFF; -- Permite verificar el éxito con ExecuteNonQuery()

    -- Desactivar registro (soft-delete)
    UPDATE Product
    SET status = 0
    WHERE product_id = @product_id;
END;
GO

-- ============================================================================
-- 6. REACTIVACION DE UN PRODUCTO (sp_ReactivateProduct)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_ReactivateProduct
    @product_id INT
AS
BEGIN
    SET NOCOUNT OFF; -- Permite verificar el éxito con ExecuteNonQuery()

    -- Reactivar registro
    UPDATE Product
    SET status = 1
    WHERE product_id = @product_id;
END;
GO

-- ============================================================================
-- 7. BUSCAR PRODUCTOS ACTIVOS CON FILTRO DINÁMICO (sp_SearchActiveProducts)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_SearchActiveProducts
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Normaliza el término de búsqueda
    SET @SearchTerm = NULLIF(LTRIM(RTRIM(@SearchTerm)), '');

    SELECT 
        p.product_id       AS product_id,
        p.brand_id         AS brand_id,
        b.name             AS Marca,
        p.product_code     AS Codigo,
        p.name             AS Nombre,
        p.stock            AS Stock,
        p.purchase_price   AS PrecioCompra,
        p.sale_price       AS PrecioVenta,
        p.image            AS Imagen
    FROM Product AS p
    INNER JOIN Brand AS b 
        ON p.brand_id = b.brand_id
    WHERE 
        p.status = 1
        AND (
            @SearchTerm IS NULL 
            OR p.product_code  LIKE '%' + @SearchTerm + '%'
            OR p.name          LIKE '%' + @SearchTerm + '%'
            OR b.name          LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY b.name ASC, p.name ASC;
END;
GO

-- ============================================================================
-- 8. BUSCAR PRODUCTOS INACTIVOS CON FILTRO DINÁMICO (sp_SearchInactiveProducts)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_SearchInactiveProducts
    @SearchTerm NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Normaliza el término de búsqueda
    SET @SearchTerm = NULLIF(LTRIM(RTRIM(@SearchTerm)), '');

    SELECT 
        p.product_id       AS product_id,
        p.brand_id         AS brand_id,
        b.name             AS Marca,
        p.product_code     AS Codigo,
        p.name             AS Nombre,
        p.stock            AS Stock,
        p.purchase_price   AS PrecioCompra,
        p.sale_price       AS PrecioVenta,
        p.image            AS Imagen
    FROM Product AS p
    INNER JOIN Brand AS b 
        ON p.brand_id = b.brand_id
    WHERE 
        p.status = 0
        AND (
            @SearchTerm IS NULL 
            OR p.product_code  LIKE '%' + @SearchTerm + '%'
            OR p.name          LIKE '%' + @SearchTerm + '%'
            OR b.name          LIKE '%' + @SearchTerm + '%'
        )
    ORDER BY b.name ASC, p.name ASC;
END;
GO
