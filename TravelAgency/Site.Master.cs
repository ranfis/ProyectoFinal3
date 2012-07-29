using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelAgency.Models;

namespace TravelAgency
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        TravelAgencyEntities agency = new TravelAgencyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void logIn(object sender, EventArgs e)
        {
            txtUser.CssClass = "";
            txtPass.CssClass = "";

            string clave = MD5Generator.generarMD5(MD5Generator.generarMD5(txtPass.Text));
            usuario user = agency.usuarios.ToList().Find(c => c.nusuario.Equals(txtUser.Text) && c.clave.Equals(clave));
            if (user != null)
            {
                Session["userLoged"] = user;
                txtUser.Text = "";
                txtPass.Text = "";
                
            }
            else
            {
                txtUser.CssClass = "error";
                txtPass.CssClass = "error";
            }
        }
    }
}
