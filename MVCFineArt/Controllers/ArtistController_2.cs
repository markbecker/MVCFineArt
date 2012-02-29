using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFineArt.Controllers
{
    public class ArtistController_2 : Controller
    {

        public ActionResult Search(string artistCode = "*")
        {
            if (artistCode == "*")
            {
                return RedirectToRoute("Artist", new { artistCode = "mbec" });
            }
            artistCode = Server.HtmlEncode(artistCode);
            return Content(artistCode);
        }

    }
}
