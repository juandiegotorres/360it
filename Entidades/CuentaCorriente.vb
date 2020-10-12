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
#Region "Metodos"
    Public Sub verCuentaCliente(ByVal tabla As DataTable)
        Try
            Dim consultaSQL As String = "CALL verCuentaCorriente(" & _idCliente & ")"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Cuentas Corriente")
        End Try
    End Sub
#End Region
End Class
