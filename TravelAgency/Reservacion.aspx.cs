﻿using System;
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
            String partida, destino, fecha, fecha2;
            try
            {

                HttpCookie cookie = Request.Cookies["reservacion"];
                partida = cookie.Values["partida"];
                destino = cookie.Values["destino"];
                fecha = cookie.Values["fechapartida"];
                fecha2 = cookie.Values["fecharegreso"];
                Request.Cookies.Remove("reservacion");
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
        }

        void generarTablaVuelos(Table table, String partida, String destino, String fecha)
        {
            try
            {

                var vuelos = servicio.buscarVuelos(partida, destino, fecha);
                Response.Cookies.Clear();
                Request.Cookies.Clear();
                Response.Cookies.Remove("reservacion");
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
                    radio.Attributes["value"] = vuelo.codigo;
                    radio.GroupName = "reservado";
                    radio.Attributes["onclick"] = "fp3.value=" + vuelo.codigo;
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
                    lbl5.Text = "14h 34m";
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
                    tdClase.Text = "<div class='btn-group' data-toggle='buttons-radio'>" +
                                "<button clientidmode='Static' class='btn' type='button' title='Seleccionar'>" +
                                    "<span class='con dark'>Economica</span>" +
                                "</button>" +
                                "<button clientidmode='Static' class='btn' type='button' title='Seleccionar'>" +
                                    "<span class='con dark'>Fumadores</span>" +
                                "</button>" +
                                "<button clientidmode='Static' class='btn' type='button' title='Seleccionar'>" +
                                    "<span class='con dark'>VIP</span>" +
                                "</button>" +
                            "</div>";
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
                    if (ocupados.Count > 0)
                    {
                        System.Drawing.Color yy = System.Drawing.Color.FromArgb(255, 255, 0);
                        tr.BorderColor = yy;
                    }
                    else
                    {
                        System.Drawing.Color gg = System.Drawing.Color.FromArgb(00, 255, 00);
                        tr.BorderColor = gg;
                    }

                    table.Rows.Add(tr);

                }

                TableRow trBoton = new TableRow();
                TableCell tdBoton = new TableCell();
                HtmlGenericControl boton = new HtmlGenericControl("button");
                Label span = new Label();
                span.CssClass = "con dark";
                boton.Controls.Add(span);
                boton.Attributes["class"] = "btn";
                boton.Attributes["title"] = "Hacer reservacion(es)";
                boton.Attributes["ID"] = "btnReservar";
                boton.Attributes["onclick"] = "fp2.click()";
                boton.Attributes["runat"] = "server";

                span.Text = "Reservar";
                tdBoton.Controls.Add(boton);
                tdBoton.CssClass = "vuelos right";
                tdBoton.ColumnSpan = 8;
                trBoton.Cells.Add(tdBoton);
                table.Rows.Add(trBoton);
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
            r.codigo = MD5Generator.generarMD5(DateTime.Now.Millisecond + fp3.Value).Substring(0, 8);
            r.agencia = "TRV001";
            r.vuelo = fp3.Value;
            r.precio = 2000;
            r.clase = "1";
            r.estado = 1;
            r.cliente = cliente;
            r.asiento = "A1";

            agencia.reservacions.AddObject(r);
            agencia.SaveChanges();
        }
    }

}