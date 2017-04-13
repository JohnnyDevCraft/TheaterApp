using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Theater.Domain.DataModel
{
    public class TheaterCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BillingAddressId { get; set; }
        public int PhysicalAddressId { get; set; }
        public string PrimaryPhone { get; set; }
        public string BillingPhone { get; set; }


        [ForeignKey("PhysicalAddressId")]
        public Address PhysicalAddress { get; set; }
        [ForeignKey("BillingAddressId")]
        public Address BillingAddress { get; set; }
    }
}
