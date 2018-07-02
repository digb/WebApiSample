Imports System.Runtime.Caching

Public Class DataAccess

    Public Function GetList(piDataCount As Integer) As List(Of TestDTO)
        Dim result As New List(Of TestDTO)
        Dim memCache = MemoryCache.Default

        If Not memCache.Contains("testnav_getlist") Then
            For i = 1 To piDataCount
                result.Add(New TestDTO With {
                       .iId = i,
                       .cString = "Item " & i,
                       .nDecimal = i / 10,
                       .lBoolean = (i Mod 2 = 0),
                       .dDateTime = DateTime.UtcNow
                       })
            Next
            memCache.Set("testnav_getlist", result, DateTimeOffset.UtcNow.AddMinutes(30))
        End If

        result = memCache.Get("testnav_getlist")
        Return result
    End Function

    Public Function GetRecord(poEntity As TestDTO) As TestDTO
        Dim memCache = MemoryCache.Default
        Dim cached As List(Of TestDTO) = memCache.Get("testnav_getlist")

        Return cached.Where(Function(x) x.iId = poEntity.iId).SingleOrDefault
    End Function

    Public Sub Create(poEntity As TestDTO)
        Dim memCache = MemoryCache.Default
        Dim cached As List(Of TestDTO) = memCache.Get("testnav_getlist")

        cached.Add(poEntity)
    End Sub

    Public Sub Update(poEntity As TestDTO)
        Dim memCache = MemoryCache.Default
        Dim cached As List(Of TestDTO) = memCache.Get("testnav_getlist")

        Dim idx = cached.FindIndex(Function(x) x.iId = poEntity.iId)
        cached(idx) = poEntity
    End Sub

    Public Sub Delete(poEntity As TestDTO)
        Dim memCache = MemoryCache.Default
        Dim cached As List(Of TestDTO) = memCache.Get("testnav_getlist")

        cached.RemoveAll(Function(x) x.iId = poEntity.iId)
    End Sub

End Class
