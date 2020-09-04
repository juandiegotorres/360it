Public Class frmNuevaReparacion
    Public eServTecnico As New Entidades.ServTecnico
    Public modificar As Boolean
    Private Sub frmNuevaReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipoArticulo()
        estadoArticulo()
        dtEntrega.Value = Today.AddDays(3)
        If modificar = True Then
            eServTecnico.modificarReparacion()
            txtNombreCliente.Text = eServTecnico.nombreCliente
            cbTipoArticulo.SelectedValue = eServTecnico.idTipo
            txtMarca.Text = eServTecnico.marca
            txtModelo.Text = eServTecnico.modelo
            cbEstado.SelectedValue = eServTecnico.idEstado
            dtRecepcion.Value = eServTecnico.fechaRecep
            dtEntrega.Value = eServTecnico.fechaLimite
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
            If TypeOf _control Is TextBox Then
                If _control Is txtDescripcion Then
                ElseIf _control Is txtAccesorios Then
                Else
                    If _control.Text = "" Then
                        MsgBox("Faltan completar datos", MsgBoxStyle.Exclamation, "Servicio Técnico")
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
        cbTipoArticulo.DisplayMember = "nombreTipo"
        cbTipoArticulo.ValueMember = "idTipo"
        cbTipoArticulo.SelectedValue = 1
    End Sub
    Public Sub estadoArticulo()
        Dim tablaEstadoArticulo As New DataTable
        eServTecnico.estadoArticulo(tablaEstadoArticulo)
        cbEstado.DataSource = tablaEstadoArticulo
        cbEstado.DisplayMember = "nombre"
        cbEstado.ValueMember = "id"
        cbEstado.SelectedValue = 1
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim clientes As New frmClientes
        Me.Hide()
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
            Me.Show()
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

        Else
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
                    MsgBox("Reparación modificada", MsgBoxStyle.Information, "Servicio Técnico")
                    Me.DialogResult = DialogResult.OK
                    frmPrincipal.Show()
                Else
                    MsgBox("Sucedión un problema y no pudimos modificar la reparación por favor intente de nuevo", MsgBoxStyle.Critical, "ModificarReparación")
                End If
            End If
        End If

    End Sub


End Class
