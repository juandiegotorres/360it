Imports MySql.Data.MySqlClient
Public Class Proveedor

#Region "DECLARACIÓN DE PROPIEDADES"

    Private _idProveedor As UInt16
    Public Property idProveedor As UInt16
        Set(value As UInt16)
            _idProveedor = value
        End Set
        Get
            Return _idProveedor
        End Get
    End Property
    Private _nombre As String
    Public Property nombre As String
        Set(value As String)
            _nombre = value
        End Set
        Get
            Return _nombre
        End Get
    End Property
    Private _telefono As String
    Public Property telefono As String
        Set(value As String)
            _telefono = value
        End Set
        Get
            Return _telefono
        End Get
    End Property
    Private _direccion As String
    Public Property direccion As String
        Set(value As String)
            _direccion = value
        End Set
        Get
            Return _direccion
        End Get
    End Property
    Private _cbu As String
    Public Property cbu As String
        Set(value As String)
            _cbu = value
        End Set
        Get
            Return _cbu
        End Get
    End Property
    Private _rubro As List(Of UInt16)
    Public Property rubro As List(Of UInt16)
        Set(value As List(Of UInt16))
            _rubro = value
        End Set
        Get
            Return _rubro
        End Get
    End Property
    Private _formPago As List(Of UInt16)
    Public Property formPago As List(Of UInt16)
        Set(value As List(Of UInt16))
            _formPago = value
        End Set
        Get
            Return _formPago
        End Get
    End Property
    Private _horario As String
    Public Property horario As String
        Set(value As String)
            _horario = value
        End Set
        Get
            Return _horario
        End Get
    End Property
#End Region
#Region "DECLARACIÓN DE MÉTODOS"
    Dim capaDatos As New CapaDeNegocios.cdDatosPrueba

    Public Sub recuperarRubro(ByVal tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM rubros WHERE activo = 1"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub recuperarFormPago(ByVal tabla As DataTable)
        Dim consultaSQL As String = "SELECT idformpago, nombFormaPago FROM formpago WHERE activo = 1 ORDER BY destacado DESC"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub nuevoProveedor()
        Try
            'Dim comando((Me._rubro.Count + 1) + (Me._formPago.Count + 1)) As MySqlCommand
            'Dim listaComandos As New List(Of MySqlCommand)
            Dim consultaSQL As String = "INSERT INTO proveedores(nombreProveedor, telefono, cbu, direccion, horario, activo) VALUES (@nombre,@telefono,@cbu,@direccion,@horario,'1')"
            Dim sqlComando As MySqlCommand = New MySqlCommand(consultaSQL)
            sqlComando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = Me.nombre
            sqlComando.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = Me.telefono
            sqlComando.Parameters.Add("@cbu", MySqlDbType.VarChar).Value = Me.cbu
            sqlComando.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = Me.direccion
            sqlComando.Parameters.Add("@horario", MySqlDbType.VarChar).Value = Me.horario
            capaDatos.cargarDatos(sqlComando)
            guardarCheckedListBox()
        Catch ex As Exception
            MsgBox(ex.Message, "Proveedores")

        End Try
    End Sub

    Private Sub guardarCheckedListBox()
        Try
            Dim consultaSQL
            For i = 0 To Me.rubro.Count - 1
                consultaSQL = "INSERT INTO rubroxproveedor(rubro,numproveedor) VALUES (@rubro, (Select max(idproveedor) from proveedores))"
                Dim comandoSQL As MySqlCommand = New MySqlCommand(consultaSQL)
                comandoSQL.Parameters.Add("@rubro", MySqlDbType.Int16).Value = Me.rubro.Item(i)
                capaDatos.cargarDatos(comandoSQL)
            Next
            For i = 0 To Me.formPago.Count - 1
                consultaSQL = "INSERT INTO pagoxproveedor(pago,proveedor) VALUES (@pago, (Select max(idproveedor) from proveedores))"
                Dim comandoSQL As MySqlCommand = New MySqlCommand(consultaSQL)
                comandoSQL.Parameters.Add("@pago", MySqlDbType.Int16).Value = Me.formPago.Item(i)
                capaDatos.cargarDatos(comandoSQL)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub recuperarProveedores(ByVal tabla As DataTable)
        Dim consultaSQL As String = "SELECT * FROM vistaproveedores"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub verPagosProveedor(ByVal tabla As DataTable)
        Dim consultaSQL As String = "SELECT nombFormaPago FROM proveedores, formpago, pagoxproveedor WHERE proveedores.idproveedor = pagoxproveedor.proveedor and pagoxproveedor.pago = formpago.idformpago and idproveedor ='" & _idProveedor & "'"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub verRubrosProveedor(ByVal tabla As DataTable)
        Dim consultaSQL As String = "SELECT nombRubro FROM proveedores, rubroxproveedor, rubros WHERE proveedores.idproveedor = rubroxproveedor.numproveedor and rubroxproveedor.rubro = rubros.idrubro and idproveedor = '" & _idProveedor & "'"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub verFormPagoProveedor(ByVal tabla As DataTable)
        Dim consultaSQL As String = "SELECT nombFormaPago FROM proveedores, pagoxproveedor, formpago WHERE proveedores.idproveedor = pagoxproveedor.proveedor and pagoxproveedor.pago = formpago.idformpago and idproveedor ='" & _idProveedor & "'"
        capaDatos.llenarDatos(tabla, consultaSQL)
    End Sub
    Public Sub modificarProveedor()
        Try
            Dim consultaSQL As String = "SELECT * FROM vistaproveedores WHERE idProveedor ='" & _idProveedor & "'"
            Dim tabla As New DataTable
            capaDatos.llenarDatos(tabla, consultaSQL)
            If tabla.Rows.Count = 1 Then
                _idProveedor = tabla.Rows(0).Item("idproveedor").ToString
                _nombre = tabla.Rows(0).Item("nombreProveedor").ToString
                _telefono = tabla.Rows(0).Item("telefono").ToString
                _cbu = tabla.Rows(0).Item("cbu").ToString
                _direccion = tabla.Rows(0).Item("direccion").ToString
                _horario = tabla.Rows(0).Item("horario").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Proveedor")
        End Try
    End Sub

    Public Sub actualizarPagosYRubros()
        Dim consultaSQL As String = "DELETE FROM pagoxproveedor WHERE proveedor = @idProveedor"
        Dim comandoSQL As MySqlCommand = New MySqlCommand(consultaSQL)
        comandoSQL.Parameters.Add("@idProveedor", MySqlDbType.VarChar).Value = Me.idProveedor
        capaDatos.cargarDatos(comandoSQL)
        consultaSQL = "DELETE FROM rubroxproveedor WHERE numproveedor = @idProveedor"
        comandoSQL.CommandText = consultaSQL
        capaDatos.cargarDatos(comandoSQL)
        Try
            For i = 0 To Me.rubro.Count - 1
                consultaSQL = "INSERT INTO rubroxproveedor(rubro,numproveedor) VALUES (@rubro, @idProveedor)"
                comandoSQL.CommandText = consultaSQL
                If i = 0 Then
                    comandoSQL.Parameters.Add("@rubro", MySqlDbType.Int16).Value = Me.rubro.Item(i)
                Else
                    comandoSQL.Parameters("@rubro").Value = Me.rubro.Item(i)
                End If
                capaDatos.cargarDatos(comandoSQL)
            Next
            For i = 0 To Me.formPago.Count - 1
                consultaSQL = "INSERT INTO pagoxproveedor(pago,proveedor) VALUES (@pago, @idProveedor)"
                comandoSQL.CommandText = consultaSQL
                If i = 0 Then
                    comandoSQL.Parameters.Add("@pago", MySqlDbType.Int16).Value = Me.formPago.Item(i)
                Else
                    comandoSQL.Parameters("@pago").Value = Me.formPago.Item(i)
                End If
                capaDatos.cargarDatos(comandoSQL)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub guardarProveedorModif()
        Try
            'No tengo nada para comentar en esta parte porque ni yo se como hice
            'para que funcionara
            Dim consultaSQL As String = "UPDATE proveedores SET nombreProveedor = @nombre, telefono = @telefono, cbu= @cbu, direccion = @direccion, horario = @horario WHERE idproveedor = @idproveedor"
            Dim comandoSQL As MySqlCommand = New MySqlCommand(consultaSQL)
            comandoSQL.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = Me.nombre
            comandoSQL.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = Me.telefono
            comandoSQL.Parameters.Add("@cbu", MySqlDbType.VarChar).Value = Me.cbu
            comandoSQL.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = Me.direccion
            comandoSQL.Parameters.Add("@horario", MySqlDbType.VarChar).Value = Me.horario
            comandoSQL.Parameters.Add("@idproveedor", MySqlDbType.Int64).Value = Me.idProveedor
            capaDatos.cargarDatos(comandoSQL)
            actualizarPagosYRubros()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub bajaProveedor()
        Try
            Dim consultaSQL As String = "UPDATE proveedores SET activo = 0 WHERE idproveedor = '" & _idProveedor & "'"
            capaDatos.cargarDatos(consultaSQL)
        Catch ex As Exception
            MsgBox(ex.Message, "Entidad Proveedor")
        End Try
    End Sub
#End Region
End Class
