using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (!IsPostBack)
        {
            var username = Session["LoginName"] as string;
            if (username == null)
            {
                Response.Redirect("~/Login.aspx");
                Response.Redirect("~/ChangePassword.aspx");
                return;
            }
            using (BlackJackOnlineEntities2 context = new BlackJackOnlineEntities2())
            {
                User x = context.Users.FirstOrDefault(u => u.UserName == username);
                Label2.Text = "$"+((x.Funds).ToString());
                var records = (from m in context.Records
                              where m.UserId == x.UserId
                              select m).ToList();


                if(records.Count !=0)
                {
                    GridView1.DataSource = records;
                    GridView1.DataBind();
                }
                
            }

        }
    }
    protected void AddFunds_Click(object sender,EventArgs e)
    {
        Response.Redirect("~/AddFunds.aspx");
    }
}