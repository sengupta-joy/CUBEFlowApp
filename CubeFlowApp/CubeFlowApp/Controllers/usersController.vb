Imports System.Web.Mvc
Imports Newtonsoft.Json

Namespace Controllers
    Public Class usersController
        Inherits Controller

        ' GET: users

        Function Index() As ActionResult
            Dim userObj As New Dictionary(Of String, String)()
            Dim brnchObj As New Dictionary(Of String, String)()
            Dim deptObj As New Dictionary(Of String, String)()
            Dim desigObj As New Dictionary(Of String, String)()

            Dim listAlphabet As New List(Of String)

            Try
                userObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(ApiCaller.GetRequest("users"))
                brnchObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(ApiCaller.GetRequest("branch"))
                deptObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(ApiCaller.GetRequest("depertment"))
                desigObj = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(ApiCaller.GetRequest("designation"))
            Catch ex As Exception

            End Try

            For Each item In userObj.Values
                If Not listAlphabet.Contains(Left(item, 1).ToUpper()) Then
                    listAlphabet.Add(Left(item, 1).ToUpper())
                End If
            Next



            ViewData("alphabetObj") = listAlphabet
            ViewData("userObj") = userObj
            ViewData("brnchObj") = brnchObj
            ViewData("deptObj") = deptObj
            ViewData("desigObj") = desigObj


            Return View(ViewData)
        End Function

        Function userDetails(id As String) As ActionResult
            Dim param As New Dictionary(Of String, String)
            Dim userObj

            Dim anon = New With {.id = "Peter"}


            Try

                param.Add("id", id)
                userObj = System.Web.Helpers.Json.Decode(ApiCaller.GetRequest("users", "GetValue", param))

                ViewBag("userObj") = userObj
                Return View(ViewBag)
            Catch ex As Exception

            End Try

        End Function


    End Class
End Namespace