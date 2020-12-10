Public Class frmOpciones
    Dim eConfiguracion As New Entidades.Opcion
    Dim idGeneral As UInt64
    Dim idGeneralTodos As New List(Of UInt64)
    Dim tablaFormPago, tablaCategorias, tablaLocalidades, tablaProvincias, tablaRubros, tablaTiposArticulo, tablaEstados, tablaClientes, tablaProductos, tablaProveedores, tablaServTec, tablaVentas, tablaNotas, tablaClientesFEchas As New DataTable
    Private Sub frmOpciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarFormPago()
        cargarCategorias()
        cargarLocalidades()
        cargarRubros()
        cargarTiposArticulo()
        cargarEstados()
        'Clientes
        cargarDatosBajas(tablaClientes, dgvClientes, "clientes", "*")
        'Productos
        cargarDatosBajas(tablaProductos, dgvProductos, "productos", "*")
        'Proveedores
        cargarDatosBajas(tablaProveedores, dgvProveedores, "proveedores", "*")
        'Serv Tecnico
        cargarDatosBajas(tablaServTec, dgvServTec, "serviciotecnico", "*")
        'Notas
        cargarDatosBajas(tablaNotas, dgvNotas, "notas", "*")
        'Clientes Fechas
        cargarDatosBajas(tablaClientesFEchas, dgvClientesFechas, "clientes", "nombreApel, dni, fechaCreacion, fechaModificacion", True)
        'Ventas 
        cargarDatosBajas(tablaVentas, dgvVentas, "ventas", "*")
        pnlEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlEditarEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    End Sub
    Public Sub cargarDatosBajas(ByRef tabla As DataTable, ByRef datagrid As DataGridView, ByVal tablaDB As String, ByVal condiciones As String, ByRef Optional activo As Boolean = False)
        tabla.Clear()
        eConfiguracion.traerDatosGeneral(tablaDB, condiciones, tabla, activo)
        datagrid.DataSource = tabla
    End Sub
    Public Sub cargarClientes()
        tablaClientes.Clear()
        eConfiguracion.traerDatosGeneral("clientes", "*", tablaClientes)
        dgvClientes.DataSource = tablaClientes
    End Sub
    Public Sub cargarProductos()
        tablaProductos.Clear()
        eConfiguracion.traerDatosGeneral("productos", "*", tablaProductos)
        dgvProductos.DataSource = tablaProductos
    End Sub
    Public Sub cargarProveedores()
        tablaProveedores.Clear()
        eConfiguracion.traerDatosGeneral("proveedores", "*", tablaProveedores)
        dgvProductos.DataSource = tablaProveedores
    End Sub
    Public Sub cargarServTec()
        tablaServTec.Clear()
        eConfiguracion.traerDatosGeneral("serviciotecnico", "*", tablaServTec)
        dgvServTec.DataSource = tablaServTec
    End Sub

    'Public Sub cargarDatosGeneral(ByRef tabla As DataTable, ByRef datagrid As DataGridView, ByVal nombreProcedimiento As MethodInvoker)
    '    tabla.Clear()
    '    eConfiguracion.----(tablaFormPago)
    '    dgvFormPago.DataSource = tablaFormPago
    'End Sub
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
        habilitarDeshabilitarControles(pnlEditar, False)
        If dgvFormPago.CurrentRow.Cells("activo").Value = 0 Then
            MsgBox("Esta forma de pago ya se encuentra dada de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        ElseIf dgvFormPago.CurrentRow.Cells("destacado").Value = 1 Then
            MsgBox("No se puede dar de baja un elemento destacado", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idFormPago = dgvFormPago.CurrentRow.Cells("idFormPago").Value
            If eConfiguracion.darDeBajaPago = True Then
                cargarFormPago()
                MsgBox("Forma de pago dada de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnDarAlta_Click(sender As Object, e As EventArgs) Handles btnDarAlta.Click
        habilitarDeshabilitarControles(pnlEditar, False)
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
        habilitarDeshabilitarControles(pnlEditar, False)
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
        habilitarDeshabilitarControles(pnlEditar, True)
        txtNombre.Enabled = False
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
                habilitarDeshabilitarControles(pnlEditar, False)
            End If
        Else
            If txtNombre.Enabled = True Then
                If LTrim(txtNombre.Text) <> "" Then
                    eConfiguracion.nombreFormPago = txtNombre.Text
                    eConfiguracion.nombreEditado()
                    cargarFormPago()
                    MsgBox("Nombre editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    habilitarDeshabilitarControles(pnlEditar, False)
                End If
            End If
            If txtRecargo.Enabled = True Then
                If LTrim(txtRecargo.Text) <> "" Then
                    eConfiguracion.recargo = txtRecargo.Text
                    eConfiguracion.recargoEditado()
                    cargarFormPago()
                    MsgBox("Recargo editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    habilitarDeshabilitarControles(pnlEditar, False)
                End If
            End If
        End If

    End Sub

    Private Sub btnEditarRecargo_Click(sender As Object, e As EventArgs) Handles btnEditarRecargo.Click
        habilitarDeshabilitarControles(pnlEditar, True)
        txtNombre.Enabled = False
        eConfiguracion.idFormPago = dgvFormPago.CurrentRow.Cells("idFormPago").Value
        lblEditarAgregar.Text = "Editar"
        eConfiguracion.traerRecargo()
        txtRecargo.Text = eConfiguracion.recargo
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        habilitarDeshabilitarControles(pnlEditar, False)
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        habilitarDeshabilitarControles(pnlEditar, True)
        lblEditarAgregar.Text = "Agregar"
    End Sub


#End Region
#Region "Categorias"
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        habilitarDeshabilitarControles(pnlEditarCategoria, True)
        lblEditarAgregarCat.Text = "Agregar"
        txtNombreCategoria.Tag = 1
    End Sub

    Private Sub btnAltaCategoria_Click(sender As Object, e As EventArgs) Handles btnAltaCategoria.Click
        habilitarDeshabilitarControles(pnlEditarCategoria, False)
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
        habilitarDeshabilitarControles(pnlEditarCategoria, False)
        If dgvCategorias.CurrentRow.Cells("activoCategoria").Value = 0 Then
            MsgBox("Esta categoría ya se encuentra dada de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        ElseIf dgvCategorias.CurrentRow.Cells("destacadoCategoria").Value = 1 Then
            MsgBox("No se puede dar de baja un elemento destacado", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idCategoria = dgvCategorias.CurrentRow.Cells("idcategoria").Value
            If eConfiguracion.darDeBajaCategoria = True Then
                cargarCategorias()
                MsgBox("Categoría dada de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub
    Private Sub habilitarDeshabilitarControles(ByRef _panel As Panel, ByRef habilitar As Boolean)
        If habilitar = True Then
            Dim _control As Control
            For Each _control In _panel.Controls
                If TypeOf _control Is TextBox Then
                    _control.Text = ""
                End If
                If TypeOf _control Is ComboBox Then
                    _control.Text = ""
                End If
                _control.Enabled = True
            Next
        Else
            Dim _control As Control
            For Each _control In _panel.Controls
                If TypeOf _control Is TextBox Then
                    _control.Text = ""
                End If
                If TypeOf _control Is ComboBox Then
                    _control.Text = ""
                End If
                _control.Enabled = False
            Next
        End If

    End Sub
    Private Sub btnEditarCategoria_Click(sender As Object, e As EventArgs) Handles btnEditarCategoria.Click
        habilitarDeshabilitarControles(pnlEditarCategoria, True)
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
                habilitarDeshabilitarControles(pnlEditarCategoria, False)
            End If
        Else
            If txtNombreCategoria.Tag = 2 Then
                If LTrim(txtNombreCategoria.Text) <> "" Then
                    eConfiguracion.nombreCategoria = txtNombreCategoria.Text
                    eConfiguracion.nombreEditadoCategoria()
                    cargarCategorias()
                    MsgBox("Nombre editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    habilitarDeshabilitarControles(pnlEditarCategoria, False)
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelarCat_Click(sender As Object, e As EventArgs) Handles btnCancelarCat.Click
        habilitarDeshabilitarControles(pnlEditarCategoria, False)
    End Sub


    Private Sub btnDestacarCategoria_Click(sender As Object, e As EventArgs) Handles btnDestacarCategoria.Click
        habilitarDeshabilitarControles(pnlEditarCategoria, False)
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
    Private Sub dgvCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellClick
        habilitarDeshabilitarControles(pnlEditarCategoria, False)
    End Sub

#End Region
#Region "Localidades"
    Dim idProvincia As UInt16



    Private Sub btnBajaLocalidad_Click(sender As Object, e As EventArgs) Handles btnBajaLocalidad.Click
        habilitarDeshabilitarControles(pnlEditarLocalidad, False)
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
        habilitarDeshabilitarControles(pnlEditarLocalidad, False)
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
        habilitarDeshabilitarControles(pnlEditarLocalidad, False)
    End Sub

    Private Sub btnEditarLocalidad_Click(sender As Object, e As EventArgs) Handles btnEditarLocalidad.Click
        habilitarDeshabilitarControles(pnlEditarLocalidad, True)
        cargarProvincias()
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
        habilitarDeshabilitarControles(pnlEditarLocalidad, True)
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
                habilitarDeshabilitarControles(pnlEditarLocalidad, False)
            End If
        End If
        If txtNombreLocalidad.Tag = 2 Then
            If LTrim(txtNombreLocalidad.Text) <> "" Then
                eConfiguracion.nombreLocalidad = txtNombreLocalidad.Text
                eConfiguracion.idProvincia = idProvincia
                eConfiguracion.localidadEditada()
                cargarLocalidades()
                MsgBox("Localidad editada con éxito", MsgBoxStyle.Information, "Configuraciones")
                habilitarDeshabilitarControles(pnlEditarLocalidad, False)
            End If
        End If
    End Sub


#End Region
#Region "Rubros"
    Private Sub btnAgregarRubro_Click(sender As Object, e As EventArgs) Handles btnAgregarRubro.Click
        habilitarDeshabilitarControles(pnlEditarRubro, True)
        lblEditarAgregarRub.Text = "Agregar"
        txtNombreRubro.Text = ""
        txtNombreRubro.Enabled = True
        txtNombreRubro.Tag = 1
    End Sub

    Private Sub btnCancelarRubro_Click(sender As Object, e As EventArgs) Handles btnCancelarRubro.Click
        habilitarDeshabilitarControles(pnlEditarRubro, False)
    End Sub



    Private Sub btnEditarRubro_Click(sender As Object, e As EventArgs) Handles btnEditarRubro.Click
        habilitarDeshabilitarControles(pnlEditarRubro, True)
        eConfiguracion.idRubro = dgvRubros.CurrentRow.Cells("idrubro").Value
        lblEditarAgregarRub.Text = "Editar"
        eConfiguracion.nombreRubro = dgvRubros.CurrentRow.Cells("nombRubro").Value
        txtNombreRubro.Text = eConfiguracion.nombreRubro
        txtNombreRubro.Tag = 2
    End Sub


    Private Sub btnBajaRubro_Click(sender As Object, e As EventArgs) Handles btnBajaRubro.Click
        habilitarDeshabilitarControles(pnlEditarRubro, False)
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
        habilitarDeshabilitarControles(pnlEditarRubro, False)
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
                habilitarDeshabilitarControles(pnlEditarRubro, False)
            End If
        Else
            If txtNombreRubro.Tag = 2 Then
                If LTrim(txtNombreRubro.Text) <> "" Then
                    eConfiguracion.nombreRubro = txtNombreRubro.Text
                    eConfiguracion.nombreEditadoRubro()
                    cargarRubros()
                    MsgBox("Nombre editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    habilitarDeshabilitarControles(pnlEditarRubro, False)
                End If
            End If
        End If
    End Sub


#End Region
#Region "Tipos de articulo"
    Private Sub btnAgregarArticulo_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulo.Click
        habilitarDeshabilitarControles(pnlEditarArticulo, True)
        lblEditarAgregarArt.Text = "Agregar"
        txtNombreArticulo.Text = ""
        txtNombreArticulo.Enabled = True
        txtNombreArticulo.Tag = 1
    End Sub

    Private Sub btnEditarArticulo_Click(sender As Object, e As EventArgs) Handles btnEditarArticulo.Click
        habilitarDeshabilitarControles(pnlEditarArticulo, True)
        eConfiguracion.idTipoArticulo = dgvTipoArticulos.CurrentRow.Cells("idtipoarticulo").Value
        lblEditarAgregarArt.Text = "Editar"
        eConfiguracion.nombreArticulo = dgvTipoArticulos.CurrentRow.Cells("tipoArticulo").Value
        txtNombreArticulo.Text = eConfiguracion.nombreArticulo
        txtNombreArticulo.Tag = 2
    End Sub

    Private Sub btnBajaArticulo_Click(sender As Object, e As EventArgs) Handles btnBajaArticulo.Click
        habilitarDeshabilitarControles(pnlEditarArticulo, False)
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
        habilitarDeshabilitarControles(pnlEditarArticulo, False)
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
                habilitarDeshabilitarControles(pnlEditarArticulo, False)

            End If
        Else
            If txtNombreArticulo.Tag = 2 Then
                If LTrim(txtNombreArticulo.Text) <> "" Then
                    eConfiguracion.nombreArticulo = txtNombreArticulo.Text
                    eConfiguracion.nombreEditadoTipoArticulo()
                    cargarTiposArticulo()
                    MsgBox("Tipo de artículo editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    habilitarDeshabilitarControles(pnlEditarArticulo, False)

                End If
            End If
        End If
    End Sub

    Private Sub btnCancelarArt_Click(sender As Object, e As EventArgs) Handles btnCancelarArt.Click
        habilitarDeshabilitarControles(pnlEditarArticulo, False)

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
        habilitarDeshabilitarControles(pnlEditarEstado, True)

        lblAgregarEditarEst.Text = "Agregar"
        txtNombreEstado.Text = ""
        txtNombreEstado.Enabled = True
        txtNombreEstado.Tag = 1
    End Sub


    Private Sub btnBajas_Click(sender As Object, e As EventArgs) Handles btnBajas.Click

        tabConfiguraciones.Visible = False
        tabBajas.Visible = True
    End Sub


    Private Sub btnOpcionesGenerales_Click(sender As Object, e As EventArgs) Handles btnOpcionesGenerales.Click

        tabBajas.Visible = False
        tabConfiguraciones.Visible = True
    End Sub

    Private Sub btnEditarEstado_Click(sender As Object, e As EventArgs) Handles btnEditarEstado.Click
        habilitarDeshabilitarControles(pnlEditarEstado, True)
        eConfiguracion.idEstado = dgvEstados.CurrentRow.Cells("idestado").Value
        lblEditarAgregarCat.Text = "Editar"
        eConfiguracion.nombreEstado = dgvEstados.CurrentRow.Cells("nombreEstado").Value
        txtNombreEstado.Text = eConfiguracion.nombreEstado
        txtNombreEstado.Text = eConfiguracion.nombreEstado
        txtNombreEstado.Tag = 2
    End Sub

    Private Sub btnBajaEstado_Click(sender As Object, e As EventArgs) Handles btnBajaEstado.Click
        habilitarDeshabilitarControles(pnlEditarEstado, False)
        If dgvEstados.CurrentRow.Cells("activoEstado").Value = 0 Then
            MsgBox("Este estado ya se encuentra dado de baja", MsgBoxStyle.Exclamation, "Configuraciones")
        ElseIf dgvEstados.CurrentRow.Cells("destacadoEstado").Value = 1 Then
            MsgBox("No se puede dar de baja un elemento destacado", MsgBoxStyle.Exclamation, "Configuraciones")
        Else
            eConfiguracion.idEstado = dgvEstados.CurrentRow.Cells("idestado").Value
            If eConfiguracion.darDeBajaEstado = True Then
                cargarEstados()
                MsgBox("Estado dado de baja con éxito", MsgBoxStyle.Information, "Configuraciones")
            End If
        End If
    End Sub

    Private Sub btnAltaEstado_Click(sender As Object, e As EventArgs) Handles btnAltaEstado.Click
        habilitarDeshabilitarControles(pnlEditarEstado, False)
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
        habilitarDeshabilitarControles(pnlEditarEstado, False)
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
                habilitarDeshabilitarControles(pnlEditarEstado, False)
            End If
        Else
            If txtNombreEstado.Tag = 2 Then
                If LTrim(txtNombreEstado.Text) <> "" Then
                    eConfiguracion.nombreEstado = txtNombreEstado.Text
                    eConfiguracion.nombreEditadoEstado()
                    cargarEstados()
                    MsgBox("Nombre editado con éxito", MsgBoxStyle.Information, "Configuraciones")
                    habilitarDeshabilitarControles(pnlEditarEstado, False)
                End If
            End If
        End If
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub



    Private Sub btnCancelarEstado_Click(sender As Object, e As EventArgs) Handles btnCancelarEstado.Click
        pnlEditarEstado.Visible = False
        txtNombreEstado.Text = ""
    End Sub


#End Region
#Region "BAJAS(Botones)"
    Private Sub btnAltaCliente_Click(sender As Object, e As EventArgs) Handles btnAltaCliente.Click
        If dgvClientes.Rows.Count = 0 Then
            MsgBox("No hay nada para restaurar", MsgBoxStyle.Critical, "Bajas")
        Else
            If MsgBox("¿Desea restaurar este elemento?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneral = 0
                idGeneral = dgvClientes.CurrentRow.Cells("idcliente").Value
                If eConfiguracion.altaGeneral("clientes", "idcliente", idGeneral) = True Then
                    cargarDatosBajas(tablaClientes, dgvClientes, "clientes", "*")
                    MsgBox("Restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podidorestaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaProducto_Click(sender As Object, e As EventArgs) Handles btnAltaProducto.Click
        If dgvProductos.Rows.Count = 0 Then
            MsgBox("No hay nada para restaurar", MsgBoxStyle.Critical, "Bajas")
        Else
            If MsgBox("¿Desea restaurar este elemento?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneral = 0
                idGeneral = dgvProductos.CurrentRow.Cells("idProducto").Value
                If eConfiguracion.altaGeneral("productos", "idProducto", idGeneral) = True Then
                    cargarDatosBajas(tablaProductos, dgvProductos, "productos", "*")
                    MsgBox("Restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podidorestaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaProveedor_Click(sender As Object, e As EventArgs) Handles btnAltaProveedor.Click
        If dgvProveedores.Rows.Count = 0 Then
            MsgBox("No hay nada para restaurar", MsgBoxStyle.Critical, "Bajas")
        Else
            If MsgBox("¿Desea restaurar este elemento?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneral = 0
                idGeneral = dgvProveedores.CurrentRow.Cells("idproveedor").Value
                If eConfiguracion.altaGeneral("proveedores", "idproveedor", idGeneral) = True Then
                    cargarDatosBajas(tablaProveedores, dgvProveedores, "proveedores", "*")
                    MsgBox("Restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podidorestaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaServTec_Click(sender As Object, e As EventArgs) Handles btnAltaServTec.Click
        If dgvServTec.Rows.Count = 0 Then
            MsgBox("No hay nada para restaurar", MsgBoxStyle.Critical, "Bajas")
        Else
            If MsgBox("¿Desea restaurar este elemento?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneral = 0
                idGeneral = dgvServTec.CurrentRow.Cells("idReparacion").Value
                If dgvServTec.CurrentRow.Selected = True Then
                    If eConfiguracion.altaGeneral("serviciotecnico", "idReparacion", idGeneral) = True Then
                        cargarDatosBajas(tablaServTec, dgvServTec, "serviciotecnico", "*")
                        MsgBox("Restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                    Else
                        MsgBox("No se ha podidorestaurar", MsgBoxStyle.Information, "Bajas")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaClienteTodos_Click(sender As Object, e As EventArgs) Handles btnAltaClienteTodos.Click
        If dgvClientes.Rows.Count > 0 Then
            If MsgBox("¿Está seguro que desea realizar esta acción?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneralTodos.Clear()
                For i = 0 To dgvClientes.Rows.Count - 1
                    idGeneralTodos.Add(dgvClientes.Rows(i).Cells("idcliente").Value)
                Next
                If eConfiguracion.altaGeneralTodos("clientes", "idcliente", idGeneralTodos) = True Then
                    cargarDatosBajas(tablaClientes, dgvClientes, "clientes", "*")
                    MsgBox("Todos los elementos se han restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podido restaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaProductosTodos_Click(sender As Object, e As EventArgs) Handles btnAltaProductosTodos.Click
        If dgvProductos.Rows.Count > 0 Then
            If MsgBox("¿Está seguro que desea realizar esta acción?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneralTodos.Clear()
                For i = 0 To dgvProductos.Rows.Count - 1
                    idGeneralTodos.Add(dgvProductos.Rows(i).Cells("idProducto").Value)
                Next
                If eConfiguracion.altaGeneralTodos("productos", "idProducto", idGeneralTodos) = True Then
                    cargarDatosBajas(tablaProductos, dgvProductos, "productos", "*")
                    MsgBox("Todos los elementos se han restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podido restaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaProveedorTodos_Click(sender As Object, e As EventArgs) Handles btnAltaProveedorTodos.Click
        If dgvServTec.Rows.Count > 0 Then
            If MsgBox("¿Está seguro que desea realizar esta acción?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneralTodos.Clear()
                For i = 0 To dgvProveedores.Rows.Count - 1
                    idGeneralTodos.Add(dgvProveedores.Rows(i).Cells("idproveedor").Value)
                Next
                If eConfiguracion.altaGeneralTodos("proveedores", "idproveedor", idGeneralTodos) = True Then
                    cargarDatosBajas(tablaProveedores, dgvProveedores, "proveedores", "*")
                    MsgBox("Todos los elementos se han restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podido restaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaServTecTodos_Click(sender As Object, e As EventArgs) Handles btnAltaServTecTodos.Click
        If dgvServTec.Rows.Count > 0 Then
            If MsgBox("¿Está seguro que desea realizar esta acción?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneralTodos.Clear()
                For i = 0 To dgvServTec.Rows.Count - 1
                    idGeneralTodos.Add(dgvServTec.Rows(i).Cells("idReparacion").Value)
                Next
                If eConfiguracion.altaGeneralTodos("serviciotecnico", "idReparacion", idGeneralTodos) = True Then
                    cargarDatosBajas(tablaServTec, dgvServTec, "serviciotecnico", "*")
                    MsgBox("Todos los elementos se han restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podido restaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub
    Private Sub btnAltaNota_Click(sender As Object, e As EventArgs) Handles btnAltaNota.Click
        If dgvNotas.Rows.Count = 0 Then
            MsgBox("No hay nada para restaurar", MsgBoxStyle.Critical, "Bajas")
        Else
            If MsgBox("¿Desea restaurar este elemento?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneral = 0
                idGeneral = dgvNotas.CurrentRow.Cells("idnota").Value
                If dgvNotas.CurrentRow.Selected = True Then
                    If eConfiguracion.altaGeneral("notas", "idnota", idGeneral) = True Then
                        cargarDatosBajas(tablaNotas, dgvNotas, "notas", "*")
                        MsgBox("Restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                    Else
                        MsgBox("No se ha podidorestaurar", MsgBoxStyle.Information, "Bajas")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaNotasTodas_Click(sender As Object, e As EventArgs) Handles btnAltaNotasTodas.Click
        If dgvNotas.Rows.Count > 0 Then
            If MsgBox("¿Está seguro que desea realizar esta acción?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneralTodos.Clear()
                For i = 0 To dgvNotas.Rows.Count - 1
                    idGeneralTodos.Add(dgvNotas.Rows(i).Cells("idnota").Value)
                Next
                If eConfiguracion.altaGeneralTodos("notas", "idnota", idGeneralTodos) = True Then
                    cargarDatosBajas(tablaNotas, dgvNotas, "notas", "*")
                    MsgBox("Todos los elementos se han restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podido restaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub


    Private Sub btnAltaVenta_Click(sender As Object, e As EventArgs) Handles btnAltaVenta.Click
        If dgvVentas.Rows.Count = 0 Then
            MsgBox("No hay nada para restaurar", MsgBoxStyle.Critical, "Bajas")
        Else
            If MsgBox("¿Desea restaurar este elemento?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneral = 0
                idGeneral = dgvVentas.CurrentRow.Cells("idVenta").Value
                If dgvVentas.CurrentRow.Selected = True Then
                    eConfiguracion.altaGeneral("movimientos", "venta", idGeneral)
                    If eConfiguracion.altaGeneral("ventas", "idVenta", idGeneral) = True Then
                        cargarDatosBajas(tablaVentas, dgvVentas, "ventas", "*")
                        MsgBox("Restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                    Else
                        MsgBox("No se ha podidorestaurar", MsgBoxStyle.Information, "Bajas")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaVentaTodos_Click(sender As Object, e As EventArgs) Handles btnAltaVentaTodos.Click
        If dgvNotas.Rows.Count > 0 Then
            If MsgBox("¿Está seguro que desea realizar esta acción?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Bajas") = MsgBoxResult.Yes Then
                idGeneralTodos.Clear()
                For i = 0 To dgvVentas.Rows.Count - 1
                    idGeneralTodos.Add(dgvVentas.Rows(i).Cells("idVenta").Value)
                Next
                If eConfiguracion.altaGeneralTodos("ventas", "idVenta", idGeneralTodos) = True Then
                    cargarDatosBajas(tablaVentas, dgvVentas, "ventas", "*")
                    MsgBox("Todos los elementos se han restaurado con éxito", MsgBoxStyle.Information, "Bajas")
                Else
                    MsgBox("No se ha podido restaurar", MsgBoxStyle.Information, "Bajas")
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim detalleVenta As New frmDetalles
            With detalleVenta
                If dgvVentas.SelectedRows.Count = 1 Then
                    .e_Venta.idVenta = dgvVentas.CurrentRow.Cells("idVenta").Value
                    .ShowDialog()
                End If
            End With
        End If
    End Sub

    Private Sub dgvLocalidades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocalidades.CellClick
        habilitarDeshabilitarControles(pnlEditarLocalidad, False)
    End Sub

    Private Sub dgvRubros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellClick
        habilitarDeshabilitarControles(pnlEditarRubro, False)
    End Sub

    Private Sub dgvTipoArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoArticulos.CellClick
        habilitarDeshabilitarControles(pnlEditarArticulo, False)
    End Sub

    Private Sub dgvEstados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstados.CellClick
        habilitarDeshabilitarControles(pnlEditarEstado, False)
    End Sub

    Private Sub dgvFormPago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFormPago.CellClick
        habilitarDeshabilitarControles(pnlEditar, False)
    End Sub
End Class