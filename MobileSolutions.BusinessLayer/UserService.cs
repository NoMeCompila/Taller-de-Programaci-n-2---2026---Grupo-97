namespace MobileSolutions.BusinessLayer
{
    public enum UserRole
    {
        Administrator,
        Gerente,
        Vendedor
    }

    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserRole Role { get; set; }
    }

    public class UserService
    {
        private static readonly List<User> _mockUsers = new()
        {
            new User { Username = "admin", Password = "123", Role = UserRole.Administrator },
            new User { Username = "fer", Password = "123", Role = UserRole.Gerente },
            new User { Username = "nico", Password = "123", Role = UserRole.Vendedor }
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
                string.Equals(u.Username, username.Trim(), StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);
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