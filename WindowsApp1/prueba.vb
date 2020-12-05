Public Class prueba
    Private Sub prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        TableLayoutPanel1.SetRow(Panel1, 1)
        TableLayoutPanel1.SetColumn(Panel1, 0)
    End Sub

    Private Sub Panel1_LostFocus(sender As Object, e As EventArgs)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class