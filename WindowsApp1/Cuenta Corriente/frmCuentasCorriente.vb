Public Class frmCuentasCorriente
    Dim eCuentaCorriente As New Entidades.CuentaCorriente
    Dim tablaCuenta As New DataTable
    Dim debe, entrega As Double
    Public Sub cargarCuentaCorriente()
        tablaCuenta.Clear()
        debe = 0
        entrega = 0
        txtResto.Text = 0
        tablaCuenta.Clear()
        eCuentaCorriente.verCuentaCliente(tablaCuenta)
        dgvCuentas.DataSource = tablaCuenta
        dgvCuentas.ClearSelection()
        corregirDataGrid()
        txtResto.Text = debe + entrega
        If debe < 0 Then
            txtResto.ForeColor = Color.Red
        Else
            txtResto.ForeColor = Color.Green
        End If
    End Sub
    Public Sub calcularResto()
        For i = 0 To dgvCuentas.Rows.Count - 1
            If dgvCuentas.Rows(i).Cells("tipoMovimiento").Value = "D" Then
                dgvCuentas.Rows(i).Cells("tipoMovimiento").Value = "DÉBITO"
                dgvCuentas.Rows(i).Cells("tipoMovimiento").Style.ForeColor = Color.Red
                dgvCuentas.Rows(i).Cells("monto").Style.ForeColor = Color.Red
                dgvCuentas.Rows(i).Cells("monto").Value = -Math.Abs(dgvCuentas.Rows(i).Cells("monto").Value)
            Else
                dgvCuentas.Rows(i).Cells("tipoMovimiento").Value = "CRÉDITO"
                dgvCuentas.Rows(i).Cells("tipoMovimiento").Style.ForeColor = Color.Green
                dgvCuentas.Rows(i).Cells("monto").Style.ForeColor = Color.Green
                dgvCuentas.Rows(i).Cells("monto").Value = +Math.Abs(dgvCuentas.Rows(i).Cells("monto").Value)

                'xd = "+$" & dgvCuentas.Rows(i).Cells("monton").Value
                'dgvCuentas.Rows(i).Cells("monton").Value = xd
            End If
        Next
    End Sub
    Public Sub corregirDataGrid()
        For i = 0 To dgvCuentas.Rows.Count - 1
            If dgvCuentas.Rows(i).Cells("tipoMovimiento").Value = "D" Then
                dgvCuentas.Rows(i).Cells("tipoMovimiento").Value = "DÉBITO"
                dgvCuentas.Rows(i).Cells("tipoMovimiento").Style.ForeColor = Color.Red
                dgvCuentas.Rows(i).Cells("monto").Style.ForeColor = Color.Red
                dgvCuentas.Rows(i).Cells("monto").Value = -Math.Abs(dgvCuentas.Rows(i).Cells("monto").Value)
                debe = debe + dgvCuentas.Rows(i).Cells("monto").Value
            Else
                dgvCuentas.Rows(i).Cells("tipoMovimiento").Value = "CRÉDITO"
                dgvCuentas.Rows(i).Cells("tipoMovimiento").Style.ForeColor = Color.Green
                dgvCuentas.Rows(i).Cells("monto").Style.ForeColor = Color.Green
                dgvCuentas.Rows(i).Cells("monto").Value = +Math.Abs(dgvCuentas.Rows(i).Cells("monto").Value)
                entrega = entrega + dgvCuentas.Rows(i).Cells("monto").Value
                'xd = "+$" & dgvCuentas.Rows(i).Cells("monton").Value
                'dgvCuentas.Rows(i).Cells("monton").Value = xd
            End If
        Next
    End Sub


    Private Sub picClientes_Click(sender As Object, e As EventArgs) Handles picClientes.Click
        Dim clientes As New frmClientes
        frmPrincipal.Hide()
        With clientes
            .reparacion = True
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                eCuentaCorriente.idCliente = clientes.eCliente.idCliente
                txtNombreCliente.Text = clientes.eCliente.nombApel
                cargarCuentaCorriente()
            End If
            If .DialogResult = DialogResult.Cancel Then
                txtNombreCliente.Text = ""
            End If
            frmPrincipal.Show()
        End With
    End Sub

    Private Sub btnDetalleVenta_Click(sender As Object, e As EventArgs) Handles btnDetalleVenta.Click
        Dim detalleVenta As New frmDetalleVentaCtaCorriente
        With detalleVenta
            If dgvCuentas.SelectedRows.Count = 1 Then
                .e_Venta.idVenta = dgvCuentas.CurrentRow.Cells("venta").Value
                .ShowDialog()
            End If
        End With
    End Sub

    Private Sub frmCuentasCorriente_Load(sender As Object, e As EventArgs) Handles Me.Load
        debe = 0
        entrega = 0
    End Sub

    Private Sub dgvCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellClick

    End Sub

    Private Sub btnEntregaDeDinero_Click(sender As Object, e As EventArgs) Handles btnEntregaDeDinero.Click
        If dgvCuentas.Rows.Count >= 1 Then
            Dim entregaDinero As New frmEntrega()
            entregaDinero.eCtaCorriente.idCtaCorriente = dgvCuentas.Rows(0).Cells("cuentacorriente").Value
            If dgvCuentas.SelectedRows.Count = 1 Then
                entregaDinero.eCtaCorriente.idVenta = dgvCuentas.CurrentRow.Cells("venta").Value
            End If
            entregaDinero.ShowDialog()
            If entregaDinero.DialogResult = DialogResult.OK Then
                eCuentaCorriente.entrega = entregaDinero.eCtaCorriente.entrega
                eCuentaCorriente.idVenta = entregaDinero.eCtaCorriente.idVenta
                eCuentaCorriente.idCtaCorriente = dgvCuentas.Rows(0).Cells("cuentacorriente").Value
                eCuentaCorriente.entregaDinero()
                cargarCuentaCorriente()
            End If
        End If
    End Sub

    Private Sub btnEliminarMovimiento_Click(sender As Object, e As EventArgs) Handles btnEliminarMovimiento.Click
        If dgvCuentas.SelectedRows.Count = 1 Then
            Dim a As String = dgvCuentas.CurrentRow.Cells("tipoMovimiento").Value.ToString
            If a = "DÉBITO" Then
                MsgBox("No se puede eliminar una venta", MsgBoxStyle.Exclamation, "Cuentas Corriente")
            Else
                eCuentaCorriente.idMovimiento = dgvCuentas.CurrentRow.Cells("idmovimiento").Value
                eCuentaCorriente.eliminarMovimiento()
                cargarCuentaCorriente()
            End If
        End If
    End Sub

    Private Sub dgvCuentas_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCuentas.ColumnHeaderMouseClick
        corregirDataGrid()
    End Sub
End Class