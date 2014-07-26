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
            if (textboxPassword.Text != textboxPasswordConfirm.Text)
            {
                literalStatusMessage.Text = "Password confirmation did not match password. ";
                return;
            }

            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();
            UserManager<IdentityUser> userManager = new UserManager<IdentityUser>(userStore);
            IdentityUser identityUser = new IdentityUser()
            {
                UserName = textboxUsername.Text
            };
            IdentityResult identityResult = userManager.Create(identityUser, textboxPassword.Text);

            if (identityResult.Succeeded)
            {
                IAuthenticationManager iAuthenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                ClaimsIdentity claimsIdentity = userManager.CreateIdentity(identityUser, DefaultAuthenticationTypes.ApplicationCookie);

                iAuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, claimsIdentity);
                Response.Redirect("Home.aspx");
            }
            else
            {
                literalStatusMessage.Text = identityResult.Errors.FirstOrDefault();
            }
        }
    }
}