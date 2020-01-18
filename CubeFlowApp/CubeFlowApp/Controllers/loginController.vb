Imports System.Web.Mvc

Namespace Controllers
    Public Class loginController
        Inherits Controller

        ' GET: login
        <AllowAnonymous>
        Function Index() As ActionResult
            Dim cookie = New HttpCookie("APIUrl")
            cookie.Value = System.Configuration.ConfigurationManager.AppSettings.Get("apiUrl")
            cookie.Expires = DateTime.Now.AddHours(5)
            Response.Cookies.Add(cookie)

            cookie = New HttpCookie("APIKey")
            cookie.Value = ""
            cookie.Expires = DateTime.Now.AddHours(5)
            Response.Cookies.Add(cookie)


            Return View()
        End Function


    End Class
End Namespace