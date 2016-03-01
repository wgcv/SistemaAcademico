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
    public partial class noticiasdetalle : System.Web.UI.Page
    {
        String idNoticia;
        protected void Page_Load(object sender, EventArgs e)
        {
            //recupera por get el id de la noticia que presenta
            idNoticia = Request["id"];
            // Verifica si esta registrado el usuario
            if (Convert.ToString(Session["usuario"]) != "")
            {
                //Muestra la calificacion
                pnlCalificacion.Visible = true;
            }
            // Recupera la noticia
            DataSet ds = Libreria.consulta("select * from noticias where id=" + idNoticia);
            // Ingresa los valores de la noticia a los controles
            lblTitulo.Text = Convert.ToString(ds.Tables[0].Rows[0]["titulo"]);
            imgNoticia.ImageUrl = Convert.ToString(ds.Tables[0].Rows[0]["img"]);
            lblDescripcion.Text = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
            // Proceso de calificacion Se procedera a calcular
            if ( Convert.ToInt32(ds.Tables[0].Rows[0]["num_calificacion"])>0){
            int calificacion = Convert.ToInt32(ds.Tables[0].Rows[0]["calificacion"]) / Convert.ToInt32(ds.Tables[0].Rows[0]["num_calificacion"]);
            //Se evalua que imagen muestra dependiendo de la calificacion
            if (calificacion == 5) { estrellas.ImageUrl = "~/calificacion/c5.png"; }
            if (calificacion == 4) { estrellas.ImageUrl = "~/calificacion/c4.png"; }
            if (calificacion == 3) { estrellas.ImageUrl = "~/calificacion/c3.png"; }
            if (calificacion == 2) { estrellas.ImageUrl = "~/calificacion/c2.png"; }
            if (calificacion < 2) { estrellas.ImageUrl = "~/calificacion/c1.png"; }
            }
            else
            {
                estrellas.ImageUrl = "~/calificacion/c5.png";
            }
        }

        protected void btnCalificar_Click(object sender, EventArgs e)
        {
            Libreria.ejecuta("update NOTICIAS SET calificacion += " + Convert.ToInt32(DropDownList1.SelectedValue) + ", num_calificacion += 1 where id=" + idNoticia);
            Response.Redirect(Request.RawUrl);

        }
    }
}