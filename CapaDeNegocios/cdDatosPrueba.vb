Imports MySql.Data.MySqlClient

Public Class cdDatosPrueba
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim comando As New MySqlCommand
    Dim stringConexion As String
    Public Function AbrirConexion()
        Try
            If Not conexion Is Nothing Then
                If conexion.State = ConnectionState.Closed Then
                    If conexion.ConnectionString = Nothing Then
                        stringConexion = "server=" & My.Settings.server & ";user Id=" & My.Settings.usuario & ";password=" & My.Settings.passwordDB & ";database=" & My.Settings.database & ""
                        conexion.ConnectionString = stringConexion
                    End If
                    conexion.Open()
                End If
            Else
                'server=localhost;user Id=root;password=basededatos1;database=db_360
                conexion = New MySqlConnection
                conexion.ConnectionString = "server=192.168.0.120;user Id=usuario;password=basededatos1;database=db_360"
                conexion.Open()
            End If
            Return True
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Base de Datos")
            MsgBox("Sucedió un error y no se pudo conectar a la base de datos", MsgBoxStyle.Critical, "Base de Datos")
            Return False
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Base de Datos")
            Return False
        End Try
    End Function
    Public Sub cargarDatos(ByRef consultaSQL As String)
        Try
            comando.CommandText = consultaSQL
            comando.Connection = conexion
            If AbrirConexion() = True Then
                comando.ExecuteNonQuery()
                CerrarConexion()
            Else
                MsgBox("No se pudo conectar con la base de datos", MsgBoxStyle.Critical, "360it")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, "Clase cdDatosPrueba")
        End Try
    End Sub
    Public Sub cargarDatos(ByRef ComandoSQL As MySqlCommand)
        Try
            ComandoSQL.Connection = conexion
            adaptador.SelectCommand = ComandoSQL
            If AbrirConexion() = True Then
                ComandoSQL.ExecuteNonQuery()
                CerrarConexion()
            Else
                MsgBox("No se pudo conectar con la base de datos", MsgBoxStyle.Critical, "360it")
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch ex As Exception
            MsgBox(ex.Message, "Clase cdDatosPrueba")
        End Try
    End Sub
    Public Function GuardarComando(ByRef ComandoVenta As MySqlCommand) As Boolean
        Dim Transaccion As MySqlTransaction
        Dim comando As MySqlCommand = conexion.CreateCommand
        Using conexion
            AbrirConexion()
            Transaccion = conexion.BeginTransaction()
            Try
                ComandoVenta.Connection = conexion
                ComandoVenta.Transaction = Transaccion
                ComandoVenta.ExecuteNonQuery()
                Transaccion.Commit()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Try
                    Transaccion.Rollback()
                Catch ex2 As MySqlException
                    MsgBox("Error: " & ex2.Message)
                End Try
                Return False
            Finally
                CerrarConexion()
            End Try
        End Using
    End Function
    Public Function GuardarListaComandos(ByRef ComandoTurno As List(Of MySqlCommand)) As Byte
        Dim Transaccion As MySqlTransaction
        Dim comando As MySqlCommand = conexion.CreateCommand
        Dim RegistrosInsertados As Byte
        Using conexion
            AbrirConexion()
            Transaccion = conexion.BeginTransaction()
            Try
                For i = 0 To ComandoTurno.Count - 1
                    With ComandoTurno.Item(i)
                        .Connection = conexion
                        .Transaction = Transaccion
                        RegistrosInsertados += .ExecuteNonQuery()
                    End With
                Next
                Transaccion.Commit()
                Return RegistrosInsertados
            Catch ex As Exception
                MsgBox(ex.Message)
                Try
                    Transaccion.Rollback()
                Catch ex2 As MySqlException
                    MsgBox("Error: " & ex2.Message)
                End Try
                Return 0
            Finally
                CerrarConexion()
            End Try
        End Using

    End Function
    Public Sub lllenarDatos(ByRef tbCliente As List(Of Clientes), ByRef consultaSQL As String)
        Try
            comando.CommandText = consultaSQL
            comando.Connection = conexion
            adaptador.SelectCommand = comando

            AbrirConexion()

            Using datos As MySqlDataReader = comando.ExecuteReader()

                While datos.Read
                    Dim cliente As New Clientes
                    With cliente
                        .idCliente = datos.GetUInt32("idCliente")
                        .nombApel = datos.GetString("nombreApel")

                    End With
                    tbCliente.Add(cliente)

                End While
            End Using
            'While comando.reader()

            'End While

            ' adaptador.Fill(tabla)
            CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, "Clase cdDatosPrueba")
        End Try
    End Sub
    Public Function CargarDatos(ByRef Tabla As DataTable, ByRef cmComandoSql As MySqlCommand) As Boolean 'sub por function
        Try

            'Asignamos la conexión al Objetos MySqlCommand
            cmComandoSql.Connection = conexion
            'Asignamos el comando al Objeto MySqlDataAdapter
            adaptador.SelectCommand = cmComandoSql
            If AbrirConexion() = True Then
                'Llenamos la el DataTable con los datos obtenidos de la Base de Datos
                adaptador.Fill(Tabla)
                CerrarConexion()
                'Pregunto si las filas de la tabla es mayor que 0 y devuelvo vedadero si hay datos y sino retorna falso
                If Tabla.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                MsgBox("No se pudo conectar con la base de datos", MsgBoxStyle.Critical, "360it")
            End If
            Return True
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
            Return False
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
            Return False
        End Try
    End Function
    Public Sub actualizarCredenciales(ByRef _server As String, ByRef _usuario As String, ByRef _passwordDB As String, ByRef _passwordEdit As String)
        My.Settings.server = _server
        My.Settings.usuario = _usuario
        My.Settings.passwordDB = _passwordDB
        My.Settings.Save()
        My.Settings.Reload()

    End Sub
    Public Sub cargarCredenciales(ByRef _server As String, ByRef _usuario As String, ByRef _passwordDB As String, ByRef _database As String)
        _server = My.Settings.server
        _usuario = My.Settings.usuario
        _passwordDB = My.Settings.passwordDB
        _database = My.Settings.database
    End Sub
    Public Function comprobarPwdEditar(ByRef _passwordEditar As String)
        If _passwordEditar = My.Settings.passwordEdit Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub llenarDatos(ByRef tabla As DataTable, ByRef consultaSQL As String)
        Try
            comando.CommandText = consultaSQL
            comando.Connection = conexion
            adaptador.SelectCommand = comando
            If AbrirConexion() = True Then
                adaptador.Fill(tabla)
                CerrarConexion()
            Else
                MsgBox("No se pudo conectar con la base de datos", MsgBoxStyle.Critical, "360it")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, "Clase cdDatosPrueba")
        End Try
    End Sub
    Private Sub CerrarConexion()
        Try
            If Not conexion Is Nothing Then
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
            End If
        Catch _error As MySqlException
            MsgBox(_error.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        End Try
    End Sub
End Class
