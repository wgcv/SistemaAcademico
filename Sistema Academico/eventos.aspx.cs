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
    public partial class eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se consulta las eventos
            DataSet ds = Libreria.consulta("select * from eventos where estado ='A' order by id DESC");
            //se inicia l tabla
            lblTabla.Text = "<table style=\"width:95%;border: solid 2px #333;\" >";
            //Pone titulo 
            lblTabla.Text += " <tr ><td style=\"border: solid 2px #696969;    background: #555175;\"><h1 style=\"margin: 1em;\">Eventos</h1></td></tr>";
            //Se agrega todas las eventos
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lblTabla.Text += " <tr><td><center> <br> <h1>" + Convert.ToString(ds.Tables[0].Rows[i]["titulo"]) + "</h1><br><img src=\"" + Convert.ToString(ds.Tables[0].Rows[i]["img"]) + "\" style=\"width: 75%;\"> <br></center><br>" + Convert.ToString(ds.Tables[0].Rows[i]["descripcion"]) + "</p><p>";
                //Si muestra fecha y lugar
             
                    lblTabla.Text += "<p>Fecha: "+ Convert.ToString(ds.Tables[0].Rows[i]["fecha"]) + "</p>";

                    lblTabla.Text += "<p>Lugar: " + Convert.ToString(ds.Tables[0].Rows[i]["lugar"]) + "</p>";
                    lblTabla.Text += "</p> <hr></td></tr>";

            }
            //Se cierra la tabla
            lblTabla.Text += "</table>";

        }

        protected void btnSuscribirce_Click(object sender, EventArgs e)
        {
            Libreria.ejecuta("INSERT INTO CONTACTOS(nombre, correo, grupo_id) values('" + txtNombre.Text + "', '" + txtCorreo.Text + "',1)");
            btnSuscribirce.Enabled = false;
            btnSuscribirce.Text = "Se suscribió";

        }
    }
}