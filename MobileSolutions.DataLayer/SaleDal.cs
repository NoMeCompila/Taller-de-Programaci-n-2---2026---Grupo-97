using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MobileSolutions.DataLayer
{
    public class SaleDal
    {
        private readonly DatabaseConnection _dbConnection;

        public SaleDal()
        {
            _dbConnection = new DatabaseConnection();
        }

        #region Métodos Auxiliares de Mapeo (Safe Mapping) y TVP

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

        private static SaleHeader MapSaleHeaderFromReader(
            SqlDataReader reader,
            int ordSaleId,
            int ordSaleNumber,
            int ordSaleDate,
            int ordTotalSale,
            int ordStatus,
            int ordPaymentTypeId,
            int ordPaymentType,
            int ordCustomerId,
            int ordCustomerDni,
            int ordCustomerName,
            int ordCustomerLastname,
            int ordUserId,
            int ordUserUsername,
            int ordSellerName,
            int ordSellerLastname)
        {
            return new SaleHeader
            {
                SaleId = ordSaleId >= 0 && !reader.IsDBNull(ordSaleId) ? reader.GetInt32(ordSaleId) : 0,
                SaleNumber = ordSaleNumber >= 0 && !reader.IsDBNull(ordSaleNumber) ? reader.GetString(ordSaleNumber) : string.Empty,
                SaleDate = ordSaleDate >= 0 && !reader.IsDBNull(ordSaleDate) ? reader.GetDateTime(ordSaleDate) : DateTime.MinValue,
                TotalSale = ordTotalSale >= 0 && !reader.IsDBNull(ordTotalSale) ? reader.GetDecimal(ordTotalSale) : 0m,
                Status = ordStatus >= 0 && !reader.IsDBNull(ordStatus) ? reader.GetBoolean(ordStatus) : true,
                PaymentTypeId = ordPaymentTypeId >= 0 && !reader.IsDBNull(ordPaymentTypeId) ? reader.GetInt32(ordPaymentTypeId) : 0,
                PaymentTypeName = ordPaymentType >= 0 && !reader.IsDBNull(ordPaymentType) ? reader.GetString(ordPaymentType) : string.Empty,
                CustomerId = ordCustomerId >= 0 && !reader.IsDBNull(ordCustomerId) ? reader.GetInt32(ordCustomerId) : 0,
                CustomerDni = ordCustomerDni >= 0 && !reader.IsDBNull(ordCustomerDni) ? reader.GetString(ordCustomerDni) : string.Empty,
                CustomerName = ordCustomerName >= 0 && !reader.IsDBNull(ordCustomerName) ? reader.GetString(ordCustomerName) : string.Empty,
                CustomerLastname = ordCustomerLastname >= 0 && !reader.IsDBNull(ordCustomerLastname) ? reader.GetString(ordCustomerLastname) : string.Empty,
                UserId = ordUserId >= 0 && !reader.IsDBNull(ordUserId) ? reader.GetInt32(ordUserId) : 0,
                UserUsername = ordUserUsername >= 0 && !reader.IsDBNull(ordUserUsername) ? reader.GetString(ordUserUsername) : string.Empty,
                SellerName = ordSellerName >= 0 && !reader.IsDBNull(ordSellerName) ? reader.GetString(ordSellerName) : string.Empty,
                SellerLastname = ordSellerLastname >= 0 && !reader.IsDBNull(ordSellerLastname) ? reader.GetString(ordSellerLastname) : string.Empty
            };
        }

        private static SaleDetail MapSaleDetailFromReader(
            SqlDataReader reader,
            int ordSaleDetailId,
            int ordSaleId,
            int ordProductId,
            int ordProductCode,
            int ordProductName,
            int ordBrandName,
            int ordQuantity,
            int ordUnitPrice)
        {
            return new SaleDetail
            {
                SaleDetailId = ordSaleDetailId >= 0 && !reader.IsDBNull(ordSaleDetailId) ? reader.GetInt32(ordSaleDetailId) : 0,
                SaleId = ordSaleId >= 0 && !reader.IsDBNull(ordSaleId) ? reader.GetInt32(ordSaleId) : 0,
                ProductId = ordProductId >= 0 && !reader.IsDBNull(ordProductId) ? reader.GetInt32(ordProductId) : 0,
                ProductCode = ordProductCode >= 0 && !reader.IsDBNull(ordProductCode) ? reader.GetString(ordProductCode) : string.Empty,
                ProductName = ordProductName >= 0 && !reader.IsDBNull(ordProductName) ? reader.GetString(ordProductName) : string.Empty,
                BrandName = ordBrandName >= 0 && !reader.IsDBNull(ordBrandName) ? reader.GetString(ordBrandName) : string.Empty,
                Quantity = ordQuantity >= 0 && !reader.IsDBNull(ordQuantity) ? reader.GetInt32(ordQuantity) : 0,
                UnitPrice = ordUnitPrice >= 0 && !reader.IsDBNull(ordUnitPrice) ? reader.GetDecimal(ordUnitPrice) : 0m
            };
        }

        private static DataTable BuildSaleDetailDataTable(IEnumerable<SaleDetail> details)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("product_id", typeof(int));
            dataTable.Columns.Add("quantity", typeof(int));
            dataTable.Columns.Add("price", typeof(decimal));

            if (details != null)
            {
                foreach (var item in details)
                {
                    dataTable.Rows.Add(item.ProductId, item.Quantity, item.UnitPrice);
                }
            }

            return dataTable;
        }

        #endregion

        #region Métodos de Lectura (SELECT)

        public List<SaleHeader> GetActiveSales()
        {
            var sales = new List<SaleHeader>();

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetActiveSales", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordSaleId = GetOrdinalSafe(reader, "sale_id", "SaleId");
                    int ordSaleNumber = GetOrdinalSafe(reader, "sale_number", "SaleNumber");
                    int ordSaleDate = GetOrdinalSafe(reader, "sale_date", "SaleDate");
                    int ordTotalSale = GetOrdinalSafe(reader, "total_sale", "TotalSale");
                    int ordStatus = GetOrdinalSafe(reader, "status", "Status");
                    int ordPaymentTypeId = GetOrdinalSafe(reader, "payment_type_id", "PaymentTypeId");
                    int ordPaymentType = GetOrdinalSafe(reader, "payment_type", "PaymentType");
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordCustomerDni = GetOrdinalSafe(reader, "customer_dni", "dni");
                    int ordCustomerName = GetOrdinalSafe(reader, "customer_name", "name");
                    int ordCustomerLastname = GetOrdinalSafe(reader, "customer_lastname", "lastname");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordUserUsername = GetOrdinalSafe(reader, "user_username", "username");
                    int ordSellerName = GetOrdinalSafe(reader, "seller_name");
                    int ordSellerLastname = GetOrdinalSafe(reader, "seller_lastname");

                    while (reader.Read())
                    {
                        sales.Add(MapSaleHeaderFromReader(
                            reader,
                            ordSaleId,
                            ordSaleNumber,
                            ordSaleDate,
                            ordTotalSale,
                            ordStatus,
                            ordPaymentTypeId,
                            ordPaymentType,
                            ordCustomerId,
                            ordCustomerDni,
                            ordCustomerName,
                            ordCustomerLastname,
                            ordUserId,
                            ordUserUsername,
                            ordSellerName,
                            ordSellerLastname));
                    }
                }
            }

            return sales;
        }

        public List<SaleHeader> GetInactiveSales()
        {
            var sales = new List<SaleHeader>();

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetInactiveSales", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordSaleId = GetOrdinalSafe(reader, "sale_id", "SaleId");
                    int ordSaleNumber = GetOrdinalSafe(reader, "sale_number", "SaleNumber");
                    int ordSaleDate = GetOrdinalSafe(reader, "sale_date", "SaleDate");
                    int ordTotalSale = GetOrdinalSafe(reader, "total_sale", "TotalSale");
                    int ordStatus = GetOrdinalSafe(reader, "status", "Status");
                    int ordPaymentTypeId = GetOrdinalSafe(reader, "payment_type_id", "PaymentTypeId");
                    int ordPaymentType = GetOrdinalSafe(reader, "payment_type", "PaymentType");
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordCustomerDni = GetOrdinalSafe(reader, "customer_dni", "dni");
                    int ordCustomerName = GetOrdinalSafe(reader, "customer_name", "name");
                    int ordCustomerLastname = GetOrdinalSafe(reader, "customer_lastname", "lastname");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordUserUsername = GetOrdinalSafe(reader, "user_username", "username");
                    int ordSellerName = GetOrdinalSafe(reader, "seller_name");
                    int ordSellerLastname = GetOrdinalSafe(reader, "seller_lastname");

                    while (reader.Read())
                    {
                        sales.Add(MapSaleHeaderFromReader(
                            reader,
                            ordSaleId,
                            ordSaleNumber,
                            ordSaleDate,
                            ordTotalSale,
                            ordStatus,
                            ordPaymentTypeId,
                            ordPaymentType,
                            ordCustomerId,
                            ordCustomerDni,
                            ordCustomerName,
                            ordCustomerLastname,
                            ordUserId,
                            ordUserUsername,
                            ordSellerName,
                            ordSellerLastname));
                    }
                }
            }

            return sales;
        }

        public List<SaleHeader> SearchActiveSales(string? searchTerm)
        {
            var sales = new List<SaleHeader>();

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchActiveSales", connection))
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
                    int ordSaleId = GetOrdinalSafe(reader, "sale_id", "SaleId");
                    int ordSaleNumber = GetOrdinalSafe(reader, "sale_number", "SaleNumber");
                    int ordSaleDate = GetOrdinalSafe(reader, "sale_date", "SaleDate");
                    int ordTotalSale = GetOrdinalSafe(reader, "total_sale", "TotalSale");
                    int ordStatus = GetOrdinalSafe(reader, "status", "Status");
                    int ordPaymentTypeId = GetOrdinalSafe(reader, "payment_type_id", "PaymentTypeId");
                    int ordPaymentType = GetOrdinalSafe(reader, "payment_type", "PaymentType");
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordCustomerDni = GetOrdinalSafe(reader, "customer_dni", "dni");
                    int ordCustomerName = GetOrdinalSafe(reader, "customer_name", "name");
                    int ordCustomerLastname = GetOrdinalSafe(reader, "customer_lastname", "lastname");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordUserUsername = GetOrdinalSafe(reader, "user_username", "username");
                    int ordSellerName = GetOrdinalSafe(reader, "seller_name");
                    int ordSellerLastname = GetOrdinalSafe(reader, "seller_lastname");

                    while (reader.Read())
                    {
                        sales.Add(MapSaleHeaderFromReader(
                            reader,
                            ordSaleId,
                            ordSaleNumber,
                            ordSaleDate,
                            ordTotalSale,
                            ordStatus,
                            ordPaymentTypeId,
                            ordPaymentType,
                            ordCustomerId,
                            ordCustomerDni,
                            ordCustomerName,
                            ordCustomerLastname,
                            ordUserId,
                            ordUserUsername,
                            ordSellerName,
                            ordSellerLastname));
                    }
                }
            }

            return sales;
        }

        public List<SaleHeader> SearchInactiveSales(string? searchTerm)
        {
            var sales = new List<SaleHeader>();

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchInactiveSales", connection))
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
                    int ordSaleId = GetOrdinalSafe(reader, "sale_id", "SaleId");
                    int ordSaleNumber = GetOrdinalSafe(reader, "sale_number", "SaleNumber");
                    int ordSaleDate = GetOrdinalSafe(reader, "sale_date", "SaleDate");
                    int ordTotalSale = GetOrdinalSafe(reader, "total_sale", "TotalSale");
                    int ordStatus = GetOrdinalSafe(reader, "status", "Status");
                    int ordPaymentTypeId = GetOrdinalSafe(reader, "payment_type_id", "PaymentTypeId");
                    int ordPaymentType = GetOrdinalSafe(reader, "payment_type", "PaymentType");
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordCustomerDni = GetOrdinalSafe(reader, "customer_dni", "dni");
                    int ordCustomerName = GetOrdinalSafe(reader, "customer_name", "name");
                    int ordCustomerLastname = GetOrdinalSafe(reader, "customer_lastname", "lastname");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordUserUsername = GetOrdinalSafe(reader, "user_username", "username");
                    int ordSellerName = GetOrdinalSafe(reader, "seller_name");
                    int ordSellerLastname = GetOrdinalSafe(reader, "seller_lastname");

                    while (reader.Read())
                    {
                        sales.Add(MapSaleHeaderFromReader(
                            reader,
                            ordSaleId,
                            ordSaleNumber,
                            ordSaleDate,
                            ordTotalSale,
                            ordStatus,
                            ordPaymentTypeId,
                            ordPaymentType,
                            ordCustomerId,
                            ordCustomerDni,
                            ordCustomerName,
                            ordCustomerLastname,
                            ordUserId,
                            ordUserUsername,
                            ordSellerName,
                            ordSellerLastname));
                    }
                }
            }

            return sales;
        }

        public List<SaleHeader> SearchSalesHistory(
            DateTime? startDate,
            DateTime? endDate,
            string? saleNumber,
            string? clientName,
            int? userId)
        {
            var sales = new List<SaleHeader>();

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_SearchSalesHistory", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add(new SqlParameter("@StartDate", SqlDbType.Date)
                {
                    Value = (object?)startDate?.Date ?? DBNull.Value
                });

                command.Parameters.Add(new SqlParameter("@EndDate", SqlDbType.Date)
                {
                    Value = (object?)endDate?.Date ?? DBNull.Value
                });

                command.Parameters.Add(new SqlParameter("@SaleNumber", SqlDbType.NVarChar, 50)
                {
                    Value = string.IsNullOrWhiteSpace(saleNumber) ? DBNull.Value : saleNumber.Trim()
                });

                command.Parameters.Add(new SqlParameter("@ClientName", SqlDbType.NVarChar, 100)
                {
                    Value = string.IsNullOrWhiteSpace(clientName) ? DBNull.Value : clientName.Trim()
                });

                command.Parameters.Add(new SqlParameter("@UserId", SqlDbType.Int)
                {
                    Value = userId.HasValue && userId.Value > 0 ? userId.Value : DBNull.Value
                });

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordSaleId = GetOrdinalSafe(reader, "sale_id", "SaleId");
                    int ordSaleNumber = GetOrdinalSafe(reader, "sale_number", "SaleNumber");
                    int ordSaleDate = GetOrdinalSafe(reader, "sale_date", "SaleDate");
                    int ordTotalSale = GetOrdinalSafe(reader, "total_sale", "TotalSale");
                    int ordStatus = GetOrdinalSafe(reader, "status", "Status");
                    int ordPaymentTypeId = GetOrdinalSafe(reader, "payment_type_id", "PaymentTypeId");
                    int ordPaymentType = GetOrdinalSafe(reader, "payment_type", "PaymentType");
                    int ordCustomerId = GetOrdinalSafe(reader, "customer_id", "CustomerId");
                    int ordCustomerDni = GetOrdinalSafe(reader, "customer_dni", "dni");
                    int ordCustomerName = GetOrdinalSafe(reader, "customer_name", "name");
                    int ordCustomerLastname = GetOrdinalSafe(reader, "customer_lastname", "lastname");
                    int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                    int ordUserUsername = GetOrdinalSafe(reader, "user_username", "username");
                    int ordSellerName = GetOrdinalSafe(reader, "seller_name");
                    int ordSellerLastname = GetOrdinalSafe(reader, "seller_lastname");

                    while (reader.Read())
                    {
                        sales.Add(MapSaleHeaderFromReader(
                            reader,
                            ordSaleId,
                            ordSaleNumber,
                            ordSaleDate,
                            ordTotalSale,
                            ordStatus,
                            ordPaymentTypeId,
                            ordPaymentType,
                            ordCustomerId,
                            ordCustomerDni,
                            ordCustomerName,
                            ordCustomerLastname,
                            ordUserId,
                            ordUserUsername,
                            ordSellerName,
                            ordSellerLastname));
                    }
                }
            }

            return sales;
        }

        public List<SaleDetail> GetSaleDetailsBySaleId(int saleId)
        {
            var details = new List<SaleDetail>();

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_GetSaleDetailsBySaleId", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@sale_id", SqlDbType.Int).Value = saleId;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int ordSaleDetailId = GetOrdinalSafe(reader, "sale_detail_id", "SaleDetailId");
                    int ordSaleId = GetOrdinalSafe(reader, "sale_id", "SaleId");
                    int ordProductId = GetOrdinalSafe(reader, "product_id", "ProductId");
                    int ordProductCode = GetOrdinalSafe(reader, "product_code", "ProductCode");
                    int ordProductName = GetOrdinalSafe(reader, "product_name", "ProductName");
                    int ordBrandName = GetOrdinalSafe(reader, "brand_name", "BrandName");
                    int ordQuantity = GetOrdinalSafe(reader, "quantity", "Quantity");
                    int ordUnitPrice = GetOrdinalSafe(reader, "unit_price", "price", "Price");

                    while (reader.Read())
                    {
                        details.Add(MapSaleDetailFromReader(
                            reader,
                            ordSaleDetailId,
                            ordSaleId,
                            ordProductId,
                            ordProductCode,
                            ordProductName,
                            ordBrandName,
                            ordQuantity,
                            ordUnitPrice));
                    }
                }
            }

            return details;
        }

        public SaleHeader? GetSaleById(int saleId)
        {
            var sales = SearchActiveSales(null);
            var sale = sales.Find(s => s.SaleId == saleId);

            if (sale == null)
            {
                var inactiveSales = SearchInactiveSales(null);
                sale = inactiveSales.Find(s => s.SaleId == saleId);
            }

            if (sale != null)
            {
                sale.Details = GetSaleDetailsBySaleId(saleId);
            }

            return sale;
        }

        #endregion

        #region Métodos de Escritura (CREATE, CANCEL, REACTIVATE)

        public (int SaleId, string SaleNumber, decimal TotalSale) CreateSale(SaleHeader sale)
        {
            if (sale == null)
                throw new ArgumentNullException(nameof(sale));

            if (sale.Details == null || sale.Details.Count == 0)
                throw new InvalidOperationException("La venta debe contener al menos un detalle de producto.");

            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_CreateSale", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@payment_type_id", SqlDbType.Int).Value = sale.PaymentTypeId;
                command.Parameters.Add("@customer_id", SqlDbType.Int).Value = sale.CustomerId;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = sale.UserId;

                // Parámetro Table-Valued Parameter (TVP)
                DataTable tvpDetails = BuildSaleDetailDataTable(sale.Details);
                var detailsParam = command.Parameters.AddWithValue("@details", tvpDetails);
                detailsParam.SqlDbType = SqlDbType.Structured;
                detailsParam.TypeName = "dbo.SaleDetailType";

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int ordSaleId = GetOrdinalSafe(reader, "sale_id", "SaleId");
                        int ordSaleNumber = GetOrdinalSafe(reader, "sale_number", "SaleNumber");
                        int ordTotalSale = GetOrdinalSafe(reader, "total_sale", "TotalSale");

                        int createdId = ordSaleId >= 0 && !reader.IsDBNull(ordSaleId) ? reader.GetInt32(ordSaleId) : 0;
                        string createdNumber = ordSaleNumber >= 0 && !reader.IsDBNull(ordSaleNumber) ? reader.GetString(ordSaleNumber) : string.Empty;
                        decimal createdTotal = ordTotalSale >= 0 && !reader.IsDBNull(ordTotalSale) ? reader.GetDecimal(ordTotalSale) : 0m;

                        sale.SaleId = createdId;
                        sale.SaleNumber = createdNumber;
                        sale.TotalSale = createdTotal;

                        return (createdId, createdNumber, createdTotal);
                    }
                }
            }

            return (0, string.Empty, 0m);
        }

        public bool CancelSale(int saleId)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_CancelSale", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@sale_id", SqlDbType.Int).Value = saleId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        public bool ReactivateSale(int saleId)
        {
            using (SqlConnection connection = _dbConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("sp_ReactivateSale", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;

                command.Parameters.Add("@sale_id", SqlDbType.Int).Value = saleId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0 || rowsAffected == -1;
            }
        }

        #endregion
    }
}

