using empleado;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_Academico.admin
{
    public partial class enviar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Configurando el cliente SMTP
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("maildepreubaayudantias@gmail.com", "aceracer123");
            //Enviando correo
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("maildepreubaayudantias@gmail.com");

            DataSet ds = Libreria.consulta("select correo from contactos where grupo_id=" + DropDownList1.SelectedValue);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                mail.To.Add(new MailAddress(ds.Tables[0].Rows[i]["correo"].ToString()));

            }
           
            mail.Subject = TextBox1.Text;
            mail.IsBodyHtml = true;
            mail.Body = TextBox2.Text;
            if (FileUpload1.HasFile)
            {
                String path = Path.Combine(Server.MapPath("~/adjuntos"), FileUpload1.FileName);
                FileUpload1.SaveAs(path);
                mail.Attachments.Add(new Attachment(path));

            }
            client.Send(mail);
                        Response.Redirect("/admin/enviado.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);

        }
    }
}