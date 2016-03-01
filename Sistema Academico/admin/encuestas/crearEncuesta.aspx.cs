using empleado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin.encuestas
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Libreria.ejecuta("INSERT INTO encuestas(titulo, preguntas, estado) VALUES('"+txtTitulo.Text+"',"+Convert.ToInt32(txtCantidad.Text)+",'A')");
            DataSet ds = Libreria.consulta("select id from encuestas where titulo= '" + txtTitulo.Text+"' order by id DESC");
            int encuesta = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            Response.Redirect("/admin/encuestas/pregunta.aspx?encuesta=" + encuesta + "&pregunta=1&cantidad=" + Convert.ToInt32(txtCantidad.Text));

       }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);

        }
    }
}