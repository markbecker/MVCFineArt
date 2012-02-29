using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFineArt.Models
{
    public class ArtDb
    {
        static ArtDb()
        {
            _artList = new List<Art>();
            _artList.Add(new Art
            {
                ID = 0,
                ArtistCode = "mbec1",
                Title = "Mat I no4",
                Medium = "b/w photograph",
                Date = "1995",
                Height = 14.0,
                Width = 19.0,
                Depth = 0.0,
                Price = 500.00,
                Availability = "Available",
                SmallImagePath = "../../Content/Images/mbec1_22_v1_small.jpg",
                MediumImagePath = "../../Content/Images/mbec1_22_v1_med.jpg",
                LargeImagePath = "../../Content/Images/mbec1_22_v1.jpg"
            });

            _artList.Add(new Art
            {
                ID = 1,
                ArtistCode = "mbec1",
                Title = "Rocks III no1",
                Medium = "b/w photograph",
                Date = "1996",
                Height = 10.0,
                Width = 13.0,
                Depth = 0.0,
                Price = 400.00,
                Availability = "Available",
                SmallImagePath = "../../Content/Images/mbec1_25_v1_small.jpg",
                MediumImagePath = "../../Content/Images/mbec1_25_v1_med.jpg",
                LargeImagePath = "../../Content/Images/mbec1_25_v1.jpg"
            });

            _artList.Add(new Art
            {
                ID = 2,
                ArtistCode = "mbec1",
                Title = "Rocks III no3",
                Medium = "b/w photograph",
                Date = "1996",
                Height = 10.0,
                Width = 13.0,
                Depth = 0.0,
                Price = 400.00,
                Availability = "Available",
                SmallImagePath = "../../Content/Images/mbec1_27_v1_small.jpg",
                MediumImagePath = "../../Content/Images/mbec1_27_v1_med.jpg",
                LargeImagePath = "../../Content/Images/mbec1_27_v1.jpg"
            });

            _artList.Add(new Art
            {
                ID = 3,
                ArtistCode = "dlyn1",
                Title = "branch4",
                Medium = "acrylic on canvas",
                Date = "2003",
                Height = 49.0,
                Width = 24.0,
                Depth = 0.0,
                Price = 2500.00,
                Availability = "Available",
                SmallImagePath = "../../Content/Images/dlyn1_2_v2_small.jpg",
                MediumImagePath = "../../Content/Images/dlyn1_2_v2_med.jpg",
                LargeImagePath = "../../Content/Images/dlyn1_2_v2.jpg"
            });

            _artList.Add(new Art
            {
                ID = 4,
                ArtistCode = "dlyn1",
                Title = "the point",
                Medium = "acrylic on canvas",
                Date = "2003",
                Height = 49.0,
                Width = 49.0,
                Depth = 0.0,
                Price = 3000.00,
                Availability = "Available",
                SmallImagePath = "../../Content/Images/dlyn1_3_v1_small.jpg",
                MediumImagePath = "../../Content/Images/dlyn1_3_v1_med.jpg",
                LargeImagePath = "../../Content/Images/dlyn1_3_v1.jpg"
            });

            _artList.Add(new Art
            {
                ID = 5,
                ArtistCode = "dlyn1",
                Title = "branch6",
                Medium = "acrylic on canvas",
                Date = "2003",
                Height = 49.0,
                Width = 22.0,
                Depth = 0.0,
                Price = 2200.00,
                Availability = "Sold",
                SmallImagePath = "../../Content/Images/dlyn1_4_v1_small.jpg",
                MediumImagePath = "../../Content/Images/dlyn1_4_v1_med.jpg",
                LargeImagePath = "../../Content/Images/dlyn1_4_v1.jpg"
            });

            _artList.Add(new Art
            {
                ID = 6,
                ArtistCode = "mham1",
                Title = "Deep Blue Sea",
                Medium = "oil on paper",
                Date = "2000",
                Height = 20.0,
                Width = 30.0,
                Depth = 2.0,
                Price = 600.00,
                Availability = "Available",
                SmallImagePath = "../../Content/Images/mham1_23_v1_small.jpg",
                MediumImagePath = "../../Content/Images/mham1_23_v1_med.jpg",
                LargeImagePath = "../../Content/Images/mham1_23_v1.jpg"
            });

            _artList.Add(new Art
            {
                ID = 7,
                ArtistCode = "mham1",
                Title = "Beyond the Iron Gate",
                Medium = "oil on panel",
                Date = "2000",
                Height = 36.0,
                Width = 32.0,
                Depth = 2.0,
                Price = 2000.00,
                Availability = "Available",
                SmallImagePath = "../../Content/Images/mham1_25_v1_small.jpg",
                MediumImagePath = "../../Content/Images/mham1_25_v1_med.jpg",
                LargeImagePath = "../../Content/Images/mham1_25_v1.jpg"
            });

            _artList.Add(new Art
            {
                ID = 8,
                ArtistCode = "mham1",
                Title = "Beanstalk Kingdom",
                Medium = "oil on paper",
                Date = "2001",
                Height = 30.0,
                Width = 22.0,
                Depth = 0.0,
                Price = 800.00,
                Availability = "Available",
                SmallImagePath = "../../Content/Images/mham1_27_v1_small.jpg",
                MediumImagePath = "../../Content/Images/mham1_27_v1_med.jpg",
                LargeImagePath = "../../Content/Images/mham1_27_v1.jpg"
            });
        }

        public IList<Art> ArtList
        {
            get { return _artList; }
        }

        static List<Art> _artList;
    }
}