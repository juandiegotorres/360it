Public Class frmClientes
    Public eCliente As New Entidades.Cliente
    Dim bsClientes As New BindingSource
    Dim filtroBS As String
    Public reparacion As Boolean
    Public ctaCorriente As Boolean
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarClientes()
        If reparacion = True Then
            piccerrar.visible = True
            btnAgregarSeleccionar.Text = "Seleccionar"
            btnModificar.Visible = False
            btnBajaCancelar.Text = "Cancelar"
            pnlHeader.Visible = True
        End If
        dgvClientes.ClearSelection()
    End Sub
    Dim tablaCliente As New DataTable
    Public Sub actualizarClientes()
        tablaCliente.Clear()
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


    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        eCliente.idCliente = dgvClientes.CurrentRow.Cells("idCliente").Value
    End Sub




    Private Sub picCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub btnAgregarSeleccionar_Click(sender As Object, e As EventArgs) Handles btnAgregarSeleccionar.Click
        If reparacion = True Then
            If dgvClientes.CurrentRow.Selected = False Then
                MsgBox("No ha seleccionado ningún cliente", MsgBoxStyle.Exclamation, "Clientes")
            Else
                eCliente.idCliente = dgvClientes.CurrentRow.Cells("idcliente").Value
                eCliente.nombApel = dgvClientes.CurrentRow.Cells("nombreApel").Value.ToString
                Me.DialogResult = DialogResult.OK
            End If
        Else
            Dim nuevoCliente As New frmNuevoCliente
            frmPrincipal.Hide()
            With nuevoCliente
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    actualizarClientes()
                    frmPrincipal.Show()
                End If
            End With
        End If
    End Sub

    Private Sub btnBajaCancelar_Click(sender As Object, e As EventArgs) Handles btnBajaCancelar.Click
        If reparacion = True Then
            Me.DialogResult = DialogResult.Cancel
        Else
            If dgvClientes.CurrentRow.Selected = False Then
                MsgBox("No hay ningun cliente seleccionado", MsgBoxStyle.Information, "Clientes")
            Else
                If MsgBox("¿Desea dar de baja este cliente?", MsgBoxStyle.YesNo, "Clientes") = MsgBoxResult.Yes Then
                    eCliente.bajaCliente()
                    actualizarClientes()
                End If
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtroBS = "nombreApel like '%" & txtBuscar.Text & "%'"
        bsClientes.Filter = filtroBS
        ' dgvClientes.ClearSelection()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
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


End Class