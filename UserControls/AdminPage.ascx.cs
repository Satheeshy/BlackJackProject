using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_Admin_Page : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //using(BlackJackOnlineEntities2 context = new BlackJackOnlineEntities2)
        //{
        //    var gamesResults = from u in context.Users
        //                       where u.UserName == Session["LoginName"]
        //                       select u.UserId;
            
        //    var queryoutput = gamesResults.FirstOrDefault();
        //    var gamerecords =  from x in context.Records
        //                       where x.UserId == queryoutput
        //                       select x;
        //    var gameres = gamerecords.ToList();
        //    GridView1.DataSource = gameres;
        //    GridView1.DataBind();

            

        }
    }
   
    protected void Setbet_Click(object sender, EventArgs e)
    {

    }
}