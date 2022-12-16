<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosEmpleado
    Inherits System.Windows.Forms.UserControl

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
        Me.tlpDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lApellido1 = New System.Windows.Forms.Label()
        Me.lApellido2 = New System.Windows.Forms.Label()
        Me.lEmail = New System.Windows.Forms.Label()
        Me.lFechaNacimiento = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.lPuesto = New System.Windows.Forms.Label()
        Me.lClave = New System.Windows.Forms.Label()
        Me.cbGenerarClave = New System.Windows.Forms.CheckBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido1 = New System.Windows.Forms.TextBox()
        Me.tbApellido2 = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.cbPuesto = New System.Windows.Forms.ComboBox()
        Me.mcFechaNacimiento = New System.Windows.Forms.MonthCalendar()
        Me.tlpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpDatos
        '
        Me.tlpDatos.ColumnCount = 8
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00001!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpDatos.Controls.Add(Me.lNombre, 1, 1)
        Me.tlpDatos.Controls.Add(Me.lApellido1, 1, 2)
        Me.tlpDatos.Controls.Add(Me.lApellido2, 1, 3)
        Me.tlpDatos.Controls.Add(Me.lEmail, 1, 4)
        Me.tlpDatos.Controls.Add(Me.lFechaNacimiento, 4, 1)
        Me.tlpDatos.Controls.Add(Me.lTelefono, 4, 2)
        Me.tlpDatos.Controls.Add(Me.lPuesto, 4, 3)
        Me.tlpDatos.Controls.Add(Me.lClave, 4, 4)
        Me.tlpDatos.Controls.Add(Me.cbGenerarClave, 6, 4)
        Me.tlpDatos.Controls.Add(Me.tbNombre, 2, 1)
        Me.tlpDatos.Controls.Add(Me.tbApellido1, 2, 2)
        Me.tlpDatos.Controls.Add(Me.tbApellido2, 2, 3)
        Me.tlpDatos.Controls.Add(Me.tbDireccion, 2, 4)
        Me.tlpDatos.Controls.Add(Me.tbTelefono, 5, 2)
        Me.tlpDatos.Controls.Add(Me.tbContraseña, 5, 4)
        Me.tlpDatos.Controls.Add(Me.cbPuesto, 5, 3)
        Me.tlpDatos.Controls.Add(Me.mcFechaNacimiento, 5, 1)
        Me.tlpDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDatos.Location = New System.Drawing.Point(0, 0)
        Me.tlpDatos.Name = "tlpDatos"
        Me.tlpDatos.RowCount = 6
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDatos.Size = New System.Drawing.Size(800, 450)
        Me.tlpDatos.TabIndex = 0
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNombre.Location = New System.Drawing.Point(23, 20)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(172, 102)
        Me.lNombre.TabIndex = 0
        Me.lNombre.Text = "Nombre"
        '
        'lApellido1
        '
        Me.lApellido1.AutoSize = True
        Me.lApellido1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lApellido1.Location = New System.Drawing.Point(23, 122)
        Me.lApellido1.Name = "lApellido1"
        Me.lApellido1.Size = New System.Drawing.Size(172, 102)
        Me.lApellido1.TabIndex = 1
        Me.lApellido1.Text = "Primer Apellido"
        '
        'lApellido2
        '
        Me.lApellido2.AutoSize = True
        Me.lApellido2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lApellido2.Location = New System.Drawing.Point(23, 224)
        Me.lApellido2.Name = "lApellido2"
        Me.lApellido2.Size = New System.Drawing.Size(172, 102)
        Me.lApellido2.TabIndex = 2
        Me.lApellido2.Text = "Segundo Apellido"
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lEmail.Location = New System.Drawing.Point(23, 326)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(172, 102)
        Me.lEmail.TabIndex = 3
        Me.lEmail.Text = "Email"
        '
        'lFechaNacimiento
        '
        Me.lFechaNacimiento.AutoSize = True
        Me.lFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFechaNacimiento.Location = New System.Drawing.Point(399, 20)
        Me.lFechaNacimiento.Name = "lFechaNacimiento"
        Me.lFechaNacimiento.Size = New System.Drawing.Size(172, 102)
        Me.lFechaNacimiento.TabIndex = 4
        Me.lFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTelefono.Location = New System.Drawing.Point(399, 122)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(172, 102)
        Me.lTelefono.TabIndex = 5
        Me.lTelefono.Text = "Telefono"
        '
        'lPuesto
        '
        Me.lPuesto.AutoSize = True
        Me.lPuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lPuesto.Location = New System.Drawing.Point(399, 224)
        Me.lPuesto.Name = "lPuesto"
        Me.lPuesto.Size = New System.Drawing.Size(172, 102)
        Me.lPuesto.TabIndex = 6
        Me.lPuesto.Text = "Puesto"
        '
        'lClave
        '
        Me.lClave.AutoSize = True
        Me.lClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lClave.Location = New System.Drawing.Point(399, 326)
        Me.lClave.Name = "lClave"
        Me.lClave.Size = New System.Drawing.Size(172, 102)
        Me.lClave.TabIndex = 7
        Me.lClave.Text = "Contraseña"
        '
        'cbGenerarClave
        '
        Me.cbGenerarClave.AutoSize = True
        Me.cbGenerarClave.Location = New System.Drawing.Point(755, 329)
        Me.cbGenerarClave.Name = "cbGenerarClave"
        Me.cbGenerarClave.Size = New System.Drawing.Size(14, 17)
        Me.cbGenerarClave.TabIndex = 8
        Me.cbGenerarClave.Text = "CheckBox1"
        Me.cbGenerarClave.UseVisualStyleBackColor = True
        '
        'tbNombre
        '
        Me.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNombre.Location = New System.Drawing.Point(201, 23)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(172, 20)
        Me.tbNombre.TabIndex = 9
        '
        'tbApellido1
        '
        Me.tbApellido1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbApellido1.Location = New System.Drawing.Point(201, 125)
        Me.tbApellido1.Name = "tbApellido1"
        Me.tbApellido1.Size = New System.Drawing.Size(172, 20)
        Me.tbApellido1.TabIndex = 10
        '
        'tbApellido2
        '
        Me.tbApellido2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbApellido2.Location = New System.Drawing.Point(201, 227)
        Me.tbApellido2.Name = "tbApellido2"
        Me.tbApellido2.Size = New System.Drawing.Size(172, 20)
        Me.tbApellido2.TabIndex = 11
        '
        'tbDireccion
        '
        Me.tbDireccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDireccion.Location = New System.Drawing.Point(201, 329)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(172, 20)
        Me.tbDireccion.TabIndex = 12
        '
        'tbTelefono
        '
        Me.tbTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTelefono.Location = New System.Drawing.Point(577, 125)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(172, 20)
        Me.tbTelefono.TabIndex = 14
        '
        'tbContraseña
        '
        Me.tbContraseña.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbContraseña.Location = New System.Drawing.Point(577, 329)
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.Size = New System.Drawing.Size(172, 20)
        Me.tbContraseña.TabIndex = 15
        '
        'cbPuesto
        '
        Me.cbPuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbPuesto.FormattingEnabled = True
        Me.cbPuesto.Location = New System.Drawing.Point(577, 227)
        Me.cbPuesto.Name = "cbPuesto"
        Me.cbPuesto.Size = New System.Drawing.Size(172, 21)
        Me.cbPuesto.TabIndex = 16
        '
        'mcFechaNacimiento
        '
        Me.mcFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mcFechaNacimiento.Location = New System.Drawing.Point(583, 29)
        Me.mcFechaNacimiento.Name = "mcFechaNacimiento"
        Me.mcFechaNacimiento.TabIndex = 17
        '
        'DatosEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpDatos)
        Me.Name = "DatosEmpleado"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.tlpDatos.ResumeLayout(False)
        Me.tlpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpDatos As TableLayoutPanel
    Friend WithEvents lNombre As Label
    Friend WithEvents lApellido1 As Label
    Friend WithEvents lApellido2 As Label
    Friend WithEvents lEmail As Label
    Friend WithEvents lFechaNacimiento As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents lPuesto As Label
    Friend WithEvents lClave As Label
    Friend WithEvents cbGenerarClave As CheckBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido1 As TextBox
    Friend WithEvents tbApellido2 As TextBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbContraseña As TextBox
    Friend WithEvents cbPuesto As ComboBox
    Friend WithEvents mcFechaNacimiento As MonthCalendar
End Class