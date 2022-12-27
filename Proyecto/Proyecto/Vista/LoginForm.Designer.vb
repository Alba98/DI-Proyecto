<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.tlpLogin = New System.Windows.Forms.TableLayoutPanel()
        Me.lTitulo = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.tClave = New System.Windows.Forms.TextBox()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.cbClave = New System.Windows.Forms.CheckBox()
        Me.tlpLogin.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLogin
        '
        Me.tlpLogin.ColumnCount = 5
        Me.tlpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpLogin.Controls.Add(Me.lTitulo, 1, 3)
        Me.tlpLogin.Controls.Add(Me.pbLogo, 1, 1)
        Me.tlpLogin.Controls.Add(Me.tUsuario, 1, 5)
        Me.tlpLogin.Controls.Add(Me.tClave, 1, 7)
        Me.tlpLogin.Controls.Add(Me.bAceptar, 1, 9)
        Me.tlpLogin.Controls.Add(Me.bSalir, 2, 9)
        Me.tlpLogin.Controls.Add(Me.cbClave, 3, 7)
        Me.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLogin.Location = New System.Drawing.Point(0, 0)
        Me.tlpLogin.Name = "tlpLogin"
        Me.tlpLogin.RowCount = 11
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLogin.Size = New System.Drawing.Size(400, 450)
        Me.tlpLogin.TabIndex = 0
        '
        'lTitulo
        '
        Me.lTitulo.AutoSize = True
        Me.tlpLogin.SetColumnSpan(Me.lTitulo, 2)
        Me.lTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lTitulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitulo.Location = New System.Drawing.Point(98, 231)
        Me.lTitulo.Name = "lTitulo"
        Me.lTitulo.Size = New System.Drawing.Size(184, 13)
        Me.lTitulo.TabIndex = 0
        Me.lTitulo.Text = "LOGIN"
        Me.lTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLogo
        '
        Me.tlpLogin.SetColumnSpan(Me.pbLogo, 2)
        Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbLogo.Image = Global.Proyecto.My.Resources.Resources.company_employee1
        Me.pbLogo.Location = New System.Drawing.Point(98, 43)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(184, 165)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'tUsuario
        '
        Me.tlpLogin.SetColumnSpan(Me.tUsuario, 2)
        Me.tUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tUsuario.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsuario.Location = New System.Drawing.Point(98, 267)
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(184, 21)
        Me.tUsuario.TabIndex = 2
        Me.tUsuario.Text = "Email"
        '
        'tClave
        '
        Me.tlpLogin.SetColumnSpan(Me.tClave, 2)
        Me.tClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tClave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tClave.Location = New System.Drawing.Point(98, 314)
        Me.tClave.Name = "tClave"
        Me.tClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tClave.Size = New System.Drawing.Size(184, 21)
        Me.tClave.TabIndex = 3
        Me.tClave.Text = "Contraseña"
        '
        'bAceptar
        '
        Me.bAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.Location = New System.Drawing.Point(98, 361)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(89, 46)
        Me.bAceptar.TabIndex = 4
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bSalir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.Location = New System.Drawing.Point(193, 361)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(89, 46)
        Me.bSalir.TabIndex = 5
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'cbClave
        '
        Me.cbClave.AutoSize = True
        Me.cbClave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbClave.Location = New System.Drawing.Point(288, 314)
        Me.cbClave.Name = "cbClave"
        Me.cbClave.Size = New System.Drawing.Size(14, 21)
        Me.cbClave.TabIndex = 6
        Me.cbClave.Text = "CheckBox1"
        Me.cbClave.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.tlpLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.tlpLogin.ResumeLayout(False)
        Me.tlpLogin.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLogin As TableLayoutPanel
    Friend WithEvents lTitulo As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents tClave As TextBox
    Friend WithEvents bAceptar As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents cbClave As CheckBox
End Class
