using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Theater.Domain.DataModel
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HomeAddressId { get; set; }
        public string CellPhone { get; set; }
        public string HomePhone { get; set; }
        public string FaxLine { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }

        [ForeignKey("GenderId")]
        public ReferenceType Gender { get; set; }

        [ForeignKey("HomeAddressId")]
        public Address HomeAddress { get; set; }
    }
}
