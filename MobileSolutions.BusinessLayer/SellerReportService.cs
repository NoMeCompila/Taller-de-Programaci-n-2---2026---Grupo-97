using System;
using System.Collections.Generic;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.DataLayer;

namespace MobileSolutions.BusinessLayer
{
    public class SellerReportService
    {
        private readonly SellerReportDal _sellerReportDal;

        public SellerReportService()
        {
            _sellerReportDal = new SellerReportDal();
        }

        #region Validación de Sesión y Período (AC1: Personal Data Boundary)

        private static int GetAuthenticatedSellerId()
        {
            if (!CurrentSession.IsAuthenticated || CurrentSession.UserId <= 0)
            {
                throw new UnauthorizedAccessException("No hay una sesión de vendedor activa para consultar el reporte personal.");
            }

            return CurrentSession.UserId;
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

            resolvedEnd = resolvedEnd.AddDays(1).AddSeconds(-1);

            return (resolvedStart, resolvedEnd);
        }

        private static (int Year, int Month) ResolveTargetPeriod(int? year, int? month)
        {
            DateTime now = DateTime.Now;
            int targetYear = year ?? now.Year;
            int targetMonth = month ?? now.Month;

            if (targetYear < 2000 || targetYear > 2100)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "El año indicado para el reporte no es válido.");
            }

            if (targetMonth < 1 || targetMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "El mes indicado debe estar entre 1 y 12.");
            }

            return (targetYear, targetMonth);
        }

        #endregion

        #region Métodos de Consulta Individuales (Single Responsibility)

        public SellerKpiSummary GetSellerKpiSummary(int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            if (startDate.HasValue && endDate.HasValue)
            {
                var (start, end) = ResolveDateRange(startDate, endDate);
                return _sellerReportDal.GetSellerKpiSummary(sellerId, null, null, start, end);
            }
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);
            return _sellerReportDal.GetSellerKpiSummary(sellerId, targetYear, targetMonth);
        }

        public List<ProductRankingItem> GetSellerMostSoldProducts(int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            if (startDate.HasValue && endDate.HasValue)
            {
                var (start, end) = ResolveDateRange(startDate, endDate);
                return _sellerReportDal.GetSellerMostSoldProducts(sellerId, null, null, start, end);
            }
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);
            return _sellerReportDal.GetSellerMostSoldProducts(sellerId, targetYear, targetMonth);
        }

        public List<ProductRankingItem> GetSellerLeastSoldProducts(int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            if (startDate.HasValue && endDate.HasValue)
            {
                var (start, end) = ResolveDateRange(startDate, endDate);
                return _sellerReportDal.GetSellerLeastSoldProducts(sellerId, null, null, start, end);
            }
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);
            return _sellerReportDal.GetSellerLeastSoldProducts(sellerId, targetYear, targetMonth);
        }

        public List<BrandRankingItem> GetSellerMostSoldBrands(int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            if (startDate.HasValue && endDate.HasValue)
            {
                var (start, end) = ResolveDateRange(startDate, endDate);
                return _sellerReportDal.GetSellerMostSoldBrands(sellerId, null, null, start, end);
            }
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);
            return _sellerReportDal.GetSellerMostSoldBrands(sellerId, targetYear, targetMonth);
        }

        public List<BrandRankingItem> GetSellerLeastSoldBrands(int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            if (startDate.HasValue && endDate.HasValue)
            {
                var (start, end) = ResolveDateRange(startDate, endDate);
                return _sellerReportDal.GetSellerLeastSoldBrands(sellerId, null, null, start, end);
            }
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);
            return _sellerReportDal.GetSellerLeastSoldBrands(sellerId, targetYear, targetMonth);
        }

        public List<DailySalesPoint> GetSellerDailyEvolution(int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            if (startDate.HasValue && endDate.HasValue)
            {
                var (start, end) = ResolveDateRange(startDate, endDate);
                return _sellerReportDal.GetSellerDailyEvolution(sellerId, null, null, start, end);
            }
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);
            return _sellerReportDal.GetSellerDailyEvolution(sellerId, targetYear, targetMonth);
        }

        public List<ProductRankingItem> GetSellerTop5Products(int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            if (startDate.HasValue && endDate.HasValue)
            {
                var (start, end) = ResolveDateRange(startDate, endDate);
                return _sellerReportDal.GetSellerTop5Products(sellerId, null, null, start, end);
            }
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);
            return _sellerReportDal.GetSellerTop5Products(sellerId, targetYear, targetMonth);
        }

        public List<BrandRankingItem> GetSellerBrandDistribution(int? year = null, int? month = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            if (startDate.HasValue && endDate.HasValue)
            {
                var (start, end) = ResolveDateRange(startDate, endDate);
                return _sellerReportDal.GetSellerBrandDistribution(sellerId, null, null, start, end);
            }
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);
            return _sellerReportDal.GetSellerBrandDistribution(sellerId, targetYear, targetMonth);
        }

        #endregion

        #region Orquestación del Reporte Completo del Vendedor

        public SellerReport GetSellerPerformanceReport(int? year = null, int? month = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            var (targetYear, targetMonth) = ResolveTargetPeriod(year, month);

            return new SellerReport
            {
                KpiSummary = _sellerReportDal.GetSellerKpiSummary(sellerId, targetYear, targetMonth),
                MostSoldProducts = _sellerReportDal.GetSellerMostSoldProducts(sellerId, targetYear, targetMonth),
                LeastSoldProducts = _sellerReportDal.GetSellerLeastSoldProducts(sellerId, targetYear, targetMonth),
                MostSoldBrands = _sellerReportDal.GetSellerMostSoldBrands(sellerId, targetYear, targetMonth),
                LeastSoldBrands = _sellerReportDal.GetSellerLeastSoldBrands(sellerId, targetYear, targetMonth),
                DailyEvolution = _sellerReportDal.GetSellerDailyEvolution(sellerId, targetYear, targetMonth),
                Top5Products = _sellerReportDal.GetSellerTop5Products(sellerId, targetYear, targetMonth),
                BrandDistribution = _sellerReportDal.GetSellerBrandDistribution(sellerId, targetYear, targetMonth)
            };
        }

        public SellerReport GetSellerPerformanceReportByRange(DateTime? startDate = null, DateTime? endDate = null)
        {
            int sellerId = GetAuthenticatedSellerId();
            var (start, end) = ResolveDateRange(startDate, endDate);

            return new SellerReport
            {
                KpiSummary = _sellerReportDal.GetSellerKpiSummary(sellerId, null, null, start, end),
                MostSoldProducts = _sellerReportDal.GetSellerMostSoldProducts(sellerId, null, null, start, end),
                LeastSoldProducts = _sellerReportDal.GetSellerLeastSoldProducts(sellerId, null, null, start, end),
                MostSoldBrands = _sellerReportDal.GetSellerMostSoldBrands(sellerId, null, null, start, end),
                LeastSoldBrands = _sellerReportDal.GetSellerLeastSoldBrands(sellerId, null, null, start, end),
                DailyEvolution = _sellerReportDal.GetSellerDailyEvolution(sellerId, null, null, start, end),
                Top5Products = _sellerReportDal.GetSellerTop5Products(sellerId, null, null, start, end),
                BrandDistribution = _sellerReportDal.GetSellerBrandDistribution(sellerId, null, null, start, end)
            };
        }

        #endregion
    }
}
