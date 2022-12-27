Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DatosEmpleado
    Private Sub DatosEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCBPuesto()
    End Sub

    Private Sub cargarCBPuesto()
        Dim dt = Controlador.getPuestos()
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                cbPuesto.Items.Add(dt.Rows(i)(0))
            Next
        End If
    End Sub

    Public Sub Vaciar()
        'For Each c As Control In Me.Controls
        '    If TypeOf (c) Is TextBox Then
        '        Dim tb As TextBox = c
        '        tb.Clear()
        '    End If
        '    If TypeOf (c) Is ComboBox Then
        '        Dim cb As ComboBox = c
        '        cb.SelectedIndex = 0
        '    End If
        '    If TypeOf (c) Is DateTimePicker Then
        '        Dim dtp As DateTimePicker = c
        '        dtp.Value = DateTime.Today
        '    End If
        'Next
        tbNombre.Clear()
        tbApellido1.Clear()
        tbApellido2.Clear()
        tbEmail.Clear()
        tbTelefono.Clear()
        tbContraseña.Clear()
        dtpFecha.Value = DateTime.Today
        cbPuesto.SelectedIndex = -1
        tbNombre.Focus()
    End Sub

    Public Sub validarDatos()
        If String.IsNullOrEmpty(tbNombre.Text) Then
            Throw New System.Exception("Nombre no puede estar vacio")
        End If
        If String.IsNullOrEmpty(tbApellido1.Text) Then
            Throw New System.Exception("Primer apellido no puede estar vacio")
        End If
        If String.IsNullOrEmpty(tbApellido2.Text) Then
            Throw New System.Exception("Segundo Apellido no puede estar vacio")
        End If
        If String.IsNullOrEmpty(tbEmail.Text) Then
            'formato email
            Dim regEmail As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
            If regEmail.IsMatch(tbEmail.Text) Then
                Throw New System.Exception("Email en formato incorrecto")
            End If
            Throw New System.Exception("Email no puede estar vacio")
        End If
        If String.IsNullOrEmpty(tbTelefono.Text) Then
            'formato numeros
            If Not IsNumeric(tbTelefono.Text) Then
                Throw New System.Exception("Telefono tienen que ser numeros")
            End If
            If Not tbTelefono.Text.Length = 9 Then
                Throw New System.Exception("Telefono son 9 numeros")
            End If
            Throw New System.Exception("Telefono no puede estar vacio")
        End If
        If String.IsNullOrEmpty(tbContraseña.Text) Then
            Throw New System.Exception("Clave no puede estar vacio")
        End If

        If dtpFecha.Value = DateTime.Today Then
            Throw New System.Exception("Fecha tiene que ser anterior a hoy")
        End If

        If Me.cbPuesto.SelectedIndex = -1 Then
            Throw New System.Exception("Puesto no puede estar vacio")
        End If
    End Sub

    Public Sub cargarDatos(nombre As String, apellido1 As String, apellido2 As String, email As String, telefono As String,
                               clave As String, fecha_nacimiento As Date, puesto As Integer)
        cargarCBPuesto()
        tbNombre.Text = nombre
        tbApellido1.Text = apellido1
        tbApellido2.Text = apellido2
        tbEmail.Text = email
        tbTelefono.Text = telefono
        tbContraseña.Text = clave
        dtpFecha.Value = fecha_nacimiento
        cbPuesto.SelectedIndex = puesto
        tbNombre.Focus()
    End Sub

    Private Sub DatosEmpleado_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim tamFuente As Double = tlpDatos.Height * 8.25 / 278

        tamFuente = IIf(tamFuente > 16, 16, tamFuente)
        For Each element In tlpDatos.Controls
            'element.MinimumSize = New System.Drawing.Size(Me.Width - 35, 50)
            element.Font = New System.Drawing.Font("Verdana", tamFuente, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Next
    End Sub
End Class
