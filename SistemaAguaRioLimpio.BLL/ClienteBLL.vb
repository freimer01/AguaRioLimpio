Imports SistemaAguaRioLimpio.DAL
Imports SistemaAguaRioLimpio.Entities

Public Class ClienteBLL
    Public Shared Sub Save(cliente As ClienteEntity)
        If cliente.ID = 0 Then
            '   Es un nuevo cliente
            ClienteDAL.Create(cliente)
        Else
            '    Es una actualizacion de un cliente existente
            ClienteDAL.Update(cliente)

        End If
    End Sub

    Public Shared Function GetById(id As Integer)
        Return ClienteDAL.GetByID(id)

    End Function

    Public Shared Function GetAll() As List(Of ClienteEntity)
        Return ClienteDAL.GetAll

    End Function

    Public Shared Function GetByValor(valor As String) As List(Of ClienteEntity)
        Return ClienteDAL.GetByValor(valor)

    End Function
End Class
