Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Controlador
    Shared SQLConnection As MySqlConnection
    Shared dt As New DataTable
    Shared ireturn As Boolean

    Dim loginWindow As LoginForm
    Dim appWindow As App

    Shared usuario As String

    Friend Shared Sub ConectarBBDD()
        Try
            ' Ejecutan las instrucciones dento del Try
            ' En caso que alguna de ellas se ejecute con un error, entonces, se pasa automáticamente a la sección "Catch" que es quien atrapa el error

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

    Friend Shared Function login(usuario As String, clave As String) As Boolean

        Dim sql As String = "SELECT clave FROM EMPLEADOS WHERE nombre = @nombre"
        Dim cmd As New MySqlCommand(sql, SQLConnection)
        cmd.Parameters.AddWithValue("@nombre", usuario)

        Dim rd As MySqlDataReader = cmd.ExecuteReader
        Dim claveBD As String
        If rd.Read Then
            claveBD = rd.GetString(0)
            If (clave = claveBD) Then
                Controlador.usuario = usuario
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

    Friend Shared Function insertarUsuario() As Boolean
        Dim sql As String = "INSERT INTO usuarios (usuario, nombre, apellidos, email, contrasena) VALUES (@usuario, @nombre, @apellidos, @email, @contrasena)"

        Dim cmd = New MySqlCommand(sql, SQLConnection)

        cmd.Parameters.AddWithValue("@usuario", "aalonso")
        cmd.Parameters.AddWithValue("@nombre", "Alba")
        cmd.Parameters.AddWithValue("@apellidos", "Alonso Marmany")
        cmd.Parameters.AddWithValue("@email", "alba.alonso@gmail.com")
        cmd.Parameters.AddWithValue("@contrasena", "12345")

        Try
            'SQLConnection.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                ireturn = True
            End If
            'SQLConnection.Close()


        Catch ex As Exception
            ireturn = False
            'SQLConnection.Close()
        End Try

        Return ireturn
    End Function

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
End Class
