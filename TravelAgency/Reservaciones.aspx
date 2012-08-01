<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Reservaciones.aspx.cs" Inherits="TravelAgency.Reservaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1><span class="con dark super" >Mis Reservaciones</span></h1>
    <div class="bluePanel full">
        <asp:label runat="server" text="" id="Label1" cssclass="con"></asp:label>
        <asp:table id="Table1" runat="server" cssclass="vuelos">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell></asp:TableHeaderCell>
            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Agencia de Viajes</span></asp:TableHeaderCell>
            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Origen</span></asp:TableHeaderCell>
            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Hora de salida</span></asp:TableHeaderCell>
            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Destino</span></asp:TableHeaderCell>
            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Hora de llegada</span></asp:TableHeaderCell>
            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Precio</span></asp:TableHeaderCell>
            <asp:TableHeaderCell CssClass="vuelos"><span class="con" >Estado</span></asp:TableHeaderCell>
            
        </asp:TableHeaderRow>
        </asp:table>
    </div>
    <br />
</asp:Content>
