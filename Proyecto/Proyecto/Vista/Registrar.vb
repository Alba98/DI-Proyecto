Imports Org.BouncyCastle.Asn1.Crmf

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
        Try
            dRegistrar.validarDatos()

            Dim insertado = Controlador.insertar(dRegistrar.tbNombre.Text, dRegistrar.tbApellido1.Text, dRegistrar.tbApellido2.Text, dRegistrar.tbEmail.Text,
                     dRegistrar.tbTelefono.Text, dRegistrar.tbContraseña.Text, dRegistrar.dtpFecha.Value, dRegistrar.cbPuesto.SelectedIndex)

            If insertado Then
                MsgBox(dRegistrar.tbNombre.Text + " insertado correctamente")
                dRegistrar.Vaciar()
                App.GetInstance().QuitarFormulario()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bVaciar_Click(sender As Object, e As EventArgs) Handles bVaciar.Click
        dRegistrar.Vaciar()
    End Sub
End Class