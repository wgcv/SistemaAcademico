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
    public partial class _Default : Page
    {
        int noticias1, noticias2, noticias3;
        int eventos1, eventos2, eventos3;
        int concursos1, concursos2, concursos3;
        int foros1, foros2, foros3;
        protected void Page_Load(object sender, EventArgs e)
        {
            noticias();
            eventos();
            concursos();
            opinion();
            foros();
        }
        public void noticias()
        {
            DataSet ds = Libreria.consulta("select id, titulo, descripcion, img from noticias where estado='A' ORDER BY id DESC");
            noticiasimg1.ImageUrl = ds.Tables[0].Rows[0]["img"].ToString();
            noticiaslabel1.Text = ds.Tables[0].Rows[0]["titulo"].ToString();
            noticias1 = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            noticiasimg2.ImageUrl = ds.Tables[0].Rows[1]["img"].ToString();
            noticiaslabel2.Text = ds.Tables[0].Rows[1]["titulo"].ToString();
            noticias2 = Convert.ToInt32(ds.Tables[0].Rows[1]["id"].ToString());
            noticiasimg3.ImageUrl = ds.Tables[0].Rows[2]["img"].ToString();
            noticiaslabel3.Text = ds.Tables[0].Rows[2]["titulo"].ToString();
            noticias3 = Convert.ToInt32(ds.Tables[0].Rows[2]["id"].ToString());

        }
        public void eventos()
        {
            DataSet ds = Libreria.consulta("select id, titulo, descripcion, img from eventos where estado='A' ORDER BY id DESC");
            eventosimg1.ImageUrl = ds.Tables[0].Rows[0]["img"].ToString();
            eventoslabel1.Text = ds.Tables[0].Rows[0]["titulo"].ToString();
            eventos1 = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            eventosimg2.ImageUrl = ds.Tables[0].Rows[1]["img"].ToString();
            eventoslabel2.Text = ds.Tables[0].Rows[1]["titulo"].ToString();
            eventos2 = Convert.ToInt32(ds.Tables[0].Rows[1]["id"].ToString());

            eventosimg3.ImageUrl = ds.Tables[0].Rows[2]["img"].ToString();
            eventoslabel3.Text = ds.Tables[0].Rows[2]["titulo"].ToString();
            eventos3 = Convert.ToInt32(ds.Tables[0].Rows[2]["id"].ToString());

        }
        public void concursos()
        {
            DataSet ds = Libreria.consulta("select id, titulo, descripcion, img from concurso where estado='A' ORDER BY id DESC");
            concursosimg1.ImageUrl = ds.Tables[0].Rows[0]["img"].ToString();
            concursoslabel1.Text = ds.Tables[0].Rows[0]["titulo"].ToString();
            concursos1 = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            concursosimg2.ImageUrl = ds.Tables[0].Rows[1]["img"].ToString();
            concursoslabel2.Text = ds.Tables[0].Rows[1]["titulo"].ToString();
            concursos2 = Convert.ToInt32(ds.Tables[0].Rows[1]["id"].ToString());

            concursosimg3.ImageUrl = ds.Tables[0].Rows[2]["img"].ToString();
            concursoslabel3.Text = ds.Tables[0].Rows[2]["titulo"].ToString();
            concursos3 = Convert.ToInt32(ds.Tables[0].Rows[2]["id"].ToString());

        }
        public void opinion()
        {
            DataSet ds2 = Libreria.consulta("select id, pregunta from preguntascortas where estado='A' ORDER BY id DESC");
            lblopinion.Text = ds2.Tables[0].Rows[0]["pregunta"].ToString();
            DataSet ds = Libreria.consulta("select id, respuesta from respuestaspreguntascortas where estado='A' ORDER BY id DESC");
            Opinion1.Text = ds.Tables[0].Rows[0]["respuesta"].ToString();
            Opinion2.Text = ds.Tables[0].Rows[1]["respuesta"].ToString();
            Opinion3.Text = ds.Tables[0].Rows[2]["respuesta"].ToString();


        }
        public void foros()
        {
            DataSet ds = Libreria.consulta("select id,  descripcion from foros where estado='A' ORDER BY id DESC");

            forolabel1.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
            foros1 = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());

            forolabel2.Text = ds.Tables[0].Rows[1]["descripcion"].ToString();
            foros2 = Convert.ToInt32(ds.Tables[0].Rows[1]["id"].ToString());


            forolabel3.Text = ds.Tables[0].Rows[2]["descripcion"].ToString();
            foros3 = Convert.ToInt32(ds.Tables[0].Rows[2]["id"].ToString());

        }

        protected void noticiasl1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/noticiasdetalle.aspx?id="+noticias1);

        }

        protected void noticiasl2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/noticiasdetalle.aspx?id=" + noticias2);
        }

        protected void noticiasl3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/noticiasdetalle.aspx?id=" + noticias3);
        }

        protected void eventosl1_Click(object sender, EventArgs e)
        {

        }

        protected void forol1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/forodetalle.aspx?id=" + foros1);

        }

        protected void forol2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/forodetalle.aspx?id=" + foros1);


        }

        protected void forol3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/forodetalle.aspx?id=" + foros1);

        }

       
    }
}