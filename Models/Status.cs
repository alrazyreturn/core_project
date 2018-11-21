using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Status
    {
        public Status()
        {
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string Kind { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
