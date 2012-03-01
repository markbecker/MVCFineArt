using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFineArt.Models
{
    public class ArtistDb
    {
        static ArtistDb()
        {
            _artists = new List<Artist>();
            _artists.Add(new Artist
            {
                ID = 0,
                ArtistCode = "mbec1",
                FirstName = "Mark",
                LastName = "Becker",
                Medium = "Photograhy",
                SampleImage = "../../Content/Images/mbec1_22_v1_small.jpg",
                Biography = "../../Content/Biographies/bio_mbec1.js"
            });

            _artists.Add(new Artist
            {
                ID = 1,
                ArtistCode = "dlyn1",
                FirstName = "Derek",
                LastName = "Lynch",
                Medium = "Painting",
                SampleImage = "../../Content/Images/dlyn1_2_v2_small.jpg",
                Biography = "../../Content/Biographies/bio_dlyn1.js"
            });

            _artists.Add(new Artist
            {
                ID = 2,
                ArtistCode = "mham1",
                FirstName = "Marc Ellen",
                LastName = "Hamel",
                Medium = "Painting",
                SampleImage = "../../Content/Images/mham1_23_v1_small.jpg",
                Biography = "../../Content/Biographies/bio_mham1.js"
            });
        }

        public IList<Artist> Artists
        {
            get { return _artists; }
        }

        static List<Artist> _artists;
    }
}