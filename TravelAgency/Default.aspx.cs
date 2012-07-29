﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelAgency
{
    public partial class _Default : System.Web.UI.Page
    {
        localhost.FlightService servicio = new localhost.FlightService();
        protected void Page_Load(object sender, EventArgs e)
        {
            Validador.iniciar();
            txtPartida.Attributes["data-source"] = listaAeropuertos();
            txtDestino.Attributes["data-source"] = listaAeropuertos();

        }
        protected String listaAeropuertos()
        {
            System.Text.StringBuilder aeropuertos = new System.Text.StringBuilder("[");
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
        protected void validarReservacion(object sender, EventArgs e)
        {
            bool resultado = true;
            txtPartida.CssClass = "";
            txtDestino.CssClass = "";
            datepickerPartida.CssClass = "";
            datepickerDestino.CssClass = "";

            if (!(Validador.validar["ciudad"].IsMatch(txtPartida.Text) && txtPartida.Text.Trim().Length > 0))
            {
                txtPartida.CssClass = "error";
                resultado = false;
            }

            if (!(Validador.validar["ciudad"].IsMatch(txtDestino.Text) && txtDestino.Text.Trim().Length > 0))
            {
                txtDestino.CssClass = "error";
                resultado = false;
            }

            if (!(datepickerPartida.Text.Trim().Length > 0))
            {
                datepickerPartida.CssClass = "error";
                resultado = false;
            }

            if (!(datepickerDestino.Text.Trim().Length > 0))
            {
                datepickerDestino.CssClass = "error";
                resultado = false;
            }
            if (resultado)
            {
                DateTime fecha = Convert.ToDateTime(datepickerPartida.Text);
                GridView1.DataSource = servicio.buscarVuelos(txtPartida.Text, txtDestino.Text, fecha);
                GridView1.DataBind();
            }
        }
    }
}
