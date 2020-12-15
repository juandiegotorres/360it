Public Class frmNuevoProveedor
    Dim tablaFP As New DataTable
    Dim tablaRB As New DataTable
    Public eProveedor As New Entidades.Proveedor
    Dim listaRubro As New List(Of UInt16)
    Dim listaPago As New List(Of UInt16)
    Dim contador As UInt64
    Private _modificar As Boolean
    Public Property modificar As Boolean
        Set(value As Boolean)
            _modificar = value
        End Set
        Get
            Return _modificar
        End Get
    End Property
    Private Sub FrmNuevoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClbFormPago()
        CargarClbRubros()
        'clbFormPago.SelectionMode = SelectionMode.None
        'clbRubro.SelectionMode = SelectionMode.None
        If _modificar = True Then
            eProveedor.modificarProveedor()
            lblTitulo.Text = "Modificar Proveedor"
            txtNombre.Text = eProveedor.nombre
            txtCBU.Text = eProveedor.cbu
            txtCuil.Text = eProveedor.cuil
            txtDireccion.Text = eProveedor.direccion
            txtTelefono.Text = eProveedor.telefono
            txtHorario.Text = eProveedor.horario

            Dim tablaModificarRubro As New DataTable
            eProveedor.verRubrosProveedor(tablaModificarRubro)

            If tablaModificarRubro.Rows.Count > 0 Then
                For i = 0 To clbRubro.Items.Count - 1
                    For a = 0 To tablaModificarRubro.Rows.Count - 1
                        Dim index As Integer = clbRubro.FindString(tablaModificarRubro.Rows(a).Item("nombRubro").ToString)
                        clbRubro.SetItemChecked(index, True)
                    Next
                Next
            End If

            Dim tablaModificarPago As New DataTable
            eProveedor.verPagosProveedor(tablaModificarPago)

            If tablaModificarPago.Rows.Count > 0 Then
                For i = 0 To clbFormPago.Items.Count - 1
                    For a = 0 To tablaModificarPago.Rows.Count - 1
                        Dim index As Integer = clbFormPago.FindString(tablaModificarPago.Rows(a).Item("nombFormaPago").ToString)
                        clbFormPago.SetItemChecked(index, True)
                    Next
                Next
            End If

        End If
    End Sub
    Private Sub CargarClbFormPago()
        eProveedor.recuperarFormPago(tablaFP)
        clbFormPago.DataSource = tablaFP
        clbFormPago.DisplayMember = "nombFormaPago"
        clbFormPago.ValueMember = "idformpago"
        'clbFormPago.SetSelected(clbFormPago.SelectedIndex, False)
    End Sub

    Private Sub limpiarCampos()
        Dim txt As Control
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.Text = ""
            End If
        Next
    End Sub

    Private Sub CargarClbRubros()
        eProveedor.recuperarRubro(tablaRB)
        clbRubro.DataSource = tablaRB
        clbRubro.DisplayMember = "nombRubro"
        clbRubro.ValueMember = "idrubro"
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        frmPrincipal.Show()
    End Sub

    Private Sub clbFormPago_LostFocus(sender As Object, e As EventArgs) Handles clbFormPago.LostFocus
        'clbFormPago.SetSelected(clbFormPago.SelectedIndex, False)
    End Sub

    Private Sub clbFormPago_MouseDown(sender As Object, e As MouseEventArgs) Handles clbFormPago.MouseDown
        'Dim Index As Integer = clbFormPago.IndexFromPoint(e.Location)
        'clbFormPago.SetItemChecked(Index, Not clbFormPago.GetItemChecked(Index))
    End Sub

    Private Sub clbRubro_MouseDown(sender As Object, e As MouseEventArgs) Handles clbRubro.MouseDown
        'Dim Index As Integer = clbRubro.IndexFromPoint(e.Location)
        'clbRubro.SetItemChecked(Index, Not clbFormPago.GetItemChecked(Index))
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
        For i = 0 To clbRubro.Items.Count - 1
            clbRubro.SetItemChecked(i, False)
        Next
        For i = 0 To clbFormPago.Items.Count - 1
            clbFormPago.SetItemChecked(i, False)
        Next
    End Sub


    Public Sub guardarCLB(ByRef clb As CheckedListBox, ByRef lista As List(Of UInt16))
        For i = 0 To clb.CheckedIndices.Count - 1
            If i < clb.CheckedIndices.Count Then
                Dim a As Integer = clb.CheckedIndices(i)
                lista.Add(a + 1)
            End If
        Next
    End Sub

    Public Function comprobarFormPago()
        For i = 0 To clbFormPago.Items.Count - 1
            If clbFormPago.GetItemChecked(i) Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function comprobarRubros()
        For i = 0 To clbRubro.Items.Count - 1
            If clbRubro.GetItemChecked(i) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If comprobarDatos() = True Then
                If Len(txtCuil.Text) <> 11 Then
                    MsgBox("El campo CUIL debe tener 11 dígitos", MsgBoxStyle.Critical, "Nuevo Proveedor")
                    Exit Sub
                End If
                If Len(txtCBU.Text) <> 22 Then
                    MsgBox("El campo CBU debe tener 22 dígitos", MsgBoxStyle.Critical, "Nuevo Proveedor")
                    Exit Sub
                End If
                If comprobarFormPago() = False And comprobarRubros() = False Then
                    MsgBox("Tiene que seleccionar al menos una forma de pago y un rubro.", MsgBoxStyle.Exclamation, "Proveedor")
                    Exit Sub
                ElseIf comprobarFormPago() = False Then
                    MsgBox("Tiene que seleccionar al menos una forma de pago. Si la lista está vacía, intente agregar una forma de pago desde las opciones.", MsgBoxStyle.Exclamation, "Proveedor")
                    Exit Sub
                ElseIf comprobarRubros() = False Then
                    MsgBox("Tiene que seleccionar al menos un rubro. Si la lista está vacía, intente agregar un rubro desde las opciones.", MsgBoxStyle.Exclamation, "Proveedor")
                    Exit Sub
                End If
                eProveedor.nombre = txtNombre.Text
                eProveedor.cuil = txtCuil.Text
                eProveedor.telefono = txtTelefono.Text
                eProveedor.cbu = txtCBU.Text
                eProveedor.direccion = txtDireccion.Text
                eProveedor.horario = txtHorario.Text
                guardarCLB(clbFormPago, listaPago)
                eProveedor.formPago = listaPago
                guardarCLB(clbRubro, listaRubro)
                eProveedor.rubro = listaRubro
                If _modificar = False Then
                    eProveedor.nuevoProveedor()
                    MsgBox("Proveedor guardado con éxito", MsgBoxStyle.Information, "Nuevo proveedor")
                    Me.DialogResult = DialogResult.OK
                Else
                    eProveedor.guardarProveedorModif()
                    MsgBox("Proveedor modificado con éxito", MsgBoxStyle.Information, "Modificar proveedor")
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function comprobarDatos()
        contador = 0
        Dim _control As Control
        For Each _control In Me.Controls
            If TypeOf _control Is TextBox Then
                If _control Is txtHorario Then
                Else
                    If LTrim(_control.Text) = "" Then
                        'MsgBox("El campo '" & _control.Tag & "' no puede estar vacío", MsgBoxStyle.Exclamation, "Clientes")
                        _control.BackColor = Color.FromArgb(255, 178, 178)
                        contador += 1
                    End If
                End If
            End If
        Next
        If contador <> 0 Then
            MsgBox("Los campos marcados de color rojo no pueden estar vacíos, completelos e intente de nuevo", MsgBoxStyle.Exclamation, "Nuevo Proveedor")
            Return False
        Else
            Return True
        End If
    End Function
    'Public Function comprobarDatos()
    '    Dim _control As Control
    '    For Each _control In Me.Controls
    '        If TypeOf _control Is TextBox Then
    '            If LTrim(_control.Text) = "" Then
    '                MsgBox("El campo '" & _control.Tag & "' no puede estar vacío", MsgBoxStyle.Exclamation, "Proveedores")
    '                Return False
    '            End If
    '        End If
    '    Next
    '    Return True
    'End Function
#Region "KEYPRESS"

    Private Sub txtCBU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCBU.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmNuevoProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case (Keys.Alt + Keys.L)
                Call BtnLimpiar_Click(btnLimpiar, e)
            Case Keys.Enter
                Call BtnGuardar_Click(btnGuardar, e)
            Case Keys.Escape
                Call BtnCancelar_Click(btnCancelar, e)
            Case Keys.Up
                e.Handled = True
                Me.SelectNextControl(Me.ActiveControl, False, True, True, True)
        End Select
    End Sub

    Private Sub frmNuevoProveedor_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub

    Private Sub txtCuil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuil.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_GotFocus(sender As Object, e As EventArgs) Handles txtNombre.GotFocus
        txtNombre.BackColor = Color.White
    End Sub
    Private Sub txtNombre_LostFocus(sender As Object, e As EventArgs) Handles txtNombre.LostFocus
        If LTrim(txtNombre.Text) = "" Then
            txtNombre.BackColor = Color.FromArgb(255, 178, 178)
        End If
    End Sub

    Private Sub txtCuil_GotFocus(sender As Object, e As EventArgs) Handles txtCuil.GotFocus
        txtCuil.BackColor = Color.White
    End Sub

    Private Sub txtCuil_LostFocus(sender As Object, e As EventArgs) Handles txtCuil.LostFocus
        If LTrim(txtCuil.Text) = "" Then
            txtCuil.BackColor = Color.FromArgb(255, 178, 178)
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

    Private Sub txtCBU_GotFocus(sender As Object, e As EventArgs) Handles txtCBU.GotFocus
        txtCBU.BackColor = Color.White
    End Sub

    Private Sub txtCBU_LostFocus(sender As Object, e As EventArgs) Handles txtCBU.LostFocus
        If LTrim(txtCBU.Text) = "" Then
            txtCBU.BackColor = Color.FromArgb(255, 178, 178)
        End If
    End Sub




#End Region


End Class