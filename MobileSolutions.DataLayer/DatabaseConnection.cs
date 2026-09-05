using System.Data;
using Microsoft.Data.SqlClient;

namespace MobileSolutions.DataLayer
{
    public class DatabaseConnection
    {
        private readonly string _connectionString;

        public DatabaseConnection()
        {
            _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=MobileSolutionsDB;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }


        // modify TestConnection method to return a tuple with
        // a boolean indicating if the connection was successful and a string containing the error message if it was not
        public (bool IsConnected, string? ErrorMessage) TestConnection()
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                return (connection.State == ConnectionState.Open, null);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}

