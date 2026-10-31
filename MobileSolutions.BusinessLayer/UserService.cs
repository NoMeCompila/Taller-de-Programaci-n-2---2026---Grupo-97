using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.DataLayer;

namespace MobileSolutions.BusinessLayer
{
    public enum UserRole
    {
        Administrator,
        Gerente,
        Vendedor
    }

    public class UserService
    {
        private readonly UserDal _userDal;
        private readonly DatabaseConnection _dbConnection;
        private readonly AuditDal _auditDal;

        public UserService()
        {
            _userDal = new UserDal();
            _dbConnection = new DatabaseConnection();
            _auditDal = new AuditDal();
        }

        public List<User> GetActiveUsers()
        {
            return _userDal.GetActiveUsers();
        }

        public List<User> GetInactiveUsers()
        {
            return _userDal.GetInactiveUsers();
        }

        public List<User> SearchUsers(string? searchTerm)
        {
            return SearchUsersByStatus(searchTerm, isInactiveMode: false);
        }

        public List<User> SearchUsersByStatus(string? searchTerm, bool isInactiveMode)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return isInactiveMode ? GetInactiveUsers() : GetActiveUsers();
            }

            string cleanSearchTerm = searchTerm.Trim();
            return isInactiveMode 
                ? _userDal.SearchInactiveUsers(cleanSearchTerm) 
                : _userDal.SearchActiveUsers(cleanSearchTerm);
        }

        public (bool Success, string Message) CreateUser(User user)
        {
            if (user == null)
                return (false, "Los campos del usuario no pueden estar vacÃ­os.");
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Lastname))
                return (false, "El nombre y apellido son obligatorios.");
            if (string.IsNullOrWhiteSpace(user.Dni) || user.Dni.Length < 7 || user.Dni.Length > 8)
                return (false, "El DNI debe contener entre 7 y 8 dÃ­gitos.");
            if (string.IsNullOrWhiteSpace(user.Username))
                return (false, "El nombre de usuario es obligatorio.");
            var passwordValidation = ValidatePasswordComplexity(user.Password, isRequired: true);
            if (!passwordValidation.IsValid)
                return (false, passwordValidation.Message);

            // Hash password with SHA-256 before persisting
            user.Password = ComputeSha256Hash(user.Password!);
            if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
                return (false, "Debe ingresar un correo electrÃ³nico vÃ¡lido.");
            if (string.IsNullOrWhiteSpace(user.Nationality) || string.IsNullOrWhiteSpace(user.Locality))
                return (false, "La nacionalidad y localidad son obligatorias.");
            if (string.IsNullOrWhiteSpace(user.Sex))
                return (false, "Seleccionar un Sexo es Obligatorio.");
            if (user.ProfileId <= 0)
                return (false, "Debe seleccionar un perfil vÃ¡lido para el usuario.");
            if (user.Birth.Date > DateTime.Today.AddYears(-18))
                return (false, "El usuario debe ser mayor de 18 aÃ±os.");
            try
            {
                int newId = _userDal.CreateUser(user);
                if (newId > 0)
                {
                    string actor = !string.IsNullOrWhiteSpace(CurrentSession.Username) ? CurrentSession.Username : "Sistema";
                    _auditDal.RecordAuditEvent("User Created", actor, "Success", $"Usuario creado: {user.Username} (ID: {newId})");
                    return (true, "Usuario agregado correctamente.");
                }

                return (false, "No se pudo registrar el usuario en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Manejo de errores por violaciÃ³n de restricciones UNIQUE (DNI, Username, Email)
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_User_DNI"))
                        return (false, "Ya existe un usuario con ese nÃºmero de DNI.");
                    if (ex.Message.Contains("UQ_User_Username"))
                        return (false, "El nombre de usuario ya se encuentra en uso.");
                    if (ex.Message.Contains("UQ_User_Email"))
                        return (false, "El correo electrÃ³nico ya estÃ¡ registrado en el sistema.");
                    if (ex.Message.Contains("UQ_User_Phone"))
                        return (false, "El telÃ©fono ya ha sido agregado anteriormente.");

                    return (false, "Ya existe un registro con datos duplicados.");
                }

                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al guardar el usuario: {ex.Message}");
            }
        }

        public (bool Success, string Message) UpdateUser(User user)
        {
            if (user == null)
                return (false, "Los datos del usuario no pueden ser nulos.");
            if (user.UserId <= 0)
                return (false, "Identificador de usuario no vÃ¡lido para la actualizaciÃ³n.");
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Lastname))
                return (false, "El nombre y apellido son obligatorios.");
            if (string.IsNullOrWhiteSpace(user.Dni) || user.Dni.Length < 7 || user.Dni.Length > 8)
                return (false, "El DNI debe contener entre 7 y 8 dÃ­gitos.");
            if (string.IsNullOrWhiteSpace(user.Username))
                return (false, "El nombre de usuario es obligatorio.");
            if (!string.IsNullOrWhiteSpace(user.Password))
            {
                var passwordValidation = ValidatePasswordComplexity(user.Password, isRequired: false);
                if (!passwordValidation.IsValid)
                    return (false, passwordValidation.Message);

                // Hash password with SHA-256 before persisting
                user.Password = ComputeSha256Hash(user.Password);
            }
            if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
                return (false, "Debe ingresar un correo electrÃ³nico vÃ¡lido.");
            if (string.IsNullOrWhiteSpace(user.Nationality) || string.IsNullOrWhiteSpace(user.Locality))
                return (false, "La nacionalidad y localidad son obligatorias.");
            if (string.IsNullOrWhiteSpace(user.Sex))
                return (false, "Seleccionar un Sexo es Obligatorio.");
            if (user.ProfileId <= 0)
                return (false, "Debe seleccionar un perfil vÃ¡lido para el usuario.");
            if (user.Birth.Date > DateTime.Today.AddYears(-18))
                return (false, "El usuario debe ser mayor de 18 aÃ±os.");

            try
            {
                bool updated = _userDal.UpdateUser(user);
                if (updated)
                {
                    string actor = !string.IsNullOrWhiteSpace(CurrentSession.Username) ? CurrentSession.Username : "Sistema";
                    _auditDal.RecordAuditEvent("User Modified", actor, "Success", $"Usuario modificado: {user.Username} (ID: {user.UserId})");
                    return (true, "Usuario actualizado correctamente.");
                }

                return (false, "No se pudo actualizar el usuario en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Manejo de errores por violaciÃ³n de restricciones UNIQUE (DNI, Username, Email)
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_User_DNI"))
                        return (false, "Ya existe un usuario con ese nÃºmero de DNI.");
                    if (ex.Message.Contains("UQ_User_Username"))
                        return (false, "El nombre de usuario ya se encuentra en uso.");
                    if (ex.Message.Contains("UQ_User_Email"))
                        return (false, "El correo electrÃ³nico ya estÃ¡ registrado en el sistema.");
                    if (ex.Message.Contains("UQ_User_Phone"))
                        return (false, "El telÃ©fono ya ha sido agregado anteriormente.");

                    return (false, "Ya existe un registro con datos duplicados.");
                }

                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al intentar actualizar el usuario: {ex.Message}");
            }
        }

        public (bool Success, string Message) SoftDeleteUser(int userId)
        {
            if (userId <= 0)
            {
                return (false, "Identificador de usuario no vÃ¡lido para la baja lÃ³gica.");
            }

            try
            {
                bool deleted = _userDal.SoftDeleteUser(userId);
                if (deleted)
                {
                    string actor = !string.IsNullOrWhiteSpace(CurrentSession.Username) ? CurrentSession.Username : "Sistema";
                    _auditDal.RecordAuditEvent("User Modified", actor, "Success", $"Baja lÃ³gica de usuario ID: {userId}");
                    return (true, "Usuario dado de baja correctamente.");
                }

                return (false, "No se pudo dar de baja al usuario en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al dar de baja al usuario: {ex.Message}");
            }
        }

        public (bool Success, string Message) ReactivateUser(int userId)
        {
            if (userId <= 0)
            {
                return (false, "Identificador de usuario no vÃ¡lido para la reactivaciÃ³n.");
            }

            try
            {
                bool reactivated = _userDal.ReactivateUser(userId);
                if (reactivated)
                {
                    string actor = !string.IsNullOrWhiteSpace(CurrentSession.Username) ? CurrentSession.Username : "Sistema";
                    _auditDal.RecordAuditEvent("User Modified", actor, "Success", $"ReactivaciÃ³n de usuario ID: {userId}");
                    return (true, "Usuario reactivado correctamente.");
                }

                return (false, "No se pudo reactivar el usuario en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al reactivar el usuario: {ex.Message}");
            }
        }

        public (bool IsConnected, string? ErrorMessage) CheckDatabaseConnection()
        {
            return _dbConnection.TestConnection();
        }

        /// <summary>
        /// Valida las reglas de complejidad de contraseÃ±a:
        /// - MÃ­nimo 8 caracteres
        /// - Al menos 1 letra mayÃºscula
        /// - Al menos 1 sÃ­mbolo especial
        /// </summary>
        public (bool IsValid, string Message) ValidatePasswordComplexity(string? password, bool isRequired = true)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return isRequired
                    ? (false, "La contraseÃ±a es obligatoria.")
                    : (true, string.Empty);
            }

            if (password.Length < 8)
            {
                return (false, "La contraseÃ±a debe contener al menos 8 caracteres.");
            }

            if (!password.Any(char.IsUpper))
            {
                return (false, "La contraseÃ±a debe contener al menos una letra mayÃºscula.");
            }

            if (!password.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                return (false, "La contraseÃ±a debe contener al menos un carÃ¡cter especial (ej. !@#$%^&*).");
            }

            return (true, string.Empty);
        }

        /// <summary>
        /// Genera el resumen criptogrÃ¡fico SHA-256 en formato hexadecimal en minÃºsculas (64 caracteres).
        /// </summary>
        public static string ComputeSha256Hash(string rawData)
        {
            if (string.IsNullOrEmpty(rawData))
            {
                return string.Empty;
            }

            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(rawData));
            StringBuilder builder = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }

        public (bool Success, string Message, User? User) Login(string usernameOrEmail, string password)
        {
            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
            {
                _auditDal.RecordAuditEvent("Login", string.IsNullOrWhiteSpace(usernameOrEmail) ? "Desconocido" : usernameOrEmail.Trim(), "Failure", "Campos de usuario o contraseÃ±a vacÃ­os");
                return (false, "Por favor ingrese usuario y contraseÃ±a.", null);
            }

            try
            {
                string hashedPassword = ComputeSha256Hash(password);
                User? user = _userDal.ValidateLogin(usernameOrEmail.Trim(), hashedPassword);
                if (user == null)
                {
                    _auditDal.RecordAuditEvent("Login", usernameOrEmail.Trim(), "Failure", "Usuario o contraseÃ±a invÃ¡lidos o cuenta inactiva");
                    return (false, "Usuario o contraseÃ±a no vÃ¡lidos, o la cuenta estÃ¡ inactiva.", null);
                }

                _auditDal.RecordAuditEvent("Login", user.Username, "Success", "Inicio de sesiÃ³n correcto");
                return (true, "Inicio de sesiÃ³n correcto.", user);
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error al conectar con la base de datos: {ex.Message}", null);
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado durante la autenticaciÃ³n: {ex.Message}", null);
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            return GetUser(username, password) != null;
        }

        public User? GetUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            string hashedPassword = ComputeSha256Hash(password);
            return _userDal.ValidateLogin(username.Trim(), hashedPassword);
        }

        public User? GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            return _userDal.GetActiveUsers().FirstOrDefault(u =>
                string.Equals(u.Username, username.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public (bool Success, string Message) RequestPasswordReset(string emailOrUsername)
        {
            if (string.IsNullOrWhiteSpace(emailOrUsername))
            {
                return (false, "Por favor ingrese su correo electrÃ³nico o nombre de usuario.");
            }

            try
            {
                // 1. Generar cÃ³digo numÃ©rico OTP de 6 dÃ­gitos seguro
                string otp = PasswordResetService.GenerateNumericOtp();

                // 2. Persistir en base de datos con expiraciÃ³n de 15 minutos
                var (saved, destinationEmail) = _userDal.SavePasswordResetOtp(emailOrUsername.Trim(), otp);
                if (!saved || string.IsNullOrWhiteSpace(destinationEmail))
                {
                    return (false, "No se encontrÃ³ ningÃºn usuario activo con el correo o usuario indicado.");
                }

                // 3. Enviar correo vÃ­a MailKit / MimeKit
                var (sent, errorMessage) = PasswordResetService.SendResetOtpEmail(destinationEmail, otp);
                if (!sent)
                {
                    return (false, $"CÃ³digo generado pero ocurriÃ³ un error al enviar el correo: {errorMessage}");
                }

                return (true, "CÃ³digo de verificaciÃ³n enviado exitosamente a tu correo registrado.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error al conectar con la base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al solicitar restablecimiento: {ex.Message}");
            }
        }

        public (bool Success, string Message) CompletePasswordReset(string emailOrUsername, string otpCode, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(emailOrUsername))
            {
                return (false, "Debe ingresar el correo o nombre de usuario.");
            }

            if (string.IsNullOrWhiteSpace(otpCode))
            {
                return (false, "Debe ingresar el cÃ³digo de verificaciÃ³n de 6 dÃ­gitos.");
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                return (false, "Debe ingresar la nueva contraseÃ±a.");
            }

            // 1. Validar reglas de complejidad de la nueva contraseÃ±a
            var (isValid, complexityMessage) = ValidatePasswordComplexity(newPassword, isRequired: true);
            if (!isValid)
            {
                return (false, complexityMessage);
            }

            try
            {
                // 2. Hashear la nueva contraseÃ±a con SHA-256
                string hashedNewPassword = ComputeSha256Hash(newPassword);

                // 3. Validar token no expirado y actualizar en base de datos
                bool updated = _userDal.ResetPasswordWithOtp(emailOrUsername.Trim(), otpCode.Trim(), hashedNewPassword);
                if (!updated)
                {
                    return (false, "El cÃ³digo de verificaciÃ³n es incorrecto, no coincide o ha expirado (15 minutos).");
                }

                return (true, "ContraseÃ±a actualizada correctamente. Ya puede iniciar sesiÃ³n con sus nuevas credenciales.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error al conectar con la base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al actualizar la contraseÃ±a: {ex.Message}");
            }
        }
    
        public User? GetUserByIdOrUsername(int userId, string? username = null)
        {
            var activeUsers = _userDal.GetActiveUsers();
            if (userId > 0)
            {
                var match = activeUsers.FirstOrDefault(u => u.UserId == userId);
                if (match != null) return match;
            }

            if (!string.IsNullOrWhiteSpace(username))
            {
                var match = activeUsers.FirstOrDefault(u => string.Equals(u.Username, username.Trim(), StringComparison.OrdinalIgnoreCase));
                if (match != null) return match;
            }

            var inactiveUsers = _userDal.GetInactiveUsers();
            if (userId > 0)
            {
                var match = inactiveUsers.FirstOrDefault(u => u.UserId == userId);
                if (match != null) return match;
            }

            if (!string.IsNullOrWhiteSpace(username))
            {
                var match = inactiveUsers.FirstOrDefault(u => string.Equals(u.Username, username.Trim(), StringComparison.OrdinalIgnoreCase));
                if (match != null) return match;
            }

            return null;
        }
    }
}