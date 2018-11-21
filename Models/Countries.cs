using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Addresses = new HashSet<Addresses>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CountryId { get; set; }
        public string CountryA { get; set; }
        public string CountryE { get; set; }
        public string NationalityA { get; set; }
        public string NationalityE { get; set; }
        public string PhoneCode { get; set; }
        public string NationalityAF { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedAt { get; set; }

        public ICollection<Addresses> Addresses { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
