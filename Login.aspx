<%@ Page Title="" Theme="Theme2"  EnableTheming="true" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<%@ Register src="UserControls/Login.ascx" tagname="Login" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="LoginPagediv" >
        <asp:Label ID="Label1" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox ID="UsernameText" runat="server" Text=""></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text=" Password:"></asp:Label>
        <asp:TextBox ID="PasswordText" runat="server" Text="" ></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" style="height: 26px" />

<asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>
</div>
    <%--<uc1:Login ID="Login1" runat="server" /> --%>
    
    
</asp:Content>

