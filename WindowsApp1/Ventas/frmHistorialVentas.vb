Public Class frmHistorialVentas
    Dim eVenta As New Entidades.Venta
    Dim eCuentaCorriente As New Entidades.CuentaCorriente
    Dim tablaHistorial, tablaHistorialCtaCorriente As New DataTable
    Dim _id As UInt64
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

    Private Sub btnDetalleVentaCtaCorriente_Click(sender As Object, e As EventArgs) Handles btnDetalleVentaCtaCorriente.Click
        Dim detalleVenta As New frmDetalleVentaCtaCorriente
        With detalleVenta
            If dgvHistCtaCorriente.SelectedRows.Count = 1 Then
                .e_Venta.idVenta = dgvHistCtaCorriente.CurrentRow.Cells("idVentaCC").Value
                .ShowDialog()
            End If
        End With
    End Sub

    Private Sub btnDetalleVentaGeneral_Click(sender As Object, e As EventArgs) Handles btnDetalleVentaGeneral.Click
        Dim detalleVenta As New frmDetalleVentaCtaCorriente
        With detalleVenta
            If dgvHistorialVentas.SelectedRows.Count = 1 Then
                .e_Venta.idVenta = dgvHistorialVentas.CurrentRow.Cells("idVenta").Value
                .ShowDialog()
            End If
        End With
    End Sub

    Private Sub dgvHistorialVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorialVentas.CellContentClick
        If e.ColumnIndex = 7 Then
            If MsgBox("¿Desea dar de baja esta venta?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Historial de Ventas") = MsgBoxResult.Yes Then
                If eVenta.bajaVenta(dgvHistorialVentas.CurrentRow.Cells("idVenta").Value) = True Then
                    cargarHistorial()
                End If
            End If
        End If
    End Sub

    Private Sub dgvHistCtaCorriente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistCtaCorriente.CellContentClick
        If e.ColumnIndex = 7 Then
            If MsgBox("Esto dará de baja la venta y eliminará la(s) entrega(s) de dinero realizadas por el cliente ¿Desea continuar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Cuentas Corriente") = MsgBoxResult.Yes Then
                eCuentaCorriente.bajaVenta(dgvHistCtaCorriente.CurrentRow.Cells("idVentaCC").Value)
                eCuentaCorriente.eliminarTodosLosMovimientos(dgvHistCtaCorriente.CurrentRow.Cells("idVentaCC").Value)
                cargarHistorialCtaCorriente()
            End If
            'If MsgBox("¿Desea dar de baja esta venta a cuenta corriente?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Historial de Ventas") = MsgBoxResult.Yes Then
            '    If eVenta.bajaVenta(dgvHistCtaCorriente.CurrentRow.Cells("idVentaCC").Value) = True Then
            '        cargarHistorialCtaCorriente()
            '    End If
            'End If
        End If
    End Sub
End Class