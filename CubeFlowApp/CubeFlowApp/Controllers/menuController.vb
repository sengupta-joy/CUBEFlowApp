Imports System.Web.Mvc

Namespace Controllers
    Public Class menuController
        Inherits Controller

        ' GET: menu
        Function Index() As ActionResult

            Dim obj = ApiCaller.GetRequest("menu")

            'ViewBag("menuData") = obj

            Return View()
        End Function
    End Class
End Namespace