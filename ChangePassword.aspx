﻿<%@ Page Title="" Theme="Theme2"Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<%@ Register src="UserControls/ChangePassword.ascx" tagname="ChangePassword" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="Changepwd">
        <uc1:ChangePassword ID="ChangePassword1" runat="server" />
    </div>
    
</asp:Content>

