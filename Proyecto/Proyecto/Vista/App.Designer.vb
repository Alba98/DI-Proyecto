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
        Me.tlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpContenido = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuLado = New Proyecto.Menu()
        Me.pContenido = New System.Windows.Forms.Panel()
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.miEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miInsertar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.miTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAjustes = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMenuLateral = New System.Windows.Forms.ToolStripMenuItem()
        Me.miShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.miHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.lSesion = New System.Windows.Forms.Label()
        Me.tlpPrincipal.SuspendLayout()
        Me.tlpContenido.SuspendLayout()
        Me.tlpNav.SuspendLayout()
        Me.msMenu.SuspendLayout()
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
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPrincipal.Size = New System.Drawing.Size(800, 450)
        Me.tlpPrincipal.TabIndex = 0
        '
        'tlpContenido
        '
        Me.tlpContenido.ColumnCount = 2
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpContenido.Controls.Add(Me.MenuLado, 0, 0)
        Me.tlpContenido.Controls.Add(Me.pContenido, 1, 0)
        Me.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenido.Location = New System.Drawing.Point(3, 43)
        Me.tlpContenido.Name = "tlpContenido"
        Me.tlpContenido.RowCount = 1
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 384.0!))
        Me.tlpContenido.Size = New System.Drawing.Size(794, 384)
        Me.tlpContenido.TabIndex = 0
        '
        'MenuLado
        '
        Me.MenuLado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuLado.Location = New System.Drawing.Point(3, 3)
        Me.MenuLado.Name = "MenuLado"
        Me.MenuLado.Size = New System.Drawing.Size(152, 378)
        Me.MenuLado.TabIndex = 0
        '
        'pContenido
        '
        Me.pContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pContenido.Location = New System.Drawing.Point(161, 3)
        Me.pContenido.Name = "pContenido"
        Me.pContenido.Size = New System.Drawing.Size(630, 378)
        Me.pContenido.TabIndex = 1
        '
        'tlpNav
        '
        Me.tlpNav.ColumnCount = 2
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNav.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpNav.Controls.Add(Me.msMenu, 0, 0)
        Me.tlpNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNav.Location = New System.Drawing.Point(3, 3)
        Me.tlpNav.Name = "tlpNav"
        Me.tlpNav.RowCount = 1
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNav.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpNav.Size = New System.Drawing.Size(794, 34)
        Me.tlpNav.TabIndex = 1
        '
        'msMenu
        '
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEditar, Me.miVer, Me.miAjustes, Me.miSalir})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(397, 24)
        Me.msMenu.TabIndex = 3
        Me.msMenu.Text = "MenuStrip1"
        '
        'miEditar
        '
        Me.miEditar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miInsertar, Me.miModificar, Me.miEliminar})
        Me.miEditar.Name = "miEditar"
        Me.miEditar.Size = New System.Drawing.Size(49, 20)
        Me.miEditar.Text = "Editar"
        '
        'miInsertar
        '
        Me.miInsertar.Name = "miInsertar"
        Me.miInsertar.Size = New System.Drawing.Size(125, 22)
        Me.miInsertar.Text = "Insertar"
        '
        'miModificar
        '
        Me.miModificar.Name = "miModificar"
        Me.miModificar.Size = New System.Drawing.Size(125, 22)
        Me.miModificar.Text = "Modificar"
        '
        'miEliminar
        '
        Me.miEliminar.Name = "miEliminar"
        Me.miEliminar.Size = New System.Drawing.Size(125, 22)
        Me.miEliminar.Text = "Eliminar"
        '
        'miVer
        '
        Me.miVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miTodos, Me.miBuscar})
        Me.miVer.Name = "miVer"
        Me.miVer.Size = New System.Drawing.Size(35, 20)
        Me.miVer.Text = "Ver"
        '
        'miTodos
        '
        Me.miTodos.Name = "miTodos"
        Me.miTodos.Size = New System.Drawing.Size(180, 22)
        Me.miTodos.Text = "Todos"
        '
        'miBuscar
        '
        Me.miBuscar.Name = "miBuscar"
        Me.miBuscar.Size = New System.Drawing.Size(180, 22)
        Me.miBuscar.Text = "Buscar"
        '
        'miAjustes
        '
        Me.miAjustes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miMenuLateral})
        Me.miAjustes.Name = "miAjustes"
        Me.miAjustes.Size = New System.Drawing.Size(57, 20)
        Me.miAjustes.Text = "Ajustes"
        '
        'miMenuLateral
        '
        Me.miMenuLateral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miShow, Me.miHide})
        Me.miMenuLateral.Name = "miMenuLateral"
        Me.miMenuLateral.Size = New System.Drawing.Size(140, 22)
        Me.miMenuLateral.Text = "MenuLateral"
        '
        'miShow
        '
        Me.miShow.Name = "miShow"
        Me.miShow.Size = New System.Drawing.Size(103, 22)
        Me.miShow.Text = "Show"
        '
        'miHide
        '
        Me.miHide.Name = "miHide"
        Me.miHide.Size = New System.Drawing.Size(103, 22)
        Me.miHide.Text = "Hide"
        '
        'miSalir
        '
        Me.miSalir.Name = "miSalir"
        Me.miSalir.Size = New System.Drawing.Size(41, 20)
        Me.miSalir.Text = "Salir"
        '
        'lSesion
        '
        Me.lSesion.AutoSize = True
        Me.lSesion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lSesion.Location = New System.Drawing.Point(3, 430)
        Me.lSesion.Name = "lSesion"
        Me.lSesion.Size = New System.Drawing.Size(794, 20)
        Me.lSesion.TabIndex = 2
        Me.lSesion.Text = "Sesion: "
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpPrincipal)
        Me.Name = "App"
        Me.Text = "App"
        Me.tlpPrincipal.ResumeLayout(False)
        Me.tlpPrincipal.PerformLayout()
        Me.tlpContenido.ResumeLayout(False)
        Me.tlpNav.ResumeLayout(False)
        Me.tlpNav.PerformLayout()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPrincipal As TableLayoutPanel
    Friend WithEvents tlpContenido As TableLayoutPanel
    Friend WithEvents tlpNav As TableLayoutPanel
    Friend WithEvents msMenu As MenuStrip
    Friend WithEvents miEditar As ToolStripMenuItem
    Friend WithEvents miInsertar As ToolStripMenuItem
    Friend WithEvents miModificar As ToolStripMenuItem
    Friend WithEvents miEliminar As ToolStripMenuItem
    Friend WithEvents miVer As ToolStripMenuItem
    Friend WithEvents miTodos As ToolStripMenuItem
    Friend WithEvents miAjustes As ToolStripMenuItem
    Friend WithEvents miMenuLateral As ToolStripMenuItem
    Friend WithEvents lSesion As Label
    Friend WithEvents MenuLado As Menu
    Friend WithEvents miSalir As ToolStripMenuItem
    Friend WithEvents miShow As ToolStripMenuItem
    Friend WithEvents miHide As ToolStripMenuItem
    Friend WithEvents pContenido As Panel
    Friend WithEvents miBuscar As ToolStripMenuItem
End Class
