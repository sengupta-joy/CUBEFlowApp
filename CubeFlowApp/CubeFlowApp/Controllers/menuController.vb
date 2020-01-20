Imports System.Web.Mvc

Namespace Controllers
    Public Class menuController
        Inherits Controller

        ' GET: menu
        <AllowAnonymous>
        Function Index() As ActionResult

            Dim obj = ApiCaller.GetRequest("menu")

            obj = IO.File.ReadAllText("d:\menudata.txt")
            ViewData("menuObj") = obj

            Return View()
        End Function
    End Class
End Namespace