<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TravelAgency._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        ASP.NET
    </h2>
    <p>
        <asp:TextBox ID="txtOrigen" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtDestino" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtFecha1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtFecha2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
    </p>
    <p>
        &nbsp;<asp:GridView ID="Tabla" runat="server">
        </asp:GridView>
        O</p>
    <p>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
