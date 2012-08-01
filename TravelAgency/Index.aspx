<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TravelAgency.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="bluePanel mid">

        <table class="pnlReserv">
            <tr>
                <td>
                    <div class="btn-group" data-toggle="buttons-radio">
                        <button clientidmode="Static" class="btn active" type="button" onclick="datepickerRetorno.readOnly = false;"
                            title="Reservar viaje de ida y vuelta">
                            <span class="con dark">Ida y vuelta</span>
                        </button>
                        <button clientidmode="Static" class="btn" type="button" onclick="datepickerRetorno.readOnly = true;"
                            title="Reservar viaje de ida">
                            <span class="con dark">Ida</span>
                        </button>
                    </div>
                </td>
            </tr>
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
                    <asp:TextBox ID="txtPartida" runat="server" placeholder="Lugar de partida" ClientIDMode="Static"
                        data-provide="typeahead" data-items="4"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtDestino" runat="server" placeholder="Lugar de destino" ClientIDMode="Static"
                        data-provide="typeahead" data-items="4"></asp:TextBox>
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
                    <asp:TextBox ID="datepickerPartida" runat="server" ClientIDMode="Static"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="datepickerRetorno" runat="server" ClientIDMode="Static"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: right;">
                    <button clientidmode="Static" id="btnBuscar" runat="server" onserverclick="validarReservacion"
                        class="btn btn-btn-primary" title="Buscar vuelos">
                        <span class="con dark">Buscar</span>
                    </button>
                </td>
            </tr>
        </table>
    </div>
    <asp:GridView ID="GridView1" CssClass="mGrid" runat="server" ClientIDMode="Static">
        
    </asp:GridView>
</asp:Content>
