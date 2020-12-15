Imports MySql.Data.MySqlClient
Public Class CuentaCorriente
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba
    Private _idCliente As UInt64
    Public Property idCliente As UInt64
        Get
            Return _idCliente
        End Get
        Set(value As UInt64)
            _idCliente = value
        End Set
    End Property
    Private _resto As Double
    Public Property resto As Double
        Get
            Return _resto
        End Get
        Set(value As Double)
            _resto = value
        End Set
    End Property
    Private _idMovimiento As UInt64
    Public Property idMovimiento As UInt64
        Get
            Return _idMovimiento
        End Get
        Set(value As UInt64)
            _idMovimiento = value
        End Set
    End Property
    Private _idCtaCorriente As UInt64
    Public Property idCtaCorriente As UInt64
        Get
            Return _idCtaCorriente
        End Get
        Set(value As UInt64)
            _idCtaCorriente = value
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
    Private _entrega As Double
    Public Property entrega As Double
        Get
            Return _entrega
        End Get
        Set(value As Double)
            _entrega = value
        End Set
    End Property
#Region "Metodos"
    Public Function filtrarVentasCliente(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "Select movimientos.venta, concat_ws(' - ', movimientos.venta, date_format(fechaMovimiento, '%d/%m/%y')) as 'ventaFecha' from clientes inner join cuentascorriente on clientes.idcliente = cuentascorriente.cliente inner join movimientos on cuentascorriente.idCuenta = movimientos.cuentacorriente inner join ventas ON movimientos.venta = ventas.idventa WHERE cuentascorriente.cliente = '" & _idCliente & "' and ventas.activo = 1 group by venta order by fechaMovimiento DESC"
            capaDatos.llenarDatos(tabla, consultaSQL)
            If tabla.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Cuentas Corriente")
            Return False
        End Try
    End Function
    Public Function verCuentaCliente(ByVal tabla As DataTable)
        Try
            Dim consultaSQL As String = "CALL verMovimientoCuenta(" & _idCliente & ")"
            capaDatos.llenarDatos(tabla, consultaSQL)
            If tabla.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Cuentas Corriente")
            Return False
        End Try
    End Function
    Public Sub cargarVentasCliente(ByVal tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT venta FROM movimientos WHERE cuentacorriente = '" & _idCtaCorriente & "' GROUP BY venta"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cuenta Corriente")
        End Try
    End Sub
    Public Function entregaDinero()
        Try
            Dim consultaSQL As String = "INSERT INTO movimientos(tipoMovimiento, monto, fechaMovimiento, cuentacorriente, venta, activo) VALUES (@tipoMovimiento,@monto, @fechaMovimiento, @cuentacorriente, @venta, 1)"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
            sqlComando.Parameters.Add("@tipoMovimiento", MySqlDbType.String).Value = "C"
            sqlComando.Parameters.Add("@monto", MySqlDbType.Float).Value = Me.entrega
            sqlComando.Parameters.Add("@fechaMovimiento", MySqlDbType.DateTime).Value = Date.Now
            sqlComando.Parameters.Add("@cuentacorriente", MySqlDbType.UInt32).Value = Me.idCtaCorriente
            sqlComando.Parameters.Add("@venta", MySqlDbType.UInt64).Value = Me.idVenta
            capaDatos.cargarDatos(sqlComando)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Cuenta Corriente")
            Return False
        End Try
    End Function
    Public Sub eliminarMovimiento()
        Try
            Dim consultaSQL As String = "DELETE FROM movimientos WHERE idmovimiento = '" & _idMovimiento & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cuenta Corriente")
        End Try
    End Sub
    Public Function bajaVenta(ByRef idVenta_ As UInt64, ByRef Optional movimientos As Boolean = False)
        Try
            Dim consultaSQL As String = "UPDATE ventas SET activo = 0 WHERE idVenta = '" & idVenta_ & "'"
            capaDatos.cargarDatos(consultaSQL)
            If movimientos = True Then
                consultaSQL = "UPDATE movimientos SET activo = 0 WHERE idVenta = '" & idVenta_ & "'"
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Ventas")
            Return False
        End Try
    End Function
    Public Function eliminarTodosLosMovimientos(ByRef idVenta_ As UInt64)
        Try
            Dim consultaSQL As String = "DELETE FROM movimientos WHERE venta = '" & idVenta_ & "' AND tipoMovimiento = 'C'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Cuentas Corriente")
            Return False
        End Try
    End Function
    Public Sub calcularRestoVenta(ByRef idVenta As UInt64)
        Dim tabla As New DataTable
        Dim consultaSQL As String = "CALL calcularResto(" & idVenta & ")"
        capaDatos.llenarDatos(tabla, consultaSQL)
        _resto = tabla.Rows(0).Item("total").ToString
    End Sub
#End Region
End Class
