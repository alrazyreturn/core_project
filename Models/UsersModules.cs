using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class UsersModules
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ModuleId { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? AccessPage { get; set; }
        public bool? CreatePage { get; set; }
        public bool? PrintPage { get; set; }
        public bool? Confirm { get; set; }
        public bool? UpdatePage { get; set; }
    }
}
