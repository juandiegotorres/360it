Public Class frmFacturacion
    'Instancio la clae ventas
    Public eVenta As New Entidades.Venta
    'defino una variable para poder establecer la cantidad de un producto, para asi poder pasarsela al formulario cantidad
    Dim cantidad As UInt16
    'Creo la tabla que va a contener los productos en stock para llenar el datagrid
    Dim tablaProductos As New DataTable
    Private Sub frmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarProductos()
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
        Dim frCantidad As New frmCantidad(cantidad)
        With frCantidad
            .ShowDialog()
            'Si introduzco una cantidad valida en el formulario cantidad, recien ahi lo agrega al datagrid de carrito/venta
            If .DialogResult = DialogResult.OK Then
                For Each Seleccion As DataGridViewRow In dgvProductosLista.SelectedRows
                    Me.dgvCarrito.Rows.Add(ObtenerValoresFila(Seleccion))
                Next
            End If
        End With
    End Sub
    'Al presionar el boton agregar se ejecuta el procedimiento de aniadir
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        anidadirAlCarro()
    End Sub

    'Recibe el 'row' y retorna su contenido en un array tipo string
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
End Class