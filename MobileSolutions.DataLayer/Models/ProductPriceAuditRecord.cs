using System;

namespace MobileSolutions.BusinessLayer.Models
{
    public class ProductPriceAuditRecord
    {
        public int AuditId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal OldPurchasePrice { get; set; }
        public decimal NewPurchasePrice { get; set; }
        public decimal OldSalePrice { get; set; }
        public decimal NewSalePrice { get; set; }
        public DateTime ChangeDate { get; set; }
        public decimal SaleDifference { get; set; }
        public decimal PercentageChange { get; set; }
    }
}
