using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Parents
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? RelationId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Users IdNavigation { get; set; }
        public Relations Relation { get; set; }
        public Students Student { get; set; }
    }
}
