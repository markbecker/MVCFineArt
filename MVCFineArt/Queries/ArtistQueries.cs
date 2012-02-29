using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCFineArt.Models;

namespace MVCFineArt.Queries
{
    public static class ArtistQueries
    {
        public static IEnumerable<Artist> FindTheLatest(this IQueryable<Artist> artists, int numberOfArtists)
        {
            return artists.OrderByDescending(a => a.LastName)
                          .Take(numberOfArtists).ToList();
        }

        public static IEnumerable<Artist> FindTheLatest(this IList<Artist> artists, int numberOfArtists)
        {
            return artists.OrderByDescending(a => a.LastName)
                          .Take(numberOfArtists).ToList();
        }

        public static Artist FindById(this IQueryable<Artist> artists, int id)
        {
            return artists.Single(a => a.ID == id);
        }

        public static Artist FindById(this IList<Artist> artists, int id)
        {
            return artists.Single(a => a.ID == id);
        }

        public static Artist FindByArtistCode(this IQueryable<Artist> artists, string artistCode)
        {
            return artists.Single(a => a.ArtistCode == artistCode);
        }

        public static Artist FindByArtistCode(this IList<Artist> artists, string artistCode)
        {
            return artists.Single(a => a.ArtistCode == artistCode);
        }
    }
}