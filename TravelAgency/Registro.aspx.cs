using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelAgency
{
    public partial class Registro : System.Web.UI.Page
    {
        private TravelAgency.Models.TravelAgencyEntities bd = new TravelAgency.Models.TravelAgencyEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            TravelAgency.Models.usuario user = new TravelAgency.Models.usuario();

            user.nombre = txtNombres.Text;
            user.apellido = txtApellidos.Text;
            user.nusuario = txtNombreUsuario.Text.ToLower();
            user.clave = MD5Generator.generarMD5(MD5Generator.generarMD5(txtClave.Text));
            user.correo = txtCorreo.Text;
            user.rol = "2";

            bd.usuarios.AddObject(user);

            bd.SaveChanges();


        }
    }
}