<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
CodeBehind="Default.aspx.cs" Inherits="TravelAgency._Default" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
	<title>Travel Agency | Inicio</title>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
	<!--div id="myCarousel" class="carousel slide">
	<div class="carousel-inner">
	<div class="item active">
	<img src="img/galeria/City-Wallpaper-3.jpg" alt="">
	<div class="carousel-caption">
	<h4>
	Third Thumbnail label</h4>
	<p>
	Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi
	porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
	</p>
	</div>
	</div>
	<div class="item">
	<img src="img/galeria/City-Wallpaper-4.jpg" alt="">
	<div class="carousel-caption">
	<h4>
	Third Thumbnail label</h4>
	<p>
	Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi
	porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
	</p>
	</div>
	</div>
	<div class="item">
	<img src="img/galeria/City-Wallpaper-5.jpg" alt="">
	<div class="carousel-caption">
	<h4>
	Third Thumbnail label</h4>
	<p>
	Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi
	porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
	</p>
	</div>
	</div>
	<div class="item">
	<img src="img/galeria/City-Wallpaper-11.jpg" alt="">
	<div class="carousel-caption">
	<h4>
	Third Thumbnail label</h4>
	<p>
	Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi
	porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
	</p>
	</div>
	</div>
	<div class="item">
	<img src="img/galeria/City-Wallpaper-25.jpg" alt="">
	<div class="carousel-caption">
	<h4>
	Third Thumbnail label</h4>
	<p>
	Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi
	porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
	</p>
	</div>
	</div>
	<div class="item">
	<img src="img/galeria/City-Wallpaper-28.jpg" alt="">
	<div class="carousel-caption">
	<h4>
	Third Thumbnail label</h4>
	<p>
	Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi
	porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
	</p>
	</div>
	</div>
	</div>
	<a class="left carousel-control" href="#myCarousel" data-slide="prev">‹</a> <a class="right carousel-control"
	href="#myCarousel" data-slide="next">›</a>
	</div-->
	<div class="modal hide" id="myModal">
		<div class="modal-header">
			<button type="button" class="close" data-dismiss="modal">
				×
			</button>
			<h3> Iniciar Sesion</h3>
		</div>
		<div class="modal-body">
			<table>
				<tr>
					<td>
					<div class='login'>
						<form action='' method='post' accept-charset='UTF-8'>
							<span class="con dark">Usuario:</span>
							<br />
							<input clientidmode="Static" id='txtUser' style='margin-bottom: 15px;' type='text'
							placeholder='Nombre de usuario' name='txtUser' size='30' />
							<br />
							<span class="con dark">Contrase&ntilde;a:</span>
							<br />
							<input clientidmode="Static" id='txtPass' style='margin-bottom: 15px;' type='password'
							placeholder='Contraseña' name='txtPass' size='30' />
							<br />
						</form>
					</div></td>
					<td><img src="../../img/logo.png" height="64px" /></td>
				</tr>
			</table>
		</div>
		<div class="modal-footer">
			<button clientidmode="Static" class='btn btn-success' type='submit' name='commit'>
				<span class="con">Ingresar</span>
			</button>
			<a href="#" class="btn" data-dismiss="modal"><span class="con dark">Cerrar</span>
			<br />
			</a>
		</div>
	</div>
	<div class="pnlReserv">
		<table class="pnlReserv">
			<tr>
				<td><span class="con">Salir de:</span></td>
				<td><span class="con">Llegar a:</span></td>
			</tr>
			<tr>
				<td><asp:TextBox ID="txtPartida" runat="server" placeholder="Lugar de partida" ClientIDMode="Static"
				data-provide="typeahead" data-items="4"></asp:TextBox></td>
				<td><asp:TextBox ID="txtDestino" runat="server" placeholder="Lugar de destino" ClientIDMode="Static"
				data-provide="typeahead" data-items="4"></asp:TextBox></td>
			</tr>
			<tr>
				<td><span class="con">Fecha de partida:</span></td>
				<td><span class="con">Fecha de retorno:</span></td>
			</tr>
			<tr>
				<td><asp:TextBox ID="datepickerPartida" runat="server" ClientIDMode="Static"></asp:TextBox></td>
				<td><asp:TextBox ID="datepickerDestino" runat="server" ClientIDMode="Static"></asp:TextBox></td>
			</tr>
			<tr>
				<td>
				<div class="btn-group" data-toggle="buttons-radio">
					<button clientidmode="Static" class="btn" type="button" title="Reservar viaje de ida">
						<span class="con dark">Ida</span>
					</button>
					<button clientidmode="Static" class="btn" type="button" title="Reservar viaje de ida y vuelta">
						<span class="con dark">Ida y vuelta</span>
					</button>
				</div></td>
			</tr>
			<tr>
				<td colspan="2" style="text-align: right;">
				<button clientidmode="Static" id="btnBuscar" runat="server" onserverclick="validarReservacion"
				class="btn btn-btn-primary" title="Buscar vuelos">
					<span class="con dark">Buscar</span>
				</button></td>
			</tr>
		</table>
	</div>
	<asp:GridView ID="GridView1" CssClass="mGrid" runat="server"></asp:GridView>
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
</asp:Content>
