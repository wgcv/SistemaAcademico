using empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin
{
    public partial class documentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Libreria.consulta("select * from DOCUMENTOS where estado = 'A' or estado='P'");
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
            txtCategoria.Text = registro.Cells[3].Text;
            txtTitulo.Text = registro.Cells[4].Text;
            if (registro.Cells[6].Text == "A")
            {
                CheckBox1.Checked = true;

            }
            else
            {
                CheckBox1.Checked = false;

            }
            
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
            String estado = "P";


            if (CheckBox1.Checked)
            {
                estado = "A";
            }
            string sql = "";
            if (Session["modo"] == "i")
            {
              //  sql = "INSERT INTO eventos (categoria,lugar,telefono,descripcion,img,fecha,estado) VALUES('" + txtTitulo.Text + "','" + txtLuguar.Text + "','" + txtTelefono.Text + "','" + txtDescripcion.Text + "','" + fullPath + "','" + txtFecha + "','A')";


            }
            else if (Session["modo"] == "m")
            {
                sql = "UPDATE DOCUMENTOS SET categoria='" + txtCategoria.Text + "',titulo='" + txtTitulo.Text + "',estado='" + estado + "' where id=" + txtCodigo.Text;


            }
            else
            {
                sql = "UPDATE DOCUMENTOS SET estado='I' where id =" + txtCodigo.Text;

            }
            Libreria.ejecuta(sql);

            Response.Redirect(Request.RawUrl);

        }

     
    }
}