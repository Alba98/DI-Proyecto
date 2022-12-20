Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controlador.ConectarBBDD()
        tUsuario.Text = "aalonso"
        tClave.Text = "12345"
    End Sub

    Private Sub cbClave_CheckedChanged(sender As Object, e As EventArgs) Handles cbClave.CheckedChanged
        tClave.PasswordChar = If(cbClave.Checked, "", "*")
    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        If Controlador.login(tUsuario.Text, tClave.Text) Then
            App.Show()
            Me.Close()
        End If
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub
End Class
