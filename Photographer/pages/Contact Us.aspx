<%@ Page Title="" Language="VB" MasterPageFile="~/Master Page/MasterPage.master" AutoEventWireup="false" CodeFile="Contact Us.aspx.vb" Inherits="pages_Contact_Us" %>
<%@ Register Src="~/control/ContactForm.ascx" TagPrefix="uc1" TagName="ContactForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
  <uc1:ContactForm ID="ContactForm" runat="server" />
  </asp:Content>

