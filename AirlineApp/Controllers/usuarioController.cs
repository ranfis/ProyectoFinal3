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
    public class usuarioController : Controller
    {
        private airlineEntities db = new airlineEntities();

        //
        // GET: /usuario/

        public ViewResult Index()
        {
            return View(db.usuarios.ToList());
        }

        //
        // GET: /usuario/Details/5

        public ViewResult Details(string id)
        {
            usuario usuario = db.usuarios.Single(u => u.nusuario == id);
            return View(usuario);
        }

        //
        // GET: /usuario/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /usuario/Create

        [HttpPost]
        public ActionResult Create(usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.usuarios.AddObject(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(usuario);
        }
        
        //
        // GET: /usuario/Edit/5
 
        public ActionResult Edit(string id)
        {
            usuario usuario = db.usuarios.Single(u => u.nusuario == id);
            return View(usuario);
        }

        //
        // POST: /usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.usuarios.Attach(usuario);
                db.ObjectStateManager.ChangeObjectState(usuario, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        //
        // GET: /usuario/Delete/5
 
        public ActionResult Delete(string id)
        {
            usuario usuario = db.usuarios.Single(u => u.nusuario == id);
            return View(usuario);
        }

        //
        // POST: /usuario/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            usuario usuario = db.usuarios.Single(u => u.nusuario == id);
            db.usuarios.DeleteObject(usuario);
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