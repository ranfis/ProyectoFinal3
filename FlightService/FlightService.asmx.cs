using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FlightService
{
    /// <summary>
    /// Descripción breve de FlightService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class FlightService : System.Web.Services.WebService
    {
        AirlineEntities airline = new AirlineEntities();
        [WebMethod]
        public List<vuelo> buscarVuelos(String partida, String destino, DateTime fecha)
        {

            String par = partida.Substring(partida.IndexOf("(")).Replace("(", "").Replace(")", "");
            String des = destino.Substring(destino.IndexOf("(")).Replace("(", "").Replace(")", "");
            var vuelos = airline.LISTVUELOSPORFECHAS(fecha);
            List<vuelo> filtro = new List<vuelo>();
            filtro = vuelos.ToList().FindAll(x => (x.origen.Equals(par) && x.destino.Equals(des)));

            return filtro;
        }
        [WebMethod]
        public List<aeropuerto> listaAeropuertos()
        {
            return airline.aeropuerto.ToList();
        }
    }
}
