Public Class Ver
    Private Shared formulario As Ver
    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo Ver
    Public Shared Function GetInstance() As Ver
        If formulario Is Nothing Then
            formulario = New Ver()
        End If
        Return formulario
    End Function

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click

    End Sub
End Class