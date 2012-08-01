using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Timers;


namespace TravelAgency
{
    public class Temporizador
    {
        // Variable que guarda una referencia al Timer (la misma para todas las instancias del mÃ³dulo)
        static Timer _timerGlobal = new Timer();
        static HttpApplication _App = new HttpApplication();
        static TravelAgency.Models.TravelAgencyEntities db = new TravelAgency.Models.TravelAgencyEntities();
        static localhost.FlightService servicio = new localhost.FlightService();

        public void Init()
        {

            if (_timerGlobal == null)
            {

                //inicializo el Timer
                _timerGlobal = new Timer(10000);
                _timerGlobal.Elapsed += new ElapsedEventHandler(ActualizarReservaciones);
                _timerGlobal.Elapsed += new ElapsedEventHandler(ActualizarReservacionesEspera);
                _timerGlobal.Start();

            }

            db = new Models.TravelAgencyEntities();
        }

        public void Dispose()
        {
            _timerGlobal = null;
        }

        /// 
        /// AquÃ­ se procesa periÃ³dicamente el Timer
        /// 
        private static void ActualizarReservaciones(object source, ElapsedEventArgs e)
        {

            IEnumerable<Models.reservacion> re = db.reservacions.ToList().FindAll(c => c.estado == 1);
            var vuelos = servicio.buscarVuelos2();
            DateTime fecha = DateTime.Now;

            foreach (var item in re)
            {
                var vuelo = vuelos.ToList().Find(c => c.codigo.ToString().Equals(item.vuelo));
                if ((vuelo.salida.Year - fecha.Year) == 0
                    && (vuelo.salida.Month - fecha.Month) == 0
                    && (vuelo.salida.Day - fecha.Day) == 0
                    && (vuelo.salida.Hour - fecha.Hour) == 0)
                {
                    item.estado = 2;
                    db.SaveChanges();

                }
            }
        }



        private static void ActualizarReservacionesEspera(object source, ElapsedEventArgs e)
        {

            IEnumerable<Models.reservacion> re = db.reservacions.ToList().FindAll(c => c.estado == 0);

            var vuelos = servicio.buscarVuelos2();

            DateTime fecha = DateTime.Now;
            TimeSpan restaFechas = new TimeSpan();

            int capacidad = 0;
            int reservaciones = re.ToList().Count;

            foreach (var item in re)
            {
                var vuelo = vuelos.ToList().Find(c => c.codigo.ToString().Equals(item.vuelo));

                restaFechas = vuelo.salida - fecha;

                if (restaFechas.Hours < 48 && restaFechas.Hours > 0)
                {
                    var clases = servicio.capacidadVuelo(Convert.ToInt32(item.vuelo));

                    foreach (var clase in clases)
                    {
                        capacidad += clase.capacidad;
                    }

                    if (reservaciones < capacidad)
                    {
                        item.estado = 1;
                        Models.usuario u=db.usuarios.ToList().Find(x=>(x.nusuario.Equals(item.usuario)));
                        EnviadorDeCorreos.envialEmail(u.nusuario, "El vuelo "+vuelo.codigo+" ya tiene asientos disponibles", "<center>" +
        "<img src='http://dl.dropbox.com/u/11327760/Agencia-de-viajes.jpg' />" +
        "<h1>JR Traven Agency</h1>" +
        "<p>Le informamos que el vuelo " + vuelo.codigo + " ya tiene asientos disponibles.</p>" +
        "<p>Por favor, si todavia quiere continuar con la reserva de este vuelo,</p>" +
        "<p>dirijase a su perfil y seleccione <b>Facturar</b></p></center>");
                    }
                }
                else
                {
                    item.estado = 2;
                }

            }
        }
    }

}