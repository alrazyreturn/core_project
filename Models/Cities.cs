using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Cities
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CountryId { get; set; }
        public string CCode { get; set; }
        public string Name { get; set; }
    }
}
