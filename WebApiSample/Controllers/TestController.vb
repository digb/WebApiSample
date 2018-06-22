Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class TestController
        Inherits ApiController

        ' api/Test2/GetList
        <HttpPost>
        Public Function GetList(<FromBody()> ByVal poInputParam As Test2InputParam) As List(Of TestDTO)
            Try

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        ' api/Test2/GetRecord
        <HttpPost>
        Public Function GetRecord(<FromBody()> ByVal poInputParam As Test2InputParam) As TestDTO

        End Function

        ' api/Test2/Add
        <HttpPost>
        Public Sub Add(<FromBody()> ByVal poEntity As TestDTO)

        End Sub

        ' api/Test2/Edit
        <HttpPost>
        Public Sub Edit(<FromBody()> ByVal poEntity As TestDTO)

        End Sub

        ' api/Test2/Delete
        <HttpPost>
        Public Sub Delete(<FromBody()> ByVal poEntity As TestDTO)

        End Sub

    End Class

    Public Class Test2InputParam
        Public Property pcCompanyId As String
        Public Property pcEntityId As Integer
        Public Property pcUsrId As String
        Public Property pcPasswd As String
    End Class

End Namespace
