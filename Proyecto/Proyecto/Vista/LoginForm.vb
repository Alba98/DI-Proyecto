Public Class LoginForm
    Private Sub cbClave_CheckedChanged(sender As Object, e As EventArgs) Handles cbClave.CheckedChanged
        'If (cbClave.Checked) Then
        '    tClave.PasswordChar = ""
        'End If

        tClave.PasswordChar = If(cbClave.Checked, "", "*")

    End Sub

    Private Sub bAceptar_Click(sender As Object, e As EventArgs) Handles bAceptar.Click
        Controlador.login(tUsuario.Text, tClave.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub
End Class
