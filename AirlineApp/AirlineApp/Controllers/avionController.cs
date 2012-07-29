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
    public class avionController : Controller
    {
        private AirlineEntities db = new AirlineEntities();

        //
        // GET: /avion/

        public ViewResult Index()
        {
            return View(db.avion.ToList());
        }

        //
        // GET: /avion/Details/5

        public ViewResult Details(string id)
        {
            avion avion = db.avion.Single(a => a.codigo == id);
            return View(avion);
        }

        //
        // GET: /avion/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /avion/Create

        [HttpPost]
        public ActionResult Create(avion avion)
        {
            if (ModelState.IsValid)
            {
                db.avion.AddObject(avion);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(avion);
        }
        
        //
        // GET: /avion/Edit/5
 
        public ActionResult Edit(string id)
        {
            avion avion = db.avion.Single(a => a.codigo == id);
            return View(avion);
        }

        //
        // POST: /avion/Edit/5

        [HttpPost]
        public ActionResult Edit(avion avion)
        {
            if (ModelState.IsValid)
            {
                db.avion.Attach(avion);
                db.ObjectStateManager.ChangeObjectState(avion, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(avion);
        }

        //
        // GET: /avion/Delete/5
 
        public ActionResult Delete(string id)
        {
            avion avion = db.avion.Single(a => a.codigo == id);
            return View(avion);
        }

        //
        // POST: /avion/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            avion avion = db.avion.Single(a => a.codigo == id);
            db.avion.DeleteObject(avion);
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