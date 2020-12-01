Public Class frmNuevoCliente
    Private _modificar As Boolean
    Public Property modificar As Boolean
        Set(value As Boolean)
            _modificar = value
        End Set
        Get
            Return _modificar
        End Get
    End Property

    Public eCliente As New Entidades.Cliente
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmPrincipal.Show()
    End Sub

    Private Sub frmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCB()
        If modificar = True Then
            lblTitulo.Text = "Modificar Cliente"
            eCliente.modificarCliente()
            txtNomApel.Text = eCliente.nombApel
            txtTelefono.Text = eCliente.telefono
            txtDireccion.Text = eCliente.direccion
            cbProvincias.SelectedValue = eCliente.idProvincia
            txtLocalidad.Text = eCliente.nombLocalidad
        Else
            eCliente.idLocalidad = 1
            eCliente.idProvincia = 8
            txtLocalidad.Text = "Real del Padre"
        End If

    End Sub
    Private Sub llenarCB()
        Dim dtProvincias As New DataTable
        eCliente.traerProvincias(dtProvincias)
        With cbProvincias
            .DataSource = dtProvincias
            .DisplayMember = "nombprovincia"
            .ValueMember = "idprovincia"
            .SelectedIndex = 6
        End With
    End Sub
    Public Function comprobarDatos()
        Dim _control As Control
        For Each _control In Me.Controls
            If TypeOf _control Is TextBox Then
                If LTrim(_control.Text) = "" Then
                    MsgBox("Faltan completar datos", MsgBoxStyle.Exclamation, "Clientes")
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Public Sub limpiarCampos()
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
            If TypeOf txt Is RichTextBox Then
                txt.Text = ""
            End If
        Next
        txtLocalidad.Text = "Real del Padre"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If comprobarDatos() = True Then
            eCliente.nombApel = txtNomApel.Text
            eCliente.telefono = txtTelefono.Text
            eCliente.direccion = txtDireccion.Text
            eCliente.idProvincia = cbProvincias.SelectedValue
            If _modificar = False Then
                eCliente.fechaCreacion = Date.Now
                eCliente.fechaModificacion = Date.Now
                eCliente.guardarCliente()
                MsgBox("Cliente guardado", MsgBoxStyle.Information, "Clientes")
                Me.DialogResult = DialogResult.OK
            Else
                eCliente.fechaModificacion = Date.Now
                eCliente.guardarClienteModif()
                MsgBox("Cliente modificado", MsgBoxStyle.Information, "Clientes")
                Me.DialogResult = DialogResult.OK
            End If
            frmClientes.Show()
        End If
    End Sub

    Private Sub btnLocalidades_Click(sender As Object, e As EventArgs) Handles btnLocalidades.Click
        Dim localidades As New frmLocalidades
        With localidades
            .idProvincia = cbProvincias.SelectedValue
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                eCliente.nombLocalidad = localidades.eLocalidad.nombLocalidad
                eCliente.idLocalidad = localidades.eLocalidad.idLocalidad
                txtLocalidad.Text = localidades.eLocalidad.nombLocalidad
            End If
        End With
    End Sub

    Private Sub cbProvincias_DropDownClosed(sender As Object, e As EventArgs) Handles cbProvincias.DropDownClosed
        'Guarda la provincia luego de seleccionar una opcion en el combobox
        eCliente.idProvincia = cbProvincias.SelectedValue
        'If cbProvincias.SelectedValue = eCliente.idProvincia Then
        '    txtLocalidad.Text = eCliente.nombLocalidad
        'End If
        If cbProvincias.SelectedValue = 8 Then
            If modificar = True Then
                txtLocalidad.Text = ""
            Else
                eCliente.idLocalidad = 1
                eCliente.idProvincia = 8
                txtLocalidad.Text = "Real del Padre"
            End If
        Else
            txtLocalidad.Text = ""
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Está seguro de que desea salir?", MsgBoxStyle.YesNo, "Agregar Cliente") = MsgBoxResult.Yes Then
            Me.Close()
            frmPrincipal.Show()
        End If
    End Sub

#Region "KEYPRESS"
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmNuevoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case (Keys.Control + Keys.L)
                Call btnLimpiar_Click(btnLimpiar, e)
            Case Keys.Enter
                Call btnGuardar_Click(btnGuardar, e)
            Case Keys.Escape
                Call BtnCancelar_Click(btnCancelar, e)
            Case Keys.Up
                e.Handled = True
                Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End Select
    End Sub

    Private Sub frmNuevoCliente_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub



#End Region
End Class