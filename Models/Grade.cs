using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Grade
    {
        public int Id { get; set; }
        public float? DegreeFrom { get; set; }
        public float? DegreeTo { get; set; }
        public string Grade1 { get; set; }
        public string GradeArabic { get; set; }
        public string GradeEnglish { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
