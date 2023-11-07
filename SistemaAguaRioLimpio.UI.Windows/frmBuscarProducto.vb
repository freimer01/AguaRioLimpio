Imports SistemaAguaRioLimpio.BLL
Imports SistemaAguaRioLimpio.DAL

Public Class frmBuscarProducto

    Private _IdProducto As Integer
    Public ReadOnly Property IdProducto As Integer
        Get
            Return _IdProducto
        End Get
    End Property
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.dgvBusquedaProducto.AutoGenerateColumns = False
        Me.dgvBusquedaProducto.DataSource = ProductoBLL.GetAll

        Dim ColCategoria As DataGridViewComboBoxColumn = dgvBusquedaProducto.Columns.Item("Categoria")

        ColCategoria.DataSource = CategoriaBLL.GetAll
        ColCategoria.DisplayMember = "Nombre"
        ColCategoria.ValueMember = "ID"
        ColCategoria.DataPropertyName = "IdCategoria"
    End Sub

    Private Sub dgvBusquedaArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusquedaProducto.CellDoubleClick

        If e.RowIndex = -1 Then
            Exit Sub
        End If

        _IdProducto = dgvBusquedaProducto.CurrentRow.Cells("ID").Value

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class