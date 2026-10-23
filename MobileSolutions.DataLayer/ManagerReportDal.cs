using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MobileSolutions.DataLayer
{
    public class ManagerReportDal
    {
        private readonly DatabaseConnection _dbConnection;

        public ManagerReportDal()
        {
            _dbConnection = new DatabaseConnection();
        }

        #region Métodos Auxiliares de Mapeo y Parámetros

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

        private static void AddPeriodParameters(SqlCommand command, DateTime? startDate, DateTime? endDate)
        {
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

        #region Métodos de Acceso a Datos por Stored Procedure

        public ManagerKpiSummary GetManagerKpiSummary(DateTime? startDate = null, DateTime? endDate = null)
        {
            var summary = new ManagerKpiSummary();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand("dbo.sp_GetManagerKpiSummary", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                AddPeriodParameters(command, startDate, endDate);

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int ordTotalSalesCount = GetOrdinalSafe(reader, "total_sales_count", "TotalSalesCount");
                    int ordTotalRevenue = GetOrdinalSafe(reader, "total_revenue", "TotalRevenue");
                    int ordAverageTicket = GetOrdinalSafe(reader, "average_ticket", "AverageTicket");
                    int ordMaxSale = GetOrdinalSafe(reader, "max_sale", "MaxSale");
                    int ordCashTotal = GetOrdinalSafe(reader, "cash_total", "CashTotal");
                    int ordTransferTotal = GetOrdinalSafe(reader, "transfer_total", "TransferTotal");
                    int ordCancelledCount = GetOrdinalSafe(reader, "cancelled_sales_count", "CancelledSalesCount");
                    int ordTotalInitiated = GetOrdinalSafe(reader, "total_initiated_sales", "TotalInitiatedSales");
                    int ordCancellationRate = GetOrdinalSafe(reader, "cancellation_rate", "CancellationRate");
                    int ordYearRevenue = GetOrdinalSafe(reader, "year_revenue", "YearRevenue");
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

                    summary.CancelledSalesCount = ordCancelledCount >= 0 && !reader.IsDBNull(ordCancelledCount)
                        ? Convert.ToInt32(reader.GetValue(ordCancelledCount))
                        : 0;

                    summary.TotalInitiatedSales = ordTotalInitiated >= 0 && !reader.IsDBNull(ordTotalInitiated)
                        ? Convert.ToInt32(reader.GetValue(ordTotalInitiated))
                        : 0;

                    summary.CancellationRate = ordCancellationRate >= 0 && !reader.IsDBNull(ordCancellationRate)
                        ? Convert.ToDecimal(reader.GetValue(ordCancellationRate))
                        : 0m;

                    summary.YearRevenue = ordYearRevenue >= 0 && !reader.IsDBNull(ordYearRevenue)
                        ? Convert.ToDecimal(reader.GetValue(ordYearRevenue))
                        : 0m;

                    summary.PreviousMonthRevenue = ordPrevMonthRevenue >= 0 && !reader.IsDBNull(ordPrevMonthRevenue)
                        ? Convert.ToDecimal(reader.GetValue(ordPrevMonthRevenue))
                        : 0m;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos al obtener el resumen de KPIs gerenciales.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado en la capa de datos al obtener el resumen de KPIs gerenciales.", ex);
            }

            return summary;
        }

        public List<SellerPerformanceItem> GetTopBottomSellers(DateTime? startDate = null, DateTime? endDate = null)
        {
            var sellers = new List<SellerPerformanceItem>();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand("dbo.sp_GetManagerTopBottomSellers", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                AddPeriodParameters(command, startDate, endDate);

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                int ordUsername = GetOrdinalSafe(reader, "username", "Username");
                int ordFullName = GetOrdinalSafe(reader, "full_name", "FullName");
                int ordSalesCount = GetOrdinalSafe(reader, "sales_count", "SalesCount");
                int ordTotalRevenue = GetOrdinalSafe(reader, "total_revenue", "TotalRevenue");
                int ordIsTopCount = GetOrdinalSafe(reader, "is_top_sales_count", "IsTopSalesCount");
                int ordIsBottomCount = GetOrdinalSafe(reader, "is_bottom_sales_count", "IsBottomSalesCount");
                int ordIsTopRevenue = GetOrdinalSafe(reader, "is_top_revenue", "IsTopRevenue");

                while (reader.Read())
                {
                    sellers.Add(new SellerPerformanceItem
                    {
                        UserId = ordUserId >= 0 && !reader.IsDBNull(ordUserId) ? Convert.ToInt32(reader.GetValue(ordUserId)) : 0,
                        Username = ordUsername >= 0 && !reader.IsDBNull(ordUsername) ? reader.GetString(ordUsername) : string.Empty,
                        FullName = ordFullName >= 0 && !reader.IsDBNull(ordFullName) ? reader.GetString(ordFullName) : string.Empty,
                        SalesCount = ordSalesCount >= 0 && !reader.IsDBNull(ordSalesCount) ? Convert.ToInt32(reader.GetValue(ordSalesCount)) : 0,
                        TotalRevenue = ordTotalRevenue >= 0 && !reader.IsDBNull(ordTotalRevenue) ? Convert.ToDecimal(reader.GetValue(ordTotalRevenue)) : 0m,
                        IsTopSalesCount = ordIsTopCount >= 0 && !reader.IsDBNull(ordIsTopCount) && Convert.ToInt32(reader.GetValue(ordIsTopCount)) == 1,
                        IsBottomSalesCount = ordIsBottomCount >= 0 && !reader.IsDBNull(ordIsBottomCount) && Convert.ToInt32(reader.GetValue(ordIsBottomCount)) == 1,
                        IsTopRevenue = ordIsTopRevenue >= 0 && !reader.IsDBNull(ordIsTopRevenue) && Convert.ToInt32(reader.GetValue(ordIsTopRevenue)) == 1
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos al obtener el ranking de vendedores.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado en la capa de datos al obtener el ranking de vendedores.", ex);
            }

            return sellers;
        }

        public List<ProductRankingItem> GetMostSoldProducts(DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteProductRankingProcedure("dbo.sp_GetManagerMostSoldProducts", startDate, endDate);
        }

        public List<ProductRankingItem> GetLeastSoldProducts(DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteProductRankingProcedure("dbo.sp_GetManagerLeastSoldProducts", startDate, endDate);
        }

        public List<BrandRankingItem> GetMostSoldBrands(DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteBrandRankingProcedure("dbo.sp_GetManagerMostSoldBrands", startDate, endDate);
        }

        public List<BrandRankingItem> GetLeastSoldBrands(DateTime? startDate = null, DateTime? endDate = null)
        {
            return ExecuteBrandRankingProcedure("dbo.sp_GetManagerLeastSoldBrands", startDate, endDate);
        }

        public List<RevenueTimelinePoint> GetRevenueEvolution(DateTime? startDate = null, DateTime? endDate = null)
        {
            var points = new List<RevenueTimelinePoint>();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand("dbo.sp_GetManagerRevenueEvolution", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                AddPeriodParameters(command, startDate, endDate);

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                int ordLabel = GetOrdinalSafe(reader, "period_label", "PeriodLabel");
                int ordDay = GetOrdinalSafe(reader, "period_day", "PeriodDay", "Day");
                int ordMonth = GetOrdinalSafe(reader, "period_month", "PeriodMonth", "Month");
                int ordYear = GetOrdinalSafe(reader, "period_year", "PeriodYear", "Year");
                int ordRevenue = GetOrdinalSafe(reader, "revenue", "Revenue", "total_sale");

                while (reader.Read())
                {
                    points.Add(new RevenueTimelinePoint
                    {
                        PeriodLabel = ordLabel >= 0 && !reader.IsDBNull(ordLabel) ? reader.GetString(ordLabel) : string.Empty,
                        Day = ordDay >= 0 && !reader.IsDBNull(ordDay) ? Convert.ToInt32(reader.GetValue(ordDay)) : 1,
                        Month = ordMonth >= 0 && !reader.IsDBNull(ordMonth) ? Convert.ToInt32(reader.GetValue(ordMonth)) : 1,
                        Year = ordYear >= 0 && !reader.IsDBNull(ordYear) ? Convert.ToInt32(reader.GetValue(ordYear)) : DateTime.Now.Year,
                        Revenue = ordRevenue >= 0 && !reader.IsDBNull(ordRevenue) ? Convert.ToDecimal(reader.GetValue(ordRevenue)) : 0m
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos al obtener la evolución de facturación.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado en la capa de datos al obtener la evolución de facturación.", ex);
            }

            return points;
        }

        public List<SellerDistributionItem> GetSellerDistribution(DateTime? startDate = null, DateTime? endDate = null)
        {
            var list = new List<SellerDistributionItem>();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand("dbo.sp_GetManagerSellerDistribution", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                AddPeriodParameters(command, startDate, endDate);

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
                int ordUserId = GetOrdinalSafe(reader, "user_id", "UserId");
                int ordUsername = GetOrdinalSafe(reader, "username", "Username");
                int ordSellerName = GetOrdinalSafe(reader, "seller_name", "SellerName");
                int ordSalesCount = GetOrdinalSafe(reader, "sales_count", "SalesCount");
                int ordTotalRevenue = GetOrdinalSafe(reader, "total_revenue", "TotalRevenue");

                while (reader.Read())
                {
                    list.Add(new SellerDistributionItem
                    {
                        UserId = ordUserId >= 0 && !reader.IsDBNull(ordUserId) ? Convert.ToInt32(reader.GetValue(ordUserId)) : 0,
                        Username = ordUsername >= 0 && !reader.IsDBNull(ordUsername) ? reader.GetString(ordUsername) : string.Empty,
                        SellerName = ordSellerName >= 0 && !reader.IsDBNull(ordSellerName) ? reader.GetString(ordSellerName) : string.Empty,
                        SalesCount = ordSalesCount >= 0 && !reader.IsDBNull(ordSalesCount) ? Convert.ToInt32(reader.GetValue(ordSalesCount)) : 0,
                        TotalRevenue = ordTotalRevenue >= 0 && !reader.IsDBNull(ordTotalRevenue) ? Convert.ToDecimal(reader.GetValue(ordTotalRevenue)) : 0m
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos al obtener la distribución por vendedor.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado en la capa de datos al obtener la distribución por vendedor.", ex);
            }

            return list;
        }

        private List<ProductRankingItem> ExecuteProductRankingProcedure(string procedureName, DateTime? startDate, DateTime? endDate)
        {
            var items = new List<ProductRankingItem>();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                AddPeriodParameters(command, startDate, endDate);

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
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
            catch (SqlException ex)
            {
                throw new Exception($"Error en la base de datos al ejecutar {procedureName}.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado en la capa de datos al ejecutar {procedureName}.", ex);
            }

            return items;
        }

        private List<BrandRankingItem> ExecuteBrandRankingProcedure(string procedureName, DateTime? startDate, DateTime? endDate)
        {
            var items = new List<BrandRankingItem>();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand(procedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandTimeout = 30;
                AddPeriodParameters(command, startDate, endDate);

                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();
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
            catch (SqlException ex)
            {
                throw new Exception($"Error en la base de datos al ejecutar {procedureName}.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado en la capa de datos al ejecutar {procedureName}.", ex);
            }

            return items;
        }

        #endregion
    }
}
