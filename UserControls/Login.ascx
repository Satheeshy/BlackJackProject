<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="UserControls_Login" %>
<div id="LoginPagediv">
         <asp:Label ID="Label1" runat="server" Text="User Name :"></asp:Label>
        <asp:TextBox ID="UsernameText" runat="server" Text="Enter Username"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
<asp:TextBox ID="PasswordText" runat="server" Text="Enter Password"></asp:TextBox><br />
<asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" style="height: 26px" />

<asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>
</div>
