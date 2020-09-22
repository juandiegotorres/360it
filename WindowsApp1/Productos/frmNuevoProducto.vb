Public Class frmNuevoProducto
    Dim precioCosto As Double
    Dim precioVenta As Double
    Dim porcentaje As Integer
    Dim eProducto As New Entidades.Producto
    Private _modificar As Boolean
    Public Property modificar As Boolean
        Set(value As Boolean)
            _modificar = value
        End Set
        Get
            Return _modificar
        End Get
    End Property

    Private Sub frmNuevoProducto_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarCategorias()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmPrincipal.Show()
    End Sub

    Public Sub cargarCategorias()
        Dim dtCategorias As New DataTable
        eProducto.categorias(dtCategorias)
        With cbCategorias
            .DataSource = dtCategorias
            .DisplayMember = "nombCategoria"
            .ValueMember = "idcategoria"
        End With
    End Sub

    Private Sub ChbPorcentaje_CheckedChanged(sender As Object, e As EventArgs) Handles chbPorcentaje.CheckedChanged
        If chbPorcentaje.Checked = True Then
            txtPorcentaje.ReadOnly = False
            txtPrecioVenta.ReadOnly = True
        ElseIf chbPorcentaje.Checked = False Then
            txtPorcentaje.ReadOnly = True
            txtPorcentaje.Text = ""
            txtPrecioVenta.ReadOnly = False
            txtPrecioVenta.Text = ""
        End If

    End Sub

    Public Function comprobarDatos()
        Dim _control As Control
        For Each _control In Me.Controls
            If TypeOf _control Is TextBox Then
                If _control Is txtDescripcion Then
                Else
                    If _control.Text = "" Then
                        MsgBox("Faltan completar datos", MsgBoxStyle.Exclamation, "Productos")
                        Return False
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Public Sub limpiarCampos()
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
    End Sub

    Private Sub TxtPrecioCosto_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioCosto.TextChanged
        calcularPrecio()
    End Sub

    Private Sub TxtPorcentaje_TextChanged(sender As Object, e As EventArgs) Handles txtPorcentaje.TextChanged
        calcularPrecio()
    End Sub
    Public Sub calcularPrecio()
        If chbPorcentaje.Checked = True Then
            If Not txtPrecioCosto.Text = "" Then
                precioCosto = txtPrecioCosto.Text
            End If
            If Not txtPorcentaje.Text = "" Then
                porcentaje = txtPorcentaje.Text
                precioVenta = (((precioCosto * porcentaje) / 100) + precioCosto)
                txtPrecioVenta.Text = precioVenta
            End If
        End If
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Dim proveedores As New frmProveedores
        Me.Hide()
        With proveedores
            .producto = True
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                eProducto.idProveedor = proveedores.eProveedor.idProveedor
                eProducto.nombProveedor = proveedores.eProveedor.nombre
                txtProveedor.Text = eProducto.nombProveedor
                Me.Show()
            End If
        End With

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobarDatos() Then
            eProducto.tipoProducto = txtTipo.Text
            eProducto.marca = txtMarca.Text
            eProducto.modelo = txtModelo.Text
            eProducto.categoria = cbCategorias.SelectedValue
            eProducto.cantidad = txtCantidad.Text
            eProducto.precioCosto = txtPrecioCosto.Text
            eProducto.precioVenta = txtPrecioVenta.Text
            eProducto.descripcion = txtDescripcion.Text
            If _modificar = False Then
                eProducto.nuevoProducto()
                MsgBox("Producto guardado con éxito", MsgBoxStyle.Information, "Nuevo Producto")
                Me.DialogResult = DialogResult.OK
            Else

            End If
        End If
    End Sub
#Region "KEYPRESS"
    Private Sub txtCantidad_Click(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPorcentaje_Click(sender As Object, e As KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPrecioCosto_Click(sender As Object, e As KeyPressEventArgs) Handles txtPrecioCosto.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPrecioVenta_Click(sender As Object, e As KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmPrincipal.Show()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
    End Sub


#End Region
End Class