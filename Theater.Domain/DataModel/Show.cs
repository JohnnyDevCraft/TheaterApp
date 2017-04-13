using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Theater.Domain.DataModel
{
    public class Show
    {
        public int ShowId { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public DateTime? OpeningNight { get; set; }
        public DateTime? ClosingNight { get; set; }
        public int? DirectorId { get; set; }
        public int TheaterId { get; set; }
        public byte[] BannerImage { get; set; }
        public byte[] PosterImage { get; set; }
        public int ShowTypeId { get; set; }
        public bool Active { get; set; }



        [ForeignKey("TheaterId"]
        public Theater Theater { get; set; }

        [ForeignKey("DirectorId")]
        public DirectorProfile Director { get; set; }

        [ForeignKey("ShowTypeId")]
        public ReferenceType ShowType { get; set; }
    }
}
