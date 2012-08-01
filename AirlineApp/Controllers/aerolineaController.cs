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
    public class aerolineaController : Controller
    {
        private airlineEntities db = new airlineEntities();

        //
        // GET: /aerolinea/

        public ViewResult Index()
        {
            return View(db.aerolineas.ToList());
        }

        //
        // GET: /aerolinea/Details/5

        public ViewResult Details(string id)
        {
            aerolinea aerolinea = db.aerolineas.Single(a => a.codigo == id);
            return View(aerolinea);
        }

        //
        // GET: /aerolinea/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /aerolinea/Create

        [HttpPost]
        public ActionResult Create(aerolinea aerolinea)
        {
            if (ModelState.IsValid)
            {
                db.aerolineas.AddObject(aerolinea);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(aerolinea);
        }
        
        //
        // GET: /aerolinea/Edit/5
 
        public ActionResult Edit(string id)
        {
            aerolinea aerolinea = db.aerolineas.Single(a => a.codigo == id);
            return View(aerolinea);
        }

        //
        // POST: /aerolinea/Edit/5

        [HttpPost]
        public ActionResult Edit(aerolinea aerolinea)
        {
            if (ModelState.IsValid)
            {
                db.aerolineas.Attach(aerolinea);
                db.ObjectStateManager.ChangeObjectState(aerolinea, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aerolinea);
        }

        //
        // GET: /aerolinea/Delete/5
 
        public ActionResult Delete(string id)
        {
            aerolinea aerolinea = db.aerolineas.Single(a => a.codigo == id);
            return View(aerolinea);
        }

        //
        // POST: /aerolinea/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            aerolinea aerolinea = db.aerolineas.Single(a => a.codigo == id);
            db.aerolineas.DeleteObject(aerolinea);
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