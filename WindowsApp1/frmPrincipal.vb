Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class frmPrincipal

    'Importar archivos para poder mover el form con el mouse, ya que no tiene bordes
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wmsg As Integer, ByVal wparam As Integer, ByVal lparam As Integer)
    End Sub

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
        'Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        'Me.Bounds = Screen.GetWorkingArea(Me)
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.Manual
        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, .Width, .Height)
        End With

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
        abrirForm(frmFacturacion)
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
    Private Sub btnServTecnico_Click(sender As Object, e As EventArgs) Handles btnServTecnico.Click
        panelCost.Visible = True
        panelCost.Height = btnServTecnico.Height
        panelCost.Top = btnServTecnico.Top
        abrirForm(frmServTecnico)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnWEB.Click
        System.Diagnostics.Process.Start("www.infoandina.com")
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
                Call btnCerrar_Click(btnCerrar, e)
        End Select
    End Sub
    'Poder mover la ventana con el mouse, porque el form no tiene bordes
    Private Sub frmPrincipal_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub btnAgrandar_Click(sender As Object, e As EventArgs) Handles btnAgrandar.Click

        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, .Width, .Height)
        End With
        btnAgrandar.Visible = False
        btnAchicar.Visible = True
    End Sub

    Private Sub btnAchicar_Click(sender As Object, e As EventArgs) Handles btnAchicar.Click

        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, 1234, 703)
        End With
        'Me.WindowState = FormWindowState.Normal
        btnAchicar.Visible = False
        btnAgrandar.Visible = True
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MsgBox("¿Está seguro de que desea salir?", MsgBoxStyle.YesNo, "360 IT") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click

        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCuentaCorriente_Click(sender As Object, e As EventArgs) Handles btnCuentaCorriente.Click
        panelCost.Visible = True
        panelCost.Height = btnCuentaCorriente.Height
        panelCost.Top = btnCuentaCorriente.Top
        abrirForm(frmCuentasCorriente)
    End Sub
End Class
