Imports MySql.Data.MySqlClient
Public Class Producto
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba
#Region "Declaración de propiedes"

    Private _idProducto As UInteger
    Public Property idProducto As UInteger
        Set(value As UInteger)
            _idProducto = value
        End Set
        Get
            Return _idProducto
        End Get
    End Property

    Private _tipoProducto As String
    Public Property tipoProducto As String
        Set(value As String)
            _tipoProducto = value
        End Set
        Get
            Return _tipoProducto
        End Get
    End Property

    Private _marca As String
    Public Property marca As String
        Set(value As String)
            _marca = value
        End Set
        Get
            Return _marca
        End Get
    End Property

    Private _modelo As String
    Public Property modelo As String
        Set(value As String)
            _modelo = value
        End Set
        Get
            Return _modelo
        End Get
    End Property


    Private _idProveedor As UInt16
    Public Property idProveedor As UInt16
        Set(value As UInt16)
            _idProveedor = value
        End Set
        Get
            Return _idProveedor
        End Get
    End Property

    Private _nombProveedor As String
    Public Property nombProveedor As String
        Set(value As String)
            _nombProveedor = value
        End Set
        Get
            Return _nombProveedor
        End Get
    End Property

    Private _categoria As UInt16
    Public Property categoria As UInt16
        Set(value As UInt16)
            _categoria = value
        End Set
        Get
            Return _categoria
        End Get
    End Property

    Private _cantidad As UInt32
    Public Property cantidad As UInt32
        Set(value As UInt32)
            _cantidad = value
        End Set
        Get
            Return _cantidad
        End Get
    End Property

    Private _precioCosto As Double
    Public Property precioCosto As Double
        Set(value As Double)
            _precioCosto = value
        End Set
        Get
            Return _precioCosto
        End Get
    End Property

    Private _precioVenta As Double
    Public Property precioVenta As Double
        Set(value As Double)
            _precioVenta = value
        End Set
        Get
            Return _precioVenta
        End Get
    End Property

    Private _descripcion As String
    Public Property descripcion As String
        Set(value As String)
            _descripcion = value
        End Set
        Get
            Return _descripcion
        End Get
    End Property

#End Region
#Region "Metodos"

    Public Sub categorias(ByRef tabla As DataTable)
        Dim consultaSQL As String = "SELECT idcategoria, nombCategoria FROM categorias WHERE activo = 1 ORDER BY destacado DESC"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub recuperarProductos(ByVal tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM vistaproductos"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub productosPocoStock(ByVal tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM vistaproductos WHERE cantidad >= 1 and cantidad <= 5"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub recuperarProductosXProveedor(ByVal tabla As DataTable, ByRef idProveedor As UInt64)
        Dim consultaSQL As String = "SELECT * FROM vistaproductos WHERE proveedor = '" & idProveedor & "'"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub nuevoProducto()
        Try
            Dim consultaSQL As String = "INSERT INTO productos(categoria, tipoProducto, marca, modelo, descripcion, proveedor, cantidad, precioCosto, precioVenta, activo) VALUES (@categoria,@tipoProducto,@marca,@modelo,@descripcion,@proveedor,@cantidad,@precioCosto,@precioVenta,'1')"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
            sqlComando.Parameters.Add("@categoria", MySqlDbType.Int64).Value = Me.categoria
            sqlComando.Parameters.Add("@tipoProducto", MySqlDbType.VarChar).Value = Me.tipoProducto
            sqlComando.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = Me.modelo
            sqlComando.Parameters.Add("@marca", MySqlDbType.VarChar).Value = Me.marca
            sqlComando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = Me.descripcion
            sqlComando.Parameters.Add("@proveedor", MySqlDbType.Int64).Value = Me.idProveedor
            sqlComando.Parameters.Add("@cantidad", MySqlDbType.Int64).Value = Me.cantidad
            sqlComando.Parameters.Add("@precioCosto", MySqlDbType.Float).Value = Me.precioCosto
            sqlComando.Parameters.Add("@precioVenta", MySqlDbType.Float).Value = Me.precioVenta

            capaDatos.cargarDatos(sqlComando)

        Catch ex As Exception
            MsgBox(ex.Message, "Productos")

        End Try
    End Sub
    Public Sub bajaProducto()
        Try
            Dim consultaSQL As String = "UPDATE productos SET activo = 0 WHERE idProducto = '" & _idProducto & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Producto")
        End Try
    End Sub
    Public Sub modificarProducto()
        Try
            Dim consultaSQL As String = "SELECT * FROM vistaproductos WHERE idProducto ='" & _idProducto & "'"
            Dim tabla As New DataTable
            capaDatos.llenarDatos(tabla, consultaSQL)
            If tabla.Rows.Count = 1 Then
                _idProveedor = tabla.Rows(0).Item("proveedor").ToString
                _categoria = tabla.Rows(0).Item("categoria").ToString
                _tipoProducto = tabla.Rows(0).Item("tipoProducto").ToString
                _marca = tabla.Rows(0).Item("marca").ToString
                _modelo = tabla.Rows(0).Item("modelo").ToString
                If LTrim(tabla.Rows(0).Item("descripcion").ToString) = "" Then
                    _descripcion = "Sin descripción"
                Else
                    _descripcion = tabla.Rows(0).Item("descripcion").ToString
                End If
                _nombProveedor = tabla.Rows(0).Item("nombreProveedor").ToString
                _cantidad = tabla.Rows(0).Item("cantidad").ToString
                _precioCosto = tabla.Rows(0).Item("precioCosto").ToString
                _precioVenta = tabla.Rows(0).Item("precioVenta").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
        End Try
    End Sub
    Public Sub guardarProductoModificado()
        Try
            Dim consultaSQL As String = "UPDATe productos SET categoria = @categoria, tipoProducto = @tipoProducto, modelo = @modelo, marca = @marca, descripcion = @descripcion, proveedor = @proveedor, cantidad = @cantidad, precioCosto = @precioCosto, precioVenta = @precioVenta WHERE idProducto = '" & _idProducto & "'"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
            sqlComando.Parameters.Add("@categoria", MySqlDbType.Int64).Value = Me.categoria
            sqlComando.Parameters.Add("@tipoProducto", MySqlDbType.VarChar).Value = Me.tipoProducto
            sqlComando.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = Me.modelo
            sqlComando.Parameters.Add("@marca", MySqlDbType.VarChar).Value = Me.marca
            sqlComando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = Me.descripcion
            sqlComando.Parameters.Add("@proveedor", MySqlDbType.Int64).Value = Me.idProveedor
            sqlComando.Parameters.Add("@cantidad", MySqlDbType.Int64).Value = Me.cantidad
            sqlComando.Parameters.Add("@precioCosto", MySqlDbType.Float).Value = Me.precioCosto
            sqlComando.Parameters.Add("@precioVenta", MySqlDbType.Float).Value = Me.precioVenta

            capaDatos.cargarDatos(sqlComando)

        Catch ex As Exception
            MsgBox(ex.Message, "Productos")

        End Try
    End Sub
    Public Sub quitarDelStock()
        Try
            Dim consultaSQL As String = "UPDATE productos SET cantidad = (cantidad - @cantidad) WHERE idProducto = @producto"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
            sqlComando.Parameters.Add("@producto", MySqlDbType.Int64).Value = Me.idProducto
            sqlComando.Parameters.Add("@cantidad", MySqlDbType.Int64).Value = Me.cantidad
            capaDatos.cargarDatos(sqlComando)
        Catch ex As Exception
            MsgBox(ex.Message, "Productos")

        End Try
    End Sub
    Public Sub agregarAlStock()
        Try
            Dim consultaSQL As String = "UPDATE productos SET cantidad = (cantidad + @cantidad) WHERE idProducto = @producto"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
            sqlComando.Parameters.Add("@producto", MySqlDbType.Int64).Value = Me.idProducto
            sqlComando.Parameters.Add("@cantidad", MySqlDbType.Int64).Value = Me.cantidad
            capaDatos.cargarDatos(sqlComando)
        Catch ex As Exception
            MsgBox(ex.Message, "Productos")

        End Try
    End Sub
    Public Sub aumentarPrecio(ByVal porcentaje As Double, ByVal todos As Boolean)
        Try
            If todos = True Then
                Dim consultaSQL As String = "UPDATE productos SET precioVenta = (precioVenta * @porcentaje)"
                Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
                sqlComando.Parameters.Add("@porcentaje", MySqlDbType.Double).Value = porcentaje
                capaDatos.cargarDatos(sqlComando)
            Else
                Dim consultaSQL As String = "UPDATE productos SET precioVenta = (precioVenta * @porcentaje) WHERE idProducto = @id"
                Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
                sqlComando.Parameters.Add("@porcentaje", MySqlDbType.Double).Value = porcentaje
                sqlComando.Parameters.Add("@id", MySqlDbType.Double).Value = Me.idProducto
                capaDatos.cargarDatos(sqlComando)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, "Productos")

        End Try
    End Sub
    Public Sub disminuirPrecio(ByVal porcentaje As Double, ByVal todos As Boolean)
        Try
            If todos = True Then
                Dim consultaSQL As String = "UPDATE productos SET precioVenta = (precioVenta * @porcentaje)"
                Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
                sqlComando.Parameters.Add("@porcentaje", MySqlDbType.Double).Value = porcentaje
                capaDatos.cargarDatos(sqlComando)
            Else
                Dim consultaSQL As String = "UPDATE productos SET precioVenta = (precioVenta * @porcentaje) WHERE idProducto = @id"
                Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
                sqlComando.Parameters.Add("@porcentaje", MySqlDbType.Double).Value = porcentaje
                sqlComando.Parameters.Add("@id", MySqlDbType.Double).Value = Me.idProducto
                capaDatos.cargarDatos(sqlComando)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Productos")

        End Try
    End Sub
#End Region
End Class
