using System;
using System.Collections.Generic;
using System.Text;

namespace MobileSolutions.BusinessLayer.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int ProfileId { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string? Password { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime Birth { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string Locality { get; set; } = string.Empty;
        public DateTime RegisterDate { get; set; }

    }
}
