Public Class Localidad
    Private _idLocalidad As UInt16
    Public Property idLocalidad As UInt16
        Set(value As UInt16)
            _idLocalidad = value
        End Set
        Get
            Return _idLocalidad
        End Get
    End Property
    Private _nombLocalidad As String
    Public Property nombLocalidad As String
        Set(value As String)
            _nombLocalidad = value
        End Set
        Get
            Return _nombLocalidad
        End Get
    End Property
    Private _idProvincia As UInt16
    Public Property idProvincia As UInt16
        Set(value As UInt16)
            _idProvincia = value
        End Set
        Get
            Return _idProvincia
        End Get
    End Property
#Region "Declaracion de métodos"
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba
    Public Sub traerLocalidades(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT * FROM localidades WHERE provincia = '" & _idProvincia & "'"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub nuevaLocalidad()
        Try
            Dim consultaSQL As String = "INSERT INTO localidades (nombLocalidad, provincia) VALUES ('" & _nombLocalidad & "','" & _idProvincia & "')"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
