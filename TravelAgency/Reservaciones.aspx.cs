using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelAgency
{
    public partial class Reservaciones : System.Web.UI.Page
    {
        Models.TravelAgencyEntities agencia = new Models.TravelAgencyEntities();
        localhost.FlightService servicio = new localhost.FlightService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLoged"] == null)
            {
                Response.Redirect("Default.aspx?Login=s");
            }
            else
            {
                generarTablaVuelos();
            }
            
        }

        void generarTablaVuelos()
        {
            try
            {
                var reservaciones = agencia.reservacions.ToList().FindAll(x => (x.cliente.Equals(Session["userLoged"]) && x.estado!=2));

                if (reservaciones.Count < 1)
                {
                    TableRow tr = new TableRow();
                    TableCell td = new TableCell();
                    Label span = new Label();
                    span.CssClass = "con";
                    span.Text = "No se han encontrado vuelos";
                    span.Attributes["class"] = "error";
                    td.ColumnSpan = 8;
                    td.Attributes["style"] = "text-align:center";
                    td.Controls.Add(span);
                    tr.Cells.Add(td);
                    Table1.Rows.Add(tr);
                }
                foreach (var res in reservaciones)
                {
                    var age = agencia.agencias.ToList().Find(x => (x.codigo.Equals(res.agencia)));
                    var vue = servicio.buscarVuelos2().ToList().Find(x => (x.codigo==Convert.ToInt32(res.vuelo)));
                    var aer1 = servicio.listaAeropuertos().ToList().Find(x => (x.codigo.Equals(vue.origen)));
                    var aer2 = servicio.listaAeropuertos().ToList().Find(x => (x.codigo.Equals(vue.destino)));

                    TableRow tr = new TableRow();

                    TableCell tdRadio = new TableCell();
                    RadioButton radio = new RadioButton();
                    radio.Attributes["value"] = res.codigo;
                    radio.GroupName = "reservado";
                    radio.Attributes["onclick"] = "fp3.value=" + res.codigo;
                    tdRadio.Controls.Add(radio);
                    tdRadio.CssClass = "vuelos";

                    TableCell tdAgencia = new TableCell();
                    Label lbl1 = new Label();
                    lbl1.Text = age.descripcion;
                    lbl1.CssClass = "con";
                    tdAgencia.Controls.Add(lbl1);
                    tdAgencia.CssClass = "vuelos";

                    TableCell tdEstado = new TableCell();
                    Label lbl2 = new Label();
                    if (res.estado == 0)
                    {
                        lbl2.Text = "Pendiente";
                        lbl2.ForeColor=System.Drawing.Color.FromArgb(255, 255, 0);
                    }
                    else
                    {
                        lbl2.Text = "Activo";
                        lbl2.ForeColor=System.Drawing.Color.FromArgb(00, 255, 00);
                    }
                    
                    lbl2.CssClass = "con";
                    tdEstado.Controls.Add(lbl2);
                    tdEstado.CssClass = "vuelos";

                    TableCell tdSalida = new TableCell();
                    Label lbl3 = new Label();
                    lbl3.Text = vue.salida.ToString();
                    lbl3.CssClass = "con";
                    tdSalida.Controls.Add(lbl3);
                    tdSalida.CssClass = "vuelos";

                    TableCell tdLlegada = new TableCell();
                    Label lbl5 = new Label();
                    lbl5.Text = vue.llegada.ToString();
                    lbl5.CssClass = "con";
                    tdLlegada.Controls.Add(lbl5);
                    tdLlegada.CssClass = "vuelos";



                    TableCell tdOrigen = new TableCell();
                    Label lbl6 = new Label();
                    //lbl6.Text = aer.ciudad.ToString();
                    lbl6.Text = aer1.ciudad;
                    lbl6.CssClass = "con";
                    tdOrigen.Controls.Add(lbl6);
                    tdOrigen.CssClass = "vuelos";

                    TableCell tdDestino = new TableCell();
                    Label lbl7 = new Label();
                    lbl7.Text = aer2.ciudad;
                    //lbl7.Text = aer.ciudad.ToString();
                    lbl7.CssClass = "con";
                    tdDestino.Controls.Add(lbl7);
                    tdDestino.CssClass = "vuelos";


                    TableCell tdPrecio = new TableCell();
                    Label lbl4 = new Label();
                    lbl4.Text = res.precio.ToString() + " US$";
                    lbl4.CssClass = "con";
                    tdPrecio.Controls.Add(lbl4);
                    tdPrecio.CssClass = "vuelos";


                    tr.Cells.Add(tdRadio);
                    tr.Cells.Add(tdAgencia);
                    tr.Cells.Add(tdOrigen);
                    tr.Cells.Add(tdSalida);
                    tr.Cells.Add(tdDestino);
                    tr.Cells.Add(tdLlegada);
                    tr.Cells.Add(tdPrecio);
                    tr.Cells.Add(tdEstado);

                    Table1.Rows.Add(tr);

                }

            }
            catch (Exception)
            {
                TableRow tr = new TableRow();
                TableCell td = new TableCell();
                Label span = new Label();
                span.CssClass = "con";
                span.Text = "No se han encontrado reservaciones";
                span.Attributes["class"] = "error";
                td.ColumnSpan = 8;
                td.Attributes["style"] = "text-align:center";
                td.Controls.Add(span);
                tr.Cells.Add(td);
                Table1.Rows.Add(tr);
            }

        }
    }
}