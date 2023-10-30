Imports SistemaAguaRioLimpio.DAL
Imports SistemaAguaRioLimpio.Entities

Public Class CategoriaBLL

    Public Shared Sub Save(categoria As CategoriaEntity)
        If categoria.IdCategoria = 0 Then
            'Es una nueva categoria'
            CategoriaDAL.Create(categoria)

        Else
            'Es una actualizacion de una categoria existente '
            CategoriaDAL.Update(categoria)
        End If
    End Sub

    Public Shared Function GetById(id As Integer) As CategoriaEntity
        Return CategoriaDAL.GetByID(id)
    End Function

    Public Shared Function GetAll() As List(Of CategoriaEntity)
        Return CategoriaDAL.GetAll()
    End Function

    Public Shared Function GatByValor(valor As String) As List(Of CategoriaEntity)
        Return CategoriaDAL.GetByValor(valor)
    End Function

End Class
