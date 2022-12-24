Public Class VerDatos
    Private Sub VerDatos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Dim tamWidith As Double = Me.Width * 260 / 500
        Dim tamFuente As Double = Me.Height * 8.25 / 350

        tamFuente = IIf(tamFuente > 16, 16, tamFuente)
        For Each element In tlpEmpleado.Controls
            'element.MinimumSize = New System.Drawing.Size(Me.Width - 35, 50)
            element.Font = New System.Drawing.Font("Segoe UI", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Next

        lPuesto.Font = New System.Drawing.Font("Segoe UI", Me.Height * 16 / 350, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'tbResultado.Width = tamWidith
        'nudOperando1.Width = tamWidith
        'nudOperando2.Width = tamWidith
    End Sub
End Class
