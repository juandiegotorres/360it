Public Class frmCambiarPrecios
    Dim porcentajeCambio As Double
    Dim e_producto As New Entidades.Producto
    Public disminuir As Boolean
    Public idProd As UInt16
    Private Sub txtPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        'Este evento me permite solo introducir numeros y comas en el recargo. Y tambien solo se va a poder escribir si hay algun producto en el carro
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnAumentar_Click(sender As Object, e As EventArgs) Handles btnAumentar.Click
        aceptar()
    End Sub


    Private Sub frmCambiarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If disminuir = True Then
            lblAlerta.Text = "El precio de todos los productos disminuirá el porcentaje que introduzcas aquí ¡Cuidado!"
            btnAumentar.Visible = False
            btnDisminuir.Visible = True
        End If
        e_producto.idProducto = idProd
        porcentajeCambio = 0
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmCambiarPrecios_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        'ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub txtPorcentaje_TextChanged(sender As Object, e As EventArgs) Handles txtPorcentaje.TextChanged
        If LTrim(txtPorcentaje.Text) = "" Then
            btnAumentar.Enabled = False
            btnDisminuir.Enabled = False
        Else
            btnAumentar.Enabled = True
            btnDisminuir.Enabled = True
        End If
    End Sub
    Public Sub aceptar()
        If txtPorcentaje.Text = "0" Or LTrim(txtPorcentaje.Text) = "" Then
            MsgBox("Introduzca un porcentaje válido", MsgBoxStyle.Exclamation, "Precios")
            Exit Sub
        ElseIf disminuir = True Then
            porcentajeCambio = (100 - CInt(txtPorcentaje.Text)) / 100
            If chbTodosLosProductos.Checked = True Then
                'Si el checkbox para cambiar los precios de todos los productos esta seleccionado, le voy a mandar por parametros 'true' para que el programa sepa que debe cambiar todos los precios.
                e_producto.disminuirPrecio(porcentajeCambio, True)
            Else
                'de la otra forma si no esta marcado el checkbox mando false para modificar solo un producto
                e_producto.disminuirPrecio(porcentajeCambio, False)
            End If
        Else
            porcentajeCambio = (CInt(txtPorcentaje.Text) / 100) + 1
            If chbTodosLosProductos.Checked = True Then
                'Hago lo mismo que explique arriba
                e_producto.aumentarPrecio(porcentajeCambio, True)
            Else
                e_producto.aumentarPrecio(porcentajeCambio, False)
            End If
        End If
        MsgBox("Tarea Completada", MsgBoxStyle.Information, "Cambio de precios | Productos")
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub btnDisminuir_Click(sender As Object, e As EventArgs) Handles btnDisminuir.Click
        aceptar()
    End Sub

    Private Sub frmCambiarPrecios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If btnAumentar.Enabled = True Or btnDisminuir.Enabled = True Then
                    aceptar()
                End If
            Case Keys.Escape
                Me.DialogResult = DialogResult.Cancel
        End Select
    End Sub

    Private Sub chbTodosLosProductos_CheckedChanged(sender As Object, e As EventArgs) Handles chbTodosLosProductos.CheckedChanged
        If chbTodosLosProductos.Checked = True Then
            lblAlerta.Visible = True
        Else
            lblAlerta.Visible = False
        End If
    End Sub
End Class