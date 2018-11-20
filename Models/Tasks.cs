using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
