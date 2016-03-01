using empleado;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico
{
    public partial class documentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se consulta los documentos
            DataSet ds = Libreria.consulta("select * from documentos where estado ='A' order by id DESC");
            //se inicia l tabla
            lblTabla.Text = "<table style=\"width:95%;border: solid 2px #333;\" >";
            //Pone titulo 
            lblTabla.Text += " <tr ><td style=\"border: solid 2px #696969;    background: #555175;\" colspan=\"3\"><h1 style=\"margin: 1em;\">Documentos</h1></td></tr>";
            //Se agrega todas las eventos
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //muestra el titulo
                lblTabla.Text += " <tr><td>" + Convert.ToString(ds.Tables[0].Rows[i]["titulo"]) + "</td>";
                //muestra al categoria
                lblTabla.Text += "<td>Tipo: " + Convert.ToString(ds.Tables[0].Rows[i]["categoria"]) + "</td>";
                //muestra el archivo
                lblTabla.Text += "<td><a href =\"" + Convert.ToString(ds.Tables[0].Rows[i]["directorio"]) + "\">Documento</a></td>";
                lblTabla.Text += "</tr>";

            }
            //Se cierra la tabla
            lblTabla.Text += "</table>";
            if (Convert.ToString(Session["usuario"]) != "")
            {
                pnlSubir.Visible = true;
            }
        }

        protected void btnSuscribirce_Click(object sender, EventArgs e)
        {
            Libreria.ejecuta("INSERT INTO CONTACTOS(nombre, correo, grupo_id) values('" + txtNombre.Text + "', '" + txtCorreo.Text + "',4)");
            btnSuscribirce.Enabled = false;
            btnSuscribirce.Text = "Se suscribió";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                String path = Path.Combine(Server.MapPath("~/Documentos"), FileUpload1.FileName);
                FileUpload1.SaveAs(path);
                String fullPath = "/Documentos/" + FileUpload1.FileName;
                String sql = "Insert into documentos(categoria, titulo, directorio, estado) VALUES('" + DropDownList1.SelectedValue + "','" + TextBox1.Text + "','" + fullPath + "','P')";
                Libreria.ejecuta(sql);
                pnlSubir.Visible = false;
                lblMensaje.Text = "Se subio correctamente. Se va a revisar el documento.";
            }
        }
    }
}