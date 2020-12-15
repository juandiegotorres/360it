Public Class frmVender

    'Instancio la clae ventas
    Public eVenta As New Entidades.Venta
    'defino las variables para poder guardar los datos del dgv productos para pasarlos hacia el carrito
    Dim idProducto, idProductoCarro As UInt64
    Dim tipo, marca, modelo, filtroBS, filtroElegido As String
    'defino una variable para poder establecer la cantidad de un producto, para asi poder pasarsela al formulario cantidad. Y defino otra para guardar el resultado del formulario
    Dim cantidad, cantidadSeleccionada, cantidadTotalCarrito As UInt16
    Dim precioCosto, precioVenta, precioTotal, subtotal, total, descuento, recargo, precioProductoIndividual As Double
    'Creo la tabla que va a contener los productos en stock para llenar el datagrid
    Dim tablaProductos, tablaBuscador, tablaFormPago, tablaRecargos As New DataTable
    Dim listaProductos, cantidades, precioProductos As New List(Of UInt16)
    Dim bsProductos As New BindingSource
    Private Sub frmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminarDGV.UseColumnTextForButtonValue = True
        btnEliminarDGV.Text = "Eliminar"
        txtFecha.Text = Date.Now.Date
        subtotal = 0
        total = 0
        rbDescuentoPorcentaje.Checked = True
        txtSubtotal.Text = subtotal.ToString("C2")
        txtTotal.Text = total.ToString("C2")
        actualizarProductos()
        cargarRecargos()
        cargarFormPago()
        nroVenta()
        comboBoxBuscarPor()
        dgvProductosLista.Select()
    End Sub
    'Traigo los recargos para que a la hora del usuario elija la forma de pago automaticamente se aplique el recargo.
    Public Sub cargarRecargos()
        tablaRecargos.Clear()
        eVenta.cargarRecargos(tablaRecargos)
    End Sub
    'Traigo los productos desde la base de datos mediante la instancia a la clase ventas
    Public Sub actualizarProductos()
        txtBuscar.Text = ""
        filtroBS = ""
        tablaProductos.Clear()
        eVenta.verProductos(tablaProductos)
        bsProductos.DataSource = tablaProductos
        dgvProductosLista.DataSource = bsProductos
    End Sub
    'Cargo el combobox de la forma de pago
    Public Sub cargarFormPago()
        tablaFormPago.Clear()
        eVenta.cargarFormasPago(tablaFormPago)
        cbFormPago.DisplayMember = "nombFormaPago"
        cbFormPago.ValueMember = "idformpago"
        cbFormPago.DataSource = tablaFormPago
    End Sub
    Public Sub comboBoxBuscarPor()
        'Creo una tabla para poder tener dos valores dentro del combobox, uno es el que yo voy a mostrar y otro contiene el nombre identificatorio que coincide con el de la base de datos para poder buscar
        tablaBuscador.Clear()
        'agrego las columnas
        tablaBuscador.Columns.Add("nombre")
        tablaBuscador.Columns.Add("nombreDB")
        'agrego las 3 filas que necesito con sus respectivos nombres de la base de datos
        tablaBuscador.Rows.Add("Tipo", "tipoProducto")
        tablaBuscador.Rows.Add("Modelo", "modelo")
        tablaBuscador.Rows.Add("Marca", "marca")
        cbBuscador.DataSource = tablaBuscador
        cbBuscador.DisplayMember = "nombre"
        cbBuscador.ValueMember = "nombreDB"
        cbBuscador.SelectedIndex = 0
    End Sub
    'Cargo el numero de ventas realizadas en total en el textbox
    Public Sub nroVenta()
        eVenta.calcularNumeroVenta()
        txtNroVenta.Text = eVenta.nroVenta
    End Sub
    'Procedimiento para eliminar todo el contenido del datagrid del carrito
    Public Sub limpiarCarrito()
        dgvCarrito.Rows.Clear()
        rbDescuentoPorcentaje.Checked = True
        cantidad = 0
        cantidadSeleccionada = 0
        subtotal = 0
        total = 0
        cantidades.Clear()
        listaProductos.Clear()
        precioProductos.Clear()
        txtTotal.Text = total.ToString("C2")
        txtSubtotal.Text = subtotal.ToString("C2")
        txtDescuento.Text = ""
        txtRecargo.Text = ""
        txtClienteCtaCorriente.Text = ""
        txtClienteCtaCorriente.Visible = False
        btnCancelarCtaCorriente.Visible = False
        lblCtaCorriente.Visible = False
        rbRecargoPorcentaje.Enabled = True
        rbRecargoPlata.Enabled = True
        rbDescuentoPlata.Enabled = True
        rbDescuentoPorcentaje.Enabled = True
        rbDescuentoPorcentaje.Checked = True
        cbFormPago_SelectedValueChanged(cbFormPago, System.EventArgs.Empty)
        actualizarProductos()
        cbFormPago.Enabled = False
    End Sub

    Public Function productoRepetido(ByRef cantidadAAgregar As UInt64)
        If dgvCarrito.Rows.Count > 0 Then
            For i = 0 To dgvCarrito.Rows.Count - 1
                If dgvCarrito.Rows(i).Cells("idProductoCarrito").Value = dgvProductosLista.CurrentRow.Cells("idProductoLista").Value Then
                    dgvCarrito.Rows(i).Cells("cantidadCarrito").Value = dgvCarrito.Rows(i).Cells("cantidadCarrito").Value + cantidadAAgregar
                    cantidadTotalCarrito = dgvCarrito.Rows(i).Cells("cantidadCarrito").Value
                    dgvCarrito.Rows(i).Cells("precioTotalCarrito").Value = cantidadTotalCarrito * dgvCarrito.Rows(i).Cells("precioVentaCarrito").Value
                    Return True
                End If
            Next
            Return False
        Else
            Return False
        End If
    End Function



    'Procedimiento para agregar un producto desde el datagrid de productos hacia el datagrid de ventas
    Public Sub anidadirAlCarro()
        'Si previamente hay algun descuento o recargo lo borro para la nueva venta
        txtBuscar.Text = ""
        filtroBS = ""
        If dgvCarrito.Rows.Count = 0 Then
            txtDescuento.Text = ""
            txtRecargo.Text = ""
            Call cbFormPago_SelectedValueChanged(cbFormPago, System.EventArgs.Empty)
        End If
        cantidad = dgvProductosLista.CurrentRow.Cells("cantidadProductoLista").Value
        Dim seleccionarCantidad As New frmCantidad(cantidad, True)
        With seleccionarCantidad
            .ShowDialog()
            'Si introduzco una cantidad valida en el formulario cantidad, recien ahi lo agrega al datagrid de carrito/venta
            If .DialogResult = DialogResult.OK Then
                cantidadSeleccionada = seleccionarCantidad.cantidadSeleccionada
                If productoRepetido(cantidadSeleccionada) = False Then
                    For Each ROW As DataGridViewRow In dgvProductosLista.SelectedRows
                        idProducto = ROW.Cells("idProductoLista").Value
                        tipo = ROW.Cells("tipoProductoLista").Value.ToString
                        marca = ROW.Cells("marcaProductoLista").Value.ToString
                        modelo = ROW.Cells("modeloProductoLista").Value.ToString
                        precioCosto = ROW.Cells("precioCostoLista").Value
                        precioVenta = ROW.Cells("precioVentaLista").Value
                        'Asigno el valor desde el formulario cantidad
                        cantidadSeleccionada = seleccionarCantidad.cantidadSeleccionada
                        ROW.Cells("cantidadProductoLista").Value = cantidad - cantidadSeleccionada
                        'agrego los datos seleccionados al datagrid  de ventas
                        precioTotal = precioVenta * cantidadSeleccionada
                        dgvCarrito.Rows.Add(idProducto, tipo, marca, modelo, cantidadSeleccionada, precioTotal, precioVenta)
                    Next
                Else
                    dgvProductosLista.CurrentRow.Cells("cantidadProductoLista").Value = cantidad - cantidadSeleccionada
                End If
                calcularPrecio()
                'Si tengo alguna forma de pago que tiene un recargo precargado esto llama a al evento de txtrecargo y actualiza el monto total con el recargo
                Call txtRecargo_TextChanged_1(txtRecargo, System.EventArgs.Empty)
                'Habilito desde aqui el combobox para que el usuario no pueda cambiar el valor si no hay ningun producto cargado en el carrito
                cbFormPago.Enabled = True
                dgvCarrito.ClearSelection()
            End If
        End With
    End Sub
    Public Sub calcularPrecio()
        precioTotal = 0
        precioVenta = 0
        For i = 0 To dgvCarrito.Rows.Count - 1
            precioVenta = dgvCarrito.Rows(i).Cells("precioTotalCarrito").Value
            precioTotal += precioVenta
        Next
        subtotal = precioTotal
        total = subtotal
        txtSubtotal.Text = subtotal.ToString("C2")
        txtTotal.Text = total.ToString("C2")
    End Sub
    'Al presionar el boton agregar se ejecuta el procedimiento de aniadir
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        anidadirAlCarro()
    End Sub
    Public Sub vender()
        Try
            'Esto pregunta si hay alguna forma de pago anteriormente
            If String.IsNullOrEmpty(cbFormPago.SelectedValue) Then
                MsgBox("Parece que no hay ninguna forma de pago cargada. Trate agregando una desde las opciones.", MsgBoxStyle.Exclamation, "Vender")
                limpiarCarrito()
            Else
                'Al vender verifico si el carrito no esta vacio
                If dgvCarrito.Rows.Count > 0 Then
                    For i = 0 To dgvCarrito.Rows.Count - 1
                        'lleno las listas con los ids de los productos vendidos y su cantidad
                        idProductoCarro = dgvCarrito.Rows(i).Cells("idProductoCarrito").Value
                        listaProductos.Add(idProductoCarro)
                        precioProductoIndividual = dgvCarrito.Rows(i).Cells("precioVentaCarrito").Value
                        precioProductos.Add(precioProductoIndividual)
                        cantidad = dgvCarrito.Rows(i).Cells("cantidadCarrito").Value
                        cantidades.Add(cantidad)
                    Next
                    If LTrim(txtDescuento.Text) = "" And LTrim(txtRecargo.Text) = "" Then
                        'Si el descuento o recargo se hace en monto de dinero establezco la S de Sin recargo/descuento
                        eVenta.tipoDescuentoRecargo = "S"
                    Else
                        If rbDescuentoPlata.Checked = True Or rbRecargoPlata.Checked = True Then
                            'Si el descuento o recargo se hace en monto de dinero establezco la D de Dinero
                            eVenta.tipoDescuentoRecargo = "D"
                        ElseIf rbRecargoPorcentaje.Checked = True Or rbDescuentoPorcentaje.Checked = True Then
                            'Si el descuento o recargo se hace en monto de dinero establezco la P de Porcentaje
                            eVenta.tipoDescuentoRecargo = "P"
                        End If
                    End If
                    eVenta.idProductos = listaProductos
                    eVenta.precioProductos = precioProductos
                    eVenta.cantidad = cantidades
                    subtotal = CInt(txtSubtotal.Text)
                    eVenta.precioInicial = subtotal
                    eVenta.descuento = descuento
                    eVenta.recargo = recargo
                    total = CInt(txtTotal.Text)
                    eVenta.precioFinal = total
                    eVenta.fechaHora = Date.Now
                    eVenta.idFormPago = cbFormPago.SelectedValue
                    If txtClienteCtaCorriente.Visible = False Then
                        eVenta.cuotas = 0
                    End If
                    'Si se pudo guardar en la base de datos muestra un mensaje al usuario diciendo que se realizo la venta
                    If eVenta.detalleVenta() = True Then
                        If txtClienteCtaCorriente.Visible = False Then
                            frmVentaRealizada.ShowDialog()
                        ElseIf txtClienteCtaCorriente.Visible = True Then
                            eVenta.ventaCuentaCorriente()
                            frmVentaRealizada.ShowDialog()
                        End If
                        limpiarCarrito()
                        nroVenta()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Hubo un problema y no se pudo realizar la venta. Información del problema: " & ex.Message, MsgBoxStyle.Critical, "Facturacion")
        End Try
    End Sub
    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        If dgvCarrito.Rows.Count = 0 Then
            MsgBox("El carrito esta vacío", MsgBoxStyle.Exclamation, "Vender")
        Else
            frmModal.ShowDialog()
            If frmModal.DialogResult = DialogResult.OK Then
                vender()
            End If
        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCarrito()
    End Sub

    Private Sub btnCancelarCtaCorriente_Click(sender As Object, e As EventArgs) Handles btnCancelarCtaCorriente.Click
        txtClienteCtaCorriente.Text = ""
        txtClienteCtaCorriente.Visible = False
        btnCancelarCtaCorriente.Visible = False
        lblCtaCorriente.Visible = False
        cbFormPago.SelectedIndex = 0
    End Sub


    'Al hacer doble click en la celda se agrega un producto al carrito tambien
    Private Sub dgvProductosLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductosLista.CellDoubleClick
        anidadirAlCarro()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'asigno el valor que habia agregado en la tabla anteriormente para asi poder filtrar el datagrid
        filtroElegido = cbBuscador.SelectedValue
        filtroBS = filtroElegido & " like '%" & txtBuscar.Text & "%'"
        bsProductos.Filter = filtroBS
    End Sub

    Private Sub btnCuentaCorriente_Click(sender As Object, e As EventArgs) Handles btnCuentaCorriente.Click
        If dgvCarrito.Rows.Count >= 1 Then
            Dim ctaCorriente As New frmCargarCuentaCorriente()
            ctaCorriente.ShowDialog()
            If ctaCorriente.DialogResult = DialogResult.OK Then
                eVenta.idCliente = ctaCorriente.eVenta.idCliente
                eVenta.entregaDinero = ctaCorriente.eVenta.entregaDinero
                eVenta.cuotas = ctaCorriente.eVenta.cuotas
                txtClienteCtaCorriente.Visible = True
                btnCancelarCtaCorriente.Visible = True
                lblCtaCorriente.Visible = True
                If eVenta.cuotas = 1 Then
                    txtClienteCtaCorriente.Text = ctaCorriente.eVenta.nombreCliente & "  -  " & eVenta.cuotas & " Pago"
                Else
                    txtClienteCtaCorriente.Text = ctaCorriente.eVenta.nombreCliente & "  -  " & eVenta.cuotas & " Cuotas"
                End If
            End If
        End If
    End Sub

#Region "Text Changed Descuento y Recargo"
    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
        If rbDescuentoPlata.Checked = True And rbDescuentoPorcentaje.Checked = False Then
            'Proceso para reestablecer el text box si esta vacio ya que cuando se pasa de monto se pone en color rojo y reestablece el total
            If LTrim(txtDescuento.Text) = "" Then
                total = subtotal
                txtTotal.Text = total.ToString("C2")
            Else
                'Si el monto de descuento se pasa del monto a pagar el text box se pone en rojo
                If CDbl(txtDescuento.Text) > subtotal Then
                    txtDescuento.BackColor = Color.FromArgb(255, 122, 122)
                    txtTotal.Text = subtotal.ToString("C2")
                Else
                    'De la otra forma se va descontando a medida que vamos presionando los numeros
                    descuento = CDbl(txtDescuento.Text)
                    total = subtotal
                    If descuento > subtotal Then
                        total = 0
                    Else
                        total = total - descuento
                    End If
                    txtTotal.Text = total.ToString("C2")
                End If
            End If
        End If
        'El mismo metodo pero si el descuento es en porcentaje
        If rbDescuentoPorcentaje.Checked = True And rbDescuentoPlata.Checked = False Then
            If LTrim(txtDescuento.Text) = "" Then
                total = subtotal
                txtTotal.Text = total.ToString("C2")
            Else
                descuento = CInt(txtDescuento.Text)
                total = subtotal
                If ((total * descuento) / 100) > subtotal Then
                    total = 0
                Else
                    total = total - ((total * descuento) / 100)
                End If
                txtTotal.Text = total.ToString("C2")
            End If
        End If
    End Sub


    Private Sub txtRecargo_TextChanged_1(sender As Object, e As EventArgs) Handles txtRecargo.TextChanged
        'Suma del dinero al total dependiendo si es por monto de dinero o porcentaje
        If rbRecargoPlata.Checked = True And rbRecargoPorcentaje.Checked = False Then
            If LTrim(txtRecargo.Text) = "" Then
                total = subtotal
                txtTotal.Text = total.ToString("C2")
            Else
                recargo = CInt(txtRecargo.Text)
                total = subtotal
                total = total + recargo
                txtTotal.Text = total.ToString("C2")
            End If
        End If
        If rbRecargoPorcentaje.Checked = True And rbRecargoPlata.Checked = False Then
            If LTrim(txtRecargo.Text) = "" Then
                total = subtotal
                txtTotal.Text = total.ToString("C2")
            Else
                recargo = CInt(txtRecargo.Text)
                total = subtotal
                total = total + ((total * recargo) / 100)
                txtTotal.Text = total.ToString("C2")
            End If
        End If
    End Sub

#End Region
#Region "Seleccion Radio Button"
    'Estos son los eventos al seleccionar uno de los radiobutton a la derecha del descuento y el recargo. Esto lo que va a hacer es deshabilitar el textbox que no se esta usando, habilitar el que estoy usando. Establecer el simbolo del label depende del radiobutton que elegi y vaciar ambos textbox. Tambien restablezco el valor del total y le pongo un maximo de caracteres
    Private Sub rbRecargoPlata_CheckedChanged(sender As Object, e As EventArgs) Handles rbRecargoPlata.CheckedChanged
        If rbRecargoPlata.Checked = True Then
            txtDescuento.Enabled = False
            txtRecargo.Enabled = True
            txtRecargo.Text = ""
            txtDescuento.Text = ""
            txtTotal.Text = subtotal.ToString("C2")
            'lblRecargo.Text = "$"
            txtRecargo.MaxLength = 9
        End If
    End Sub

    Private Sub rbRecargoPorcentaje_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbRecargoPorcentaje.CheckedChanged
        If rbRecargoPorcentaje.Checked = True Then
            txtDescuento.Enabled = False
            txtRecargo.Enabled = True
            txtRecargo.Text = ""
            txtDescuento.Text = ""
            txtTotal.Text = subtotal.ToString("C2")
            'lblRecargo.Text = "%"
            txtRecargo.MaxLength = 3
        End If
    End Sub

    Private Sub rbDescuentoPlata_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbDescuentoPlata.CheckedChanged
        If rbDescuentoPlata.Checked = True Then
            txtRecargo.Enabled = False
            txtDescuento.Enabled = True
            txtDescuento.Text = ""
            txtRecargo.Text = ""
            txtTotal.Text = subtotal.ToString("C2")
            'lblDescuento.Text = "$"
            txtDescuento.MaxLength = 9
        End If
    End Sub

    Private Sub rbDescuentoPorcentaje_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbDescuentoPorcentaje.CheckedChanged
        If rbDescuentoPorcentaje.Checked = True Then
            txtRecargo.Enabled = False
            txtDescuento.Enabled = True
            txtDescuento.Text = ""
            txtRecargo.Text = ""
            txtTotal.Text = subtotal.ToString("C2")
            ' lblDescuento.Text = "%"
            txtDescuento.MaxLength = 3
        End If
    End Sub


#End Region
#Region "Key Press/Down"
    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Este evento me permite solo introducir numeros y comas en el recargo. Y tambien solo se va a poder escribir si hay algun producto en el carro
        If Char.IsNumber(e.KeyChar) And total <> 0 Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'INSTR es una herramienta que busca la cantidad de coincidencias de un cierto caracter o letra en una cadena. Si me devuelve 0 es que no hay ninguna coincidencia. Esto me va a permitir que el usuario solo pueda introducir una sola coma
        ElseIf e.KeyChar.ToString = "," And InStr(txtDescuento.Text, ",") = 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtRecargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecargo.KeyPress
        'Este evento me permite solo introducir numeros y comas en el recargo. Y tambien solo se va a poder escribir si hay algun producto en el carro
        If Char.IsNumber(e.KeyChar) And total <> 0 Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'INSTR es una herramienta que busca la cantidad de coincidencias de un cierto caracter o letra en una cadena. Si me devuelve 0 es que no hay ninguna coincidencia. Esto me va a permitir que el usuario solo pueda introducir una sola coma
        ElseIf e.KeyChar.ToString = "," And InStr(txtRecargo.Text, ",") = 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescuento_KeyDown(sender As Object, e As KeyEventArgs)
        'Si yo presiono la tecla de borrar se va a borrar todo el contenido del textbox. Esto lo hago porque yo voy haciendo los calculos del total mientras el usuario esta escribiendo, y no puedo hacerlo a la inversa de deshacerlo mientras el usuario esta borrando por lo que borro de una sola vez. Lo podria hacer pero no tengo ganas xD
        If e.KeyCode = Keys.Back Then
            txtDescuento.Text = ""
        End If
    End Sub

    Private Sub txtRecargo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRecargo.KeyDown
        'Si yo presiono la tecla de borrar se va a borrar todo el contenido del textbox. Esto lo hago porque yo voy haciendo los calculos del total mientras el usuario esta escribiendo, y no puedo hacerlo a la inversa de deshacerlo mientras el usuario esta borrando por lo que borro de una sola vez. Lo podria hacer pero no tengo ganas xD
        If e.KeyCode = Keys.Back Then
            txtRecargo.Text = ""
        End If
    End Sub
#End Region
#Region "Eliminar producto del carrito"
    'Accion al presionar una celda  del datagrid  carrito
    Private Sub dgvCarrito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarrito.CellContentClick
        'Si la columna clickeada es la de eliminar(index 8) entra en el if 
        If e.ColumnIndex = 8 Then
            'Selecciono el id del producto y lo guardo en una variable al igual que la cantidad que yo habia elegido anteriormente
            idProductoCarro = dgvCarrito.CurrentRow.Cells("idProductoCarrito").Value
            cantidadSeleccionada = dgvCarrito.CurrentRow.Cells("cantidadCarrito").Value
            'Si solo es un producto lo elimino directamente
            If cantidadSeleccionada = 1 Then
                dgvCarrito.Rows.Remove(dgvCarrito.CurrentRow)
            Else
                'Instancio el formulario cantidad y le paso la cantidad de productos que tengo en el carrito y le paso el valor false que diferencia de agregar o quitar unidades
                Dim cantidadAQuitar As New frmCantidad(cantidadSeleccionada, False)
                cantidadAQuitar.ShowDialog()
                If cantidadAQuitar.DialogResult = DialogResult.OK Then
                    'Asigno la cantidad que elegi en el formulario
                    cantidadSeleccionada = cantidadAQuitar.cantidadSeleccionada
                    'Pregunto si el numero que elegi en el formulario es igual a la cantidad de productos que tengo en el carrito directamente lo elimino
                    If dgvCarrito.CurrentRow.Cells("cantidadCarrito").Value = cantidadSeleccionada Then
                        dgvCarrito.Rows.Remove(dgvCarrito.CurrentRow)
                    Else
                        'Sino le resto la cantidad elegida a la celda cantidad del producto
                        dgvCarrito.CurrentRow.Cells("cantidadCarrito").Value = (dgvCarrito.CurrentRow.Cells("cantidadCarrito").Value - cantidadSeleccionada)
                        'Vuelvo a calcular el precio total dependiendo las cantidades que quedaron
                        dgvCarrito.CurrentRow.Cells("precioTotalCarrito").Value = (dgvCarrito.CurrentRow.Cells("cantidadCarrito").Value * dgvCarrito.CurrentRow.Cells("precioVentaCarrito").Value)
                    End If
                End If
                calcularPrecio()
            End If
            'Este for lo utilizo para volver a poner la cantidad en la lista de productos, ya que cuando yo agrego un producto carrito resto la cantidad de la lista de productos. Esto me permite volver a ponerlo como estaba antes. Mediante el id del producto busco y vuelvo a sumar la cantidad 
            For i = 0 To dgvProductosLista.Rows.Count - 1
                If idProductoCarro = dgvProductosLista.Rows(i).Cells("idProductoLista").Value Then
                    cantidad = dgvProductosLista.Rows(i).Cells("cantidadProductoLista").Value
                    dgvProductosLista.Rows(i).Cells("cantidadProductoLista").Value = cantidad + cantidadSeleccionada
                End If
            Next
            If dgvCarrito.Rows.Count = 0 Then
                limpiarCarrito()
            End If
        End If
    End Sub


    Private Sub dgvProductosLista_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProductosLista.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                anidadirAlCarro()
        End Select
    End Sub

    Private Sub cbBuscador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbBuscador.SelectedValueChanged
        txtBuscar.Text = ""
        txtBuscar.Focus()
    End Sub

    Private Sub cbFormPago_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbFormPago.SelectedValueChanged
        'En esta parte establezco los recargos fijos que tiene cada forma de pago
        'Recorro la tabla con el id de la forma de pago y el recargo
        For i = 0 To tablaRecargos.Rows.Count - 1
            'Los comparo con el valor seleccionado en el combobox de la forma de pago
            If cbFormPago.SelectedValue = tablaRecargos.Rows(i).Item("idformpago") Then
                'Si coinciden y el recargo es mayor que 0 lo establezco automaticamente. Tambien deshabilito todos los controles respectivos para que el usuario no lo pueda modificar
                If tablaRecargos.Rows(i).Item("recargo") > 0 Then
                    rbRecargoPorcentaje.Checked = True
                    rbRecargoPlata.Checked = False
                    rbDescuentoPlata.Checked = False
                    rbDescuentoPorcentaje.Checked = False
                    txtRecargo.Text = CInt(tablaRecargos.Rows(i).Item("recargo"))
                    txtRecargo.Enabled = False
                    txtDescuento.Text = ""
                    txtDescuento.Enabled = False
                    rbRecargoPorcentaje.Enabled = False
                    rbRecargoPlata.Enabled = False
                    rbDescuentoPlata.Enabled = False
                    rbDescuentoPorcentaje.Enabled = False
                    'Si el recargo es de 0 habilito todos los controles para el uso normal
                Else
                    rbRecargoPorcentaje.Enabled = True
                    rbRecargoPlata.Enabled = True
                    rbDescuentoPlata.Enabled = True
                    rbDescuentoPorcentaje.Enabled = True
                    rbRecargoPorcentaje.Checked = False
                    rbRecargoPlata.Checked = False
                    rbDescuentoPlata.Checked = True
                    rbDescuentoPorcentaje.Checked = False
                    txtDescuento.Text = ""
                    txtRecargo.Text = ""
                    txtRecargo.Enabled = False
                    txtDescuento.Enabled = True
                End If
            End If
        Next
    End Sub

    Private Sub frmVender_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case (Keys.Alt + Keys.B)
                txtBuscar.Select()
            Case Keys.F10
                Call btnVender_Click(btnVender, e)
            Case Keys.F11
                Call btnCuentaCorriente_Click(btnCuentaCorriente, e)
            Case (Keys.Alt + Keys.L)
                Call btnLimpiar_Click(btnLimpiar, e)
        End Select
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            anidadirAlCarro()
        End If
    End Sub







#End Region

End Class