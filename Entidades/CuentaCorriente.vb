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
    Public Function entregaDinero()
        Try
            Dim consultaSQL As String = "INSERT INTO movimientos(clienteMovimiento, tipoMovimiento, monto, fechaMovimiento) VALUES (@idCliente,@tipoMovimiento,@monto, @fechaMovimiento)"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
            sqlComando.Parameters.Add("@idCliente", MySqlDbType.Int64).Value = Me.idCliente
            sqlComando.Parameters.Add("@tipoMovimiento", MySqlDbType.String).Value = "C"
            sqlComando.Parameters.Add("@monto", MySqlDbType.Float).Value = Me.entrega
            sqlComando.Parameters.Add("@fechaMovimiento", MySqlDbType.DateTime).Value = Date.Now
            capaDatos.cargarDatos(sqlComando)

            Dim consultaSQL1 As String = "UPDATE cuentascorriente SET montoRestante = (montoRestante + @monto) WHERE cliente = @idCliente AND venta = @idVenta"
            Dim sqlComando1 As MySqlCommand = New MySqlCommand(consultaSQL1)
            sqlComando1.Parameters.Add("@idCliente", MySqlDbType.Int64).Value = Me.idCliente
            sqlComando1.Parameters.Add("@monto", MySqlDbType.Float).Value = Me.entrega
            sqlComando1.Parameters.Add("@idVenta", MySqlDbType.Int64).Value = Me.idVenta
            capaDatos.cargarDatos(sqlComando1)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Cuenta Corriente")
            Return False
        End Try
    End Function
#End Region
End Class
