using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Notifications
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int NotifiableId { get; set; }
        public string NotifiableType { get; set; }
        public string Data { get; set; }
        public DateTime? ReadAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
