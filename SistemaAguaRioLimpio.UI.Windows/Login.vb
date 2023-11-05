Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUsuario.Clear()
        txtContraseña.Clear()


    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("Server =DESKTOP-G4KT730\SQL2022; Initial Catalog =AguaRioLimpioDB; Integrated Security = true")




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        conexion.Open()
        Dim consulta As String = "SELECT * FROM Usuarios WHERE Usuario= '" & txtUsuario.Text & "' and Contraseña= '" & txtContraseña.Text & "'"

        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader

        If lector.HasRows Then
            MessageBox.Show("Inicio de sesión exitoso.")
            ' Cierra el formulario de inicio de sesión

            FrmPrincipal.Show() ' Abre el formulario principal
            Me.Close()
        Else
            MessageBox.Show("Este Usuario no existe o los datos son incorrectos.")
        End If
        conexion.Close()
    End Sub

End Class