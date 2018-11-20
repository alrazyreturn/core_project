using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Relations
    {
        public Relations()
        {
            Parents = new HashSet<Parents>();
        }

        public int Id { get; set; }
        public string Kind { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Parents> Parents { get; set; }
    }
}
