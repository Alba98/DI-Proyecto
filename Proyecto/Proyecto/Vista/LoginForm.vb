Public Class LoginForm

    Private Shared formulario As LoginForm
    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo LoginForm
    Public Shared Function GetInstance() As LoginForm
        If formulario Is Nothing Then
            formulario = New LoginForm()
        End If
        Return formulario
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controlador.ConectarBBDD()
        tUsuario.Text = "aalonso"
        tClave.Text = "12345"
        formulario = Me
    End Sub

    Private Sub cbClave_CheckedChanged(sender As Object, e As EventArgs) Handles cbClave.CheckedChanged
        tClave.PasswordChar = If(cbClave.Checked, "", "*")
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        If Controlador.login(tUsuario.Text, tClave.Text) Then

        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Friend Sub Clear()
        tUsuario.Text = "Usuario"
        tClave.Text = "Clave"
    End Sub
End Class
