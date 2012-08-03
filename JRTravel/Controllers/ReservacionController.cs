using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JRTravel
{
    public class ReservacionController : Controller
    {
        protected String listaAeropuertos()
        {
            using (Servicio.FlightService servicio = new Servicio.FlightService())
            {
                System.Text.StringBuilder aeropuertos = new System.Text.StringBuilder("[");
                try
                {
                    var lista = servicio.listaAeropuertos();
                    foreach (var x in lista)
                    {
                        aeropuertos.Append('"'.ToString());
                        aeropuertos.Append(x.ciudad);
                        aeropuertos.Append(" (" + x.codigo + ")");
                        aeropuertos.Append('"'.ToString() + ",");
                    }
                    aeropuertos.Remove(aeropuertos.Length - 1, 1);
                    aeropuertos.Append("]");
                    return aeropuertos.ToString();
                }
                catch (Exception)
                {
                    return "";
                }
            }

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar()
        {
            var @aeropuertos = listaAeropuertos();
            ViewBag.Aeropuertos = @aeropuertos;
            return View();
        }

        [HttpPost]
        public ActionResult Buscar(String txtPartida, String txtDestino, String datepickerPartida, String datepickerRetorno)
        {
            HttpCookie cookie = new HttpCookie("RES");
            cookie.Values["partida"] = txtPartida;
            cookie.Values["destino"] = txtDestino;
            cookie.Values["fechapartida"] = datepickerPartida;
            cookie.Values["fecharegreso"] = datepickerRetorno;
            Response.Cookies.Add(cookie);
            Response.Redirect("Vuelos");
            return View();
        }
        public ActionResult Vuelos()
        {
            HttpCookie cookie = Request.Cookies["RES"];
            String partida, destino, fecha, fecha2;
            partida = cookie.Values["partida"];
            destino = cookie.Values["destino"];
            fecha = cookie.Values["fechapartida"];
            fecha2 = cookie.Values["fecharegreso"];

            partida = partida.Substring(partida.IndexOf("(")).Replace("(", "").Replace(")", "");
            destino = destino.Substring(destino.IndexOf("(")).Replace("(", "").Replace(")", "");
            Request.Cookies["RES"].Value = null;
            Request.Cookies.Remove(cookie.Name);

            using (Servicio.FlightService servicio = new Servicio.FlightService()){
                var @vuelos = servicio.listarVuelosPor(partida,destino,fecha);
                ViewBag.Vuelos = @vuelos;
            }


            return View();
        }
        public ActionResult Reservaciones()
        {
            return View();
        }

    }
}
