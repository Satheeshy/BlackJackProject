using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    public string value
    {
        get
        {
            return UsernameText.Text;

        }
        set
        {
            UsernameText.Text = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && !string.IsNullOrEmpty(value))
        {
            UsernameText.Visible = true;
            PasswordText.Visible = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string loginid = UsernameText.Text;
        string loginpwd = PasswordText.Text;
        using (var context = new BlackJackOnlineEntities2())
        {
            var loginvalidation = from val in context.Users
                                  where val.UserName == loginid && val.Password == loginpwd
                                  select val;

            bool exists = false;
            exists = loginvalidation.Any();

            if (exists)
            {
                Session["LoginName"] = loginid;

                if (loginid == "Dealer")
                {
                    Response.Redirect("~/AdminPage.aspx");
                }
                else
                {
                    Response.Redirect("~/UserProfile.aspx");
                }
            }
            else
            {
                var usernamevalidation = from v in context.Users
                                         where v.UserName == loginid
                                         select v;
                if (usernamevalidation.FirstOrDefault() == null)
                {
                    ErrorMessage.Text = "Enter a Valid Username and Password";
                }
                else
                {
                    ErrorMessage.Text = "Enter a valid password for the " + loginid;
                }


            }

        }



    }
    
}