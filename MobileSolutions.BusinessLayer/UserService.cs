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

        public UserService()
        {
            _userDal = new UserDal();
            _dbConnection = new DatabaseConnection();
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
                return (false, "Los campos del usuario no pueden estar vacíos.");
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Lastname))
                return (false, "El nombre y apellido son obligatorios.");
            if (string.IsNullOrWhiteSpace(user.Dni) || user.Dni.Length < 7 || user.Dni.Length > 8)
                return (false, "El DNI debe contener entre 7 y 8 dígitos.");
            if (string.IsNullOrWhiteSpace(user.Username))
                return (false, "El nombre de usuario es obligatorio.");
            var passwordValidation = ValidatePasswordComplexity(user.Password, isRequired: true);
            if (!passwordValidation.IsValid)
                return (false, passwordValidation.Message);

            // Hash password with SHA-256 before persisting
            user.Password = ComputeSha256Hash(user.Password!);
            if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
                return (false, "Debe ingresar un correo electrónico válido.");
            if (user.ProfileId <= 0)
                return (false, "Debe seleccionar un perfil válido para el usuario.");
            if (user.Birth.Date > DateTime.Today.AddYears(-18))
                return (false, "El usuario debe ser mayor de 18 años.");
            try
            {
                int newId = _userDal.CreateUser(user);
                if (newId > 0)
                {
                    return (true, "Usuario agregado correctamente.");
                }

                return (false, "No se pudo registrar el usuario en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Manejo de errores por violación de restricciones UNIQUE (DNI, Username, Email)
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_User_DNI"))
                        return (false, "Ya existe un usuario con ese número de DNI.");
                    if (ex.Message.Contains("UQ_User_Username"))
                        return (false, "El nombre de usuario ya se encuentra en uso.");
                    if (ex.Message.Contains("UQ_User_Email"))
                        return (false, "El correo electrónico ya está registrado en el sistema.");
                    if (ex.Message.Contains("UQ_User_Phone"))
                        return (false, "El teléfono ya ha sido agregado anteriormente.");

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
                return (false, "Identificador de usuario no válido para la actualización.");
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Lastname))
                return (false, "El nombre y apellido son obligatorios.");
            if (string.IsNullOrWhiteSpace(user.Dni) || user.Dni.Length < 7 || user.Dni.Length > 8)
                return (false, "El DNI debe contener entre 7 y 8 dígitos.");
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
                return (false, "Debe ingresar un correo electrónico válido.");
            if (user.ProfileId <= 0)
                return (false, "Debe seleccionar un perfil válido para el usuario.");
            if (user.Birth.Date > DateTime.Today.AddYears(-18))
                return (false, "El usuario debe ser mayor de 18 años.");

            try
            {
                bool updated = _userDal.UpdateUser(user);
                if (updated)
                {
                    return (true, "Usuario actualizado correctamente.");
                }

                return (false, "No se pudo actualizar el usuario en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Manejo de errores por violación de restricciones UNIQUE (DNI, Username, Email)
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("UQ_User_DNI"))
                        return (false, "Ya existe un usuario con ese número de DNI.");
                    if (ex.Message.Contains("UQ_User_Username"))
                        return (false, "El nombre de usuario ya se encuentra en uso.");
                    if (ex.Message.Contains("UQ_User_Email"))
                        return (false, "El correo electrónico ya está registrado en el sistema.");
                    if (ex.Message.Contains("UQ_User_Phone"))
                        return (false, "El teléfono ya ha sido agregado anteriormente.");

                    return (false, "Ya existe un registro con datos duplicados.");
                }

                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al actualizar el usuario: {ex.Message}");
            }
        }

        public (bool Success, string Message) SoftDeleteUser(int userId)
        {
            if (userId <= 0)
            {
                return (false, "Identificador de usuario no válido para la baja lógica.");
            }

            try
            {
                bool deleted = _userDal.SoftDeleteUser(userId);
                if (deleted)
                {
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
                return (false, "Identificador de usuario no válido para la reactivación.");
            }

            try
            {
                bool reactivated = _userDal.ReactivateUser(userId);
                if (reactivated)
                {
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
        /// Valida las reglas de complejidad de contraseña:
        /// - Mínimo 8 caracteres
        /// - Al menos 1 letra mayúscula
        /// - Al menos 1 símbolo especial
        /// </summary>
        public (bool IsValid, string Message) ValidatePasswordComplexity(string? password, bool isRequired = true)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return isRequired
                    ? (false, "La contraseña es obligatoria.")
                    : (true, string.Empty);
            }

            if (password.Length < 8)
            {
                return (false, "La contraseña debe contener al menos 8 caracteres.");
            }

            if (!password.Any(char.IsUpper))
            {
                return (false, "La contraseña debe contener al menos una letra mayúscula.");
            }

            if (!password.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                return (false, "La contraseña debe contener al menos un carácter especial (ej. !@#$%^&*).");
            }

            return (true, string.Empty);
        }

        /// <summary>
        /// Genera el resumen criptográfico SHA-256 en formato hexadecimal en minúsculas (64 caracteres).
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
                return (false, "Por favor ingrese usuario y contraseña.", null);
            }

            try
            {
                string hashedPassword = ComputeSha256Hash(password);
                User? user = _userDal.ValidateLogin(usernameOrEmail.Trim(), hashedPassword);
                if (user == null)
                {
                    return (false, "Usuario o contraseña no válidos, o la cuenta está inactiva.", null);
                }

                return (true, "Inicio de sesión correcto.", user);
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error al conectar con la base de datos: {ex.Message}", null);
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado durante la autenticación: {ex.Message}", null);
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
    }
}

