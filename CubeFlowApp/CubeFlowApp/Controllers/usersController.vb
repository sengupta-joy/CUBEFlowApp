Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class usersController
        Inherits Controller

        ' GET: users
        <AllowAnonymous>
        Function Index() As ActionResult
            Dim userObj As New Dictionary(Of String, String)()
            Dim listAlphabet As New List(Of String)
            Dim json = ApiCaller.GetRequest("users")

            Try
                userObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(json)
            Catch ex As Exception

            End Try

            For Each item In userObj.Values
                If Not listAlphabet.Contains(Left(item, 1)) Then
                    listAlphabet.Add(Left(item, 1).ToUpper())
                End If
            Next

            listAlphabet.Add("A")
            listAlphabet.Add("B")
            listAlphabet.Add("C")

            ViewData("alphabetObj") = listAlphabet
            ViewData("userObj") = userObj

            Return View(ViewData)
        End Function
    End Class
End Namespace