USE MobileSolutionsDB;
GO

-- ==============================================================================
-- Script: productData.sql
-- Descripción: Limpieza de registros y generación de 20 productos de prueba
--              - 20 Productos en total (5 por cada marca)
--              - Marcas requeridas (ya pobladas en la tabla Brand):
--                  1 = Motorola, 2 = Iphone, 3 = Samsung, 4 = Huawei
--              - 15 Activos (status = 1)
--              -  5 Inactivos (status = 0): 1 o 2 por marca
--              - Precios de compra y de venta en pesos argentinos (ARS),
--                siempre cumpliendo sale_price >= purchase_price
--                (CHK_Product_SalePrice) y purchase_price >= 0
--                (CHK_Product_PurchasePrice)
--              - Stock variado (incluye 0 para ejercitar alertas de stock)
--                y siempre >= 0 (CHK_Product_Stock)
--              - product_code únicos (UQ_Product_Code)
--              - image en NULL (se cargarán imágenes luego)
-- ==============================================================================

SET NOCOUNT ON;

-- ==============================================================================
-- Chequeo previo: ¿hay productos cargados en la base?
-- ==============================================================================
SELECT COUNT(*) AS [Productos Actuales] FROM Product;
GO

-- ==============================================================================
-- Limpieza condicional: borra y reinicia el id SOLO si hay registros
-- ==============================================================================
IF EXISTS (SELECT 1 FROM Product)
BEGIN
    PRINT 'Se detectaron productos en la base. Iniciando limpieza...';

    -- Desactivar temporalmente la FK de SaleDetail para permitir el borrado
    ALTER TABLE SaleDetail NOCHECK CONSTRAINT FK_SaleDetail_Product;

    -- Eliminar todos los productos existentes
    DELETE FROM Product;

    -- Reiniciar el contador de identidad
    DBCC CHECKIDENT ('Product', RESEED, 0);

    -- Reactivar la restricción FK
    ALTER TABLE SaleDetail CHECK CONSTRAINT FK_SaleDetail_Product;

    PRINT 'Limpieza completada. Contador de identity reiniciado en 0.';
END
ELSE
BEGIN
    PRINT 'La tabla Product ya estaba vacia. Se reinicia el contador por las dudas.';
    DBCC CHECKIDENT ('Product', RESEED, 0);
END
GO

-- ==============================================================================
-- Chequeo previo: las 4 marcas deben existir antes de insertar productos
-- (FK_Product_Brand)
-- ==============================================================================
IF NOT EXISTS (
    SELECT 1 FROM Brand 
    WHERE brand_id IN (1, 2, 3, 4) AND status = 1
)
BEGIN
    RAISERROR('Faltan marcas requeridas (Motorola, Iphone, Samsung, Huawei). Ejecute primero la carga de Brand.', 16, 1);
    RETURN;
END
GO

-- ==============================================================================
-- Inserción de los 20 productos de prueba
-- ==============================================================================
INSERT INTO Product (
    brand_id,
    product_code,
    name,
    stock,
    purchase_price,
    sale_price,
    status,
    image
)
VALUES
-- ==============================================================================
-- MOTOROLA (brand_id = 1) - 4 activos, 1 inactivo
-- ==============================================================================
(1, 'MOT-G84-256',  'Motorola Moto G84 5G 256GB',        25, 280000.00,  389999.00, 1, NULL),
(1, 'MOT-G54-128',  'Motorola Moto G54 5G 128GB',        40, 220000.00,  299999.00, 1, NULL),
(1, 'MOT-E13-64',   'Motorola Moto E13 64GB',            12, 120000.00,  169999.00, 1, NULL),
(1, 'MOT-EDGE40',   'Motorola Moto Edge 40 256GB',        8, 350000.00,  469999.00, 1, NULL),
(1, 'MOT-G24-128',  'Motorola Moto G24 128GB',            0, 180000.00,  249999.00, 0, NULL),

-- ==============================================================================
-- IPHONE (brand_id = 2) - 4 activos, 1 inactivo
-- ==============================================================================
(2, 'APL-IP15-128', 'Apple iPhone 15 128GB',             15, 950000.00, 1299999.00, 1, NULL),
(2, 'APL-IP14-128', 'Apple iPhone 14 128GB',             10, 780000.00, 1049999.00, 1, NULL),
(2, 'APL-IP13-128', 'Apple iPhone 13 128GB',             18, 650000.00,  869999.00, 1, NULL),
(2, 'APL-IP12-64',  'Apple iPhone 12 64GB',               6, 480000.00,  649999.00, 1, NULL),
(2, 'APL-IPSE3-64', 'Apple iPhone SE 3rd Gen 64GB',       0, 320000.00,  429999.00, 0, NULL),

-- ==============================================================================
-- SAMSUNG (brand_id = 3) - 3 activos, 2 inactivos
-- ==============================================================================
(3, 'SAM-S24-256',  'Samsung Galaxy S24 5G 256GB',       10, 850000.00, 1149999.00, 1, NULL),
(3, 'SAM-A55-128',  'Samsung Galaxy A55 5G 128GB',       30, 380000.00,  519999.00, 1, NULL),
(3, 'SAM-A15-128',  'Samsung Galaxy A15 128GB',          45, 175000.00,  244999.00, 1, NULL),
(3, 'SAM-A05-64',   'Samsung Galaxy A05 64GB',            0, 130000.00,  184999.00, 0, NULL),
(3, 'SAM-NOTE20',   'Samsung Galaxy Note 20 128GB',       3, 420000.00,  579999.00, 0, NULL),

-- ==============================================================================
-- HUAWEI (brand_id = 4) - 4 activos, 1 inactivo
-- ==============================================================================
(4, 'HUA-NOVA12I',  'Huawei Nova 12i 256GB',             22, 290000.00,  399999.00, 1, NULL),
(4, 'HUA-NOVA11',   'Huawei Nova 11 256GB',              14, 340000.00,  459999.00, 1, NULL),
(4, 'HUA-Y9A-128',  'Huawei Y9a 128GB',                  20, 250000.00,  339999.00, 1, NULL),
(4, 'HUA-P60-256',  'Huawei P60 Pro 256GB',               5, 720000.00,  969999.00, 1, NULL),
(4, 'HUA-ENJ60-128','Huawei Enjoy 60 128GB',              0, 140000.00,  199999.00, 0, NULL);
GO

-- ==============================================================================
-- Verificación de resumen
-- ==============================================================================
SELECT 
    status AS [Estado],
    COUNT(*) AS [Cantidad]
FROM Product
GROUP BY status;
GO

SELECT 
    b.name AS [Marca],
    COUNT(*) AS [Productos],
    SUM(CASE WHEN p.status = 1 THEN 1 ELSE 0 END) AS [Activos],
    SUM(CASE WHEN p.status = 0 THEN 1 ELSE 0 END) AS [Inactivos]
FROM Product AS p
INNER JOIN Brand AS b ON p.brand_id = b.brand_id
GROUP BY b.name
ORDER BY b.name ASC;
GO

SELECT 
    p.product_id    AS [Id],
    b.name          AS [Marca],
    p.product_code  AS [Codigo],
    p.name          AS [Nombre],
    p.stock         AS [Stock],
    p.purchase_price AS [Precio Compra],
    p.sale_price    AS [Precio Venta],
    p.status        AS [Estado]
FROM Product AS p
INNER JOIN Brand AS b ON p.brand_id = b.brand_id
ORDER BY p.status DESC, b.name ASC, p.name ASC;
GO
