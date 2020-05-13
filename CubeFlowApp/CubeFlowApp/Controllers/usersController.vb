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
            Dim retval As New Dictionary(Of String, Object)

            'Dim anon = New With {.id = "Peter"}


            Try

                param.Add("id", id)
                userObj = System.Web.Helpers.Json.Decode(ApiCaller.GetRequest("users", "GetValue", param))

                ViewData("userid") = id

                ViewData("about") = userObj.about
                ViewData("active") = userObj.active
                ViewData("address") = userObj.address
                ViewData("city") = userObj.city
                ViewData("email") = userObj.email
                ViewData("name") = userObj.name
                ViewData("phone") = userObj.phone
                ViewData("country") = userObj.country

                param("id") = userObj.boss
                ViewData("boss") = System.Web.Helpers.Json.Decode(ApiCaller.GetRequest("users", "GetValue", param)).Name

                param("id") = userObj.depertment
                ViewData("dept") = System.Web.Helpers.Json.Decode(ApiCaller.GetRequest("depertment", "GetValue", param)).Name

                param("id") = userObj.designation
                ViewData("desig") = System.Web.Helpers.Json.Decode(ApiCaller.GetRequest("designation", "GetValue", param)).Name

                param("id") = userObj.branch
                ViewData("branch") = userObj.branch ' System.Web.Helpers.Json.Decode(ApiCaller.GetRequest("branch", "GetValue", param)).Name

                param("id") = userObj.company
                ViewData("company") = userObj.company ' System.Web.Helpers.Json.Decode(ApiCaller.GetRequest("entity", "GetValue", param)).Name





                Return View()
            Catch ex As Exception

            End Try

        End Function


    End Class
End Namespace