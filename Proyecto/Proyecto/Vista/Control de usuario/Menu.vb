Public Class Menu
    Private Sub Menu_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Dim tamFuente As Double = Me.Height * 8.25 / 378

        'tamFuente = IIf(tamFuente > 16, 16, tamFuente)
        'For Each element In tlpMenu.Controls
        '    'element.MinimumSize = New System.Drawing.Size(Me.Width - 35, 50)
        '    element.Font = New System.Drawing.Font("Verdana", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Next
    End Sub

    ' Public Event click_buscar()
    ' Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
    '     RaiseEvent click_buscar()
    ' End Sub

    'para lanzar evento desde la vista al añadir el control programaticamente
    'AddHandler() control.clicikBoton, AddressOf click_buscar
End Class
