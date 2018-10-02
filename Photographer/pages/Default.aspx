<%@ Page Title="" Language="VB" MasterPageFile="~/Master Page/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="WebSite1_pages_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../Jquery/cycle2-master/jquery.min.js" type="text/javascript"></script>
    <script src="../Jquery/cycle2-master/build/jquery.cycle2.js" type="text/javascript"></script>
    <script src="../Jquery/cycle2-master/build/plugin/jquery.cycle2.center.min.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
   
   <div class="cycle-slideshow" data-cycle-center-horz="true"  data-cycle-center-vert="true" >
       <img alt="" src="~/SlidShow/2.jpg" width="500" height="650" runat=server /> 

    <img src="../SlidShow/625568_356367674477181_911561183_n copy.jpg" width="940"  height="650">
    <img src="../SlidShow/6final.jpg" width="940" height="650">
    <img src="../SlidShow/DSC_0093.jpg" width="940" height="650">
    <img src="../SlidShow/DSC_0229.jpg" width="940" height="650">
    <img src="../SlidShow/DSC_8198.jpg" width="940" height="650">
    <img src="../SlidShow/Found_20145205_7173885.jpg" width="500"  height="650">   
 
</div>
    
 

</asp:Content>


