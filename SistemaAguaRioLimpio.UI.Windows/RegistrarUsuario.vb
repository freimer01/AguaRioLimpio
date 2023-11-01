Imports System.Data.SqlClient

Public Class RegistrarUsuario
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click


        ' Recopila los datos ingresados por el usuario
        Dim nombreUsuario As String = txtUsuario.Text
        Dim contraseña As String = txtContraseña.Text

        ' Define la cadena de conexión a tu base de datos SQL Server
        Dim connectionString As String = "Data Sourse =DESKTOP-G4KT730\SQL2022; Initial Catalog =AguaRioLimpioDB; Integrated Security = true"

        ' Define la consulta SQL para insertar los datos en la base de datos
        Dim query As String = "INSERT INTO Usuarios (Usuario, Contraseña) VALUES (@Usuario, @Contraseña)"

        ' Establece la conexión a la base de datos y ejecuta la consulta
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Agrega los parámetros a la consulta
                command.Parameters.AddWithValue("@Usuario", nombreUsuario)
                command.Parameters.AddWithValue("@Contraseña", contraseña)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()

                    ' Muestra un mensaje de éxito y cierra el formulario de registro
                    MessageBox.Show("Registro exitoso. Puede iniciar sesión con su nuevo usuario y contraseña.")
                    Me.Close()
                Catch ex As Exception
                    ' En caso de error, muestra un mensaje de error
                    MessageBox.Show("Ocurrió un error durante el registro. Inténtelo de nuevo.")
                End Try
                ' Luego de un registro exitoso
                MessageBox.Show("Registro exitoso. Puede iniciar sesión con su nuevo usuario y contraseña.")
                Me.Close() ' Cierra el formulario de registro
                Login.Show() ' Abre el formulario de inicio de sesión
            End Using
        End Using
    End Sub

End Class