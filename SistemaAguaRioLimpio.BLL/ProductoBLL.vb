
Imports SistemaAguaRioLimpio.DAL
Imports SistemaAguaRioLimpio.Entities

Public Class ProductoBLL

    Public Shared Sub Save(prododucto As Entities.ProductoEntity)
        If prododucto.IdProduto = 0 Then
            '   Es una nuevo articulo
            ProductoDAL.Create(prododucto)
        Else
            '    Es una actualizacion de un nuevo articulo existente
            ProductoDAL.Update(prododucto)

        End If
    End Sub

    Public Shared Function GetById(id As Integer)
        Return ProductoDAL.GetByID(id)

    End Function

    Public Shared Function GetAll() As List(Of ProductoEntity)
        Return ProductoDAL.GetAll

    End Function

    Public Shared Function GetByValor(valor As String) As List(Of ProductoEntity)
        Return ProductoDAL.GetByValor(valor)

    End Function

End Class
