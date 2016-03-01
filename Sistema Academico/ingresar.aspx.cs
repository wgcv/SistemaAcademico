using empleado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico
{
    public partial class ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            DataSet ds = Libreria.consulta("select usuario, nombre, apellido from usuarios where usuario='" + txtUsuario.Text + "' and password='" + sha256(txtPassword.Text) + "' and estado='A'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["usuario"] = ds.Tables[0].Rows[0]["usuario"].ToString();
                Session["nombre"] = ds.Tables[0].Rows[0]["nombre"].ToString() + " " + ds.Tables[0].Rows[0]["apellido"].ToString();
                Response.Redirect("/");

            }
            else
            {
                lblerror.Text = "Error al ingresar <a href=\"/recuperar.aspx?usuario=" + txtUsuario.Text + "\">Recuperar clave</a>";
                lblerror.Visible = true;
            }
        }
        //Sirve para encriptar
        static string sha256(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}