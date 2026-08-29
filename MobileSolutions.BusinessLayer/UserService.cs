namespace MobileSolutions.BusinessLayer
{
    public class UserService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            // Mockup credential validation
            return username == "fer" && password == "123";
        }
    }
}