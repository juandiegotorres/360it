Public Class frmOpciones
    Dim eConfiguracion As New Entidades.Configuracion
    Dim tablaFormPago, tablaCategorias, tablaLocalidades, tablaProvincias As New DataTable
    Private Sub frmOpciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarFormPago()
        cargarCategorias()
        cargarLocalidades()
        pnlEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    End Sub
    Public Sub cargarFormPago()
        tablaFormPago.Clear()
        eConfiguracion.traerFormasDePago(tablaFormPago)
        dgvFormPago.DataSource = tablaFormPago
    End Sub
    Public Sub cargarCategorias()
        tablaCategorias.Clear()
        eConfiguracion.traerCategorias(tablaCategorias)
        dgvCategorias.DataSource = tablaCategorias
    End Sub
    Public Sub cargarLocalidades()
        tablaLocalidades.Clear()
        eConfiguracion.traerLocalidades(tablaLocalidades)
        dgvLocalidades.DataSource = tablaLocalidades
    End Sub
    Public Sub cargarProvincias()
        tablaProvincias.Clear()
        eConfiguracion.traerProvincias(tablaProvincias)
        With cbProvincias
            .DataSource = tablaProvincias
            .DisplayMember = "nombprovincia"
            .ValueMember = "idprovincia"
        End With
    End Sub

#Region "Form Pago"
    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If dgvFormPago.CurrentRow.Cells("activo").Value = 0 Then
            MsgBox("Esta forma de pago ya se encuentra dada de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idFormPago = dgvFormPago.CurrentRow.Cells("idFormPago").Value
            If eConfiguracion.darDeBajaPago = True Then
                cargarFormPago()
                MsgBox("Forma de pago dada de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnDarAlta_Click(sender As Object, e As EventArgs) Handles btnDarAlta.Click
        If dgvFormPago.CurrentRow.Cells("activo").Value = 1 Then
            MsgBox("Esta forma de pago ya se encuentra activa", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idFormPago = dgvFormPago.CurrentRow.Cells("idFormPago").Value
            If eConfiguracion.darDeAltaPago = True Then
                cargarFormPago()
                MsgBox("Forma de pago dada de alta con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnDestacar_Click(sender As Object, e As EventArgs) Handles btnDestacar.Click
        If dgvFormPago.CurrentRow.Cells("destacado").Value = 1 Then
            MsgBox("Esta forma de pago ya se encuentra destacada", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idFormPago = dgvFormPago.CurrentRow.Cells("idFormPago").Value
            If eConfiguracion.destacarPago = True Then
                cargarFormPago()
                MsgBox("Forma de pago destacada con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub txtRecargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecargo.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnEditarNombre_Click(sender As Object, e As EventArgs) Handles btnEditarNombre.Click
        pnlEditar.Visible = True
        txtNombre.Enabled = True
        txtRecargo.Enabled = False
        eConfiguracion.idFormPago = dgvFormPago.CurrentRow.Cells("idFormPago").Value
        lblEditarAgregar.Text = "Editar"
        eConfiguracion.traerNombre()
        txtNombre.Text = eConfiguracion.nombreFormPago
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtRecargo.Enabled = True And txtNombre.Enabled Then
            If LTrim(txtNombre.Text) <> "" And LTrim(txtRecargo.Text) <> "" Then
                eConfiguracion.nombreFormPago = txtNombre.Text
                eConfiguracion.recargo = txtRecargo.Text
                eConfiguracion.agregarFormaPago()
                MsgBox("Forma de pago agregada con éxito", MsgBoxStyle.Information, "Configuraciones")
                cargarFormPago()
                txtNombre.Text = ""
                txtRecargo.Text = ""
                pnlEditar.Visible = False
            End If
        Else
            If txtNombre.Enabled = True Then
                If LTrim(txtNombre.Text) <> "" Then
                    eConfiguracion.nombreFormPago = txtNombre.Text
                    eConfiguracion.nombreEditado()
                    cargarFormPago()
                    MsgBox("Nombre editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    txtNombre.Text = ""
                    pnlEditar.Visible = False
                End If
            End If
            If txtRecargo.Enabled = True Then
                If LTrim(txtRecargo.Text) <> "" Then
                    eConfiguracion.recargo = txtRecargo.Text
                    eConfiguracion.recargoEditado()
                    cargarFormPago()
                    MsgBox("Recargo editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    txtRecargo.Text = ""
                    pnlEditar.Visible = False
                End If
            End If
        End If

    End Sub

    Private Sub btnEditarRecargo_Click(sender As Object, e As EventArgs) Handles btnEditarRecargo.Click
        pnlEditar.Visible = True
        txtNombre.Enabled = False
        txtRecargo.Enabled = True
        eConfiguracion.idFormPago = dgvFormPago.CurrentRow.Cells("idFormPago").Value
        lblEditarAgregar.Text = "Editar"
        eConfiguracion.traerRecargo()
        txtRecargo.Text = eConfiguracion.recargo
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlEditar.Visible = False
        txtNombre.Text = ""
        txtRecargo.Text = ""
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlEditar.Visible = True
        lblEditarAgregar.Text = "Agregar"
        txtNombre.Text = ""
        txtNombre.Enabled = True
        txtRecargo.Text = ""
        txtRecargo.Enabled = True
    End Sub


#End Region
#Region "Categorias"
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        pnlEditarCategoria.Visible = True
        lblEditarAgregarCat.Text = "Agregar"
        txtNombreCategoria.Text = ""
        txtNombreCategoria.Enabled = True
        txtNombreCategoria.Tag = 1
    End Sub

    Private Sub btnAltaCategoria_Click(sender As Object, e As EventArgs) Handles btnAltaCategoria.Click
        If dgvCategorias.CurrentRow.Cells("activoCategoria").Value = 1 Then
            MsgBox("Esta categoría ya se encuentra activa", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idCategoria = dgvCategorias.CurrentRow.Cells("idcategoria").Value
            If eConfiguracion.darDeAltaCategoria = True Then
                cargarCategorias()
                MsgBox("Categoría dada de alta con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnBajaCategoria_Click(sender As Object, e As EventArgs) Handles btnBajaCategoria.Click
        If dgvCategorias.CurrentRow.Cells("activoCategoria").Value = 0 Then
            MsgBox("Esta categoría ya se encuentra dada de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idCategoria = dgvCategorias.CurrentRow.Cells("idcategoria").Value
            If eConfiguracion.darDeBajaCategoria = True Then
                cargarCategorias()
                MsgBox("Categoría dada de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnEditarCategoria_Click(sender As Object, e As EventArgs) Handles btnEditarCategoria.Click
        pnlEditarCategoria.Visible = True
        txtNombreCategoria.Enabled = True
        eConfiguracion.idCategoria = dgvCategorias.CurrentRow.Cells("idcategoria").Value
        lblEditarAgregarCat.Text = "Editar"
        eConfiguracion.traerNombreCategoria()
        txtNombreCategoria.Text = eConfiguracion.nombreCategoria
        txtNombreCategoria.Tag = 2
    End Sub

    Private Sub btnGuardarCategoria_Click(sender As Object, e As EventArgs) Handles btnGuardarCategoria.Click
        If txtNombreCategoria.Tag = 1 Then
            If LTrim(txtNombreCategoria.Text) <> "" Then
                eConfiguracion.nombreCategoria = txtNombreCategoria.Text
                eConfiguracion.agregarCategoria()
                MsgBox("Categoría agregada con éxito", MsgBoxStyle.Information, "Configuraciones")
                cargarCategorias()
                txtNombreCategoria.Text = ""
                pnlEditarCategoria.Visible = False
            End If
        Else
            If txtNombreCategoria.Tag = 2 Then
                If LTrim(txtNombreCategoria.Text) <> "" Then
                    eConfiguracion.nombreCategoria = txtNombreCategoria.Text
                    eConfiguracion.nombreEditadoCategoria()
                    cargarCategorias()
                    MsgBox("Nombre editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    txtNombreCategoria.Text = ""
                    pnlEditarCategoria.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelarCat_Click(sender As Object, e As EventArgs) Handles btnCancelarCat.Click
        pnlEditarCategoria.Visible = False
        txtNombreCategoria.Text = ""
    End Sub


    Private Sub btnDestacarCategoria_Click(sender As Object, e As EventArgs) Handles btnDestacarCategoria.Click
        If dgvCategorias.CurrentRow.Cells("destacadoCategoria").Value = 1 Then
            MsgBox("Esta categoría ya se encuentra destacada", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idCategoria = dgvCategorias.CurrentRow.Cells("idcategoria").Value
            If eConfiguracion.destacarCategoria = True Then
                cargarCategorias()
                MsgBox("Categoría destacada con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub


#End Region
#Region "Localidades"
    Dim idProvincia As UInt16



    Private Sub btnBajaLocalidad_Click(sender As Object, e As EventArgs) Handles btnBajaLocalidad.Click
        If dgvLocalidades.CurrentRow.Cells("activoLocalidad").Value = 0 Then
            MsgBox("Esta localidad ya se encuentra dada de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idlocalidad = dgvLocalidades.CurrentRow.Cells("idlocalidad").Value
            If eConfiguracion.darDeBajaLocalidad = True Then
                cargarLocalidades()
                MsgBox("Localidad dada de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub


    Private Sub btnAltaLocalidad_Click(sender As Object, e As EventArgs) Handles btnAltaLocalidad.Click
        If dgvLocalidades.CurrentRow.Cells("activoLocalidad").Value = 1 Then
            MsgBox("Esta localidad ya se encuentra activa", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idlocalidad = dgvLocalidades.CurrentRow.Cells("idlocalidad").Value
            If eConfiguracion.darDeAltaLocalidad = True Then
                cargarLocalidades()
                MsgBox("Localidad dada de alta con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnCancelarLoc_Click(sender As Object, e As EventArgs) Handles btnCancelarLoc.Click
        pnlEditarLocalidad.Visible = False
        txtNombreLocalidad.Text = ""
        cbProvincias.SelectedIndex = 6
    End Sub

    Private Sub btnEditarLocalidad_Click(sender As Object, e As EventArgs) Handles btnEditarLocalidad.Click
        cargarProvincias()
        pnlEditarLocalidad.Visible = True
        txtNombreLocalidad.Enabled = True
        eConfiguracion.idlocalidad = dgvLocalidades.CurrentRow.Cells("idlocalidad").Value
        idProvincia = dgvLocalidades.CurrentRow.Cells("provincia").Value
        eConfiguracion.nombreLocalidad = dgvLocalidades.CurrentRow.Cells("nombLocalidad").Value
        lblEditarAgregarLoc.Text = "Editar"
        cbProvincias.SelectedValue = idProvincia
        txtNombreLocalidad.Text = eConfiguracion.nombreLocalidad
        'Numero de tag para realizar la opcion de editar
        txtNombreLocalidad.Tag = 2
    End Sub

    Private Sub btnNuevaLocalidad_Click(sender As Object, e As EventArgs) Handles btnNuevaLocalidad.Click
        pnlEditarLocalidad.Visible = True
        lblEditarAgregarLoc.Text = "Agregar"
        idProvincia = dgvLocalidades.CurrentRow.Cells("provincia").Value
        txtNombreLocalidad.Text = ""
        txtNombreLocalidad.Enabled = True
        txtNombreLocalidad.Tag = 1
        cargarProvincias()
        cbProvincias.SelectedIndex = 6
    End Sub
    Private Sub btnGuardarLocalidad_Click(sender As Object, e As EventArgs) Handles btnGuardarLocalidad.Click
        If txtNombreLocalidad.Tag = 1 Then
            If LTrim(txtNombreLocalidad.Text) <> "" Then
                eConfiguracion.nombreLocalidad = txtNombreLocalidad.Text
                eConfiguracion.idProvincia = idProvincia
                eConfiguracion.agregarLocalidad()
                MsgBox("Localidad agregada con éxito", MsgBoxStyle.Information, "Configuraciones")
                cargarLocalidades()
                txtNombreLocalidad.Text = ""
                pnlEditarLocalidad.Visible = False
            End If
        End If
        If txtNombreLocalidad.Tag = 2 Then
            If LTrim(txtNombreLocalidad.Text) <> "" Then
                eConfiguracion.nombreLocalidad = txtNombreLocalidad.Text
                eConfiguracion.idProvincia = idProvincia
                eConfiguracion.localidadEditada()
                cargarLocalidades()
                MsgBox("Localidad editada con éxito", MsgBoxStyle.Information, "Configuraciones")
                txtNombreLocalidad.Text = ""
                pnlEditarLocalidad.Visible = False
            End If
        End If
    End Sub
#End Region
End Class