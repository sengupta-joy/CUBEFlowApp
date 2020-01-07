
Imports System.Net
Imports System.Web.Mvc

Public Class CustomAuthentication : Implements System.Web.Mvc.IAuthorizationFilter

    Public Sub OnAuthorization(filterContext As AuthorizationContext) Implements IAuthorizationFilter.OnAuthorization
        Dim anonymAttr As New System.Web.Mvc.AllowAnonymousAttribute()

        Dim ActionAttrs = filterContext.ActionDescriptor.GetCustomAttributes(False)

        For Each attr As Attribute In ActionAttrs
            If TypeOf attr Is AllowAnonymousAttribute Then
                Return
            End If
        Next


        If Not authorized(filterContext.ActionDescriptor.ActionName, filterContext.Controller.ControllerContext.Controller.ToString()) Then
            HttpContext.Current.Response.Clear()
            HttpContext.Current.Response.Write("Unauthorized!")
            HttpContext.Current.Response.StatusCode = HttpStatusCode.Unauthorized
            HttpContext.Current.Response.End()
        End If


    End Sub

    Private Function authorized(actionName As String, controller As String) As Boolean
        'check if session is valid
        'check if user have access
        Return True
    End Function
End Class
