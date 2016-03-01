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
    public partial class forodetalle : System.Web.UI.Page
    {
        String idforo="0";
        protected void Page_Load(object sender, EventArgs e)
        {
            idforo = Request["id"];
            DataSet ds = Libreria.consulta("select usuarios.usuario , respuestaforos.respuesta  , respuestaforos.id from respuestaforos, usuarios where id_foro=" + idforo + " AND estado ='A' AND usuarios.id= respuestaforos.id_usuario order by id DESC");
            DataSet ds2 = Libreria.consulta("select descripcion from foros where id="+idforo+" AND estado ='A' order by id DESC");
            Label1.Text = "<table style=\"width:50%;border: solid 2px #333;\" >";
            Label1.Text += " <tr ><td style=\"border: solid 2px #696969;    background: #555175;\" colspan=\"2\"><h1 style=\"margin: 1em;\" >" + Convert.ToString(ds2.Tables[0].Rows[0]["descripcion"]) + "</h1></td></tr>";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Label1.Text += " <tr><td>" + Convert.ToString(ds.Tables[0].Rows[i]["usuario"]) + ": </td>";
                Label1.Text += "<td>" + Convert.ToString(ds.Tables[0].Rows[i]["respuesta"]) + "</td></tr>";

            }
            Label1.Text += "</table>";
            if (Convert.ToString(Session["usuario"]) != "")
            {
                pnlResponder.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Libreria.ejecuta("Insert INTO respuestaforos(id_foro,id_usuario,respuesta) values(" + idforo + ", (select id from usuarios where usuario='" + Session["usuario"] + "'), '" + TextBox1.Text + "')");
            Response.Redirect(Request.RawUrl);

        }
    }
}