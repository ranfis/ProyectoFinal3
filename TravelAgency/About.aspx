<%@ Page Title="Acerca de nosotros" Language="C#" MasterPageFile="~/Site.master"
    AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TravelAgency.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="bluePanel full">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Table ID="Table1" runat="server" CssClass="vuelos">
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
        </asp:Table>
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
    <button id="fp2" runat="server" onserverclick="hacerReservacion" ClientIDMode="Static" type="button" style="display:none;" ></button>
    <input type="text" id="fp3" runat="server" ClientIDMode="Static" style="display:none;" />
</asp:Content>
