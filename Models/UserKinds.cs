using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class UserKinds
    {
        public UserKinds()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Kind { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
