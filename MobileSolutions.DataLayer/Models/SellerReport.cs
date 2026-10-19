using System;
using System.Collections.Generic;

namespace MobileSolutions.BusinessLayer.Models
{
    public class SellerKpiSummary
    {
        public int TotalSalesCount { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal AverageTicket { get; set; }
        public decimal MaxSale { get; set; }
        public decimal CashTotal { get; set; }
        public decimal TransferTotal { get; set; }
        public decimal PreviousMonthRevenue { get; set; }
    }

    public class ProductRankingItem
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public int UnitsSold { get; set; }
        public string DisplayText => string.IsNullOrWhiteSpace(ProductCode)
            ? $"{ProductName} ({UnitsSold} u.)"
            : $"[{ProductCode}] {ProductName} ({UnitsSold} u.)";
    }

    public class BrandRankingItem
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public int UnitsSold { get; set; }
        public string DisplayText => $"{BrandName} ({UnitsSold} u.)";
    }

    public class DailySalesPoint
    {
        public int Day { get; set; }
        public decimal Revenue { get; set; }
    }

    public class SellerReport
    {
        public SellerKpiSummary KpiSummary { get; set; } = new();
        public List<ProductRankingItem> MostSoldProducts { get; set; } = new();
        public List<ProductRankingItem> LeastSoldProducts { get; set; } = new();
        public List<BrandRankingItem> MostSoldBrands { get; set; } = new();
        public List<BrandRankingItem> LeastSoldBrands { get; set; } = new();
        public List<DailySalesPoint> DailyEvolution { get; set; } = new();
        public List<ProductRankingItem> Top5Products { get; set; } = new();
        public List<BrandRankingItem> BrandDistribution { get; set; } = new();
    }
}
