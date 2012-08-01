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
    public class configuracionController : Controller
    {
        private airlineEntities db = new airlineEntities();

        //
        // GET: /configuracion/

        public ViewResult Index()
        {
            var configuracions = db.configuracions.Include("avion1").Include("clas");
            return View(configuracions.ToList());
        }

        //
        // GET: /configuracion/Details/5

        public ViewResult Details(int id)
        {
            configuracion configuracion = db.configuracions.Single(c => c.avion == id);
            return View(configuracion);
        }

        //
        // GET: /configuracion/Create

        public ActionResult Create()
        {
            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion");
            ViewBag.clase = new SelectList(db.clases, "codigo", "descripcion");
            return View();
        } 

        //
        // POST: /configuracion/Create

        [HttpPost]
        public ActionResult Create(configuracion configuracion)
        {
            if (ModelState.IsValid)
            {
                db.configuracions.AddObject(configuracion);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion", configuracion.avion);
            ViewBag.clase = new SelectList(db.clases, "codigo", "descripcion", configuracion.clase);
            return View(configuracion);
        }
        
        //
        // GET: /configuracion/Edit/5
 
        public ActionResult Edit(int id)
        {
            configuracion configuracion = db.configuracions.Single(c => c.avion == id);
            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion", configuracion.avion);
            ViewBag.clase = new SelectList(db.clases, "codigo", "descripcion", configuracion.clase);
            return View(configuracion);
        }

        //
        // POST: /configuracion/Edit/5

        [HttpPost]
        public ActionResult Edit(configuracion configuracion)
        {
            if (ModelState.IsValid)
            {
                db.configuracions.Attach(configuracion);
                db.ObjectStateManager.ChangeObjectState(configuracion, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion", configuracion.avion);
            ViewBag.clase = new SelectList(db.clases, "codigo", "descripcion", configuracion.clase);
            return View(configuracion);
        }

        //
        // GET: /configuracion/Delete/5
 
        public ActionResult Delete(int id)
        {
            configuracion configuracion = db.configuracions.Single(c => c.avion == id);
            return View(configuracion);
        }

        //
        // POST: /configuracion/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            configuracion configuracion = db.configuracions.Single(c => c.avion == id);
            db.configuracions.DeleteObject(configuracion);
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