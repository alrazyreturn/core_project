using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Semesters
    {
        public Semesters()
        {
            TimeTable = new HashSet<TimeTable>();
        }

        public int Id { get; set; }
        public int? SemsterId { get; set; }
        public int? YearId { get; set; }
        public string SemesterCode { get; set; }
        public bool? StudySemester { get; set; }
        public bool? ControlSemester { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<TimeTable> TimeTable { get; set; }
    }
}
