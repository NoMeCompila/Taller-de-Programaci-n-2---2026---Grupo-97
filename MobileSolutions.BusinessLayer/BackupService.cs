using System;
using System.IO;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.DataLayer;

namespace MobileSolutions.BusinessLayer
{
    public class BackupService
    {
        private readonly BackupDal _backupDal;
        private readonly UserService _userService;
        private readonly AuditDal _auditDal;

        public BackupService()
        {
            _backupDal = new BackupDal();
            _userService = new UserService();
            _auditDal = new AuditDal();
        }

        public BackupService(BackupDal backupDal, UserService userService, AuditDal auditDal)
        {
            _backupDal = backupDal ?? throw new ArgumentNullException(nameof(backupDal));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _auditDal = auditDal ?? throw new ArgumentNullException(nameof(auditDal));
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

        /// <summary>
        /// Valida las credenciales del Primer Administrador (Paso 1 del Dual Auth).
        /// </summary>
        public (bool IsValid, string Message, User? User) ValidateAdminStep1(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return (false, "Por favor complete el usuario y contraseña del Primer Administrador.", null);
            }

            User? user = _userService.GetUser(username.Trim(), password);
            if (user == null)
            {
                return (false, "Credenciales inválidas del Administrador o la cuenta se encuentra inactiva.", null);
            }

            string profile = user.ProfileName.Trim().ToLowerInvariant();
            bool isAdmin = user.ProfileId == 1 ||
                           profile == "administrador" ||
                           profile == "administrator" ||
                           profile == "admin" ||
                           string.Equals(user.Username.Trim(), "admin", StringComparison.OrdinalIgnoreCase);

            if (!isAdmin)
            {
                return (false, "El usuario ingresado en el Paso 1 no posee rol de Administrador.", null);
            }

            return (true, "Administrador validado correctamente.", user);
        }

        /// <summary>
        /// Valida las credenciales del Segundo Autorizador (Paso 2 del Dual Auth: Gerente o segundo Administrador),
        /// garantizando la regla de validación cruzada (Cross-Auth): ambos autorizadores deben ser personas distintas.
        /// </summary>
        public (bool IsValid, string Message, User? User) ValidateStep2CoAuth(string auth2Username, string auth2Password, string admin1Username)
        {
            if (string.IsNullOrWhiteSpace(auth2Username) || string.IsNullOrWhiteSpace(auth2Password))
            {
                return (false, "Por favor complete el usuario y contraseña del Segundo Autorizador (Gerente).", null);
            }

            if (!string.IsNullOrWhiteSpace(admin1Username) &&
                string.Equals(auth2Username.Trim(), admin1Username.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return (false, "Validación Cruzada requerida: El segundo autorizador no puede ser el mismo usuario del Paso 1.", null);
            }

            User? user = _userService.GetUser(auth2Username.Trim(), auth2Password);
            if (user == null)
            {
                return (false, "Credenciales inválidas del Segundo Autorizador o la cuenta se encuentra inactiva.", null);
            }

            string profile = user.ProfileName.Trim().ToLowerInvariant();
            bool isAuthorized = user.ProfileId == 2 || user.ProfileId == 1 ||
                                profile == "gerente" || profile == "manager" ||
                                profile == "administrador" || profile == "administrator" || profile == "admin";

            if (!isAuthorized)
            {
                return (false, "El segundo autorizador debe poseer rol de Gerente o Administrador.", null);
            }

            return (true, "Segundo autorizador validado correctamente.", user);
        }

        /// <summary>
        /// Ejecuta la restauración completa del sistema verificando la doble autenticación cruzada (Cross-Auth Validation).
        /// </summary>
        public void RestoreDatabase(string backupFilePath, string admin1Username, string admin1Password, string auth2Username, string auth2Password)
        {
            ValidateAdminAccess();

            // 1. Validar Paso 1
            var step1 = ValidateAdminStep1(admin1Username, admin1Password);
            if (!step1.IsValid)
            {
                throw new UnauthorizedAccessException($"Paso 1 inválido: {step1.Message}");
            }

            // 2. Validar Paso 2 (Cross-Auth)
            var step2 = ValidateStep2CoAuth(auth2Username, auth2Password, admin1Username);
            if (!step2.IsValid)
            {
                throw new UnauthorizedAccessException($"Paso 2 inválido: {step2.Message}");
            }

            // 3. Validar archivo físico
            if (string.IsNullOrWhiteSpace(backupFilePath))
            {
                throw new ArgumentException("Debe seleccionar un archivo de backup (.bak).", nameof(backupFilePath));
            }

            if (!File.Exists(backupFilePath))
            {
                throw new FileNotFoundException($"El archivo de backup seleccionado no existe: {backupFilePath}");
            }

            if (!backupFilePath.EndsWith(".bak", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("El archivo seleccionado debe ser un respaldo válido con extensión .bak.", nameof(backupFilePath));
            }

            // 4. Ejecución en SQL Server
            _backupDal.ExecuteDatabaseRestore(backupFilePath);
        }

        /// <summary>
        /// Obtiene las marcas de tiempo del último Backup y último Restore registrados en el sistema.
        /// </summary>
        public (DateTime? LastBackup, DateTime? LastRestore) GetLastBackupAndRestoreInfo()
        {
            try
            {
                var metrics = _auditDal.GetAdminDashboardMetrics();
                return (metrics.LastBackupTimestamp, metrics.LastRestoreTimestamp);
            }
            catch
            {
                return (null, null);
            }
        }

        private static void ValidateAdminAccess()
        {
            if (!CurrentSession.IsAuthenticated)
            {
                throw new UnauthorizedAccessException("Debe iniciar sesión para realizar operaciones de base de datos.");
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
                throw new UnauthorizedAccessException("Acceso denegado: esta operación está restringida exclusivamente a Administradores.");
            }
        }
    }
}
