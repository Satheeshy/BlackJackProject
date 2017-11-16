<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdminPage.ascx.cs" Inherits="UserControls_Admin_Page" %>

Available Funds :<asp:Label ID="AvailableFunds" runat="server" Text="Label"></asp:Label>
Games Wons: <asp:Label ID="GamesWon" runat="server" Text=""></asp:Label><br />
Games Lost: <asp:Label ID="GamesLost" runat="server" Text=""></asp:Label><br />
Games Push :<asp:Label ID="GamePush" runat="server" Text=""></asp:Label><br />
<asp:GridView ID="GridView1" runat="server"></asp:GridView>
<asp:Button ID="Setbet" runat="server" Text="SetBet" OnClick="Setbet_Click" />