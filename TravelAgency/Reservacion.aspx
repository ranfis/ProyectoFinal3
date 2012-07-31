<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Reservacion.aspx.cs" Inherits="TravelAgency.Reservacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label runat="server" Text="Vuelos de ida" id="Label3" CssClass="con dark" ></asp:Label>
    <div class="bluePanel full">
    <asp:Label runat="server" Text="" id="Label1" CssClass="con" ></asp:Label>
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
    </div> <br />
    <asp:Label runat="server" Text="Vuelos de retorno" id="Label4" CssClass="con dark" ></asp:Label>
    <div class="bluePanel full">
    <asp:Label runat="server" Text="" id="Label2" CssClass="con" ></asp:Label>
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
    <button id="fp2" runat="server" onserverclick="hacerReservacion" clientidmode="Static"
        type="button" style="display: none;">
    </button>
    <input type="text" id="fp3" runat="server" clientidmode="Static" style="display: none;" />
</asp:Content>
