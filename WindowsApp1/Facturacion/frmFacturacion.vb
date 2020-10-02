Public Class frmFacturacion
    'Instancio la clae ventas
    Public eVenta As New Entidades.Venta
    'defino las variables para poder guardar los datos del dgv productos para pasarlos hacia el carrito
    Dim idProducto As UInt64
    Dim tipo, marca, modelo As String
    'defino una variable para poder establecer la cantidad de un producto, para asi poder pasarsela al formulario cantidad. Y defino otra para guardar el resultado del formulario
    Dim cantidad, cantidadSeleccionada As UInt16
    Dim precioCosto, precioVenta, precioTotal, subtotal, total, descuento, recargo As Double

    'Creo la tabla que va a contener los productos en stock para llenar el datagrid
    Dim tablaProductos As New DataTable

    Private Sub frmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Date.Now.Date
        subtotal = 0
        total = 0
        rbDescuentoPorcentaje.Checked = True
        actualizarProductos()
    End Sub

    Private Sub txtDescuento_TextChanged(sender As Object, e As EventArgs) Handles txtDescuento.TextChanged
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
                    total = total - descuento
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
                total = total - ((total * descuento) / 100)
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

    Private Sub txtRecargo_TextChanged(sender As Object, e As EventArgs) Handles txtRecargo.TextChanged
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
            If LTrim(txtDescuento.Text) = "" Then
                total = subtotal
                txtTotal.Text = total
            Else
                descuento = CInt(txtDescuento.Text)
                total = subtotal
                total = total + ((total * descuento) / 100)
                txtTotal.Text = total
            End If
        End If
    End Sub

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
#Region "Seleccion Radio Button"
    Private Sub dgvProductosLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductosLista.CellDoubleClick
        anidadirAlCarro()
    End Sub
    Private Sub rbDescuentoPorcentaje_CheckedChanged(sender As Object, e As EventArgs) Handles rbDescuentoPorcentaje.CheckedChanged
        If rbDescuentoPorcentaje.Checked = True Then
            txtRecargo.Enabled = False
            txtDescuento.Enabled = True
            txtDescuento.Text = ""
            txtRecargo.Text = ""
            txtTotal.Text = subtotal
            lblDescuento.Text = "%"
        End If
    End Sub
    Private Sub rbDescuentoPlata_CheckedChanged(sender As Object, e As EventArgs) Handles rbDescuentoPlata.CheckedChanged
        If rbDescuentoPlata.Checked = True Then
            txtRecargo.Enabled = False
            txtDescuento.Enabled = True
            txtDescuento.Text = ""
            txtRecargo.Text = ""
            txtTotal.Text = subtotal
            lblDescuento.Text = "$"
        End If
    End Sub
    Private Sub rbRecargoPlata_CheckedChanged(sender As Object, e As EventArgs) Handles rbRecargoPlata.CheckedChanged
        If rbRecargoPlata.Checked = True Then
            txtDescuento.Enabled = False
            txtRecargo.Enabled = True
            txtRecargo.Text = ""
            txtDescuento.Text = ""
            txtTotal.Text = subtotal
            lblRecargo.Text = "$"
        End If
    End Sub
    Private Sub rbRecargoPorcentaje_CheckedChanged(sender As Object, e As EventArgs) Handles rbRecargoPorcentaje.CheckedChanged
        If rbRecargoPorcentaje.Checked = True Then
            txtDescuento.Enabled = False
            txtRecargo.Enabled = True
            txtRecargo.Text = ""
            txtDescuento.Text = ""
            txtTotal.Text = subtotal
            lblRecargo.Text = "%"
        End If
    End Sub


    Private Sub txtDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
        If Char.IsNumber(e.KeyChar) And total <> 0 Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.ToString = "," And InStr(txtDescuento.Text, ",") = 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRecargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecargo.KeyPress
        If Char.IsNumber(e.KeyChar) And total <> 0 Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.ToString = "," And InStr(txtRecargo.Text, ",") = 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescuento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescuento.KeyDown
        If e.KeyCode = Keys.Back Then
            txtDescuento.Text = ""
            txtRecargo.Text = ""
        End If
    End Sub
#End Region

End Class