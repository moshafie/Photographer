Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols





' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.

<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<System.Web.Script.Services.ScriptService()> _
Public Class WebService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function GetSlides() As AjaxControlToolkit.Slide()
        Dim myslid(7) As AjaxControlToolkit.Slide
        myslid(0) = New AjaxControlToolkit.Slide("~/images1/fashion1.jpg", "Fashion1", "Go Fashion1")
        myslid(1) = New AjaxControlToolkit.Slide("~/images1/fashion2.jpg", "Fashion2", "Go Fashion2")
        myslid(2) = New AjaxControlToolkit.Slide("~/images1/monir.jpg", "monir", "Go monir")
        myslid(3) = New AjaxControlToolkit.Slide("~/images1/monir1.jpg", "monir1", "Go monir1")
        myslid(4) = New AjaxControlToolkit.Slide("~/images1/wedding1.jpg", "wedding1", "Go wedding1")
        myslid(5) = New AjaxControlToolkit.Slide("~/images1/wedding2.jpg", "wedding2", "Go wedding2")
        myslid(6) = New AjaxControlToolkit.Slide("~/images1/wedding3.jpg", "wedding3", "Go wedding3")
        myslid(7) = New AjaxControlToolkit.Slide("~/images1/Clasic.jpg", "Clasic", "Go Clasic")

        Return myslid

    End Function


End Class