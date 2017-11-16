<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.ascx.cs" Inherits="UserControls_ChangePassword" %>
Current Password:<asp:TextBox ID="OldPassword" runat="server"></asp:TextBox><br />
New Password:<asp:TextBox ID="NewPassword1" runat="server"></asp:TextBox><br />
Confirm Password:<asp:TextBox ID="NewPassword2" runat="server"></asp:TextBox><br />
<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
<asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>