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
    public partial class encuesta : System.Web.UI.Page
    {
        int encuesta1;
        int cantidad;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = Libreria.consulta("Select * from encuestas where estado ='A' order by id DESC");
            Label1.Text = ds.Tables[0].Rows[0]["titulo"].ToString();
            encuesta1 = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            cantidad = Convert.ToInt32(ds.Tables[0].Rows[0]["preguntas"].ToString());
            DataSet ds2 = Libreria.consulta("Select * from preguntaencuestas where id_encuesta="+ encuesta1 + " order by numero ASC ");

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                Label l = new Label();
                int pregunta = Convert.ToInt32(ds2.Tables[0].Rows[i]["numero"].ToString());
                l.Text ="<br>"+ ds2.Tables[0].Rows[i]["pregunta"].ToString() +"<br>";
                
                Panel p = new Panel();
                p.ID = "p"+(i);
                p.Controls.Add(l);
                if (ds2.Tables[0].Rows[i]["tipo"].ToString() == "A")
                {
                    TextBox t = new TextBox();
                    p.Controls.Add(t);
                }
                else
                {
                    DataSet ds3 = Libreria.consulta("Select * from respuestaencuestas where pregunta=" + pregunta + " and encuesta=" + encuesta1 + " order by id ASC ");

                    RadioButtonList d = new RadioButtonList();
                    for (int j = 0; j < ds3.Tables[0].Rows.Count; j++)
                    {
                        d.Items.Add(new ListItem(ds3.Tables[0].Rows[j]["respuesta"].ToString(), ds3.Tables[0].Rows[j]["id"].ToString()));
                        p.Controls.Add(d);

                    }

                }
                Panel1.Controls.Add(p);
            }
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < cantidad; i++)
            {
                Panel panel=null;
                foreach (Control p in Panel1.Controls)
                {
                    if (p is Panel)
                    {
                        Panel panel1 = p as Panel;
                        if (panel1.ID == "p" + i) { 
                            panel = panel1;
                        String pregunta;
                        String respuesta = "";
                        int respuesta2 = 0;
                        foreach (Control p1 in panel.Controls)
                        {
                            if (p1 is Label)
                            {
                                Label l = p1 as Label;
                                pregunta = l.Text;
                            }
                        }
                        foreach (Control p1 in panel.Controls)
                        {
                            if (p1 is TextBox)
                            {
                                TextBox t = p1 as TextBox;
                                respuesta = t.Text;
                                Libreria.ejecuta("INSERT INTO respuestasabiertasencuestas(encuesta, pregunta, respuesta) values(" + encuesta1 + "," + (i + 1) + ",'" + respuesta + "')");

                            }
                        }
                        foreach (Control p1 in panel.Controls)
                        {
                            if (p1 is RadioButtonList)
                            {
                                RadioButtonList r = p1 as RadioButtonList;
                                respuesta2 = Convert.ToInt32(r.SelectedValue);
                                Libreria.ejecuta("UPDATE respuestaencuestas SET contador+=1 WHERE id=" + respuesta2);

                            }
                        }
                    }
                    }
                }
           
            
            }
            Response.Redirect("/finencuesta.aspx");

        }
    }
}