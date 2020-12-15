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
    Dim contador As Integer
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
            txtDNI.Text = eCliente.dni
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
        contador = 0
        Dim _control As Control
        For Each _control In Me.Controls
            If TypeOf _control Is TextBox Then
                If LTrim(_control.Text) = "" Then
                    'MsgBox("El campo '" & _control.Tag & "' no puede estar vacío", MsgBoxStyle.Exclamation, "Clientes")
                    _control.BackColor = Color.FromArgb(255, 178, 178)
                    contador += 1
                End If
            End If
        Next
        If contador <> 0 Then
            MsgBox("Los campos marcados de color rojo no pueden estar vacíos, completelos e intente de nuevo", MsgBoxStyle.Exclamation, "Nuevo Cliente")
            Return False
        Else
            Return True
        End If
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
            If Len(txtDNI.Text) <> 8 Then
                MsgBox("El campo DNI debe tenere 8 dígitos", MsgBoxStyle.Critical, "Nuevo Cliente")
                Exit Sub
            Else
                eCliente.nombApel = txtNomApel.Text
                eCliente.telefono = txtTelefono.Text
                eCliente.direccion = txtDireccion.Text
                eCliente.idProvincia = cbProvincias.SelectedValue
                eCliente.dni = txtDNI.Text
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
            Case (Keys.Alt + Keys.L)
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

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNomApel_GotFocus(sender As Object, e As EventArgs) Handles txtNomApel.GotFocus
        txtNomApel.BackColor = Color.White
    End Sub
    Private Sub txtNomApel_LostFocus(sender As Object, e As EventArgs) Handles txtNomApel.LostFocus
        If LTrim(txtNomApel.Text) = "" Then
            txtNomApel.BackColor = Color.FromArgb(255, 178, 178)
        End If
    End Sub

    Private Sub txtDNI_GotFocus(sender As Object, e As EventArgs) Handles txtDNI.GotFocus
        txtDNI.BackColor = Color.White
    End Sub
    Private Sub txtDNI_LostFocus(sender As Object, e As EventArgs) Handles txtDNI.LostFocus
        If LTrim(txtDNI.Text) = "" Then
            txtDNI.BackColor = Color.FromArgb(255, 178, 178)
        End If
    End Sub


    Private Sub txtTelefono_GotFocus(sender As Object, e As EventArgs) Handles txtTelefono.GotFocus
        txtTelefono.BackColor = Color.White
    End Sub

    Private Sub txtTelefono_LostFocus(sender As Object, e As EventArgs) Handles txtTelefono.LostFocus
        If LTrim(txtTelefono.Text) = "" Then
            txtTelefono.BackColor = Color.FromArgb(255, 178, 178)
        End If
    End Sub

    Private Sub txtDireccion_GotFocus(sender As Object, e As EventArgs) Handles txtDireccion.GotFocus
        txtDireccion.BackColor = Color.White
    End Sub

    Private Sub txtDireccion_LostFocus(sender As Object, e As EventArgs) Handles txtDireccion.LostFocus
        If LTrim(txtDireccion.Text) = "" Then
            txtDireccion.BackColor = Color.FromArgb(255, 178, 178)
        End If
    End Sub


#End Region
End Class