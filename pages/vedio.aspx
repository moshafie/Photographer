<%@ Page Title="" Language="VB" MasterPageFile="~/Master Page/MasterPage.master" AutoEventWireup="false" CodeFile="vedio.aspx.vb" Inherits="pages_vedio" %>

<%@ Register Assembly="ASPNetVideo.NET3" Namespace="ASPNetVideo" TagPrefix="ASPNetVideo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    <ASPNetVideo:WindowsMedia BackColor="Pink"  BaseURL="~/vedio/اخرج من الببان.MP3" ID="WindowsMedia1" runat="server">
    </ASPNetVideo:WindowsMedia >
</asp:Content>


