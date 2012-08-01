using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirlineApp.Controllers
{
    public class prueb2Controller : Controller
    {
        private AirlineApp.Models.AeropuertoModel aer = new Models.AeropuertoModel();

        // GET: /prueb2/

        public ActionResult Index()
        {

            return View(aer.cargar().ToList());
        }

    }
}
