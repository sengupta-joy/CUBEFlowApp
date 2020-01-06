Imports System.Web.Mvc

Public Class CustomAuthentication : Implements System.Web.Mvc.IAuthorizationFilter

    Public Sub OnAuthorization(filterContext As AuthorizationContext) Implements IAuthorizationFilter.OnAuthorization

        If Not filterContext.ActionDescriptor.IsDefined(Type.GetType("System.Web.Mvc.AllowAnonymousAttribute"), True) Then
            If Not authorized(filterContext.ActionDescriptor.ActionName, filterContext.Controller.ControllerContext.Controller.ToString()) Then
                filterContext.HttpContext.Response.Write("unauthorized")
            End If
        End If


    End Sub

    Private Function authorized(actionName As String, controller As String) As Boolean
        Return True
    End Function
End Class
