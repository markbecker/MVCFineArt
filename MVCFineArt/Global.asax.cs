using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFineArt
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Added for 'artists/artistCode' routing 
            routes.MapRoute(
                "Artists",
                "Artists/{artistCode}",
                new { controller = "Artists", action = "Index", artistCode = UrlParameter.Optional }
            );

            // Added for 'art/artByArtist' routing 
            routes.MapRoute(
                "Art/ArtByArtist",
                "Art/ArtByArtist/{artistCode}",
                new { controller = "Art", action = "ArtByArtist", artistCode = UrlParameter.Optional }
            );

            // Added for 'art/' routing 
            routes.MapRoute(
                "Art/ArtDetails",
                "Art/ArtDetails/{id}",
                new { controller = "Art", action = "ArtDetails", id = UrlParameter.Optional }
            );

            // Added for 'art/' routing 
            routes.MapRoute(
                "Art",
                "Art/{action}/{id}",
                new { controller = "Artists", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}