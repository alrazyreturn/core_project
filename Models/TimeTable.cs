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

        public Days Day { get; set; }
        public Times EndTimeNavigation { get; set; }
        public Levels Level { get; set; }
        public Locations Location { get; set; }
        public Semesters Semester { get; set; }
        public Times StartTimeNavigation { get; set; }
    }
}
