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
        private airlineEntities db = new airlineEntities();

        //
        // GET: /avion/

        public ViewResult Index()
        {
            return View(db.avions.ToList());
        }

        //
        // GET: /avion/Details/5

        public ViewResult Details(int id)
        {
            avion avion = db.avions.Single(a => a.codigo == id);
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
        public void Create(int txtCodigo, string txtNombre, int[] clases, int[] numClases)
        {

            avion avion = new avion();

            avion.codigo = txtCodigo;
            avion.descripcion = txtNombre;
            db.avions.AddObject(avion);


            int capacidad = 0;

            for (int i = 0; i < numClases.Length; i++)
            {
                configuracion con = new configuracion();
                con.avion = txtCodigo;
                con.clase = clases[i];
                con.capacidad = numClases[i];
                capacidad += numClases[i];
                db.configuracions.AddObject(con);
            }
            avion.capacidad = capacidad;
            db.SaveChanges();
            Response.Redirect("Index");


        }
        
        //
        // GET: /avion/Edit/5
 
        public ActionResult Edit(int id)
        {
            avion avion = db.avions.Single(a => a.codigo == id);
            return View(avion);
        }

        //
        // POST: /avion/Edit/5

        [HttpPost]
        public ActionResult Edit(avion avion)
        {
            if (ModelState.IsValid)
            {
                db.avions.Attach(avion);
                db.ObjectStateManager.ChangeObjectState(avion, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(avion);
        }

        //
        // GET: /avion/Delete/5
 
        public ActionResult Delete(int id)
        {
            avion avion = db.avions.Single(a => a.codigo == id);
            return View(avion);
        }

        //
        // POST: /avion/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            avion avion = db.avions.Single(a => a.codigo == id);
            db.avions.DeleteObject(avion);
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