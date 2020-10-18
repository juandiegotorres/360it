Public Class frmEntrega
    Public eCtaCorriente As New Entidades.CuentaCorriente
    Dim index As Integer
    Private Sub frmEntrega_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Public Function aceptar()
        If LTrim(txtEntrega.Text) = "" Or LTrim(txtEntrega.Text) = "0" Then
            Return False
        Else
            eCtaCorriente.entrega = CDbl(txtEntrega.Text)
            eCtaCorriente.idVenta = cbVenta.SelectedValue
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

    Private Sub frmEntrega_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tablaVentasCliente As New DataTable
        eCtaCorriente.cargarVentasCliente(tablaVentasCliente)
        cbVenta.DataSource = tablaVentasCliente
        cbVenta.ValueMember = "venta"
        cbVenta.DisplayMember = "venta"
        Dim i As String
        i = eCtaCorriente.idVenta.ToString
        index = cbVenta.FindString(i)
        If index >= 0 Then
            cbVenta.SelectedIndex = index
        End If

    End Sub

    Private Sub frmEntrega_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If btnAceptar.Enabled = True Then
                    aceptar()
                End If
            Case Keys.Escape
                Me.DialogResult = DialogResult.Cancel
        End Select
    End Sub
End Class