<%@ Page Title="" Language="VB" MasterPageFile="~/Master Page/MasterPage.master" AutoEventWireup="false" CodeFile="ManegmentAlbum.aspx.vb" Inherits="Gallery_ManegmentAlbum" %>

<%@ Register Assembly="ASPNetAudio.NET3" Namespace="ASPNetAudio" TagPrefix="ASPNetAudio" %>

<%@ Register Assembly="ASPNetVideo.NET3" Namespace="ASPNetVideo" TagPrefix="ASPNetVideo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="../Jquery/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="../Jquery/lightbox-2.6.min.js" type="text/javascript"></script>
    <link href="../Jquery/lightbox.css" rel="stylesheet" type="text/css" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID_Photo" 
             DataSourceID="LinqDataSource1" InsertItemPosition="LastItem" >        
             
             
                          
                 <InsertItemTemplate>
                   <li>    
        
      Add New Photo : <asp:FileUpload ID="FileUpload1" runat="server" />
             <asp:CustomValidator ID="CustomValidator1" 
           runat="server" ErrorMessage="pleas inseart valid end with .JPG"></asp:CustomValidator>
   <br />

 Photo Name : <asp:TextBox ID="ImageNameTextBox" runat="server" 
                    Text='<%# Bind("Photo_discreption") %>' TextMode ="MultiLine" /> 
                       <asp:RequiredFieldValidator ControlToValidate="ImageNameTextBox" 
                       ID="RequiredFieldValidator1" runat="server" 
                       ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                    Text="Insert" CausesValidation="false" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                    Text="Clear" CausesValidation="false" />
                    </li>
             </InsertItemTemplate>
             <ItemTemplate>
             <li>
 <a id="imageLink" href='<%# Eval("Photo_Name") %>' title='<%#Eval("Photo_discreption") %>' rel="lightBox" data-lightbox="roadtrip" runat="server" >
   <asp:Image CssClass="img" ID="Image1" ImageUrl='<%# Bind("Photo_Name") %>' runat="server" Width="200" Height="300" />
    
    </a>
             <br />
<asp:Label ID="DescriptionTextBox" runat="server" 
                    Text='<%# Bind("Photo_discreption") %>' />
    </li>

             </ItemTemplate>
             <LayoutTemplate>
                 <ul class="itemContainer">
                     <li id="itemPlaceholder" runat="server"></li>
                 </ul>  
             </LayoutTemplate>
              </asp:ListView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
        ContextTypeName="DataClassesDataContext" EntityTypeName="" 
        TableName="Photos" Where="ID_Album == @ID_Album" 
        EnableInsert="True" EnableDelete="True">
        <WhereParameters>
            <asp:QueryStringParameter DefaultValue="0" Name="ID_Album" 
                QueryStringField="ID_Album" Type="Int32" />
        </WhereParameters>
    </asp:LinqDataSource>
</asp:Content>

