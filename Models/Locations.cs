using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Locations
    {
        public Locations()
        {
            TimeTable = new HashSet<TimeTable>();
        }

        public int Id { get; set; }
        public string Location { get; set; }
        public string LevelId { get; set; }
        public string Building { get; set; }
        public string Capacity { get; set; }
        public string Kind { get; set; }
        public string Notes { get; set; }
        public int SchoolId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<TimeTable> TimeTable { get; set; }
    }
}
