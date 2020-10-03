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
            Dim consultaSQL As String = "SELECT * FROM formpago;"
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
#End Region
End Class
