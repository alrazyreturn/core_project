using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Parents
    {

        public Parents()
        {
        }
        private Parents(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        private ILazyLoader LazyLoader { get; set; }

        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? RelationId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Users IdNavigation { get; set; }
        public virtual Relations Relation { get; set; }
        public virtual Students Student { get; set; }
    }
}
