Imports System.Data.SqlClient
Imports SistemaAguaRioLimpio.DAL
Imports SistemaAguaRioLimpio.Entities

Public Class frmCliente
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtApellido.Clear()
        txtDireccion.Clear()
        txtFecha.Clear()
        txtTelefono.Clear()
        txtNombre.Clear()
        txtID.Clear()
        txtCedula.Clear()


    End Sub

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AguaRioLimpioDBDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.AguaRioLimpioDBDataSet.Cliente)


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim cliente As New ClienteEntity()
        ' Obtener los valores de los TextBox



        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim cedula As String = txtCedula.Text
        Dim direccion As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim fecha As Date = Date.Parse(txtFecha.Text)

        ' Llamar al método AgregarCliente en la clase ClienteDAL
        clienteDAL.create(cliente)

        ' Actualizar el DataGridView para reflejar los cambios

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim cliente As New ClienteEntity()

        ' Obtener el ID del cliente a actualizar


        ' Obtener los nuevos valores de los TextBox
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim cedula As String = txtCedula.Text
        Dim direccion As String = txtDireccion.Text
        Dim telefono As String = txtTelefono.Text
        Dim fecha As Date = Date.Parse(txtFecha.Text)

        ClienteDAL.Update(cliente)

    End Sub

    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click

    End Sub
End Class