using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace TravelAgency
{
    public partial class Reservacion : System.Web.UI.Page
    {
        Models.TravelAgencyEntities agencia = new Models.TravelAgencyEntities();
        localhost.FlightService servicio = new localhost.FlightService();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userLoged"] == null)
            {
                Response.Redirect("Default.aspx?Login=s");
            }

            String partida, destino, fecha, fecha2;
            try
            {
                HttpCookie cookie = Request.Cookies["reservacion"];
                partida = cookie.Values["partida"];
                destino = cookie.Values["destino"];
                fecha = cookie.Values["fechapartida"];
                fecha2 = cookie.Values["fecharegreso"];
                Request.Cookies["reservacion"].Value = null;

            }
            catch (Exception)
            {
                partida = "";
                destino = "";
                fecha = "";
                fecha2 = "";
            }


            generarTablaVuelos(Table1, partida, destino, fecha);
            generarTablaVuelos(Table2, destino, partida, fecha2);
            TableRow trBoton = new TableRow();
            TableCell tdBoton = new TableCell();
            HtmlGenericControl boton = new HtmlGenericControl("button");
            Label span = new Label();
            span.CssClass = "con dark";
            boton.Controls.Add(span);
            boton.Attributes["class"] = "btn btn-large";
            boton.Attributes["title"] = "Hacer reservacion(es)";
            boton.Attributes["ID"] = "btnReservar";
            boton.Attributes["onclick"] = "fpreservacion.click()";
            boton.Attributes["runat"] = "server";

            span.Text = "Reservar";
            tdBoton.Controls.Add(boton);
            tdBoton.CssClass = "vuelos right";
            tdBoton.ColumnSpan = 8;
            trBoton.Cells.Add(tdBoton);
            boton2.Controls.Add(trBoton);
        }

        void generarTablaVuelos(Table table, String partida, String destino, String fecha)
        {
            try
            {
                var vuelos = servicio.buscarVuelos(partida, destino, fecha);
                foreach (var vuelo in vuelos)
                {
                    if (true)
                    {
                        Label1.Text = "Vuelos " + vuelo.salida.ToLongDateString();
                        Label2.Text = "Vuelos " + vuelo.salida.ToLongDateString();

                    }


                    TableRow tr = new TableRow();

                    TableCell tdRadio = new TableCell();
                    RadioButton radio = new RadioButton();
                    radio.Attributes["value"] = vuelo.codigo.ToString();
                    radio.GroupName = "reservado" + vuelo.origen;


                    tdRadio.Controls.Add(radio);
                    tdRadio.CssClass = "vuelos";

                    TableCell tdSalida = new TableCell();
                    Label lbl1 = new Label();
                    lbl1.Text = vuelo.salida.TimeOfDay.ToString();
                    lbl1.CssClass = "con";
                    tdSalida.Controls.Add(lbl1);
                    tdSalida.CssClass = "vuelos";

                    TableCell tdLlegada = new TableCell();
                    Label lbl2 = new Label();
                    lbl2.Text = vuelo.llegada.TimeOfDay.ToString();
                    lbl2.CssClass = "con";
                    tdLlegada.Controls.Add(lbl2);
                    tdLlegada.CssClass = "vuelos";

                    TableCell tdCiudad = new TableCell();
                    Label lbl3 = new Label();
                    lbl3.Text = vuelo.origen.ToString();
                    lbl3.CssClass = "con";
                    tdCiudad.Controls.Add(lbl3);
                    tdCiudad.CssClass = "vuelos";

                    TableCell tdCiudad2 = new TableCell();
                    Label lbl4 = new Label();
                    lbl4.Text = vuelo.destino.ToString();
                    lbl4.CssClass = "con";
                    tdCiudad2.Controls.Add(lbl4);
                    tdCiudad2.CssClass = "vuelos";


                    TableCell tdTiempo = new TableCell();
                    Label lbl5 = new Label();
                    lbl5.Text = (vuelo.llegada - vuelo.salida).ToString();
                    lbl5.CssClass = "con";
                    tdTiempo.Controls.Add(lbl5);
                    tdTiempo.CssClass = "vuelos";


                    TableCell tdAerolinea = new TableCell();
                    Label lbl6 = new Label();
                    lbl6.Text = vuelo.aerolinea;
                    lbl6.CssClass = "con";
                    tdAerolinea.Controls.Add(lbl6);
                    tdAerolinea.CssClass = "vuelos";



                    TableCell tdClase = new TableCell();
                    var capacidad = servicio.capacidadVuelo(vuelo.codigo).ToList();
                    Panel div = new Panel();
                    div.CssClass = "btn-group";
                    div.Attributes["data-toggle"] = "buttons-radio";
                    int cap = 0;
                    foreach (var c in capacidad)
                    {
                        cap += c.capacidad;
                        HtmlGenericControl btn = new HtmlGenericControl("button");
                        Label lbl = new Label();
                        lbl.CssClass = "con dark";
                        btn.Controls.Add(lbl);
                        btn.Attributes["class"] = "btn";
                        btn.Attributes["title"] = "Seleccionar";
                        btn.Attributes["ID"] = "radioc";
                        btn.Attributes["type"] = "button";
                        btn.Attributes["runat"] = "server";
                        btn.Attributes["name"] = "miradio";
                        btn.Attributes["onclick"] = "fpclase.value=" + c.codigo.ToString();
                        lbl.Text = c.descripcion;
                        div.Controls.Add(btn);
                    }
                    tdClase.Controls.Add(div);

                    tdClase.CssClass = "vuelos";

                    tr.Cells.Add(tdRadio);
                    tr.Cells.Add(tdSalida);
                    tr.Cells.Add(tdLlegada);
                    tr.Cells.Add(tdCiudad);
                    tr.Cells.Add(tdCiudad2);
                    tr.Cells.Add(tdTiempo);
                    tr.Cells.Add(tdAerolinea);
                    tr.Cells.Add(tdClase);
                    tr.BorderWidth = 2;
                    var ocupados = agencia.reservacions.ToList().FindAll(x => (x.vuelo.Equals(vuelo.codigo)));

                    if (ocupados.Count >= cap)
                    {
                        System.Drawing.Color yy = System.Drawing.Color.FromArgb(255, 255, 0);
                        tr.BorderColor = yy;
                        radio.Attributes["onclick"] = "fpvuelo.value=" + vuelo.codigo + ";fplleno.value=0;radioc.class='btn'";
                        tdRadio.ToolTip = "El avion esta lleno";
                    }
                    else
                    {
                        System.Drawing.Color gg = System.Drawing.Color.FromArgb(00, 255, 00);
                        tr.BorderColor = gg;
                        tdRadio.ToolTip = "Vuelo disponible";
                        radio.Attributes["onclick"] = "fpvuelo.value=" + vuelo.codigo + ";fplleno.value=1;radioc.class='btn'";
                    }

                    table.Rows.Add(tr);

                }

            }
            catch (Exception)
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
                table.Rows.Add(tr);
            }
        }

        protected void hacerReservacion(object sender, EventArgs e)
        {
            String cliente = Session["userLoged"].ToString();
            Models.reservacion r = new Models.reservacion();

            r.codigo = MD5Generator.generarMD5(DateTime.Now.Millisecond + fpvuelo.Value).Substring(0, 8);
            r.agencia = agencia.agencias.First().codigo;
            r.vuelo = fpvuelo.Value;
            r.precio = 2000;
            r.clase = fpclase.Value;
            if (fplleno.Value.Equals("1"))
            {
                r.estado = 1;
            }
            else
            {
                r.estado = 0;

            }
            r.cliente = cliente;
            r.asiento = "A" + fpclase.Value + fpreservacion;
            agencia.reservacions.AddObject(r);

            if (true)
            {
                Models.reservacion r2 = new Models.reservacion();
                r2.codigo = MD5Generator.generarMD5(DateTime.Now.Millisecond + fpvuelo.Value).Substring(0, 8);
                r2.agencia = agencia.agencias.First().codigo;
                r2.vuelo = fpvuelo.Value;
                r2.precio = 2000;
                r2.clase = fpclase.Value;
                Models.usuario u = agencia.usuarios.ToList().Find(x => (x.nusuario.Equals(Session["userLoged"])));
                if (fplleno.Value.Equals("1"))
                {
                    r.estado = 1;
                    inalert.Attributes["onlick"] = "alert('Vuelo reservado con exito');";
                    
                    try
                    {
                        EnviadorDeCorreos.envialEmail(u.correo, "El vuelo " + fpvuelo + "Gracias por su reservacion", "<center>" +
        "<img src='http://dl.dropbox.com/u/11327760/Agencia-de-viajes.jpg' />" +
        "<h1>JR Travel Agency</h1>" +
        "<p>Le informamos que su reserva al vuelo " + fpvuelo + " se proceso correctamente.</p>" +
        "<p>Gracias por preferirnos, tenga un buen viaje.</p>");

                    }
                    catch (Exception)
                    {

                    }

                }
                else
                {
                    r.estado = 0;
                    try
                    {
                        EnviadorDeCorreos.envialEmail(u.correo, "El vuelo " + fpvuelo + "Usted ha entrada a la lista de espera", "<center>" +
        "<img src='http://dl.dropbox.com/u/11327760/Agencia-de-viajes.jpg' />" +
        "<h1>JR Travel Agency</h1>" +
        "<p>Le informamos que su reserva al vuelo " + fpvuelo + " ha sido guardada como pendiente</p>" +
                        "<p>Le informaremos por esta misma via, tan pronto como el vuelo este disponible.</p>" +
        "<p>Gracias por preferirnos.</p>");

                    }
                    catch (Exception)
                    {

                    }

                }
                r.cliente = cliente;
                r.asiento = "A" + fpclase.Value + fpreservacion;
                agencia.reservacions.AddObject(r);
            }


            agencia.SaveChanges();
            Response.Redirect("Reservaciones.aspx");
        }
    }

}