
Public Class Editar
    Public Property emple As Empleado
    Private Shared formulario As Editar

    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo Editar
    Public Shared Function GetInstance() As Editar
        If formulario Is Nothing Then
            formulario = New Editar()
        End If
        Return formulario
    End Function

    Private Sub Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Activated

        Me.dEditar.cargarDatos(emple.nombre, emple.apellido1, emple.apellido2, emple.email, emple.telefono,
                               emple.clave, emple.fecha_nacimiento, emple.puesto)
    End Sub

    Private Sub bVaciar_Click(sender As Object, e As EventArgs) Handles bVaciar.Click
        Me.dEditar.Vaciar()
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        Try
            dEditar.validarDatos()
            Dim actualizado = Controlador.actualizar(emple.codigo, dEditar.tbNombre.Text, dEditar.tbApellido1.Text,
                     dEditar.tbApellido2.Text, dEditar.tbEmail.Text, dEditar.tbTelefono.Text, dEditar.tbContraseña.Text,
                     dEditar.dtpFecha.Value, dEditar.cbPuesto.SelectedIndex + 1)

            If actualizado Then
                MsgBox(dEditar.tbNombre.Text + " actualizado correctamente")
                dEditar.Vaciar()
                App.GetInstance().QuitarFormulario()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bActualizar_MouseEnter(sender As Object, e As EventArgs) Handles bActualizar.MouseEnter
        bActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(88, Byte), Integer))
    End Sub

    Private Sub bActualizar_MouseLeave(sender As Object, e As EventArgs) Handles bActualizar.MouseLeave
        bActualizar.BackColor = Color.Transparent
    End Sub

    Private Sub bVaciar_MouseEnter(sender As Object, e As EventArgs) Handles bVaciar.MouseEnter
        bVaciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(88, Byte), Integer))
    End Sub

    Private Sub bVaciar_MouseLeave(sender As Object, e As EventArgs) Handles bVaciar.MouseLeave
        bVaciar.BackColor = Color.Transparent
    End Sub


End Class