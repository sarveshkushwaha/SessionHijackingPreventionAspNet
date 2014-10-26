using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionHijackingPreventionAspNet
{
    public partial class SessionHijacking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["User"].ToString() == "Simpleuser" )
            {
                lblAdmin.Visible = false;
            }
        
            else if (Session["User"].ToString() == "Admin")
                {
                    lblAdmin.Visible = true;
                }
            
            

        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Session["User"] = "Admin";
        }
    }
}