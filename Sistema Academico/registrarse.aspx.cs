using empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico
{
    public partial class registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {  }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {//Compara q las claves sean iguales
            if (txtPassword1.Text == txtPassword2.Text)
            {
                
                //se encripta la clave
                String password = sha256(txtPassword1.Text);
                //se crea la sentencia SQL para guardar en la base de datos

                String sql = "Insert into usuarios(nombre,apellido,usuario,carrera,password,pregunta,respuesta,correo) VALUES('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtUsuario.Text + "','" + ddlcarrera.SelectedItem.Text + "','" + password + "','" + ddlpregunta.SelectedItem.Text + "','" + txtRespuesta.Text + "','" + txtCorreo.Text + "')";
                if (Libreria.ejecuta(sql) > 0)
                {

               
                Session["usuario"] = txtUsuario.Text;
                Session["nombre"] = txtNombre.Text + " " + txtApellido.Text;
                Response.Redirect("/");
                }
                else
                {
                    lblError.Text = "Ya existe un usuario con esos datos";
                }

            }
            else
            {
                lblError.Text = "Las claves no coninciden";
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