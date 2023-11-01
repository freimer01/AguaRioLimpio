

Public Class ArticuloBLL

    Public Shared Sub Save(articulo As ArticuloEntity)
        If articulo.ID = 0 Then
            '   Es una nuevo articulo
            ArticuloDAL.Create(articulo)
        Else
            '    Es una actualizacion de un nuevo articulo existente
            ArticuloDAL.Update(articulo)

        End If
    End Sub

    Public Shared Function GetById(id As Integer)
        Return ArticuloDAL.GetByID(id)

    End Function

    Public Shared Function GetAll() As List(Of ArticuloEntity)
        Return ArticuloDAL.GetAll

    End Function

    Public Shared Function GetByValor(valor As String) As List(Of ArticuloEntity)
        Return ArticuloDAL.GetByValor(valor)

    End Function

End Class
