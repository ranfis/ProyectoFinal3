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
    public class ClasesController : Controller
    {
        private airlineEntities db = new airlineEntities();

        //
        // GET: /Clases/

        public ViewResult Index()
        {
            return View(db.clases.ToList());
        }

        //
        // GET: /Clases/Details/5

        public ViewResult Details(int id)
        {
            clas clas = db.clases.Single(c => c.codigo == id);
            return View(clas);
        }

        //
        // GET: /Clases/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Clases/Create

        [HttpPost]
        public ActionResult Create(clas clas)
        {
            if (ModelState.IsValid)
            {
                db.clases.AddObject(clas);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(clas);
        }
        
        //
        // GET: /Clases/Edit/5
 
        public ActionResult Edit(int id)
        {
            clas clas = db.clases.Single(c => c.codigo == id);
            return View(clas);
        }

        //
        // POST: /Clases/Edit/5

        [HttpPost]
        public ActionResult Edit(clas clas)
        {
            if (ModelState.IsValid)
            {
                db.clases.Attach(clas);
                db.ObjectStateManager.ChangeObjectState(clas, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clas);
        }

        //
        // GET: /Clases/Delete/5
 
        public ActionResult Delete(int id)
        {
            clas clas = db.clases.Single(c => c.codigo == id);
            return View(clas);
        }

        //
        // POST: /Clases/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            clas clas = db.clases.Single(c => c.codigo == id);
            db.clases.DeleteObject(clas);
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