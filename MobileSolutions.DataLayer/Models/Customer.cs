using System;
using System.Collections.Generic;
using System.Text;

namespace MobileSolutions.BusinessLayer.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime Birth { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string Locality { get; set; } = string.Empty;
        public DateTime RegisterDate { get; set; }
    }
}
