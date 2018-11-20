using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Years
    {
        public int Id { get; set; }
        public int? YearId { get; set; }
        public string Code { get; set; }
        public bool? Study { get; set; }
        public bool? Control { get; set; }
    }
}
