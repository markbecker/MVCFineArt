using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFineArt.Models;
using MVCFineArt.Queries;

namespace MVCFineArt.Controllers
{
    public class ArtistsController : Controller
    {
        ArtistDb _db = new ArtistDb();

        //
        // GET: /Artists/

        public ActionResult Index()
        {
            var model = _db.Artists;
            return View(model);
        }

        //
        // GET: /Artists/Details/5

        public ActionResult ArtistDetails(int id)
        {
            var model = ArtistQueries.FindById(_db.Artists, id);
            return View(model);
        }

        //
        // GET: /Artists/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Artists/Create

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
        // GET: /Artists/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Artists/Edit/5

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
        // GET: /Artists/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Artists/Delete/5

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
