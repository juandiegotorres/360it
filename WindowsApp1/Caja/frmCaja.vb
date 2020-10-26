Public Class frmCaja
    Dim e_venta As New Entidades.Venta
    Dim total As Integer
    Dim totalEfectivo As Integer
    Dim tablaClientesCtaCorriente As New DataTable
    Dim tablaMovimientos As New DataTable
    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtFecha.Value = Date.Now
        dtFecha.MaxDate = Date.Now
        cajaCtaCorriente()
        cajaDeLaFecha()
        cajaMovimientos()
        calcularTotal()
        Dim tbL As TableLayoutPanel
        For Each tbL In TableLayoutPanel5.Controls
            tbL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            tbL.BackColor = Color.FromArgb(240, 240, 240)
        Next
        TableLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        TableLayoutPanel5.BackColor = Color.FromArgb(255, 156, 0)

    End Sub
    Public Sub calcularTotal()
        total = 0
        total = e_venta.total + e_venta.totalCtaCorriente + e_venta.totalMovimientos
        lblTotal.Text = total.ToString("C2")
    End Sub
    Public Sub cajaCtaCorriente()
        tablaClientesCtaCorriente.Clear()
        e_venta.totalCtaCorriente = 0
        e_venta.cajaDiariaCtaCorriente(tablaClientesCtaCorriente, dtFecha.Value)
        dgvClientesCtaCorriente.DataSource = tablaClientesCtaCorriente
        lblCtaCorriente.Text = e_venta.totalCtaCorriente.ToString("C2")
    End Sub
    Public Sub cajaMovimientos()
        tablaMovimientos.Clear()
        e_venta.totalMovimientos = 0
        e_venta.movimientosDia(tablaMovimientos, dtFecha.Value)
        dgvCajaMovimientos.DataSource = tablaMovimientos
        lblMovimientos.Text = e_venta.totalMovimientos.ToString("C2")
    End Sub
    Public Sub cajaDeLaFecha()
        totalEfectivo = 0
        e_venta.total = 0
        e_venta.cajaDiaria(dtFecha.Value)
        totalEfectivo = e_venta.total - e_venta.totalCtaCorriente
        lblEfectivo.Text = totalEfectivo.ToString("C2")
    End Sub

    Private Sub dtFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtFecha.ValueChanged
        cajaCtaCorriente()
        cajaDeLaFecha()
        cajaMovimientos()
        calcularTotal()
    End Sub
End Class