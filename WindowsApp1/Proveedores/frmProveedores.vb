﻿Public Class frmProveedores
    Dim bsProveedores As New BindingSource
    Dim filtroBS As String

    Public eProveedor As New Entidades.Proveedor
    Private _producto As Boolean
    Dim tablaRubros, tablaFormPago As New DataTable
    Public Property producto As Boolean
        Set(value As Boolean)
            _producto = value
        End Set
        Get
            Return _producto
        End Get
    End Property
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarProveedores()
        actualizarRubrosYFormPago()
        dgvProveedores.Select()
        If producto = True Then
            btnProductosAsociados.Visible = False
            picCerrar.Visible = True
            btnAgregarSeleccionar.Text = "Aceptar"
            btnAgregarSeleccionar.Image = My.Resources.seleccionar
            btnModificar.Visible = False
            btnBajaCancelar.Text = "Cancelar"
            btnBajaCancelar.Image = My.Resources.cancelar
            pnlHeader.Visible = True
        End If
    End Sub


    Public Sub actualizarProveedores()
        Dim tabla As New DataTable
        eProveedor.recuperarProveedores(tabla)
        bsProveedores.DataSource = tabla
        dgvProveedores.DataSource = bsProveedores
    End Sub
    'Dim a As UInt16 = dgvProveedores.Width
    Public Sub actualizarRubros()
        tablaRubros.Clear()
        eProveedor.verRubrosProveedor(tablaRubros)
        dgvRubros.DataSource = tablaRubros
        dgvRubros.ClearSelection()
    End Sub
    Public Sub actualizarFormPago()
        tablaFormPago.Clear()
        eProveedor.verFormPagoProveedor(tablaFormPago)
        dgvFormPago.DataSource = tablaFormPago
        dgvFormPago.ClearSelection()
    End Sub



    Private Sub picCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmNuevoProducto.Show()
    End Sub


    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If rbNombreApel.Checked = True Then
            filtroBS = "nombreProveedor like '%" & txtBuscar.Text & "%'"
            bsProveedores.Filter = filtroBS
        ElseIf rbCuil.Checked = True Then
            filtroBS = "CONVERT(cuil, 'System.String') like '%" & txtBuscar.Text & "%'"
            bsProveedores.Filter = filtroBS
        End If

    End Sub
    Public Sub actualizarRubrosYFormPago()
        eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idProveedor").Value
        actualizarRubros()
        actualizarFormPago()
    End Sub

    Private Sub dgvProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        actualizarRubrosYFormPago()
    End Sub

    Private Sub btnAgregarSeleccionar_Click(sender As Object, e As EventArgs) Handles btnAgregarSeleccionar.Click
        If producto = True Then
            If dgvProveedores.CurrentRow.Selected = False Then
                MsgBox("No ha seleccionado ningún cliente", MsgBoxStyle.Exclamation, "Proveedores")
            Else
                eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
                eProveedor.nombre = dgvProveedores.CurrentRow.Cells("nombre").Value
                Me.DialogResult = DialogResult.OK
            End If
        Else
            Dim nuevoProveedor As New frmNuevoProveedor
            nuevoProveedor.ShowDialog()
            If nuevoProveedor.DialogResult = DialogResult.OK Then
                actualizarProveedores()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim modificarProveedor As New frmNuevoProveedor
        modificarProveedor.eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
        With modificarProveedor
            .modificar = True
            .ShowDialog()
            If DialogResult.OK Then
                actualizarProveedores()
                actualizarRubrosYFormPago()
            End If
        End With
    End Sub


    Private Sub btnBajaCancelar_Click(sender As Object, e As EventArgs) Handles btnBajaCancelar.Click
        If producto = True Then
            Me.Close()
            frmNuevoProducto.Show()
        Else
            If MsgBox("¿Desea dar de baja el proveedor '" & dgvProveedores.CurrentRow.Cells("nombre").Value & "'?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Proveedores") = MsgBoxResult.Yes Then
                eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
                eProveedor.bajaProveedor()
                actualizarProveedores()
                actualizarRubrosYFormPago()
            End If
        End If
    End Sub

    Private Sub frmProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case (Keys.Alt + Keys.B)
                txtBuscar.Select()
            Case Keys.F10
                Call btnAgregarSeleccionar_Click(btnAgregarSeleccionar, e)
            Case Keys.F11
                Call btnBajaCancelar_Click(btnBajaCancelar, e)
            Case Keys.F12
                Call btnModificar_Click(btnModificar, e)
        End Select
    End Sub

    Private Sub dgvProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProveedores.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If producto = True Then
                    Call btnAgregarSeleccionar_Click(btnAgregarSeleccionar, e)
                End If
        End Select

    End Sub

    Private Sub picCerrar_Click_1(sender As Object, e As EventArgs) Handles picCerrar.Click
        Me.Close()
    End Sub

    Private Sub rbNombreApel_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreApel.CheckedChanged
        txtBuscar.Text = ""
        filtroBS = ""
        bsProveedores.Filter = filtroBS
    End Sub

    Private Sub rbCuil_CheckedChanged(sender As Object, e As EventArgs) Handles rbCuil.CheckedChanged
        txtBuscar.Text = ""
        filtroBS = ""
        bsProveedores.Filter = filtroBS
    End Sub

    Private Sub btnProductosAsociados_Click(sender As Object, e As EventArgs) Handles btnProductosAsociados.Click
        Dim productosXproveedor As New frmProductosAsociados(dgvProveedores.CurrentRow.Cells("idProveedor").Value)
        productosXproveedor.Show()
    End Sub

End Class