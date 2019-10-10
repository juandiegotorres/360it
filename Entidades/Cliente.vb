Imports MySql.Data.MySqlClient
Public Class Cliente
#Region "Declaracion de propiedades"
    Private _idCliente As UInt32
    Public Property idCliente As UInt32
        Get
            Return _idCliente
        End Get
        Set(value As UInt32)
            _idCliente = value
        End Set
    End Property
    Private _nombApel As String
    Public Property nombApel As String
        Get
            Return _nombApel
        End Get
        Set(value As String)
            _nombApel = value
        End Set
    End Property
    Private _idLocalidad As UInt16
    Public Property idLocalidad As UInt16
        Get
            Return _idLocalidad
        End Get
        Set(value As UInt16)
            _idLocalidad = value
        End Set
    End Property
    Private _nombLocalidad As String
    Public Property nombLocalidad As String
        Get
            Return _nombLocalidad
        End Get
        Set(value As String)
            _nombLocalidad = value
        End Set
    End Property
    Private _idProvincia As UInt16
    Public Property idProvincia As UInt16
        Get
            Return _idProvincia
        End Get
        Set(value As UInt16)
            _idProvincia = value
        End Set
    End Property
    Private _nombProvincia As UInt16
    Public Property nombProvincia As String
        Get
            Return _nombProvincia
        End Get
        Set(value As String)
            _nombProvincia = value
        End Set
    End Property
    Private _telefono As String
    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Private _direccion As String
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
#End Region
#Region "Métodos"
    Dim SqlComando As MySqlCommand
    Dim capaDatos As New CapaDeNegocios.cdDatos
    Dim capaDatosPrueba As New CapaDeNegocios.cdDatosPrueba
    Public Sub traerProvincias(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "Select * from provincias"
            capaDatosPrueba.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
        End Try
    End Sub
    Public Sub guardarCliente()
        Try
            Dim comandoSQL As String = "Insert into clientes(nombreapel, direccion, localidad, provincia, telefono, activo) VALUES (@nombreApel,@direccion,@localidad,@provincia,@telefono,'1')"
            Dim sqlcomando As MySqlCommand = New MySqlCommand(comandoSQL)
            sqlcomando.Parameters.Add("@nombreApel", MySqlDbType.VarChar).Value = Me.nombApel
            sqlcomando.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = Me.direccion
            sqlcomando.Parameters.Add("@localidad", MySqlDbType.Int16).Value = Me.idLocalidad
            sqlcomando.Parameters.Add("@provincia", MySqlDbType.Int16).Value = Me.idProvincia
            sqlcomando.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = Me.telefono
            capaDatosPrueba.cargarDatos(sqlcomando)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
        End Try
    End Sub
    Public Sub traerClientes(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "Select * from vistaclientes"
            capaDatosPrueba.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
        End Try
    End Sub

    Public Sub bajaCliente()
        Try
            Dim consultaSQL As String = "UPDATE clientes SET activo = 0 WHERE idcliente = '" & _idCliente & "'"
            capaDatosPrueba.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
        End Try
    End Sub
    Public Sub modificarCliente()
        Try
            Dim consultaSQL As String = "SELECT * FROM vistaclientes WHERE idCliente ='" & _idCliente & "'"
            Dim tabla As New DataTable
            capaDatosPrueba.llenarDatos(tabla, consultaSQL)
            If tabla.Rows.Count = 1 Then
                _nombApel = tabla.Rows(0).Item("nombreApel").ToString
                _telefono = tabla.Rows(0).Item("telefono").ToString
                _direccion = tabla.Rows(0).Item("direccion").ToString
                _idProvincia = tabla.Rows(0).Item("provincia").ToString
                _idLocalidad = tabla.Rows(0).Item("localidad").ToString
                _nombLocalidad = tabla.Rows(0).Item("nombLocalidad").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
        End Try
    End Sub
    Public Sub guardarClienteModif()
        Try
            Dim consultaSQL As String = "UPDATE clientes SET nombreApel ='" & _nombApel & "', telefono = '" & _telefono & "', direccion = '" & _direccion & "', provincia = '" & _idProvincia & "', localidad ='" & _idLocalidad & "' WHERE idCliente = '" & _idCliente & "'"
            capaDatosPrueba.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
        End Try
    End Sub
#End Region
End Class
