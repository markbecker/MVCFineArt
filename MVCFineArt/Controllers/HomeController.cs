using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFineArt.Models;

namespace MVCFineArt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to MVC Fine Art";

            var model = new Artist()
            {
                FirstName = "Mark",
                LastName = "Becker",
                Medium = "Photograhy",
                ExampleImage = "../../Content/Images/mbec1_22_v1_med.jpg"
            };

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
