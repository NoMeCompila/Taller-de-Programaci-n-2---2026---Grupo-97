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
