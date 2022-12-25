<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContenido = New System.Windows.Forms.TableLayoutPanel()
        Me.pContenido = New System.Windows.Forms.Panel()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.miEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miInsertar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAjustes = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMenuLateral = New System.Windows.Forms.ToolStripMenuItem()
        Me.miShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.miHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbVer = New System.Windows.Forms.ToolStripButton()
        Me.lSesion = New System.Windows.Forms.Label()
        Me.menuLateral = New Proyecto.Menu()
        Me.tlpPrincipal.SuspendLayout()
        Me.tlpContenido.SuspendLayout()
        Me.tlpNav.SuspendLayout()
        Me.msMenu.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpPrincipal
        '
        Me.tlpPrincipal.ColumnCount = 1
        Me.tlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.Controls.Add(Me.tlpContenido, 0, 1)
        Me.tlpPrincipal.Controls.Add(Me.tlpNav, 0, 0)
        Me.tlpPrincipal.Controls.Add(Me.lSesion, 0, 2)
        Me.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tlpPrincipal.Name = "tlpPrincipal"
        Me.tlpPrincipal.RowCount = 3
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(800, 450)
        Me.tlpPrincipal.TabIndex = 0
        '
        'tlpContenido
        '
        Me.tlpContenido.ColumnCount = 3
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.0!))
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.tlpContenido.Controls.Add(Me.pContenido, 1, 0)
        Me.tlpContenido.Controls.Add(Me.menuLateral, 0, 0)
        Me.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenido.Location = New System.Drawing.Point(3, 34)
        Me.tlpContenido.Name = "tlpContenido"
        Me.tlpContenido.RowCount = 1
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenido.Size = New System.Drawing.Size(794, 399)
        Me.tlpContenido.TabIndex = 0
        '
        'pContenido
        '
        Me.pContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContenido.Location = New System.Drawing.Point(161, 3)
        Me.pContenido.Name = "pContenido"
        Me.pContenido.Size = New System.Drawing.Size(613, 393)
        Me.pContenido.TabIndex = 1
        '
        'tlpNav
        '
        Me.tlpNav.ColumnCount = 2
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNav.Controls.Add(Me.msMenu, 0, 0)
        Me.tlpNav.Controls.Add(Me.tsMenu, 1, 0)
        Me.tlpNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNav.Location = New System.Drawing.Point(3, 3)
        Me.tlpNav.Name = "tlpNav"
        Me.tlpNav.RowCount = 1
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpNav.Size = New System.Drawing.Size(794, 25)
        Me.tlpNav.TabIndex = 1
        '
        'msMenu
        '
        Me.msMenu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEditar, Me.miVer, Me.miAjustes, Me.miSalir})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(397, 24)
        Me.msMenu.TabIndex = 3
        Me.msMenu.Text = "MenuStrip1"
        '
        'miEditar
        '
        Me.miEditar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miInsertar})
        Me.miEditar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miEditar.Name = "miEditar"
        Me.miEditar.Size = New System.Drawing.Size(56, 20)
        Me.miEditar.Text = "Editar"
        '
        'miInsertar
        '
        Me.miInsertar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miInsertar.Name = "miInsertar"
        Me.miInsertar.Size = New System.Drawing.Size(125, 22)
        Me.miInsertar.Text = "Insertar"
        '
        'miVer
        '
        Me.miVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miTodos, Me.miBuscar})
        Me.miVer.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miVer.Name = "miVer"
        Me.miVer.Size = New System.Drawing.Size(39, 20)
        Me.miVer.Text = "Ver"
        '
        'miTodos
        '
        Me.miTodos.Name = "miTodos"
        Me.miTodos.Size = New System.Drawing.Size(116, 22)
        Me.miTodos.Text = "Todos"
        '
        'miBuscar
        '
        Me.miBuscar.Name = "miBuscar"
        Me.miBuscar.Size = New System.Drawing.Size(116, 22)
        Me.miBuscar.Text = "Buscar"
        '
        'miAjustes
        '
        Me.miAjustes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miMenuLateral})
        Me.miAjustes.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miAjustes.Name = "miAjustes"
        Me.miAjustes.Size = New System.Drawing.Size(66, 20)
        Me.miAjustes.Text = "Ajustes"
        '
        'miMenuLateral
        '
        Me.miMenuLateral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miShow, Me.miHide})
        Me.miMenuLateral.Name = "miMenuLateral"
        Me.miMenuLateral.Size = New System.Drawing.Size(152, 22)
        Me.miMenuLateral.Text = "MenuLateral"
        '
        'miShow
        '
        Me.miShow.Name = "miShow"
        Me.miShow.Size = New System.Drawing.Size(109, 22)
        Me.miShow.Text = "Show"
        '
        'miHide
        '
        Me.miHide.Name = "miHide"
        Me.miHide.Size = New System.Drawing.Size(109, 22)
        Me.miHide.Text = "Hide"
        '
        'miSalir
        '
        Me.miSalir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miSalir.Name = "miSalir"
        Me.miSalir.Size = New System.Drawing.Size(46, 20)
        Me.miSalir.Text = "Salir"
        '
        'tsMenu
        '
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRegistrar, Me.tsbBuscar, Me.tsbVer})
        Me.tsMenu.Location = New System.Drawing.Point(397, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(397, 25)
        Me.tsMenu.TabIndex = 4
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbRegistrar
        '
        Me.tsbRegistrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRegistrar.Image = CType(resources.GetObject("tsbRegistrar.Image"), System.Drawing.Image)
        Me.tsbRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRegistrar.Name = "tsbRegistrar"
        Me.tsbRegistrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbRegistrar.Text = "Insertar"
        '
        'tsbBuscar
        '
        Me.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(23, 22)
        Me.tsbBuscar.Text = "Buscar"
        '
        'tsbVer
        '
        Me.tsbVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbVer.Image = CType(resources.GetObject("tsbVer.Image"), System.Drawing.Image)
        Me.tsbVer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVer.Name = "tsbVer"
        Me.tsbVer.Size = New System.Drawing.Size(23, 22)
        Me.tsbVer.Text = "Ver"
        '
        'lSesion
        '
        Me.lSesion.AutoSize = True
        Me.lSesion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lSesion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSesion.Location = New System.Drawing.Point(3, 436)
        Me.lSesion.Name = "lSesion"
        Me.lSesion.Size = New System.Drawing.Size(794, 14)
        Me.lSesion.TabIndex = 2
        Me.lSesion.Text = "Sesion: "
        '
        'menuLateral
        '
        Me.menuLateral.Location = New System.Drawing.Point(3, 3)
        Me.menuLateral.Name = "menuLateral"
        Me.menuLateral.Size = New System.Drawing.Size(152, 378)
        Me.menuLateral.TabIndex = 2
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "App"
        Me.Text = "App"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        Me.tlpContenido.ResumeLayout(False)
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents tlpContenido As TableLayoutPanel
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents msMenu As MenuStrip
    Friend WithEvents miEditar As ToolStripMenuItem
    Friend WithEvents miInsertar As ToolStripMenuItem
    Friend WithEvents miVer As ToolStripMenuItem
    Friend WithEvents miTodos As ToolStripMenuItem
    Friend WithEvents miAjustes As ToolStripMenuItem
    Friend WithEvents miMenuLateral As ToolStripMenuItem
    Friend WithEvents lSesion As Label
    Friend WithEvents miSalir As ToolStripMenuItem
    Friend WithEvents miShow As ToolStripMenuItem
    Friend WithEvents miHide As ToolStripMenuItem
    Friend WithEvents pContenido As Panel
    Friend WithEvents miBuscar As ToolStripMenuItem
    Friend WithEvents menuLateral As Menu
    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents tsbRegistrar As ToolStripButton
    Friend WithEvents tsbBuscar As ToolStripButton
    Friend WithEvents tsbVer As ToolStripButton
End Class
