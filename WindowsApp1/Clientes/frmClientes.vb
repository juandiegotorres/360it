﻿Public Class frmClientes
    Dim eCliente As New Entidades.Cliente
    Dim bsClientes As New BindingSource
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarClientes()
        dgvClientes.ClearSelection()
    End Sub

    Public Sub actualizarClientes()
        Dim tablaCliente As New DataTable
        eCliente.traerClientes(tablaCliente)
        bsClientes.DataSource = tablaCliente
        dgvClientes.DataSource = bsClientes
        dgvClientes.ClearSelection()
    End Sub



    Private Sub dgvClientes_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim columna As UInt16 = e.ColumnIndex
            dgvClientes.CurrentCell = dgvClientes(e.ColumnIndex, e.RowIndex)
            Dim position_xy_mouse_row = dgvClientes.HitTest(e.X, e.Y).RowIndex

            If columna > 0 Then
                'cmsClientes.Show(dgvClientes, New Point(e.X, e.Y))
            End If
        End If
    End Sub


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevoCliente As New frmNuevoCliente
        frmPrincipal.Hide()
        With nuevoCliente
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                actualizarClientes()
                frmPrincipal.Show()
            End If
        End With
    End Sub

    Private Sub BtnBajaCliente_Click_1(sender As Object, e As EventArgs) Handles btnBajaCliente.Click
        If dgvClientes.CurrentRow.Selected = False Then
            MsgBox("No hay ningun cliente seleccionado", MsgBoxStyle.Information, "Clientes")
        Else
            If MsgBox("¿Desea dar de baja este cliente?", MsgBoxStyle.YesNo, "Clientes") = MsgBoxResult.Yes Then
                eCliente.bajaCliente()
                actualizarClientes()
            End If
        End If
    End Sub

    Private Sub BtnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvClientes.CurrentRow.Selected = False Then
            MsgBox("No hay ningun cliente seleccionado", MsgBoxStyle.MsgBoxHelp, "Clientes")
        Else
            Dim modificarCliente As New frmNuevoCliente
            modificarCliente.eCliente.idCliente = dgvClientes.CurrentRow.Cells("idCliente").Value
            frmPrincipal.Hide()

            With modificarCliente
                .modificar = True
                .ShowDialog()
                If DialogResult.OK Then
                    actualizarClientes()
                End If
            End With
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        eCliente.idCliente = dgvClientes.CurrentRow.Cells("idCliente").Value
    End Sub
End Class