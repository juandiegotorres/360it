Public Class frmVentas
    Dim eVenta As New Entidades.Venta
    Dim tablaHistorial As New DataTable
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarHistorial()
    End Sub
    Public Sub cargarHistorial()
        tablaHistorial.Clear()
        eVenta.cargarHistorial(tablaHistorial)
        dgvHistorialVentas.DataSource = tablaHistorial
    End Sub
End Class