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
        public List<vuelo> buscarVuelos()
        {
            //List<vuelo> filtro = new List<vuelo>();
            List<vuelo> filtro2 = new List<vuelo>();
            //String ori = airline.aeropuerto.ToList().Find(x => (x.descripcion.Equals("Aeropuerto Internacional del Santiago"))).codigo;
            //String des = airline.aeropuerto.ToList().Find(x => (x.descripcion.Equals("Washington International Airport"))).codigo;

            //filtro = airline.vuelo.ToList().FindAll(x => (x.origen.Equals(ori) && x.destino.Equals(des)));
            return filtro2;
        }

        [WebMethod]
        public void insertarClase(String id, String descripcion)
        {
            AirlineEntities airline = new AirlineEntities();
            clases clase =new clases();

            clase.codigo = id;
            clase.descripcion = descripcion;

            airline.clases.AddObject(clase);
            airline.SaveChanges();
            //return airline.vuelo.ToList().FindAll(x => (x.origen.Equals(origen) && x.destino.Equals(destino)));
        }
    }
}
