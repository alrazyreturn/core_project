using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Teachers
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Role { get; set; }

        public virtual Users IdNavigation { get; set; }
    }
}
