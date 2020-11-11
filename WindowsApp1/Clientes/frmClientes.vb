Public Class frmClientes
    Public eCliente As New Entidades.Cliente
    Dim bsClientes As New BindingSource
    Dim filtroBS As String
    Public reparacion As Boolean
    Public ctaCorriente As Boolean
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarClientes()
        If reparacion = True Then
            picCerrar.Visible = True
            btnAgregarSeleccionar.Text = "Seleccionar"
            btnAgregarSeleccionar.Image = My.Resources.seleccionar
            btnBajaCancelar.Text = "Cancelar"
            btnBajaCancelar.Image = My.Resources.cancelar
            pnlHeader.Visible = True
            btnModificar.Text = "Agregar"
            btnModificar.Image = My.Resources.add__1_
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




    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtroBS = "nombreApel like '%" & txtBuscar.Text & "%'"
        bsClientes.Filter = filtroBS
        ' dgvClientes.ClearSelection()
    End Sub

    Public Sub agregarCliente()
        Dim nuevoCliente As New frmNuevoCliente
        With nuevoCliente
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                actualizarClientes()
            End If
        End With
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
            agregarCliente()
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
                    eCliente.idCliente = dgvClientes.CurrentRow.Cells("idcliente").Value
                    eCliente.bajaCliente()
                    actualizarClientes()
                End If
            End If
        End If
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Si el form se abre desde cuenta corriente o reparacion u otro lado voy a dejar este boton(modificar) para agregar un cliente tambien, ya que el originario va a esta ocupado con la opcion de seleccionar 
        If reparacion = True Then
            Me.Hide()
            agregarCliente()
            Me.Show()
        Else

            If dgvClientes.CurrentRow.Selected = False Then
                MsgBox("No hay ningun cliente seleccionado", MsgBoxStyle.MsgBoxHelp, "Clientes")
            Else
                Dim modificarCliente As New frmNuevoCliente
                modificarCliente.eCliente.idCliente = dgvClientes.CurrentRow.Cells("idCliente").Value
                With modificarCliente
                    .modificar = True
                    .ShowDialog()
                    If DialogResult.OK Then
                        actualizarClientes()
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub frmClientes_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
        'MyBase.OnPaintBackground(e)
        'Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        'e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub

    Private Sub picCerrar_Click_1(sender As Object, e As EventArgs) Handles picCerrar.Click
        Me.Close()
    End Sub
End Class