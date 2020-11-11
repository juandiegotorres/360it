Public Class frmVentaRealizada
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmVentaRealizada_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Me.Close()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub frmVentaRealizada_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub
End Class