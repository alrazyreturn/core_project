using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class TimeTable
    {
        public int Id { get; set; }
        public int? LocationId { get; set; }
        public int? SchoolId { get; set; }
        public int? SubjectId { get; set; }
        public int? LevelId { get; set; }
        public int? DayId { get; set; }
        public int? SemesterId { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }
        public int? TeacherId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CreatedBy { get; set; }

        public virtual Days Day { get; set; }
        public virtual Times EndTimeNavigation { get; set; }
        public virtual Levels Level { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Semesters Semester { get; set; }
        public virtual Times StartTimeNavigation { get; set; }
    }
}
