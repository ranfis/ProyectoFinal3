using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelAgency
{
    public partial class Index : System.Web.UI.Page
    {
        localhost.FlightService servicio = new localhost.FlightService();
        TravelAgency.Models.TravelAgencyEntities agency = new TravelAgency.Models.TravelAgencyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLoged"] == null)
            {
                Response.Redirect("Default.aspx?Login=s");
            }
            Validador.iniciar();
            txtPartida.Attributes["data-source"] = listaAeropuertos();
            txtDestino.Attributes["data-source"] = listaAeropuertos();
            //var vuelos = servicio.buscarVuelos2();
        }
        protected String listaAeropuertos()
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
        protected void validarReservacion(object sender, EventArgs e)
        {

            bool resultado = true;
            txtPartida.CssClass = "";
            txtDestino.CssClass = "";
            datepickerPartida.CssClass = "";
            datepickerRetorno.CssClass = "";

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
            if (!(Validador.validar["fecha"].IsMatch(datepickerPartida.Text) && datepickerPartida.Text.Trim().Length > 0))
            {
                datepickerPartida.CssClass = "error";
                resultado = false;
            }

            if (!(datepickerRetorno.Text.Trim().Length > 0))
            {
                datepickerRetorno.CssClass = "error";
                resultado = false;
            }

            if (resultado)
            {
                try
                {
                    HttpCookie cookie = new HttpCookie("reservacion");
                    cookie.Values["partida"] = txtPartida.Text;
                    cookie.Values["destino"] = txtDestino.Text;
                    cookie.Values["fechapartida"] = datepickerPartida.Text;
                    cookie.Values["fecharegreso"] = datepickerRetorno.Text;
                    Response.Cookies.Add(cookie);
                    Response.Redirect("Reservacion.aspx");
                }
                catch (Exception)
                {
                    GridView1.DataSource = new List<String> { "No se han encontrado vuelos" };
                }
                finally
                {
                    GridView1.DataBind();
                }

            }
        }
    }
}