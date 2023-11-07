Imports SistemaAguaRioLimpio.BLL
Imports SistemaAguaRioLimpio.Entities

Public Class frmPedido

    'Variable que recoge el id del articulo seleccionado
    Private _IdProductoo As Integer

    'Detalle de la lista del pedido
    Dim iDetallePedido As DetallePedidoEntity

    'Crear una variable que pueda ser accedida a la misma
    Dim iPedido As PedidoEntity

    'variable para poder eliminar una fila del datagrid
    Dim index As Integer

    Public ReadOnly Property IdProductoo As Integer
        Get
            Return _IdProductoo
        End Get
    End Property


    Private Sub frmPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim frm As New frmBuscarCliente

        'Para mostrar el formulario de busqueda para clientes'
        If frm.ShowDialog() = DialogResult.OK Then
            Dim oCliente As ClienteEntity = ClienteBLL.GetById(frm.IdCliente)
            'Para mostrar datos de los clientes'
            Me.txtCodigoCliente.Text = oCliente.IdCliente
            Me.txtCodigoCliente.Text = oCliente.Nombre & " " & oCliente.Apellidos
            Me.txtCedula.Text = oCliente.Cedula

        End If
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        'llamamos el formulario para agregar los producto al pedido
        Dim frm As New frmBuscarProducto

        If frm.ShowDialog = DialogResult.OK Then 'se cargaran los datos despues de la seleccion

            Dim iProducto As ProductoEntity = ProductoBLL.GetById(frm.IdProducto)

            Me.txtCodigoProducto.Text = iProducto.IdProduto
            Me.txtProducto.Text = iProducto.Nombre
            Me.txtCantidadProducto.Text = 1
            Me.txtPrecioProducto.Text = iProducto.Precio
            _IdProducto = frm.ID

        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

        'Validacion de que el detalle no sea incorrecto
        If Not ValidarDetalle() Then
            Exit Sub
        End If

        Dim Detalle As New DetallePedidoEntity

        Detalle.ID = Me.txtCodigoProducto.Text
        Detalle.IdPedido = Me.txtCodigoProducto.Text
        Detalle.IdProducto = txtCodigoProducto.Text
        Detalle.Cantidad = Me.txtCantidadProducto.Text
        Detalle.Precio = Me.txtPrecioProducto.Text
        Detalle.Descuento = Me.txtDescuentoProducto.Text

        'Agrega el objeto detalle a la lista
        iPedido.Detalles.Add(Detalle)

        'inicializamos todo despues de agregar el pedido
        InicializarControlesDetalle()

    End Sub

    Private Sub InicializarControlesDetalle()
        Me.txtCodigoProducto.Text = 0
        Me.txtProducto.Text = Nothing
        Me.txtCantidadProducto.Text = 0
        Me.txtPrecioProducto.Text = 0
        Me.txtDescuentoProducto.Text = 0

        Me.dgvPedido.AutoGenerateColumns = False
        Dim binding As New BindingSource
        binding.DataSource = iPedido.Detalles
        Me.dgvPedido.DataSource = binding

        Me.txtSubTotal.Text = iPedido.TotalSubTotal.ToString("C")
        Me.txtDescuentoTotal.Text = iPedido.TotalDescuento.ToString("C")
        Me.txtImpuestoTotal.Text = iPedido.TotalImpuesto.ToString("C")
        Me.txtTotalFinal.Text = iPedido.Total.ToString("C")

    End Sub
    Private Function ValidarDetalle() As Boolean
        Dim Resultado As Boolean = True
        ErrorProvider.Clear()

        If txtCodigoProducto.Text = 0 Then
            MessageBox.Show("Por favor agregue los productos...", Nombre_Empresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnBuscarProducto.Focus()
            Resultado = False
        End If

        If Val(txtCantidadProducto.Text) = 0 Then
            ErrorProvider.SetError(txtCantidadProducto, "Introduzca la cantidad..")
            Resultado = False
        End If
        Return Resultado
    End Function

    Private Function ValidarPedido() As Boolean
        Dim Resultado As Boolean = True
        ErrorProvider.Clear()

        If String.IsNullOrEmpty(Me.txtNombre.Text) Then
            MessageBox.Show("Por favor seleccione el cliente...", CStr(MessageBoxButtons.OK))
            Me.btnBuscarCliente.Focus()
            Resultado = False
        End If

        If dgvPedido.Rows.Count = 0 Then
            MessageBox.Show("Por favor agregue los productos...", CStr(MessageBoxButtons.OK))
            Me.btnBuscarProducto.Focus()
            Resultado = False
        End If

        Return Resultado
    End Function

    Private Function ValidarPedidoEliminar() As Boolean
        Dim Resultado As Boolean = True
        ErrorProvider.Clear()
        If IdProductoo = 0 Then
            MessageBox.Show("Por favor seleccione el articulo...", Nombre_Empresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.dgvPedido.Focus()
            Resultado = False
        End If
        Return Resultado
    End Function

    Private Sub Inicializar()

        iPedido = New PedidoEntity
        iDetallePedido = New DetallePedidoEntity

        Me.txtCodigoCliente.Text = 0
        Me.txtNombre.Clear()
        Me.txtCedula.Clear()
        Me.txtMesa.Text = 0
        Me.DateTimePicker.Value = DateTime.Today
        Me.txtProducto.Text = ""
        Me.txtSubTotal.Text = 0.ToString("C")
        Me.txtDescuentoTotal.Text = 0.ToString("C")
        Me.txtImpuestoTotal.Text = 0.ToString("C")
        Me.txtTotalFinal.Text = 0.ToString("C")

        Me.dgvPedido.AutoGenerateColumns = False
        Me.dgvPedido.DataSource = Nothing

        InicializarControlesDetalle()
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'validamos que nada este vacio antes de guardar
        If Not ValidarPedido() Then
            Exit Sub
        End If

        'pasamos sus respectivos valores para ser guardados
        iPedido.ID = 0
        iPedido.IdCliente = Me.txtCodigoCliente.Text
        iPedido.Fecha = Me.DateTimePicker.Value

        iDetallePedido.IdProducto = _IdProductoo

        Try
            'guardamos y mostramos mensaje de confirmacion
            PedidoBLL.Save(iPedido)
            MessageBox.Show("Pedido generado correctamente...", Nombre_Empresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Inicializar()
        Catch ex As Exception
            'en caso de error mostramos esto
            MessageBox.Show(ex.Message, Nombre_Empresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'reinicia los textbox para un nuevo pedido
        Inicializar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'para cerrar el formulario
        Me.Close()
    End Sub

    Private Sub dgvPedido_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedido.CellClick

        'para evitar errores
        If e.RowIndex = -1 Then
            Exit Sub
        End If

        'guardamos el indice del producto en el datagrid de pedido
        index = dgvPedido.CurrentRow.Index

        'cogemos el id del producto seleccionado
        _IdProductoo = dgvPedido.CurrentRow.Cells("IdProducto").Value

        'cargamos la informacion a los textbox para  que sea editada
        Me.txtCodigoProducto.Text = dgvPedido.CurrentRow.Cells("IdProducto").Value
        Me.txtProducto.Text = dgvPedido.CurrentRow.Cells("Producto").Value
        Me.txtCantidadProducto.Text = dgvPedido.CurrentRow.Cells("Cantidad").Value
        Me.txtPrecioProducto.Text = dgvPedido.CurrentRow.Cells("Precio").Value
        Me.txtDescuentoProducto.Text = dgvPedido.CurrentRow.Cells("Descuento").Value

    End Sub

End Class