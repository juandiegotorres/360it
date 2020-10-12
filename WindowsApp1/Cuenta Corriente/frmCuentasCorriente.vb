Public Class frmCuentasCorriente
    Dim eCuentaCorriente As New Entidades.CuentaCorriente
    Dim tablaCuenta As New DataTable
    Dim debe, entrega As Double
    Public Sub cargarCuentaCorriente()
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


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picClientes.Click
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

    Private Sub frmCuentasCorriente_Load(sender As Object, e As EventArgs) Handles Me.Load
        debe = 0
        entrega = 0
    End Sub
End Class