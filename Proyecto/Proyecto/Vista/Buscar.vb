Imports MySql.Data.MySqlClient

Public Class Buscar
    Private Shared formulario As Buscar
    'Usamos la función Shared para poder acceder a ella sin necesidad de
    'instanciar un objeto de tipo VerDataGrid
    Public Shared Function GetInstance() As Buscar
        If formulario Is Nothing Then
            formulario = New Buscar()
        End If
        Return formulario
    End Function

    Private Sub tbBusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbBusqueda.TextChanged
        Dim cmd As New MySqlCommand("Select * from usuarios Where usuario Like Concat('%',@parm1, '%')", Controlador.getConnection())
        cmd.Parameters.AddWithValue("parm1", tbBusqueda.Text)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class