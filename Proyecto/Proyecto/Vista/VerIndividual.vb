Public Class VerIndividual
    Private Shared formulario As VerIndividual
    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo Ver
    Public Shared Function GetInstance() As VerIndividual
        If formulario Is Nothing Then
            formulario = New VerIndividual()
        End If
        Return formulario
    End Function

    Dim emple As Empleado

    Private Sub VerIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emple = Controlador.getPrimerEmpleado()
        actualizar()
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        'App.GetInstance().ver(emple)
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        App.GetInstance().editar(emple)
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Try
            If emple.nombre = Controlador.getUser() Then
                Throw New Exception("no puedes borrar tus datos")
            End If
            Controlador.eliminar(emple.codigo)
            MsgBox(emple.nombre + " elimiado correctamente")
            emple = Controlador.siguienteEmple()
            actualizar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bAnterior_Click(sender As Object, e As EventArgs) Handles bAnterior.Click
        emple = Controlador.anteriorEmple()
        actualizar()
    End Sub

    Private Sub bSiguiente_Click(sender As Object, e As EventArgs) Handles bSiguiente.Click
        emple = Controlador.siguienteEmple()
        actualizar()
    End Sub

    Friend Sub actualizarInit()
        emple = Controlador.getPrimerEmpleado()
        actualizar()
    End Sub

    Friend Sub actualizar()
        vDatos.lNombre.Text = emple.nombre
        vDatos.lApellido1.Text = emple.apellido1
        vDatos.lApellido2.Text = emple.apellido2
        vDatos.lEmail.Text = emple.email
        vDatos.lTelefono.Text = emple.telefono
        vDatos.lCodigo.Text = emple.codigo
    End Sub

    Private Sub bVer_MouseEnter(sender As Object, e As EventArgs) Handles bVer.MouseEnter
        bVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(88, Byte), Integer))
    End Sub

    Private Sub bVer_MouseLeave(sender As Object, e As EventArgs) Handles bVer.MouseLeave
        bVer.BackColor = Color.Transparent
    End Sub

    Private Sub bEditar_MouseEnter(sender As Object, e As EventArgs) Handles bEditar.MouseEnter
        bEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(88, Byte), Integer))
    End Sub

    Private Sub bEditar_MouseLeave(sender As Object, e As EventArgs) Handles bEditar.MouseLeave
        bEditar.BackColor = Color.Transparent
    End Sub

    Private Sub bEliminar_MouseEnter(sender As Object, e As EventArgs) Handles bEliminar.MouseEnter
        bEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(88, Byte), Integer))
    End Sub

    Private Sub bEliminar_MouseLeave(sender As Object, e As EventArgs) Handles bEliminar.MouseLeave
        bEliminar.BackColor = Color.Transparent
    End Sub

    Private Sub bAnterior_MouseEnter(sender As Object, e As EventArgs) Handles bAnterior.MouseEnter
        bAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(88, Byte), Integer))
    End Sub

    Private Sub bAnterior_MouseLeave(sender As Object, e As EventArgs) Handles bAnterior.MouseLeave
        bAnterior.BackColor = Color.Transparent
    End Sub

    Private Sub bSiguiente_MouseEnter(sender As Object, e As EventArgs) Handles bSiguiente.MouseEnter
        bSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(88, Byte), Integer))
    End Sub

    Private Sub bSiguiente_MouseLeave(sender As Object, e As EventArgs) Handles bSiguiente.MouseLeave
        bSiguiente.BackColor = Color.Transparent
    End Sub
End Class