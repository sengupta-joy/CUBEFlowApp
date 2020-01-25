Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class usersController
        Inherits Controller

        ' GET: users
        Function Index() As ActionResult

            Dim json = ApiCaller.GetRequest("users")
            Dim userObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)
            Dim listAlphabet As New List(Of String)

            For Each item In userObj.Values
                If Not listAlphabet.Contains(Left(item, 1)) Then
                    listAlphabet.Add(Left(item, 1).ToUpper())
                End If
            Next

            ViewData("Alphabets") = listAlphabet
            ViewData("userObj") = userObj
            Return View(ViewData)
        End Function
    End Class
End Namespace