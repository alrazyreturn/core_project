using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Students
    {
        public Students()
        {
            Parents = new HashSet<Parents>();
        }

        public int Id { get; set; }
        public int? StatusId { get; set; }
        public int? LevelId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Users IdNavigation { get; set; }
        public virtual Levels Level { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Parents> Parents { get; set; }
    }
}
