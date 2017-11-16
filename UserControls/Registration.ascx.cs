using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_Registration : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string NewUserId = LoginName.Text;
        string NewPassword = LoginPassword.Text;
        string NewConfirmPwd = ConfirmPassword.Text;

        using(var context = new BlackJackOnlineEntities2())
        {
            var newid = from id in context.Users
                        where id.UserName == NewUserId && id.Password == NewPassword
                        select id;
            
            if(newid.FirstOrDefault() != null)
            {
                Label1.Text = "User already exists Try to login with your username and password";
            }
            else if(NewPassword == NewConfirmPwd)
            {
               User user = new User()
               {
                    UserName = NewUserId,
                    Password = NewPassword

               };
                context.Users.Add(user);
                context.SaveChanges();
                Label1.Text = "User Registration Successfull";

            }
            else Label1.Text = "Password Doesn't Match";

            
        }
    }
}