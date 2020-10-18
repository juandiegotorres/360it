
Public Class frmCantidad
    Dim cantidadProductos As UInt16
    Public cantidadSeleccionada As UInt16
    ''' <summary>
    ''' Paso el parametro de la cantidad de un producto que hay en stock hacia el formulario cantida, para poder establecer una validacion a la hora de que el usuario introduzca la cantidad que desea vender. Si es mas de la que hay en stock va a salir un mensaje de error
    ''' </summary>
    ''' <param name="cantidadProducto">Cantidad de productos en stock</param>
    Public Sub New(ByVal cantidadProducto As UInt16)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.cantidadProductos = cantidadProducto
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    'Al cargar el formulario muestro un mensaje al usuario de cuanta cantidad de un producto le queda, para recordarle
    Private Sub frmCantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cantidadProductos = 1 Then
            lblDisponibilidad.Text = "Solo queda " & cantidadProductos & " producto en stock"
            txtCantidad.Text = "1"
        ElseIf cantidadProductos = 0 Then
            lblDisponibilidad.Text = "No hay mas stock de este producto"
            lblDisponibilidad.ForeColor = Color.Red
            txtCantidad.Enabled = False
        Else
            lblDisponibilidad.Text = "Quedan " & cantidadProductos & " productos en stock"
            txtCantidad.Text = "1"
        End If
    End Sub
    'Accion al cerrar el formulario
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    'Como el formulario se muestra sobre el formulario padre y ambos tienen el mismo color de fondo dibujo un borde para diferenciarlo
    Private Sub frmCantidad_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        aceptar()
    End Sub
    ''' <summary>
    '''Puse esta porcion de codigo en un procedimiento ya que quiero que se ejecute lo mismo al realizar dos acciones. Al presionar enter se ejecutaria esto, y al darle al boton agregar con el mouse
    ''' </summary>
    Public Function aceptar()
        If LTrim(txtCantidad.Text) = "" Then
            Return False
        Else
            cantidadSeleccionada = txtCantidad.Text
            If cantidadSeleccionada > cantidadProductos Then
                lblError.Visible = True
                lblError.Text = "No dispones de esa cantidad de unidades"
                txtCantidad.Text = ""
                txtCantidad.Select()
            ElseIf cantidadSeleccionada = 0 Then
                lblError.Visible = True
                lblError.Text = "Debe seleccionar al menos una unidad"
            Else
                cantidadSeleccionada = txtCantidad.Text
                Me.DialogResult = DialogResult.OK
            End If
            Return True
        End If
    End Function



    'Dejo introducir solo numeros
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If LTrim(txtCantidad.Text) = "" Then
            btnAgregar.Enabled = False
        Else
            btnAgregar.Enabled = True
        End If
    End Sub
    'Establezco la accion al presionar la tecla enter y escape con el evento keydown
    Private Sub frmCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If txtCantidad.Enabled = True Then
                    aceptar()
                End If
            Case Keys.Escape
                Me.DialogResult = DialogResult.Cancel
        End Select
    End Sub
End Class