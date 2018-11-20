using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Schools
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public string Notes { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string MoreInfo { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
