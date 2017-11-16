<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<%@ Register src="UserControls/Registration.ascx" tagname="Registration" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div id="Registration">
        <uc1:Registration ID="Registration1" runat="server" />
    </div>
    
   
</asp:Content>



