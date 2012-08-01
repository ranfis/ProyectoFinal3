using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirlineApp.Models;

namespace AirlineApp.Controllers
{
    public class pruebaController : Controller
    {
        private airlineEntities db = new airlineEntities();
        
        //
        // GET: /prueba/

        public ActionResult Index()
        {
            var configuracions = db.configuracions.Include("avion1").Include("clas");
            return View(configuracions.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.avion = new SelectList(db.avions, "codigo", "descripcion");
            ViewBag.clase = new SelectList(db.clases, "codigo", "descripcion");
            return View();
        }

        //
        // POST: /configuracion/Create

        [HttpPost]
        public void Create(int txtCodigo, string txtNombre, int [] clases, int[] numClases)
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
            //Response.Redirect("Index");
           
           
        }
    }
}
    