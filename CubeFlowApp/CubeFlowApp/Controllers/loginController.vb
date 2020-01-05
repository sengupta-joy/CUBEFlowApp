Imports System.Web.Mvc

Namespace Controllers
    Public Class loginController
        Inherits Controller

        ' GET: login
        Function Index() As ActionResult
            Return View()
        End Function

        Function index(id As String, password As String) As String
            Return "success"
        End Function
    End Class
End Namespace