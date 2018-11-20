using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;

namespace mad3.Models
{
    public partial class Users
    {
        public Users()
        {
            Addresses = new HashSet<Addresses>();
        }
    
        public int? SchoolId { get; set; }
        public int Id { get; set; }
        public int? RelgionId { get; set; }
        public string Email { get; set; }
        public string AName { get; set; }
        public string EName { get; set; }
        public string AName1 { get; set; }
        public string AName2 { get; set; }
        public string AName3 { get; set; }
        public string AName4 { get; set; }
        public string EName1 { get; set; }
        public string EName2 { get; set; }
        public string EName3 { get; set; }
        public string EName4 { get; set; }
        public string Password { get; set; }
        public string BirthDate { get; set; }
        public string RememberToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? KindId { get; set; }
        public int? GenderId { get; set; }
        public string TelphoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public int? NationalityId { get; set; }
        public int? BirthCountryId { get; set; }
        public string UserImg { get; set; }
        public int? StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public int? AddressId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual UserKinds Kind { get; set; }
        public virtual Countries Nationality { get; set; }
        public virtual Religion Relgion { get; set; }
        public virtual Parents Parents { get; set; }
        public virtual Students Students { get; set; }
        public virtual Teachers Teachers { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
