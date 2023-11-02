Imports System.Data.SqlClient

Public Class Login

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUsuario.Clear()
        txtUsuario.Clear()


    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion = New SqlConnection("Data Sourse =DESKTOP-G4KT730\SQL2022; Initial Catalog =AguaRioLimpioDB; Integrated Security = true")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Open()

        Dim consulta As String = "select * from Usuarios where usuario= '" & txtUsuario.Text & "' and Contraseña'" & txtContraseña.Text & "' "
        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader

        If lector.HasRows Then

            FrmPrincipal.ShowDialog()
        Else
            MessageBox.Show("Este Usuario No Existe O Datos Incorrectos"
                            )
        End If
        conexion.Close()
    End Sub
End Class