using System;
using System.Collections.Generic;
using System.Linq;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.DataLayer;

namespace MobileSolutions.BusinessLayer
{
    public class ManagerReportService
    {
        private readonly ManagerReportDal _managerReportDal;

        public ManagerReportService()
        {
            _managerReportDal = new ManagerReportDal();
        }

        #region Validación de Rol y Rango de Fechas

        private static void ValidateManagerAccess()
        {
            if (!CurrentSession.IsAuthenticated)
            {
                throw new UnauthorizedAccessException("Debe iniciar sesión para consultar los reportes gerenciales.");
            }

            // En la base de datos: Profile 1 = Administrador, Profile 2 = Vendedor, Profile 3 = Gerente
            // Se autoriza a Gerente y Administrador
            string profile = CurrentSession.ProfileName.Trim().ToLowerInvariant();
            bool isAuthorized = profile.Contains("gerente") ||
                                profile.Contains("manager") ||
                                profile.Contains("admin") ||
                                CurrentSession.ProfileId == 1 ||
                                CurrentSession.ProfileId == 3;

            if (!isAuthorized)
            {
                throw new UnauthorizedAccessException("Acceso denegado: este módulo está restringido al perfil de Gerente o Administrador.");
            }
        }

        private static (DateTime Start, DateTime End) ResolveDateRange(DateTime? startDate, DateTime? endDate)
        {
            DateTime now = DateTime.Now;

            DateTime resolvedStart = (startDate ?? new DateTime(now.Year, now.Month, 1)).Date;
            DateTime resolvedEnd = (endDate ?? new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month))).Date;

            if (resolvedStart > resolvedEnd)
            {
                throw new ArgumentException("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.");
            }

            // Normalizamos el fin del día (23:59:59)
            resolvedEnd = resolvedEnd.AddDays(1).AddSeconds(-1);

            return (resolvedStart, resolvedEnd);
        }

        #endregion

        #region Métodos de Consulta Individuales

        public ManagerKpiSummary GetManagerKpiSummary(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);
            return _managerReportDal.GetManagerKpiSummary(start, end);
        }

        public List<SellerPerformanceItem> GetTopBottomSellers(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);
            return _managerReportDal.GetTopBottomSellers(start, end);
        }

        public List<ProductRankingItem> GetMostSoldProducts(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);
            return _managerReportDal.GetMostSoldProducts(start, end);
        }

        public List<ProductRankingItem> GetLeastSoldProducts(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);
            return _managerReportDal.GetLeastSoldProducts(start, end);
        }

        public List<BrandRankingItem> GetMostSoldBrands(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);
            return _managerReportDal.GetMostSoldBrands(start, end);
        }

        public List<BrandRankingItem> GetLeastSoldBrands(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);
            return _managerReportDal.GetLeastSoldBrands(start, end);
        }

        public List<RevenueTimelinePoint> GetRevenueEvolution(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);
            return _managerReportDal.GetRevenueEvolution(start, end);
        }

        public List<SellerDistributionItem> GetSellerDistribution(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);
            return _managerReportDal.GetSellerDistribution(start, end);
        }

        #endregion

        #region Orquestación del Reporte Gerencial Completo

        public ManagerReport GetManagerPerformanceReport(DateTime? startDate = null, DateTime? endDate = null)
        {
            ValidateManagerAccess();
            var (start, end) = ResolveDateRange(startDate, endDate);

            var sellers = _managerReportDal.GetTopBottomSellers(start, end);

            // Discriminamos los grupos con empates en base a las banderas calculadas
            var topByCount = sellers.Where(s => s.IsTopSalesCount).ToList();
            var bottomByCount = sellers.Where(s => s.IsBottomSalesCount).ToList();
            var topByRevenue = sellers.Where(s => s.IsTopRevenue).ToList();

            return new ManagerReport
            {
                KpiSummary = _managerReportDal.GetManagerKpiSummary(start, end),
                TopSellersByCount = topByCount,
                BottomSellersByCount = bottomByCount,
                TopSellersByRevenue = topByRevenue,
                MostSoldProducts = _managerReportDal.GetMostSoldProducts(start, end),
                LeastSoldProducts = _managerReportDal.GetLeastSoldProducts(start, end),
                MostSoldBrands = _managerReportDal.GetMostSoldBrands(start, end),
                LeastSoldBrands = _managerReportDal.GetLeastSoldBrands(start, end),
                RevenueEvolution = _managerReportDal.GetRevenueEvolution(start, end),
                SellerDistribution = _managerReportDal.GetSellerDistribution(start, end)
            };
        }

        #endregion
    }
}
