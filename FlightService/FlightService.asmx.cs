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
        airlineEntities airline = new airlineEntities();
        [WebMethod]
        public List<vuelo> buscarVuelos(String partida, String destino, String fecha)
        {
            List<vuelo> filtro = new List<vuelo>();
            try
            {

                String par = partida.Substring(partida.IndexOf("(")).Replace("(", "").Replace(")", "");
                String des = destino.Substring(destino.IndexOf("(")).Replace("(", "").Replace(")", "");

                DateTime date = Convert.ToDateTime(fecha);
                var vuelos = airline.LISTVUELOSPORFECHAS(date.ToString("yyyy-MM-dd"));

                filtro = vuelos.ToList().FindAll(x => (x.origen.Equals(par) && x.destino.Equals(des)));
            }
            catch (Exception)
            {
                filtro = null;
            }
            return filtro;
        }
        [WebMethod]
        public List<vuelo> buscarVuelos2()
        {
            return airline.vueloes.ToList();
        }
        [WebMethod]
        public List<aeropuerto> listaAeropuertos()
        {
            List<aeropuerto> aeropuertos;
            try
            {
                aeropuertos = airline.aeropuertoes.ToList();
            }
            catch (Exception)
            {
                aeropuertos = null;
            }
            return aeropuertos;
        }
        [WebMethod]
        public List<avion> capacidadVuelo(int vuelo)
        {
            var resultado =airline.sp_capacidad_vuelo2(vuelo.ToString());
            return resultado.ToList();
        }
        
    }
}
