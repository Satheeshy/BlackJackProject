using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddFunds : System.Web.UI.Page
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
                AvailableFunds.Text = (x.Funds).ToString();
            }
        }
       
    }
    protected void AddFundButton_Click(object sender, EventArgs e)
    {
        int funds = Convert.ToInt32(AddFundsofUser.Text);
        var username = Session["LoginName"] as string;
        
        using(BlackJackOnlineEntities2 context = new BlackJackOnlineEntities2())
        {
            var TableFunds = from u in context.Users
                             where u.UserName == username
                             select u;

            User x = context.Users.FirstOrDefault(u => u.UserName == username);
            AvailableFunds.Text = x.ToString();
            if (x != null)
            {
                x.Funds += funds;
                context.SaveChanges();
            }
            using (BlackJackOnlineEntities2 db = new BlackJackOnlineEntities2())
            {
                var updatedFunds = from y in context.Users
                                   where y.UserName == username
                                   select y.Funds;

                AvailableFunds.Text = (updatedFunds.FirstOrDefault()).ToString();
            }
            AddFundsofUser.Text = "";

            BetTable bets = context.BetTables.FirstOrDefault();

        } Response.Redirect("~/Bet.aspx");
        
            
    }
             
}