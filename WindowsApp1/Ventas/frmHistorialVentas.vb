Public Class frmHistorialVentas
    Dim eVenta As New Entidades.Venta
    Dim tablaHistorial, tablaHistorialCtaCorriente As New DataTable
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarHistorial()
        cargarHistorialCtaCorriente()
        rbVenta.Checked = True
    End Sub
    Public Sub cargarHistorial()
        tablaHistorial.Clear()
        eVenta.cargarHistorial(tablaHistorial)
        dgvHistorialVentas.DataSource = tablaHistorial
        TableLayoutPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    End Sub
    Public Sub cargarHistorialCtaCorriente()
        tablaHistorialCtaCorriente.Clear()
        eVenta.cargarHistorialCtaCorriente(tablaHistorialCtaCorriente)
        dgvHistCtaCorriente.DataSource = tablaHistorialCtaCorriente
        TableLayoutPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    End Sub



    Private Sub btnBuscarFecha_Click(sender As Object, e As EventArgs) Handles btnBuscarFecha.Click
        If dtpDesde.Value.Date.ToString = dtpHasta.Value.Date.ToString Then
            MsgBox("La fechas no pueden ser iguales", MsgBoxStyle.Critical, "Reporte Alquiler")
        ElseIf (DateTime.Compare(dtpDesde.Value, dtpHasta.Value) > 0) Then
            MsgBox("La fecha de incio no puede ser mayor que la del final", MsgBoxStyle.Critical, "Reporte Alquiler")
            dtpDesde.Value = Today
        ElseIf rbVenta.Checked = True Then
            tablaHistorial.Clear()
            eVenta.ventaPorFechas(tablaHistorial, dtpDesde.Value, dtpHasta.Value)
            dgvHistorialVentas.DataSource = tablaHistorial
            btnResetear.Visible = True
            If tablaHistorial.Rows.Count = 0 Then
                MsgBox("No hay registro de esta fecha", MsgBoxStyle.Information, "Reporte Alquiler")
                cargarHistorial()
            End If
        ElseIf rbCtaCorriente.Checked = True Then
            tablaHistorialCtaCorriente.Clear()
            eVenta.ventaCtaCorrientePorFechas(tablaHistorialCtaCorriente, dtpDesde.Value, dtpHasta.Value)
            dgvHistCtaCorriente.DataSource = tablaHistorialCtaCorriente
            btnResetear.Visible = True
            If tablaHistorialCtaCorriente.Rows.Count = 0 Then
                MsgBox("No hay registro de esta fecha", MsgBoxStyle.Information, "Reporte Alquiler")
                cargarHistorialCtaCorriente()
            End If
        ElseIf rbAmbos.Checked = True Then
            tablaHistorial.Clear()
            eVenta.ventaPorFechas(tablaHistorial, dtpDesde.Value, dtpHasta.Value)
            dgvHistorialVentas.DataSource = tablaHistorial
            btnResetear.Visible = True
            If tablaHistorial.Rows.Count = 0 Then
                MsgBox("No hay registro de venta esta fecha", MsgBoxStyle.Information, "Reporte Alquiler")
                cargarHistorial()
            End If
            tablaHistorialCtaCorriente.Clear()
            eVenta.ventaCtaCorrientePorFechas(tablaHistorialCtaCorriente, dtpDesde.Value, dtpHasta.Value)
            dgvHistCtaCorriente.DataSource = tablaHistorialCtaCorriente
            btnResetear.Visible = True
            If tablaHistorialCtaCorriente.Rows.Count = 0 Then
                MsgBox("No hay registro de venta a cuenta corriente de esta fecha", MsgBoxStyle.Information, "Reporte Alquiler")
                cargarHistorialCtaCorriente()
            End If
        End If
    End Sub

    Private Sub btnResetear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnResetear.LinkClicked
        tablaHistorial.Clear()
        tablaHistorialCtaCorriente.Clear()
        cargarHistorial()
        cargarHistorialCtaCorriente()
        btnResetear.Visible = False
    End Sub


    Private Sub btnDetalleVenta_Click(sender As Object, e As EventArgs) Handles btnDetalleVenta.Click
        Dim detalleVenta As New frmDetalleVentaCtaCorriente
        With detalleVenta
            If dgvHistorialVentas.SelectedRows.Count = 1 Then
                .e_Venta.idVenta = dgvHistorialVentas.CurrentRow.Cells("idVenta").Value
                .ShowDialog()
            End If
            If dgvHistCtaCorriente.SelectedRows.Count = 1 Then
                .e_Venta.idVenta = dgvHistCtaCorriente.CurrentRow.Cells("idVentaCta").Value
                .ShowDialog()
            End If
        End With
    End Sub

End Class