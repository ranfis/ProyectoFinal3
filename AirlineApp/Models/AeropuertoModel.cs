using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using AirlineApp.Models;

namespace AirlineApp.Models
{
    public class Aeropuerto
    {

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Codigo")]
        public int Codigo { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Capacidad")]
        public int Capacidad { get; set; }

        public Object clases { get; set; }
    }


    public class AeropuertoModel 
    {
        private airlineEntities bd = new airlineEntities();

        public List<Aeropuerto> cargar()
        {
            List<Aeropuerto> lisAeropuerto = new List<Aeropuerto>();

          
            var configuracions = bd.configuracions.Include("avion1").Include("clas").Distinct();

            foreach (var item in configuracions)
            {
                Aeropuerto aer = new Aeropuerto();

                aer.Codigo = item.avion1.codigo;
                aer.Nombre = item.avion1.descripcion;
                aer.Capacidad = item.avion1.capacidad;

                aer.clases = new   SelectList(bd.clases, "codigo", "descripcion", item.clase);
                lisAeropuerto.Add(aer);
            }

            return lisAeropuerto;
        }
    }
}