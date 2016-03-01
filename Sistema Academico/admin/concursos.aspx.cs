using empleado;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin
{
    public partial class concursos : System.Web.UI.Page
    {
        string fullPath = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Libreria.consulta("select * from concurso where estado = 'A'");
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
            txtDescripcion.Text = registro.Cells[7].Text;
            Session["img"] = registro.Cells[6].Text;
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
            fullPath = Session["img"].ToString();
            if (FileUpload1.HasFile)
            {
                String path = Path.Combine(Server.MapPath("~/Images"), FileUpload1.FileName);
                FileUpload1.SaveAs(path);
                fullPath = "/Images/" + FileUpload1.FileName;


            }
            lblMensaje.Text = "";

            string sql = "";
            if (Session["modo"] == "i")
            {
                sql = "INSERT INTO concurso (titulo,lugar,fecha,img,descripcion,estado) VALUES('" + txtTitulo.Text + "','" + txtLuguar.Text + "','" + txtFecha.Text + "','" + fullPath + "','" + txtDescripcion.Text  + "','A')";


            }
            else if (Session["modo"] == "m")
            {
                sql = "UPDATE concurso SET titulo='" + txtTitulo.Text + "',lugar='" + txtLuguar.Text + "',descripcion='" + txtDescripcion.Text + "',img='" + fullPath + "',fecha='" + txtFecha.Text + "',estado='A' where id=" + txtCodigo.Text;


            }
            else
            {
                sql = "UPDATE concurso SET estado='I' where id =" + txtCodigo.Text;

            }
            Libreria.ejecuta(sql);

            Response.Redirect(Request.RawUrl);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["modo"] = "i";
            Session["img"] = "";
            Panel1.Visible = true;
        }
    }
}