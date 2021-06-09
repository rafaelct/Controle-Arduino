Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Json
Imports System.Text
Imports Newtonsoft.Json
Public Class ConnectionApi

    Public Shared Function LedApi(ByVal url As String) As Led

        REM Shared baseUrl As String = Uri
        Dim client = New WebClient()
        client.Headers.Add("User-Agent", "Nobody")


        Try
            Dim response = client.DownloadString(New Uri(url))
            Dim led As Led = JsonConvert.DeserializeObject(Of Led)(response)
            Return led
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function BuzzerApi(ByVal url As String) As Buzzer

        REM Shared baseUrl As String = Uri
        Dim client = New WebClient()
        client.Headers.Add("User-Agent", "Nobody")

        Try
            Dim response = client.DownloadString(New Uri(url))
            Dim buzzer As Buzzer = JsonConvert.DeserializeObject(Of Buzzer)(response)
            Return buzzer
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
