Public Class frmEntrega
    Public eCtaCorriente As New Entidades.CuentaCorriente
    Dim index As Integer
    Dim restoDinero As Double
    Dim idVenta As UInt64
    Private Sub frmEntrega_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        '' ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub
    Public Sub New(ByRef _restoDinero As Double, ByRef _idVenta As UInt64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        restoDinero = _restoDinero
        idVenta = _idVenta
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Function aceptar()
        eCtaCorriente.calcularRestoVenta(cbVenta.SelectedValue)
        If LTrim(txtEntrega.Text) = "" Or LTrim(txtEntrega.Text) = "0" Then
            Return False
            'ElseIf cbVenta.Text = "" Then
            '    MsgBox("Debe elegir una venta", MsgBoxStyle.Exclamation, "Entrega de Dinero")
        ElseIf CDbl(txtEntrega.Text) > eCtaCorriente.resto Then
            MsgBox("Este monto es más de lo que el cliente debe, intente chequear la opcion 'Entregar resto faltante'", MsgBoxStyle.Exclamation, "Entrega de Dinero")
            Return True
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
    Public Sub cargarVentas()
        Dim tablaVentasCliente As New DataTable
        eCtaCorriente.filtrarVentasCliente(tablaVentasCliente)
        cbVenta.DataSource = tablaVentasCliente
        cbVenta.ValueMember = "venta"
        cbVenta.DisplayMember = "ventaFecha"
    End Sub
    Private Sub frmEntrega_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarVentas()
        If idVenta <> 0 Then
            cbVenta.SelectedValue = idVenta
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub chbResto_CheckedChanged(sender As Object, e As EventArgs) Handles chbResto.CheckedChanged
        If chbResto.Checked = True Then
            eCtaCorriente.calcularRestoVenta(cbVenta.SelectedValue)
            txtEntrega.Text = eCtaCorriente.resto
        Else
            txtEntrega.Text = ""
        End If
    End Sub

    Private Sub cbVenta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbVenta.SelectionChangeCommitted
        If chbResto.Checked = True Then
            Call chbResto_CheckedChanged(chbResto, e)
        End If
    End Sub
End Class