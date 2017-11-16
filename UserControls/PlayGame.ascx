<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PlayGame.ascx.cs" Inherits="UserControls_PlayGame" %>
<div id="UserCardsValues">
      Points:<asp:Label ID="UserPoints" runat="server" Text=""></asp:Label><br />
</div>
<div id="DealerCardValues">
    DealerPoints:<asp:Label ID="DealerPoints" runat="server" Text=""></asp:Label><br />
</div>
<%--BetAmount:<asp:TextBox ID="BetAmount" runat="server"></asp:TextBox>--%>
<div>
    <asp:Button ID="AddBet" runat="server" Text="AddBet"  /><br />
    <asp:Label ID="BetErrorMSg" runat="server" Text=""></asp:Label><br />
    <asp:Button ID="Play" runat="server" Text="Play" OnClick="Play_Click" /><br />
    <asp:Button ID="Hit" runat="server" Text="Hit" OnClick="Hit_Click" /><br />
    <asp:Button ID="Stand" runat="server" Text="Stand" OnClick="Stand_Click" /><br />
    <asp:Label ID="WinORLose" runat="server" Text=""></asp:Label>
</div>
<div id="HiddenValues">
     <asp:HiddenField runat="server" ID="hdnUserCards" Value="0"/>
    <asp:HiddenField runat="server" ID="hdnDeck" Value="0"/>
    <asp:HiddenField runat="server" ID="hdnDealerCards" Value="0"/>
    <asp:HiddenField runat="server" ID="hdnDealerpoints" Value="0"/>
    <asp:HiddenField runat="server" ID="hdnUserpoints" Value="0"/>
    <asp:HiddenField runat="server" ID="hdnUserHitCount" Value="0"/>
    <asp:HiddenField runat="server" ID="hdneDealerHitCount" Value="0"/>
    <asp:HiddenField runat="server" ID="hdnHitpoints" Value="0"/>
</div>
<div id="PlayerImages">
Player Images:
        <asp:Image ID="PlayerImage1" runat="server" width ="10%" Height="10%"/>
        <asp:Image ID="PlayerImage2" runat="server" width ="10%" Height="10%"/>
        <asp:Image ID="PlayerImage3" runat="server" width ="10%" Height="10%"/>
        <asp:Image ID="PlayerImage4" runat="server" width ="10%" Height="10%"/>
        <asp:Image ID="PlayerImage5" runat="server" width ="10%" Height="10%"/>
        <asp:Image ID="PlayerImage6" runat="server" width ="10%" Height="10%"/>
        <asp:Image ID="PlayerImage7" runat="server" width ="10%" Height="10%"/>
        <asp:Image ID="PlayerImage8" runat="server" width ="10%" Height="10%"/>
        <asp:Image ID="PlayerImage9" runat="server" width ="10%" Height="10%"/>
</div>
<div id="DealerImages">
Dealer Images:
    <asp:Image ID="DealerImage1" runat="server" width ="10%" Height="10%"/>
    <asp:Image ID="DealerImage2" runat="server" width ="10%" Height="10%"/>
    <asp:Image ID="DealerImage3" runat="server" width ="10%" Height="10%"/>
    <asp:Image ID="DealerImage4" runat="server" width ="10%" Height="10%"/>
    <asp:Image ID="DealerImage5" runat="server" width ="10%" Height="10%"/>
    <asp:Image ID="DealerImage6" runat="server" width ="10%" Height="10%"/>
    <asp:Image ID="DealerImage7" runat="server" width ="10%" Height="10%"/>
    <asp:Image ID="DealerImage8" runat="server" width ="10%" Height="10%"/>
    <asp:Image ID="DealerImage9" runat="server" width ="10%" Height="10%"/>

</div>