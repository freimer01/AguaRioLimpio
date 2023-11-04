Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()

    End Sub

    Private Sub hideSubMenu()
        SubMenuManten.Visible = False
        SubMenuAyuda.Visible = False


    End Sub
    Private Sub MostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True

        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenuMant.Click
        MostrarSubMenu(SubMenuManten)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCliente.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmEmpleado.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmPedido.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub btbMenuAyuda_Click(sender As Object, e As EventArgs) Handles btnMenuAyuda.Click
        MostrarSubMenu(SubMenuAyuda)
    End Sub

    Private Sub btnPreguntas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt_Click(sender As Object, e As EventArgs) Handles bt.Click
        frmPreguntas.ShowDialog()
    End Sub
End Class