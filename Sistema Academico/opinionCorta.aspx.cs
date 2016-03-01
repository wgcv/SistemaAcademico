using empleado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico
{

    public partial class opinionCorta : System.Web.UI.Page
    {
        int id_pregunta = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
 if (Convert.ToString(Session["usuario"]) != ""  ){
     pnlResponder.Visible = true;
 }
 else
 {
     lblMensaje.Visible = true;
 
 
 }
 DataSet ds = Libreria.consulta("select pregunta, id from preguntascortas where estado ='A' order by id DESC ");
  lblPregunta.Text =   ds.Tables[0].Rows[0]["pregunta"].ToString();
  id_pregunta = (int)ds.Tables[0].Rows[0]["id"];
  GridView1.DataSource = Libreria.consulta("select [usuarios].usuario, [respuestaspreguntascortas].respuesta from respuestaspreguntascortas, usuarios where [usuarios].id = [respuestaspreguntascortas].id_usuario AND id_pregunta =" + (int)ds.Tables[0].Rows[0]["id"]);
  GridView1.DataBind();
    }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Libreria.ejecuta("Insert INTO respuestaspreguntascortas(id_usuario,id_pregunta, respuesta) VALUES((select id from usuarios where usuario='"+Convert.ToString(Session["usuario"])+"'),"+id_pregunta+",'"+TextBox1.Text+"')");
            Response.Redirect(Request.RawUrl);

        }

          }
}