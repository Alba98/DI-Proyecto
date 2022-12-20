﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Controlador
    Shared SQLConnection As MySqlConnection
    Shared dt As New DataTable
    Shared ireturn As Boolean

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

            MsgBox("Conexión establecida correctamente")

        Catch ex As MySqlException
            MsgBox("Error al conectarse a la BD", MsgBoxStyle.Critical)
        End Try
    End Sub

    Friend Shared Function login(usuario As String, clave As String) As Boolean

        Dim sql As String = "SELECT clave FROM usuarios WHERE usuario = @usuario"
        Dim cmd As New MySqlCommand(sql, SQLConnection)
        cmd.Parameters.AddWithValue("@usuario", usuario)

        Dim rd As MySqlDataReader = cmd.ExecuteReader
        Dim claveBD As String
        If rd.Read Then
            claveBD = rd.GetString(0)
            If (clave = claveBD) Then
                'App.Show()
                'LoginForm.Close()
                rd.Close()
                Return True
            End If
        Else
            rd.Close()
            Return False
        End If



        'If (usuario = "aalonso") Then
        '    If (clave = "12345") Then
        '        App.Show()
        '        LoginForm.Close()
        '    End If
        'End If
    End Function

    Friend Shared Function insertar() As Boolean
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

    Shared vConn As MySqlConnection


End Class
