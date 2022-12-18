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
        Me.cbActivo = New System.Windows.Forms.CheckBox()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lApellidos = New System.Windows.Forms.Label()
        Me.lEmail = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.tlpEmpleado.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpEmpleado
        '
        Me.tlpEmpleado.ColumnCount = 5
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpEmpleado.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEmpleado.Controls.Add(Me.lPuesto, 0, 1)
        Me.tlpEmpleado.Controls.Add(Me.cbActivo, 1, 5)
        Me.tlpEmpleado.Controls.Add(Me.pbFoto, 1, 2)
        Me.tlpEmpleado.Controls.Add(Me.lNombre, 3, 2)
        Me.tlpEmpleado.Controls.Add(Me.lApellidos, 3, 3)
        Me.tlpEmpleado.Controls.Add(Me.lEmail, 3, 4)
        Me.tlpEmpleado.Controls.Add(Me.pbLogo, 3, 5)
        Me.tlpEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.tlpEmpleado.Name = "tlpEmpleado"
        Me.tlpEmpleado.RowCount = 7
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpEmpleado.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpEmpleado.Size = New System.Drawing.Size(500, 350)
        Me.tlpEmpleado.TabIndex = 0
        '
        'lPuesto
        '
        Me.lPuesto.AutoSize = True
        Me.lPuesto.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tlpEmpleado.SetColumnSpan(Me.lPuesto, 5)
        Me.lPuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lPuesto.Location = New System.Drawing.Point(3, 20)
        Me.lPuesto.Name = "lPuesto"
        Me.lPuesto.Size = New System.Drawing.Size(494, 62)
        Me.lPuesto.TabIndex = 0
        Me.lPuesto.Text = "PUESTO"
        Me.lPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbActivo
        '
        Me.cbActivo.AutoSize = True
        Me.cbActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbActivo.Location = New System.Drawing.Point(23, 271)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.Size = New System.Drawing.Size(214, 56)
        Me.cbActivo.TabIndex = 1
        Me.cbActivo.Text = "Activo"
        Me.cbActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbActivo.UseVisualStyleBackColor = True
        '
        'pbFoto
        '
        Me.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbFoto.Location = New System.Drawing.Point(23, 85)
        Me.pbFoto.Name = "pbFoto"
        Me.tlpEmpleado.SetRowSpan(Me.pbFoto, 3)
        Me.pbFoto.Size = New System.Drawing.Size(214, 180)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto.TabIndex = 2
        Me.pbFoto.TabStop = False
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lNombre.Location = New System.Drawing.Point(263, 82)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(214, 62)
        Me.lNombre.TabIndex = 3
        Me.lNombre.Text = "Nombre"
        Me.lNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lApellidos
        '
        Me.lApellidos.AutoSize = True
        Me.lApellidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lApellidos.Location = New System.Drawing.Point(263, 144)
        Me.lApellidos.Name = "lApellidos"
        Me.lApellidos.Size = New System.Drawing.Size(214, 62)
        Me.lApellidos.TabIndex = 4
        Me.lApellidos.Text = "Apellidos"
        Me.lApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lEmail
        '
        Me.lEmail.AutoSize = True
        Me.lEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lEmail.Location = New System.Drawing.Point(263, 206)
        Me.lEmail.Name = "lEmail"
        Me.lEmail.Size = New System.Drawing.Size(214, 62)
        Me.lEmail.TabIndex = 5
        Me.lEmail.Text = "Email"
        Me.lEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbLogo
        '
        Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbLogo.Location = New System.Drawing.Point(263, 271)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(214, 56)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 6
        Me.pbLogo.TabStop = False
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "ofdFoto"
        '
        'VerEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpEmpleado)
        Me.Name = "VerEmpleado"
        Me.Size = New System.Drawing.Size(500, 350)
        Me.tlpEmpleado.ResumeLayout(False)
        Me.tlpEmpleado.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpEmpleado As TableLayoutPanel
    Friend WithEvents lPuesto As Label
    Friend WithEvents cbActivo As CheckBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents lNombre As Label
    Friend WithEvents lApellidos As Label
    Friend WithEvents lEmail As Label
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents pbLogo As PictureBox
End Class
