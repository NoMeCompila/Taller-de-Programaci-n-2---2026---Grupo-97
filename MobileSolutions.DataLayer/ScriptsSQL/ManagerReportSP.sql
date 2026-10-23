USE MobileSolutionsDB;
GO

-- ============================================================================
-- MANAGER REPORT STORED PROCEDURES (US-FileSystem-029)
-- ============================================================================
-- Procedimientos almacenados para el reporte del gerente con soporte de rango de fechas:
--   1. sp_GetManagerKpiSummary: Métricas clave globales (facturación, año, pagos, cancelaciones)
--   2. sp_GetManagerTopBottomSellers: Ranking de vendedores (más ventas, menos ventas, más recaudación)
--   3. sp_GetManagerMostSoldProducts: Celular(es) más vendido(s) con empates
--   4. sp_GetManagerLeastSoldProducts: Celular(es) menos vendido(s) con empates (incluye 0 ventas)
--   5. sp_GetManagerMostSoldBrands: Marca(s) más vendida(s) con empates
--   6. sp_GetManagerLeastSoldBrands: Marca(s) menos vendida(s) con empates (incluye 0 ventas)
--   7. sp_GetManagerRevenueEvolution: Evolución cronológica de recaudación para gráfico de barras
--   8. sp_GetManagerSellerDistribution: Distribución de ventas por vendedor para gráfico de torta/dona
-- ============================================================================
GO

-- ============================================================================
-- 1. RESUMEN DE KPIs GERENCIALES (sp_GetManagerKpiSummary)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetManagerKpiSummary
    @start_date DATETIME = NULL,
    @end_date   DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Resolución de rango por defecto (mes actual completo si no se pasan parámetros)
    DECLARE @ActualStartDate DATETIME;
    DECLARE @ActualEndDate   DATETIME;

    IF @start_date IS NULL
        SET @ActualStartDate = CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME);
    ELSE
        SET @ActualStartDate = CAST(CAST(@start_date AS DATE) AS DATETIME);

    IF @end_date IS NULL
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(MONTH, 1, CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME)));
    ELSE
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@end_date AS DATE) AS DATETIME)));

    -- Año de referencia para el acumulado anual (año de la fecha fin)
    DECLARE @TargetYear INT = YEAR(@ActualEndDate);
    DECLARE @YearStartDate DATETIME = CAST(DATEFROMPARTS(@TargetYear, 1, 1) AS DATETIME);
    DECLARE @YearEndDate   DATETIME = DATEADD(SECOND, -1, DATEADD(YEAR, 1, @YearStartDate));

    -- Mes previo al período para calcular comparativa porcentual
    DECLARE @PrevMonthStart DATETIME = DATEADD(MONTH, -1, @ActualStartDate);
    DECLARE @PrevMonthEnd   DATETIME = DATEADD(SECOND, -1, @ActualStartDate);

    SELECT
        -- Métricas del período activo
        COUNT(CASE WHEN sh.status = 1 THEN sh.sale_id ELSE NULL END) AS total_sales_count,
        ISNULL(SUM(CASE WHEN sh.status = 1 THEN sh.total_sale ELSE 0 END), 0) AS total_revenue,
        ISNULL(AVG(CASE WHEN sh.status = 1 THEN sh.total_sale ELSE NULL END), 0) AS average_ticket,
        ISNULL(MAX(CASE WHEN sh.status = 1 THEN sh.total_sale ELSE 0 END), 0) AS max_sale,
        ISNULL(SUM(CASE WHEN sh.status = 1 AND pt.description LIKE '%Efectivo%' THEN sh.total_sale ELSE 0 END), 0) AS cash_total,
        ISNULL(SUM(CASE WHEN sh.status = 1 AND pt.description LIKE '%Transferencia%' THEN sh.total_sale ELSE 0 END), 0) AS transfer_total,

        -- Cancelaciones y Tasa de Cancelación / Devolución
        COUNT(CASE WHEN sh.status = 0 THEN sh.sale_id ELSE NULL END) AS cancelled_sales_count,
        COUNT(sh.sale_id) AS total_initiated_sales,
        CASE 
            WHEN COUNT(sh.sale_id) > 0 
            THEN ROUND((CAST(COUNT(CASE WHEN sh.status = 0 THEN 1 ELSE NULL END) AS DECIMAL(18, 4)) / COUNT(sh.sale_id)) * 100.0, 2)
            ELSE 0.00 
        END AS cancellation_rate,

        -- Recaudación total acumulada del año correspondiente
        ISNULL((
            SELECT SUM(sh_year.total_sale)
            FROM dbo.SaleHeader AS sh_year
            WHERE sh_year.status = 1
              AND sh_year.sale_date >= @YearStartDate
              AND sh_year.sale_date <= @YearEndDate
        ), 0) AS year_revenue,

        -- Recaudación del mes previo para variación
        ISNULL((
            SELECT SUM(sh_prev.total_sale)
            FROM dbo.SaleHeader AS sh_prev
            WHERE sh_prev.status = 1
              AND sh_prev.sale_date >= @PrevMonthStart
              AND sh_prev.sale_date <= @PrevMonthEnd
        ), 0) AS prev_month_revenue
    FROM dbo.SaleHeader AS sh
    INNER JOIN dbo.PaymentType AS pt ON pt.payment_type_id = sh.payment_type_id
    WHERE sh.sale_date >= @ActualStartDate
      AND sh.sale_date <= @ActualEndDate;
END;
GO

-- ============================================================================
-- 2. RANKING DE VENDEDORES (sp_GetManagerTopBottomSellers)
--    Retorna: Vendedores con más ventas, menos ventas y mayor facturación
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetManagerTopBottomSellers
    @start_date DATETIME = NULL,
    @end_date   DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ActualStartDate DATETIME;
    DECLARE @ActualEndDate   DATETIME;

    IF @start_date IS NULL
        SET @ActualStartDate = CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME);
    ELSE
        SET @ActualStartDate = CAST(CAST(@start_date AS DATE) AS DATETIME);

    IF @end_date IS NULL
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(MONTH, 1, CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME)));
    ELSE
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@end_date AS DATE) AS DATETIME)));

    -- Tabla temporal con las métricas consolidadas de todos los vendedores activos (ProfileId = 2)
    -- Se incluyen los que tienen 0 ventas para permitir calcular el menos vendido real
    ;WITH SellerStats AS (
        SELECT 
            u.user_id,
            u.username,
            RTRIM(CONCAT(u.name, ' ', u.lastname)) AS full_name,
            COUNT(sh.sale_id) AS sales_count,
            ISNULL(SUM(sh.total_sale), 0) AS total_revenue
        FROM dbo.[User] AS u
        INNER JOIN dbo.Profile AS pr ON pr.profile_id = u.profile_id
        LEFT JOIN dbo.SaleHeader AS sh 
            ON sh.user_id = u.user_id 
            AND sh.status = 1
            AND sh.sale_date >= @ActualStartDate
            AND sh.sale_date <= @ActualEndDate
        WHERE u.status = 1
          AND pr.description = 'Vendedor'
        GROUP BY u.user_id, u.username, u.name, u.lastname
    )
    SELECT
        user_id,
        username,
        full_name,
        sales_count,
        total_revenue,
        -- Categorías para identificar empates en una única llamada o filtrado
        CASE WHEN sales_count = (SELECT MAX(sales_count) FROM SellerStats WHERE sales_count > 0) THEN 1 ELSE 0 END AS is_top_sales_count,
        CASE WHEN sales_count = (SELECT MIN(sales_count) FROM SellerStats) THEN 1 ELSE 0 END AS is_bottom_sales_count,
        CASE WHEN total_revenue = (SELECT MAX(total_revenue) FROM SellerStats WHERE total_revenue > 0) THEN 1 ELSE 0 END AS is_top_revenue
    FROM SellerStats
    ORDER BY total_revenue DESC, sales_count DESC, full_name ASC;
END;
GO

-- ============================================================================
-- 3. CELULAR MÁS VENDIDO CON EMPATES (sp_GetManagerMostSoldProducts)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetManagerMostSoldProducts
    @start_date DATETIME = NULL,
    @end_date   DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ActualStartDate DATETIME;
    DECLARE @ActualEndDate   DATETIME;

    IF @start_date IS NULL
        SET @ActualStartDate = CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME);
    ELSE
        SET @ActualStartDate = CAST(CAST(@start_date AS DATE) AS DATETIME);

    IF @end_date IS NULL
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(MONTH, 1, CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME)));
    ELSE
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@end_date AS DATE) AS DATETIME)));

    SELECT TOP (1) WITH TIES
        p.product_id        AS product_id,
        p.product_code      AS product_code,
        p.name              AS product_name,
        SUM(sd.quantity)    AS units_sold
    FROM dbo.SaleDetail AS sd
    INNER JOIN dbo.SaleHeader AS sh ON sh.sale_id = sd.sale_id
    INNER JOIN dbo.Product AS p ON p.product_id = sd.product_id
    WHERE sh.status = 1
      AND sh.sale_date >= @ActualStartDate
      AND sh.sale_date <= @ActualEndDate
    GROUP BY p.product_id, p.product_code, p.name
    ORDER BY SUM(sd.quantity) DESC;
END;
GO

-- ============================================================================
-- 4. CELULAR MENOS VENDIDO CON EMPATES - INCLUYE 0 VENTAS (sp_GetManagerLeastSoldProducts)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetManagerLeastSoldProducts
    @start_date DATETIME = NULL,
    @end_date   DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ActualStartDate DATETIME;
    DECLARE @ActualEndDate   DATETIME;

    IF @start_date IS NULL
        SET @ActualStartDate = CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME);
    ELSE
        SET @ActualStartDate = CAST(CAST(@start_date AS DATE) AS DATETIME);

    IF @end_date IS NULL
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(MONTH, 1, CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME)));
    ELSE
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@end_date AS DATE) AS DATETIME)));

    SELECT TOP (1) WITH TIES
        p.product_id                AS product_id,
        p.product_code              AS product_code,
        p.name                      AS product_name,
        ISNULL(SUM(sd.quantity), 0) AS units_sold
    FROM dbo.Product AS p
    LEFT JOIN (
        dbo.SaleDetail AS sd
        INNER JOIN dbo.SaleHeader AS sh 
            ON sh.sale_id = sd.sale_id
            AND sh.status = 1
            AND sh.sale_date >= @ActualStartDate
            AND sh.sale_date <= @ActualEndDate
    ) ON sd.product_id = p.product_id
    WHERE p.status = 1
    GROUP BY p.product_id, p.product_code, p.name
    ORDER BY ISNULL(SUM(sd.quantity), 0) ASC;
END;
GO

-- ============================================================================
-- 5. MARCA MÁS VENDIDA CON EMPATES (sp_GetManagerMostSoldBrands)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetManagerMostSoldBrands
    @start_date DATETIME = NULL,
    @end_date   DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ActualStartDate DATETIME;
    DECLARE @ActualEndDate   DATETIME;

    IF @start_date IS NULL
        SET @ActualStartDate = CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME);
    ELSE
        SET @ActualStartDate = CAST(CAST(@start_date AS DATE) AS DATETIME);

    IF @end_date IS NULL
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(MONTH, 1, CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME)));
    ELSE
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@end_date AS DATE) AS DATETIME)));

    SELECT TOP (1) WITH TIES
        b.brand_id          AS brand_id,
        b.name              AS brand_name,
        SUM(sd.quantity)    AS units_sold
    FROM dbo.SaleDetail AS sd
    INNER JOIN dbo.SaleHeader AS sh ON sh.sale_id = sd.sale_id
    INNER JOIN dbo.Product AS p ON p.product_id = sd.product_id
    INNER JOIN dbo.Brand AS b ON b.brand_id = p.brand_id
    WHERE sh.status = 1
      AND sh.sale_date >= @ActualStartDate
      AND sh.sale_date <= @ActualEndDate
    GROUP BY b.brand_id, b.name
    ORDER BY SUM(sd.quantity) DESC;
END;
GO

-- ============================================================================
-- 6. MARCA MENOS VENDIDA CON EMPATES - INCLUYE 0 VENTAS (sp_GetManagerLeastSoldBrands)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetManagerLeastSoldBrands
    @start_date DATETIME = NULL,
    @end_date   DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ActualStartDate DATETIME;
    DECLARE @ActualEndDate   DATETIME;

    IF @start_date IS NULL
        SET @ActualStartDate = CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME);
    ELSE
        SET @ActualStartDate = CAST(CAST(@start_date AS DATE) AS DATETIME);

    IF @end_date IS NULL
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(MONTH, 1, CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME)));
    ELSE
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@end_date AS DATE) AS DATETIME)));

    SELECT TOP (1) WITH TIES
        b.brand_id                  AS brand_id,
        b.name                      AS brand_name,
        ISNULL(SUM(sd.quantity), 0) AS units_sold
    FROM dbo.Brand AS b
    LEFT JOIN dbo.Product AS p
        ON p.brand_id = b.brand_id
        AND p.status = 1
    LEFT JOIN (
        dbo.SaleDetail AS sd
        INNER JOIN dbo.SaleHeader AS sh 
            ON sh.sale_id = sd.sale_id
            AND sh.status = 1
            AND sh.sale_date >= @ActualStartDate
            AND sh.sale_date <= @ActualEndDate
    ) ON sd.product_id = p.product_id
    WHERE b.status = 1
    GROUP BY b.brand_id, b.name
    ORDER BY ISNULL(SUM(sd.quantity), 0) ASC;
END;
GO

-- ============================================================================
-- 7. EVOLUCIÓN CRONOLÓGICA DE RECAUDACIÓN (sp_GetManagerRevenueEvolution)
--    Agrupa por día (si el rango <= 60 días) o por mes (si > 60 días)
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetManagerRevenueEvolution
    @start_date DATETIME = NULL,
    @end_date   DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ActualStartDate DATETIME;
    DECLARE @ActualEndDate   DATETIME;

    IF @start_date IS NULL
        SET @ActualStartDate = CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME);
    ELSE
        SET @ActualStartDate = CAST(CAST(@start_date AS DATE) AS DATETIME);

    IF @end_date IS NULL
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(MONTH, 1, CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME)));
    ELSE
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@end_date AS DATE) AS DATETIME)));

    DECLARE @DayDiff INT = DATEDIFF(DAY, @ActualStartDate, @ActualEndDate);

    IF @DayDiff <= 62
    BEGIN
        -- Agrupación diaria
        SELECT 
            CONVERT(VARCHAR(10), CAST(sh.sale_date AS DATE), 120) AS period_label,
            DAY(sh.sale_date)   AS period_day,
            MONTH(sh.sale_date) AS period_month,
            YEAR(sh.sale_date)  AS period_year,
            SUM(sh.total_sale)  AS revenue
        FROM dbo.SaleHeader AS sh
        WHERE sh.status = 1
          AND sh.sale_date >= @ActualStartDate
          AND sh.sale_date <= @ActualEndDate
        GROUP BY CAST(sh.sale_date AS DATE), DAY(sh.sale_date), MONTH(sh.sale_date), YEAR(sh.sale_date)
        ORDER BY period_year ASC, period_month ASC, period_day ASC;
    END
    ELSE
    BEGIN
        -- Agrupación mensual
        SELECT 
            FORMAT(sh.sale_date, 'yyyy-MM') AS period_label,
            1                   AS period_day,
            MONTH(sh.sale_date) AS period_month,
            YEAR(sh.sale_date)  AS period_year,
            SUM(sh.total_sale)  AS revenue
        FROM dbo.SaleHeader AS sh
        WHERE sh.status = 1
          AND sh.sale_date >= @ActualStartDate
          AND sh.sale_date <= @ActualEndDate
        GROUP BY FORMAT(sh.sale_date, 'yyyy-MM'), MONTH(sh.sale_date), YEAR(sh.sale_date)
        ORDER BY period_year ASC, period_month ASC;
    END
END;
GO

-- ============================================================================
-- 8. DISTRIBUCIÓN DE VENTAS POR VENDEDOR (sp_GetManagerSellerDistribution)
--    Para alimentar el gráfico de torta/dona de volumen o facturación compartida
-- ============================================================================
CREATE OR ALTER PROCEDURE dbo.sp_GetManagerSellerDistribution
    @start_date DATETIME = NULL,
    @end_date   DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ActualStartDate DATETIME;
    DECLARE @ActualEndDate   DATETIME;

    IF @start_date IS NULL
        SET @ActualStartDate = CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME);
    ELSE
        SET @ActualStartDate = CAST(CAST(@start_date AS DATE) AS DATETIME);

    IF @end_date IS NULL
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(MONTH, 1, CAST(DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) AS DATETIME)));
    ELSE
        SET @ActualEndDate = DATEADD(SECOND, -1, DATEADD(DAY, 1, CAST(CAST(@end_date AS DATE) AS DATETIME)));

    SELECT 
        u.user_id,
        u.username,
        RTRIM(CONCAT(u.name, ' ', u.lastname)) AS seller_name,
        COUNT(sh.sale_id)                      AS sales_count,
        ISNULL(SUM(sh.total_sale), 0)          AS total_revenue
    FROM dbo.[User] AS u
    INNER JOIN dbo.Profile AS pr ON pr.profile_id = u.profile_id
    INNER JOIN dbo.SaleHeader AS sh ON sh.user_id = u.user_id
    WHERE sh.status = 1
      AND pr.description = 'Vendedor'
      AND sh.sale_date >= @ActualStartDate
      AND sh.sale_date <= @ActualEndDate
    GROUP BY u.user_id, u.username, u.name, u.lastname
    HAVING COUNT(sh.sale_id) > 0
    ORDER BY total_revenue DESC, sales_count DESC;
END;
GO
