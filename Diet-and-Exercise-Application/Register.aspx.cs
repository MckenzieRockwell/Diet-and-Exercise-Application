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

namespace Diet_and_Exercise_Application
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonRegister_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> store = new UserStore<IdentityUser>();
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(store);
            IdentityUser user = new IdentityUser()
            {
                UserName = textboxUsername.Text
            };
            IdentityResult result = manager.Create(user, textboxPassword.Text);

            if (result.Succeeded)
            {
                IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                ClaimsIdentity userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                Response.Redirect("Home.aspx");
            }
            else
            {
                literalStatusMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}