Imports System.Net.Mail


Partial Class Control_ContactUs_Control_
    Inherits System.Web.UI.UserControl


    Protected Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        If Page.IsValid Then
            Dim FileName As String = Server.MapPath("~/App_Data/TextFile.txt")
            Dim MailBody As String = System.IO.File.ReadAllText(FileName)

            MailBody = MailBody.Replace("##Name##", txtName.Text)
            MailBody = MailBody.Replace("##Emial##", txtEmial1.Text)
            'MailBody = MailBody.Replace("##HomePhone##", txtHomePhone.Text)
            MailBody = MailBody.Replace("##WorkPhone##", txtWorkPhone.Text)
            MailBody = MailBody.Replace("##Comments##", txtComments.Text)

            Dim mymessage As New MailMessage
            With mymessage
                .Subject = "Contact From Response"
                .Body = MailBody
                .From = New MailAddress("shaf3e_msm@yahoo.com", "from shaf3e")
                .To.Add(New MailAddress("mshaf3e@yahoo.com", "to shaf3e"))
                Dim mysmtpclient As New SmtpClient
                mysmtpclient.Send(mymessage)

            End With
        End If
        System.Threading.Thread.Sleep(5000)
        lblsent.Visible = True
        TableFormat.Visible = False

    End Sub


    'Protected Sub ValCustHomePhone_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles ValCustHomePhone.ServerValidate
    '    If txtHomePhone.Text IsNot String.Empty Or txtWorkPhone.Text IsNot String.Empty Then
    '        args.IsValid = True
    '    Else
    '        args.IsValid = False
    '    End If
    'End Sub

    
 

    'Protected Sub txtHomePhone_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHomePhone.TextChanged

    'End Sub
End Class
