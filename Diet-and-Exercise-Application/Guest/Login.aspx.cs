using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Owin.Host.SystemWeb;

namespace Diet_and_Exercise_Application
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    // User is logged in
                }
            }
        }

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();
            UserManager<IdentityUser> userManager = new UserManager<IdentityUser>(userStore);
            IdentityUser identityUser = userManager.Find(textboxUsername.Text, textboxPassword.Text);

            // If the user is found
            if (identityUser != null)
            {
                IAuthenticationManager iAuthenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                ClaimsIdentity claimsIdentity = userManager.CreateIdentity(identityUser, DefaultAuthenticationTypes.ApplicationCookie);

                // Log the user in
                iAuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, claimsIdentity);
                Response.Redirect("/User/Home.aspx");
            }
            else
            {
                labelDanger.Text = "Username or password incorrect. ";
                labelDanger.Visible = true;
            }
        }
    }
}
