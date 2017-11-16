<%@ Page Title="" Theme="Theme2"Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserProfile.aspx.cs" Inherits="UserProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="UserProfile">
        
        <a href="PlayGame.aspx">PlayGame.aspx</a><br />

        <asp:Label ID="Label1" runat="server" Text="Available Funds:" ></asp:Label>
        
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
        <a href="ChangePassword.aspx" ><b>ChangePassword.aspx</b></a><br />
        <asp:Button ID="AddFunds" runat="server" Text="AddFunds" OnClick="AddFunds_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    <div>
        
        
    </div>
</asp:Content>

