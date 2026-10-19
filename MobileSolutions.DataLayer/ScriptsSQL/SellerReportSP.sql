USE MobileSolutionsDB;
GO

-- ============================================================================
-- SELLER REPORT STORED PROCEDURES (US-FileSystem-028)
-- ============================================================================
GO

-- ============================================================================
-- 1. RESUMEN DE KPIs Y DESGLOSE POR MEDIO DE PAGO (sp_GetSellerKpiSummary)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetSellerKpiSummary
    @user_id INT,
    @year INT = NULL,
    @month INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @user_id IS NULL OR @user_id <= 0
    BEGIN
        RAISERROR('El parámetro @user_id es obligatorio y debe ser válido.', 16, 1);
        RETURN;
    END

    DECLARE @TargetYear INT = ISNULL(@year, YEAR(GETDATE()));
    DECLARE @TargetMonth INT = ISNULL(@month, MONTH(GETDATE()));

    DECLARE @StartDate DATETIME = DATEFROMPARTS(@TargetYear, @TargetMonth, 1);
    DECLARE @EndDate DATETIME = DATEADD(MONTH, 1, @StartDate);
    DECLARE @PrevStartDate DATETIME = DATEADD(MONTH, -1, @StartDate);

    SELECT
        COUNT(sh.sale_id) AS total_sales_count,
        ISNULL(SUM(sh.total_sale), 0) AS total_revenue,
        ISNULL(AVG(sh.total_sale), 0) AS average_ticket,
        ISNULL(MAX(sh.total_sale), 0) AS max_sale,
        ISNULL(SUM(CASE WHEN pt.description LIKE '%Efectivo%' THEN sh.total_sale ELSE 0 END), 0) AS cash_total,
        ISNULL(SUM(CASE WHEN pt.description LIKE '%Transferencia%' THEN sh.total_sale ELSE 0 END), 0) AS transfer_total,
        ISNULL((
            SELECT SUM(sh_prev.total_sale)
            FROM SaleHeader AS sh_prev
            WHERE sh_prev.user_id = @user_id
              AND sh_prev.status = 1
              AND sh_prev.sale_date >= @PrevStartDate
              AND sh_prev.sale_date < @StartDate
        ), 0) AS prev_month_revenue
    FROM SaleHeader AS sh
    INNER JOIN PaymentType AS pt ON pt.payment_type_id = sh.payment_type_id
    WHERE sh.user_id = @user_id
      AND sh.status = 1
      AND sh.sale_date >= @StartDate
      AND sh.sale_date < @EndDate;
END;
GO

-- ============================================================================
-- 2. CELULAR MÁS VENDIDO CON EMPATES (sp_GetSellerMostSoldProducts)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetSellerMostSoldProducts
    @user_id INT,
    @year INT = NULL,
    @month INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @user_id IS NULL OR @user_id <= 0
    BEGIN
        RAISERROR('El parámetro @user_id es obligatorio y debe ser válido.', 16, 1);
        RETURN;
    END

    DECLARE @TargetYear INT = ISNULL(@year, YEAR(GETDATE()));
    DECLARE @TargetMonth INT = ISNULL(@month, MONTH(GETDATE()));

    DECLARE @StartDate DATETIME = DATEFROMPARTS(@TargetYear, @TargetMonth, 1);
    DECLARE @EndDate DATETIME = DATEADD(MONTH, 1, @StartDate);

    SELECT TOP (1) WITH TIES
        p.product_id        AS product_id,
        p.product_code      AS product_code,
        p.name              AS product_name,
        SUM(sd.quantity)    AS units_sold
    FROM SaleDetail AS sd
    INNER JOIN SaleHeader AS sh ON sh.sale_id = sd.sale_id
    INNER JOIN Product AS p ON p.product_id = sd.product_id
    WHERE sh.user_id = @user_id
      AND sh.status = 1
      AND sh.sale_date >= @StartDate
      AND sh.sale_date < @EndDate
    GROUP BY p.product_id, p.product_code, p.name
    ORDER BY SUM(sd.quantity) DESC;
END;
GO

-- ============================================================================
-- 3. CELULAR MENOS VENDIDO CON EMPATES - INCLUYE 0 VENTAS (sp_GetSellerLeastSoldProducts)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetSellerLeastSoldProducts
    @user_id INT,
    @year INT = NULL,
    @month INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @user_id IS NULL OR @user_id <= 0
    BEGIN
        RAISERROR('El parámetro @user_id es obligatorio y debe ser válido.', 16, 1);
        RETURN;
    END

    DECLARE @TargetYear INT = ISNULL(@year, YEAR(GETDATE()));
    DECLARE @TargetMonth INT = ISNULL(@month, MONTH(GETDATE()));

    DECLARE @StartDate DATETIME = DATEFROMPARTS(@TargetYear, @TargetMonth, 1);
    DECLARE @EndDate DATETIME = DATEADD(MONTH, 1, @StartDate);

    SELECT TOP (1) WITH TIES
        p.product_id                AS product_id,
        p.product_code              AS product_code,
        p.name                      AS product_name,
        ISNULL(SUM(sd.quantity), 0) AS units_sold
    FROM Product AS p
    LEFT JOIN (
        SaleDetail AS sd
        INNER JOIN SaleHeader AS sh
            ON sh.sale_id = sd.sale_id
            AND sh.user_id = @user_id
            AND sh.status = 1
            AND sh.sale_date >= @StartDate
            AND sh.sale_date < @EndDate
    ) ON sd.product_id = p.product_id
    WHERE p.status = 1
    GROUP BY p.product_id, p.product_code, p.name
    ORDER BY ISNULL(SUM(sd.quantity), 0) ASC;
END;
GO

-- ============================================================================
-- 4. MARCA MÁS VENDIDA CON EMPATES (sp_GetSellerMostSoldBrands)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetSellerMostSoldBrands
    @user_id INT,
    @year INT = NULL,
    @month INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @user_id IS NULL OR @user_id <= 0
    BEGIN
        RAISERROR('El parámetro @user_id es obligatorio y debe ser válido.', 16, 1);
        RETURN;
    END

    DECLARE @TargetYear INT = ISNULL(@year, YEAR(GETDATE()));
    DECLARE @TargetMonth INT = ISNULL(@month, MONTH(GETDATE()));

    DECLARE @StartDate DATETIME = DATEFROMPARTS(@TargetYear, @TargetMonth, 1);
    DECLARE @EndDate DATETIME = DATEADD(MONTH, 1, @StartDate);

    SELECT TOP (1) WITH TIES
        b.brand_id          AS brand_id,
        b.name              AS brand_name,
        SUM(sd.quantity)    AS units_sold
    FROM SaleDetail AS sd
    INNER JOIN SaleHeader AS sh ON sh.sale_id = sd.sale_id
    INNER JOIN Product AS p ON p.product_id = sd.product_id
    INNER JOIN Brand AS b ON b.brand_id = p.brand_id
    WHERE sh.user_id = @user_id
      AND sh.status = 1
      AND sh.sale_date >= @StartDate
      AND sh.sale_date < @EndDate
    GROUP BY b.brand_id, b.name
    ORDER BY SUM(sd.quantity) DESC;
END;
GO

-- ============================================================================
-- 5. MARCA MENOS VENDIDA CON EMPATES - INCLUYE 0 VENTAS (sp_GetSellerLeastSoldBrands)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetSellerLeastSoldBrands
    @user_id INT,
    @year INT = NULL,
    @month INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @user_id IS NULL OR @user_id <= 0
    BEGIN
        RAISERROR('El parámetro @user_id es obligatorio y debe ser válido.', 16, 1);
        RETURN;
    END

    DECLARE @TargetYear INT = ISNULL(@year, YEAR(GETDATE()));
    DECLARE @TargetMonth INT = ISNULL(@month, MONTH(GETDATE()));

    DECLARE @StartDate DATETIME = DATEFROMPARTS(@TargetYear, @TargetMonth, 1);
    DECLARE @EndDate DATETIME = DATEADD(MONTH, 1, @StartDate);

    SELECT TOP (1) WITH TIES
        b.brand_id                  AS brand_id,
        b.name                      AS brand_name,
        ISNULL(SUM(sd.quantity), 0) AS units_sold
    FROM Brand AS b
    LEFT JOIN Product AS p
        ON p.brand_id = b.brand_id
        AND p.status = 1
    LEFT JOIN (
        SaleDetail AS sd
        INNER JOIN SaleHeader AS sh
            ON sh.sale_id = sd.sale_id
            AND sh.user_id = @user_id
            AND sh.status = 1
            AND sh.sale_date >= @StartDate
            AND sh.sale_date < @EndDate
    ) ON sd.product_id = p.product_id
    WHERE b.status = 1
    GROUP BY b.brand_id, b.name
    ORDER BY ISNULL(SUM(sd.quantity), 0) ASC;
END;
GO

-- ============================================================================
-- 6. EVOLUCIÓN DIARIA DE FACTURACIÓN DEL MES (sp_GetSellerDailyEvolution)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetSellerDailyEvolution
    @user_id INT,
    @year INT = NULL,
    @month INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @user_id IS NULL OR @user_id <= 0
    BEGIN
        RAISERROR('El parámetro @user_id es obligatorio y debe ser válido.', 16, 1);
        RETURN;
    END

    DECLARE @TargetYear INT = ISNULL(@year, YEAR(GETDATE()));
    DECLARE @TargetMonth INT = ISNULL(@month, MONTH(GETDATE()));

    DECLARE @StartDate DATETIME = DATEFROMPARTS(@TargetYear, @TargetMonth, 1);
    DECLARE @EndDate DATETIME = DATEADD(MONTH, 1, @StartDate);

    SELECT
        DAY(sh.sale_date)   AS sale_day,
        SUM(sh.total_sale)  AS daily_revenue
    FROM SaleHeader AS sh
    WHERE sh.user_id = @user_id
      AND sh.status = 1
      AND sh.sale_date >= @StartDate
      AND sh.sale_date < @EndDate
    GROUP BY DAY(sh.sale_date)
    ORDER BY sale_day ASC;
END;
GO

-- ============================================================================
-- 7. TOP 5 PRODUCTOS DEL VENDEDOR (sp_GetSellerTop5Products)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetSellerTop5Products
    @user_id INT,
    @year INT = NULL,
    @month INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @user_id IS NULL OR @user_id <= 0
    BEGIN
        RAISERROR('El parámetro @user_id es obligatorio y debe ser válido.', 16, 1);
        RETURN;
    END

    DECLARE @TargetYear INT = ISNULL(@year, YEAR(GETDATE()));
    DECLARE @TargetMonth INT = ISNULL(@month, MONTH(GETDATE()));

    DECLARE @StartDate DATETIME = DATEFROMPARTS(@TargetYear, @TargetMonth, 1);
    DECLARE @EndDate DATETIME = DATEADD(MONTH, 1, @StartDate);

    SELECT TOP (5)
        p.product_id        AS product_id,
        p.product_code      AS product_code,
        p.name              AS product_name,
        SUM(sd.quantity)    AS units_sold
    FROM SaleDetail AS sd
    INNER JOIN SaleHeader AS sh ON sh.sale_id = sd.sale_id
    INNER JOIN Product AS p ON p.product_id = sd.product_id
    WHERE sh.user_id = @user_id
      AND sh.status = 1
      AND sh.sale_date >= @StartDate
      AND sh.sale_date < @EndDate
    GROUP BY p.product_id, p.product_code, p.name
    ORDER BY units_sold DESC, p.name ASC;
END;
GO

-- ============================================================================
-- 8. DISTRIBUCIÓN POR MARCA DEL VENDEDOR (sp_GetSellerBrandDistribution)
-- ============================================================================
CREATE OR ALTER PROCEDURE sp_GetSellerBrandDistribution
    @user_id INT,
    @year INT = NULL,
    @month INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @user_id IS NULL OR @user_id <= 0
    BEGIN
        RAISERROR('El parámetro @user_id es obligatorio y debe ser válido.', 16, 1);
        RETURN;
    END

    DECLARE @TargetYear INT = ISNULL(@year, YEAR(GETDATE()));
    DECLARE @TargetMonth INT = ISNULL(@month, MONTH(GETDATE()));

    DECLARE @StartDate DATETIME = DATEFROMPARTS(@TargetYear, @TargetMonth, 1);
    DECLARE @EndDate DATETIME = DATEADD(MONTH, 1, @StartDate);

    SELECT
        b.brand_id          AS brand_id,
        b.name              AS brand_name,
        SUM(sd.quantity)    AS units_sold
    FROM SaleDetail AS sd
    INNER JOIN SaleHeader AS sh ON sh.sale_id = sd.sale_id
    INNER JOIN Product AS p ON p.product_id = sd.product_id
    INNER JOIN Brand AS b ON b.brand_id = p.brand_id
    WHERE sh.user_id = @user_id
      AND sh.status = 1
      AND sh.sale_date >= @StartDate
      AND sh.sale_date < @EndDate
    GROUP BY b.brand_id, b.name
    HAVING SUM(sd.quantity) > 0
    ORDER BY units_sold DESC, b.name ASC;
END;
GO
