Public Class VerDatos
    Private Sub VerDatos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim tamFuente As Double = Me.Height * 8.25 / 350

        tamFuente = IIf(tamFuente > 16, 16, tamFuente)
        For Each element In tlpEmpleado.Controls
            element.Font = New System.Drawing.Font("Verdana", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Next

        lPuesto.Font = New System.Drawing.Font("Verdana", Me.Height * 16 / 350, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
End Class
