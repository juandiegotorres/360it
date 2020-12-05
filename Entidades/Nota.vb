Imports MySql.Data.MySqlClient
Public Class Nota
    Dim eCapaDatos As New CapaDeNegocios.cdDatosPrueba
    Private _idNota As UInt64
    Public Property idNota As UInt64
        Set(value As UInt64)
            _idNota = value
        End Set
        Get
            Return _idNota
        End Get
    End Property
    Private _nota As String
    Public Property nota As String
        Set(value As String)
            _nota = value
        End Set
        Get
            Return _nota
        End Get
    End Property
    Private _fecha As Date
    Public Property fecha As Date
        Set(value As Date)
            _fecha = value
        End Set
        Get
            Return _fecha
        End Get
    End Property
    Private _color As UInt16
    Public Property color As UInt16
        Set(value As UInt16)
            _color = value
        End Set
        Get
            Return _color
        End Get
    End Property
    Public Sub traerNotas(ByVal tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT * FROM notas WHERE activo = 1 ORDER BY fecha DESC"
            eCapaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Notas")
        End Try
    End Sub
    Public Sub bajaNota(ByRef id As UInteger)
        Try
            Dim consultaSQL As String = "UPDATE notas SET activo = 0 WHERE idnota = '" & id & "'"
            eCapaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function nuevaNota()
        Try
            Dim ComandoSQL As String = "INSERT INTO notas(nota,fecha,color,activo) VALUES(@nota, @fecha, @color, '1')"
            Dim sqlcomando As MySqlCommand = New MySqlCommand(ComandoSQL)
            sqlcomando.Parameters.Add("@nota", MySqlDbType.VarChar).Value = Me.nota
            sqlcomando.Parameters.Add("@fecha", MySqlDbType.Date).Value = Me.fecha
            sqlcomando.Parameters.Add("@color", MySqlDbType.Int16).Value = Me.color
            eCapaDatos.cargarDatos(sqlcomando)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Notas")
            Return False
        End Try
    End Function
    Public Sub traerNotaModificar(ByVal tabla As DataTable, ByRef id As UInt64)
        Try
            Dim consultaSQL As String = "SELECT * FROM notas WHERE idnota = " & id
            eCapaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function guardarNotaModificada()
        Try
            Dim ComandoSQL As String = "UPDATE notas SET nota = @nota, color = @color WHERE idnota = @id"
            Dim sqlcomando As MySqlCommand = New MySqlCommand(ComandoSQL)
            sqlcomando.Parameters.Add("@id", MySqlDbType.Int64).Value = Me.idNota
            sqlcomando.Parameters.Add("@nota", MySqlDbType.VarChar).Value = Me.nota
            sqlcomando.Parameters.Add("@color", MySqlDbType.Int16).Value = Me.color
            eCapaDatos.cargarDatos(sqlcomando)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
