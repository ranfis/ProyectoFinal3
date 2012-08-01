<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Registro.aspx.cs" Inherits="TravelAgency.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <span class="con dark super">Registrarse</span></h1>
    <table style="width: 400px; margin: auto">
        <tr>
            <td>
                <asp:label id="lblCorreo" runat="server" text="Correo"></asp:label>
            </td>
            <td>
                <asp:textbox id="txtCorreo" runat="server" placeholder="digite su correo electronico"
                    width="210px" clientidmode="Static"></asp:textbox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:label id="lblNombreUsuario" runat="server" text="Nombre Usuario"></asp:label>
            </td>
            <td>
                <asp:textbox id="txtNombreUsuario" runat="server" placeholder="digite su nombre de usuario"
                    clientidmode="Static"></asp:textbox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:label id="lblClave" runat="server" text="Clave"></asp:label>
            </td>
            <td>
                <asp:textbox id="txtClave" runat="server" placeholder="digite su clave" clientidmode="Static"></asp:textbox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:label id="lblNombres" runat="server" text="Nombre (s)"></asp:label>
            </td>
            <td>
                <asp:textbox id="txtNombres" runat="server" placeholder="digite su (s) nombre (s)"
                    clientidmode="Static"></asp:textbox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:label id="lblApellidos" runat="server" text="Apellidos (s)"></asp:label>
            </td>
            <td>
                <asp:textbox id="txtApellidos" runat="server" placeholder="digite su (s) apellido (s)"
                    clientidmode="Static"></asp:textbox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:button id="btnRegistrar" cssclass="btn" runat="server" text="Registrarse" onclick="btnRegistrar_Click" />
            </td>
        </tr>
    </table>
    <br />
    <!-- JQuery -->
    <link type="text/css" href="jquery/css/jquery-ui-1.8.21.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="jquery/js/jquery-1.7.2.min.js">     </script>
    <script type="text/javascript" src="jquery/js/jquery-ui-1.8.21.custom.min.js"></script>
    <!-- JQuery -->
    <!-- Bootstrap -->
    <script src="../../bootstrap/js/bootstrap.js"></script>
    <!-- Bootstrap -->
    <script type="text/javascript" src="js/calls.js"></script>
    <script>
        ("#txtCorreo").click(function () {
            $.post("registrarse.aspx", function (data) {
                alert(data);
            })
        });
    </script>
</asp:Content>
