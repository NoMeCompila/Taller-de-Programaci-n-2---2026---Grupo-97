USE MobileSolutionsDB;
GO

-- ==============================================================================
-- Script: SalesData.sql
-- Descripción: Datos de prueba para validar el esquema de Ventas (SaleHeader/SaleDetail)
--              - Inserta 5 ventas válidas (con sus detalles)
--              - Prueba los SPs de ventas creados en SaleSP.sql
--              - Ejecuta pruebas negativas con TRY/CATCH para corroborar restricciones
--              NO modifica stock de productos (validado vía SPs en flujo real)
-- ==============================================================================

SET NOCOUNT ON;
GO

-- ==============================================================================
-- 1. VERIFICACIÓN PREVIA
-- ==============================================================================

SELECT 'PaymentType' AS Tabla, payment_type_id, description, status FROM PaymentType ORDER BY payment_type_id;
SELECT profile_id, description, status FROM Profile ORDER BY profile_id;
SELECT 'User (activos)' AS Tabla, user_id, username, name, lastname, profile_id FROM [User] WHERE status = 1 ORDER BY user_id;
SELECT 'Customer (activos)' AS Tabla, customer_id, dni, name, lastname FROM Customer WHERE status = 1 ORDER BY customer_id;
SELECT 'Product (activos con stock)' AS Tabla, product_id, product_code, name, stock, sale_price FROM Product WHERE status = 1 AND stock > 0 ORDER BY product_id;
GO

-- ==============================================================================
-- 2. LIMPIEZA CONDICIONAL DE VENTAS DE PRUEBA
-- ==============================================================================

IF EXISTS (SELECT 1 FROM SaleDetail)
BEGIN
    PRINT 'Eliminando registros de SaleDetail...';
    DELETE FROM SaleDetail;
END

IF EXISTS (SELECT 1 FROM SaleHeader)
BEGIN
    PRINT 'Eliminando registros de SaleHeader...';
    DELETE FROM SaleHeader;
END

DBCC CHECKIDENT ('SaleHeader', RESEED, 0);
DBCC CHECKIDENT ('SaleDetail', RESEED, 0);

PRINT 'Limpieza finalizada. Identidades reiniciadas.';
GO

-- ==============================================================================
-- 3. INSERTS VÁLIDOS DE PRUEBA
--    Se seleccionan IDs existentes reales para garantizar integridad referencial
-- ==============================================================================

DECLARE @c1 INT, @c2 INT, @c3 INT, @p1 INT, @p2 INT, @p3 INT, @p4 INT, @p5 INT;

-- Clientes activos
SELECT TOP 1 @c1 = customer_id FROM Customer WHERE status = 1 ORDER BY customer_id;
SELECT TOP 1 @c2 = customer_id FROM Customer WHERE status = 1 AND customer_id <> @c1 ORDER BY customer_id;
SELECT TOP 1 @c3 = customer_id FROM Customer WHERE status = 1 AND customer_id <> @c1 AND customer_id <> @c2 ORDER BY customer_id;

-- Productos activos con stock
SELECT TOP 1 @p1 = product_id FROM Product WHERE status = 1 AND stock >= 5 ORDER BY product_id;
SELECT TOP 1 @p2 = product_id FROM Product WHERE status = 1 AND stock >= 5 AND product_id <> @p1 ORDER BY product_id;
SELECT TOP 1 @p3 = product_id FROM Product WHERE status = 1 AND stock >= 5 AND product_id <> @p1 AND product_id <> @p2 ORDER BY product_id;
SELECT TOP 1 @p4 = product_id FROM Product WHERE status = 1 AND stock >= 5 AND product_id <> @p1 AND product_id <> @p2 AND product_id <> @p3 ORDER BY product_id;
SELECT TOP 1 @p5 = product_id FROM Product WHERE status = 1 AND stock >= 5 AND product_id <> @p1 AND product_id <> @p2 AND product_id <> @p3 AND product_id <> @p4 ORDER BY product_id;

-- VENTA 1: Vendedor user_id=4002 (username: carlita4) | Efectivo | Activa
-- sale_number: NV-4002-00000001
DECLARE @sh1 INT;
INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
VALUES (1, @c1, 4002, 'NV-4002-00000001', GETDATE(), 1500.00, 1);
SET @sh1 = SCOPE_IDENTITY();

-- Detalle: 2 unidades a 750.00
INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
VALUES (@sh1, @p1, 2, 750.00);

PRINT 'OK - Venta 1 insertada: NV-4002-00000001 (activa)';

-- VENTA 2: Vendedor user_id=5004 (username: malvarez03) | Transferencia | Activa
-- sale_number: NV-5004-00000001
DECLARE @sh2 INT;
INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
VALUES (2, @c2, 5004, 'NV-5004-00000001', GETDATE(), 950.00, 1);
SET @sh2 = SCOPE_IDENTITY();

-- Detalle: 1 unidad a 950.00
INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
VALUES (@sh2, @p2, 1, 950.00);

PRINT 'OK - Venta 2 insertada: NV-5004-00000001 (activa)';

-- VENTA 3: Mismo vendedor user_id=4002 | Efectivo | Activa (correlativo distinto)
-- sale_number: NV-4002-00000002
DECLARE @sh3 INT;
INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
VALUES (1, @c3, 4002, 'NV-4002-00000002', GETDATE(), 1800.00, 1);
SET @sh3 = SCOPE_IDENTITY();

-- Detalles: 2 ítems distintos
INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
VALUES (@sh3, @p3, 2, 500.00),
       (@sh3, @p4, 2, 400.00); -- 1000 + 800 = 1800

PRINT 'OK - Venta 3 insertada: NV-4002-00000002 (activa con 2 detalles)';

-- VENTA 4: Vendedor user_id=5004 | Efectivo | Activa (correlativo distinto)
-- sale_number: NV-5004-00000002
DECLARE @sh4 INT;
INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
VALUES (1, @c1, 5004, 'NV-5004-00000002', GETDATE(), 300.00, 1);
SET @sh4 = SCOPE_IDENTITY();

INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
VALUES (@sh4, @p5, 3, 100.00); -- 300

PRINT 'OK - Venta 4 insertada: NV-5004-00000002 (activa)';

-- VENTA 5: Vendedor user_id=5007 | Transferencia | CANCELADA (status=0)
-- sale_number: NV-5007-00000001
DECLARE @sh5 INT;
INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
VALUES (2, @c2, 5007, 'NV-5007-00000001', GETDATE(), 850.00, 0);
SET @sh5 = SCOPE_IDENTITY();

INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
VALUES (@sh5, @p1, 1, 850.00);

PRINT 'OK - Venta 5 insertada: NV-5007-00000001 (CANCELADA/status=0)';
PRINT '--------------------------------------------------';
PRINT 'Ventas válidas insertadas correctamente.';
GO

-- ==============================================================================
-- 4. PRUEBA DE STORED PROCEDURES
-- ==============================================================================
PRINT '--- [1] sp_GetActiveSales ---';
EXEC sp_GetActiveSales;
GO

PRINT '--- [2] sp_GetInactiveSales ---';
EXEC sp_GetInactiveSales;
GO

DECLARE @sidActivo INT;
SELECT TOP 1 @sidActivo = sale_id FROM SaleHeader WHERE status = 1 ORDER BY sale_id;

PRINT '--- [3] sp_GetSaleDetailsBySaleId (sale_id=' + CAST(@sidActivo AS VARCHAR(10)) + ') ---';
EXEC sp_GetSaleDetailsBySaleId @sale_id = @sidActivo;
GO

PRINT '--- [4] sp_SearchActiveSales @SearchTerm=''NV-4002'' ---';
EXEC sp_SearchActiveSales @SearchTerm = 'NV-4002';
GO

DECLARE @dniCli VARCHAR(8);
SELECT TOP 1 @dniCli = c.dni
FROM SaleHeader sh
INNER JOIN Customer c ON c.customer_id = sh.customer_id
WHERE sh.status = 1;

PRINT '--- [5] sp_SearchActiveSales @SearchTerm=''' + @dniCli + ''' (DNI cliente) ---';
EXEC sp_SearchActiveSales @SearchTerm = @dniCli;
GO

PRINT '--- [6] sp_SearchInactiveSales @SearchTerm=''NV-5004'' ---';
EXEC sp_SearchInactiveSales @SearchTerm = 'NV-5004';
GO

PRINT '--------------------------------------------------';
PRINT 'Pruebas de SPs finalizadas.';
GO

-- ==============================================================================
-- 5. PRUEBAS NEGATIVAS - VALIDACIÓN DE RESTRICCIONES
--    Usamos TRY/CATCH + ROLLBACK para no afectar datos válidos
-- ==============================================================================

-- 5a. FK_SaleHeader_PaymentType inválido
BEGIN TRANSACTION
BEGIN TRY
    INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
    VALUES (999, 1, 2, 'NV-TEST-00000001', GETDATE(), 100.00, 1);
    PRINT '✗ ERROR: Se insertó con payment_type_id inválido (FK_SaleHeader_PaymentType)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - FK_SaleHeader_PaymentType rechazó payment_type_id=999: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5b. FK_SaleHeader_Customer inválido
BEGIN TRANSACTION
BEGIN TRY
    INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
    VALUES (1, 99999, 2, 'NV-TEST-00000002', GETDATE(), 100.00, 1);
    PRINT '✗ ERROR: Se insertó con customer_id inválido (FK_SaleHeader_Customer)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - FK_SaleHeader_Customer rechazó customer_id=99999: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5c. FK_SaleHeader_User inválido
BEGIN TRANSACTION
BEGIN TRY
    INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
    VALUES (1, 1, 99999, 'NV-TEST-00000003', GETDATE(), 100.00, 1);
    PRINT '✗ ERROR: Se insertó con user_id inválido (FK_SaleHeader_User)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - FK_SaleHeader_User rechazó user_id=99999: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5d. UQ_SaleHeader_SaleNumber duplicado
BEGIN TRANSACTION
BEGIN TRY
    INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
    VALUES (1, 1, 2, 'NV-0002-00000001', GETDATE(), 100.00, 1); -- ya existe
    PRINT '✗ ERROR: Se insertó con sale_number duplicado (UQ_SaleHeader_SaleNumber)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - UQ_SaleHeader_SaleNumber rechazó duplicado: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5e. CHK_SaleHeader_TotalSale negativo
BEGIN TRANSACTION
BEGIN TRY
    INSERT INTO SaleHeader (payment_type_id, customer_id, user_id, sale_number, sale_date, total_sale, status)
    VALUES (1, 1, 2, 'NV-TEST-00000004', GETDATE(), -10.00, 1);
    PRINT '✗ ERROR: Se insertó con total_sale negativo (CHK_SaleHeader_TotalSale)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - CHK_SaleHeader_TotalSale rechazó total_sale < 0: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5f. FK_SaleDetail_SaleHeader inválido
BEGIN TRANSACTION
BEGIN TRY
    INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
    VALUES (99999, 1, 1, 100.00);
    PRINT '✗ ERROR: Se insertó con sale_id inválido (FK_SaleDetail_SaleHeader)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - FK_SaleDetail_SaleHeader rechazó sale_id=99999: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5g. FK_SaleDetail_Product inválido
BEGIN TRANSACTION
BEGIN TRY
    DECLARE @sidVal INT;
    SELECT TOP 1 @sidVal = sale_id FROM SaleHeader;
    INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
    VALUES (@sidVal, 99999, 1, 100.00);
    PRINT '✗ ERROR: Se insertó con product_id inválido (FK_SaleDetail_Product)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - FK_SaleDetail_Product rechazó product_id=99999: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5h. CHK_SaleDetail_Quantity = 0
BEGIN TRANSACTION
BEGIN TRY
    DECLARE @sidVal2 INT;
    SELECT TOP 1 @sidVal2 = sale_id FROM SaleHeader;
    INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
    VALUES (@sidVal2, 1, 0, 100.00);
    PRINT '✗ ERROR: Se insertó con quantity=0 (CHK_SaleDetail_Quantity)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - CHK_SaleDetail_Quantity rechazó quantity=0: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5i. CHK_SaleDetail_Quantity negativo
BEGIN TRANSACTION
BEGIN TRY
    DECLARE @sidVal3 INT;
    SELECT TOP 1 @sidVal3 = sale_id FROM SaleHeader;
    INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
    VALUES (@sidVal3, 1, -5, 100.00);
    PRINT '✗ ERROR: Se insertó con quantity negativo (CHK_SaleDetail_Quantity)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - CHK_SaleDetail_Quantity rechazó quantity<0: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5j. CHK_SaleDetail_Price negativo
BEGIN TRANSACTION
BEGIN TRY
    DECLARE @sidVal4 INT;
    SELECT TOP 1 @sidVal4 = sale_id FROM SaleHeader;
    INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
    VALUES (@sidVal4, 1, 1, -1.00);
    PRINT '✗ ERROR: Se insertó con price negativo (CHK_SaleDetail_Price)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - CHK_SaleDetail_Price rechazó price<0: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

-- 5k. UQ_SaleDetail_Sale_Product duplicado
BEGIN TRANSACTION
BEGIN TRY
    DECLARE @sidDup INT, @pidDup INT;
    SELECT TOP 1 @sidDup = sale_id, @pidDup = product_id FROM SaleDetail;
    INSERT INTO SaleDetail (sale_id, product_id, quantity, price)
    VALUES (@sidDup, @pidDup, 1, 100.00); -- duplicado (sale_id,product_id)
    PRINT '✗ ERROR: Se insertó con (sale_id,product_id) duplicado (UQ_SaleDetail_Sale_Product)';
    ROLLBACK TRANSACTION
END TRY
BEGIN CATCH
    PRINT '✓ OK - UQ_SaleDetail_Sale_Product rechazó duplicado: ' + ERROR_MESSAGE();
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
END CATCH
GO

PRINT '--------------------------------------------------';
PRINT 'Todas las pruebas negativas finalizadas.';
GO

-- ==============================================================================
-- 6. RESUMEN FINAL
-- ==============================================================================
PRINT '==================================================';
PRINT '6. RESUMEN FINAL';
PRINT '==================================================';

SELECT 'SaleHeader' AS Tabla, COUNT(*) AS Registros FROM SaleHeader;
SELECT 'SaleDetail' AS Tabla, COUNT(*) AS Registros FROM SaleDetail;
GO

PRINT 'Script SalesData.sql ejecutado correctamente.';
PRINT 'Las restricciones, FKs, unicidades y SPs fueron validados.';
GO
