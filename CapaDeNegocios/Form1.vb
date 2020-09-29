Public Class Form1
    Dim a As New cdDatosPrueba
    Dim c As New List(Of Clientes)
    ''Dim consultaSQL As String = "Select * from vistaclientes"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        a.lllenarDatos(c, "Select * from vistaclientes")
        DataGridView1.DataSource = c
    End Sub
End Class