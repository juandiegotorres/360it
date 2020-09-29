Imports MySql.Data.MySqlClient

Public Class cdDatosPrueba
    Dim conexion As New MySqlConnection
    Dim adaptador As New MySqlDataAdapter
    Dim comando As New MySqlCommand

    Private Sub AbrirConexion()
        Try
            If Not conexion Is Nothing Then
                If conexion.State = ConnectionState.Closed Then
                    If conexion.ConnectionString = Nothing Then
                        conexion.ConnectionString = "server=localhost;user Id=root;password=basededatos1;database=db_360"
                    End If
                    conexion.Open()
                End If
            Else
                conexion = New MySqlConnection
                conexion.ConnectionString = "server=localhost;user Id=root;password=basededatos1;database=db_360"
                conexion.Open()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        End Try
    End Sub
    Public Sub cargarDatos(ByRef consultaSQL As String)
        Try
            comando.CommandText = consultaSQL
            comando.Connection = conexion
            AbrirConexion()
            comando.ExecuteNonQuery()
            CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message, "Clase cdDatosPrueba")
        End Try
    End Sub
    Public Sub cargarDatos(ByRef ComandoSQL As MySqlCommand)
        Try
            ComandoSQL.Connection = conexion
            adaptador.SelectCommand = ComandoSQL
            AbrirConexion()
            ComandoSQL.ExecuteNonQuery()
            CerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch ex As Exception
            MsgBox(ex.Message, "Clase cdDatosPrueba")
        End Try
    End Sub
    Public Function Guardar(ByRef ComandoTurno As List(Of MySqlCommand)) As Byte
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
    Public Sub llenarDatos(ByRef tabla As DataTable, ByRef consultaSQL As String)
        Try
            comando.CommandText = consultaSQL
            comando.Connection = conexion
            adaptador.SelectCommand = comando

            AbrirConexion()



            adaptador.Fill(tabla)
            CerrarConexion()
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
