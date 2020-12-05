Public Class frmNuevaNota
    Dim eNotas As New Entidades.Nota
    Private Sub frmNuevaNota_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblFecha.Text = CDate(Today)
        txtNota.Select()
        lblCaracteres.Text = Len(txtNota.Text) & "/" & txtNota.MaxLength
        'lblCaracteres.Text = "240/240"
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmNuevaNota_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNota.TextChanged
        lblCaracteres.Text = Len(txtNota.Text) & "/" & txtNota.MaxLength
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Trim(txtNota.Text) <> "" Then
            eNotas.nota = txtNota.Text
            eNotas.fecha = CDate(Today)
            If color1.Checked = True Then
                eNotas.color = 1
            End If
            If color2.Checked = True Then
                eNotas.color = 2
            End If
            If color3.Checked = True Then
                eNotas.color = 3
            End If
            If color4.Checked = True Then
                eNotas.color = 4
            End If
            If color5.Checked = True Then
                eNotas.color = 5
            End If
            If eNotas.nuevaNota = True Then
                MsgBox("Nota agregada", MsgBoxStyle.Information, "Notas")
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("Sucedió un problema, intente nuevamente", MsgBoxStyle.Critical, "Notas")
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        color1.Checked = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        color2.Checked = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        color3.Checked = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        color4.Checked = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        color5.Checked = True
    End Sub
End Class