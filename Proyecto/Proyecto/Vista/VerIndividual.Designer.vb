<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerIndividual
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
        Me.tlpContenido = New System.Windows.Forms.TableLayoutPanel()
        Me.bAnterior = New System.Windows.Forms.Button()
        Me.bSiguiente = New System.Windows.Forms.Button()
        Me.vDatos = New Proyecto.VerDatos()
        Me.tlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.bEditar = New System.Windows.Forms.Button()
        Me.bVer = New System.Windows.Forms.Button()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.tlpContenido.SuspendLayout()
        Me.tlpBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpContenido
        '
        Me.tlpContenido.ColumnCount = 3
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpContenido.Controls.Add(Me.bAnterior, 0, 0)
        Me.tlpContenido.Controls.Add(Me.bSiguiente, 2, 0)
        Me.tlpContenido.Controls.Add(Me.vDatos, 1, 1)
        Me.tlpContenido.Controls.Add(Me.tlpBotones, 1, 0)
        Me.tlpContenido.Location = New System.Drawing.Point(0, 0)
        Me.tlpContenido.Name = "tlpContenido"
        Me.tlpContenido.RowCount = 2
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpContenido.Size = New System.Drawing.Size(800, 450)
        Me.tlpContenido.TabIndex = 0
        '
        'bAnterior
        '
        Me.bAnterior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bAnterior.Location = New System.Drawing.Point(3, 3)
        Me.bAnterior.Name = "bAnterior"
        Me.bAnterior.Size = New System.Drawing.Size(75, 39)
        Me.bAnterior.TabIndex = 1
        Me.bAnterior.Text = "<"
        Me.bAnterior.UseVisualStyleBackColor = True
        '
        'bSiguiente
        '
        Me.bSiguiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bSiguiente.Location = New System.Drawing.Point(722, 3)
        Me.bSiguiente.Name = "bSiguiente"
        Me.bSiguiente.Size = New System.Drawing.Size(75, 39)
        Me.bSiguiente.TabIndex = 2
        Me.bSiguiente.Text = ">"
        Me.bSiguiente.UseVisualStyleBackColor = True
        '
        'vDatos
        '
        Me.vDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vDatos.Location = New System.Drawing.Point(84, 48)
        Me.vDatos.Name = "vDatos"
        Me.vDatos.Size = New System.Drawing.Size(632, 399)
        Me.vDatos.TabIndex = 3
        '
        'tlpBotones
        '
        Me.tlpBotones.ColumnCount = 5
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpBotones.Controls.Add(Me.bEditar, 2, 0)
        Me.tlpBotones.Controls.Add(Me.bVer, 1, 0)
        Me.tlpBotones.Controls.Add(Me.bEliminar, 3, 0)
        Me.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBotones.Location = New System.Drawing.Point(84, 3)
        Me.tlpBotones.Name = "tlpBotones"
        Me.tlpBotones.RowCount = 1
        Me.tlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBotones.Size = New System.Drawing.Size(632, 39)
        Me.tlpBotones.TabIndex = 4
        '
        'bEditar
        '
        Me.bEditar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bEditar.Image = Global.Proyecto.My.Resources.Resources.ACTUALIZAR
        Me.bEditar.Location = New System.Drawing.Point(255, 3)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(120, 33)
        Me.bEditar.TabIndex = 0
        Me.bEditar.Text = "Editar"
        Me.bEditar.UseVisualStyleBackColor = True
        '
        'bVer
        '
        Me.bVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bVer.Image = Global.Proyecto.My.Resources.Resources.LEER
        Me.bVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bVer.Location = New System.Drawing.Point(129, 3)
        Me.bVer.Name = "bVer"
        Me.bVer.Size = New System.Drawing.Size(120, 33)
        Me.bVer.TabIndex = 1
        Me.bVer.Text = "Ver"
        Me.bVer.UseVisualStyleBackColor = True
        '
        'bEliminar
        '
        Me.bEliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bEliminar.Image = Global.Proyecto.My.Resources.Resources.ELIMINAR
        Me.bEliminar.Location = New System.Drawing.Point(381, 3)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bEliminar.Size = New System.Drawing.Size(120, 33)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'VerIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpContenido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerIndividual"
        Me.Text = "Ver"
        Me.tlpContenido.ResumeLayout(False)
        Me.tlpBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpContenido As TableLayoutPanel
    Friend WithEvents bAnterior As Button
    Friend WithEvents bSiguiente As Button
    Friend WithEvents tlpBotones As TableLayoutPanel
    Friend WithEvents bEditar As Button
    Friend WithEvents bEliminar As Button
    Friend WithEvents bVer As Button
    Friend WithEvents vDatos As VerDatos
End Class
