<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDatos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.tlpEmpleado = New System.Windows.Forms.TableLayoutPanel()
        Me.lPuesto = New System.Windows.Forms.Label()
        Me.lApellido2 = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lApellido1 = New System.Windows.Forms.Label()
        Me.lEmail = New System.Windows.Forms.Label()
        Me.lCodigo = New System.Windows.Forms.Label()
        Me.tlpEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpEmpleado
        '
        Me.tlpEmpleado.ColumnCount = 5
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826!))
        Me.tlpEmpleado.Controls.Add(Me.lPuesto, 0, 1)
        Me.tlpEmpleado.Controls.Add(Me.lApellido2, 3, 3)
        Me.tlpEmpleado.Controls.Add(Me.lTelefono, 3, 4)
        Me.tlpEmpleado.Controls.Add(Me.lNombre, 1, 2)
        Me.tlpEmpleado.Controls.Add(Me.lApellido1, 1, 3)
        Me.tlpEmpleado.Controls.Add(Me.lEmail, 1, 4)
        Me.tlpEmpleado.Controls.Add(Me.lCodigo, 3, 2)
        Me.tlpEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.tlpEmpleado.Name = "tlpEmpleado"
        Me.tlpEmpleado.RowCount = 6
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.545455!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.545455!))
        Me.tlpEmpleado.Size = New System.Drawing.Size(391, 278)
        Me.tlpEmpleado.TabIndex = 0
        '
        'lPuesto
        '
        Me.lPuesto.AutoSize = True
        Me.lPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.tlpEmpleado.SetColumnSpan(Me.lPuesto, 5)
        Me.lPuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lPuesto.Location = New System.Drawing.Point(3, 12)
        Me.lPuesto.Name = "lPuesto"
        Me.lPuesto.Size = New System.Drawing.Size(385, 63)
        Me.lPuesto.TabIndex = 0
        Me.lPuesto.Text = "PUESTO"
        Me.lPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lApellido2
        '
        Me.lApellido2.AutoSize = True
        Me.lApellido2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lApellido2.Location = New System.Drawing.Point(207, 138)
        Me.lApellido2.Name = "lApellido2"
        Me.lApellido2.Size = New System.Drawing.Size(164, 63)
        Me.lApellido2.TabIndex = 4
        Me.lApellido2.Text = "Apellido 2"
        Me.lApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTelefono.Location = New System.Drawing.Point(207, 201)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(164, 63)
        Me.lTelefono.TabIndex = 5
        Me.lTelefono.Text = "Telefono"
        Me.lTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNombre.Location = New System.Drawing.Point(20, 75)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(164, 63)
        Me.lNombre.TabIndex = 7
        Me.lNombre.Text = "Nombre"
        Me.lNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lApellido1
        '
        Me.lApellido1.AutoSize = True
        Me.lApellido1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lApellido1.Location = New System.Drawing.Point(20, 138)
        Me.lApellido1.Name = "lApellido1"
        Me.lApellido1.Size = New System.Drawing.Size(164, 63)
        Me.lApellido1.TabIndex = 8
        Me.lApellido1.Text = "Apellido 1"
        Me.lApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lEmail.Location = New System.Drawing.Point(20, 201)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(164, 63)
        Me.lEmail.TabIndex = 9
        Me.lEmail.Text = "Email"
        Me.lEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lCodigo
        '
        Me.lCodigo.AutoSize = True
        Me.lCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lCodigo.Location = New System.Drawing.Point(207, 75)
        Me.lCodigo.Name = "lCodigo"
        Me.lCodigo.Size = New System.Drawing.Size(164, 63)
        Me.lCodigo.TabIndex = 10
        Me.lCodigo.Text = "Codigo"
        Me.lCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VerDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.tlpEmpleado)
        Me.Name = "VerDatos"
        Me.Size = New System.Drawing.Size(391, 278)
        Me.tlpEmpleado.ResumeLayout(False)
        Me.tlpEmpleado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpEmpleado As TableLayoutPanel
    Friend WithEvents lPuesto As Label
    Friend WithEvents lNombre As Label
    Friend WithEvents lApellido1 As Label
    Friend WithEvents lEmail As Label
    Friend WithEvents lApellido2 As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents lCodigo As Label
End Class
