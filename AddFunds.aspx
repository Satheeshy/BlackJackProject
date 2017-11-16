<%@ Page Title="" Theme="Theme2"Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddFunds.aspx.cs" Inherits="AddFunds" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="AddFunds">
         Available Funds :<asp:Label ID="AvailableFunds" runat="server" Text=""></asp:Label>
    Enter Amount to be Added:<asp:TextBox ID="AddFundsofUser" runat="server"></asp:TextBox>
    <asp:Button ID="AddFundButton" runat="server" Text="AddFundButton" OnClick="AddFundButton_Click" /><br />
    <asp:Label ID="AddFundErrorMsg" runat="server" Text=""></asp:Label>
    </div>
   
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>

