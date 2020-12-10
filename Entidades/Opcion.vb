Imports MySql.Data.MySqlClient
Public Class Opcion
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba
#Region "Opciones Generales"
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
#Region "Categorias"
    Private _idCategoria As UInt16
    Public Property idCategoria As UInt16
        Set(value As UInt16)
            _idCategoria = value
        End Set
        Get
            Return _idCategoria
        End Get
    End Property
    Private _nombreCategoria As String
    Public Property nombreCategoria As String
        Set(value As String)
            _nombreCategoria = value
        End Set
        Get
            Return _nombreCategoria
        End Get
    End Property
    Public Sub traerCategorias(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "Select * from categorias"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Function darDeBajaCategoria()
        Try
            Dim consultaSQL As String = "UPDATE categorias SET activo = 0 WHERE idcategoria = '" & _idCategoria & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function darDeAltaCategoria()
        Try
            Dim consultaSQL As String = "UPDATE categorias SET activo = 1 WHERE idcategoria = '" & _idCategoria & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function destacarCategoria()
        Try
            'Primero saco el que estaba destacado antes 
            Dim consultaSQL As String = "UPDATE categorias SET destacado = 0 WHERE destacado = '1'"
            capaDatos.cargarDatos(consultaSQL)
            consultaSQL = "UPDATE categorias SET destacado = 1 WHERE idcategoria = '" & _idCategoria & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Sub traerNombreCategoria()
        Try
            Dim tabla As New DataTable
            Dim consultaSQL As String = "SELECT nombCategoria FROM categorias WHERE idcategoria = '" & _idCategoria & "'"
            capaDatos.llenarDatos(tabla, consultaSQL)
            _nombreCategoria = tabla.Rows(0).Item("nombCategoria").ToString
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub nombreEditadoCategoria()
        Try
            Dim consultaSQL As String = "UPDATE categorias SET nombCategoria = '" & _nombreCategoria & "' WHERE idcategoria = '" & _idCategoria & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub agregarCategoria()
        Try
            Dim consultaSQL As String = "INSERT INTO categorias(nombCategoria, destacado, activo) VALUES ('" & _nombreCategoria & "', '0', '1')"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
#End Region
#Region "Localidades"
    Private _idLocalidad As UInt32
    Public Property idlocalidad As UInt32
        Set(value As UInt32)
            _idLocalidad = value
        End Set
        Get
            Return _idLocalidad
        End Get
    End Property
    Private _idProvincia As UInt32
    Public Property idProvincia As UInt32
        Set(value As UInt32)
            _idProvincia = value
        End Set
        Get
            Return _idProvincia
        End Get
    End Property
    Private _nombreLocalidad As String
    Public Property nombreLocalidad As String
        Set(value As String)
            _nombreLocalidad = value
        End Set
        Get
            Return _nombreLocalidad
        End Get
    End Property
    Public Sub traerProvincias(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT * FROM provincias"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub traerLocalidades(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "SELECT localidades.idlocalidad, localidades.nombLocalidad, localidades.provincia, localidades.activo, provincias.nombProvincia FROM localidades JOIN provincias ON localidades.provincia = provincias.idprovincia"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function darDeBajaLocalidad()
        Try
            Dim consultaSQL As String = "UPDATE localidades SET activo = 0 WHERE idlocalidad = '" & _idLocalidad & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function darDeAltaLocalidad()
        Try
            Dim consultaSQL As String = "UPDATE localidades SET activo = 1 WHERE idlocalidad = '" & _idLocalidad & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function localidadEditada()
        Try
            Dim consultaSQL As String = "UPDATE localidades SET nombLocalidad = '" & _nombreLocalidad & "', provincia = '" & _idProvincia & "' WHERE idlocalidad = '" & _idLocalidad & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function agregarLocalidad()
        Try
            Dim consultaSQL As String = "INSERT INTO localidades(nombLocalidad, provincia, activo) VALUES ('" & _nombreLocalidad & "','" & _idProvincia & "','1')"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
#End Region
#Region "Rubros"
    Private _idRubro As UInt16
    Public Property idRubro As UInt16
        Set(value As UInt16)
            _idRubro = value
        End Set
        Get
            Return _idRubro
        End Get
    End Property
    Private _nombreRubro As String
    Public Property nombreRubro As String
        Set(value As String)
            _nombreRubro = value
        End Set
        Get
            Return _nombreRubro
        End Get
    End Property
    Public Sub traerRubros(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "Select * from rubros"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Function darDeBajaRubro()
        Try
            Dim consultaSQL As String = "UPDATE rubros SET activo = 0 WHERE idrubro = '" & _idRubro & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function darDeAltaRubro()
        Try
            Dim consultaSQL As String = "UPDATE rubros SET activo = 1 WHERE idrubro = '" & _idRubro & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function

    Public Sub nombreEditadoRubro()
        Try
            Dim consultaSQL As String = "UPDATE rubros SET nombRubro = '" & _nombreRubro & "' WHERE idrubro = '" & _idRubro & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub agregarRubro()
        Try
            Dim consultaSQL As String = "INSERT INTO rubros(nombRubro, activo) VALUES ('" & _nombreRubro & "','1')"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
#End Region
#Region "Tipos de Articulo"
    Private _idTipoArticulo As UInt16
    Public Property idTipoArticulo As UInt16
        Set(value As UInt16)
            _idTipoArticulo = value
        End Set
        Get
            Return _idTipoArticulo
        End Get
    End Property
    Private _nombreArticulo As String
    Public Property nombreArticulo As String
        Set(value As String)
            _nombreArticulo = value
        End Set
        Get
            Return _nombreArticulo
        End Get
    End Property
    Public Sub traerTipoArticulos(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "Select * from tipoarticulo"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Function darDeBajaTipoArticulo()
        Try
            Dim consultaSQL As String = "UPDATE tipoarticulo SET activo = 0 WHERE id = '" & _idTipoArticulo & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function darDeAltaTipoArticulo()
        Try
            Dim consultaSQL As String = "UPDATE tipoarticulo SET activo = 1 WHERE id = '" & _idTipoArticulo & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function

    Public Sub nombreEditadoTipoArticulo()
        Try
            Dim consultaSQL As String = "UPDATE tipoarticulo SET tipoArticulo = '" & _nombreArticulo & "' WHERE id = '" & _idTipoArticulo & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub agregarTipoArticulo()
        Try
            Dim consultaSQL As String = "INSERT INTO tipoarticulo(tipoArticulo, activo) VALUES ('" & _nombreArticulo & "','1')"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
#End Region
#Region "Estados"
    Private _idEstado As UInt16
    Public Property idEstado As UInt16
        Set(value As UInt16)
            _idEstado = value
        End Set
        Get
            Return _idEstado
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
    Public Sub traerEstados(ByRef tabla As DataTable)
        Try
            Dim consultaSQL As String = "Select * from estado"
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Function darDeBajaEstado()
        Try
            Dim consultaSQL As String = "UPDATE estado SET activo = 0 WHERE id = '" & _idEstado & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function darDeAltaEstado()
        Try
            Dim consultaSQL As String = "UPDATE estado SET activo = 1 WHERE id = '" & _idEstado & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function destacarEstado()
        Try
            'Primero saco el que estaba destacado antes 
            Dim consultaSQL As String = "UPDATE estado SET destacado = 0 WHERE destacado = '1'"
            capaDatos.cargarDatos(consultaSQL)
            consultaSQL = "UPDATE estado SET destacado = 1 WHERE id = '" & _idEstado & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function

    Public Sub nombreEditadoEstado()
        Try
            Dim consultaSQL As String = "UPDATE estado SET nombreEstado = '" & _nombreEstado & "' WHERE id = '" & _idEstado & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    Public Sub agregarEstado()
        Try
            Dim consultaSQL As String = "INSERT INTO estado(nombreEstado , destacado, activo) VALUES ('" & _nombreEstado & "', '0', '1')"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
#End Region
#End Region
#Region "Bajas"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tablaDB"></param>
    ''' Hace referencia a la tabla de donde se van a extraer los datos desde la base de datos ej. clientes, productos, etc
    ''' <param name="condiciones"></param>
    ''' Hace referencia a que voy a traer desde la tabla seleccionada. Ej. nombre, telefono, direccion, etc
    ''' <param name="tabla"></param>
    ''' La tabla donde se van  a llenar los datos para luego mostrarlos en el datagrid
    Public Sub traerDatosGeneral(ByVal tablaDB As String, ByVal condiciones As String, ByRef tabla As DataTable, ByRef Optional activo As Boolean = False)
        Try
            Dim consultaSQL As String
            If activo = True Then
                consultaSQL = "SELECT " & condiciones & " FROM " & tablaDB
            Else
                consultaSQL = "SELECT " & condiciones & " FROM " & tablaDB & " WHERE activo = 0"
            End If
            capaDatos.llenarDatos(tabla, consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tabla"></param>
    ''' Hace referencia a la tabla de donde se van a extraer los datos desde la base de datos ej. clientes, productos, etc
    ''' <param name="columna"></param>
    ''' Hace referencia al nombre de la clave principal
    ''' <param name="id"></param>
    ''' hace referencia al numero del id
    ''' <returns></returns>
    Public Function altaGeneralTodos(ByVal tabla As String, ByVal columna As String, ByVal listaIDs As List(Of UInt64))
        Try
            Dim consultaSQL As String
            For i = 0 To listaIDs.Count - 1
                consultaSQL = "UPDATE " & tabla & " SET activo = 1 WHERE " & columna & " = '" & listaIDs(i) & "'"
                capaDatos.cargarDatos(consultaSQL)
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    Public Function altaGeneral(ByVal tablaDB As String, ByVal columna As String, ByVal id As UInt64)
        Try
            Dim consultaSQL As String = "UPDATE " & tablaDB & " SET activo = 1 WHERE " & columna & " = '" & id & "'"
            capaDatos.cargarDatos(consultaSQL)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Configuraciones")
            Return False
        End Try
    End Function
    ''↑↑↑↑ Los parametros son los mismos para las dos funciones ↑↑↑↑↑
#End Region

End Class
