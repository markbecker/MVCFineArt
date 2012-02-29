using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFineArt.Models;
using MVCFineArt.Queries;

namespace MVCFineArt.Controllers
{
    public class ArtController : Controller
    {
        ArtDb _artDb = new ArtDb();
        ArtistDb _artistDb = new ArtistDb();

        //
        // GET: /Art/

        public ActionResult Index()
        {
            var model = _artDb.ArtList;
            return View(model);
        }

        //
        // GET: /Art/ArtByArtist/mbec1

        public ActionResult ArtByArtist(string artistCode)
        {
            var model = ArtQueries.FindByArtist(_artDb.ArtList, artistCode);
            var artist = ArtistQueries.FindByArtistCode(_artistDb.Artists, artistCode);
            ViewBag.FirstName = artist.FirstName;
            ViewBag.LastName = artist.LastName;

            return View(model);
        }

        //
        // GET: /Art/ArtDetails/5

        public ActionResult ArtDetails(int id)
        {
            var model = ArtQueries.FindArt(_artDb.ArtList, id);
            var artist = ArtistQueries.FindByArtistCode(_artistDb.Artists, model.ArtistCode);
            ViewBag.FirstName = artist.FirstName;
            ViewBag.LastName = artist.LastName;

            return View(model);
        }

        //
        // GET: /Art/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Art/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Art/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Art/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Art/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Art/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
