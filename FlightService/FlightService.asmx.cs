using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace FlightService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class FlightService : System.Web.Services.WebService
    {
        airlineEntities airline = new airlineEntities();

        [WebMethod]
        public List<vuelo> listarVuelosPor(String partida, String destino, String fecha)
        {
            List<vuelo> filtro = new List<vuelo>();
            try
            {
                DateTime date = Convert.ToDateTime(fecha);
                var vuelos = airline.LISTVUELOSPORFECHAS(date.ToString("yyyy-MM-dd"));

                filtro = vuelos.ToList().FindAll(x => (x.origen.Equals(partida) && x.destino.Equals(destino)));
            }
            catch (Exception)
            {
                filtro = null;
            }
            return filtro;
        }

        [WebMethod]
        public List<vuelo> listarVuelos()
        {
            List<vuelo> filtro = new List<vuelo>();
            try
            {

                return airline.vueloes.ToList();
            }
            catch (Exception)
            {
                filtro = null;
            }
            return filtro;
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
