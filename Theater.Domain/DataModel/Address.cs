using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Theater.Domain.DataModel
{
    public class Address
    {
        public int AddressId { get; set; }        
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }


        
        [ForeignKey("StateId")]
        public ReferenceType State { get; set; }        
    }
}
