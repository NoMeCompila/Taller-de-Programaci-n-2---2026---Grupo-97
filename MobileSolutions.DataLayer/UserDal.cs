using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MobileSolutions.DataLayer
{
    public class UserDal
    {
        private readonly DatabaseConnection _dbConnection;
        public UserDal()
        {
            _dbConnection = new DatabaseConnection();
        }

        private static int GetOrdinalSafe(SqlDataReader reader, params string[] columnNames)
        {
            foreach (var name in columnNames)
            {
                try
                {
                    return reader.GetOrdinal(name);
                }
                catch (IndexOutOfRangeException)
                {
                    // Continuar buscando con el siguiente alias
                }
            }
            return -1;
        }

        private static User MapUserFromReader(
            SqlDataReader reader,
            int ordUserId,
            int ordProfileId,
            int ordProfileName,
            int ordName,
            int ordLastname,
            int ordDni,
            int ordSex,
            int ordUsername,
            int ordEmail,
            int ordPhone,
            int ordAddress,
            int ordBirth,
            int ordNationality,
            int ordLocality,
            int ordRegisterDate)
        {
            return new User
            {
                UserId = ordUserId >= 0 && !reader.IsDBNull(ordUserId) ? reader.GetInt32(ordUserId) : 0,
                ProfileId = ordProfileId >= 0 && !reader.IsDBNull(ordProfileId) ? reader.GetInt32(ordProfileId) : 0,
                ProfileName = ordProfileName >= 0 && !reader.IsDBNull(ordProfileName) ? reader.GetString(ordProfileName) : string.Empty,
                Name = ordName >= 0 && !reader.IsDBNull(ordName) ? reader.GetString(ordName) : string.Empty,
                Lastname = ordLastname >= 0 && !reader.IsDBNull(ordLastname) ? reader.GetString(ordLastname) : string.Empty,
                Dni = ordDni >= 0 && !reader.IsDBNull(ordDni) ? reader.GetString(ordDni) : string.Empty,
                Sex = ordSex >= 0 && !reader.IsDBNull(ordSex) ? reader.GetString(ordSex) : string.Empty,
                Username = ordUsername >= 0 && !reader.IsDBNull(ordUsername) ? reader.GetString(ordUsername) : string.Empty,
                Email = ordEmail >= 0 && !reader.IsDBNull(ordEmail) ? reader.GetString(ordEmail) : string.Empty,
                Phone = ordPhone >= 0 && !reader.IsDBNull(ordPhone) ? reader.GetString(ordPhone) : null,
                Address = ordAddress >= 0 && !reader.IsDBNull(ordAddress) ? reader.GetString(ordAddress) : null,
                Birth = ordBirth >= 0 && !reader.IsDBNull(ordBirth) ? reader.GetDateTime(ordBirth) : DateTime.MinValue,
                Nationality = ordNationality >= 0 && !reader.IsDBNull(ordNationality) ? reader.GetString(ordNationality) : string.Empty,
                Locality = ordLocality >= 0 && !reader.IsDBNull(ordLocality) ? reader.GetString(ordLocality) : string.Empty,
                RegisterDate = ordRegisterDate >= 0 && !reader.IsDBNull(ordRegisterDate) ? reader.GetDateTime(ordRegisterDate) : DateTime.Now
            };
        }

        public List<User> GetActiveUsers()
        {
            var users = new List<User>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetActiveUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30; // 30 segundos de timeout estándar
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordProfileName = GetOrdinalSafe(reader, "Perfil", "profile_name", "description");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordLastname = GetOrdinalSafe(reader, "Apellido", "lastname");
                    int ordDni = GetOrdinalSafe(reader, "DNI", "dni");
                    int ordSex = GetOrdinalSafe(reader, "Sexo", "sex");
                    int ordUsername = GetOrdinalSafe(reader, "Usuario", "username");
                    int ordEmail = GetOrdinalSafe(reader, "Email", "email");
                    int ordPhone = GetOrdinalSafe(reader, "Telefono", "phone");
                    int ordAddress = GetOrdinalSafe(reader, "Direccion", "address");
                    int ordBirth = GetOrdinalSafe(reader, "Fecha Nacimiento", "birth");
                    int ordNationality = GetOrdinalSafe(reader, "Nacionalidad", "nationality");
                    int ordLocality = GetOrdinalSafe(reader, "Localidad", "locality");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordProfileId = GetOrdinalSafe(reader, "profile_id", "ProfileId");
                    int ordRegisterDate = GetOrdinalSafe(reader, "register_date", "RegisterDate");

                    while (reader.Read())
                    {
                        users.Add(MapUserFromReader(
                            reader,
                            ordUserId,
                            ordProfileId,
                            ordProfileName,
                            ordName,
                            ordLastname,
                            ordDni,
                            ordSex,
                            ordUsername,
                            ordEmail,
                            ordPhone,
                            ordAddress,
                            ordBirth,
                            ordNationality,
                            ordLocality,
                            ordRegisterDate));
                    }
                }
            }
            return users;
        }

        public List<User> GetInactiveUsers()
        {
            var users = new List<User>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetInactiveUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordProfileName = GetOrdinalSafe(reader, "Perfil", "profile_name", "description");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordLastname = GetOrdinalSafe(reader, "Apellido", "lastname");
                    int ordDni = GetOrdinalSafe(reader, "DNI", "dni");
                    int ordSex = GetOrdinalSafe(reader, "Sexo", "sex");
                    int ordUsername = GetOrdinalSafe(reader, "Usuario", "username");
                    int ordEmail = GetOrdinalSafe(reader, "Email", "email");
                    int ordPhone = GetOrdinalSafe(reader, "Telefono", "phone");
                    int ordAddress = GetOrdinalSafe(reader, "Direccion", "address");
                    int ordBirth = GetOrdinalSafe(reader, "Fecha Nacimiento", "birth");
                    int ordNationality = GetOrdinalSafe(reader, "Nacionalidad", "nationality");
                    int ordLocality = GetOrdinalSafe(reader, "Localidad", "locality");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordProfileId = GetOrdinalSafe(reader, "profile_id", "ProfileId");
                    int ordRegisterDate = GetOrdinalSafe(reader, "register_date", "RegisterDate");

                    while (reader.Read())
                    {
                        users.Add(MapUserFromReader(
                            reader,
                            ordUserId,
                            ordProfileId,
                            ordProfileName,
                            ordName,
                            ordLastname,
                            ordDni,
                            ordSex,
                            ordUsername,
                            ordEmail,
                            ordPhone,
                            ordAddress,
                            ordBirth,
                            ordNationality,
                            ordLocality,
                            ordRegisterDate));
                    }
                }
            }
            return users;
        }

        public List<User> SearchActiveUsers(string? searchTerm)
        {
            var users = new List<User>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchActiveUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                // Parámetro seguro para prevenir inyección SQL
                object dbValue = string.IsNullOrWhiteSpace(searchTerm)
                    ? DBNull.Value
                    : searchTerm.Trim();

                command.Parameters.Add(new SqlParameter("@SearchTerm", SqlDbType.NVarChar, 100)
                {
                    Value = dbValue
                });

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordProfileName = GetOrdinalSafe(reader, "Perfil", "profile_name", "description");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordLastname = GetOrdinalSafe(reader, "Apellido", "lastname");
                    int ordDni = GetOrdinalSafe(reader, "DNI", "dni");
                    int ordSex = GetOrdinalSafe(reader, "Sexo", "sex");
                    int ordUsername = GetOrdinalSafe(reader, "Usuario", "username");
                    int ordEmail = GetOrdinalSafe(reader, "Email", "email");
                    int ordPhone = GetOrdinalSafe(reader, "Telefono", "phone");
                    int ordAddress = GetOrdinalSafe(reader, "Direccion", "address");
                    int ordBirth = GetOrdinalSafe(reader, "Fecha Nacimiento", "birth");
                    int ordNationality = GetOrdinalSafe(reader, "Nacionalidad", "nationality");
                    int ordLocality = GetOrdinalSafe(reader, "Localidad", "locality");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordProfileId = GetOrdinalSafe(reader, "profile_id", "ProfileId");
                    int ordRegisterDate = GetOrdinalSafe(reader, "register_date", "RegisterDate");

                    while (reader.Read())
                    {
                        users.Add(MapUserFromReader(
                            reader,
                            ordUserId,
                            ordProfileId,
                            ordProfileName,
                            ordName,
                            ordLastname,
                            ordDni,
                            ordSex,
                            ordUsername,
                            ordEmail,
                            ordPhone,
                            ordAddress,
                            ordBirth,
                            ordNationality,
                            ordLocality,
                            ordRegisterDate));
                    }
                }
            }
            return users;
        }

        public List<User> SearchInactiveUsers(string? searchTerm)
        {
            var users = new List<User>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchInactiveUsers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                object dbValue = string.IsNullOrWhiteSpace(searchTerm)
                    ? DBNull.Value
                    : searchTerm.Trim();

                command.Parameters.Add(new SqlParameter("@SearchTerm", SqlDbType.NVarChar, 100)
                {
                    Value = dbValue
                });

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordProfileName = GetOrdinalSafe(reader, "Perfil", "profile_name", "description");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordLastname = GetOrdinalSafe(reader, "Apellido", "lastname");
                    int ordDni = GetOrdinalSafe(reader, "DNI", "dni");
                    int ordSex = GetOrdinalSafe(reader, "Sexo", "sex");
                    int ordUsername = GetOrdinalSafe(reader, "Usuario", "username");
                    int ordEmail = GetOrdinalSafe(reader, "Email", "email");
                    int ordPhone = GetOrdinalSafe(reader, "Telefono", "phone");
                    int ordAddress = GetOrdinalSafe(reader, "Direccion", "address");
                    int ordBirth = GetOrdinalSafe(reader, "Fecha Nacimiento", "birth");
                    int ordNationality = GetOrdinalSafe(reader, "Nacionalidad", "nationality");
                    int ordLocality = GetOrdinalSafe(reader, "Localidad", "locality");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordProfileId = GetOrdinalSafe(reader, "profile_id", "ProfileId");
                    int ordRegisterDate = GetOrdinalSafe(reader, "register_date", "RegisterDate");

                    while (reader.Read())
                    {
                        users.Add(MapUserFromReader(
                            reader,
                            ordUserId,
                            ordProfileId,
                            ordProfileName,
                            ordName,
                            ordLastname,
                            ordDni,
                            ordSex,
                            ordUsername,
                            ordEmail,
                            ordPhone,
                            ordAddress,
                            ordBirth,
                            ordNationality,
                            ordLocality,
                            ordRegisterDate));
                    }
                }
            }
            return users;
        }

        public int CreateUser(User user)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_CreateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@profile_id", SqlDbType.Int).Value = user.ProfileId;
                command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = user.Name;
                command.Parameters.Add("@lastname", SqlDbType.VarChar, 100).Value = user.Lastname;
                command.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = user.Dni;
                command.Parameters.Add("@sex", SqlDbType.VarChar, 10).Value = user.Sex;
                command.Parameters.Add("@username", SqlDbType.VarChar, 100).Value = user.Username;
                command.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = user.Password;
                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = user.Email;
                command.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = (object?)user.Phone ?? DBNull.Value;
                command.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = (object?)user.Address ?? DBNull.Value;
                command.Parameters.Add("@birth", SqlDbType.Date).Value = user.Birth;
                command.Parameters.Add("@nationality", SqlDbType.VarChar, 100).Value = user.Nationality;
                command.Parameters.Add("@locality", SqlDbType.VarChar, 100).Value = user.Locality;

                connection.Open();
                object? result = command.ExecuteScalar();
                return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        public bool UpdateUser(User user)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_UpdateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@user_id", SqlDbType.Int).Value = user.UserId;
                command.Parameters.Add("@profile_id", SqlDbType.Int).Value = user.ProfileId;
                command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = user.Name;
                command.Parameters.Add("@lastname", SqlDbType.VarChar, 100).Value = user.Lastname;
                command.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = user.Dni;
                command.Parameters.Add("@sex", SqlDbType.VarChar, 10).Value = user.Sex;
                command.Parameters.Add("@username", SqlDbType.VarChar, 100).Value = user.Username;
                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = user.Email;
                command.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = (object?)user.Phone ?? DBNull.Value;
                command.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = (object?)user.Address ?? DBNull.Value;
                command.Parameters.Add("@birth", SqlDbType.Date).Value = user.Birth;
                command.Parameters.Add("@nationality", SqlDbType.VarChar, 100).Value = user.Nationality;
                command.Parameters.Add("@locality", SqlDbType.VarChar, 100).Value = user.Locality;
                command.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = string.IsNullOrWhiteSpace(user.Password) ? DBNull.Value : user.Password;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        public bool SoftDeleteUser(int userId)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_DeleteUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@user_id", SqlDbType.Int).Value = userId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        public bool ReactivateUser(int userId)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_ReactivateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@user_id", SqlDbType.Int).Value = userId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }
    }
}

