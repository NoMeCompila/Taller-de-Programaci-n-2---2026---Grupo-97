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
