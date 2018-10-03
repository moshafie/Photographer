
Partial Class Gallery_AddNewAlbum
    Inherits System.Web.UI.Page

    Protected Sub LinqDataSource1_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.LinqDataSourceStatusEventArgs) Handles LinqDataSource1.Inserted
        Dim myAlbum As Album = CType(e.Result, Album)
        Response.Redirect(String.Format("ManegmentAlbum.aspx?ID_Album={0}", myAlbum.ID.ToString()))
    End Sub

End Class
