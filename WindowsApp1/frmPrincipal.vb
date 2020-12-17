Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class frmPrincipal
    Public colorGeneral As Color
    Dim probarConexion As New CapaDeNegocios.cdDatosPrueba

    'Importar archivos para poder mover el form con el mouse, ya que no tiene bordes
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wmsg As Integer, ByVal wparam As Integer, ByVal lparam As Integer)
    End Sub

    Private Sub abrirForm(ByVal formulario As Form)
        'Cerrar formulario actual
        colorGeneral = Color.FromArgb(124, 231, 45)
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
        If probarConexion.AbrirConexion = False Then
            Dim _control As Control
            For Each _control In Panel1.Controls

                If TypeOf _control Is Button Then
                    _control.Enabled = False
                End If
            Next
            btnOpciones.Enabled = True
            btnWEB.Enabled = True
        End If
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.Manual
        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, .Width, .Height)
        End With

    End Sub
    Public Sub cerrarForm()
        For Each form In pnlContenedor.Controls.OfType(Of Form).ToList()
            form.Close()
        Next
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnWEB_Click(sender As Object, e As EventArgs) Handles btnWEB.Click
        System.Diagnostics.Process.Start("www.infoandina.com")
    End Sub

    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.F1
                Call btnVentas_Click_1(btnVentas, e)
            Case (Keys.Alt + Keys.D1)
                Call btnVender_Click(btnVender, e)
                pnlSubMenuVentas.Visible = True
            Case (Keys.Alt + Keys.D2)
                Call btnCuentaCorriente_Click(btnCuentaCorriente, e)
                pnlSubMenuVentas.Visible = True
            Case (Keys.Alt + Keys.D3)
                Call btnCaja_Click(btnCaja, e)
                pnlSubMenuVentas.Visible = True
            Case (Keys.Alt + Keys.D4)
                Call btnHistorialVentas_Click(btnHistorialVentas, e)
                pnlSubMenuVentas.Visible = True
            Case Keys.F2
                pnlSubMenuVentas.Visible = False
                Call btnClientes_Click(btnClientes, e)
            Case Keys.F3
                pnlSubMenuVentas.Visible = False
                Call btnProductos_Click(btnProductos, e)
            Case Keys.F4
                pnlSubMenuVentas.Visible = False
                Call btnServTecnico_Click(btnServTecnico, e)
            Case Keys.F5
                pnlSubMenuVentas.Visible = False
                Call btnProveedores_Click(btnProveedores, e)
            Case Keys.F6
                pnlSubMenuVentas.Visible = False
                Call btnNotas_Click(btnNotas, e)
            Case Keys.F7
                pnlSubMenuVentas.Visible = False
                Call btnReportes_Click(btnReportes, e)
            Case (Keys.Alt + Keys.W)
                Call btnWEB_Click(btnWEB, e)
            Case (Keys.Alt + Keys.O)
                Call btnOpciones_Click(btnOpciones, e)
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
        If MsgBox("¿Está seguro de que desea salir?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "360 IT") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub customizarDesign()
        pnlSubMenuVentas.Visible = False
    End Sub

    Private Sub btnVentas_Click_1(sender As Object, e As EventArgs) Handles btnVentas.Click
        cerrarForm()
        pnlContenedor.Controls.Add(PictureBox3)
        panelSelector.Visible = True
        panelSelector.Height = btnVentas.Height
        panelSelector.Top = btnVentas.Top
        If pnlSubMenuVentas.Visible = True Then
            pnlSubMenuVentas.Visible = False
        Else
            pnlSubMenuVentas.Visible = True
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnVentas.Height
        panelSelector.Top = btnVentas.Top
        btnVender.BackColor = Color.Orange
        setColor(btnVender)
        abrirForm(frmVender)
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnVentas.Height
        panelSelector.Top = btnVentas.Top
        abrirForm(frmCaja)
        setColor(btnCaja)
    End Sub

    Private Sub btnHistorialVentas_Click(sender As Object, e As EventArgs) Handles btnHistorialVentas.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnVentas.Height
        panelSelector.Top = btnVentas.Top
        setColor(btnHistorialVentas)
        abrirForm(frmHistorialVentas)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnClientes.Height
        panelSelector.Top = btnClientes.Top
        abrirForm(frmClientes)
    End Sub
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnProductos.Height
        panelSelector.Top = btnProductos.Top
        abrirForm(frmProductos)
    End Sub

    Private Sub btnServTecnico_Click(sender As Object, e As EventArgs) Handles btnServTecnico.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnServTecnico.Height
        panelSelector.Top = btnServTecnico.Top
        abrirForm(frmServTecnico)
    End Sub
    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnProveedores.Height
        panelSelector.Top = btnProveedores.Top
        abrirForm(frmProveedores)
    End Sub
    Public Sub setColor(ByVal boton As Button)
        Dim btn As Button
        For Each btn In pnlSubMenuVentas.Controls
            btn.BackColor = Color.FromArgb(100, 100, 100)
        Next
        boton.BackColor = Color.FromArgb(255, 156, 0)
    End Sub


    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        'Si el boton ventas no esta habilitado significa que hay un error y no se puede conectar a la base de datos, de ese modo le indico al formulario opciones con el parametro errorDB, si es verdadero que solo deje habilitada las credenciales de la base de datos, si es false que cargue normalmente
        If btnVentas.Enabled = False Then
            Dim opciones As New frmOpciones(True)
            opciones.ShowDialog()
            If opciones.DialogResult = DialogResult.OK Then
                Call Panel1_Click(Panel1, e)
                panelSelector.Visible = False
            End If
        Else
            Dim opciones As New frmOpciones(False)
            opciones.ShowDialog()
            If opciones.DialogResult = DialogResult.OK Then
                Call Panel1_Click(Panel1, e)
                panelSelector.Visible = False
            End If
        End If
    End Sub


    Private Sub btnCuentaCorriente_Click(sender As Object, e As EventArgs) Handles btnCuentaCorriente.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnVentas.Height
        panelSelector.Top = btnVentas.Top
        setColor(btnCuentaCorriente)
        abrirForm(frmCuentasCorriente)
    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnNotas.Height
        panelSelector.Top = btnNotas.Top
        abrirForm(frmNotas)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        cerrarForm()
        panelSelector.Visible = True
        panelSelector.Height = btnReportes.Height
        panelSelector.Top = btnReportes.Top
        abrirForm(frmReportes)
    End Sub

    Private Sub panelCost_LocationChanged(sender As Object, e As EventArgs) Handles panelSelector.LocationChanged
        Dim btn As Button
        For Each btn In pnlSubMenuVentas.Controls
            btn.BackColor = Color.FromArgb(100, 100, 100)
        Next
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        cerrarForm()
        pnlContenedor.Controls.Add(PictureBox3)
    End Sub
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        cerrarForm()
        pnlContenedor.Controls.Add(PictureBox3)
    End Sub
End Class
