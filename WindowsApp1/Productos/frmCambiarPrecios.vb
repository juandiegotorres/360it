Public Class frmCambiarPrecios
    Dim porcentajeCambio As Double
    Dim e_producto As New Entidades.Producto
    Public disminuir As Boolean

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
        porcentajeCambio = 0
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmCambiarPrecios_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
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
        ElseIf disminuir = True Then
            porcentajeCambio = (100 - CInt(txtPorcentaje.Text)) / 100
            e_producto.disminuirPrecio(porcentajeCambio)
        Else
            porcentajeCambio = (CInt(txtPorcentaje.Text) / 100) + 1
            e_producto.aumentarPrecio(porcentajeCambio)
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
End Class