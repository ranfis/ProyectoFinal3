using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirlineApp.Models;

namespace AirlineApp.Controllers
{ 
    public class clasesController : Controller
    {
        private AirlineEntities db = new AirlineEntities();

        //
        // GET: /clases/

        public ViewResult Index()
        {
            return View(db.clases.ToList());
        }

        //
        // GET: /clases/Details/5

        public ViewResult Details(string id)
        {
            clases clases = db.clases.Single(c => c.codigo == id);
            return View(clases);
        }

        //
        // GET: /clases/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /clases/Create

        [HttpPost]
        public ActionResult Create(clases clases)
        {
            if (ModelState.IsValid)
            {
                db.clases.AddObject(clases);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(clases);
        }
        
        //
        // GET: /clases/Edit/5
 
        public ActionResult Edit(string id)
        {
            clases clases = db.clases.Single(c => c.codigo == id);
            return View(clases);
        }

        //
        // POST: /clases/Edit/5

        [HttpPost]
        public ActionResult Edit(clases clases)
        {
            if (ModelState.IsValid)
            {
                db.clases.Attach(clases);
                db.ObjectStateManager.ChangeObjectState(clases, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clases);
        }

        //
        // GET: /clases/Delete/5
 
        public ActionResult Delete(string id)
        {
            clases clases = db.clases.Single(c => c.codigo == id);
            return View(clases);
        }

        //
        // POST: /clases/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            clases clases = db.clases.Single(c => c.codigo == id);
            db.clases.DeleteObject(clases);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}