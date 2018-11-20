using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Inbox
    {
        public int Id { get; set; }
        public int? FromUser { get; set; }
        public int? ToUser { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool? Read { get; set; }
        public int? AttacheId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
