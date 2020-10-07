Public Class frmFacturacion

    'Instancio la clae ventas
    Public eVenta As New Entidades.Venta
    'defino las variables para poder guardar los datos del dgv productos para pasarlos hacia el carrito
    Dim idProducto, idProductoCarro As UInt64
    Dim tipo, marca, modelo As String
    'defino una variable para poder establecer la cantidad de un producto, para asi poder pasarsela al formulario cantidad. Y defino otra para guardar el resultado del formulario
    Dim cantidad, cantidadSeleccionada As UInt16
    Dim precioCosto, precioVenta, precioTotal, subtotal, total, descuento, recargo As Double

    'Creo la tabla que va a contener los productos en stock para llenar el datagrid
    Dim tablaProductos As New DataTable
    Dim tablaFormPago As New DataTable
    Private Sub frmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminarDGV.UseColumnTextForButtonValue = True
        btnEliminarDGV.Text = "Eliminar"
        txtFecha.Text = Date.Now.Date
        subtotal = 0
        total = 0
        rbDescuentoPorcentaje.Checked = True
        actualizarProductos()
        cargarFormPago()
        nroVenta()
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs)
        If rbDescuentoPlata.Checked = True And rbDescuentoPorcentaje.Checked = False Then
            If LTrim(txtDescuento.Text) = "" Then
                txtDescuento.BackColor = Color.White
                total = subtotal
                txtTotal.Text = total
            Else
                If CInt(txtDescuento.Text) > subtotal Then
                    txtDescuento.BackColor = Color.FromArgb(255, 122, 122)
                    txtTotal.Text = subtotal
                Else
                    descuento = CInt(txtDescuento.Text)
                    total = subtotal
                    If descuento > subtotal Then
                        total = 0
                    Else
                        total = total - descuento
                    End If
                    txtTotal.Text = total
                End If
            End If
        End If
        If rbDescuentoPorcentaje.Checked = True And rbDescuentoPlata.Checked = False Then
            If LTrim(txtDescuento.Text) = "" Then
                total = subtotal
                txtTotal.Text = total
            Else
                descuento = CInt(txtDescuento.Text)
                total = subtotal
                If ((total * descuento) / 100) > subtotal Then
                    total = 0
                Else
                    total = total - ((total * descuento) / 100)
                End If
                txtTotal.Text = total
            End If
        End If
    End Sub
    'Traigo los productos desde la base de datos mediante la instancia a la clase ventas
    Public Sub actualizarProductos()
        tablaProductos.Clear()
        eVenta.verProductos(tablaProductos)
        dgvProductosLista.DataSource = tablaProductos
        dgvProductosLista.ClearSelection()
    End Sub
    Public Sub cargarFormPago()
        tablaFormPago.Clear()
        eVenta.cargarFormasPago(tablaFormPago)
        cbFormPago.DataSource = tablaFormPago
        cbFormPago.DisplayMember = "nombFormaPago"
        cbFormPago.ValueMember = "idformpago"
    End Sub
    Public Sub nroVenta()
        eVenta.calcularNumeroVenta()
        txtNroVenta.Text = eVenta.nroVenta
    End Sub
    Public Sub limpiarCarrito()
        dgvCarrito.Rows.Clear()
        rbDescuentoPorcentaje.Checked = True
        subtotal = 0
        total = 0
        txtTotal.Text = total
        txtSubtotal.Text = subtotal
        txtDescuento.Text = ""
        txtRecargo.Text = ""
        actualizarProductos()
    End Sub
    'Procedimiento para agregar un producto desde el datagrid de productos hacia el datagrid de ventas
    Public Sub anidadirAlCarro()
        cantidad = dgvProductosLista.CurrentRow.Cells("cantidadProductoLista").Value
        Dim seleccionarCantidad As New frmCantidad(cantidad)
        With seleccionarCantidad
            .ShowDialog()
            'Si introduzco una cantidad valida en el formulario cantidad, recien ahi lo agrega al datagrid de carrito/venta
            If .DialogResult = DialogResult.OK Then
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
                    dgvCarrito.Rows.Add(idProducto, tipo, marca, modelo, cantidadSeleccionada, precioTotal, precioCosto)
                    subtotal = precioTotal + subtotal
                    total = subtotal
                    txtSubtotal.Text = subtotal
                    txtTotal.Text = total
                    dgvCarrito.ClearSelection()
                Next
            End If
        End With
    End Sub
    'Al presionar el boton agregar se ejecuta el procedimiento de aniadir
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        anidadirAlCarro()
    End Sub

    Private Sub txtRecargo_TextChanged(sender As Object, e As EventArgs)
        If rbRecargoPlata.Checked = True And rbRecargoPorcentaje.Checked = False Then
            If LTrim(txtRecargo.Text) = "" Then
                total = subtotal
                txtTotal.Text = total
            Else
                recargo = CInt(txtRecargo.Text)
                total = subtotal
                total = total + recargo
                txtTotal.Text = total
            End If
        End If
        If rbRecargoPorcentaje.Checked = True And rbRecargoPlata.Checked = False Then
            If LTrim(txtRecargo.Text) = "" Then
                total = subtotal
                txtTotal.Text = total
            Else
                descuento = CInt(txtRecargo.Text)
                total = subtotal
                total = total + ((total * descuento) / 100)
                txtTotal.Text = total
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    'Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
    '    limpiarCarrito()
    'End Sub



    'Recibe el 'row' y retorna su contenido en un array tipo string
    'Me.dgvCarrito.Rows.Add(ObtenerValoresFila(Seleccion))
    Function ObtenerValoresFila(ByVal fila As DataGridViewRow) As String()
        'Dimensionar el array al tamaño de columnas del DGV
        Dim Contenido(Me.dgvProductosLista.ColumnCount - 1) As String
        'Rellenar el contenido con el valor de las celdas de la fila
        For i As Integer = 0 To Contenido.Length - 1
            Contenido(i) = fila.Cells(i).Value
        Next
        Return Contenido
    End Function
    'Al hacer doble click en la celda se agrega un producto al carrito tambien
    Private Sub dgvProductosLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductosLista.CellDoubleClick
        anidadirAlCarro()
    End Sub
#Region "Seleccion Radio Button"
    'Estos son los eventos al seleccionar uno de los radiobutton a la derecha del descuento y el recargo. Esto lo que va a hacer es deshabilitar el textbox que no se esta usando, habilitar el que estoy usando. Establecer el simbolo del label depende del radiobutton que elegi y vaciar ambos textbox. Tambien restablezco el valor del total y le pongo un maximo de caracteres
    Private Sub rbDescuentoPorcentaje_CheckedChanged(sender As Object, e As EventArgs)
        If rbDescuentoPorcentaje.Checked = True Then
            txtRecargo.Enabled = False
            txtDescuento.Enabled = True
            txtDescuento.Text = ""
            txtRecargo.Text = ""
            txtTotal.Text = subtotal
            ' lblDescuento.Text = "%"
            txtDescuento.MaxLength = 3
        End If
    End Sub
    Private Sub rbDescuentoPlata_CheckedChanged(sender As Object, e As EventArgs)
        If rbDescuentoPlata.Checked = True Then
            txtRecargo.Enabled = False
            txtDescuento.Enabled = True
            txtDescuento.Text = ""
            txtRecargo.Text = ""
            txtTotal.Text = subtotal
            'lblDescuento.Text = "$"
            txtDescuento.MaxLength = 9
        End If
    End Sub
    Private Sub rbRecargoPlata_CheckedChanged(sender As Object, e As EventArgs)
        If rbRecargoPlata.Checked = True Then
            txtDescuento.Enabled = False
            txtRecargo.Enabled = True
            txtRecargo.Text = ""
            txtDescuento.Text = ""
            txtTotal.Text = subtotal
            'lblRecargo.Text = "$"
            txtRecargo.MaxLength = 9
        End If
    End Sub
    Private Sub rbRecargoPorcentaje_CheckedChanged(sender As Object, e As EventArgs)
        If rbRecargoPorcentaje.Checked = True Then
            txtDescuento.Enabled = False
            txtRecargo.Enabled = True
            txtRecargo.Text = ""
            txtDescuento.Text = ""
            txtTotal.Text = subtotal
            'lblRecargo.Text = "%"
            txtRecargo.MaxLength = 3
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

    Private Sub txtRecargo_KeyPress(sender As Object, e As KeyPressEventArgs)
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
            txtRecargo.Text = ""
        End If
    End Sub
#End Region

    'Accion al presionar una celda  del datagrid  carrito
    Private Sub dgvCarrito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarrito.CellContentClick
        'Si la columna clickeada es la de eliminar(index 8) entra en el if 
        If e.ColumnIndex = 8 Then
            'Selecciono el id del producto y lo guardo en una variable al igual que la cantidad que yo habia elegido anteriormente
            idProductoCarro = dgvCarrito.CurrentRow.Cells("idProductoCarrito").Value
            cantidadSeleccionada = dgvCarrito.CurrentRow.Cells("cantidadCarrito").Value
            'Elimino la fila del datagrid carrito
            dgvCarrito.Rows.Remove(dgvCarrito.CurrentRow)
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
End Class