Public Class frmNuevaNota
    Dim eNotas As New Entidades.Nota
    Dim idNota As UInt64
    Dim modificar As Boolean
    Dim tablaNota As New DataTable
    Dim rbColor As RadioButton
    Dim nombreColor As String
    Public Sub New(Optional ByRef _idNota As UInt64 = 0, Optional ByRef _modificar As Boolean = False)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idNota = _idNota
        modificar = _modificar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub frmNuevaNota_Load(sender As Object, e As EventArgs) Handles Me.Load
        If modificar = True Then
            eNotas.traerNotaModificar(tablaNota, idNota)
            If tablaNota.Rows.Count = 1 Then
                txtNota.Text = tablaNota.Rows(0).Item("nota").ToString
                lblFecha.Text = tablaNota.Rows(0).Item("fecha").ToString
                nombreColor = "color" & tablaNota.Rows(0).Item("color").ToString
                rbColor = GroupBox1.Controls.Item(nombreColor)
                rbColor.Checked = True
            End If
        ElseIf modificar = False Then
            lblFecha.Text = CDate(Today)
            txtNota.Select()
        End If
        lblCaracteres.Text = Len(txtNota.Text) & "/" & txtNota.MaxLength
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
            eNotas.fecha = Date.Now
            If modificar = False Then
                If eNotas.nuevaNota = True Then
                    MsgBox("Nota agregada", MsgBoxStyle.Information, "Notas")
                    Me.DialogResult = DialogResult.OK
                Else
                    MsgBox("Sucedió un problema, intente nuevamente", MsgBoxStyle.Critical, "Notas")
                End If
            ElseIf modificar = True Then
                eNotas.idNota = idNota
                If eNotas.guardarNotaModificada = True Then
                    MsgBox("Nota modificada", MsgBoxStyle.Information, "Notas")
                    Me.DialogResult = DialogResult.OK
                Else
                    MsgBox("Sucedió un problema, intente nuevamente", MsgBoxStyle.Critical, "Notas")
                End If
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

    Private Sub frmNuevaNota_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            Call btnGuardar_Click(btnGuardar, e)
        ElseIf e.KeyData = Keys.Escape Then
            Call btnCerrar_Click(btnCerrar, e)
        End If
    End Sub
End Class