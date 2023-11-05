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
        AbrirFormHijo(New frmCliente)
        frmCliente.ShowDialog()
        hideSubMenu()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormHijo(New frmEmpleado)
        frmEmpleado.ShowDialog()
        hideSubMenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormHijo(New frmPedido)
        frmPedido.ShowDialog()
        hideSubMenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        hideSubMenu()
    End Sub

    Private Sub btbMenuAyuda_Click(sender As Object, e As EventArgs) Handles btnMenuAyuda.Click
        MostrarSubMenu(SubMenuAyuda)
    End Sub

    Private Sub btnPreguntas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bt_Click(sender As Object, e As EventArgs) Handles bt.Click
        AbrirFormHijo(New frmPreguntas)
        frmPreguntas.ShowDialog()
        hideSubMenu()
    End Sub

    Private FormActual As Form = Nothing
    Private Sub AbrirFormHijo(FormHijo As Form)
        If FormActual IsNot Nothing Then FormActual.Close()
        FormActual = FormHijo
        FormHijo.TopLevel = False
        FormHijo.FormBorderStyle = FormBorderStyle.None
        FormHijo.Dock = DockStyle.Fill
        PanelHijo.Controls.Add(FormHijo)
        PanelHijo.Tag = FormHijo
        FormHijo.BringToFront()
        FormHijo.Show()



    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class