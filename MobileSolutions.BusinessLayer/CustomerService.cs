using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.DataLayer;

namespace MobileSolutions.BusinessLayer
{
    internal class CustomerService
    {
        private readonly CustomerDal _customerDal;
        private readonly DatabaseConnection _dbConnection;

        public CustomerService()
        {
            _customerDal = new CustomerDal();
            _dbConnection = new DatabaseConnection();
        }

        public List<Customer> GetActiveCustomers()
        {
            return _customerDal.GetActiveCustomers();
        }

        public List<Customer> GetInactiveCustomers()
        {
            return _customerDal.GetInactiveCustomers();
        }

        public List<Customer> SearchCustomers(string? searchTerm)
        {
            return SearchCustomersByStatus(searchTerm, isInactiveMode: false);
        }

        public List<Customer> SearchCustomersByStatus(string? searchTerm, bool isInactiveMode)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return isInactiveMode ? GetInactiveCustomers() : GetActiveCustomers();
            }

            string cleanSearchTerm = searchTerm.Trim();
            return isInactiveMode ?
                _customerDal.SearchInactiveCustomers(cleanSearchTerm) :
                _customerDal.SearchActiveCustomers(cleanSearchTerm);
        }

        public (bool Success, string Message) CreateCustomer(Customer customer)
        {
            if (customer == null)
            {
                return (false, "Los campos del Cliente no pueden estar vacíos.");
            }
            if (string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.Lastname))
            {
                return (false, "El nombre y apellido son obligatorios.");
            }
            if (string.IsNullOrWhiteSpace(customer.Dni) || customer.Dni.Length < 7 || customer.Dni.Length > 8)
            {
                return (false, "El DNI debe contener entre 7 y 8 dígitos.");
            }
            if (string.IsNullOrWhiteSpace(customer.Email) || !customer.Email.Contains("@"))
            {
                return (false, "Debe ingresar un correo electrónico válido.");
            }
            if (string.IsNullOrWhiteSpace(customer.Nationality) || string.IsNullOrWhiteSpace(customer.Locality))
            {
                return (false, "La nacionalidad y localidad son obligatorias.");
            }
            if (string.IsNullOrWhiteSpace(customer.Sex))
            {
                return (false, "Seleccionar un Sexo es Obligatorio.");
            }
            if (customer.Birth.Date > DateTime.Today)
            {
                return (false, "Fecha de Nacimiento Invalida (no puede ser una fecha futura).");
            }

            try
            {
                int newCustomerId = _customerDal.CreateCustomer(customer);
                if (newCustomerId > 0)
                {
                    return (true, $"Cliente creado exitosamente con ID: {newCustomerId}");
                }
                else
                {
                    return (false, "No se pudo registrar el cliente en la base de datos.");
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Manejo de errores por violación de restricciones UNIQUE (DNI, Username, Email)
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint error
                {
                    if (ex.Message.Contains("UQ_Customer_DNI"))
                    {
                        return (false, "Ya existe un Cliente con ese número de DNI.");
                    }
                    if (ex.Message.Contains("UQ_Customer_Email"))
                    {
                        return (false, "Ya existe un Cliente con ese correo electrónico.");
                    }
                      
                    return (false, "Ya existe un Cliente con los datos proporcionados.");
                }
                else
                {
                    return (false, $"Error al crear el cliente: ({ex.Number}): {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al crear el cliente: {ex.Message}");
            }
        }


        public (bool Success, string Message) UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                return (false, "Los campos del Cliente no pueden estar vacíos.");
            }
            if (string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.Lastname))
            {
                return (false, "El nombre y apellido son obligatorios.");
            }
            if (string.IsNullOrWhiteSpace(customer.Dni) || customer.Dni.Length < 7 || customer.Dni.Length > 8)
            {
                return (false, "El DNI debe contener entre 7 y 8 dígitos.");
            }
            if (string.IsNullOrWhiteSpace(customer.Email) || !customer.Email.Contains("@"))
            {
                return (false, "Debe ingresar un correo electrónico válido.");
            }
            if (string.IsNullOrWhiteSpace(customer.Nationality) || string.IsNullOrWhiteSpace(customer.Locality))
            {
                return (false, "La nacionalidad y localidad son obligatorias.");
            }
            if (string.IsNullOrWhiteSpace(customer.Sex))
            {
                return (false, "Seleccionar un Sexo es Obligatorio.");
            }
            if (customer.Birth.Date > DateTime.Today)
            {
                return (false, "Fecha de Nacimiento Invalida (no puede ser una fecha futura).");
            }
            try
            {
                bool updateResult = _customerDal.UpdateCustomer(customer);
                if (updateResult)
                {
                    return (true, $"Cliente con ID: {customer.CustomerId} actualizado exitosamente.");
                }
                else
                {
                    return (false, "No se pudo actualizar el cliente en la base de datos.");
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Manejo de errores por violación de restricciones UNIQUE (DNI, Username, Email)
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint error
                {
                    if (ex.Message.Contains("UQ_Customer_DNI"))
                    {
                        return (false, "Ya existe un Cliente con ese número de DNI.");
                    }
                    if (ex.Message.Contains("UQ_Customer_Email"))
                    {
                        return (false, "Ya existe un Cliente con ese correo electrónico.");
                    }

                    return (false, "Ya existe un Cliente con los datos proporcionados.");
                }
                else
                {
                    return (false, $"Error al intentar modificar el cliente: ({ex.Number}): {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al intentar modificar el cliente: {ex.Message}");
            }
        }


        public (bool Succes, string Message) SoftDeleteCustomer(int customerId)
        {
            if (customerId <= 0)
            {
                return (false, "Identificador de Cliente no válido para la baja lógica");
            }

            try
            {
                bool deleted = _customerDal.SoftDeleteCustomer(customerId);
                if (deleted)
                {
                    return (true, "Cliente dado de baja correctamente");
                }

                return (false, "No se pudo dar de baja el cliente en la base de datos");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al dar de baja al cliente: {ex.Message}");
            }
        }


        public (bool Success, string Message) ReactivateCustomer(int customerId)
        {
            if (customerId <= 0)
            {
                return (false, "Identificador de cliente no válido para la reactivación.");
            }

            try
            {
                bool reactivated = _customerDal.ReactivateCustomer(customerId);
                if (reactivated)
                {
                    return (true, "Cliente reactivado correctamente.");
                }

                return (false, "No se pudo reactivar al cliente en la base de datos.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return (false, $"Error de base de datos ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Error inesperado al reactivar el cliente: {ex.Message}");
            }
        }


    }
}
