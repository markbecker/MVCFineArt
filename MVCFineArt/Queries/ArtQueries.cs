using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCFineArt.Models;

namespace MVCFineArt.Queries
{
    public static class ArtQueries
    {
        public static IEnumerable<Art> FindTheLatest(this IQueryable<Art> artList, int numberOfPieces)
        {
            return artList.OrderByDescending(r => r.Date)
                          .Take(numberOfPieces).ToList();
        }

        public static IEnumerable<Art> FindTheLatest(this IList<Art> artList, int numberOfPieces)
        {
            return artList.OrderByDescending(r => r.Date)
                          .Take(numberOfPieces).ToList();
        }

        public static IEnumerable<Art> FindByArtist(this IQueryable<Art> artList, string artistCode)
        {
            return artList.OrderByDescending(d => d.Date).Where(a => a.ArtistCode == artistCode || (artistCode == null));
        }

        public static IEnumerable<Art> FindByArtist(this IList<Art> artList, string artistCode)
        {
            return artList.OrderByDescending(d => d.Date).Where(a => a.ArtistCode == artistCode || (artistCode == null));
        }

        public static Art FindArt(this IQueryable<Art> artList, int id)
        {
            return artList.Single(a => a.ID == id);
        }

        public static Art FindArt(this IList<Art> artList, int id)
        {
            return artList.Single(a => a.ID == id);
        }
    }
}