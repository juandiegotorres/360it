Public Class frmProductos
    Dim cantidadProducto, idProducto As UInt16
    Public eProducto As New Entidades.Producto
    Dim bsProductos As New BindingSource
    Dim filtroBS, filtroElegido As String
    Dim tablaProductos, tablaCategorias, tablaBuscador, tablaProductosPocoStock As New DataTable
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
        frmNuevoProducto.Show()
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarProductos()
        comboBoxCategorias()
        comboBoxBuscarPor()
        cbCategorias.SelectedIndex = 0
        cbBuscador.SelectedIndex = 0
        dgvProductos.Select()
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
    End Sub
    Public Sub comboBoxCategorias()
        cbCategorias.Items.Clear()
        cbCategorias.Items.Add("Todas")
        tablaCategorias.Clear()
        'Codigo para poder agregar una nueva fila a la tabla, quiero poder tener la opcion de elegir todas las categorias para que el usuario pueda volver atras si filtar por una categoria
        tablaCategorias.Columns.Add("idcategoria")
        tablaCategorias.Columns.Add("nombCategoria")
        tablaCategorias.Rows.Add("0", "Todas")
        eProducto.categorias(tablaCategorias)
        cbCategorias.DataSource = tablaCategorias
        cbCategorias.DisplayMember = "nombCategoria"
        cbCategorias.ValueMember = "idcategoria"
    End Sub
    Public Sub actualizarProductos()
        txtBuscar.Text = ""
        filtroBS = ""
        tablaProductos.Clear()
        tablaProductosPocoStock.Clear()
        eProducto.recuperarProductos(tablaProductos)
        eProducto.productosPocoStock(tablaProductosPocoStock)
        dgvProductosPocoStock.DataSource = tablaProductosPocoStock
        bsProductos.DataSource = tablaProductos
        dgvProductos.DataSource = bsProductos
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        eProducto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
    End Sub

    Private Sub btnDetalleVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarStock.Click
        If dgvProductos.SelectedRows.Count = 1 Then
            cantidadProducto = dgvProductos.CurrentRow.Cells("cantidad").Value
            Dim cantidadAAgregar As New frmMovimientoDeStock(cantidadProducto)
            With cantidadAAgregar
                .quitar = False
                'asigno el id a la instancia dentro del formulario para poder traer los datos desde alli
                .e_Producto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    actualizarProductos()
                End If
            End With
        End If
    End Sub

    Private Sub btnAgregarSeleccionar_Click(sender As Object, e As EventArgs) Handles btnAgregarSeleccionar.Click
        Dim nuevoProducto As New frmNuevoProducto
        nuevoProducto.ShowDialog()
        If nuevoProducto.DialogResult = DialogResult.OK Then
            frmPrincipal.Show()
            actualizarProductos()
        ElseIf nuevoProducto.DialogResult = DialogResult.Cancel Then
            filtroBS = ""
            txtBuscar.Text = ""
        End If
    End Sub

    Private Sub btnBajaCancelar_Click(sender As Object, e As EventArgs) Handles btnBajaCancelar.Click
        eProducto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
        If dgvProductos.CurrentRow.Cells("cantidad").Value >= 1 Then
            If MsgBox("Está a punto de dar de baja un producto con stock ¿Desea hacerlo de todas formas?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Productos") = MsgBoxResult.Yes Then
                eProducto.bajaProducto()
                actualizarProductos()
            End If
        Else
            If MsgBox("¿Desea dar de baja este producto?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Productos") = MsgBoxResult.Yes Then
                eProducto.bajaProducto()
                actualizarProductos()
            End If
        End If

    End Sub

    Private Sub btnAumentarPrecio_Click(sender As Object, e As EventArgs) Handles btnAumentarPrecio.Click
        Dim aumentarPrecio As New frmCambiarPrecios
        aumentarPrecio.idProd = dgvProductos.CurrentRow.Cells("id").Value
        aumentarPrecio.disminuir = False
        aumentarPrecio.ShowDialog()
        If aumentarPrecio.DialogResult = DialogResult.OK Then
            actualizarProductos()
        End If
    End Sub

    Private Sub btnDisminuir_Click(sender As Object, e As EventArgs) Handles btnDisminuir.Click
        Dim disminuirPrecio As New frmCambiarPrecios
        disminuirPrecio.idProd = dgvProductos.CurrentRow.Cells("id").Value
        disminuirPrecio.disminuir = True
        disminuirPrecio.ShowDialog()
        If disminuirPrecio.DialogResult = DialogResult.OK Then
            actualizarProductos()
        End If
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim modificarProducto As New frmNuevoProducto
        modificarProducto.eProducto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
        With modificarProducto
            .modificar = True
            .ShowDialog()
            If DialogResult.OK Then
                actualizarProductos()
            End If
        End With
    End Sub

    'Private Sub btnSinStock_Click(sender As Object, e As EventArgs) Handles btnSinStock.Click
    '    If dgvProductos.Rows(0).Cells("cantidad").Value = 0 Then
    '        bsProductos.Sort = "cantidad DESC"
    '        btnSinStock.Text = "Productos sin Stock primero"
    '        ' actualizarProductos()
    '    Else
    '        bsProductos.Sort = "cantidad ASC"
    '        'Ordeno el data grid por los productos con menor cantidad, si el primero es 0 (osea que hay al menos un producto que tiene stock recien ahi ordeno)
    '        If dgvProductos.Rows(0).Cells("cantidad").Value = 0 Then

    '        End If

    '        btnSinStock.Text = "Productos con Stock primero"

    '        MsgBox("Actualmente todos los productos tienen stock", MsgBoxStyle.Information, "Productos")
    '    End If
    'End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        'Procedimiento para sacar stock a un producto
        If dgvProductos.SelectedRows.Count = 1 Then
            cantidadProducto = dgvProductos.CurrentRow.Cells("cantidad").Value
            Dim cantidadAQuitar As New frmMovimientoDeStock(cantidadProducto)
            With cantidadAQuitar
                .quitar = True
                .e_Producto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    actualizarProductos()
                End If
            End With
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'asigno el valor que habia agregado en la tabla anteriormente para asi poder filtrar el datagrid
        filtroElegido = cbBuscador.SelectedValue
        filtroBS = filtroElegido & " like '%" & txtBuscar.Text & "%'"
        bsProductos.Filter = filtroBS
    End Sub


    Private Sub cbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategorias.SelectedIndexChanged
        'Filtrado por categorias
        If cbCategorias.Text = "Todas" Then
            filtroBS = ""
            bsProductos.Filter = filtroBS
        Else
            filtroBS = "nombCategoria like '%" & cbCategorias.Text & "%'"
            bsProductos.Filter = filtroBS
        End If

    End Sub

    Private Sub cbBuscador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbBuscador.SelectedValueChanged
        txtBuscar.Text = ""
        txtBuscar.Focus()
    End Sub

    Private Sub frmProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case (Keys.Control + Keys.B)
                txtBuscar.Select()
            Case Keys.F10
                Call btnAgregarSeleccionar_Click(btnAgregarSeleccionar, e)
            Case Keys.F11
                Call btnBajaCancelar_Click(btnBajaCancelar, e)
            Case Keys.F12
                Call btnModificar_Click_1(btnModificar, e)
        End Select
    End Sub

End Class