Public Class frmDetalleReparacion
    Dim e_Reparacion As New Entidades.ServTecnico
    Public Sub New(ByRef idReparacion As UInt64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        e_Reparacion.idReparacion = idReparacion
    End Sub

    Private Sub frmDetalleReparacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        e_Reparacion.detalleReparacion()
        txtCliente.Text = e_Reparacion.nombreCliente
        txtEstado.Text = e_Reparacion.nombreEstado
        txtAccesorios.Text = e_Reparacion.accesorios
        txtDescripcion.Text = e_Reparacion.descripcion
        If LTrim(e_Reparacion.notaTecnico) = "" Then
            txtNotaTecnico.Text = "El técnico aún no ha publicado una nota"
        Else
            txtNotaTecnico.Text = e_Reparacion.notaTecnico
        End If
        btnCerrar.Select()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmDetalleReparacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Me.Close()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub frmDetalleReparacion_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub
End Class