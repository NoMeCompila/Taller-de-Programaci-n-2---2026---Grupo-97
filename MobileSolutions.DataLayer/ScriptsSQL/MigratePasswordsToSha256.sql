USE MobileSolutionsDB;
GO

-- ==============================================================================
-- Script: MigratePasswordsToSha256.sql
-- Descripción: Migración de contraseñas existentes a SHA-256 (64 caracteres hex).
--              Es idempotente: solo convierte las contraseñas cuya longitud sea
--              distinta de 64 caracteres para no re-hashear datos ya procesados.
-- ==============================================================================

SET NOCOUNT ON;

UPDATE [User]
SET password = LOWER(CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', password), 2))
WHERE LEN(password) <> 64;

PRINT 'Contraseñas migradas a SHA-256 exitosamente.';
GO

