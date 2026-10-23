using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MobileSolutions.DataLayer
{
    public class SellerReportDal
    {
        private readonly DatabaseConnection _dbConnection;

        public SellerReportDal()
        {
            _dbConnection = new DatabaseConnection();
        }

        #region Métodos Auxiliares de Mapeo (Safe Mapping) y Parámetros

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

        private static void AddSellerPeriodParameters(SqlCommand command, int userId, int? year, int? month, DateTime? startDate = null, DateTime? endDate = null)
        {
            command.Parameters.Add(new SqlParameter("@user_id", SqlDbType.Int) { Value = userId });
            command.Parameters.Add(new SqlParameter("@year", SqlDbType.Int)
            {
                Value = year.HasValue ? (object)year.Value : DBNull.Value
            });
            command.Parameters.Add(new SqlParameter("@month", SqlDbType.Int)
            {
                Value = month.HasValue ? (object)month.Value : DBNull.Value
            });
            command.Parameters.Add(new SqlParameter("@start_date", SqlDbType.DateTime)
            {
                Value = startDate.HasValue ? (object)startDate.Value : DBNull.Value
            });
            command.Parameters.Add(new SqlParameter("@end_date", SqlDbType.DateTime)
            {
                Value = endDate.HasValue ? (object)endDate.Value : DBNull.Value
            });
        }

        private static ProductRankingItem MapProductRankingFromReader(
            SqlDataReader reader,
            int ordProductId,
            int ordProductCode,
            int ordProductName,
            int ordUnitsSold)
        {
            return new ProductRankingItem
            {
                ProductId = ordProductId >= 0 && !reader.IsDBNull(ordProductId) ? Convert.ToInt32(reader.GetValue(ordProductId)) : 0,
                ProductCode = ordProductCode >= 0 && !reader.IsDBNull(ordProductCode) ? reader.GetString(ordProductCode) : string.Empty,
                ProductName = ordProductName >= 0 && !reader.IsDBNull(ordProductName) ? reader.GetString(ordProductName) : string.Empty,
                UnitsSold = ordUnitsSold >= 0 && !reader.IsDBNull(ordUnitsSold) ? Convert.ToInt32(reader.GetValue(ordUnitsSold)) : 0
            };
        }

        private static BrandRankingItem MapBrandRankingFromReader(
            SqlDataReader reader,
            int ordBrandId,
            int ordBrandName,
            int ordUnitsSold)
        {
            return new BrandRankingItem
            {
                BrandId = ordBrandId >= 0 && !reader.IsDBNull(ordBrandId) ? Convert.ToInt32(reader.GetValue(ordBrandId)) : 0,
                BrandName = ordBrandName >= 0 && !reader.IsDBNull(ordBrandName) ? reader.GetString(ordBrandName) : string.Empty,
                UnitsSold = ordUnitsSold >= 0 && !reader.IsDBNull(ordUnitsSold) ? Convert.ToInt32(reader.GetValue(ordUnitsSold)) : 0
            };
        }

        #endregion

        #region Métodos de Lectura por Stored Procedure (Single Responsibility)

        public SellerKpiSummary GetSellerKpiSummary(int userId, int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            var summary = new SellerKpiSummary();

            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                using (SqlCommand command = new SqlCommand("sp_GetSellerKpiSummary", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 30;
                    AddSellerPeriodParameters(command, userId, year, month, startDate, endDate);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int ordTotalSalesCount = GetOrdinalSafe(reader, "total_sales_count", "TotalSalesCount");
                            int ordTotalRevenue = GetOrdinalSafe(reader, "total_revenue", "TotalRevenue");
                            int ordAverageTicket = GetOrdinalSafe(reader, "average_ticket", "AverageTicket");
                            int ordMaxSale = GetOrdinalSafe(reader, "max_sale", "MaxSale");
                            int ordCashTotal = GetOrdinalSafe(reader, "cash_total", "CashTotal");
                            int ordTransferTotal = GetOrdinalSafe(reader, "transfer_total", "TransferTotal");
                            int ordPrevMonthRevenue = GetOrdinalSafe(reader, "prev_month_revenue", "PreviousMonthRevenue");

                            summary.TotalSalesCount = ordTotalSalesCount >= 0 && !reader.IsDBNull(ordTotalSalesCount)
                                ? Convert.ToInt32(reader.GetValue(ordTotalSalesCount))
                                : 0;
                            summary.TotalRevenue = ordTotalRevenue >= 0 && !reader.IsDBNull(ordTotalRevenue)
                                ? Convert.ToDecimal(reader.GetValue(ordTotalRevenue))
                                : 0m;
                            summary.AverageTicket = ordAverageTicket >= 0 && !reader.IsDBNull(ordAverageTicket)
                                ? Convert.ToDecimal(reader.GetValue(ordAverageTicket))
                                : 0m;
                            summary.MaxSale = ordMaxSale >= 0 && !reader.IsDBNull(ordMaxSale)
                                ? Convert.ToDecimal(reader.GetValue(ordMaxSale))
                                : 0m;
                            summary.CashTotal = ordCashTotal >= 0 && !reader.IsDBNull(ordCashTotal)
                                ? Convert.ToDecimal(reader.GetValue(ordCashTotal))
                                : 0m;
                            summary.TransferTotal = ordTransferTotal >= 0 && !reader.IsDBNull(ordTransferTotal)
                                ? Convert.ToDecimal(reader.GetValue(ordTransferTotal))
                                : 0m;
                            summary.PreviousMonthRevenue = ordPrevMonthRevenue >= 0 && !reader.IsDBNull(ordPrevMonthRevenue)
                                ? Convert.ToDecimal(reader.GetValue(ordPrevMonthRevenue))
                                : 0m;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error en la base de datos al obtener el resumen de KPIs del vendedor (ID: {userId}).", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado en la capa de datos al obtener el resumen de KPIs del vendedor (ID: {userId}).", ex);
            }

            return summary;
        }

        public List<ProductRankingItem> GetSellerMostSoldProducts(int userId, int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteProductRankingProcedure("sp_GetSellerMostSoldProducts", userId, year, month, startDate, endDate);
        }

        public List<ProductRankingItem> GetSellerLeastSoldProducts(int userId, int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteProductRankingProcedure("sp_GetSellerLeastSoldProducts", userId, year, month, startDate, endDate);
        }

        public List<ProductRankingItem> GetSellerTop5Products(int userId, int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteProductRankingProcedure("sp_GetSellerTop5Products", userId, year, month, startDate, endDate);
        }

        public List<BrandRankingItem> GetSellerMostSoldBrands(int userId, int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteBrandRankingProcedure("sp_GetSellerMostSoldBrands", userId, year, month, startDate, endDate);
        }

        public List<BrandRankingItem> GetSellerLeastSoldBrands(int userId, int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteBrandRankingProcedure("sp_GetSellerLeastSoldBrands", userId, year, month, startDate, endDate);
        }

        public List<BrandRankingItem> GetSellerBrandDistribution(int userId, int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteBrandRankingProcedure("sp_GetSellerBrandDistribution", userId, year, month, startDate, endDate);
        }

        public List<DailySalesPoint> GetSellerDailyEvolution(int userId, int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            var points = new List<DailySalesPoint>();

            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                using (SqlCommand command = new SqlCommand("sp_GetSellerDailyEvolution", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 30;
                    AddSellerPeriodParameters(command, userId, year, month, startDate, endDate);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordSaleDay = GetOrdinalSafe(reader, "sale_day", "SaleDay", "Day");
                        int ordDailyRevenue = GetOrdinalSafe(reader, "daily_revenue", "DailyRevenue", "Revenue");

                        while (reader.Read())
                        {
                            points.Add(new DailySalesPoint
                            {
                                Day = ordSaleDay >= 0 && !reader.IsDBNull(ordSaleDay) ? Convert.ToInt32(reader.GetValue(ordSaleDay)) : 0,
                                Revenue = ordDailyRevenue >= 0 && !reader.IsDBNull(ordDailyRevenue) ? Convert.ToDecimal(reader.GetValue(ordDailyRevenue)) : 0m
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error en la base de datos al obtener la evolución diaria del vendedor (ID: {userId}).", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado en la capa de datos al obtener la evolución diaria del vendedor (ID: {userId}).", ex);
            }

            return points;
        }

        private List<ProductRankingItem> ExecuteProductRankingProcedure(string procedureName, int userId, int? year, int? month, DateTime? startDate = null, DateTime? endDate = null)
        {
            var items = new List<ProductRankingItem>();

            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 30;
                    AddSellerPeriodParameters(command, userId, year, month, startDate, endDate);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordProductId = GetOrdinalSafe(reader, "product_id", "ProductId");
                        int ordProductCode = GetOrdinalSafe(reader, "product_code", "ProductCode");
                        int ordProductName = GetOrdinalSafe(reader, "product_name", "ProductName", "name");
                        int ordUnitsSold = GetOrdinalSafe(reader, "units_sold", "UnitsSold");

                        while (reader.Read())
                        {
                            items.Add(MapProductRankingFromReader(
                                reader,
                                ordProductId,
                                ordProductCode,
                                ordProductName,
                                ordUnitsSold));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error en la base de datos al ejecutar {procedureName} para el vendedor (ID: {userId}).", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado en la capa de datos al ejecutar {procedureName} para el vendedor (ID: {userId}).", ex);
            }

            return items;
        }

        private List<BrandRankingItem> ExecuteBrandRankingProcedure(string procedureName, int userId, int? year, int? month, DateTime? startDate = null, DateTime? endDate = null)
        {
            var items = new List<BrandRankingItem>();

            try
            {
                using (SqlConnection connection = _dbConnection.GetConnection())
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 30;
                    AddSellerPeriodParameters(command, userId, year, month, startDate, endDate);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordBrandId = GetOrdinalSafe(reader, "brand_id", "BrandId");
                        int ordBrandName = GetOrdinalSafe(reader, "brand_name", "BrandName", "name");
                        int ordUnitsSold = GetOrdinalSafe(reader, "units_sold", "UnitsSold");

                        while (reader.Read())
                        {
                            items.Add(MapBrandRankingFromReader(
                                reader,
                                ordBrandId,
                                ordBrandName,
                                ordUnitsSold));
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error en la base de datos al ejecutar {procedureName} para el vendedor (ID: {userId}).", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado en la capa de datos al ejecutar {procedureName} para el vendedor (ID: {userId}).", ex);
            }

            return items;
        }

        #endregion
    }
}
