using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Subjects
    {
        public string Code { get; set; }
        public int? SchoolId { get; set; }
        public string Title { get; set; }
        public int? LevelId { get; set; }
        public bool? Enable { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int Id { get; set; }
        public float? Cr { get; set; }
        public string TitleE { get; set; }

        public virtual Levels Level { get; set; }
    }
}
