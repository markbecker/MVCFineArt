using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFineArt.Models
{
    public class Art
    {
        public virtual int ID { get; set; }
        public virtual string ArtistCode { get; set; }
        public virtual string Title { get; set; }
        public virtual string Medium { get; set; }
        public virtual string Date { get; set; }
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }
        public virtual double Depth { get; set; }
        public virtual double Price { get; set; }
        public virtual string Availability { get; set; }
        public virtual string SmallImagePath { get; set; }
        public virtual string MediumImagePath { get; set; }
        public virtual string LargeImagePath { get; set; }
    }
}