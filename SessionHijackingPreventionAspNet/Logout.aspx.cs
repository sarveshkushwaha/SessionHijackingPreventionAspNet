using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionHijackingPreventionAspNet
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon(); // Session Expire but cookie do exist
            Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddDays(-30); //Delete the cookie
        }
    }
}