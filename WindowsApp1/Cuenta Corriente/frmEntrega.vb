Public Class frmEntrega
    Public eCtaCorriente As New Entidades.CuentaCorriente
    Private Sub frmEntrega_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub
    Private Sub txtEntrega_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEntrega.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                aceptar()
            Case Keys.Escape
                Me.DialogResult = DialogResult.Cancel
        End Select
    End Sub
    Public Function aceptar()
        If LTrim(txtEntrega.Text) = "" Then
            Return False
        Else
            eCtaCorriente.entrega = CDbl(txtEntrega.Text)
            Me.DialogResult = DialogResult.OK
            Return True
        End If
    End Function

    Private Sub txtEntrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEntrega.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEntrega_TextChanged(sender As Object, e As EventArgs) Handles txtEntrega.TextChanged
        If LTrim(txtEntrega.Text) = "" Then
            btnAceptar.Enabled = False
        Else
            btnAceptar.Enabled = True
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        aceptar()
    End Sub
End Class