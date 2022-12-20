Public Class Registrar
    Private Shared formulario As Registrar
    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo Registrar
    Public Shared Function GetInstance() As Registrar
        If formulario Is Nothing Then
            formulario = New Registrar()
        End If
        Return formulario
    End Function

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

    End Sub
End Class