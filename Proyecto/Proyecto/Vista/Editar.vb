
Public Class Editar
    Private Shared formulario As Editar
    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo Editar
    Public Shared Function GetInstance() As Editar
        If formulario Is Nothing Then
            formulario = New Editar()
        End If
        Return formulario
    End Function

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Controlador.insertar()
    End Sub
End Class