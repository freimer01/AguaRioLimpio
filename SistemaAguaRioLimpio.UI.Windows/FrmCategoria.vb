Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports SistemaAguaRioLimpio.BLL
Imports SistemaAguaRioLimpio.Entities

Public Class frmCategoria


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        InicialControles()
    End Sub

    Private Sub InicialControles()
        Me.txtID.Text = "0"
        Me.txtNombre.Clear()
        Me.dgvCategoria.AutoGenerateColumns = False
        Me.dgvCategoria.DataSource = CategoriaBLL.GetAll()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '1. Antes de guardar validar los datos'
        If Not ValidarDatos() Then
            Exit Sub
        End If
        '2. pasar los datos de los controles a un objetos'
        Dim oCategoria As New CategoriaEntity
        oCategoria.IdCategoria = Me.txtID.Text
        oCategoria.Nombre = Me.txtNombre.Text
        '3. mandamos a guardar el objeto creado a la base de datos'
        Try
            CategoriaBLL.Save(oCategoria)
            MessageBox.Show("Categoria guardada.", "Sistema Agua Rio Limpio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InicialControles()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema Agua Rio Limpio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function ValidarDatos() As Boolean
        Dim resultado As Boolean = True

        'Inicializar los mensajes de las validaciones '

        ErrorProvider.Clear()

        'Verificar que en los campos obligadorios haya datos'

        If String.IsNullOrEmpty(txtNombre.Text) Then
            ErrorProvider.SetError(txtNombre, "El Nombres es obligatoio")
            resultado = False
        End If

        Return resultado

    End Function

    Private Sub bntCancelar_Click(sender As Object, e As EventArgs) Handles bntCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ' En el evento TextChanged de un TextBox:

        Dim patronValido As String = "^[a-zA-Z0-9]+$"
        Dim regex As New Regex(patronValido)
        Dim textoIngresado As String = txtNombre.Text

        If Not regex.IsMatch(textoIngresado) Then
            MessageBox.Show("Caracteres no válidos. Solo se permiten letras y números.")
            ' Puedes borrar el texto no válido o tomar otras medidas según tus requisitos.
            txtNombre.Text = String.Empty
        End If



    End Sub

    Private Sub dgvCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategoria.CellContentClick

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub
End Class