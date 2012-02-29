using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFineArt.Models;
using MVCFineArt.Queries;

namespace MVCFineArt.Controllers
{
    public class HomeController : Controller
    {
        ArtistDb _db = new ArtistDb();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to MVC Fine Art";

            //var model = ArtistQueries.FindById(_db.Artists, 0);
            var model = _db.Artists;
            return View(model);

        }

        public ActionResult About()
        {
            return View();
        }
    }
}
