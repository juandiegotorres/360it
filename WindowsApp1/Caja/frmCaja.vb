Public Class frmCaja
    Dim e_venta As New Entidades.Venta
    Dim total As Integer
    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtFecha.Value = Date.Now
        dtFecha.MaxDate = Date.Now
        cajaDeLaFecha()
    End Sub
    Public Sub cajaDeLaFecha()
        e_venta.total = 0
        e_venta.cajaDiaria(dtFecha.Value)
        lblEfectivo.Text = e_venta.total.ToString("C2")
    End Sub

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged
        cajaDeLaFecha()
    End Sub
End Class