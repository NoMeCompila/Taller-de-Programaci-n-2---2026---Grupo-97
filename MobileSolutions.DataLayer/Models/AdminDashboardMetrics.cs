using System;

namespace MobileSolutions.BusinessLayer.Models
{
    public class AdminDashboardMetrics
    {
        public string MostActiveUser { get; set; } = "Sin datos";
        public int MostActiveUserLoginCount { get; set; }
        public int OrphanAccountsCount { get; set; }
        public string LastLoginUser { get; set; } = "Sin registros";
        public DateTime? LastLoginTimestamp { get; set; }
        public int FailedLoginsLast24Hours { get; set; }

        public decimal DatabaseAllocatedMb { get; set; }
        public decimal DatabaseUsedMb { get; set; }
        public int TotalBackups { get; set; }
        public int TotalRestores { get; set; }
        public DateTime? LastRestoreTimestamp { get; set; }
        public DateTime? LastBackupTimestamp { get; set; }
    }
}
