using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Theater.Domain.DataModel
{
    public class ReferenceType
    {
        public int ReferenceTypeId { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Public { get; set; }
        public int TheaterId { get; set; }

        [ForeignKey("TheaterId")]
        public TheaterCompany Theater { get; set; }
    }
}
