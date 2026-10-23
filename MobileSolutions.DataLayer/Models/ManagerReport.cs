using System;
using System.Collections.Generic;

namespace MobileSolutions.BusinessLayer.Models
{
    /// <summary>
    /// Resumen de KPIs gerenciales consolidados para el período consultado.
    /// </summary>
    public class ManagerKpiSummary
    {
        public int TotalSalesCount { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal AverageTicket { get; set; }
        public decimal MaxSale { get; set; }
        public decimal CashTotal { get; set; }
        public decimal TransferTotal { get; set; }
        public int CancelledSalesCount { get; set; }
        public int TotalInitiatedSales { get; set; }
        public decimal CancellationRate { get; set; }
        public decimal YearRevenue { get; set; }
        public decimal PreviousMonthRevenue { get; set; }
    }

    /// <summary>
    /// Ítem de ranking para el desempeño de vendedores.
    /// </summary>
    public class SellerPerformanceItem
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public int SalesCount { get; set; }
        public decimal TotalRevenue { get; set; }
        public bool IsTopSalesCount { get; set; }
        public bool IsBottomSalesCount { get; set; }
        public bool IsTopRevenue { get; set; }

        public string DisplayText => !string.IsNullOrWhiteSpace(FullName) ? FullName : Username;
    }

    /// <summary>
    /// Punto temporal para la evolución cronológica de facturación (gráfico de barras).
    /// </summary>
    public class RevenueTimelinePoint
    {
        public string PeriodLabel { get; set; } = string.Empty;
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal Revenue { get; set; }
    }

    /// <summary>
    /// Participación de un vendedor para el gráfico circular (Pie/Donut).
    /// </summary>
    public class SellerDistributionItem
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string SellerName { get; set; } = string.Empty;
        public int SalesCount { get; set; }
        public decimal TotalRevenue { get; set; }

        public string DisplayName => !string.IsNullOrWhiteSpace(SellerName) ? SellerName : Username;
    }

    /// <summary>
    /// Modelo contenedor del reporte completo de Gerente.
    /// </summary>
    public class ManagerReport
    {
        public ManagerKpiSummary KpiSummary { get; set; } = new();

        // Rankings de Vendedores (con soporte de empates)
        public List<SellerPerformanceItem> TopSellersByCount { get; set; } = new();
        public List<SellerPerformanceItem> BottomSellersByCount { get; set; } = new();
        public List<SellerPerformanceItem> TopSellersByRevenue { get; set; } = new();

        // Demanda de Productos (Celulares)
        public List<ProductRankingItem> MostSoldProducts { get; set; } = new();
        public List<ProductRankingItem> LeastSoldProducts { get; set; } = new();

        // Demanda de Marcas
        public List<BrandRankingItem> MostSoldBrands { get; set; } = new();
        public List<BrandRankingItem> LeastSoldBrands { get; set; } = new();

        // Datos para Gráficos
        public List<RevenueTimelinePoint> RevenueEvolution { get; set; } = new();
        public List<SellerDistributionItem> SellerDistribution { get; set; } = new();
    }
}
