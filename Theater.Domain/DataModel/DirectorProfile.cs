using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Theater.Domain.DataModel
{
    public class DirectorProfile
    {
        public int DirectorProfileId { get; set; }
        public int TheaterCompanyId { get; set; }
        public string TheaterUserId { get; set; }

        public string DirectorBio { get; set; }
        public int DirectorSince { get; set; }
        public byte[] DirectorPhoto { get; set; }


        [ForeignKey("TheaterUserId")]
        public TheaterUser TheaterUser { get; set; }

        [ForeignKey("TheaterCompanyId")]
        public TheaterCompany TheaterCompany { get; set; }

    }
}
