﻿Public Class frmDetalles
    Public e_Venta As New Entidades.Venta

    Public Sub cargarProductos()
        Dim tablaProductos As New DataTable
        e_Venta.ventaXproductos(tablaProductos)
        dgvProductos.DataSource = tablaProductos
    End Sub

    Private Sub frmDetalles_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.Close()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub frmDetalles_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtIDVenta.Text = e_Venta.idVenta
        e_Venta.descuento = 0
        e_Venta.recargo = 0
        e_Venta.detalleHistorialVenta()
        cargarProductos()
        txtFecha.Text = e_Venta.fechaHora
        txtFormaPago.Text = e_Venta.formPago
        If e_Venta.tipoDescuentoRecargo = "S" Then
            txtDescuento.Text = 0
            txtRecargo.Text = 0
        ElseIf e_Venta.tipoDescuentoRecargo = "P" Then
            If e_Venta.recargo > 0 Then
                txtRecargo.Text = "%" & e_Venta.recargo
            Else
                txtDescuento.Text = "%" & e_Venta.descuento
            End If
        ElseIf e_Venta.tipoDescuentoRecargo = "D" Then
            If e_Venta.recargo > 0 Then
                txtRecargo.Text = "$" & e_Venta.recargo
            Else
                txtDescuento.Text = "$" & e_Venta.descuento
            End If
        End If
        txtSubtotal.Text = e_Venta.precioInicial.ToString("C2")
        txtTotal.Text = e_Venta.precioFinal.ToString("C2")
    End Sub
End Class