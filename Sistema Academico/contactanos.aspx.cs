using empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico
{
    public partial class contactanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Libreria.ejecuta("INSERT INTO contactanos(nombre,email,mensaje) VALUES('" + lblNombre.Text + "','" + lblEmail.Text + "','" + lblMensaje.Text + "')");
            Label1.Text = "Se envio correctamente, gracias por su mensaje";
            btnEnviar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);

        }
    }
}