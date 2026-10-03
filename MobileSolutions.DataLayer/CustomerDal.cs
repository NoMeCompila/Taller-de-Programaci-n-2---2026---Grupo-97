using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MobileSolutions.DataLayer
{
    public class CustomerDal
    {
        private readonly DatabaseConnection _dbConnection;

        public CustomerDal()
        {
            _dbConnection = new DatabaseConnection();
        }

        #region Métodos Auxiliares de Mapeo (Safe Mapping)

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

        private static Customer MapCustomerFromReader(
            SqlDataReader reader,
            int ordCustomerId,
            int ordName,
            int ordLastname,
            int ordDni,
            int ordSex,
            int ordEmail,
            int ordPhone,
            int ordAddress,
            int ordBirth,
            int ordNationality,
            int ordLocality,
            int ordRegisterDate)
        {
            return new Customer
            {
                CustomerId = ordCustomerId >= 0 && !reader.IsDBNull(ordCustomerId) ? reader.GetInt32(ordCustomerId) : 0,
                Name = ordName >= 0 && !reader.IsDBNull(ordName) ? reader.GetString(ordName) : string.Empty,
                Lastname = ordLastname >= 0 && !reader.IsDBNull(ordLastname) ? reader.GetString(ordLastname) : string.Empty,
                Dni = ordDni >= 0 && !reader.IsDBNull(ordDni) ? reader.GetString(ordDni) : string.Empty,
                Sex = ordSex >= 0 && !reader.IsDBNull(ordSex) ? reader.GetString(ordSex) : string.Empty,
                Email = ordEmail >= 0 && !reader.IsDBNull(ordEmail) ? reader.GetString(ordEmail) : string.Empty,
                Phone = ordPhone >= 0 && !reader.IsDBNull(ordPhone) ? reader.GetString(ordPhone) : null,
                Address = ordAddress >= 0 && !reader.IsDBNull(ordAddress) ? reader.GetString(ordAddress) : null,
                Birth = ordBirth >= 0 && !reader.IsDBNull(ordBirth) ? reader.GetDateTime(ordBirth) : DateTime.MinValue,
                Nationality = ordNationality >= 0 && !reader.IsDBNull(ordNationality) ? reader.GetString(ordNationality) : string.Empty,
                Locality = ordLocality >= 0 && !reader.IsDBNull(ordLocality) ? reader.GetString(ordLocality) : string.Empty,
                RegisterDate = ordRegisterDate >= 0 && !reader.IsDBNull(ordRegisterDate) ? reader.GetDateTime(ordRegisterDate) : DateTime.Now
            };
        }

        #endregion

        #region Métodos de Lectura (SELECT)

        public List<Customer> GetActiveCustomers()
        {
            var customers = new List<Customer>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetActiveCustomers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30; // 30 segundos de timeout estándar
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordLastname = GetOrdinalSafe(reader, "Apellido", "lastname");
                    int ordDni = GetOrdinalSafe(reader, "DNI", "dni");
                    int ordSex = GetOrdinalSafe(reader, "Sexo", "sex");
                    int ordEmail = GetOrdinalSafe(reader, "Email", "email");
                    int ordPhone = GetOrdinalSafe(reader, "Telefono", "phone");
                    int ordAddress = GetOrdinalSafe(reader, "Direccion", "address");
                    int ordBirth = GetOrdinalSafe(reader, "Fecha Nacimiento", "birth");
                    int ordNationality = GetOrdinalSafe(reader, "Nacionalidad", "nationality");
                    int ordLocality = GetOrdinalSafe(reader, "Localidad", "locality");
                    int ordRegisterDate = GetOrdinalSafe(reader, "register_date", "RegisterDate");

                    while (reader.Read())
                    {
                        customers.Add(MapCustomerFromReader(
                            reader,
                            ordCustomerId,
                            ordName,
                            ordLastname,
                            ordDni,
                            ordSex,
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
            return customers;
        }

        public List<Customer> GetInactiveCustomers()
        {
            var customers = new List<Customer>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetInactiveCustomers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30; // 30 segundos de timeout estándar
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordLastname = GetOrdinalSafe(reader, "Apellido", "lastname");
                    int ordDni = GetOrdinalSafe(reader, "DNI", "dni");
                    int ordSex = GetOrdinalSafe(reader, "Sexo", "sex");
                    int ordEmail = GetOrdinalSafe(reader, "Email", "email");
                    int ordPhone = GetOrdinalSafe(reader, "Telefono", "phone");
                    int ordAddress = GetOrdinalSafe(reader, "Direccion", "address");
                    int ordBirth = GetOrdinalSafe(reader, "Fecha Nacimiento", "birth");
                    int ordNationality = GetOrdinalSafe(reader, "Nacionalidad", "nationality");
                    int ordLocality = GetOrdinalSafe(reader, "Localidad", "locality");
                    int ordRegisterDate = GetOrdinalSafe(reader, "register_date", "RegisterDate");

                    while (reader.Read())
                    {
                        customers.Add(MapCustomerFromReader(
                            reader,
                            ordCustomerId,
                            ordName,
                            ordLastname,
                            ordDni,
                            ordSex,
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
            return customers;
        }

        public List<Customer> SearchActiveCustomers(string? searchTerm)
        {
            var customers = new List<Customer>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchActiveCustomers", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30; // 30 segundos de timeout estándar

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
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordLastname = GetOrdinalSafe(reader, "Apellido", "lastname");
                    int ordDni = GetOrdinalSafe(reader, "DNI", "dni");
                    int ordSex = GetOrdinalSafe(reader, "Sexo", "sex");
                    int ordEmail = GetOrdinalSafe(reader, "Email", "email");
                    int ordPhone = GetOrdinalSafe(reader, "Telefono", "phone");
                    int ordAddress = GetOrdinalSafe(reader, "Direccion", "address");
                    int ordBirth = GetOrdinalSafe(reader, "Fecha Nacimiento", "birth");
                    int ordNationality = GetOrdinalSafe(reader, "Nacionalidad", "nationality");
                    int ordLocality = GetOrdinalSafe(reader, "Localidad", "locality");
                    int ordRegisterDate = GetOrdinalSafe(reader, "register_date", "RegisterDate");

                    while (reader.Read())
                    {
                        customers.Add(MapCustomerFromReader(
                            reader,
                            ordCustomerId,
                            ordName,
                            ordLastname,
                            ordDni,
                            ordSex,
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
            return customers;
        }

        public List<Customer> SearchInactiveCustomers(string? searchTerm)
        {
            var customers = new List<Customer>();
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchInactiveCustomers", connection))
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
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordName = GetOrdinalSafe(reader, "Nombre", "name");
                    int ordLastname = GetOrdinalSafe(reader, "Apellido", "lastname");
                    int ordDni = GetOrdinalSafe(reader, "DNI", "dni");
                    int ordSex = GetOrdinalSafe(reader, "Sexo", "sex");
                    int ordEmail = GetOrdinalSafe(reader, "Email", "email");
                    int ordPhone = GetOrdinalSafe(reader, "Telefono", "phone");
                    int ordAddress = GetOrdinalSafe(reader, "Direccion", "address");
                    int ordBirth = GetOrdinalSafe(reader, "Fecha Nacimiento", "birth");
                    int ordNationality = GetOrdinalSafe(reader, "Nacionalidad", "nationality");
                    int ordLocality = GetOrdinalSafe(reader, "Localidad", "locality");
                    int ordRegisterDate = GetOrdinalSafe(reader, "register_date", "RegisterDate");

                    while (reader.Read())
                    {
                        customers.Add(MapCustomerFromReader(
                            reader,
                            ordCustomerId,
                            ordName,
                            ordLastname,
                            ordDni,
                            ordSex,
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
            return customers;
        }

        #endregion

        #region Métodos de Escritura (INSERT, UPDATE, DELETE, REACTIVATE)

        public int CreateCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_CreateCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = customer.Name;
                command.Parameters.Add("@lastname", SqlDbType.VarChar, 100).Value = customer.Lastname;
                command.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = customer.Dni;
                command.Parameters.Add("@sex", SqlDbType.VarChar, 10).Value = customer.Sex;
                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = customer.Email;
                command.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = (object?)customer.Phone ?? DBNull.Value;
                command.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = (object?)customer.Address ?? DBNull.Value;
                command.Parameters.Add("@birth", SqlDbType.Date).Value = customer.Birth;
                command.Parameters.Add("@nationality", SqlDbType.VarChar, 100).Value = customer.Nationality;
                command.Parameters.Add("@locality", SqlDbType.VarChar, 100).Value = customer.Locality;

                connection.Open();
                object? result = command.ExecuteScalar();
                return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_UpdateCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer.CustomerId;
                command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = customer.Name;
                command.Parameters.Add("@lastname", SqlDbType.VarChar, 100).Value = customer.Lastname;
                command.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = customer.Dni;
                command.Parameters.Add("@sex", SqlDbType.VarChar, 10).Value = customer.Sex;
                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = customer.Email;
                command.Parameters.Add("@phone", SqlDbType.VarChar, 15).Value = (object?)customer.Phone ?? DBNull.Value;
                command.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = (object?)customer.Address ?? DBNull.Value;
                command.Parameters.Add("@birth", SqlDbType.Date).Value = customer.Birth;
                command.Parameters.Add("@nationality", SqlDbType.VarChar, 100).Value = customer.Nationality;
                command.Parameters.Add("@locality", SqlDbType.VarChar, 100).Value = customer.Locality;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        public bool SoftDeleteCustomer(int customerId)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_DeleteCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@customer_id", SqlDbType.Int).Value = customerId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        public bool ReactivateCustomer(int customerId)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_ReactivateCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@customer_id", SqlDbType.Int).Value = customerId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        #endregion
    }
}
