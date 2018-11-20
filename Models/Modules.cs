using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Modules
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
