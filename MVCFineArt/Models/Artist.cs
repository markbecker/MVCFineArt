using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFineArt.Models
{
    public class Artist
    {
        public virtual int ID { get; set; }
        public virtual string ArtistCode { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Medium { get; set; }
        public virtual string SampleImage { get; set; }
    }
}