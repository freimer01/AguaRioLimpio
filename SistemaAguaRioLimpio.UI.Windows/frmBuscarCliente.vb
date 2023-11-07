
Imports SistemaAguaRioLimpio.BLL

Public Class frmBuscarCliente

    Private _IdCliente As Integer
    Public ReadOnly Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
    End Property
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.dgvBusquedaClientes.AutoGenerateColumns = False
        Me.dgvBusquedaClientes.DataSource = ClienteBLL.GetAll
    End Sub

    Private Sub dgvBusquedaClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusquedaClientes.CellDoubleClick

        If e.RowIndex = -1 Then
            Exit Sub
        End If

        _IdCliente = dgvBusquedaClientes.CurrentRow.Cells("ID").Value

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class