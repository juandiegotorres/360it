﻿Imports MySql.Data.MySqlClient
Public Class Venta
    Dim tablaNumeroVenta As New DataTable
    Dim tablaCliente As New DataTable
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
    Private _precioProductos As List(Of UInt16)
    Public Property precioProductos As List(Of UInt16)
        Get
            Return _precioProductos
        End Get
        Set(value As List(Of UInt16))
            _precioProductos = value
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
    Private _tipoDescuentoRecargo As String
    Public Property tipoDescuentoRecargo As String
        Set(value As String)
            _tipoDescuentoRecargo = value
        End Set
        Get
            Return _tipoDescuentoRecargo
        End Get
    End Property
    Private _formPago As String
    Public Property formPago As String
        Set(value As String)
            _formPago = value
        End Set
        Get
            Return _formPago
        End Get
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
    Public Sub cargarHistorial(tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT * FROM vistahistorialventas"
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
            strComando = "INSERT INTO ventas(fechaHora, formPago, activo) VALUES (@fechaHora, @formPago, '1');"
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
                    comando(i).Parameters.Add("@tipoDescuentoRecargo", MySqlDbType.String).Value = Me.tipoDescuentoRecargo
                    comando(i).Parameters.Add("@producto", MySqlDbType.Int16)
                    comando(i).Parameters.Add("@precioProducto", MySqlDbType.Int16)
                    comando(i).Parameters.Add("@cantidad", MySqlDbType.Int16)
                    strComando = "INSERT INTO detalleventa(venta, producto, cantidad, precioProducto, precioInicial, descuento, recargo, tipoDescRec, precioFinal) VALUES ((SELECT max(idVenta) FROM ventas), @producto, @cantidad, @precioProducto, @precioInicial, @descuento, @recargo, @tipoDescuentoRecargo, @precioFinal); UPDATE productos SET cantidad = (cantidad - @cantidad) WHERE idProducto = @producto"
                    comando(i).CommandText = strComando
                    comando(i).Parameters("@precioProducto").Value = Me.precioProductos.Item(i)
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
    Public Function insertarMovimiento()
        Try
            Dim consultaSQL1 As String = "INSERT INTO movimientos(tipoMovimiento, monto, fechaMovimiento, cuentacorriente, venta) VALUES (@tipoMovimiento,@monto,@fecha,(SELECT idCuenta FROM cuentascorriente WHERE cliente = @idcliente), (SELECT max(idVenta) FROM ventas))"
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
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Ventas")
            Return False
        End Try

    End Function
    Public Function ventaCuentaCorriente() As Boolean
        Try
            tablaCliente.Clear()
            Dim consultarCliente As String = "SELECT idCuenta FROM cuentasCorriente WHERE cliente ='" & _idCliente & "'"
            capaDatos.llenarDatos(tablaCliente, consultarCliente)
            If tablaCliente.Rows.Count = 0 Then
                Dim consultaSQL2 As String = "INSERT INTO cuentascorriente(cliente, cuotas, montoRestante) VALUES (@idCliente, @cuotas, '0')"
                Dim sqlComando1 As MySqlCommand = New MySqlCommand(consultaSQL2)
                sqlComando1.Parameters.Add("@idCliente", MySqlDbType.Int64).Value = Me.idCliente
                sqlComando1.Parameters.Add("@cuotas", MySqlDbType.UInt16).Value = Me.cuotas
                capaDatos.cargarDatos(sqlComando1)
                insertarMovimiento()
            Else
                insertarMovimiento()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
            Return False
        End Try
    End Function
#End Region
#Region "Metodos Historial de Venta"
    Public Sub ventaXproductos(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "CALL detalleVentaProductos(" & _idVenta & ")"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Venta")
        End Try
    End Sub
    Public Sub detalleHistorialVenta()
        Try
            Dim tabla As New DataTable
            Dim consultaSQL As String = "SELECT fechaHora, nombFormaPago FROM ventas JOIN formpago ON ventas.formPago = formpago.idformpago WHERE idVenta = '" & _idVenta & "'"
            capaDatos.llenarDatos(tabla, consultaSQL)
            fechaHora = CDate(tabla.Rows(0).Item("fechaHora").ToString)
            formPago = tabla.Rows(0).Item("nombFormaPago").ToString()
            consultaSQL = "SELECT descuento, recargo, tipoDescRec, precioInicial, precioFinal FROM detalleventa WHERE venta = '" & _idVenta & "'"
            tabla.Clear()
            capaDatos.llenarDatos(tabla, consultaSQL)
            descuento = tabla.Rows(0).Item("descuento").ToString()
            recargo = tabla.Rows(0).Item("recargo").ToString()
            tipoDescuentoRecargo = tabla.Rows(0).Item("tipoDescRec").ToString()
            precioInicial = tabla.Rows(0).Item("precioInicial").ToString()
            precioFinal = tabla.Rows(0).Item("precioFinal").ToString()
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Venta")
        End Try
    End Sub
#End Region
End Class
