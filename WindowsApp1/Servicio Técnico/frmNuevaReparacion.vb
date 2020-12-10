﻿Public Class frmNuevaReparacion
    Public eServTecnico As New Entidades.ServTecnico
    Public modificar As Boolean
    Private Sub frmNuevaReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipoArticulo()
        estadoReparacion()
        dtEntrega.Value = Today.AddDays(3)
        dtEntrega.MinDate = Today
        If modificar = True Then
            btnGuardarEImprimir.Enabled = False
            lblTitulo.Text = "Modificar Reparación"
            eServTecnico.modificarReparacion()
            txtNombreCliente.Text = eServTecnico.nombreCliente
            cbTipoArticulo.SelectedValue = eServTecnico.idTipo
            txtMarca.Text = eServTecnico.marca
            txtModelo.Text = eServTecnico.modelo
            cbEstado.SelectedValue = eServTecnico.idEstado
            dtRecepcion.Value = eServTecnico.fechaRecep
            'Cuando tengo una reparacion que no tiene fecha limite en la base de datos la almaceno con la fecha 1/1/2000 para poder luego corregirla en el datagrid
            'Si la reparacion no tiene fecha de entrega marco el checkbox y pongo una fecha acorde
            If eServTecnico.fechaLimite.ToString = #1/1/2000 12:00:00 AM# Then
                dtEntrega.MinDate = eServTecnico.fechaRecep
                dtEntrega.Value = Today.AddDays(3)
                chbSinFecha.Checked = True
            Else
                dtEntrega.MinDate = eServTecnico.fechaRecep
                dtEntrega.Value = eServTecnico.fechaLimite
            End If
            If eServTecnico.accesorios = "Sin accesorios" Then
                txtAccesorios.Text = ""
            Else
                txtAccesorios.Text = eServTecnico.accesorios
            End If
            If eServTecnico.descripcion = "Sin descripción" Then
                txtDescripcion.Text = ""
            Else
                txtDescripcion.Text = eServTecnico.descripcion
            End If
        End If
    End Sub
    Public Function comprobarAccesoriosYDescripcion()
        If Trim(txtAccesorios.Text) = "" Then
            eServTecnico.accesorios = "Sin accesorios"
        Else
            eServTecnico.accesorios = txtAccesorios.Text
        End If
        If Trim(txtDescripcion.Text) = "" Then
            eServTecnico.descripcion = "Sin descripción"
        Else
            eServTecnico.descripcion = txtDescripcion.Text
        End If
        Return True
    End Function
    Public Function comprobarDatos()
        Dim _control As Control
        For Each _control In Me.Controls
            If TypeOf _control Is ComboBox Then
                If String.IsNullOrEmpty(cbTipoArticulo.SelectedValue) Then
                    MsgBox("Parece que no hay ningún tipo de artículo a seleccionar. Intente agregando una desde las opciones.", MsgBoxStyle.Exclamation, "Servico Técnico")
                    Return False
                ElseIf String.IsNullOrEmpty(cbEstado.SelectedValue) Then
                    MsgBox("Parece que no hay ningún estado a seleccionar. Intente agregando uno desde las opciones.", MsgBoxStyle.Exclamation, "Servico Técnico")
                    Return False
                End If
            End If
            If TypeOf _control Is TextBox Then
                If _control Is txtDescripcion Then
                ElseIf _control Is txtAccesorios Then
                Else
                    If LTrim(_control.Text) = "" Then
                        MsgBox("El campo '" & _control.Tag & "' no puede estar vacío", MsgBoxStyle.Exclamation, "Servicio Técnico")
                        Return False
                    End If
                End If
            End If
        Next
        Return True
    End Function
    Public Sub limpiarCampos()
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
        cbEstado.SelectedValue = 1
        cbTipoArticulo.SelectedValue = 1
        dtEntrega.Value = Today
        dtRecepcion.Value = Today.AddDays(3)
    End Sub

    Public Sub tipoArticulo()
        Dim tablaArticulo As New DataTable
        eServTecnico.tipoArticulo(tablaArticulo)
        cbTipoArticulo.DataSource = tablaArticulo
        cbTipoArticulo.DisplayMember = "tipoArticulo"
        cbTipoArticulo.ValueMember = "id"
        cbTipoArticulo.SelectedValue = 1
    End Sub
    Public Sub estadoReparacion()
        Dim tablaEstadoArticulo As New DataTable
        eServTecnico.estadoReparacion(tablaEstadoArticulo)
        cbEstado.DataSource = tablaEstadoArticulo
        cbEstado.DisplayMember = "nombreEstado"
        cbEstado.ValueMember = "id"
        cbEstado.SelectedValue = 1
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim clientes As New frmClientes
        With clientes
            .reparacion = True
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                eServTecnico.idCliente = clientes.eCliente.idCliente
                txtNombreCliente.Text = clientes.eCliente.nombApel
            End If
            If .DialogResult = DialogResult.Cancel Then
                txtNombreCliente.Text = ""
            End If
        End With
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub chbSinFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chbSinFecha.CheckedChanged
        If chbSinFecha.Checked = True Then
            dtEntrega.Enabled = False
        ElseIf chbSinFecha.Checked = False And modificar = True Then
            dtEntrega.MinDate = eServTecnico.fechaRecep
            dtEntrega.Enabled = True
        Else
            dtEntrega.MinDate = Today
            dtEntrega.Enabled = True
            dtEntrega.Value = Today.AddDays(3)
        End If

    End Sub
    Public Function controlDeFechas()
        If (DateTime.Compare(dtRecepcion.Value, dtEntrega.Value) > 0) And chbSinFecha.Checked = False Then
            MsgBox("La fecha de recepción no puede ser mayor que la de entrega", MsgBoxStyle.Critical, "Nueva Reparacón")
            dtEntrega.Value = Today
            Return False
        End If
        Return True
    End Function

    Private Sub frmNuevaReparacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case (Keys.Control + Keys.L)
                Call btnLimpiar_Click(btnLimpiar, e)
            Case Keys.Enter
                Call btnGuardar_Click(btnGuardar, e)
            Case Keys.Escape
                Call btnCancelar_Click(btnCancelar, e)
            Case Keys.Up
                e.Handled = True
                Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End Select
    End Sub

    Private Sub frmNuevaReparacion_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobarDatos() And controlDeFechas() And comprobarAccesoriosYDescripcion() Then
            eServTecnico.idTipo = cbTipoArticulo.SelectedValue
            eServTecnico.marca = txtMarca.Text
            eServTecnico.modelo = txtModelo.Text
            eServTecnico.idEstado = cbEstado.SelectedValue
            eServTecnico.fechaRecep = dtRecepcion.Value
            If chbSinFecha.Checked = False Then
                eServTecnico.fechaLimite = dtEntrega.Value
            Else
                eServTecnico.fechaLimite = #01/01/2000 12:00:00AM#
            End If
            If modificar = False Then
                If eServTecnico.nuevaReparacion() Then
                    MsgBox("Reparación agregada", MsgBoxStyle.Information, "Nueva Reparacion")
                    Me.DialogResult = DialogResult.OK
                    frmPrincipal.Show()
                Else
                    MsgBox("Sucedión un problema y no pudimos guardar la reparación por favor intente de nuevo", MsgBoxStyle.Critical, "Nueva Reparación")
                End If
            Else
                If eServTecnico.guardarReparacionModificada() Then
                    MsgBox("Reparación modificada", MsgBoxStyle.Information, "Modificar Reparación")
                    Me.DialogResult = DialogResult.OK
                    frmPrincipal.Show()
                Else
                    MsgBox("Sucedión un problema y no pudimos modificar la reparación por favor intente de nuevo", MsgBoxStyle.Critical, "Modificar Reparación")
                End If
            End If
        End If

    End Sub

    Private Sub btnGuardarEImprimir_Click(sender As Object, e As EventArgs) Handles btnGuardarEImprimir.Click
        If comprobarDatos() And controlDeFechas() And comprobarAccesoriosYDescripcion() Then
            eServTecnico.idTipo = cbTipoArticulo.SelectedValue
            eServTecnico.marca = txtMarca.Text
            eServTecnico.modelo = txtModelo.Text
            eServTecnico.idEstado = cbEstado.SelectedValue
            eServTecnico.fechaRecep = dtRecepcion.Value
            If chbSinFecha.Checked = False Then
                eServTecnico.fechaLimite = dtEntrega.Value
            Else
                eServTecnico.fechaLimite = #01/01/2000 12:00:00AM#
            End If
            If modificar = False Then
                If eServTecnico.nuevaReparacion() Then
                    MsgBox("Reparación agregada", MsgBoxStyle.Information, "Nueva Reparacion")
                    Dim generarEtiqueta As New frmEtiqueta(0, True)
                    generarEtiqueta.Show()
                    Me.DialogResult = DialogResult.OK
                    frmPrincipal.Show()
                Else
                    MsgBox("Sucedión un problema y no pudimos guardar la reparación por favor intente de nuevo", MsgBoxStyle.Critical, "Nueva Reparación")
                End If

            End If
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
