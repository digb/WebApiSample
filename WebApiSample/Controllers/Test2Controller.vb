Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class Test2Controller
        Inherits ApiController

        <HttpPost>
        Public Function GetList(<FromBody()> ByVal poInputParam As Test2InputParam) As List(Of TestDTO)

        End Function

        <HttpPost>
        Public Function GetRecord(<FromBody()> ByVal poInputParam As Test2InputParam) As TestDTO

        End Function

        <HttpPost>
        Public Sub Add(<FromBody()> ByVal poEntity As TestDTO)

        End Sub

        <HttpPost>
        Public Sub Edit(<FromBody()> ByVal poEntity As TestDTO)

        End Sub

        <HttpPost>
        Public Sub Delete(<FromBody()> ByVal poEntity As TestDTO)

        End Sub

    End Class

    Public Class Test2InputParam
        Public Property pcCompanyId As String
        Public Property pcEntityId As Integer
    End Class

End Namespace
