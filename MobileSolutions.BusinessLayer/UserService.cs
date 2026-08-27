using MobileSolutions.DataLayer;

namespace MobileSolutions.BusinessLayer
{
    public class UserService
    {
        private readonly DatabaseConnection _databaseConnection;

        public UserService()
        {
            _databaseConnection = new DatabaseConnection();
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            // Business logic processing & stored procedure execution via DataLayer
            return true;
        }
    }
}

