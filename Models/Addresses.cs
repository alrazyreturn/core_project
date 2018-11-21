using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Addresses
    {
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int Id { get; set; }
        public string Street { get; set; }
        public string BuildingNum { get; set; }
        public string FlatNum { get; set; }
        public string MoreDetials { get; set; }
        public bool? PrimaryAddress { get; set; }
        public int? UserId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string District { get; set; }
        public DateTime? CreatedAt { get; set; }

        public Countries Country { get; set; }
        public Users User { get; set; }
    }
}
