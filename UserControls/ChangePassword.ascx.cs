using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_ChangePassword : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         var username = Session["LoginName"] as string;
        if(username ==null)
        {
            Response.Redirect("~/Login.aspx");
            Response.Redirect("~/ChangePassword.aspx");
            return;
        }
        string oldpwd = OldPassword.Text;
        string newpwd = NewPassword1.Text;
        string confirmPwd = NewPassword2.Text;
        if(confirmPwd == newpwd)
        {
           
                    using (BlackJackOnlineEntities2 db = new BlackJackOnlineEntities2())
                    {

                        var olduser = from user in db.Users
                                      where user.UserName == username && user.Password == oldpwd
                                      select user;
                       

                        User x = db.Users.FirstOrDefault( user => user.UserName == username);
                        if (x != null)
                        {
                            x.Password = newpwd;
                            db.SaveChanges();
                        }


                        ErrorMessage.Text = "Password Changed Successfully";
                    }

                
            
           
        }
        else
        {
            ErrorMessage.Text = "Password's Doesn't Match";
        }
    }
}


