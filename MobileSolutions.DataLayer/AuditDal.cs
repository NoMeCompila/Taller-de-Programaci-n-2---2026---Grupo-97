using Microsoft.Data.SqlClient;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace MobileSolutions.DataLayer
{
    public class AuditDal
    {
        private readonly DatabaseConnection _dbConnection;

        public AuditDal()
        {
            _dbConnection = new DatabaseConnection();
        }

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

        /// <summary>
        /// Registra un evento de auditoría en dbo.AuditLog mediante sp_RecordAuditEvent.
        /// </summary>
        public bool RecordAuditEvent(string eventType, string actor, string outcome, string? details = null)
        {
            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand("dbo.sp_RecordAuditEvent", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@event_type", SqlDbType.VarChar, 50) { Value = eventType });
                command.Parameters.Add(new SqlParameter("@actor", SqlDbType.VarChar, 100) { Value = actor });
                command.Parameters.Add(new SqlParameter("@outcome", SqlDbType.VarChar, 20) { Value = outcome });
                command.Parameters.Add(new SqlParameter("@details", SqlDbType.VarChar, 255)
                {
                    Value = string.IsNullOrWhiteSpace(details) ? (object)DBNull.Value : details
                });

                connection.Open();
                int rows = command.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                // La falla de auditoría no debe romper la operación primaria si la base no estuviera disponible
                return false;
            }
        }

        /// <summary>
        /// Obtiene las métricas consolidadas del dashboard administrativo mediante sp_GetAdminDashboardMetrics.
        /// </summary>
        public AdminDashboardMetrics GetAdminDashboardMetrics()
        {
            AdminDashboardMetrics metrics = new AdminDashboardMetrics();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand("dbo.sp_GetAdminDashboardMetrics", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int ordMostActiveUser = GetOrdinalSafe(reader, "MostActiveUser");
                    int ordMostActiveCount = GetOrdinalSafe(reader, "MostActiveUserLoginCount");
                    int ordOrphanAccounts = GetOrdinalSafe(reader, "OrphanAccountsCount");
                    int ordLastLoginUser = GetOrdinalSafe(reader, "LastLoginUser");
                    int ordLastLoginTime = GetOrdinalSafe(reader, "LastLoginTimestamp");
                    int ordFailedLogins = GetOrdinalSafe(reader, "FailedLoginsLast24Hours");
                    int ordAllocatedMb = GetOrdinalSafe(reader, "DatabaseAllocatedMb");
                    int ordUsedMb = GetOrdinalSafe(reader, "DatabaseUsedMb");
                    int ordTotalBackups = GetOrdinalSafe(reader, "TotalBackups");
                    int ordTotalRestores = GetOrdinalSafe(reader, "TotalRestores");
                    int ordLastRestoreTime = GetOrdinalSafe(reader, "LastRestoreTimestamp");
                    int ordLastBackupTime = GetOrdinalSafe(reader, "LastBackupTimestamp");

                    if (ordMostActiveUser >= 0 && !reader.IsDBNull(ordMostActiveUser))
                        metrics.MostActiveUser = reader.GetString(ordMostActiveUser);

                    if (ordMostActiveCount >= 0 && !reader.IsDBNull(ordMostActiveCount))
                        metrics.MostActiveUserLoginCount = Convert.ToInt32(reader.GetValue(ordMostActiveCount));

                    if (ordOrphanAccounts >= 0 && !reader.IsDBNull(ordOrphanAccounts))
                        metrics.OrphanAccountsCount = Convert.ToInt32(reader.GetValue(ordOrphanAccounts));

                    if (ordLastLoginUser >= 0 && !reader.IsDBNull(ordLastLoginUser))
                        metrics.LastLoginUser = reader.GetString(ordLastLoginUser);

                    if (ordLastLoginTime >= 0 && !reader.IsDBNull(ordLastLoginTime))
                        metrics.LastLoginTimestamp = reader.GetDateTime(ordLastLoginTime);

                    if (ordFailedLogins >= 0 && !reader.IsDBNull(ordFailedLogins))
                        metrics.FailedLoginsLast24Hours = Convert.ToInt32(reader.GetValue(ordFailedLogins));

                    if (ordAllocatedMb >= 0 && !reader.IsDBNull(ordAllocatedMb))
                        metrics.DatabaseAllocatedMb = Convert.ToDecimal(reader.GetValue(ordAllocatedMb));

                    if (ordUsedMb >= 0 && !reader.IsDBNull(ordUsedMb))
                        metrics.DatabaseUsedMb = Convert.ToDecimal(reader.GetValue(ordUsedMb));

                    if (ordTotalBackups >= 0 && !reader.IsDBNull(ordTotalBackups))
                        metrics.TotalBackups = Convert.ToInt32(reader.GetValue(ordTotalBackups));

                    if (ordTotalRestores >= 0 && !reader.IsDBNull(ordTotalRestores))
                        metrics.TotalRestores = Convert.ToInt32(reader.GetValue(ordTotalRestores));

                    if (ordLastRestoreTime >= 0 && !reader.IsDBNull(ordLastRestoreTime))
                        metrics.LastRestoreTimestamp = reader.GetDateTime(ordLastRestoreTime);

                    if (ordLastBackupTime >= 0 && !reader.IsDBNull(ordLastBackupTime))
                        metrics.LastBackupTimestamp = reader.GetDateTime(ordLastBackupTime);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[AuditDal.GetAdminDashboardMetrics] Error: {ex.Message}");
            }

            return metrics;
        }

        /// <summary>
        /// Obtiene los últimos N eventos críticos de auditoría mediante sp_GetLastCriticalAuditEvents.
        /// </summary>
        public List<AuditEvent> GetLastCriticalAuditEvents(int topCount = 15)
        {
            List<AuditEvent> events = new List<AuditEvent>();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand("dbo.sp_GetLastCriticalAuditEvents", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@TopCount", SqlDbType.Int) { Value = topCount });

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                int ordAuditId = GetOrdinalSafe(reader, "audit_id");
                int ordTimestamp = GetOrdinalSafe(reader, "timestamp");
                int ordEventType = GetOrdinalSafe(reader, "event_type");
                int ordActor = GetOrdinalSafe(reader, "actor");
                int ordOutcome = GetOrdinalSafe(reader, "outcome");
                int ordDetails = GetOrdinalSafe(reader, "details");

                while (reader.Read())
                {
                    events.Add(new AuditEvent
                    {
                        AuditId = ordAuditId >= 0 && !reader.IsDBNull(ordAuditId) ? Convert.ToInt32(reader.GetValue(ordAuditId)) : 0,
                        Timestamp = ordTimestamp >= 0 && !reader.IsDBNull(ordTimestamp) ? reader.GetDateTime(ordTimestamp) : DateTime.MinValue,
                        EventType = ordEventType >= 0 && !reader.IsDBNull(ordEventType) ? reader.GetString(ordEventType) : string.Empty,
                        Actor = ordActor >= 0 && !reader.IsDBNull(ordActor) ? reader.GetString(ordActor) : string.Empty,
                        Outcome = ordOutcome >= 0 && !reader.IsDBNull(ordOutcome) ? reader.GetString(ordOutcome) : string.Empty,
                        Details = ordDetails >= 0 && !reader.IsDBNull(ordDetails) ? reader.GetString(ordDetails) : null
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[AuditDal.GetLastCriticalAuditEvents] Error: {ex.Message}");
            }

            return events;
        }

        /// <summary>
        /// Obtiene el historial de auditoría de precios generado por el trigger mediante sp_GetProductPriceAuditHistory.
        /// </summary>
        public List<ProductPriceAuditRecord> GetProductPriceAuditHistory(int topCount = 100)
        {
            List<ProductPriceAuditRecord> records = new List<ProductPriceAuditRecord>();

            try
            {
                using SqlConnection connection = _dbConnection.GetConnection();
                using SqlCommand command = new SqlCommand("dbo.sp_GetProductPriceAuditHistory", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new SqlParameter("@TopCount", SqlDbType.Int) { Value = topCount });

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                int ordAuditId = GetOrdinalSafe(reader, "audit_id");
                int ordProductId = GetOrdinalSafe(reader, "product_id");
                int ordProductCode = GetOrdinalSafe(reader, "product_code");
                int ordProductName = GetOrdinalSafe(reader, "product_name");
                int ordOldPurchase = GetOrdinalSafe(reader, "old_purchase_price");
                int ordNewPurchase = GetOrdinalSafe(reader, "new_purchase_price");
                int ordOldSale = GetOrdinalSafe(reader, "old_sale_price");
                int ordNewSale = GetOrdinalSafe(reader, "new_sale_price");
                int ordChangeDate = GetOrdinalSafe(reader, "change_date");
                int ordSaleDiff = GetOrdinalSafe(reader, "sale_difference");
                int ordPercChange = GetOrdinalSafe(reader, "percentage_change");

                while (reader.Read())
                {
                    records.Add(new ProductPriceAuditRecord
                    {
                        AuditId = ordAuditId >= 0 && !reader.IsDBNull(ordAuditId) ? Convert.ToInt32(reader.GetValue(ordAuditId)) : 0,
                        ProductId = ordProductId >= 0 && !reader.IsDBNull(ordProductId) ? Convert.ToInt32(reader.GetValue(ordProductId)) : 0,
                        ProductCode = ordProductCode >= 0 && !reader.IsDBNull(ordProductCode) ? reader.GetString(ordProductCode) : string.Empty,
                        ProductName = ordProductName >= 0 && !reader.IsDBNull(ordProductName) ? reader.GetString(ordProductName) : string.Empty,
                        OldPurchasePrice = ordOldPurchase >= 0 && !reader.IsDBNull(ordOldPurchase) ? Convert.ToDecimal(reader.GetValue(ordOldPurchase)) : 0m,
                        NewPurchasePrice = ordNewPurchase >= 0 && !reader.IsDBNull(ordNewPurchase) ? Convert.ToDecimal(reader.GetValue(ordNewPurchase)) : 0m,
                        OldSalePrice = ordOldSale >= 0 && !reader.IsDBNull(ordOldSale) ? Convert.ToDecimal(reader.GetValue(ordOldSale)) : 0m,
                        NewSalePrice = ordNewSale >= 0 && !reader.IsDBNull(ordNewSale) ? Convert.ToDecimal(reader.GetValue(ordNewSale)) : 0m,
                        ChangeDate = ordChangeDate >= 0 && !reader.IsDBNull(ordChangeDate) ? reader.GetDateTime(ordChangeDate) : DateTime.MinValue,
                        SaleDifference = ordSaleDiff >= 0 && !reader.IsDBNull(ordSaleDiff) ? Convert.ToDecimal(reader.GetValue(ordSaleDiff)) : 0m,
                        PercentageChange = ordPercChange >= 0 && !reader.IsDBNull(ordPercChange) ? Convert.ToDecimal(reader.GetValue(ordPercChange)) : 0m
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[AuditDal.GetProductPriceAuditHistory] Error: {ex.Message}");
            }

            return records;
        }
    }
}
