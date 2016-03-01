using empleado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
          
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/registrarse.aspx");
        }
        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session["usuario"] = "";
            Session["nombre"] = "";
            Response.Redirect(Request.RawUrl);

        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            DataSet ds = Libreria.consulta("select usuario, nombre, apellido from usuarios where usuario='"+ txtusuario.Text+"' and password='"+ sha256(txtpassword.Text) +"' and estado ='A'");
            //se valida si existe usuario
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["usuario"] = ds.Tables[0].Rows[0]["usuario"].ToString();
                Session["nombre"] = ds.Tables[0].Rows[0]["nombre"].ToString() + " " + ds.Tables[0].Rows[0]["apellido"].ToString();
                Response.Redirect(Request.RawUrl);

            }
            else
            {
                lblerror.Text = "Error al ingresar <a href=\"/recuperar.aspx?usuario="+txtusuario.Text+"\">Recuperar clave</a>";
                lblerror.Visible = true;
            }
          
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //si no es admin no deja ingresar
           /*
            if (Convert.ToString(Session["usuario"]) != "admin"  )
            {
                Response.Redirect("/");

            
            }
            * */
            //se muestra el bienvenido
            ingresado.Visible = true;
            logear.Visible = false;

            lblUsuario.Text = (String)Session["nombre"];
     
        }
        //Sirve para encriptar
        static string sha256(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}