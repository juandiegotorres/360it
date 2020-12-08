Public Class frmCuentasCorriente
    Dim eCuentaCorriente As New Entidades.CuentaCorriente
    Dim tablaCuenta As New DataTable
    Dim debe, entrega As Double
    Dim bsMovimientoCuenta As New BindingSource
    Dim filtroBS As String
    Public Sub cargarCuentaCorriente()
        tablaCuenta.Clear()
        debe = 0
        entrega = 0
        txtResto.Text = 0
        tablaCuenta.Clear()
        dgvCuentas.Select()
        If eCuentaCorriente.verCuentaCliente(tablaCuenta) = True Then
            bsMovimientoCuenta.DataSource = tablaCuenta
            dgvCuentas.DataSource = bsMovimientoCuenta
            comboBoxVentas()
            filtroBS = ""
            bsMovimientoCuenta.Filter = filtroBS
            corregirDataGrid()
            dgvCuentas.ClearSelection()
        Else
            MsgBox("Este cliente no posee cuenta corriente", MsgBoxStyle.Information, "Cuentas Corriente")
        End If

    End Sub

    Public Sub comboBoxVentas()
        Dim tablaVentas As New DataTable
        tablaVentas.Clear()
        tablaVentas.Columns.Add("venta")
        tablaVentas.Columns.Add("ventaFecha")
        tablaVentas.Rows.Add("0", "Todas")
        eCuentaCorriente.filtrarVentasCliente(tablaVentas)
        cbVentas.DataSource = tablaVentas
        cbVentas.DisplayMember = "ventaFecha"
        cbVentas.ValueMember = "venta"
        cbVentas.SelectedIndex = 0
    End Sub

    Public Sub corregirDataGrid()
        debe = 0
        entrega = 0
        txtResto.Text = 0
        For i = 0 To dgvCuentas.Rows.Count - 1
            If dgvCuentas.Rows(i).Cells("tipoMovimiento").Value = "D" Or dgvCuentas.Rows(i).Cells("tipoMovimiento").Value = "DÉBITO" Then
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
            txtResto.Text = (debe + entrega).ToString("C2")
            If debe < 0 Then
                txtResto.ForeColor = Color.Red
            Else
                txtResto.ForeColor = Color.Green
            End If
            dgvCuentas.ClearSelection()
        Next
    End Sub


    Private Sub btnDetalleVenta_Click(sender As Object, e As EventArgs) Handles btnDetalleVenta.Click
        If dgvCuentas.SelectedRows.Count = 1 Then
            Dim detalleVenta As New frmDetalleVentaCtaCorriente
            With detalleVenta
                .e_Venta.idVenta = dgvCuentas.CurrentRow.Cells("venta").Value
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub frmCuentasCorriente_Load(sender As Object, e As EventArgs) Handles Me.Load
        debe = 0
        entrega = 0
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
            Dim tipoMovimiento As String = dgvCuentas.CurrentRow.Cells("tipoMovimiento").Value.ToString
            If tipoMovimiento = "DÉBITO" Then
                MsgBox("No se puede eliminar una venta", MsgBoxStyle.Exclamation, "Cuentas Corriente")
            Else
                If MsgBox("¿Desea eliminar esta entrega de dinero?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Cuenta Corriente") = MsgBoxResult.Yes Then
                    eCuentaCorriente.idMovimiento = dgvCuentas.CurrentRow.Cells("idmovimiento").Value
                    eCuentaCorriente.eliminarMovimiento()
                    cargarCuentaCorriente()
                End If
            End If
        End If
    End Sub

    Private Sub dgvCuentas_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCuentas.ColumnHeaderMouseClick
        corregirDataGrid()
    End Sub

    Private Sub picClientes_Click(sender As Object, e As EventArgs) Handles picClientes.Click
        Dim clientes As New frmClientes
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
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        cbVentas.Text = ""
        filtroBS = ""
        bsMovimientoCuenta.Filter = filtroBS
        corregirDataGrid()
    End Sub


    Private Sub frmCuentasCorriente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case (Keys.Control + Keys.B)
                picClientes_Click(picClientes, e)
            Case Keys.F10
                Call btnDetalleVenta_Click(btnDetalleVenta, e)
            Case Keys.F11
                Call btnEntregaDeDinero_Click(btnEntregaDeDinero, e)
            Case Keys.F12
                Call btnEliminarMovimiento_Click(btnEliminarMovimiento, e)
        End Select
    End Sub

    Private Sub cbVentas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbVentas.SelectionChangeCommitted
        If cbVentas.Items.Count <> 0 Then
            If cbVentas.Text = "Todas" Then
                filtroBS = ""
                bsMovimientoCuenta.Filter = filtroBS
                corregirDataGrid()
                dgvCuentas.ClearSelection()
            Else
                filtroBS = "CONVERT(venta, 'System.String') like '%" & cbVentas.SelectedValue.ToString & "%'"
                bsMovimientoCuenta.Filter = filtroBS
                corregirDataGrid()
                dgvCuentas.ClearSelection()
            End If
        End If
    End Sub
End Class