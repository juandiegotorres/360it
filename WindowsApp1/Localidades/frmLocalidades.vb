Public Class frmLocalidades
    Dim bsLocalidades As New BindingSource
    Public eLocalidad As New Entidades.Localidad
    Private _idProvincia As UInt16
    Public Property idProvincia As UInt16
        Set(value As UInt16)
            _idProvincia = value
        End Set
        Get
            Return _idProvincia
        End Get
    End Property
    Private Sub frmLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarDatos()
    End Sub

    Private Sub actualizarDatos()
        Dim tablaLocalidades As New DataTable
        eLocalidad.idProvincia = _idProvincia
        eLocalidad.traerLocalidades(tablaLocalidades)
        bsLocalidades.DataSource = tablaLocalidades
        dgvLocalidades.DataSource = bsLocalidades
        dgvLocalidades.ClearSelection()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Cuenta la cantidad de celdas seleccionadas
        If dgvLocalidades.CurrentRow.Selected = False Then
            MsgBox("No ha seleccionado ninguna localidad", MsgBoxStyle.Exclamation, "Localidades")
        Else
            eLocalidad.idLocalidad = dgvLocalidades.CurrentRow.Cells("idLocalidad").Value
            eLocalidad.nombLocalidad = dgvLocalidades.CurrentRow.Cells("nombLocalidad").Value
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Dim filtro As String
    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtro = "nombLocalidad like '%" & txtBuscar.Text & "%'"
        bsLocalidades.Filter = filtro
        dgvLocalidades.ClearSelection()
    End Sub

    Private Sub dgvLocalidades_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLocalidades.ColumnHeaderMouseClick
        dgvLocalidades.ClearSelection()
    End Sub

    Private Sub BtnNuevaLocalidad_Click(sender As Object, e As EventArgs) Handles btnNuevaLocalidad.Click
        txtNuevaLoc.Visible = True
        lblNombre.Visible = True
        btnGuardarLoc.Visible = True
        btnAceptar.Enabled = False
        txtBuscar.Enabled = False
        btnCancelarLoc.Visible = True
        txtNuevaLoc.Focus()
    End Sub

    Private Sub BtnGuardarLoc_Click(sender As Object, e As EventArgs) Handles btnGuardarLoc.Click
        If guardarLocalidad() = True Then
            actualizarDatos()
            If MsgBox("Localidad agregada", MsgBoxStyle.Information, "Localidades") = MsgBoxResult.Ok Then
                restablecerControles()
            End If
        Else
            MsgBox("Sucedió un problema al agregar la localidad", MsgBoxStyle.Critical, "Localidades")
        End If
    End Sub
    Public Function guardarLocalidad() As Boolean
        Try
            eLocalidad.nombLocalidad = txtNuevaLoc.Text
            eLocalidad.nuevaLocalidad()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Guardar localidad")
            Return False
        End Try
    End Function

    Private Sub frmLocalidades_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        dgvLocalidades.ClearSelection()
    End Sub

    Private Sub BtnCancelarLoc_Click(sender As Object, e As EventArgs) Handles btnCancelarLoc.Click
        restablecerControles()
    End Sub
    Public Sub restablecerControles()
        btnAceptar.Enabled = True
        txtBuscar.Enabled = True
        txtNuevaLoc.Visible = False
        lblNombre.Visible = False
        btnGuardarLoc.Visible = False
        btnCancelarLoc.Visible = False
    End Sub

    Private Sub picCerrar_Click(sender As Object, e As EventArgs) Handles picCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmLocalidades_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Call BtnAceptar_Click(btnAceptar, e)
            Case Keys.Escape
                Call BtnCancelar_Click(btnCancelar, e)
        End Select
    End Sub

    Private Sub frmLocalidades_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub
End Class