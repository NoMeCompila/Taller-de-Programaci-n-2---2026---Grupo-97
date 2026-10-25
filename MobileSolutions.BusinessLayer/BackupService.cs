using System;
using System.IO;
using MobileSolutions.DataLayer;

namespace MobileSolutions.BusinessLayer
{
    public class BackupService
    {
        private readonly BackupDal _backupDal;

        public BackupService()
        {
            _backupDal = new BackupDal();
        }

        public BackupService(BackupDal backupDal)
        {
            _backupDal = backupDal ?? throw new ArgumentNullException(nameof(backupDal));
        }

        /// <summary>
        /// Valida privilegios de administrador y genera el archivo .bak en el directorio indicado.
        /// Reemplaza automáticamente barras '/' por guiones '-' para compatibilidad con el sistema de archivos de Windows.
        /// </summary>
        /// <param name="destinationDirectory">Directorio destino seleccionado por el usuario.</param>
        /// <param name="backupFileName">Nombre del archivo de backup.</param>
        /// <returns>La ruta física absoluta completa del archivo generado.</returns>
        public string CreateBackup(string destinationDirectory, string backupFileName)
        {
            ValidateAdminAccess();

            if (string.IsNullOrWhiteSpace(destinationDirectory))
            {
                throw new ArgumentException("Debe especificar una ruta destino válida para el backup.", nameof(destinationDirectory));
            }

            if (!Directory.Exists(destinationDirectory))
            {
                throw new DirectoryNotFoundException($"El directorio destino especificado no existe: {destinationDirectory}");
            }

            if (string.IsNullOrWhiteSpace(backupFileName))
            {
                throw new ArgumentException("El nombre del archivo de backup no puede estar vacío.", nameof(backupFileName));
            }

            // Reemplazo estricto de barras '/' por guiones '-' para evitar errores de sintaxis en el sistema de archivos
            string physicalFileName = backupFileName.Replace('/', '-');

            string fullBackupPath = Path.Combine(destinationDirectory, physicalFileName);

            _backupDal.ExecuteDatabaseBackup(fullBackupPath);

            return fullBackupPath;
        }

        private static void ValidateAdminAccess()
        {
            if (!CurrentSession.IsAuthenticated)
            {
                throw new UnauthorizedAccessException("Debe iniciar sesión para realizar copias de seguridad del sistema.");
            }

            // En la base de datos: Profile 1 = Administrador
            string profile = CurrentSession.ProfileName.Trim().ToLowerInvariant();
            string username = CurrentSession.Username.Trim().ToLowerInvariant();

            bool isAdmin = CurrentSession.ProfileId == 1 ||
                           profile == "administrador" ||
                           profile == "administrator" ||
                           profile == "admin" ||
                           username == "admin";

            if (!isAdmin)
            {
                throw new UnauthorizedAccessException("Acceso denegado: la generación de backups está restringida exclusivamente a Administradores.");
            }
        }
    }
}
