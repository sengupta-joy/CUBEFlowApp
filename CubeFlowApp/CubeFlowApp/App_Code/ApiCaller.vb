Imports System.IO
Imports System.Net

Public Class ApiCaller

    Public Shared Function GetRequest(controller As String, Optional action As String = "", Optional parameters As Dictionary(Of String, String) = Nothing) As Object
        Dim req As HttpWebRequest
        Dim resp As HttpWebResponse
        Dim responseFromServer = ""
        Dim url As String
        Dim servicePath = System.Configuration.ConfigurationManager.AppSettings.Get("apiUrl")
        Dim token = HttpContext.Current.Session(ApplicationConstant.APIKey)


        url = servicePath + controller

        If Not action.Equals(String.Empty) Then
            url = servicePath + controller + "/" + action
        End If


        If Not parameters Is Nothing Then
            url = url + "?"
            For Each p In parameters
                url = url + p.Key + "=" + p.Value + "&"
            Next

            If url.Last() = "&" Then
                url = Mid(url, 1, Len(url) - 1)
            End If
        End If


        req = DirectCast(WebRequest.Create(url), HttpWebRequest)
        req.Method = "GET"
        'req.Accept = "application/json"


        req.Headers.Add("token", token)


        Try
            resp = DirectCast(req.GetResponse(), HttpWebResponse)
            If resp.StatusDescription.Equals("OK") Then
                Using strm = resp.GetResponseStream()
                    Dim reader = New StreamReader(strm)
                    responseFromServer = reader.ReadToEnd()
                End Using
            Else
                responseFromServer = ""
            End If


        Catch ex As Exception
            responseFromServer = ex.Message
        End Try

        Return responseFromServer
    End Function

End Class
