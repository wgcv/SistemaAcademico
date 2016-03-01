using empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin
{
    public partial class contactosemail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

            txtNombre.Text = registro.Cells[3].Text;
            txtCorreo.Text = registro.Cells[4].Text;
            txtGrupo.Text = registro.Cells[5].Text;

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
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            string sql = "";
            if (Session["modo"] == "i")
            {
                sql = "INSERT INTO contactos (nombre,correo,grupo_id,estado) VALUES('" + txtNombre.Text + "','" + txtCorreo.Text + "','" + txtGrupo.Text + "','A')";


            }
            else if (Session["modo"] == "m")
            {
                sql = "UPDATE contactos SET nombre='" + txtNombre.Text + "', correo='" + txtCorreo.Text + "', grupo_id='" + txtGrupo.Text + "' where id=" + txtCodigo.Text;


            }
            else
            {
                sql = "UPDATE contactos SET estado='I' where id =" + txtCodigo.Text;

            }
            Libreria.ejecuta(sql);

            Response.Redirect(Request.RawUrl);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);

        }

        protected void Button5_Click1(object sender, EventArgs e)
        {
            Session["modo"] = "i";
            Session["img"] = "";
            Panel1.Visible = true;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            GridView1.DataSource = Libreria.consulta("select * from contactos where estado = 'A' AND grupo_id=" + DropDownList1.SelectedValue );
            GridView1.DataBind();
        }
    }
}