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
        private airlineEntities db = new airlineEntities();

        //
        // GET: /vuelo/

        public ViewResult Index()
        {
            var vueloes = db.vueloes.Include("aerolinea1").Include("aeropuerto").Include("aeropuerto1").Include("avion1");
            return View(vueloes.ToList());
        }

        //
        // GET: /vuelo/Details/5

        public ViewResult Details(int id)
        {
            vuelo vuelo = db.vueloes.Single(v => v.codigo == id);
            return View(vuelo);
        }

        //
        // GET: /vuelo/Create

        public ActionResult Create()
        {
            ViewBag.aerolinea = new SelectList(db.aerolineas, "codigo", "descripcion");
            ViewBag.origen = new SelectList(db.aeropuertoes, "codigo", "descripcion");
            ViewBag.destino = new SelectList(db.aeropuertoes, "codigo", "descripcion");
            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion");
            return View();
        } 

        //
        // POST: /vuelo/Create

        [HttpPost]
        public ActionResult Create(vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                db.vueloes.AddObject(vuelo);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.aerolinea = new SelectList(db.aerolineas, "codigo", "descripcion", vuelo.aerolinea);
            ViewBag.origen = new SelectList(db.aeropuertoes, "codigo", "descripcion", vuelo.origen);
            ViewBag.destino = new SelectList(db.aeropuertoes, "codigo", "descripcion", vuelo.destino);
            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion", vuelo.avion);
            return View(vuelo);
        }
        
        //
        // GET: /vuelo/Edit/5
 
        public ActionResult Edit(int id)
        {
            vuelo vuelo = db.vueloes.Single(v => v.codigo == id);
            ViewBag.aerolinea = new SelectList(db.aerolineas, "codigo", "descripcion", vuelo.aerolinea);
            ViewBag.origen = new SelectList(db.aeropuertoes, "codigo", "descripcion", vuelo.origen);
            ViewBag.destino = new SelectList(db.aeropuertoes, "codigo", "descripcion", vuelo.destino);
            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion", vuelo.avion);
            return View(vuelo);
        }

        //
        // POST: /vuelo/Edit/5

        [HttpPost]
        public ActionResult Edit(vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                db.vueloes.Attach(vuelo);
                db.ObjectStateManager.ChangeObjectState(vuelo, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.aerolinea = new SelectList(db.aerolineas, "codigo", "descripcion", vuelo.aerolinea);
            ViewBag.origen = new SelectList(db.aeropuertoes, "codigo", "descripcion", vuelo.origen);
            ViewBag.destino = new SelectList(db.aeropuertoes, "codigo", "descripcion", vuelo.destino);
            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion", vuelo.avion);
            return View(vuelo);
        }

        //
        // GET: /vuelo/Delete/5
 
        public ActionResult Delete(int id)
        {
            vuelo vuelo = db.vueloes.Single(v => v.codigo == id);
            return View(vuelo);
        }

        //
        // POST: /vuelo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            vuelo vuelo = db.vueloes.Single(v => v.codigo == id);
            db.vueloes.DeleteObject(vuelo);
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