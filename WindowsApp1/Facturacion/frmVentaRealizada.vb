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
End Class