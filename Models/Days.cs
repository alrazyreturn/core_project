using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Days
    {
        public Days()
        {
            TimeTable = new HashSet<TimeTable>();
        }

        public int Id { get; set; }
        public string DayA { get; set; }
        public string DayE { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<TimeTable> TimeTable { get; set; }
    }
}
