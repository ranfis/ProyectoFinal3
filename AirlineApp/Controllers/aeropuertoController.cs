﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirlineApp.Models;

namespace AirlineApp.Controllers
{ 
    public class aeropuertoController : Controller
    {
        private airlineEntities db = new airlineEntities();

        //
        // GET: /aeropuerto/

        public ViewResult Index()
        {
            return View(db.aeropuertoes.ToList());
        }

        //
        // GET: /aeropuerto/Details/5

        public ViewResult Details(string id)
        {
            aeropuerto aeropuerto = db.aeropuertoes.Single(a => a.codigo == id);
            return View(aeropuerto);
        }

        //
        // GET: /aeropuerto/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /aeropuerto/Create

        [HttpPost]
        public ActionResult Create(aeropuerto aeropuerto)
        {
            if (ModelState.IsValid)
            {
                db.aeropuertoes.AddObject(aeropuerto);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(aeropuerto);
        }
        
        //
        // GET: /aeropuerto/Edit/5
 
        public ActionResult Edit(string id)
        {
            aeropuerto aeropuerto = db.aeropuertoes.Single(a => a.codigo == id);
            return View(aeropuerto);
        }

        //
        // POST: /aeropuerto/Edit/5

        [HttpPost]
        public ActionResult Edit(aeropuerto aeropuerto)
        {
            if (ModelState.IsValid)
            {
                db.aeropuertoes.Attach(aeropuerto);
                db.ObjectStateManager.ChangeObjectState(aeropuerto, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aeropuerto);
        }

        //
        // GET: /aeropuerto/Delete/5
 
        public ActionResult Delete(string id)
        {
            aeropuerto aeropuerto = db.aeropuertoes.Single(a => a.codigo == id);
            return View(aeropuerto);
        }

        //
        // POST: /aeropuerto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            aeropuerto aeropuerto = db.aeropuertoes.Single(a => a.codigo == id);
            db.aeropuertoes.DeleteObject(aeropuerto);
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