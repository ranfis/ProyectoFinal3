using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JRTravel.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            String user = Request["txtUser"];
            String pass = JRTravel.Models.Encriptador.generarMD5(Request["txtPass"]);
            pass = JRTravel.Models.Encriptador.generarMD5(pass);
            using (JRTravel.Models.TravelAgencyEntities TA = new Models.TravelAgencyEntities())
            {
                JRTravel.Models.usuario usuario = TA.usuarios.ToList().Find(x => (x.nusuario.Equals(user) && x.clave.Equals(pass)));
                if (usuario == null)
                {
                    Response.Redirect("Home");
                }
                else
                {
                    Response.Redirect("Home/Nosotros");
                }
            }
            return View();
        }

        public ActionResult Registro()
        {
            using (JRTravel.Models.TravelAgencyEntities TA = new Models.TravelAgencyEntities())
            {
                JRTravel.Models.usuario usuario = new Models.usuario();
                // TODO
                // TODO
                TA.SaveChanges();
            }
            return View();
        }

    }
}
