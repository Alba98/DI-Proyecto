Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient

Public Class Controlador
    Private Shared SQLConnection As MySqlConnection
    Private Shared dt As New DataTable
    Private Shared ireturn As Boolean

    Private Shared usuario As String

    Shared Property empleados As List(Of Empleado)
    Private Shared currIndex As Integer = 0

    Friend Shared Function getUser() As String
        Return usuario
    End Function

    Friend Shared Sub VolverLogin()
        App.GetInstance().Hide()
        LoginForm.GetInstance().Clear()
        App.GetInstance().Close()

        LoginForm.GetInstance().ShowDialog()
    End Sub

    Friend Shared Function getConnection() As MySqlConnection
        Return SQLConnection
    End Function

    Friend Shared Sub ConectarBBDD()
        Try
            ' Crear un objeto de tipo ConnectionString
            Dim vConnString As New MySqlConnectionStringBuilder
            vConnString.Server = "localhost"
            vConnString.Database = "db1"
            vConnString.UserID = "db1"
            vConnString.Password = "test"
            vConnString.IntegratedSecurity = False

            ' Usar ese objeto para conectarnos
            SQLConnection = New MySqlConnection(vConnString.ToString)
            SQLConnection.Open()

            'MsgBox("Conexión establecida correctamente")

        Catch ex As MySqlException
            MsgBox("Error al conectarse a la BD", MsgBoxStyle.Critical)
        End Try
    End Sub

    Friend Shared Function login(email As String, clave As String) As Boolean
        Dim sql As String = "SELECT clave, nombre FROM EMPLEADOS WHERE email = @email"
        Dim cmd As New MySqlCommand(sql, SQLConnection)
        cmd.Parameters.AddWithValue("@email", email)

        Dim rd As MySqlDataReader = cmd.ExecuteReader
        Dim claveBD As String
        If rd.Read() Then
            claveBD = rd("clave")
            If (clave = claveBD) Then
                Controlador.usuario = rd("nombre")
                rd.Close()

                LoginForm.GetInstance().Hide()
                If (App.GetInstance().Created()) Then
                    App.GetInstance().Close()
                End If
                App.GetInstance().ShowDialog()

                LoginForm.GetInstance().Close()

                Return True
            Else
                rd.Close()
            End If
        End If
        rd.Close()
        Return False
    End Function

    Friend Shared Function insertar(nombre As String, apellido1 As String, apellido2 As String, email As String, telefono As String,
                               clave As String, fecha_nacimiento As Date, puesto As Integer)
        Dim sql As String = "INSERT INTO EMPLEADOS (nombre, apellido1, apellido2, email, fecha_nacimiento, telefono, puesto, clave) VALUES (@nombre, @apellido1, @apellido2, @email, @fecha_nacimiento, @telefono, @puesto, @clave)"

        Dim cmd = New MySqlCommand(sql, SQLConnection)

        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@apellido1", apellido1)
        cmd.Parameters.AddWithValue("@apellido2", apellido2)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento)
        cmd.Parameters.AddWithValue("@telefono", telefono)
        cmd.Parameters.AddWithValue("@puesto", puesto + 1)
        cmd.Parameters.AddWithValue("@clave", clave)

        Try
            'SQLConnection.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                ireturn = True
            End If
            'SQLConnection.Close()

        Catch ex As Exception
            ireturn = False
            MsgBox(ex.Message)
            'SQLConnection.Close()
        End Try

        Return ireturn
    End Function

    Friend Shared Function actualizar(id As Integer, nombre As String, apellido1 As String, apellido2 As String, email As String, telefono As String,
                               clave As String, fecha_nacimiento As Date, puesto As Integer)
        Dim sql As String = "UPDATE EMPLEADOS SET nombre=@nombre, apellido1=@apellido1, apellido2=@apellido2, email=@email,
                            fecha_nacimiento=@fecha_nacimiento, telefono=@telefono, puesto=@puesto, clave=@clave 
                            WHERE codigo=@id"

        Dim cmd = New MySqlCommand(sql, SQLConnection)

        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@apellido1", apellido1)
        cmd.Parameters.AddWithValue("@apellido2", apellido2)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento)
        cmd.Parameters.AddWithValue("@telefono", telefono)
        cmd.Parameters.AddWithValue("@puesto", puesto)
        cmd.Parameters.AddWithValue("@clave", clave)
        cmd.Parameters.AddWithValue("@id", id)

        Try
            'SQLConnection.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                ireturn = True
            End If
            'SQLConnection.Close()

        Catch ex As Exception
            ireturn = False
            MsgBox(ex.Message)
            'SQLConnection.Close()
        End Try

        Return ireturn
    End Function

    Friend Shared Function getPuestos() As DataTable
        Dim cmd As New MySqlCommand("Select nombre from PUESTO", SQLConnection)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Friend Shared Function getEmpleado(idEmpleado As Integer) As Empleado
        Dim sql As String = "SELECT * FROM EMPLEADOS WHERE codigo = @id"
        Dim cmd As New MySqlCommand(sql, SQLConnection)
        cmd.Parameters.AddWithValue("@id", idEmpleado)

        Dim rd As MySqlDataReader = cmd.ExecuteReader
        Dim empleado = New Empleado()
        If rd.Read() Then
            empleado.codigo = rd("codigo")
            empleado.nombre = rd("nombre")
            empleado.apellido1 = rd("apellido1")
            empleado.apellido2 = rd("apellido2")
            empleado.email = rd("email")
            empleado.fecha_nacimiento = rd("fecha_nacimiento")
            empleado.telefono = rd("telefono")
            empleado.clave = rd("clave")
        End If
        rd.Close()
        Return empleado
    End Function

    Friend Shared Sub eliminar(codEmple As Integer)
        Dim sql As String = "DELETE FROM EMPLEADOS WHERE codigo = @codEmple"
        Dim cmd As New MySqlCommand(sql, SQLConnection)
        cmd.Parameters.AddWithValue("@codEmple", codEmple)

        If cmd.ExecuteNonQuery() > 0 Then
            getEmpleados()
        End If
    End Sub

    Friend Shared Sub getEmpleados()
        Dim sql As String = "SELECT * FROM EMPLEADOS"
        Dim cmd As New MySqlCommand(sql, SQLConnection)

        Dim rd As MySqlDataReader = cmd.ExecuteReader
        empleados = New List(Of Empleado)
        While rd.Read()
            Dim empleado = New Empleado()
            empleado.codigo = rd("codigo")
            empleado.nombre = rd("nombre")
            empleado.apellido1 = rd("apellido1")
            empleado.apellido2 = rd("apellido2")
            empleado.email = rd("email")
            empleado.fecha_nacimiento = rd("fecha_nacimiento")
            empleado.telefono = rd("telefono")
            empleado.clave = rd("clave")
            empleados.Add(empleado)
        End While
        rd.Close()
    End Sub

    Friend Shared Function siguienteEmple() As Empleado
        currIndex = If(currIndex + 1 = empleados.Count, currIndex, currIndex + 1)
        Return empleados(currIndex)
    End Function

    Friend Shared Function anteriorEmple() As Empleado
        currIndex = If(currIndex = 0, currIndex, currIndex - 1)
        Return empleados(currIndex)
    End Function

    Friend Shared Function getPrimerEmpleado() As Empleado
        currIndex = 0
        getEmpleados()
        Return empleados(currIndex)
    End Function

    Friend Shared Sub EditarEmple(Cod As Integer)
        App.GetInstance().QuitarFormulario()
        getEmpleados()
        App.GetInstance().editar(BuscarPorCod(Cod))
    End Sub
    Private Shared Function BuscarPorCod(Cod As Integer) As Empleado
        Return empleados.Find(Function(emple) emple.codigo = Cod)
        'Return empleados.Find(Function(emple As Empleado) emple.codigo = Cod)
    End Function
End Class
