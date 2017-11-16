<%@ Page Title="" Theme="Theme2"Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="SetBet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="AdminPage">
    Minimun Bet :<asp:TextBox ID="MinBet" runat="server"></asp:TextBox>
    Maximum Bet :<asp:TextBox ID="MaxBet" runat="server"></asp:TextBox>
    <asp:Button ID="AddBet" runat="server" Text="AddBet" OnClick="AddBet_Click" /><br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Label ID="ErrorMsg" runat="server" Text=""></asp:Label>
    </div>
   
    <div id="AdminPageCp">
        <a href="ChangePassword.aspx"><b>ChangePassword.aspx</b></a>
    </div>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>

