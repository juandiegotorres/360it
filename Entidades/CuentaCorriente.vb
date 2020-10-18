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
    Public Sub verCuentaCliente(ByVal tabla As DataTable)
        Try
            Dim consultaSQL As String = "CALL verMovimientoCuenta(" & _idCliente & ")"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Cuentas Corriente")
        End Try
    End Sub
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
            Dim consultaSQL As String = "INSERT INTO movimientos(tipoMovimiento, monto, fechaMovimiento, cuentacorriente, venta) VALUES (@tipoMovimiento,@monto, @fechaMovimiento, @cuentacorriente, @venta)"
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
#End Region
End Class
