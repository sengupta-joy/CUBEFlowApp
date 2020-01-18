
Imports System.Net
Imports System.Web.Mvc

Public Class CustomAuthentication : Implements System.Web.Mvc.IAuthorizationFilter

    Public Sub OnAuthorization(filterContext As AuthorizationContext) Implements IAuthorizationFilter.OnAuthorization
        Dim anonymAttr As New System.Web.Mvc.AllowAnonymousAttribute()
        Dim resp As HttpResponse = HttpContext.Current.Response

        Dim ActionAttrs = filterContext.ActionDescriptor.GetCustomAttributes(False)

        For Each attr As Attribute In ActionAttrs
            If TypeOf attr Is AllowAnonymousAttribute Then
                Return
            End If
        Next


        If Not authorized(filterContext.ActionDescriptor.ActionName, filterContext.Controller.ControllerContext.Controller.ToString()) Then
            'resp.Clear()
            'resp.Write("Unauthorized!")
            'resp.StatusCode = HttpStatusCode.Unauthorized
            'resp.End()
            resp.ClearContent()
            resp.Write("<script language='javascript'>self.location='../login';</script>")
        End If


    End Sub

    Private Function authorized(actionName As String, controller As String) As Boolean
        'check if session is valid
        'check if user have access

        If HttpContext.Current.Session(ApplicationConstant.APIKey) Is Nothing Then
            Return False
            If String.IsNullOrEmpty(HttpContext.Current.Session(ApplicationConstant.APIKey)) Then
                Return False
            End If
        End If

        Return True
    End Function
End Class
