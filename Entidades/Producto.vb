Public Class Producto
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba
#Region "Declaración de propiedes"

    Private _idProducto As UInteger
    Public Property idProducto As UInteger
        Set(value As UInteger)
            _idProducto = value
        End Set
        Get
            Return _idProducto
        End Get
    End Property

    Private _nombProducto As String
    Public Property nombProducto As String
        Set(value As String)
            _nombProducto = value
        End Set
        Get
            Return _nombProducto
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


    Private _idProveedor As UInt16
    Public Property idProveedor As UInt16
        Set(value As UInt16)
            _idProveedor = value
        End Set
        Get
            Return _idProveedor
        End Get
    End Property

    Private _nombProveedor As String
    Public Property nombProveedor As String
        Set(value As String)
            _nombProveedor = value
        End Set
        Get
            Return _nombProveedor
        End Get
    End Property

    Private _categoria As UInt16
    Public Property categoria As UInt16
        Set(value As UInt16)
            _categoria = value
        End Set
        Get
            Return _categoria
        End Get
    End Property

    Private _cantidad As UInt32
    Public Property cantidad As UInt32
        Set(value As UInt32)
            _cantidad = value
        End Set
        Get
            Return _cantidad
        End Get
    End Property

    Private _precioCosto As Double
    Public Property precioCosto As Double
        Set(value As Double)
            _precioCosto = value
        End Set
        Get
            Return _precioCosto
        End Get
    End Property

    Private _precioVenta As Double
    Public Property precioVenta As Double
        Set(value As Double)
            _precioVenta = value
        End Set
        Get
            Return _precioVenta
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

#End Region
#Region "Metodos"

    Public Sub categorias(ByRef tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM categorias"
        capaDatos.llenarDatos(tabla, consultaSQL)

    End Sub

#End Region
End Class
