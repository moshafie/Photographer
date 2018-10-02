
Partial Class Gallery_ManegmentAlbum
    Inherits System.Web.UI.Page

  

    Protected Sub LinqDataSource1_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.LinqDataSourceInsertEventArgs) Handles LinqDataSource1.Inserting
        Dim MyPhoto As Photo = CType(e.NewObject, Photo)
        MyPhoto.ID_Album = Convert.ToInt32(Request.QueryString.Get("ID_Album"))

        Dim FileUpload1 As FileUpload = _
            CType(ListView1.InsertItem.FindControl("FileUpload1"), FileUpload)
        Dim virtualFolder As String = "~/SlideImages/"
        Dim physicalFolder As String = Server.MapPath(virtualFolder)
        Dim fileName As String = Guid.NewGuid().ToString()
        Dim extension As String = System.IO.Path.GetExtension(FileUpload1.FileName)

        FileUpload1.SaveAs(System.IO.Path.Combine(physicalFolder, fileName + extension))
        MyPhoto.Photo_Name = virtualFolder + fileName + extension


    End Sub

    Protected Sub ListView1_ItemInserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ListViewInsertEventArgs) Handles ListView1.ItemInserting
        Dim FileUpload2 As FileUpload = _
        CType(ListView1.InsertItem.FindControl("FileUpload1"), FileUpload)

        If Not FileUpload2.HasFile OrElse _
           Not FileUpload2.FileName.ToLower().EndsWith(".jpg") Then
            Dim CustomValidator1 As CustomValidator = _
                CType(ListView1.InsertItem.FindControl("CustomValidator1"), CustomValidator)
            CustomValidator1.IsValid = False
            e.Cancel = True


        End If

    End Sub
End Class
