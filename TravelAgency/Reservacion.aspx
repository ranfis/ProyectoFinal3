<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Reservacion.aspx.cs" Inherits="TravelAgency.Reservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <span class="con dark super">Lista de vuelos</span></h1>
    <div class="tabbable">
        <!-- Only required for left/right tabs -->
        <ul class="nav nav-tabs">
            <li class="active"><a href="#tab1" data-toggle="tab">
                <asp:label runat="server" text="Vuelos de ida" id="Label3" cssclass="con dark"></asp:label>
            </a></li>
            <li><a href="#tab2" data-toggle="tab">
                <asp:label runat="server" text="Vuelos de retorno" id="Label4" cssclass="con dark"></asp:label>
            </a></li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane active" id="tab1">
                <div class="bluePanel full">
                    <asp:label runat="server" text="" id="Label1" cssclass="con"></asp:label>
                    <asp:table id="Table1" runat="server" cssclass="vuelos">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Hora de Salida</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Hora de Llegada</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Ciudad de salida</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Ciudad de llegada</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Duracion del viaje</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Aerolinea</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Clases</span></asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:table>
                </div>
            </div>
            <div class="tab-pane" id="tab2">
                <div class="bluePanel full">
                    <asp:label runat="server" text="" id="Label2" cssclass="con"></asp:label>
                    <asp:table id="Table2" runat="server" cssclass="vuelos">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Hora de Salida</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Hora de Llegada</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Ciudad de salida</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Ciudad de llegada</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Duracion del viaje</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Aerolinea</span></asp:TableHeaderCell>
                            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Clases</span></asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:table>
                </div>
            </div>
        </div>
    </div>
    <div id="boton2" clientidmode="Static" style="text-align: center; margin-top: 16px;"
        runat="server">
    </div>
    <!-- JQuery -->
    <link type="text/css" href="../../jquery/css/jquery-ui-1.8.21.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="../../jquery/js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="../../jquery/js/jquery-ui-1.8.21.custom.min.js"></script>
    <!-- JQuery -->
    <!-- Bootstrap -->
    <script src="../../bootstrap/js/bootstrap.js"></script>
    <!-- Bootstrap -->
    <script type="text/javascript" src="../../js/calls.js"></script>
    <script type="text/javascript" src="../../js/functions.js"></script>
    <button id="fpreservacion" runat="server" onserverclick="hacerReservacion" clientidmode="Static"
        type="button" style="display: none;">
    </button>
    <input id="fpvuelo" runat="server" clientidmode="Static" style="display: none;" />
    <input id="fplleno" runat="server" clientidmode="Static" style="display: none;" />
    <input id="fpclase" runat="server" clientidmode="Static" style="display: none;" />

    <input id="fpvuelo2" runat="server" clientidmode="Static" style="display: none;" />
    <input id="fplleno2" runat="server" clientidmode="Static" style="display: none;" />
    <input id="fpclase2" runat="server" clientidmode="Static" style="display: none;" />
    <button id="inalert" type="button" runat="server" style="display: none;" clientidmode="Static">
    </button>
</asp:Content>
