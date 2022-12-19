Imports MySql.Data.MySqlClient

Public Class Controlador
    'Shared SQLConnection As New MySqlConnection("DataSource=localhost;port=8000;Database=db1;Username=test;Password=test;")
    'Shared SQLConnection As New MySqlConnection("server=localhost;port=8000;userid=db1;database=db1;Pwd=test;")
    Shared connStr As String = "server=localhost;user=db1;database=db1;port=8000;password=test"
    Shared SQLConnection = New MySqlConnection(connStr)
    Shared dt As New DataTable
    Shared ireturn As Boolean

    Friend Shared Sub login(usuario As String, clave As String)
        If (usuario = "aalonso") Then
            If (clave = "12345") Then
                App.Show()
                LoginForm.Close()
            End If
        End If
    End Sub

    Friend Shared Function Insertar() As Boolean

        Dim sql As String = "INSERT INTO usuarios (usuario, nombre, apellidos, email, contrasena) VALUES (@usuario, @nombre, @apellidos, @email, @contrasena)"

        Dim cmd = New MySqlCommand(sql, SQLConnection)

        cmd.Parameters.AddWithValue("@usuario", "aalonso")
        cmd.Parameters.AddWithValue("@nombre", "Alba")
        cmd.Parameters.AddWithValue("@apellidos", "Alonso Marmany")
        cmd.Parameters.AddWithValue("@email", "alba.alonso@gmail.com")
        cmd.Parameters.AddWithValue("@contrasena", "12345")

        Try
            SQLConnection.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                ireturn = True
            End If
            SQLConnection.Close()


        Catch ex As Exception
            ireturn = False
            SQLConnection.Close()
        End Try

        Return ireturn
    End Function
End Class
