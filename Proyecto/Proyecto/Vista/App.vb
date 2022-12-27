Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class App
    Private Shared formulario As App

    Dim insertar As Registrar
    Dim modificar As Editar
    Dim ver As VerIndividual
    Dim buscarDG As Buscar

    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo App
    Public Shared Function GetInstance() As App
        If formulario Is Nothing Then
            formulario = New App()
        End If
        Return formulario
    End Function

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lSesion.Text = "Sesion: " + Controlador.getUser()
        menuLateral.Hide()
        tlpContenido.ColumnStyles(0).Width = 2
    End Sub

    Private Sub CargarFormulario(formulario As Form)
        'Borra los controles que pudiera haber en el Panel
        pContenido.Controls.Clear()

        'El formulario que queremos cargar no sera de nivel superior
        formulario.TopLevel = False

        'Añadimos el formulario a los controles del Panel
        pContenido.Controls.Add(formulario)

        formulario.Dock = System.Windows.Forms.DockStyle.Fill
        'Muestra el formulario
        formulario.Show()
    End Sub

    Public Sub QuitarFormulario()
        'Borra los controles que pudiera haber en el Panel
        pContenido.Controls.Clear()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miSalir.Click
        Controlador.VolverLogin()
    End Sub

    Private Sub miShow_Click(sender As Object, e As EventArgs) Handles miShow.Click
        menuLateral.Show()
        tlpContenido.ColumnStyles(0).SizeType = SizeType.Percent
        tlpContenido.ColumnStyles(0).Width = 20
        tlpContenido.ColumnStyles(1).Width = 80
    End Sub

    Private Sub miHide_Click(sender As Object, e As EventArgs) Handles miHide.Click
        'menuLateral.Hide()
        'tlpContenido.ColumnStyles(0).Width = 2
    End Sub

    Private Sub miInsertar_Click(sender As Object, e As EventArgs) Handles miInsertar.Click
        insertar = insertar.GetInstance()

        CargarFormulario(insertar)
    End Sub

    Private Sub miModificar_Click(sender As Object, e As EventArgs)
        modificar = modificar.GetInstance()

        CargarFormulario(modificar)
    End Sub

    Private Sub miTodos_Click(sender As Object, e As EventArgs) Handles miTodos.Click
        Controlador.getEmpleados()
        ver = ver.GetInstance()
        ver.actualizarInit()

        CargarFormulario(ver)
    End Sub

    Private Sub miBuscar_Click(sender As Object, e As EventArgs) Handles miBuscar.Click
        buscarDG = buscarDG.GetInstance()

        CargarFormulario(buscarDG)
    End Sub

    Friend Sub editar(emple As Empleado)
        modificar = modificar.GetInstance()
        modificar.emple = emple

        CargarFormulario(modificar)
    End Sub

    Private Sub App_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Dim tamFuente As Double = Me.Height * 8.25 / 489

        'tamFuente = IIf(tamFuente > 16, 16, tamFuente)
        'For Each element In tlpPrincipal.Controls
        '    element.Font = New System.Drawing.Font("Verdana", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Next
    End Sub

    Private Sub tsbRegistrar_Click(sender As Object, e As EventArgs) Handles tsbRegistrar.Click
        insertar = insertar.GetInstance()
        CargarFormulario(insertar)
    End Sub

    Private Sub tsbBuscar_Click(sender As Object, e As EventArgs) Handles tsbBuscar.Click
        buscarDG = buscarDG.GetInstance()
        CargarFormulario(buscarDG)
    End Sub

    Private Sub tsbVer_Click(sender As Object, e As EventArgs) Handles tsbVer.Click
        ver = ver.GetInstance()
        ver.actualizarInit()
        CargarFormulario(ver)
    End Sub

    'Private Sub mlBuscar_Click(sender As Object, e As EventArgs) Handles menuLateral.bBuscar.Click
    '    buscarDG = buscarDG.GetInstance()
    '    CargarFormulario(buscarDG)
    'End Sub

End Class