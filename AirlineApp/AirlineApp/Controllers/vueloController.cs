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
    public class vueloController : Controller
    {
        private AirlineEntities db = new AirlineEntities();

        //
        // GET: /vuelo/

        public ViewResult Index()
        {
            var vuelo = db.vuelo.Include("aerolinea1").Include("aeropuerto").Include("aeropuerto1").Include("avion1");
            return View(vuelo.ToList());
        }

        //
        // GET: /vuelo/Details/5

        public ViewResult Details(string id)
        {
            vuelo vuelo = db.vuelo.Single(v => v.codigo == id);
            return View(vuelo);
        }

        //
        // GET: /vuelo/Create

        public ActionResult Create()
        {
            ViewBag.aerolinea = new SelectList(db.aerolinea, "codigo", "descripcion");
            ViewBag.origen = new SelectList(db.aeropuerto, "codigo", "descripcion");
            ViewBag.destino = new SelectList(db.aeropuerto, "codigo", "descripcion");
            ViewBag.avion = new SelectList(db.avion, "codigo", "descripcion");
            return View();
        } 

        //
        // POST: /vuelo/Create

        [HttpPost]
        public ActionResult Create(vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                db.vuelo.AddObject(vuelo);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.aerolinea = new SelectList(db.aerolinea, "codigo", "descripcion", vuelo.aerolinea);
            ViewBag.origen = new SelectList(db.aeropuerto, "codigo", "descripcion", vuelo.origen);
            ViewBag.destino = new SelectList(db.aeropuerto, "codigo", "descripcion", vuelo.destino);
            ViewBag.avion = new SelectList(db.avion, "codigo", "descripcion", vuelo.avion);
            return View(vuelo);
        }
        
        //
        // GET: /vuelo/Edit/5
 
        public ActionResult Edit(string id)
        {
            vuelo vuelo = db.vuelo.Single(v => v.codigo == id);
            ViewBag.aerolinea = new SelectList(db.aerolinea, "codigo", "descripcion", vuelo.aerolinea);
            ViewBag.origen = new SelectList(db.aeropuerto, "codigo", "descripcion", vuelo.origen);
            ViewBag.destino = new SelectList(db.aeropuerto, "codigo", "descripcion", vuelo.destino);
            ViewBag.avion = new SelectList(db.avion, "codigo", "descripcion", vuelo.avion);
            return View(vuelo);
        }

        //
        // POST: /vuelo/Edit/5

        [HttpPost]
        public ActionResult Edit(vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                db.vuelo.Attach(vuelo);
                db.ObjectStateManager.ChangeObjectState(vuelo, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.aerolinea = new SelectList(db.aerolinea, "codigo", "descripcion", vuelo.aerolinea);
            ViewBag.origen = new SelectList(db.aeropuerto, "codigo", "descripcion", vuelo.origen);
            ViewBag.destino = new SelectList(db.aeropuerto, "codigo", "descripcion", vuelo.destino);
            ViewBag.avion = new SelectList(db.avion, "codigo", "descripcion", vuelo.avion);
            return View(vuelo);
        }

        //
        // GET: /vuelo/Delete/5
 
        public ActionResult Delete(string id)
        {
            vuelo vuelo = db.vuelo.Single(v => v.codigo == id);
            return View(vuelo);
        }

        //
        // POST: /vuelo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            vuelo vuelo = db.vuelo.Single(v => v.codigo == id);
            db.vuelo.DeleteObject(vuelo);
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