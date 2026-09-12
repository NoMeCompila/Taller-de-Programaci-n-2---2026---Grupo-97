using System.Data;
using Microsoft.Data.SqlClient;

namespace MobileSolutions.DataLayer
{
    public class DatabaseConnection
    {
        
        private string dbName ;
        private string dbServer;
        private string tConnection;
        private string tServerCert;

        public DatabaseConnection()
        {
            this.dbServer = "(localdb)\\MSSQLLocalDB";
            this.dbName = "MobileSolutionsDB";
            this.tConnection = "True";
            this.tServerCert = "True";
        }


        public SqlConnection GetConnection()
        {
            SqlConnection ConnString = new SqlConnection();

            try
            {
                ConnString.ConnectionString = $"Server={dbServer};" +
                    $"Database={dbName};" +
                    $"Trusted_Connection={tConnection};" +
                    $"TrustServerCertificate={tServerCert};";
            }
            catch (Exception ex)
            {
                ConnString = null;
                throw ex;
            }

            return ConnString;
        }


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

