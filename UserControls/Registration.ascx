<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Registration.ascx.cs" Inherits="UserControls_Registration" %>
Login Name :<asp:TextBox ID="LoginName" runat="server" Text="Enter a Username "></asp:TextBox><br />
Password :<asp:TextBox ID="LoginPassword" runat="server" Text="Enter a Password "></asp:TextBox><br />
Confirm Password :<asp:TextBox ID="ConfirmPassword" runat="server" Text="Confirm Password"></asp:TextBox><br />
<asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
<asp:TextBox ID="Label1" runat="server"></asp:TextBox>