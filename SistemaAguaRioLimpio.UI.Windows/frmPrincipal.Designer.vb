<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.SubMenuAyuda = New System.Windows.Forms.Panel()
        Me.bt = New System.Windows.Forms.Button()
        Me.btnMenuAyuda = New System.Windows.Forms.Button()
        Me.SubMenuManten = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnMenuMant = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelHijo = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        Me.SubMenuAyuda.SuspendLayout()
        Me.SubMenuManten.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(752, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ArticuloToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.PedidoToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ArticuloToolStripMenuItem
        '
        Me.ArticuloToolStripMenuItem.Name = "ArticuloToolStripMenuItem"
        Me.ArticuloToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ArticuloToolStripMenuItem.Text = "Articulo"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'PedidoToolStripMenuItem
        '
        Me.PedidoToolStripMenuItem.Name = "PedidoToolStripMenuItem"
        Me.PedidoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PedidoToolStripMenuItem.Text = "Pedido"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'PanelLateral
        '
        Me.PanelLateral.AutoScroll = True
        Me.PanelLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelLateral.Controls.Add(Me.SubMenuAyuda)
        Me.PanelLateral.Controls.Add(Me.btnMenuAyuda)
        Me.PanelLateral.Controls.Add(Me.SubMenuManten)
        Me.PanelLateral.Controls.Add(Me.BtnMenuMant)
        Me.PanelLateral.Controls.Add(Me.PanelLogo)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 26)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(250, 569)
        Me.PanelLateral.TabIndex = 1
        '
        'SubMenuAyuda
        '
        Me.SubMenuAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.SubMenuAyuda.Controls.Add(Me.bt)
        Me.SubMenuAyuda.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuAyuda.Location = New System.Drawing.Point(0, 396)
        Me.SubMenuAyuda.Name = "SubMenuAyuda"
        Me.SubMenuAyuda.Size = New System.Drawing.Size(233, 175)
        Me.SubMenuAyuda.TabIndex = 5
        '
        'bt
        '
        Me.bt.Dock = System.Windows.Forms.DockStyle.Top
        Me.bt.FlatAppearance.BorderSize = 0
        Me.bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt.ForeColor = System.Drawing.Color.Gainsboro
        Me.bt.Location = New System.Drawing.Point(0, 0)
        Me.bt.Name = "bt"
        Me.bt.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.bt.Size = New System.Drawing.Size(233, 40)
        Me.bt.TabIndex = 0
        Me.bt.Text = "Preguntas Frecuentes"
        Me.bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt.UseVisualStyleBackColor = True
        '
        'btnMenuAyuda
        '
        Me.btnMenuAyuda.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuAyuda.FlatAppearance.BorderSize = 0
        Me.btnMenuAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuAyuda.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMenuAyuda.Location = New System.Drawing.Point(0, 351)
        Me.btnMenuAyuda.Name = "btnMenuAyuda"
        Me.btnMenuAyuda.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnMenuAyuda.Size = New System.Drawing.Size(233, 45)
        Me.btnMenuAyuda.TabIndex = 4
        Me.btnMenuAyuda.Text = "Ayuda"
        Me.btnMenuAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuAyuda.UseVisualStyleBackColor = True
        '
        'SubMenuManten
        '
        Me.SubMenuManten.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.SubMenuManten.Controls.Add(Me.Button4)
        Me.SubMenuManten.Controls.Add(Me.Button3)
        Me.SubMenuManten.Controls.Add(Me.Button2)
        Me.SubMenuManten.Controls.Add(Me.Button1)
        Me.SubMenuManten.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubMenuManten.Location = New System.Drawing.Point(0, 145)
        Me.SubMenuManten.Name = "SubMenuManten"
        Me.SubMenuManten.Size = New System.Drawing.Size(233, 206)
        Me.SubMenuManten.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Location = New System.Drawing.Point(0, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(233, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Producto"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3.Location = New System.Drawing.Point(0, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(233, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Pedido"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(0, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(233, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Empleado"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(233, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cliente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnMenuMant
        '
        Me.BtnMenuMant.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMenuMant.FlatAppearance.BorderSize = 0
        Me.BtnMenuMant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenuMant.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnMenuMant.Location = New System.Drawing.Point(0, 100)
        Me.BtnMenuMant.Name = "BtnMenuMant"
        Me.BtnMenuMant.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnMenuMant.Size = New System.Drawing.Size(233, 45)
        Me.BtnMenuMant.TabIndex = 1
        Me.BtnMenuMant.Text = "Mantenimiento"
        Me.BtnMenuMant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMenuMant.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(233, 100)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(75, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelHijo
        '
        Me.PanelHijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHijo.Location = New System.Drawing.Point(250, 26)
        Me.PanelHijo.Name = "PanelHijo"
        Me.PanelHijo.Size = New System.Drawing.Size(502, 569)
        Me.PanelHijo.TabIndex = 2
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 595)
        Me.Controls.Add(Me.PanelHijo)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelLateral.ResumeLayout(False)
        Me.SubMenuAyuda.ResumeLayout(False)
        Me.SubMenuManten.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticuloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents SubMenuManten As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnMenuMant As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMenuAyuda As Button
    Friend WithEvents SubMenuAyuda As Panel
    Friend WithEvents bt As Button
    Friend WithEvents PanelHijo As Panel
End Class
