using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Times
    {
        public Times()
        {
            TimeTableEndTimeNavigation = new HashSet<TimeTable>();
            TimeTableStartTimeNavigation = new HashSet<TimeTable>();
        }

        public int Id { get; set; }
        public string Time { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }

        public ICollection<TimeTable> TimeTableEndTimeNavigation { get; set; }
        public ICollection<TimeTable> TimeTableStartTimeNavigation { get; set; }
    }
}
