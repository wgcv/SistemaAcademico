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
    public partial class foro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = Libreria.consulta("select * from foros where estado ='A' order by id DESC");
            Label1.Text = "<table style=\"width:50%;border: solid 2px #333;\" >";
            Label1.Text += " <tr ><td style=\"border: solid 2px #696969;    background: #555175;\"><h1 style=\"margin: 1em;\">Foros</h1></td></tr>";

           for(int i=0; i<ds.Tables[0].Rows.Count;i++){
               Label1.Text += " <tr><td><a href=\"/forodetalle.aspx?id=" + Convert.ToString(ds.Tables[0].Rows[i]["id"]) + "\">" + Convert.ToString(ds.Tables[0].Rows[i]["descripcion"]) + "</a></td></tr>";

           }
           Label1.Text += "</table>";

        }
    }
}