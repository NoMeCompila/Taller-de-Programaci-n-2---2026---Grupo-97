using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MobileSolutions.DataLayer
{
    internal class UserDal
    {
        private readonly DatabaseConnection _dbConnection;
        public UserDal()
        {
            _dbConnection = new DatabaseConnection();
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
                    // Obtenemos los ordinales una sola vez antes del bucle para optimizar rendimiento
                    int ordUserId = reader.GetOrdinal("user_id");
                    int ordProfileId = reader.GetOrdinal("profile_id");
                    int ordProfileName = reader.GetOrdinal("profile_name");
                    int ordName = reader.GetOrdinal("name");
                    int ordLastname = reader.GetOrdinal("lastname");
                    int ordDni = reader.GetOrdinal("dni");
                    int ordSex = reader.GetOrdinal("sex");
                    int ordUsername = reader.GetOrdinal("username");
                    int ordEmail = reader.GetOrdinal("email");
                    int ordPhone = reader.GetOrdinal("phone");
                    int ordAddress = reader.GetOrdinal("address");
                    int ordBirth = reader.GetOrdinal("birth");
                    int ordNationality = reader.GetOrdinal("nationality");
                    int ordLocality = reader.GetOrdinal("locality");
                    int ordRegisterDate = reader.GetOrdinal("register_date");
                    while (reader.Read())
                    {
                        var user = new User
                        {
                            UserId = reader.GetInt32(ordUserId),
                            ProfileId = reader.GetInt32(ordProfileId),
                            ProfileName = reader.GetString(ordProfileName),
                            Name = reader.GetString(ordName),
                            Lastname = reader.GetString(ordLastname),
                            Dni = reader.GetString(ordDni),
                            Sex = reader.GetString(ordSex),
                            Username = reader.GetString(ordUsername),
                            Email = reader.GetString(ordEmail),
                            Phone = reader.IsDBNull(ordPhone) ? null : reader.GetString(ordPhone),
                            Address = reader.IsDBNull(ordAddress) ? null : reader.GetString(ordAddress),
                            Birth = reader.GetDateTime(ordBirth),
                            Nationality = reader.GetString(ordNationality),
                            Locality = reader.GetString(ordLocality),
                            RegisterDate = reader.GetDateTime(ordRegisterDate)
                        };
                        users.Add(user);
                    }
                }
            }
            return users;
        }
    }
}
