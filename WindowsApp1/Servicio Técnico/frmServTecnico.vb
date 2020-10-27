Public Class frmServTecnico
    Dim eServTec As New Entidades.ServTecnico
    Dim fechaLim As String
    Dim id_Reparacion As UInt64
    Dim id_Estado As UInt16

    Private Sub frmServTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'idEstadoArticulo = 1
        'eServTec.idEstado = idEstadoArticulo
        estadoArticulo()
        actualizarReparaciones()

    End Sub
    Public Sub cambiarFecha()
        For i As Integer = 0 To dgvServTecnico.Rows.Count - 1
            If dgvServTecnico.Rows(i).Cells("fechaLimite").Value.ToString() = #1/1/2000 12:00:00 AM# Then
                Me.dgvServTecnico.Rows(i).Cells("fechaLimite").Value = ""
            End If
        Next
    End Sub
    Public Sub estadoArticulo()
        Dim tablaEstadoArticulo As New DataTable
        eServTec.estadoReparacion(tablaEstadoArticulo)
        cbEstado.DataSource = tablaEstadoArticulo
        cbEstado.DisplayMember = "nombreEstado"
        cbEstado.ValueMember = "id"
        cbEstado.SelectedValue = 1
    End Sub
    Public Sub actualizarReparaciones()
        Dim tablaReparaciones As New DataTable
        eServTec.traerReparaciones(tablaReparaciones, cbEstado.SelectedValue)
        dgvServTecnico.DataSource = tablaReparaciones
        cambiarFecha()
        dgvServTecnico.ClearSelection()
    End Sub



    Private Sub dgvServTecnico_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        eServTec.fechaLimite = dgvServTecnico.CurrentRow.Cells("fechaLimite").Value
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmPrincipal.Hide()
        Dim nuevaReparacion As New frmNuevaReparacion
        nuevaReparacion.ShowDialog()
        If nuevaReparacion.DialogResult = DialogResult.OK Then
            actualizarReparaciones()
        End If
        frmPrincipal.Show()

    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If dgvServTecnico.CurrentRow.Selected = False Then
            MsgBox("No hay ninguna reparacion seleccionada", MsgBoxStyle.Information, "Servicio Técnico")
        Else
            If MsgBox("¿Desea dar de baja esta reparación?", MsgBoxStyle.YesNo, "Servicio Técnico") = MsgBoxResult.Yes Then
                eServTec.bajaReparacion()
                actualizarReparaciones()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvServTecnico.CurrentRow.Selected = False Then
            MsgBox("No hay ninguna reparación seleccionada", MsgBoxStyle.MsgBoxHelp, "Servicio Técnico")
        Else
            Dim modificarReparacion As New frmNuevaReparacion
            modificarReparacion.eServTecnico.idReparacion = dgvServTecnico.CurrentRow.Cells("idReparacion").Value
            frmPrincipal.Hide()
            With modificarReparacion
                .modificar = True
                .ShowDialog()
                If DialogResult.OK Then
                    actualizarReparaciones()
                End If
            End With
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub cbEstado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEstado.SelectionChangeCommitted
        actualizarReparaciones()
    End Sub

    Private Sub dgvServTecnico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnVerDetalles_Click(sender As Object, e As EventArgs)
        If dgvServTecnico.SelectedRows.Count = 1 Then
            id_Reparacion = dgvServTecnico.CurrentRow.Cells("idReparacion").Value
            Dim detallesReparacion As New frmDetalleReparacion(id_Reparacion)
            detallesReparacion.ShowDialog()
        End If
    End Sub

    Private Sub btnCambiarEstado_Click(sender As Object, e As EventArgs) 
        If dgvServTecnico.SelectedRows.Count = 1 Then
            id_Reparacion = dgvServTecnico.CurrentRow.Cells("idReparacion").Value
            id_Estado = dgvServTecnico.CurrentRow.Cells("estado").Value
            Dim cambiarEstado As New frmCambiarEstado(id_Estado, id_Reparacion)
            cambiarEstado.ShowDialog()
            If cambiarEstado.DialogResult = DialogResult.OK Then
                actualizarReparaciones()
            End If
        End If
    End Sub
End Class