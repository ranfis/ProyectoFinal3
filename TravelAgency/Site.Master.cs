using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace TravelAgency
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        TravelAgency.Models.TravelAgencyEntities agency = new TravelAgency.Models.TravelAgencyEntities();
        public static String err;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public static String getErr()
        {

            return err;
        }
        protected void logOut(object sender, EventArgs e)
        {
            Session.Clear();
        }
        protected void logIn(object sender, EventArgs e)
        {
            txtUser.CssClass = "";
            txtPass.CssClass = "";

            string clave = MD5Generator.generarMD5(MD5Generator.generarMD5(txtPass.Text));
            try
            {
                TravelAgency.Models.usuario user = agency.usuarios.ToList().Find(c => c.nusuario.Equals(txtUser.Text) && c.clave.Equals(clave));
                if (user != null)
                {
                    Session["userLoged"] = user.nusuario;
                    txtUser.Text = "";
                    txtPass.Text = "";

                }
                else
                {
                    txtUser.CssClass = "error";
                    txtPass.CssClass = "error";
                    //Session["userLoged"] = "";
                }
            }
            catch (Exception)
            {
                txtUser.CssClass = "error";
                txtPass.CssClass = "error";
                Session["userLoged"] = "";
                Response.Redirect("/");
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }
    }
}
