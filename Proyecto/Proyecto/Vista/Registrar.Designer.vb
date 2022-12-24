<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
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
        Me.tplPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTitulo = New System.Windows.Forms.TableLayoutPanel()
        Me.lTituloRegistrar = New System.Windows.Forms.Label()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bVaciar = New System.Windows.Forms.Button()
        Me.dRegistrar = New Proyecto.DatosEmpleado()
        Me.tplPrincipal.SuspendLayout()
        Me.tlpTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplPrincipal
        '
        Me.tplPrincipal.ColumnCount = 1
        Me.tplPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplPrincipal.Controls.Add(Me.tlpTitulo, 0, 0)
        Me.tplPrincipal.Controls.Add(Me.dRegistrar, 0, 1)
        Me.tplPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tplPrincipal.Name = "tplPrincipal"
        Me.tplPrincipal.RowCount = 2
        Me.tplPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tplPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tplPrincipal.Size = New System.Drawing.Size(800, 450)
        Me.tplPrincipal.TabIndex = 0
        '
        'tlpTitulo
        '
        Me.tlpTitulo.ColumnCount = 3
        Me.tlpTitulo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTitulo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTitulo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpTitulo.Controls.Add(Me.lTituloRegistrar, 0, 0)
        Me.tlpTitulo.Controls.Add(Me.bGuardar, 1, 0)
        Me.tlpTitulo.Controls.Add(Me.bVaciar, 2, 0)
        Me.tlpTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTitulo.Location = New System.Drawing.Point(3, 3)
        Me.tlpTitulo.Name = "tlpTitulo"
        Me.tlpTitulo.RowCount = 1
        Me.tlpTitulo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTitulo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.tlpTitulo.Size = New System.Drawing.Size(794, 39)
        Me.tlpTitulo.TabIndex = 1
        '
        'lTituloRegistrar
        '
        Me.lTituloRegistrar.AutoSize = True
        Me.lTituloRegistrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTituloRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTituloRegistrar.Location = New System.Drawing.Point(3, 0)
        Me.lTituloRegistrar.Name = "lTituloRegistrar"
        Me.lTituloRegistrar.Size = New System.Drawing.Size(391, 39)
        Me.lTituloRegistrar.TabIndex = 0
        Me.lTituloRegistrar.Text = "REGISTRAR"
        Me.lTituloRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bGuardar
        '
        Me.bGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGuardar.Location = New System.Drawing.Point(400, 3)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(192, 33)
        Me.bGuardar.TabIndex = 1
        Me.bGuardar.Text = "Guardar"
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'bVaciar
        '
        Me.bVaciar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bVaciar.Location = New System.Drawing.Point(598, 3)
        Me.bVaciar.Name = "bVaciar"
        Me.bVaciar.Size = New System.Drawing.Size(193, 33)
        Me.bVaciar.TabIndex = 2
        Me.bVaciar.Text = "Vaciar"
        Me.bVaciar.UseVisualStyleBackColor = True
        '
        'dRegistrar
        '
        Me.dRegistrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dRegistrar.Location = New System.Drawing.Point(3, 48)
        Me.dRegistrar.Name = "dRegistrar"
        Me.dRegistrar.Size = New System.Drawing.Size(794, 399)
        Me.dRegistrar.TabIndex = 2
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tplPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrar"
        Me.Text = "Registrar"
        Me.tplPrincipal.ResumeLayout(False)
        Me.tlpTitulo.ResumeLayout(False)
        Me.tlpTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tplPrincipal As TableLayoutPanel
    Friend WithEvents tlpTitulo As TableLayoutPanel
    Friend WithEvents lTituloRegistrar As Label
    Friend WithEvents bGuardar As Button
    Friend WithEvents bVaciar As Button
    Friend WithEvents dRegistrar As DatosEmpleado
End Class
