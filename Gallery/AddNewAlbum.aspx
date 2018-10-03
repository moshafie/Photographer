<%@ Page Title="" Language="VB" MasterPageFile="~/Master Page/MasterPage.master" AutoEventWireup="false" CodeFile="AddNewAlbum.aspx.vb" Inherits="Gallery_AddNewAlbum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" 
    Width="125px" AutoGenerateRows="False" DataKeyNames="AlbumID" 
    DataSourceID="LinqDataSource1" DefaultMode="Insert">
        <Fields>
            <asp:BoundField DataField="AlbumID" HeaderText="AlbumID" InsertVisible="False" 
                ReadOnly="True" SortExpression="AlbumID" />
            <asp:BoundField DataField="Album_Name" HeaderText="Album_Name" 
                SortExpression="Album_Name" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
<asp:LinqDataSource ID="LinqDataSource1" runat="server" 
    ContextTypeName="DataClassesDataContext" EnableInsert="True" EntityTypeName="" 
    TableName="Albums">
</asp:LinqDataSource>

</asp:Content>

 
      
 
