Public Class frmServTecnico
    Dim eServTec As New Entidades.ServTecnico
    Dim fechaLim, filtroBS, nombreEquipo As String
    Dim id_Reparacion, id_Estado As UInt64
    Dim bsReparaciones As New BindingSource
    Dim tablaBuscador, tablaReparaciones As New DataTable
    Dim idReparacion_ As UInt64


    Private Sub frmServTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'idEstadoArticulo = 1
        'eServTec.idEstado = idEstadoArticulo
        estadoArticulo()
        actualizarReparaciones()
        dgvServTecnico.Select()
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
        tablaReparaciones.Clear()
        eServTec.traerReparaciones(tablaReparaciones, cbEstado.SelectedValue)
        bsReparaciones.DataSource = tablaReparaciones
        dgvServTecnico.DataSource = bsReparaciones
        cambiarFecha()
        dgvServTecnico.ClearSelection()
    End Sub

    Private Sub dgvServTecnico_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        eServTec.fechaLimite = dgvServTecnico.CurrentRow.Cells("fechaLimite").Value
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevaReparacion As New frmNuevaReparacion
        nuevaReparacion.ShowDialog()
        If nuevaReparacion.DialogResult = DialogResult.OK Then
            actualizarReparaciones()
        End If
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click

        If dgvServTecnico.CurrentRow.Selected = False Then
            MsgBox("No hay ninguna reparacion seleccionada", MsgBoxStyle.Information, "Servicio Técnico")
        Else
            eServTec.idReparacion = dgvServTecnico.CurrentRow.Cells("idReparacion").Value
            nombreEquipo = dgvServTecnico.CurrentRow.Cells("articulo").Value & " " & dgvServTecnico.CurrentRow.Cells("marca").Value & " " & dgvServTecnico.CurrentRow.Cells("modelo").Value
            If MsgBox("¿Desea dar de baja la reparación del artículo '" & nombreEquipo & "'?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Servicio Técnico") = MsgBoxResult.Yes Then
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
            With modificarReparacion
                .modificar = True
                .ShowDialog()
                If DialogResult.OK Then
                    actualizarReparaciones()
                End If
            End With
        End If
    End Sub

    Private Sub cbEstado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbEstado.SelectionChangeCommitted
        actualizarReparaciones()
    End Sub

    Private Sub dgvServTecnico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnVerDetalles_Click_1(sender As Object, e As EventArgs) Handles btnVerDetalles.Click
        If dgvServTecnico.SelectedRows.Count = 1 Then
            id_Reparacion = dgvServTecnico.CurrentRow.Cells("idReparacion").Value
            Dim detallesReparacion As New frmDetalleReparacion(id_Reparacion)
            detallesReparacion.ShowDialog()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtroBS = "CONVERT(idReparacion, 'System.String') like '" & txtBuscar.Text & "%'"
        bsReparaciones.Filter = filtroBS
    End Sub

    Private Sub btnImprimirEtiqueta_Click(sender As Object, e As EventArgs) Handles btnImprimirEtiqueta.Click
        idReparacion_ = dgvServTecnico.CurrentRow.Cells("idReparacion").Value
        Dim generarEtiqueta As New frmEtiqueta(idReparacion_, False)
        generarEtiqueta.Show()
    End Sub

    Private Sub btnCambiarEstado_Click_1(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
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

    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover
        ttAyuda.SetToolTip(btnAgregar, "Introduzca los centavos con una coma. Ej: '22,50'")
        ttAyuda.ToolTipTitle = "Precio"
        ttAyuda.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub frmServTecnico_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case (Keys.Alt + Keys.B)
                txtBuscar.Select()
            Case Keys.F10
                Call btnAgregar_Click(btnAgregar, e)
            Case Keys.F11
                Call btnBaja_Click(btnBaja, e)
            Case Keys.F12
                Call btnModificar_Click_1(btnModificar, e)
        End Select
    End Sub
End Class