using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace MobileSolutions.DataLayer
{
    /// <summary>
    /// Provee mecanismos de auto-aprovisionamiento de la base de datos local (LocalDB)
    /// para instalaciones limpias en otras PCs con Windows 10 y Windows 11.
    /// </summary>
    public static class DatabaseInitializer
    {
        private const string DatabaseName = "MobileSolutionsDB";
        private const string LocalDbInstance = "MSSQLLocalDB";

        /// <summary>
        /// Verifica que la instancia LocalDB esté activa y que la base de datos MobileSolutionsDB exista.
        /// Si no existe, la crea automáticamente restaurando el backup semilla (MobileSolutions_Initial.bak)
        /// o ejecutando los scripts SQL de inicialización.
        /// </summary>
        public static void EnsureDatabaseReady()
        {
            EnsureLocalDbInstanceRunning();

            var dbConn = new DatabaseConnection();
            using SqlConnection masterConn = dbConn.GetMasterConnection();
            masterConn.Open();

            if (DatabaseExists(masterConn))
            {
                return;
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string backupFilePath = FindSeedBackupFile(baseDir);

            if (!string.IsNullOrEmpty(backupFilePath) && File.Exists(backupFilePath))
            {
                RestoreSeedBackup(masterConn, backupFilePath);
                return;
            }

            string scriptsFolder = FindScriptsFolder(baseDir);
            if (!string.IsNullOrEmpty(scriptsFolder) && Directory.Exists(scriptsFolder))
            {
                CreateDatabaseFromScripts(masterConn, dbConn, scriptsFolder);
            }
        }

        private static void EnsureLocalDbInstanceRunning()
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = "sqllocaldb",
                    Arguments = $"start {LocalDbInstance}",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                using Process? process = Process.Start(startInfo);
                process?.WaitForExit(15000);
            }
            catch
            {
                // Si sqllocaldb no está en el PATH o ya está corriendo, la conexión posterior determinará el estado.
            }
        }

        private static bool DatabaseExists(SqlConnection masterConn)
        {
            using var cmd = new SqlCommand(
                "SELECT COUNT(*) FROM sys.databases WHERE name = @DbName;",
                masterConn);
            cmd.Parameters.AddWithValue("@DbName", DatabaseName);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        private static string FindSeedBackupFile(string baseDir)
        {
            string[] candidatePaths =
            {
                Path.Combine(baseDir, "Database", "MobileSolutions_Initial.bak"),
                Path.Combine(baseDir, "Installer", "Database", "MobileSolutions_Initial.bak"),
                Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", "..", "Installer", "Database", "MobileSolutions_Initial.bak"))
            };

            foreach (string path in candidatePaths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }

            return string.Empty;
        }

        private static string FindScriptsFolder(string baseDir)
        {
            string[] candidateDirs =
            {
                Path.Combine(baseDir, "ScriptsSQL"),
                Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", "..", "MobileSolutions.DataLayer", "ScriptsSQL"))
            };

            foreach (string dir in candidateDirs)
            {
                if (Directory.Exists(dir))
                {
                    return dir;
                }
            }

            return string.Empty;
        }

        private static void RestoreSeedBackup(SqlConnection masterConn, string backupFilePath)
        {
            string dataFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "MobileSolutions",
                "Data");

            Directory.CreateDirectory(dataFolder);

            string mdfPath = Path.Combine(dataFolder, $"{DatabaseName}.mdf");
            string ldfPath = Path.Combine(dataFolder, $"{DatabaseName}_log.ldf");

            const string restoreSql = @"
                RESTORE DATABASE [MobileSolutionsDB]
                FROM DISK = @BackupPath
                WITH MOVE N'MobileSolutionsDB' TO @MdfPath,
                     MOVE N'MobileSolutionsDB_log' TO @LdfPath,
                     REPLACE,
                     RECOVERY;";

            using var cmd = new SqlCommand(restoreSql, masterConn)
            {
                CommandTimeout = 300
            };
            cmd.Parameters.Add(new SqlParameter("@BackupPath", SqlDbType.NVarChar, 500) { Value = backupFilePath });
            cmd.Parameters.Add(new SqlParameter("@MdfPath", SqlDbType.NVarChar, 500) { Value = mdfPath });
            cmd.Parameters.Add(new SqlParameter("@LdfPath", SqlDbType.NVarChar, 500) { Value = ldfPath });

            cmd.ExecuteNonQuery();
            SqlConnection.ClearAllPools();
        }

        private static void CreateDatabaseFromScripts(SqlConnection masterConn, DatabaseConnection dbConn, string scriptsFolder)
        {
            using (var createCmd = new SqlCommand($"CREATE DATABASE [{DatabaseName}];", masterConn))
            {
                createCmd.CommandTimeout = 120;
                createCmd.ExecuteNonQuery();
            }

            SqlConnection.ClearAllPools();

            string[] orderedScripts =
            {
                "CreateDB.sql",
                "CustomerSP.sql",
                "ProductSP.sql",
                "UserSP.sql",
                "SaleSP.sql",
                "SellerReportSP.sql",
                "ManagerReportSP.sql",
                "AuditAndGovernanceSP.sql",
                "BackupRestoreSP.sql",
                "usersData.sql",
                "customersData.sql",
                "productData.sql",
                "SalesData.sql",
                "MigratePasswordsToSha256.sql"
            };

            using SqlConnection appDbConn = dbConn.GetConnection();
            appDbConn.Open();

            foreach (string scriptName in orderedScripts)
            {
                string fullPath = Path.Combine(scriptsFolder, scriptName);
                if (!File.Exists(fullPath))
                {
                    continue;
                }

                string scriptContent = File.ReadAllText(fullPath, Encoding.UTF8);
                IEnumerable<string> batches = Regex.Split(
                    scriptContent,
                    @"^\s*GO\s*$",
                    RegexOptions.Multiline | RegexOptions.IgnoreCase);

                foreach (string batch in batches)
                {
                    if (string.IsNullOrWhiteSpace(batch))
                    {
                        continue;
                    }

                    using var batchCmd = new SqlCommand(batch, appDbConn)
                    {
                        CommandTimeout = 120
                    };
                    batchCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
