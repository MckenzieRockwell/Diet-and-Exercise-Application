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
            ScriptResourceDefinition srd = new ScriptResourceDefinition();
            srd.Path = "/js/lib/jquery.min.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", null, srd);

            // Set main heading to page title
            literalPageHeading.Text = Page.Title;

            // Show different navigation options based on login status
            if (Page.User.Identity.IsAuthenticated)
            {
                if (Page.Request.Path.Contains("/Guest/"))
                {
                    Response.Redirect("/User/Home.aspx");
                }
                panelGuest.Visible = false;
            }
            else
            {
                if (Page.Request.Path.Contains("/User/"))
                {
                    Response.Redirect("/Guest/Login.aspx");
                }
                panelUser.Visible = false;
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
