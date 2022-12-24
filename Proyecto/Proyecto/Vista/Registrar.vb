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

    Private Sub Registrar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim tamFuente As Double = Me.Height * 10 / 450

        tamFuente = IIf(tamFuente > 16, 16, tamFuente)
        lTituloRegistrar.Font = New System.Drawing.Font("Verdana", tamFuente, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bGuardar.Font = New System.Drawing.Font("Verdana", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bVaciar.Font = New System.Drawing.Font("Verdana", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


    End Sub
End Class