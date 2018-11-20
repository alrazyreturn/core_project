using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Events
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string AllDay { get; set; }
        public string Color { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? SubjectId { get; set; }
        public int? LevelId { get; set; }
        public int? LocationId { get; set; }
        public int? EventTypeId { get; set; }
    }
}
