Public Class frmModal
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnNO_Click(sender As Object, e As EventArgs) Handles btnNO.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmModal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Me.DialogResult = DialogResult.OK
            Case Keys.Escape
                Me.DialogResult = DialogResult.Cancel

        End Select
    End Sub

    Private Sub frmModal_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub
End Class