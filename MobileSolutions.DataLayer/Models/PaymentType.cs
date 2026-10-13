using System;
using System.Collections.Generic;
using System.Text;

namespace MobileSolutions.BusinessLayer.Models
{
    public class PaymentType
    {
        public int PaymentTypeId { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}
