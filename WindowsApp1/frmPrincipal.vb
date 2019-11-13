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



    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'panelCost.Height = btnVentas.Height
        'panelCost.Top = btnVentas.Top

    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        panelCost.Height = btnClientes.Height
        panelCost.Top = btnClientes.Top
        abrirForm(frmClientes)
    End Sub
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        panelCost.Visible = True
        panelCost.Height = btnVentas.Height
        panelCost.Top = btnVentas.Top
        abrirForm(frmVentas)
    End Sub


    Private Sub btnCuentas_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        panelCost.Visible = True
        panelCost.Height = btnCuentas.Height
        panelCost.Top = btnCuentas.Top
        abrirForm(frmCuentas)
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        panelCost.Visible = True
        panelCost.Height = btnStock.Height
        panelCost.Top = btnStock.Top
        abrirForm(frmProductos)
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        panelCost.Visible = True
        panelCost.Height = btnProveedores.Height
        panelCost.Top = btnProveedores.Top
        abrirForm(frmProveedores)
    End Sub

    Private Sub picCerrar_Click(sender As Object, e As EventArgs) Handles picCerrar.Click
        If MsgBox("¿Está seguro de que desea salir?", MsgBoxStyle.YesNo, "360 IT") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnWEB.Click
        System.Diagnostics.Process.Start("www.infoandina.com")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Call btnVentas_Click(btnVentas, e)
            Case Keys.F2
                Call btnClientes_Click(btnClientes, e)
            Case Keys.F3
                Call btnCuentas_Click(btnCuentas, e)
            Case Keys.F4
                Call btnStock_Click(btnStock, e)
            Case Keys.F5
                Call btnProveedores_Click(btnProveedores, e)
            Case Keys.Escape
                Call picCerrar_Click(picCerrar, e)
        End Select
    End Sub
End Class
