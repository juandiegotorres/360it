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

#End Region
#Region "Metodos"
    Public Sub tipoArticulo(ByRef tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM tipoarticulo"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub estadoArticulo(ByRef tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM estado"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
#End Region
End Class
