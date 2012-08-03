using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JRTravel
{
    public class ReservacionController : Controller
    {
        JRTravel.Models.TravelAgencyEntities TA = new Models.TravelAgencyEntities();

        public ActionResult Index()
        {
            var @reservaciones = TA.reservacions.ToList();
            var @usuarios = TA.usuarios.ToList();
            ViewBag.Reservaciones = @reservaciones;
            ViewBag.Usuarios = @usuarios;
            return View();
        }

        public ActionResult Buscar()
        {
            return View();
        }
        public ActionResult Reservaciones()
        {
            return View();
        }

    }
}
