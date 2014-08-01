using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Diet_and_Exercise_Application
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();
            UserManager<IdentityUser> userManager = new UserManager<IdentityUser>(userStore);
            IdentityUser identityUser = userManager.FindByName(User.Identity.Name);

            username.InnerText = identityUser.UserName;
            textboxEmail.Attributes.Add("placeholder", "Email Address (" + identityUser.Email + ")");
        }

        protected void buttonSave_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();
            UserManager<IdentityUser> userManager = new UserManager<IdentityUser>(userStore);
            IdentityUser identityUser = userManager.FindByName(User.Identity.Name);

            if (!String.IsNullOrWhiteSpace(textboxPasswordNew.Text))
            {
                IdentityResult irChangePassword = userManager.ChangePassword(identityUser.Id, textboxPassword.Text, textboxPasswordNew.Text);
                Label lChangePasswordResult = new Label();
                lChangePasswordResult.CssClass = "alert";
                if (irChangePassword.Succeeded)
                {
                    lChangePasswordResult.CssClass += " alert-success";
                    lChangePasswordResult.Text = "Password changed successfully!";
                }
                else
                {
                    lChangePasswordResult.CssClass += " alert-danger";
                    lChangePasswordResult.Text = irChangePassword.Errors.FirstOrDefault();
                }
                status.Controls.Add(lChangePasswordResult);
            }

            if (!String.IsNullOrWhiteSpace(textboxEmail.Text))
            {
                IdentityResult irChangeEmail = userManager.SetEmail(identityUser.Id, textboxEmail.Text);
                Label lChangeEmailResult = new Label();
                lChangeEmailResult.CssClass = "alert";
                if (irChangeEmail.Succeeded)
                {
                    lChangeEmailResult.CssClass += " alert-success";
                    lChangeEmailResult.Text = "Email changed successfully!";
                    textboxEmail.Attributes.Add("placeholder", "Email Address (" + identityUser.Email + ")");
                }
                else
                {
                    lChangeEmailResult.CssClass += " alert-danger";
                    lChangeEmailResult.Text = irChangeEmail.Errors.FirstOrDefault();
                }
                status.Controls.Add(lChangeEmailResult);
            }
        }
    }
}
