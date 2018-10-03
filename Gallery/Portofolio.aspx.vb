'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.IO
'Partial Class pages_Portofolio
'    Inherits System.Web.UI.Page

'    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


'    End Sub

'    Protected Sub ListView1_ItemCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ListViewCommandEventArgs) Handles ListView1.ItemCommand
'        Dim upl As FileUpload
'        Dim lbl As Label
'        Dim txt As TextBox
'        Select Case e.CommandName
'            Case "insertupload"
'                upl = CType(ListView1.InsertItem.FindControl("ImgUpload"), FileUpload)
'                lbl = CType(ListView1.InsertItem.FindControl("LblUpload"), Label)
'                txt = CType(ListView1.InsertItem.FindControl("ImageNameTextBox"), TextBox)
'                Call UploadImage(upl, lbl, txt)


'        End Select
'    End Sub
'    Private Sub UploadImage(ByVal upl As FileUpload, ByVal lbl As Label, ByVal txt As TextBox)
'        If upl.HasFile Then

'            If upl.FileName.ToLower.EndsWith(".jpg") Then

'                If upl.FileContent.Length < 1000000 Then
'                    upl.SaveAs(Server.MapPath("~/SlideImages/" & upl.FileName))
'                    lbl.ForeColor = Drawing.Color.White
'                    lbl.Text = "Uploaded."
'                    txt.Text = upl.FileName


'                Else
'                    lbl.ForeColor = Drawing.Color.Red
'                    lbl.Text = "File is too big.Must be less than 1MB."
'                End If

'            Else
'                lbl.ForeColor = Drawing.Color.Red
'                lbl.Text = "Only file ending with .jpg"
'            End If
'        Else

'            lbl.ForeColor = Drawing.Color.Red
'            lbl.Text = "File Name Required"
'        End If
'    End Sub

'    Protected Sub shownew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles shownew.Click

'        If ListView1.InsertItemPosition = InsertItemPosition.FirstItem Then

'            ListView1.InsertItemPosition = InsertItemPosition.None
'            shownew.Text = "Add New"
'        Else

'            ListView1.InsertItemPosition = InsertItemPosition.FirstItem
'            shownew.Text = "Hide New"
'        End If

'    End Sub


'End Class
