<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.tlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bRegistrar = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.lSesion = New System.Windows.Forms.Label()
        Me.tlpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMenu
        '
        Me.tlpMenu.ColumnCount = 3
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMenu.Controls.Add(Me.bModificar, 1, 2)
        Me.tlpMenu.Controls.Add(Me.bRegistrar, 1, 1)
        Me.tlpMenu.Controls.Add(Me.bEliminar, 1, 3)
        Me.tlpMenu.Controls.Add(Me.bBuscar, 1, 4)
        Me.tlpMenu.Controls.Add(Me.bSalir, 1, 6)
        Me.tlpMenu.Controls.Add(Me.lSesion, 1, 8)
        Me.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.RowCount = 10
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMenu.Size = New System.Drawing.Size(184, 473)
        Me.tlpMenu.TabIndex = 0
        '
        'bModificar
        '
        Me.bModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bModificar.Location = New System.Drawing.Point(23, 98)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(138, 49)
        Me.bModificar.TabIndex = 1
        Me.bModificar.Text = "Modificar"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'bRegistrar
        '
        Me.bRegistrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bRegistrar.Location = New System.Drawing.Point(23, 43)
        Me.bRegistrar.Name = "bRegistrar"
        Me.bRegistrar.Size = New System.Drawing.Size(138, 49)
        Me.bRegistrar.TabIndex = 2
        Me.bRegistrar.Text = "Registrar"
        Me.bRegistrar.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bEliminar.Location = New System.Drawing.Point(23, 153)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(138, 49)
        Me.bEliminar.TabIndex = 3
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bBuscar.Location = New System.Drawing.Point(23, 208)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(138, 49)
        Me.bBuscar.TabIndex = 4
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bSalir.Location = New System.Drawing.Point(23, 361)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(138, 49)
        Me.bSalir.TabIndex = 5
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'lSesion
        '
        Me.lSesion.AutoSize = True
        Me.lSesion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lSesion.Location = New System.Drawing.Point(23, 433)
        Me.lSesion.Name = "lSesion"
        Me.lSesion.Size = New System.Drawing.Size(138, 20)
        Me.lSesion.TabIndex = 6
        Me.lSesion.Text = "Sesion:"
        Me.lSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpMenu)
        Me.Name = "Menu"
        Me.Size = New System.Drawing.Size(184, 473)
        Me.tlpMenu.ResumeLayout(False)
        Me.tlpMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMenu As TableLayoutPanel
    Friend WithEvents bModificar As Button
    Friend WithEvents bRegistrar As Button
    Friend WithEvents bEliminar As Button
    Friend WithEvents bBuscar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents lSesion As Label
End Class
