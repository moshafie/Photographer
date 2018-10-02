<%@ Page Title="" Language="VB" MasterPageFile="~/Master Page/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Photo_Albums_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../Jquery/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="../Jquery/lightbox-2.6.min.js" type="text/javascript"></script>
    <link href="../Jquery/lightbox.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
       
        .grd
        {}
       
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="gred">
   <asp:GridView  ID="GridView1" RowStyle-Height="3" ShowHeader="False" 
         runat="server" AllowPaging="True" 
        DataKeyNames="ID" DataSourceID="LinqDataSource1" 
        AutoGenerateColumns="False" PageSize="8" CssClass="grd" 
        ViewStateMode="Disabled" Height="145px" 
        Width="120px" CellPadding="0" Font-Bold="True" Font-Italic="True" 
         Font-Size="Medium" ForeColor="Black" GridLines="None" >
        <AlternatingRowStyle BorderStyle="None"  />
        <Columns>

            <asp:HyperLinkField DataNavigateUrlFields="ID"  
                DataNavigateUrlFormatString="ID_Album={0}" DataTextField="Album Name" 
                 Visible="False" />
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" 
                Visible="False" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Font-Underline="false" ForeColor="Black" ID="LinkButton1" runat="server" CausesValidation="False" 
                        CommandName="Select"  Text='<%# Bind("Album_Name") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
    </div>
    <div id="lstview">
  
    <asp:ListView ID="ListView1" SkinID="#main #contant #lstview" runat="server" DataKeyNames="ID_Photo" 
        DataSourceID="LinqDataSource2" InsertItemPosition="None" 
           ViewStateMode="Enabled">
                      <LayoutTemplate>
                 <ul class="itemContainer">
                     <li id="itemPlaceholder" runat="server"></li>
                 </ul>  
                 <div style="">
     
    </div>
    
             </LayoutTemplate>  
             <ItemTemplate>
             <li>              
 <a id="imageLink" href='<%# Eval("Photo_Name") %>' title='<%#Eval("Photo_discreption") %>' rel="lightBox" data-lightbox="roadtrip" runat="server" >
   <asp:Image CssClass="imag" ID="Image1" ImageUrl='<%# Bind("Photo_Name") %>' runat="server" Width="200" Height="300" />
    </a>  <br />
<asp:Label ID="DescriptionTextBox" runat="server" 
                   Text='<%# Bind("Photo_discreption") %>' />
                   <br />
    </li></ItemTemplate> 
     
    </asp:ListView>
  
  
  </div>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="DataClassesDataContext" EntityTypeName="" 
        Select="new (ID, Album_Name)" TableName="Albums">
    </asp:LinqDataSource>
    <asp:LinqDataSource ID="LinqDataSource2" runat="server" 
        ContextTypeName="DataClassesDataContext" EntityTypeName="" 
        TableName="Photos" Where="ID_Album == @ID_Album" EnableDelete="True">
        <WhereParameters>
            <asp:ControlParameter ControlID="GridView1" DefaultValue="1" Name="ID_Album" 
                PropertyName="SelectedValue" Type="Int32" />
        </WhereParameters>
    </asp:LinqDataSource>
    <div id="pager">

    <asp:DataPager ID="DataPager1" runat="server" PageSize="6" PagedControlID="ListView1">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                ShowLastPageButton="True" />
        </Fields>
    </asp:DataPager>
    </div>
  </asp:Content>

