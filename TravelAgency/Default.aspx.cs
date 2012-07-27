using System;
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
        }

        protected void validarReservacion(object sender, EventArgs e)
        {
            txtPartida.CssClass = "";
            txtDestino.CssClass = "";
            datepickerPartida.CssClass = "";
            datepickerDestino.CssClass = "";

            if (!(Validador.validar["texto"].IsMatch(txtPartida.Text) && txtPartida.Text.Trim().Length > 0))
            {
                txtPartida.CssClass = "error";
            }

            if (!(Validador.validar["texto"].IsMatch(txtDestino.Text) && txtDestino.Text.Trim().Length > 0))
            {
                txtDestino.CssClass = "error";
            }

            if (!(datepickerPartida.Text.Trim().Length>0))
            {
                datepickerPartida.CssClass = "error";
            }

            if (!(datepickerDestino.Text.Trim().Length > 0))
            {
                datepickerDestino.CssClass = "error";
            }
        }
        /*
        protected void Button1_Click(object sender, EventArgs e)
        {
            servicio.insertarClase(txtID.Text,txtDesc.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Tabla.DataSource = servicio.buscarVuelos(txtOrigen.Text, txtDestino.Text, txtFecha1.Text, txtFecha2.Text);
            Tabla.DataSource = servicio.buscarVuelos();
            Tabla.DataBind();
        }*/
    }
}
