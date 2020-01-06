Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Session(ApplicationConstant.APIKey) = Request.QueryString.GetValues("key")(0)


        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
