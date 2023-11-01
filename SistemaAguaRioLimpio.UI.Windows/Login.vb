Imports System.Data.SqlClient

Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUsuario.Clear()
        txtUsuario.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuarioIngresado As String = txtUsuario.Text
        Dim contrasenaIngresada As String = txtContraseña.Text

        ' Establece la cadena de conexión a tu base de datos SQL Server
        Dim m_CadenaConexion As String = "Data Sourse =DESKTOP-G4KT730\SQL2022; Initial Catalog =AguaRioLimpioDB; Integrated Security = true"

        ' Realiza la consulta SQL para verificar las credenciales
        Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contrasena"

        Using connection As New SqlConnection(m_CadenaConexion)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Usuario", usuarioIngresado)
                command.Parameters.AddWithValue("@Contrasena", contrasenaIngresada)

                connection.Open()

                Dim resultado As Integer = CInt(command.ExecuteScalar())

                If resultado > 0 Then
                    ' Las credenciales son válidas, puedes abrir el formulario principal
                    Dim formularioPrincipal As New FrmPrincipal()
                    formularioPrincipal.Show()
                    Me.Hide() ' Oculta el formulario de inicio de sesión
                Else
                    ' Las credenciales son incorrectas, mostrar un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.")
                End If
            End Using
        End Using
    End Sub
End Class