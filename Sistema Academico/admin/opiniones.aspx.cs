using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin
{
    public partial class opiniones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/PreguntaOpinion.aspx");

        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/RespuestaOpinones.aspx");

        }
    }
}