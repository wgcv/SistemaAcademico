using empleado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin.encuestas
{
    public partial class respuestas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        public void consultar()
        {
            DataSet dsE = Libreria.consulta("select * from preguntaencuestas where id_encuesta=" + DropDownList1.SelectedValue + " and tipo ='C'");
            for (int i = 0; i < dsE.Tables[0].Rows.Count; i++)
            {
                Chart chart = new Chart();
                DataSet ds = Libreria.consulta("select respuesta, contador from respuestaencuestas where encuesta= "+DropDownList1.SelectedValue+" AND pregunta = " + dsE.Tables[0].Rows[i]["numero"].ToString());
                // Set chart data source
                chart.DataSource = ds;
                Title tt = new Title();
                tt.Name = "tTitle";
                tt.Text = dsE.Tables[0].Rows[i]["pregunta"].ToString();

                chart.Titles.Add(tt);


                chart.Series.Add(new Series());
                chart.ChartAreas.Add(new ChartArea());
                chart.ChartAreas[0].Area3DStyle.Enable3D = false;
                chart.Series[0].Color = Color.Blue;
                chart.ChartAreas[0].AxisX.Title = "Respuestas";
                chart.ChartAreas[0].AxisY.Title = "Cantidad";
                // Cambia el tipo de grafico
                chart.Series[0].ChartType = SeriesChartType.Column;
                // Set series members names for the X and Y values
                chart.Series[0].XValueMember = "respuesta";
                chart.Series[0].YValueMembers = "contador";

                // Data bind to the selected data source
                chart.DataBind();
                Panel1.Controls.Add(chart);
            }
            DataSet dsE2 = Libreria.consulta("select preguntaencuestas.pregunta, respuestasabiertasencuestas.respuesta from preguntaencuestas, respuestasabiertasencuestas where preguntaencuestas.numero = respuestasabiertasencuestas.pregunta and respuestasabiertasencuestas.encuesta = " + DropDownList1.SelectedValue + "AND  preguntaencuestas.id_encuesta=" + DropDownList1.SelectedValue + " order by preguntaencuestas.pregunta asc");

            GridView1.DataSource = dsE2;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultar();
        }
    }
}