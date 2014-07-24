using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Owin.Host.SystemWeb;

namespace Diet_and_Exercise_Application
{
    public partial class Diet_and_Exercise_Application : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Set main heading to page title
            literalPageHeading.Text = Page.Title;

            if (!IsPostBack)
            {
                // Show different navigation options based on login status
                if (Page.User.Identity.IsAuthenticated)
                {
                    panelGuest.Visible = false;
                }
                else
                {
                    panelUser.Visible = false;
                }
            }
        }

        protected void linkbuttonLogout_Click(object sender, EventArgs e)
        {
            // Sign the user out and redirect to login page
            IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("/Guest/Login.aspx");
        }
    }
}
