Imports MySql.Data.MySqlClient
Public Class Configuracion
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba
#Region "Form Pago"
    Private _idFormPago As UInt16
    Public Property idFormPago As UInt16
        Set(value As UInt16)
            _idFormPago = value
        End Set
        Get
            Return _idFormPago
        End Get
    End Property
    Private _nombreFormPago As String
    Public Property nombreFormPago As String
        Set(value As String)
            _nombreFormPago = value
        End Set
        Get
            Return _nombreFormPago
        End Get
    End Property
    Private _recargo As UInt16
    Public Property recargo As UInt16
        Set(value As UInt16)
            _recargo = value
        End Set
        Get
            Return _recargo
        End Get
    End Property
    'Private _activo As UInt16
    'Public Property activo As UInt16
    '    Set(value As UInt16)
    '        _activo = value
    '    End Set
    '    Get
    '        Return _activo
    '    End Get
    'End Property
    Public Sub traerFormasDePago(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "Select * from formpago"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Function darDeBajaPago()
        Try
            Dim consultaSQL As String = "UPDATE formpago SET activo = 0 WHERE idformpago = '" & _idFormPago & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function darDeAltaPago()
        Try
            Dim consultaSQL As String = "UPDATE formpago SET activo = 1 WHERE idformpago = '" & _idFormPago & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function destacarPago()
        Try
            'Primero saco el que estaba destacado antes 
            Dim consultaSQL As String = "UPDATE formpago SET destacado = 0 WHERE destacado = '1'"
            capaDatos.cargarDatos(consultaSQL)
            consultaSQL = "UPDATE formpago SET destacado = 1 WHERE idformpago = '" & _idFormPago & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Sub traerNombre()
        Try
            Dim tabla As New DataTable
            Dim consultaSQL As String = "SELECT nombFormaPago FROM formpago WHERE idformpago = '" & _idFormPago & "'"
            capaDatos.llenarDatos(tabla, consultaSQL)
            _nombreFormPago = tabla.Rows(0).Item("nombFormaPago").ToString
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub nombreEditado()
        Try
            Dim consultaSQL As String = "UPDATE formpago SET nombFormaPago = '" & _nombreFormPago & "' WHERE idformpago = '" & _idFormPago & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub traerRecargo()
        Try
            Dim tabla As New DataTable
            Dim consultaSQL As String = "SELECT recargo FROM formpago WHERE idformpago = '" & _idFormPago & "'"
            capaDatos.llenarDatos(tabla, consultaSQL)
            _recargo = tabla.Rows(0).Item("recargo").ToString
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub recargoEditado()
        Try
            Dim consultaSQL As String = "UPDATE formpago SET recargo = '" & _recargo & "' WHERE idformpago = '" & _idFormPago & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub agregarFormaPago()
        Try
            Dim consultaSQL As String = "INSERT INTO formpago(nombFormaPago, destacado, recargo, activo) VALUES ('" & _nombreFormPago & "', '0','" & _recargo & "', '1')"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
#End Region
End Class
