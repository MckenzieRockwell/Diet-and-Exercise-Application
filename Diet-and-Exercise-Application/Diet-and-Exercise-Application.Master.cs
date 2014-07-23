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
            literalPageHeading.Text = Page.Title;

            if (!IsPostBack)
            {
                if (Page.User.Identity.IsAuthenticated)
                {
                    panelIsGuest.Visible = false;
                }
                else
                {
                    panelIsUser.Visible = false;
                }
            }
        }

        protected void linkbuttonLogout_Click(object sender, EventArgs e)
        {
            IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("Login.aspx");
        }
    }
}
