Imports SistemaAguaRioLimpio.DAL
Imports SistemaAguaRioLimpio.Entities

Public Class PedidoBLL
        Public Shared Sub Save(pedido As PedidoEntity, pedidoDAL As PedidoDAL)
            If pedido.ID = 0 Then
                '   Es una nuevo pedido
                pedidoDAL.Create(pedido)
            Else
                '    Es una actualizacion de un pedido existente
                pedidoDAL.Update(pedido)

            End If
        End Sub

        Public Shared Sub Save(oPedido As PedidoEntity)
            Throw New NotImplementedException()
        End Sub

        Public Shared Function GetById(id As Integer, pedidoDAL As PedidoDAL)
            Return pedidoDAL.GetById(id)

        End Function

        Public Shared Function GetAll() As List(Of PedidoEntity)
            Return PedidoDAL.GetAll

        End Function

        Public Shared Function GetByValor(valor As String) As List(Of PedidoEntity)
            Return PedidoBLL.GetByValor(valor)

        End Function

    End Class
