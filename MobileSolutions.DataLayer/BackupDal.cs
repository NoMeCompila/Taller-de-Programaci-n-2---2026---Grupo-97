using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MobileSolutions.DataLayer
{
    public class BackupDal
    {
        private readonly DatabaseConnection _dbConnection;

        public BackupDal()
        {
            _dbConnection = new DatabaseConnection();
        }

        /// <summary>
        /// Ejecuta el Stored Procedure sp_CreateDatabaseBackup en SQL Server.
        /// </summary>
        /// <param name="fullBackupPath">Ruta absoluta completa incluyendo el nombre del archivo .bak</param>
        public void ExecuteDatabaseBackup(string fullBackupPath)
        {
            if (string.IsNullOrWhiteSpace(fullBackupPath))
            {
                throw new ArgumentException("La ruta de backup no puede estar vacía.", nameof(fullBackupPath));
            }

            using SqlConnection connection = _dbConnection.GetConnection();
            using SqlCommand command = new SqlCommand("dbo.sp_CreateDatabaseBackup", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 300 // Timeout extendido de 5 minutos para operaciones de backup de base de datos
            };

            command.Parameters.Add(new SqlParameter("@BackupPath", SqlDbType.NVarChar, 500)
            {
                Value = fullBackupPath
            });

            connection.Open();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Ejecuta la restauración de MobileSolutionsDB conectándose a la base de datos master,
        /// forzando SINGLE_USER para terminar conexiones existentes, restaurando con REPLACE y RECOVERY,
        /// y reestableciendo MULTI_USER para dejar la base disponible inmediatamente.
        /// </summary>
        /// <param name="fullBackupPath">Ruta absoluta del archivo .bak seleccionado.</param>
        public void ExecuteDatabaseRestore(string fullBackupPath)
        {
            if (string.IsNullOrWhiteSpace(fullBackupPath))
            {
                throw new ArgumentException("La ruta del archivo de backup (.bak) no puede estar vacía.", nameof(fullBackupPath));
            }

            // 1. Limpiar pools de conexión antes del restore para evitar bloqueos de clientes inactivos
            SqlConnection.ClearAllPools();

            const string restoreSql = @"
                RESTORE VERIFYONLY FROM DISK = @BackupPath;

                ALTER DATABASE [MobileSolutionsDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

                BEGIN TRY
                    RESTORE DATABASE [MobileSolutionsDB]
                    FROM DISK = @BackupPath
                    WITH REPLACE, RECOVERY;

                    ALTER DATABASE [MobileSolutionsDB] SET MULTI_USER;
                END TRY
                BEGIN CATCH
                    IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'MobileSolutionsDB' AND user_access_desc = 'SINGLE_USER')
                    BEGIN
                        ALTER DATABASE [MobileSolutionsDB] SET MULTI_USER;
                    END;
                    THROW;
                END CATCH";

            try
            {
                using SqlConnection masterConnection = _dbConnection.GetMasterConnection();
                using SqlCommand command = new SqlCommand(restoreSql, masterConnection)
                {
                    CommandType = CommandType.Text,
                    CommandTimeout = 300 // Timeout extendido de 5 minutos
                };

                command.Parameters.Add(new SqlParameter("@BackupPath", SqlDbType.NVarChar, 500)
                {
                    Value = fullBackupPath
                });

                masterConnection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                // 2. Limpiar pools nuevamente para que la aplicación reabra conexiones sobre la base restaurada
                SqlConnection.ClearAllPools();
            }
        }
    }
}
