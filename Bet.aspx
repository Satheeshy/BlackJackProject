<%@ Page Theme="Theme2" Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Bet.aspx.cs" Inherits="Bet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="Bet">
        Place Bet:<asp:TextBox ID="BetVal" runat="server"></asp:TextBox>
        <asp:Button ID="PlaceBet" runat="server" OnClick="PlaceBet_Click" Text="PlaceBet" />
        <asp:Label ID="BetErrorMEssage" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>


