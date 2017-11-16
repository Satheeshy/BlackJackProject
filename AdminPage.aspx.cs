using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SetBet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using(BlackJackOnlineEntities2 data =  new BlackJackOnlineEntities2())
        {
            var dataquery = from u in data.BetTables
                            select u;
            var dataoutput = dataquery.FirstOrDefault();
            if (dataoutput != null)
            {
                var updated = (from u in data.BetTables
                               select u).ToList();
                if (updated.Count != 0)
                {
                    GridView1.DataSource = updated;
                    GridView1.DataBind();
                }
            }
           else
            {
               ErrorMsg.Text = "Bet had not been set yet please set the bet by clicking Addbet Button"
            }
            
        }
    }
    protected void AddBet_Click(object sender, EventArgs e)
    {
        int minbet = Convert.ToInt32(MinBet.Text);
        int maxbet = Convert.ToInt32(MaxBet.Text);
        using (BlackJackOnlineEntities2 context = new BlackJackOnlineEntities2())
        {
           
            using (var db = new BlackJackOnlineEntities2())
            {
             var bet = from u in context.BetTables
                      select u.MaxBet;
             BetTable x = db.BetTables.FirstOrDefault();

                    x.MinBet = minbet;
                    x.MaxBet = maxbet;
                   db.SaveChanges();
                ErrorMsg.Text = "Bet has been Set Successfully";
            }

        }

        
        using(var cont = new BlackJackOnlineEntities2())
        {
            var updated = (from u in cont.BetTables
                          select u).ToList();
            if(updated.Count!=0)
            {
                GridView1.DataSource = updated;
                GridView1.DataBind();
            }
           
            //var updateoutput = updated.FirstOrDefault();
            //CurrMax.Text = updateoutput.MaxBet.ToString();
            //CurrMin.Text = updateoutput.MinBet.ToString();


        }
    }
}