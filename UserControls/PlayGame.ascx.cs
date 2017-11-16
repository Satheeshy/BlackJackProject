using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_PlayGame : System.Web.UI.UserControl
{
    List<int> Deck = new List<int>();
    List<int> usercards = new List<int>();
    List<int> Dealercards = new List<int>();
    int GlobalRandom = 0;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DeckCreation();
        }
    }

    protected void Play_Click(object sender, EventArgs e)
    {
        
        
        HdnInitialize();
        WinORLose.Text = "";
        Hit.Visible = true;
        Stand.Visible = true;
        
            GlobalRandom = RandomNumber();
            usercards.Add(GlobalRandom);
            GlobalRandom = RandomNumber();
            usercards.Add(GlobalRandom);
            GlobalRandom = RandomNumber();
            Dealercards.Add(GlobalRandom);        
            GlobalRandom = RandomNumber();
            Dealercards.Add(GlobalRandom);
        
        Session["SessionUserCards"] = usercards;
        Session["SessionDealerCards"] = Dealercards;
        


            if(usercards.Count ==2 && (usercards[0]).ToString()!="")
            {
                PlayerImage1.ImageUrl = "~/Cards/" + displayCard(usercards[0]) + ".png";
                PlayerImage2.ImageUrl = "~/Cards/" + displayCard(usercards[1]) + ".png";
            }
            if (Dealercards.Count == 2 && (usercards[0]).ToString() != "")
            {
                DealerImage1.ImageUrl = "~/Cards/" + displayCard(Dealercards[0]) + ".png";
                DealerImage2.ImageUrl = "~/Cards/" + displayCard(Dealercards[1]) + ".png";
            }
        int BlackJackofDealer = CalculateBlackJack(Dealercards);
        int BlackJackofUser = CalculateBlackJack(usercards);
        
        hdnUserpoints.Value = BlackJackofUser.ToString();
        hdnDealerpoints.Value = BlackJackofDealer.ToString();
        if(BlackJackofDealer <=21 && BlackJackofDealer<=21)
        {
            if (BlackJackofDealer == 21 && BlackJackofUser == 21)
            {
                WinORLose.Text = "Game Tie,Click the Play Button to replay";
                Session["Winner"] = "None";
                FewInitializes();

            }
            else if (BlackJackofUser == 21 && BlackJackofUser > BlackJackofDealer)
            {
                WinORLose.Text = "User Won the Game,Click the Play Button to replay";
                Session["Winner"] = "User";
                FewInitializes();

            }
            else if (BlackJackofDealer == 21 && BlackJackofDealer > BlackJackofUser)
            {
                WinORLose.Text = "Dealer Won the Game,Click the Play Button to replay";
                Session["Winner"] = "Dealer";
                FewInitializes();
                
            }
            else
            {
                UserPoints.Text = BlackJackofUser.ToString();
                DealerPoints.Text = BlackJackofDealer.ToString();
                Play.Visible = false;
            }
        }else
        {
            if(BlackJackofDealer >21)
            {
                WinORLose.Text = "User Won the Game,Dealer is Busted";
                Session["Winner"] = "User";
            }
            else            
            {
                WinORLose.Text = "Dealer Won the Game, User is Busted";
                Session["Winner"] = "Dealer";
            }
        }
       
        
    }
    private List<int> DeckCreation()
    {
        List<int> DeckCreation = new List<int>();
        for (int d = 1; d <= 52; d++)
        {
            Deck.Add(d);
        }
        Hit.Visible = false;
        Stand.Visible = false;
        Session["SessionDeck"] = Deck;
        hdnDeck.Value = string.Join(",", Deck);
        return DeckCreation;
    }
    
    public void Hit_Click(object sender, EventArgs e)
    {

        int hitpoints = 0;
        int dealerpoints = 0;
        int hitcount = 0;
        if(hdnUserHitCount.Value =="")
        {
            hitcount = 0;
        }else
        {
            hitcount = Convert.ToInt32(hdnUserHitCount.Value);
        }

         
        hitcount += 1;
        hdnUserHitCount.Value = (hitcount).ToString();
        GlobalRandom = RandomNumber();
        usercards = (List<int>)Session["SessionUserCards"];
        usercards.Add(GlobalRandom);
        Session["SessionUserCards"] = usercards;

        hitpoints = CalculateBlackJack(usercards);
        Session["UserPoints"] = hitpoints;
        dealerpoints = Convert.ToInt32(hdnDealerpoints.Value);

        if (hitcount == 1)
        {
            
            PlayerImage3.ImageUrl = "~/Cards/" + displayCard(usercards[2]) + ".png";
        }
        if (hitcount == 2)
        {
            
            PlayerImage4.ImageUrl = "~/Cards/" + displayCard(usercards[3]) + ".png";
        }
        if (hitcount == 3)
        {
            
            PlayerImage5.ImageUrl = "~/Cards/" + displayCard(usercards[4]) + ".png";

        }
        if (hitcount == 4)
        {
            
            PlayerImage6.ImageUrl = "~/Cards/" + displayCard(usercards[5]) + ".png";
        }
        if (hitcount == 5)
        {
            
            PlayerImage7.ImageUrl = "~/Cards/" + displayCard(usercards[6]) + ".png";
        }
        if (hitcount == 6)
        {
            
            PlayerImage8.ImageUrl = "~/Cards/" + displayCard(usercards[7]) + ".png";

        }
        if (hitcount == 7)
        {
            
            PlayerImage9.ImageUrl = "~/Cards/" + displayCard(usercards[8]) + ".png";

        }
        if (hitpoints > 21 && dealerpoints <=21)
        {
            WinORLose.Text = "User is Busted and Dealer won the Game,Click the Play Button to replay";
            UserPoints.Text = hitpoints.ToString();
            hdnUserpoints.Value = hitpoints.ToString();
            Session["Winner"] = "Dealer";
            FewInitializes();           
            
        }
        else if (hitpoints == 21 && hitpoints > dealerpoints)
        {
            WinORLose.Text = "User won the Game,Click the Play Button to replay";
            Session["Winner"] = "User";
            UserPoints.Text = hitpoints.ToString();
            FewInitializes();          

           
        }else
        {
            UserPoints.Text = hitpoints.ToString();
            hdnUserpoints.Value = hitpoints.ToString();

        }
        
    }

    public void Stand_Click(object sender, EventArgs e)
    {
        int DealerHit = 0;
        if(hdneDealerHitCount.Value!="")
        {
            DealerHit = Convert.ToInt32(hdneDealerHitCount.Value);
        }
        else
        {
            DealerHit = 0;
        }
        
        int dealerstandtimepoints = Convert.ToInt32(hdnDealerpoints.Value);
        int userstandtimepoints = Convert.ToInt32(hdnUserpoints.Value);
        
        if (dealerstandtimepoints < 17)
        {
            
            for (int i = 0; dealerstandtimepoints < 17; i++)
            {
                GlobalRandom = RandomNumber();
                Dealercards = (List<int>)Session["SessionDealerCards"];
                Dealercards.Add(GlobalRandom);
                Session["SessionDealerCards"] = Dealercards;
                
                dealerstandtimepoints = CalculateBlackJack(Dealercards);
                DealerHit += 1;                               
                hdneDealerHitCount.Value = (DealerHit).ToString();
                
                if (DealerHit == 1 && Dealercards.Count>2)
                {
                    
                    DealerImage3.ImageUrl = "~/Cards/" + displayCard(Dealercards[2]) + ".png";
                }
                if (DealerHit == 2)
                {
                    
                    DealerImage4.ImageUrl = "~/Cards/" + displayCard(Dealercards[3]) + ".png";
                }
                if (DealerHit == 3)
                {
                    
                    DealerImage5.ImageUrl = "~/Cards/" + displayCard(Dealercards[4]) + ".png";

                }
                if (DealerHit == 4)
                {
                    
                    DealerImage6.ImageUrl = "~/Cards/" + displayCard(Dealercards[5]) + ".png";
                }
                if (DealerHit == 5)
                {
                    
                    DealerImage7.ImageUrl = "~/Cards/" + displayCard(Dealercards[6]) + ".png";
                }
                if (DealerHit == 6)
                {
                    
                    DealerImage8.ImageUrl = "~/Cards/" + displayCard(Dealercards[7]) + ".png";

                }
                if (DealerHit == 7)
                {
                    
                    DealerImage8.ImageUrl = "~/Cards/" + displayCard(Dealercards[8]) + ".png";

                }
            } 
            DealerPoints.Text = dealerstandtimepoints.ToString();
         

        }

       
        if(dealerstandtimepoints<=21)
        {
            if (dealerstandtimepoints == userstandtimepoints)
            {
                WinORLose.Text = "Game is Tie,Click the Play Button to replay";
                Session["Winner"] = "None";
                FewInitializes();

            }
            else if (dealerstandtimepoints > userstandtimepoints)
            {
                WinORLose.Text = "Dealer Won the Game ,Click the Play Button to replay";
                Session["Winner"] = "Dealer";
                FewInitializes();

            }
            else if (userstandtimepoints > dealerstandtimepoints)
            {
                WinORLose.Text = "User Won the Game,Click the Play Button to replay";
                Session["Winner"] = "User";
                FewInitializes();

            }
        }else
        {
            WinORLose.Text = "user won the Game,Click the Play Button to reaplay ";
            Session["Winner"] = "User";
            FewInitializes();
        }
    }

    public int RandomNumber()
    {
        int index = 0;
        int RandomNum = 0;
        Random rand = new Random();
        List<int> Decks = new List<int>();
        Decks = (List<int>)Session["SessionDeck"];
        index = rand.Next(1, Decks.Count+1);
        RandomNum = Decks.ElementAt(index - 1);
        Decks.RemoveAt(index - 1);
        Session["SessionDeck"] = Decks;
        return RandomNum;

    }

    public int getcardnumber(int cardnum)
    {

        if (cardnum % 13 == 0)
        {
            return 13;
        }
        else
        {
            return (cardnum % 13);
        }
    }

    public int CalculateBlackJack(List<int> x)
    {
        List<int> xlist = new List<int>();
        int points = 0;
        foreach (var u in x)
        {
            xlist.Add(getcardnumber(u));
        }
        int cardnum0 = xlist[0];
        int cardnum1 = xlist[1];
        if (xlist.Count == 2 && (cardnum0 == 1 && cardnum1 > 10 || cardnum0 > 10 && cardnum1 == 1))
        {   
                points = 21;
                return points;
        }
        else
        {
            foreach(var number in xlist)
            {
                if (number <= 10)
                {
                    points  += number;
                }
                
                    
                if (number > 10)
                {
                    points = points + 10;
                }  
            }
            if (points < 11)
            {
                foreach (var ace in xlist)
                {
                    if (ace == 1)
                    {
                        points += 10;
                    }
                }
            }
                
         }return points;
     } 
    
   
    private int getCardSuit( int a) 
    {
        if (a >= 1 && a <= 13)
        {
            return 0;
        }
        else if (a >= 14 && a <= 26)
        {
            return 1;
        }
        else if (a >= 27 && a <= 39) 
        {
            return 2;
        }
        else return 3;
    }
    private string displayCard(int a) 
    {
        var cardNumber = getcardnumber(a);
        var cardFace = getCardSuit(a);
        var faceName = "";
        if (cardFace == 0) 
        {
            faceName = "diamonds";
        }
        else if (cardFace == 1) 
        {
            faceName = "clubs";
        }
        else if (cardFace == 2) 
        {
            faceName = "hearts";
        }
        else
            faceName = "spades";

        if (cardNumber == 1) 
        {
            return "ace"+"_of_" + faceName;
        }

        else if (cardNumber == 11) 
        {
            return "jack"+"_of_"+ faceName;
        }
        else if (cardNumber == 12)
        {
            return "queen"+"_of_" + faceName;
        }
        else if (cardNumber == 13) 
        {
            return "king"+"_of_"+ faceName;
        }

        else return cardNumber + "_of_" + faceName;
    }

    private void HdnInitialize()
    {
        Hit.Visible = false;
        Stand.Visible = false;
        DealerPoints.Text = "";
        hdnDealerpoints.Value = "";
        hdnUserHitCount.Value = "";
        hdneDealerHitCount.Value = "";
        hdnHitpoints.Value = "";
        DeckCreation();
        DealerImage1.ImageUrl = "";
        DealerImage2.ImageUrl = "";
        DealerImage3.ImageUrl = "";
        DealerImage4.ImageUrl = "";
        DealerImage5.ImageUrl = "";
        DealerImage6.ImageUrl = "";
        DealerImage7.ImageUrl = "";
        DealerImage8.ImageUrl = "";
        DealerImage9.ImageUrl = "";
        PlayerImage1.ImageUrl = "";
        PlayerImage2.ImageUrl = "";
        PlayerImage3.ImageUrl = "";
        PlayerImage4.ImageUrl = "";
        PlayerImage5.ImageUrl = "";
        PlayerImage6.ImageUrl = "";
        PlayerImage7.ImageUrl = "";
        PlayerImage8.ImageUrl = "";
        PlayerImage9.ImageUrl = "";
        Play.Visible = true;
    }
    private void FewInitializes()
    {
        Hit.Visible = false;
        Stand.Visible = false;
        Play.Visible = true;
    }
   // private void UpdateDatebase(list<int> y)
    //{
    //    var username = Session["LoginName"] as string;
    //    using(var context =  new BlackJackOnlineEntities2())
    //    {
    //        User x = context.Users.FirstOrDefault(u=> u.UserName ==username);
    //        x.Funds = Convert.ToInt32(Session["Prize"]);
    //        x.Points = Convert.ToInt32(Session["UserPoints"]);
    //        context.SaveChanges();
    //        User Deal = context.Users.FirstOrDefault(m => m.UserName == "Dealer");
    //        Deal.Points = Convert.ToInt32(Session["DealerPoints"]);
    //        Record addwins = context.Records.FirstOrDefault(s=>s.UserId == x.UserId);
    //        if(Session["Dealer"] == "Dealer")
    //        {
    //            addwins.Wins +=1;
    //        }else if(Session[""])
    //        {

    //        }
    //        Deal.Points = Convert.ToInt32(Session[]);
    //    }

            
            
        
    //}
}