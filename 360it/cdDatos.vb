Imports MySql.Data.MySqlClient
Public Class cdDatos
#Region "Declaracion de Métodos"
    Private Sub AbrirConexion()
        'Iniciamos un bloque Try...Catch...End Try para que en caso de que ocurra
        'una Excepción podamos capturarla y mostrar el mensaje de error.
        Try
            'Primero consultamos el objeto cnMySql no es igual a nada, 
            'es decir si esta instanciado; de estar instanciado continuamos
            'con la ejecución del siguiente If...Then...End.
            If Not cnMySql Is Nothing Then
                'Ahora preguntamos si el estado de la conexión es cerrada, si esta esta cerrada
                'establecemos la cadena de conexión a la base de datos y luego la abrimos.
                If cnMySql.State = ConnectionState.Closed Then
                    If cnMySql.ConnectionString = Nothing Then
                        'Verifico si connection string tiene alguna cadena y si no tiene nada le asigno una
                        cnMySql.ConnectionString = "server=localhost;user Id=root;password=basededatos1;database=db_salon"
                    End If
                    cnMySql.Open()
                End If
                'Si el objeto no estaba instanciado, lo instanciamos, luego establecemos la cadena de conexión
                'y finalmente abrimos la misma.
            Else
                cnMySql = New MySqlConnection
                cnMySql.ConnectionString = "server=localhost;user Id=root;password=basededatos1;database=db_salon"
                cnMySql.Open()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        End Try
    End Sub

    Private Sub CerrarConexion()
        Try
            'Pregunto si esta creado el objeto cnMySql y si esta creado cierro la conexion, de lo contrario no hace nada
            If Not cnMySql Is Nothing Then
                If cnMySql.State = ConnectionState.Open Then
                    cnMySql.Close()
                End If
            End If
        Catch _error As MySqlException
            MsgBox(_error.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        End Try
    End Sub
    ''' <summary>
    ''' Llena un DataTable con datos traidos desde la base de datos por medio de una consulta 
    ''' </summary>
    ''' <param name="Tabla">DataTable que se llenará con datos (Por referencia)</param>
    ''' <param name="cmComandoSql">Sentencia SQL que se ejecuta en la base de datos (Select)</param>
    ''' <returns>Devuelve "Verdadero" si el DataTable pudo ser llenado con datos</returns>
    Public Function CargarDatos(ByRef Tabla As DataTable, ByRef cmComandoSql As MySqlCommand) As Boolean 'sub por function
        Try
            'Asignamos el texto del comando al Objeto MySqlCommand
            'cmComandoSql.CommandText = Comando
            'cmComandoSql.Parameters.Add(parametros.Item(0), MySqlDbType.String)
            'cmComandoSql.Parameters("@nombre").Value = parametros.nombre
            ''parametros._nombre)
            ''cmComandoSql.Parameters.Add("@descripcion", MySqlDbType.String)
            ''parametros._descripcion)
            ''cmComandoSql.Parameters.Add("@precio", MySqlDbType.Decimal)
            ''parametros._precio)
            ''cmComandoSql.Parameters.Add("@cantidad", MySqlDbType.Int16)
            ''parametros.cantidad)
            'cmComandoSql.Parameters.AddWithValue("@nombre", parametros.nombre)
            'cmComandoSql.Parameters.AddWithValue("@descripcion", parametros.descripcion)
            'cmComandoSql.Parameters.AddWithValue("@precio", parametros.precio)
            'cmComandoSql.Parameters.AddWithValue("@cantidad", parametros.cantidad)
            ' cmComandoSql.Parameters.AddWithValue()

            'Asignamos la conexión al Objetos MySqlCommand
            cmComandoSql.Connection = cnMySql
            'Asignamos el comando al Objeto MySqlDataAdapter
            daDatos.SelectCommand = cmComandoSql
            AbrirConexion()
            'Llenamos la el DataTable con los datos obtenidos de la Base de Datos
            daDatos.Fill(Tabla)
            CerrarConexion()
            'Pregunto si las filas de la tabla es mayor que 0 y devuelvo vedadero si hay datos y sino retorna falso
            If Tabla.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
            Return False
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
            Return False
        End Try
    End Function
    Public Function CargarDatos(ByRef Tabla As DataTable, ByVal Comando As String) As Boolean 'sub por function
        Try
            'Asignamos el texto del comando al Objeto MySqlCommand
            cmComandoSql.CommandText = Comando
            'cmComandoSql.Parameters.Add("@nombre", MySqlDbType.String)
            ''parametros._nombre)
            'cmComandoSql.Parameters.Add("@descripcion", MySqlDbType.String)
            ''parametros._descripcion)
            'cmComandoSql.Parameters.Add("@precio", MySqlDbType.Decimal)
            ''parametros._precio)
            'cmComandoSql.Parameters.Add("@cantidad", MySqlDbType.Int16)
            ''parametros.cantidad)
            'cmComandoSql.Parameters.AddWithValue("@nombre", parametros._nombre)
            'cmComandoSql.Parameters.AddWithValue("@descripcion", parametros._descripcion)
            'cmComandoSql.Parameters.AddWithValue("@precio", parametros._precio)
            'cmComandoSql.Parameters.AddWithValue("@cantidad", parametros._cantidad)
            '' cmComandoSql.Parameters.AddWithValue()

            'Asignamos la conexión al Objetos MySqlCommand
            cmComandoSql.Connection = cnMySql
            'Asignamos el comando al Objeto MySqlDataAdapter
            daDatos.SelectCommand = cmComandoSql
            AbrirConexion()
            'Llenamos la el DataTable con los datos obtenidos de la Base de Datos
            daDatos.Fill(Tabla)
            CerrarConexion()
            'Pregunto si las filas de la tabla es mayor que 0 y devuelvo vedadero si hay datos y sino retorna falso
            If Tabla.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
            Return False
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
            Return False
        End Try
    End Function
    Public Function Guardar(ByVal InsertCommand As String) As Byte
        'Declaramo una variable del tipo entero corto para almacenar la cantidad de filas insertadas.
        Dim RowInsert As Byte
        Try
            'Asignamos el texto del comando al objetoMySqlCommand
            cmComandoSql.CommandText = InsertCommand
            'Asignamos la conexión al objetoMySqlCommand
            cmComandoSql.Connection = cnMySql

            AbrirConexion()
            RowInsert = cmComandoSql.ExecuteNonQuery()
            CerrarConexion()

        Catch ErrorMySql As MySqlException
            MsgBox(ErrorMySql.Message, MsgBoxStyle.Critical, "Clase cdDatos")
            RowInsert = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
            RowInsert = 0
        End Try

        Return RowInsert
    End Function
    Public Function Eliminar(ByVal DeleteCommand As String) As Byte
        Dim RowInserted As Byte
        'Asigno el comando
        cmComandoSql.CommandText = DeleteCommand
        'Asigno la conección
        cmComandoSql.Connection = cnMySql
        Try
            AbrirConexion()
            'ExeciteNonQuery devuelve la cantida de filas insertadas en la base de datos
            RowInserted = cmComandoSql.ExecuteNonQuery()
            CerrarConexion()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, "Clase cdDatos")
        End Try
        Return RowInserted
        Return 0
    End Function
    Public Function Guardar(ByRef ComandoTurno As List(Of MySqlCommand)) As Byte
        Dim Transaccion As MySqlTransaction
        Dim comando As MySqlCommand = cnMySql.CreateCommand
        Dim RegistrosInsertados As Byte
        Using cnMySql
            AbrirConexion()
            Transaccion = cnMySql.BeginTransaction()
            Try
                For i = 0 To ComandoTurno.Count - 1
                    With ComandoTurno.Item(i)
                        .Connection = cnMySql
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
#End Region
#Region "Declaracon de Variables Globales"
    'MySqlConnection es una clase que se utiliza para establecer una conexión con 
    'un origen de datos del tipo MySql.
    Private cnMySql As New MySqlConnection
    'MySqlCommand es una clase que representa un comando de base de datos, como una
    'instrucción SELECT, UPDATE, INSERT, DELET, etc.
    Private cmComandoSql As New MySqlCommand
    'MySqlDataAdapter es una clase que se utiliza para sincronizar los regstros de
    'un origen de datos con un DataTable o Dataset.
    Private daDatos As New MySqlDataAdapter
#End Region
End Class
