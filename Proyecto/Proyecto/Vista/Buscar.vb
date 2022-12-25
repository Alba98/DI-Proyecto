Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
        Dim cmd As New MySqlCommand("Select * from EMPLEADOS Where NOMBRE Like Concat('%',@nombre, '%')", Controlador.getConnection())
        cmd.Parameters.AddWithValue("nombre", tbBusqueda.Text)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i, j As Integer
        i = DataGridView1.CurrentRow.Index
        Dim id As Integer = DataGridView1.Item(0, i).Value

        Controlador.EditarEmple(id)

    End Sub

    Private Sub lTituloModificar_Click(sender As Object, e As EventArgs) Handles lTituloModificar.Click

    End Sub
End Class