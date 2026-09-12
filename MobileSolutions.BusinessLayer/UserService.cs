using System;
using System.Collections.Generic;
using System.Linq;
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

        public (bool Success, string Message) CreateUser(User user)
        {
            if (user == null)
                return (false, "Los datos del usuario no pueden ser nulos.");
            if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Lastname))
                return (false, "El nombre y apellido son obligatorios.");
            if (string.IsNullOrWhiteSpace(user.Dni) || user.Dni.Length < 7 || user.Dni.Length > 8)
                return (false, "El DNI debe contener entre 7 y 8 dígitos.");
            if (string.IsNullOrWhiteSpace(user.Username))
                return (false, "El nombre de usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(user.Password))
                return (false, "La contraseña es obligatoria.");
            if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
                return (false, "Debe ingresar un correo electrónico válido.");
            if (user.ProfileId <= 0)
                return (false, "Debe seleccionar un perfil válido para el usuario.");

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
            if (string.IsNullOrWhiteSpace(user.Email) || !user.Email.Contains("@"))
                return (false, "Debe ingresar un correo electrónico válido.");
            if (user.ProfileId <= 0)
                return (false, "Debe seleccionar un perfil válido para el usuario.");

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

                    return (false, "Ya existe un registro con datos duplicados.");
                }

                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al actualizar el usuario: {ex.Message}");
            }
        }

        public (bool IsConnected, string? ErrorMessage) CheckDatabaseConnection()
        {
            return _dbConnection.TestConnection();
        }

        private static readonly List<User> _mockUsers = new()
        {
            new User { Username = "admin", ProfileName = "Administrator" },
            new User { Username = "fer", ProfileName = "Gerente" },
            new User { Username = "nico", ProfileName = "Vendedor" }
        };

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

            return _mockUsers.FirstOrDefault(u =>
                string.Equals(u.Username, username.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public User? GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            return _mockUsers.FirstOrDefault(u =>
                string.Equals(u.Username, username.Trim(), StringComparison.OrdinalIgnoreCase));
        }
    }
}
