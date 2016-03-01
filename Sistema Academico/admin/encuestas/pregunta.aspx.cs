using empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin.encuestas
{
    public partial class pregunta : System.Web.UI.Page
    {
        int encuesta, npregunta, cantidad;
        protected void Page_Load(object sender, EventArgs e)
        {

            encuesta = Convert.ToInt32(Request["encuesta"]);
            npregunta = Convert.ToInt32(Request["pregunta"]);
            cantidad = Convert.ToInt32(Request["cantidad"]);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "abierta")
            {
                Panel1.Visible =false;

            }
            if (DropDownList1.SelectedValue == "cerrada")
            {
                Panel1.Visible = true;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "abierta")
            {

                Libreria.ejecuta("Insert INTO preguntaencuestas(numero, id_encuesta,pregunta, tipo) VALUES(" + npregunta + "," + encuesta + ",'" + txtPregunta.Text + "','A')");
            }
            if (DropDownList1.SelectedValue == "cerrada")
            {
                Libreria.ejecuta("Insert INTO preguntaencuestas(numero, id_encuesta,pregunta, tipo) VALUES(" + npregunta + "," + encuesta + ",'" + txtPregunta.Text + "','C')");
                if (txtR1.Text != "")
                {
                    Libreria.ejecuta("INSERT INTO respuestaencuestas(encuesta, pregunta, respuesta) VALUES(" + encuesta + "," + npregunta + ",'" + txtR1.Text + "')");
                }
                if (txtR2.Text != "")
                {
                    Libreria.ejecuta("INSERT INTO respuestaencuestas(encuesta, pregunta, respuesta) VALUES(" + encuesta + "," + npregunta + ",'" + txtR2.Text + "')");
                }

                if (txtR3.Text != "")
                {
                    Libreria.ejecuta("INSERT INTO respuestaencuestas(encuesta, pregunta, respuesta) VALUES(" + encuesta + "," + npregunta + ",'" + txtR3.Text + "')");
                }
                if (txtR4.Text != "")
                {
                    Libreria.ejecuta("INSERT INTO respuestaencuestas(encuesta, pregunta, respuesta) VALUES(" + encuesta + "," + npregunta + ",'" + txtR4.Text + "')");
                }
                if (txtR5.Text != "")
                {
                    Libreria.ejecuta("INSERT INTO respuestaencuestas(encuesta, pregunta, respuesta) VALUES(" + encuesta + "," + npregunta + ",'" + txtR5.Text + "')");
                }
               
            }
            if (cantidad == npregunta)
            {
                Response.Redirect("/admin/encuestas/fin.aspx");
            }
            else
            {
                Response.Redirect("/admin/encuestas/pregunta.aspx?encuesta=" + encuesta + "&pregunta=" + (npregunta + 1) + "&cantidad=" + cantidad);

            }
        }
    }
}