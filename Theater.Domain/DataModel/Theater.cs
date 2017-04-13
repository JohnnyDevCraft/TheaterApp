using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Theater.Domain.DataModel
{
    public class Theater
    {
        public int TheaterId { get; set; }
                
        #region TableFields
        public string Name { get; set; }
        public int PhysicalAddressId { get; set; }
        public int MailingAddressId { get; set; }
        public string MainPhone { get; set; }
        public string TicketPhone { get; set; }
        public string BillingPhone { get; set; }
        public int TheaterCompanyId { get; set; } 
        #endregion

        #region Navigation Properties
        [ForeignKey("TheaterCompanyId")]
        public TheaterCompany TheaterCompany { get; set; }

        [ForeignKey("PhysicalAddressId")]
        public Address PhysicalAddress { get; set; }

        [ForeignKey("MailingAddressId")]
        public Address MailingAddress { get; set; } 
        #endregion

    }
}
