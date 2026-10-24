using System;

namespace MobileSolutions.BusinessLayer.Models
{
    public class AuditEvent
    {
        public int AuditId { get; set; }
        public DateTime Timestamp { get; set; }
        public string EventType { get; set; } = string.Empty;
        public string Actor { get; set; } = string.Empty;
        public string Outcome { get; set; } = string.Empty;
        public string? Details { get; set; }
    }
}
