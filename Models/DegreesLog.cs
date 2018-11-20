using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class DegreesLog
    {
        public int Id { get; set; }
        public int? StdId { get; set; }
        public int? SubjectId { get; set; }
        public int? SemeterId { get; set; }
        public int? UserId { get; set; }
        public float? Q1 { get; set; }
        public float? Q2 { get; set; }
        public float? Q3 { get; set; }
        public string SerialId { get; set; }
        public float? Final { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string ActionName { get; set; }
        public double? Q4 { get; set; }
        public double? Q5 { get; set; }
        public double? Q6 { get; set; }
        public double? MedYear { get; set; }
        public double? MedOral { get; set; }
        public double? MedPractical { get; set; }
        public double? FinalOral { get; set; }
        public double? FinalPractical { get; set; }
    }
}
