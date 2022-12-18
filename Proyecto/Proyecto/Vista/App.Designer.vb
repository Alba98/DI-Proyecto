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
        Me.tlpNav = New System.Windows.Forms.TableLayoutPanel()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuLateralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuLado.Location = New System.Drawing.Point(3, 3)
        Me.MenuLado.Name = "MenuLado"
        Me.MenuLado.Size = New System.Drawing.Size(152, 378)
        Me.MenuLado.TabIndex = 0
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
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.AjustesToolStripMenuItem})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(397, 24)
        Me.msMenu.TabIndex = 3
        Me.msMenu.Text = "MenuStrip1"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.InsertarToolStripMenuItem.Text = "Insertar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuLateralToolStripMenuItem})
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        Me.AjustesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.AjustesToolStripMenuItem.Text = "Ajustes"
        '
        'MenuLateralToolStripMenuItem
        '
        Me.MenuLateralToolStripMenuItem.Name = "MenuLateralToolStripMenuItem"
        Me.MenuLateralToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.MenuLateralToolStripMenuItem.Text = "MenuLateral"
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
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuLateralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lSesion As Label
    Friend WithEvents MenuLado As Menu
End Class
