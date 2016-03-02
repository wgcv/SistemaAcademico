using empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin
{
    public partial class contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Libreria.consulta("select * from contactanos where estado = 'A'");
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Panel1.Visible = true;
            int fila = Convert.ToInt32(e.CommandArgument);
            GridViewRow registro = GridView1.Rows[fila];
            txtCodigo.Enabled = false;
            txtCodigo.Text = registro.Cells[2].Text;
            txtTitulo.Text = registro.Cells[3].Text;

            txtLuguar.Text = registro.Cells[4].Text;
            txtFecha.Text = registro.Cells[5].Text;
           
            if (e.CommandName == "modificar")
            {

                Session["modo"] = "m";
            }
            else
            {

                lblMensaje.Text = "Esta seguro que desea eliminar el registro";
                Session["modo"] = "e";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            lblMensaje.Text = "";

            string sql = "";
            if (Session["modo"] == "i")
            {
                sql = "INSERT INTO contactanos (nombre,email,mensaje,estado) VALUES('" + txtTitulo.Text + "','" + txtLuguar.Text + "','" + txtFecha.Text + "','A')";


            }
            else if (Session["modo"] == "m")
            {
                sql = "UPDATE contactanos SET nombre='" + txtTitulo.Text + "',email='" + txtLuguar.Text + "', mensaje=' " + txtFecha.Text + "',estado='A' where id=" + txtCodigo.Text;


            }
            else
            {
                sql = "UPDATE contactanos SET estado='I' where id =" + txtCodigo.Text;

            }
            Libreria.ejecuta(sql);

            Response.Redirect(Request.RawUrl);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["modo"] = "i";
            Panel1.Visible = true;
        }
    }
}