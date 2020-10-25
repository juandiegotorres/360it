﻿Public Class frmCargarCuentaCorriente
    Public eVenta As New Entidades.Venta
    Dim tablaFormPago As New DataTable

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
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
        ElseIf txtCuotas.Text = "0" Or LTrim(txtCuotas.Text) = "" Then
            MsgBox("Introduzca un número de cuotas válido", MsgBoxStyle.Information, "Cuenta Corriente")
        Else
            If LTrim(txtEntrega.Text) = "" Then
                eVenta.entregaDinero = 0
            Else
                eVenta.entregaDinero = txtEntrega.Text
            End If
            eVenta.nombreCliente = txtNombreCliente.Text
            eVenta.cuotas = CInt(txtCuotas.Text)
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub txtCuotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuotas.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEntrega.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class