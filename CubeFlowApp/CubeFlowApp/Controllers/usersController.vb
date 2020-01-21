Imports System.Web.Mvc

Namespace Controllers
    Public Class usersController
        Inherits Controller

        ' GET: users
        <AllowAnonymous>
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace