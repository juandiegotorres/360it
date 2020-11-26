Public Class prueba
    Private Sub prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Focus()
    End Sub

    Private Sub Panel1_LostFocus(sender As Object, e As EventArgs) Handles Panel1.LostFocus
        MsgBox("Hola", MsgBoxStyle.YesNo)
    End Sub
End Class