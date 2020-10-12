Public Class frmCargarCuentaCorriente
    Public eVenta As New Entidades.Venta
    Dim tablaFormPago As New DataTable
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtEntrega.TextChanged

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmCuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarFormPago()
    End Sub
    Public Sub cargarFormPago()
        tablaFormPago.Clear()
        eVenta.cargarFormasPago(tablaFormPago)
        cbFormPago.DataSource = tablaFormPago
        cbFormPago.DisplayMember = "nombFormaPago"
        cbFormPago.ValueMember = "idformpago"
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim clientes As New frmClientes
        Me.Hide()
        With clientes
            .reparacion = True
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                eVenta.idCliente = clientes.eCliente.idCliente
                txtNombreCliente.Text = clientes.eCliente.nombApel
            End If
            If .DialogResult = DialogResult.Cancel Then
                txtNombreCliente.Text = ""
            End If
            Me.Show()
        End With
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Trim(txtNombreCliente.Text) = "" Then
            MsgBox("No hay ningun cliente seleccionado", MsgBoxStyle.Information, "Cuenta Corriente")
        Else
            eVenta.entregaDinero = txtEntrega.Text
            eVenta.cuotas = CInt(txtCuotas.Text)
            eVenta.idFormPago = cbFormPago.SelectedValue
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class