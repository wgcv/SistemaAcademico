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
    public partial class noticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se consulta las noticas
            DataSet ds = Libreria.consulta("select * from noticias where estado ='A' order by id DESC");
          //se inicia l tabla
            lblNoticias.Text = "<table style=\"width:75%;border: solid 2px #333;\" >";
           //Pone titulo 
            lblNoticias.Text += " <tr ><td style=\"border: solid 2px #696969;    background: #555175;\"><h1 style=\"margin: 1em;\">Noticas</h1></td></tr>";
            //Se agrega todas las noticias
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lblNoticias.Text += " <tr><td><center> <br><a href=\"/noticiasdetalle.aspx?id=" + Convert.ToString(ds.Tables[0].Rows[i]["id"]) + "\"><img src=\"" + Convert.ToString(ds.Tables[0].Rows[i]["img"]) + "\" style=\"width: 350px;\"> <br><br>" + Convert.ToString(ds.Tables[0].Rows[i]["titulo"]) + "</a></center><p>";
                //Si es mayor a 200 se muestra un preview
                if (Convert.ToString(ds.Tables[0].Rows[i]["descripcion"]).Length > 250) { 
                lblNoticias.Text += Convert.ToString(ds.Tables[0].Rows[i]["descripcion"]).Substring(0, 130) +"...";
                }
                    lblNoticias.Text += "</p></td></tr>";

            }
            //Se cierra la tabla
            lblNoticias.Text += "</table>";

        }
    }
}