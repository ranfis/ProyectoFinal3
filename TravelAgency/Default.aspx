<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TravelAgency._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="pnlReserv">
        <table class="pnlReserv">
            <tr>
                <td>
                    <span class="con">Salir de:</span>
                </td>
                <td>
                    <span class="con">Llegar a:</span>
                </td>
            </tr>
            <tr>
                <td>
                    <input runat="server" placeholder="Lugar de partida" id="txtPartida" type="text"
                        data-provide="typeahead" data-items="4" data-source="[&quot;Alabama&quot;,&quot;Alaska&quot;,&quot;Arizona&quot;,&quot;Arkansas&quot;,&quot;California&quot;,&quot;Colorado&quot;,&quot;Connecticut&quot;,&quot;Delaware&quot;,&quot;Florida&quot;,&quot;Georgia&quot;,&quot;Hawaii&quot;,&quot;Idaho&quot;,&quot;Illinois&quot;,&quot;Indiana&quot;,&quot;Iowa&quot;,&quot;Kansas&quot;,&quot;Kentucky&quot;,&quot;Louisiana&quot;,&quot;Maine&quot;,&quot;Maryland&quot;,&quot;Massachusetts&quot;,&quot;Michigan&quot;,&quot;Minnesota&quot;,&quot;Mississippi&quot;,&quot;Missouri&quot;,&quot;Montana&quot;,&quot;Nebraska&quot;,&quot;Nevada&quot;,&quot;New Hampshire&quot;,&quot;New Jersey&quot;,&quot;New Mexico&quot;,&quot;New York&quot;,&quot;North Dakota&quot;,&quot;North Carolina&quot;,&quot;Ohio&quot;,&quot;Oklahoma&quot;,&quot;Oregon&quot;,&quot;Pennsylvania&quot;,&quot;Rhode Island&quot;,&quot;Santo Domingo Las Americas, DR&quot;,&quot;South Carolina&quot;,&quot;South Dakota&quot;,&quot;Tennessee&quot;,&quot;Texas&quot;,&quot;Utah&quot;,&quot;Vermont&quot;,&quot;Virginia&quot;,&quot;Washington&quot;,&quot;West Virginia&quot;,&quot;Wisconsin&quot;,&quot;Wyoming&quot;]" />
                </td>
                <td>
                    <input placeholder="Lugar de destino" id="txtOrigen" type="text" data-provide="typeahead"
                        data-items="4" data-source="[&quot;Alabama&quot;,&quot;Alaska&quot;,&quot;Arizona&quot;,&quot;Arkansas&quot;,&quot;California&quot;,&quot;Colorado&quot;,&quot;Connecticut&quot;,&quot;Delaware&quot;,&quot;Florida&quot;,&quot;Georgia&quot;,&quot;Hawaii&quot;,&quot;Idaho&quot;,&quot;Illinois&quot;,&quot;Indiana&quot;,&quot;Iowa&quot;,&quot;Kansas&quot;,&quot;Kentucky&quot;,&quot;Louisiana&quot;,&quot;Maine&quot;,&quot;Maryland&quot;,&quot;Massachusetts&quot;,&quot;Michigan&quot;,&quot;Minnesota&quot;,&quot;Mississippi&quot;,&quot;Missouri&quot;,&quot;Montana&quot;,&quot;Nebraska&quot;,&quot;Nevada&quot;,&quot;New Hampshire&quot;,&quot;New Jersey&quot;,&quot;New Mexico&quot;,&quot;New York&quot;,&quot;North Dakota&quot;,&quot;North Carolina&quot;,&quot;Ohio&quot;,&quot;Oklahoma&quot;,&quot;Oregon&quot;,&quot;Pennsylvania&quot;,&quot;Rhode Island&quot;,&quot;Santo Domingo Las Americas, DR&quot;,&quot;South Carolina&quot;,&quot;South Dakota&quot;,&quot;Tennessee&quot;,&quot;Texas&quot;,&quot;Utah&quot;,&quot;Vermont&quot;,&quot;Virginia&quot;,&quot;Washington&quot;,&quot;West Virginia&quot;,&quot;Wisconsin&quot;,&quot;Wyoming&quot;]" />
                </td>
            </tr>
            <tr>
                <td>
                    <span class="con">Fecha de partida:</span>
                </td>
                <td>
                    <span class="con">Fecha de retorno:</span>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="text" class="datepicker" id="datepickerOrigen" />
                </td>
                <td>
                    <input type="text" class="datepicker" id="datepickerDestino" />
                    <asp:TextBox ID="TextBox1" CssClass="datepicker"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right;">
                    <button id="Button4" runat="server" type="button" onclick="validarReservacion();"
                        class="btn btn-btn-primary">
                        Buscar vuelos</button>
                </td>
            </tr>
        </table>
    </div>
    <!-- JQuery -->
    <link type="text/css" href="../../jquery/css/jquery-ui-1.8.21.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="../../jquery/js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="../../jquery/js/jquery-ui-1.8.21.custom.min.js"></script>
    <!-- JQuery -->
    <!-- Bootstrap -->
    <script src="../../bootstrap/js/bootstrap.js"></script>
    <!-- Bootstrap -->

    <script type="text/javascript" src="../../js/Calls.js"></script>
    <script type="text/javascript" src="../../js/functions.js"></script>
</asp:Content>
