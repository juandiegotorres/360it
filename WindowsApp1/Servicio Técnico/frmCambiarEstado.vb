Public Class frmCambiarEstado
    Dim e_Reparacion As New Entidades.ServTecnico
    Dim index As Integer = 1
    Public Sub New(ByRef idEstado As UInt16, ByRef idReparacion As UInt64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        e_Reparacion.idEstado = idEstado
        e_Reparacion.idReparacion = idReparacion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmCambiarEstado_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Public Sub guardar()
        If LTrim(txtNotaTecnico.Text) = "" Then
            e_Reparacion.notaTecnico = "Sin nota de parte del técnico"
        Else
            e_Reparacion.notaTecnico = txtNotaTecnico.Text
        End If
        e_Reparacion.idEstado = cbEstado.SelectedValue
        e_Reparacion.cambiarEstado()
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub frmCambiarEstado_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tablaEstado As New DataTable
        e_Reparacion.estadoReparacion(tablaEstado)
        cbEstado.DataSource = tablaEstado
        cbEstado.DisplayMember = "nombreEstado"
        cbEstado.ValueMember = "id"
        cbEstado.SelectedValue = e_Reparacion.idEstado
        e_Reparacion.verNotaTecnico()
        txtNotaTecnico.Text = e_Reparacion.notaTecnico
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        e_Reparacion.notaTecnico = txtNotaTecnico.Text
        guardar()
    End Sub

    Private Sub frmCambiarEstado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                guardar()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
End Class