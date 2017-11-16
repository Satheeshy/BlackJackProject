using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void PlaceBet_Click(object sender, EventArgs e)
    {
        int BetValue = Convert.ToInt32(BetVal.Text);
        using(var context = new BlackJackOnlineEntities2())
        {
            BetTable bets = context.BetTables.FirstOrDefault();
            User funds = context.Users.FirstOrDefault();
            if(BetValue <=funds.Funds)
            {
                if (BetValue >= bets.MinBet && BetValue <= bets.MaxBet)
                {
                    Response.Redirect("~/PlayGame.aspx");
                }
                else if (BetValue < bets.MinBet)
                {
                    BetErrorMEssage.Text = "Place bet greater more the $" + bets.MinBet;

                }
                else
                {
                    BetErrorMEssage.Text = "Place bet below $" + bets.MaxBet;
                }
            }
            else
            {
            
               
                Response.Redirect("~/AddFunds.aspx");
            }

        }
    }
}