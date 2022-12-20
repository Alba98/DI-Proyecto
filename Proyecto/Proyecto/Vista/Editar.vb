
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

    Private Sub Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'https://www.youtube.com/watch?v=dEEkaz3WE_c
    End Sub
End Class