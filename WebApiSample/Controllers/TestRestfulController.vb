Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class TestRestfulController
        Inherits ApiController

        ' GET: api/TestRestful
        Public Function GetList() As List(Of TestDTO)
            Dim DAO As New DataAccess
            Return DAO.GetList()
        End Function

        ' GET: api/TestRestful/5
        Public Function GetRecord(ByVal id As Integer) As TestDTO
            Dim DAO As New DataAccess
            Return DAO.GetRecord(New TestDTO With {.iId = id})
        End Function

        ' POST: api/TestRestful
        Public Sub PostValue(<FromBody()> ByVal poEntity As TestDTO)
            Dim DAO As New DataAccess
            DAO.Create(poEntity)
        End Sub

        ' PUT: api/TestRestful/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal poEntity As TestDTO)
            poEntity.iId = id

            Dim DAO As New DataAccess
            DAO.Update(poEntity)
        End Sub

        ' DELETE: api/TestRestful/5
        Public Sub DeleteValue(ByVal id As Integer)
            Dim DAO As New DataAccess
            DAO.Delete(New TestDTO With {.iId = id})
        End Sub

    End Class
End Namespace
