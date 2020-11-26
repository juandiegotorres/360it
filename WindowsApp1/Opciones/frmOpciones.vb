Public Class frmOpciones
    Dim eConfiguracion As New Entidades.Configuracion
    Dim tablaFormPago, tablaCategorias, tablaLocalidades, tablaProvincias, tablaRubros, tablaTiposArticulo, tablaEstados As New DataTable
    Private Sub frmOpciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarFormPago()
        cargarCategorias()
        cargarLocalidades()
        cargarRubros()
        cargarTiposArticulo()
        cargarEstados()
        pnlEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
    Public Sub cargarRubros()
        tablaRubros.Clear()
        eConfiguracion.traerRubros(tablaRubros)
        dgvRubros.DataSource = tablaRubros
    End Sub
    Public Sub cargarTiposArticulo()
        tablaTiposArticulo.Clear()
        eConfiguracion.traerTipoArticulos(tablaTiposArticulo)
        dgvTipoArticulos.DataSource = tablaTiposArticulo
    End Sub
    Public Sub cargarEstados()
        tablaEstados.Clear()
        eConfiguracion.traerEstados(tablaEstados)
        dgvEstados.DataSource = tablaEstados
    End Sub
#Region "Form Pago"
    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        If pnlEditar.Visible = True Then
            Call btnCancelar_Click(btnCancelar, e)
        End If
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
        If pnlEditar.Visible = True Then
            Call btnCancelar_Click(btnCancelar, e)
        End If
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
        If pnlEditar.Visible = True Then
            Call btnCancelar_Click(btnCancelar, e)
        End If
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
        If pnlEditarCategoria.Visible = True Then
            Call btnCancelarCat_Click(btnCancelarCat, e)
        End If
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
        If pnlEditarCategoria.Visible = True Then
            Call btnCancelarCat_Click(btnCancelarCat, e)
        End If
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
        If pnlEditarCategoria.Visible = True Then
            Call btnCancelarCat_Click(btnCancelarCat, e)
        End If
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
        If pnlEditarLocalidad.Visible = True Then
            Call btnCancelarLoc_Click(btnCancelarLoc, e)
        End If
        If dgvLocalidades.CurrentRow.Cells("activoLocalidad").Value = 0 Then
            MsgBox("Esta localidad ya se encuentra dada de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        ElseIf dgvLocalidades.CurrentRow.Cells("activoLocalidad").Value = 2 Then
            MsgBox("Esta localidad no se puede dar de baja, es la localidad por defecto", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idlocalidad = dgvLocalidades.CurrentRow.Cells("idlocalidad").Value
            If eConfiguracion.darDeBajaLocalidad = True Then
                cargarLocalidades()
                MsgBox("Localidad dada de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub


    Private Sub btnAltaLocalidad_Click(sender As Object, e As EventArgs) Handles btnAltaLocalidad.Click
        If pnlEditarLocalidad.Visible = True Then
            Call btnCancelarLoc_Click(btnCancelarLoc, e)
        End If
        If dgvLocalidades.CurrentRow.Cells("activoLocalidad").Value = 1 Or 2 Then
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
#Region "Rubros"
    Private Sub btnAgregarRubro_Click(sender As Object, e As EventArgs) Handles btnAgregarRubro.Click
        pnlEditarRubro.Visible = True
        lblEditarAgregarRub.Text = "Agregar"
        txtNombreRubro.Text = ""
        txtNombreRubro.Enabled = True
        txtNombreRubro.Tag = 1
    End Sub

    Private Sub btnCancelarRubro_Click(sender As Object, e As EventArgs) Handles btnCancelarRubro.Click
        pnlEditarRubro.Visible = False
        txtNombreRubro.Text = ""
    End Sub



    Private Sub btnEditarRubro_Click(sender As Object, e As EventArgs) Handles btnEditarRubro.Click
        pnlEditarRubro.Visible = True
        txtNombreRubro.Enabled = True
        eConfiguracion.idRubro = dgvRubros.CurrentRow.Cells("idrubro").Value
        lblEditarAgregarRub.Text = "Editar"
        eConfiguracion.nombreRubro = dgvRubros.CurrentRow.Cells("nombRubro").Value
        txtNombreRubro.Text = eConfiguracion.nombreRubro
        txtNombreRubro.Tag = 2
    End Sub


    Private Sub btnBajaRubro_Click(sender As Object, e As EventArgs) Handles btnBajaRubro.Click
        If pnlEditarRubro.Visible = True Then
            Call btnCancelarRubro_Click(btnCancelarRubro, e)
        End If
        If dgvRubros.CurrentRow.Cells("activoRubro").Value = 0 Then
            MsgBox("Este rubro ya se encuentra dado de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idRubro = dgvRubros.CurrentRow.Cells("idrubro").Value
            If eConfiguracion.darDeBajaRubro = True Then
                cargarRubros()
                MsgBox("Rubro dado de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub


    Private Sub btnAltaRubro_Click(sender As Object, e As EventArgs) Handles btnAltaRubro.Click
        If pnlEditarRubro.Visible = True Then
            Call btnCancelarRubro_Click(btnCancelarRubro, e)
        End If
        If dgvRubros.CurrentRow.Cells("activoRubro").Value = 1 Then
            MsgBox("Este rubro ya se encuentra activo", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idRubro = dgvRubros.CurrentRow.Cells("idrubro").Value
            If eConfiguracion.darDeAltaRubro = True Then
                cargarRubros()
                MsgBox("Rubro dado de alta con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub


    Private Sub btnGuardarRubro_Click(sender As Object, e As EventArgs) Handles btnGuardarRubro.Click
        If txtNombreRubro.Tag = 1 Then
            If LTrim(txtNombreRubro.Text) <> "" Then
                eConfiguracion.nombreRubro = txtNombreRubro.Text
                eConfiguracion.agregarRubro()
                MsgBox("Rubro agregado con éxito", MsgBoxStyle.Information, "Configuraciones")
                cargarRubros()
                txtNombreRubro.Text = ""
                pnlEditarRubro.Visible = False
            End If
        Else
            If txtNombreRubro.Tag = 2 Then
                If LTrim(txtNombreRubro.Text) <> "" Then
                    eConfiguracion.nombreRubro = txtNombreRubro.Text
                    eConfiguracion.nombreEditadoRubro()
                    cargarRubros()
                    MsgBox("Nombre editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    txtNombreRubro.Text = ""
                    pnlEditarRubro.Visible = False
                End If
            End If
        End If
    End Sub


#End Region
#Region "Tipos de articulo"
    Private Sub btnAgregarArticulo_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulo.Click
        pnlEditarArticulo.Visible = True
        lblEditarAgregarArt.Text = "Agregar"
        txtNombreArticulo.Text = ""
        txtNombreArticulo.Enabled = True
        txtNombreArticulo.Tag = 1
    End Sub

    Private Sub btnEditarArticulo_Click(sender As Object, e As EventArgs) Handles btnEditarArticulo.Click
        pnlEditarArticulo.Visible = True
        txtNombreArticulo.Enabled = True
        eConfiguracion.idTipoArticulo = dgvTipoArticulos.CurrentRow.Cells("idtipoarticulo").Value
        lblEditarAgregarArt.Text = "Editar"
        eConfiguracion.nombreArticulo = dgvTipoArticulos.CurrentRow.Cells("tipoArticulo").Value
        txtNombreArticulo.Text = eConfiguracion.nombreArticulo
        txtNombreArticulo.Tag = 2
    End Sub

    Private Sub btnBajaArticulo_Click(sender As Object, e As EventArgs) Handles btnBajaArticulo.Click
        If pnlEditarArticulo.Visible = True Then
            Call btnCancelarArt_Click(btnCancelarArt, e)
        End If
        If dgvTipoArticulos.CurrentRow.Cells("activoTipoArticulo").Value = 0 Then
            MsgBox("Este tipo de artículo ya se encuentra dado de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idTipoArticulo = dgvTipoArticulos.CurrentRow.Cells("idtipoarticulo").Value
            If eConfiguracion.darDeBajaTipoArticulo = True Then
                cargarTiposArticulo()
                MsgBox("Tipo de artículo dado de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnAltaArticulo_Click(sender As Object, e As EventArgs) Handles btnAltaArticulo.Click
        If pnlEditarArticulo.Visible = True Then
            Call btnCancelarArt_Click(btnCancelarArt, e)
        End If
        If dgvTipoArticulos.CurrentRow.Cells("activoTipoArticulo").Value = 1 Then
            MsgBox("Este tipo de artículo ya se encuentra activo", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idTipoArticulo = dgvTipoArticulos.CurrentRow.Cells("idtipoarticulo").Value
            If eConfiguracion.darDeAltaTipoArticulo = True Then
                cargarTiposArticulo()
                MsgBox("Tipo de artículo de alta con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnGuardarArticulo_Click(sender As Object, e As EventArgs) Handles btnGuardarArticulo.Click
        If txtNombreArticulo.Tag = 1 Then
            If LTrim(txtNombreArticulo.Text) <> "" Then
                eConfiguracion.nombreArticulo = txtNombreArticulo.Text
                eConfiguracion.agregarTipoArticulo()
                MsgBox("Tipo artículo agregado con éxito", MsgBoxStyle.Information, "Configuraciones")
                cargarTiposArticulo()
                txtNombreArticulo.Text = ""
                pnlEditarArticulo.Visible = False
            End If
        Else
            If txtNombreArticulo.Tag = 2 Then
                If LTrim(txtNombreArticulo.Text) <> "" Then
                    eConfiguracion.nombreArticulo = txtNombreArticulo.Text
                    eConfiguracion.nombreEditadoTipoArticulo()
                    cargarTiposArticulo()
                    MsgBox("Tipo de artículo editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    txtNombreArticulo.Text = ""
                    pnlEditarArticulo.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelarArt_Click(sender As Object, e As EventArgs) Handles btnCancelarArt.Click
        pnlEditarArticulo.Visible = False
        txtNombreArticulo.Text = ""
    End Sub

    Private Sub pnlEditarArticulo_LocationChanged(sender As Object, e As EventArgs) Handles pnlEditarArticulo.LocationChanged

        Call btnCancelarArt_Click(btnCancelarArt, e)

    End Sub

    Private Sub pnlEditarArticulo_LostFocus(sender As Object, e As EventArgs) Handles pnlEditarArticulo.LostFocus
        Call btnCancelarArt_Click(btnCancelarArt, e)
    End Sub

    Private Sub pnlEditarArticulo_Leave(sender As Object, e As EventArgs) Handles pnlEditarArticulo.Leave
        Call btnCancelarArt_Click(btnCancelarArt, e)

    End Sub


#End Region
#Region "Estados"
    Private Sub btnAgregarEstado_Click(sender As Object, e As EventArgs) Handles btnAgregarEstado.Click
        pnlEditarEstado.Visible = True
        lblAgregarEditarEst.Text = "Agregar"
        txtNombreEstado.Text = ""
        txtNombreEstado.Enabled = True
        txtNombreEstado.Tag = 1
    End Sub


    Private Sub btnEditarEstado_Click(sender As Object, e As EventArgs) Handles btnEditarEstado.Click
        pnlEditarEstado.Visible = True
        txtNombreEstado.Enabled = True
        eConfiguracion.idEstado = dgvEstados.CurrentRow.Cells("idestado").Value
        lblEditarAgregarCat.Text = "Editar"
        eConfiguracion.nombreEstado = dgvEstados.CurrentRow.Cells("nombreEstado").Value
        txtNombreEstado.Text = eConfiguracion.nombreEstado
        txtNombreEstado.Text = eConfiguracion.nombreEstado
        txtNombreEstado.Tag = 2
    End Sub

    Private Sub btnBajaEstado_Click(sender As Object, e As EventArgs) Handles btnBajaEstado.Click
        If pnlEditarEstado.Visible = True Then
            Call btnCancelarEstado_Click(btnCancelarEstado, e)
        End If
        If dgvEstados.CurrentRow.Cells("activoEstado").Value = 0 Then
            MsgBox("Este estado ya se encuentra dado de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idEstado = dgvEstados.CurrentRow.Cells("idestado").Value
            If eConfiguracion.darDeBajaEstado = True Then
                cargarEstados()
                MsgBox("Estado dado de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnAltaEstado_Click(sender As Object, e As EventArgs) Handles btnAltaEstado.Click
        If pnlEditarArticulo.Visible = True Then
            Call btnCancelarEstado_Click(btnCancelarEstado, e)
        End If
        If dgvEstados.CurrentRow.Cells("activoEstado").Value = 1 Then
            MsgBox("Este estado ya se encuentra activo", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idEstado = dgvEstados.CurrentRow.Cells("idestado").Value
            If eConfiguracion.darDeAltaEstado = True Then
                cargarEstados()
                MsgBox("Estado dado de alta con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnDestacarEstado_Click(sender As Object, e As EventArgs) Handles btnDestacarEstado.Click
        If pnlEditarEstado.Visible = True Then
            Call btnCancelarEstado_Click(btnCancelarEstado, e)
        End If
        If dgvEstados.CurrentRow.Cells("destacadoEstado").Value = 1 Then
            MsgBox("Est estado ya se encuentra destacado", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idEstado = dgvEstados.CurrentRow.Cells("idestado").Value
            If eConfiguracion.destacarEstado = True Then
                cargarEstados()
                MsgBox("Estado destacado con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnGuardarEstado_Click(sender As Object, e As EventArgs) Handles btnGuardarEstado.Click
        If txtNombreEstado.Tag = 1 Then
            If LTrim(txtNombreEstado.Text) <> "" Then
                eConfiguracion.nombreEstado = txtNombreEstado.Text
                eConfiguracion.agregarEstado()
                MsgBox("Estado agregado con éxito", MsgBoxStyle.Information, "Configuraciones")
                cargarEstados()
                txtNombreEstado.Text = ""
                pnlEditarEstado.Visible = False
            End If
        Else
            If txtNombreEstado.Tag = 2 Then
                If LTrim(txtNombreEstado.Text) <> "" Then
                    eConfiguracion.nombreEstado = txtNombreEstado.Text
                    eConfiguracion.nombreEditadoEstado()
                    cargarEstados()
                    MsgBox("Nombre editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    txtNombreEstado.Text = ""
                    pnlEditarEstado.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelarEstado_Click(sender As Object, e As EventArgs) Handles btnCancelarEstado.Click
        pnlEditarEstado.Visible = False
        txtNombreEstado.Text = ""
    End Sub
#End Region
End Class