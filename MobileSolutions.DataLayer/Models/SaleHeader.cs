using System;
using System.Collections.Generic;
using System.Text;

namespace MobileSolutions.BusinessLayer.Models
{
    public class SaleHeader
    {
        public int SaleId { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public string CustomerDni { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerLastname { get; set; } = string.Empty;
        public string CustomerFullName => $"{CustomerName} {CustomerLastname}".Trim();
        public int UserId { get; set; }
        public string UserUsername { get; set; } = string.Empty;
        public string SellerName { get; set; } = string.Empty;
        public string SellerLastname { get; set; } = string.Empty;
        public string SellerFullName => $"{SellerName} {SellerLastname}".Trim();
        public string SaleNumber { get; set; } = string.Empty;
        public DateTime SaleDate { get; set; }
        public decimal TotalSale { get; set; }
        public bool Status { get; set; } = true;
        public List<SaleDetail> Details { get; set; } = new();
    }
}
