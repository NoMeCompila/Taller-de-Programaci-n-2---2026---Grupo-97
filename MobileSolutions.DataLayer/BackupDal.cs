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
    }
}
