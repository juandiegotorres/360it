Imports MySql.Data.MySqlClient
Public Class Venta
    Dim tablaNumeroVenta As New DataTable
    Private _nroVenta As UInt64
    Public Property nroVenta As UInt64
        Get
            Return _nroVenta
        End Get
        Set(value As UInt64)
            _nroVenta = value
        End Set
    End Property
    Private _idCliente As UInt64
    Public Property idCliente As UInt64
        Get
            Return _idCliente
        End Get
        Set(value As UInt64)
            _idCliente = value
        End Set
    End Property
    Private _cuotas As UShort
    Public Property cuotas As UShort
        Get
            Return _cuotas
        End Get
        Set(value As UShort)
            _cuotas = value
        End Set
    End Property
    Private _fechaHora As DateTime
    Public Property fechaHora As DateTime
        Get
            Return _fechaHora
        End Get
        Set(value As DateTime)
            _fechaHora = value
        End Set
    End Property
    Private _idVenta As UInt64
    Public Property idVenta As UInt64
        Get
            Return _idVenta
        End Get
        Set(value As UInt64)
            _idVenta = value
        End Set
    End Property
    Private _idFormPago As UInt16
    Public Property idFormPago As UInt16
        Get
            Return _idFormPago
        End Get
        Set(value As UInt16)
            _idFormPago = value
        End Set
    End Property
    Private _idProductos As List(Of UInt16)
    Public Property idProductos As List(Of UInt16)
        Get
            Return _idProductos
        End Get
        Set(value As List(Of UInt16))
            _idProductos = value
        End Set
    End Property
    Private _cantidad As List(Of UInt16)
    Public Property cantidad As List(Of UInt16)
        Get
            Return _cantidad
        End Get
        Set(value As List(Of UInt16))
            _cantidad = value
        End Set
    End Property
    Private _entregaDinero As Double
    Public Property entregaDinero As Double
        Get
            Return _entregaDinero
        End Get
        Set(value As Double)
            _entregaDinero = value
        End Set
    End Property
    Private _precioInicial As Double
    Public Property precioInicial As Double
        Get
            Return _precioInicial
        End Get
        Set(value As Double)
            _precioInicial = value
        End Set
    End Property
    Private _descuento As Double
    Public Property descuento As Double
        Get
            Return _descuento
        End Get
        Set(value As Double)
            _descuento = value
        End Set
    End Property
    Private _recargo As Double
    Public Property recargo As Double
        Get
            Return _recargo
        End Get
        Set(value As Double)
            _recargo = value
        End Set
    End Property
    Private _precioFinal As Double
    Public Property precioFinal As Double
        Get
            Return _precioFinal
        End Get
        Set(value As Double)
            _precioFinal = value
        End Set
    End Property
#Region "Metodos"
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba
    Public Sub verProductos(tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT * FROM vistaventaproducto"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Ventas")
        End Try
    End Sub
    Public Sub cargarFormasPago(tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT * FROM formpago ORDER BY destacado DESC"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Ventas")
        End Try
    End Sub
    Public Sub calcularNumeroVenta()
        Try
            tablaNumeroVenta.Clear()
            Dim consultaSQL As String = "SELECT count(idVenta) as 'nroVenta' FROM ventas"
            capaDatos.llenarDatos(tablaNumeroVenta, consultaSQL)
            _nroVenta = tablaNumeroVenta.Rows(0).Item("nroVenta").ToString
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Ventas")
        End Try
    End Sub
    Public Function venta() As Boolean
        Dim EjecutaComando As New CapaDeNegocios.cdDatosPrueba
        Dim comando As MySqlCommand
        Dim strComando As String
        Try
            strComando = "INSERT INTO ventas(fechaHora, formPago) VALUES (@fechaHora, @formPago);"
            comando = New MySqlCommand
            comando.CommandText = strComando
            comando.Parameters.Add("@formPago", MySqlDbType.Int16).Value = Me.idFormPago
            comando.Parameters.Add("@fechaHora", MySqlDbType.DateTime).Value = Me.fechaHora
            capaDatos.GuardarComando(comando)
            Return True
        Catch e As MySqlException
            MsgBox("ERROR:" & Chr(13) & e.Message)
            Return False
        End Try
    End Function
    Public Function detalleVenta() As Boolean
        If venta() = True Then
            Dim EjecutaComando As New CapaDeNegocios.cdDatosPrueba
            Dim comando(Me.idProductos.Count + 1) As MySqlCommand
            Dim strComando As String
            Dim Comandos As New List(Of MySqlCommand)
            Try
                For i = 0 To Me.idProductos.Count - 1
                    comando(i) = New MySqlCommand
                    comando(i).Parameters.Add("@precioInicial", MySqlDbType.Float).Value = Me.precioInicial
                    comando(i).Parameters.Add("@descuento", MySqlDbType.Float).Value = Me.descuento
                    comando(i).Parameters.Add("@recargo", MySqlDbType.Float).Value = Me.recargo
                    comando(i).Parameters.Add("@precioFinal", MySqlDbType.Float).Value = Me.precioFinal
                    comando(i).Parameters.Add("@producto", MySqlDbType.Int16)
                    comando(i).Parameters.Add("@cantidad", MySqlDbType.Int16)
                    strComando = "INSERT INTO detalleventa(venta, producto, cantidad, precioIncial, descuento, recargo, precioFinal) VALUES ((SELECT max(idVenta) FROM ventas), @producto, @cantidad, @precioInicial, @descuento, @recargo, @precioFinal); UPDATE productos SET cantidad = (cantidad - @cantidad) WHERE idProducto = @producto"
                    comando(i).CommandText = strComando
                    comando(i).Parameters("@producto").Value = Me.idProductos.Item(i)
                    comando(i).Parameters("@cantidad").Value = Me.cantidad.Item(i)
                    Comandos.Add(comando(i))
                Next
                capaDatos.GuardarListaComandos(Comandos)
                Return True
            Catch e As MySqlException
                MsgBox("ERROR:" & Chr(13) & e.Message)
                Return False
            End Try
        End If
        Return False
    End Function
    Public Function ventaCuentaCorriente() As Boolean
        Try

            Dim consultaSQL1 As String = "INSERT INTO movimientos(clienteMovimiento, tipoMovimiento, monto, fechaMovimiento) VALUES (@idCliente,@tipoMovimiento,@monto,@fecha)"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL1)
            sqlComando.Parameters.Add("@idCliente", MySqlDbType.Int64).Value = Me.idCliente
            sqlComando.Parameters.Add("@tipoMovimiento", MySqlDbType.VarChar).Value = "D"
            sqlComando.Parameters.Add("@monto", MySqlDbType.Int64).Value = Me.precioFinal
            sqlComando.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = Date.Now
            capaDatos.cargarDatos(sqlComando)
            If entregaDinero > 0 Then
                sqlComando.Parameters("@tipoMovimiento").Value = "C"
                sqlComando.Parameters("@monto").Value = entregaDinero
                capaDatos.cargarDatos(sqlComando)
            End If


            Dim consultaSQL2 As String = "INSERT INTO cuentascorriente(cliente, venta, cuotas) VALUES (@idCliente,(SELECT max(idVenta) FROM ventas), @cuotas)"
            Dim sqlComando1 As MySqlCommand = New MySqlCommand(consultaSQL2)
            sqlComando1.Parameters.Add("@idCliente", MySqlDbType.Int64).Value = Me.idCliente
            sqlComando1.Parameters.Add("@cuotas", MySqlDbType.UInt16).Value = Me.cuotas
            capaDatos.cargarDatos(sqlComando1)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
            Return False
        End Try
    End Function
#End Region
End Class
