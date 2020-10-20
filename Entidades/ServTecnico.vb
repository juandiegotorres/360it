Imports MySql.Data.MySqlClient
Public Class ServTecnico
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba
#Region "Declaracion de propiedades"

    Private _idReparacion As UInt64
    Public Property idReparacion As UInt64
        Set(value As UInt64)
            _idReparacion = value
        End Set
        Get
            Return _idReparacion
        End Get
    End Property
    Private _idCliente As UInt64
    Public Property idCliente As UInt64
        Set(value As UInt64)
            _idCliente = value
        End Set
        Get
            Return _idCliente
        End Get
    End Property
    Private _nombreCliente As String
    Public Property nombreCliente As String
        Set(value As String)
            _nombreCliente = value
        End Set
        Get
            Return _nombreCliente
        End Get
    End Property
    Private _idTipo As UInt16
    Public Property idTipo As UInt64
        Set(value As UInt64)
            _idTipo = value
        End Set
        Get
            Return _idTipo
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
    Private _descripcion As String
    Public Property descripcion As String
        Set(value As String)
            _descripcion = value
        End Set
        Get
            Return _descripcion
        End Get
    End Property
    Private _accesorios As String
    Public Property accesorios As String
        Set(value As String)
            _accesorios = value
        End Set
        Get
            Return _accesorios
        End Get
    End Property
    Private _fechaRecep As Date
    Public Property fechaRecep As Date
        Set(value As Date)
            _fechaRecep = value
        End Set
        Get
            Return _fechaRecep
        End Get
    End Property
    Private _fechaLimite As Date
    Public Property fechaLimite As Date
        Set(value As Date)
            _fechaLimite = value
        End Set
        Get
            Return _fechaLimite
        End Get
    End Property
    Private _idEstado As UInt16
    Public Property idEstado As UInt64
        Set(value As UInt64)
            _idEstado = value
        End Set
        Get
            Return _idEstado
        End Get
    End Property
    Private _entregado As UInt16
    Public Property entregado As UInt64
        Set(value As UInt64)
            _entregado = value
        End Set
        Get
            Return _entregado
        End Get
    End Property
    Private _nombreEstado As String
    Public Property nombreEstado As String
        Set(value As String)
            _nombreEstado = value
        End Set
        Get
            Return _nombreEstado
        End Get
    End Property
    Private _notaTecnico As String
    Public Property notaTecnico As String
        Set(value As String)
            _notaTecnico = value
        End Set
        Get
            Return _notaTecnico
        End Get
    End Property
#End Region
#Region "Metodos"
    Public Sub traerReparaciones(ByVal tabla As DataTable, ByRef id As UInt16)
        Try
            Dim consultaSQL As String = "CALL procedimiento_servtecnico(" & id & ")"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
        End Try
    End Sub
    Public Sub detalleReparacion()
        Try
            Dim tabla As New DataTable
            Dim consultaSQL As String = "SELECT clientes.nombreApel, estado.nombreEstado, accesorios, descripcion, notaTecnico FROM serviciotecnico JOIN clientes ON serviciotecnico.cliente = clientes.idcliente JOIN estado ON estado.id = serviciotecnico.estado WHERE idReparacion = '" & _idReparacion & "'"
            capaDatos.llenarDatos(tabla, consultaSQL)
            _nombreCliente = tabla.Rows(0).Item("nombreApel").ToString
            _nombreEstado = tabla.Rows(0).Item("nombreEstado").ToString
            _accesorios = tabla.Rows(0).Item("accesorios").ToString
            _descripcion = tabla.Rows(0).Item("descripcion").ToString
            _notaTecnico = tabla.Rows(0).Item("notaTecnico").ToString
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
        End Try
    End Sub
    Public Sub verNotaTecnico()
        Try
            Dim tabla As New DataTable
            Dim consultaSQL As String = "SELECT notaTecnico FROM serviciotecnico WHERE idReparacion = '" & _idReparacion & "'"
            capaDatos.llenarDatos(tabla, consultaSQL)
            _notaTecnico = tabla.Rows(0).Item("notaTecnico").ToString
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
        End Try
    End Sub
    Public Sub tipoArticulo(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT * FROM tipoarticulo WHERE activo = 1"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
        End Try
    End Sub
    Public Sub estadoReparacion(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT * FROM estado WHERE activo = 1"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
        End Try
    End Sub

    Public Function nuevaReparacion()
        Try
            Dim consultaSQL As String = "INSERT INTO serviciotecnico(cliente, tipo, marca, modelo, accesorios, descripcion, fechaRecep, fechaLimite, estado, activo) VALUES (@idCliente,@tipo,@marca, @modelo,@accesorios,@descripcion,@fechaRecep,@fechaLimite,@estado,'1')"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
            sqlComando.Parameters.Add("@idCliente", MySqlDbType.Int64).Value = Me.idCliente
            sqlComando.Parameters.Add("@tipo", MySqlDbType.Int64).Value = Me.idTipo
            sqlComando.Parameters.Add("@marca", MySqlDbType.VarChar).Value = Me.marca
            sqlComando.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = Me.modelo
            sqlComando.Parameters.Add("@accesorios", MySqlDbType.VarChar).Value = Me.accesorios
            sqlComando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = Me.descripcion
            sqlComando.Parameters.Add("@fechaRecep", MySqlDbType.Date).Value = Me.fechaRecep
            sqlComando.Parameters.Add("@fechaLimite", MySqlDbType.Date).Value = Me.fechaLimite
            sqlComando.Parameters.Add("@estado", MySqlDbType.Int32).Value = Me.idEstado
            capaDatos.cargarDatos(sqlComando)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
            Return False
        End Try
    End Function

    Public Sub modificarReparacion()
        Try
            Dim tabla As New DataTable
            Dim consultaSQL As String = "SELECT clientes.nombreApel, idReparacion, cliente, tipo, marca, modelo, accesorios, descripcion, fechaRecep, fechaLimite, estado FROM serviciotecnico JOIN clientes on serviciotecnico.cliente = clientes.idcliente WHERE idReparacion = '" & _idReparacion & "'"
            capaDatos.llenarDatos(tabla, consultaSQL)
            _idReparacion = tabla.Rows(0).Item("idReparacion").ToString
            _nombreCliente = tabla.Rows(0).Item("nombreApel").ToString
            _idCliente = tabla.Rows(0).Item("cliente").ToString
            _idTipo = tabla.Rows(0).Item("tipo").ToString
            _marca = tabla.Rows(0).Item("marca").ToString
            _modelo = tabla.Rows(0).Item("modelo").ToString
            _accesorios = tabla.Rows(0).Item("accesorios").ToString
            _descripcion = tabla.Rows(0).Item("descripcion").ToString
            _fechaRecep = tabla.Rows(0).Item("fechaRecep").ToString
            _fechaLimite = tabla.Rows(0).Item("fechaLimite").ToString
            _idEstado = tabla.Rows(0).Item("estado").ToString
        Catch ex As Exception
            MsgBox(ex.Message, "Servicio Técnico")
        End Try
    End Sub
    Public Function guardarReparacionModificada()
        Try
            Dim comandoSQL As String = "UPDATE serviciotecnico SET cliente = @idCliente, tipo = @idTipo, marca = @marca, modelo = @modelo, accesorios = @accesorios, descripcion = @descripcion, fechaRecep = @fechaRecep, fechaLimite = @fechaLimite, estado = @idEstado WHERE idReparacion = @idReparacion"
            Dim sqlcomando As MySqlCommand = New MySqlCommand(comandoSQL)
            sqlcomando.Parameters.Add("@idReparacion", MySqlDbType.UInt64).Value = Me.idReparacion
            sqlcomando.Parameters.Add("@idCliente", MySqlDbType.UInt64).Value = Me.idCliente
            sqlcomando.Parameters.Add("@idTipo", MySqlDbType.UInt64).Value = Me.idTipo
            sqlcomando.Parameters.Add("@marca", MySqlDbType.VarChar).Value = Me.marca
            sqlcomando.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = Me.modelo
            sqlcomando.Parameters.Add("@accesorios", MySqlDbType.VarChar).Value = Me.accesorios
            sqlcomando.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = Me.descripcion
            sqlcomando.Parameters.Add("@fechaRecep", MySqlDbType.Date).Value = Me.fechaRecep
            sqlcomando.Parameters.Add("@fechaLimite", MySqlDbType.Date).Value = Me.fechaLimite
            sqlcomando.Parameters.Add("@idEstado", MySqlDbType.UInt64).Value = Me.idEstado
            capaDatos.cargarDatos(sqlcomando)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
            Return False
        End Try
    End Function
    Public Function cambiarEstado()
        Try
            Dim comandoSQL As String = "UPDATE serviciotecnico SET estado = @estado, notaTecnico = @notaTecnico WHERE idReparacion = @idReparacion"
            Dim sqlcomando As MySqlCommand = New MySqlCommand(comandoSQL)
            sqlcomando.Parameters.Add("@idReparacion", MySqlDbType.UInt64).Value = Me.idReparacion
            sqlcomando.Parameters.Add("@estado", MySqlDbType.UInt64).Value = Me.idEstado
            sqlcomando.Parameters.Add("@notaTecnico", MySqlDbType.VarChar).Value = Me.notaTecnico
            capaDatos.cargarDatos(sqlcomando)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Cliente")
            Return False
        End Try
    End Function
    Public Sub bajaReparacion()
        Dim comandoSQl As String = "UPDATE serviciotecnico SET activo = 0 WHERE idReparacion = @idReparacion"
        Dim sqlcomando As MySqlCommand = New MySqlCommand(comandoSQl)
        sqlcomando.Parameters.Add("@idReparacion", MySqlDbType.UInt64).Value = Me.idReparacion
        capaDatos.cargarDatos(sqlcomando)
    End Sub
#End Region
End Class
