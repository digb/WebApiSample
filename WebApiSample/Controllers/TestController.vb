Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class TestController
        Inherits ApiController

        ' api/Test/GetList
        <HttpPost>
        Public Function GetList(<FromBody()> ByVal poParam As GetListInputParam) As List(Of TestDTO)
            Try
                Dim DAO As New DataAccess
                Return DAO.GetList(poParam.piDataCount)
            Catch ex As Exception
                Throw ex
            End Try

        End Function

        ' api/Test/GetRecord
        <HttpPost>
        Public Function GetRecord(<FromBody()> ByVal poEntity As TestDTO) As TestDTO
            Try
                Dim DAO As New DataAccess
                Return DAO.GetRecord(poEntity)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' api/Test/Add
        <HttpPost>
        Public Sub Add(<FromBody()> ByVal poEntity As TestDTO)
            Try
                Dim DAO As New DataAccess
                DAO.Create(poEntity)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ' api/Test/Edit
        <HttpPost>
        Public Sub Edit(<FromBody()> ByVal poEntity As TestDTO)
            Try
                Dim DAO As New DataAccess
                DAO.Update(poEntity)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ' api/Test/Delete
        <HttpPost>
        Public Sub Delete(<FromBody()> ByVal poEntity As TestDTO)
            Try
                Dim DAO As New DataAccess
                DAO.Delete(poEntity)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    End Class

    Public Class GetListInputParam
        Public Property piDataCount As Integer
    End Class

End Namespace
