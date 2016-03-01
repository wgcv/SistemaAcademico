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
    public partial class recupear : System.Web.UI.Page
    {
        String pregunta = "";
        String respuesta = "";
        String usuario = "";
        protected void Page_Load(object sender, EventArgs e)
        {
             usuario = Request["usuario"];
            
            DataSet ds = Libreria.consulta("select pregunta,respuesta from usuarios where usuario='" + usuario + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                pregunta = ds.Tables[0].Rows[0]["pregunta"].ToString();
                respuesta = ds.Tables[0].Rows[0]["respuesta"].ToString();
                lblInformacion.Text = pregunta;
            }
            else
            {
                lblInformacion.Text = "Error el usuario no existe";
                txtRespuesta.Visible = false;
            }
            
        }

        protected void btnResponder_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.Text == respuesta)
            {
                txtClave.Visible = true;
                lblInformacion.Text = "Ingrese la nueva clave";
                lblInformacion.Visible = true; 
                btnResponder.Visible = false;
                txtRespuesta.Visible = false;
                lblpassword.Visible = true;
                btnPassword.Visible = true;
            }
        }

        protected void btnPassword_Click(object sender, EventArgs e)
        {
            Libreria.ejecuta("UPDATE usuarios set password ='" + sha256(txtClave.Text) + "' where usuario ='" + usuario + "'");
         Response.Redirect("/");

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

        protected void txtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}