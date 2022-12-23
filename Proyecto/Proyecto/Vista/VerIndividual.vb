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
        loadData()
    End Sub

    Private Sub loadData()
        emple = Controlador.getEmpleado(1)
        vDatos.lNombre.Text = emple.nombre
        vDatos.lApellido1.Text = emple.apellido1
        vDatos.lApellido2.Text = emple.apellido2
        vDatos.lEmail.Text = emple.email
        vDatos.lTelefono.Text = emple.telefono
        vDatos.lCodigo.Text = ""
    End Sub

    Private Sub bVer_Click(sender As Object, e As EventArgs) Handles bVer.Click
        'App.GetInstance().ver(emple)
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        App.GetInstance().editar(emple)
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        'App.GetInstance().eliminar(emple)
    End Sub

    Private Sub bAnterior_Click(sender As Object, e As EventArgs) Handles bAnterior.Click

    End Sub

    Private Sub bSiguiente_Click(sender As Object, e As EventArgs) Handles bSiguiente.Click

    End Sub

    Friend Sub actualizar()
        loadData()
    End Sub
End Class