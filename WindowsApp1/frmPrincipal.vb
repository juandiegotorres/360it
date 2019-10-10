Public Class frmPrincipal

    Private Sub abrirForm(ByVal formulario As Form)
        Dim formHijo As Form = TryCast(formulario, Form)
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        If Me.pnlContenedor.Controls.Count = 1 Then
            Me.pnlContenedor.Controls.RemoveAt(0)
        End If
        Me.pnlContenedor.Controls.Add(formHijo)
        Me.pnlContenedor.Tag = formHijo
        formHijo.Show()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        panelCost.Height = btnClientes.Height
        panelCost.Top = btnClientes.Top
        abrirForm(frmClientes)
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        panelCost.Height = btnVentas.Height
        panelCost.Top = btnVentas.Top
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        panelCost.Height = btnVentas.Height
        panelCost.Top = btnVentas.Top
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        panelCost.Height = btnCuentas.Height
        panelCost.Top = btnCuentas.Top
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        panelCost.Height = btnStock.Height
        panelCost.Top = btnStock.Top
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        panelCost.Height = btnProveedores.Height
        panelCost.Top = btnProveedores.Top
        abrirForm(frmProveedores)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If MsgBox("¿Está seguro de que desea salir?", MsgBoxStyle.YesNo, "360 IT") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("www.infoandina.com")
    End Sub
End Class
