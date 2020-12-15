Public Class frmNotas
    'El formulario Notas esta estructurado con tres tablelayoutpanel, de los cuales 1 tiene el titulo, otro la paginacion y el de en medio (TableLayoutPanel2) contiene las notas, este esta dividido en 4 columnas y dos filas de las cuales cada una tiene un dos paneles (uno contenedor y otro header), un textbox dentro del panel contenedor y tres imagenes y un label en el panel header. Todos los controles situados dentro del panel tienen el mismo nombre cambiando su numero identificador al final (nota1,2,3, etc | fecha1,2,3 etc | headernota1,2,3, etc)
    Dim eNotas As New Entidades.Nota
    Dim cantidadNotas, cantidadPaginas, paginaActual, a As UInt32
    Dim tablaNotas As New DataTable
    Dim _control As Control
    Dim _control2 As Control
    Dim txt As TextBox
    Dim lbl As Label
    Dim nombreLabel, numeroDePanel, nombreTextbox As String
    Dim numeroDeFilas As Integer
    Private Sub frmNotas_Load(sender As Object, e As EventArgs) Handles Me.Load

        paginaActual = 1
        If cantidadPaginas = paginaActual Then
            linkSiguiente.Enabled = False
        End If

        cargarNotas(0)
    End Sub
    Public Sub colorPanelHeader(ByRef idColor As UInt16, ByRef panelHeader As Panel)
        Select Case idColor
            Case 1
                panelHeader.BackColor = Color.FromArgb(255, 156, 0)

            Case 2
                panelHeader.BackColor = Color.CornflowerBlue

            Case 3
                panelHeader.BackColor = Color.LightCoral

            Case 4
                panelHeader.BackColor = Color.LightGreen

            Case 5
                panelHeader.BackColor = Color.MediumPurple

        End Select
    End Sub
    Public Sub colorPanel(ByRef idColor As UInt16, ByRef panel As Panel, ByRef txtNota As TextBox)
        Select Case idColor
            Case 1
                panel.BackColor = Color.Moccasin
                txtNota.BackColor = Color.Moccasin
            Case 2
                panel.BackColor = Color.LightSteelBlue
                txtNota.BackColor = Color.LightSteelBlue
            Case 3
                panel.BackColor = Color.FromArgb(242, 183, 183)
                txtNota.BackColor = Color.FromArgb(242, 183, 183)
            Case 4
                panel.BackColor = Color.FromArgb(193, 242, 193)
                txtNota.BackColor = Color.FromArgb(193, 242, 193)
            Case 5
                panel.BackColor = Color.Thistle
                txtNota.BackColor = Color.Thistle
        End Select
    End Sub
    Public Sub cargarNotas(ByRef offset As UInt32)
        tablaNotas.Clear()
        eNotas.contarNotas(tablaNotas)
        cantidadNotas = tablaNotas.Rows(0).Item("cantidad").ToString
        'Redondea el resultado hacia arriba
        cantidadPaginas = Math.Ceiling(cantidadNotas / 8)
        tablaNotas.Clear()
        eNotas.traerNotas(tablaNotas, offset)
        numeroDeFilas = tablaNotas.Rows.Count
        For Each _control In TableLayoutPanel2.Controls
            If TypeOf _control Is Panel Then
                'Para yo poder recorrer cada uno de los paneles para poder llenarlo con las notas tengo que obtener el numero de panel en el que estoy situado ya que eso me va a dar el numero de textbox donde tengo que situar la nota. Una vez que lo tengo almaceno en una variable
                numeroDePanel = Mid(_control.Name, _control.Name.Length)

                'Ahora surge otro problema, el label de la fecha no esta dentro del label contenedor por lo que tengo que recorrer los controles dentro del panel para poder encontrarlo
                For Each _control2 In _control.Controls
                    If TypeOf _control2 Is Panel Then
                        'Anteriormente cree una variable que contiene la cantidad de filas de la tabla en la base de datos, para poder parar cuando haya asignado todas las notas (si son menos de 8)
                        If numeroDePanel <= numeroDeFilas Then
                            colorPanelHeader(tablaNotas.Rows(numeroDePanel - 1).Item("color").ToString, _control2)
                            'Una vez que pude entrar dentro del panel header asigno el nombre del label
                            nombreLabel = "fecha" & numeroDePanel
                            lbl = _control2.Controls.Item(nombreLabel)
                            lbl.Text = CDate(tablaNotas.Rows(numeroDePanel - 1).Item("date(fecha)").ToString)
                        End If
                    End If
                Next
                'Ahora prosigo a hacer algo similar con lo de arriba pero para los textbox
                If numeroDePanel <= numeroDeFilas Then

                    nombreTextbox = "nota" & numeroDePanel
                    txt = _control.Controls.Item(nombreTextbox)
                    txt.Text = tablaNotas.Rows(numeroDePanel - 1).Item("nota").ToString
                    'Voy a asignar el ID al tag por si el usario desea dar de baja la nota poder identificarla
                    txt.Tag = tablaNotas.Rows(numeroDePanel - 1).Item("idnota").ToString
                    colorPanel(tablaNotas.Rows(numeroDePanel - 1).Item("color").ToString, _control, txt)
                    _control.Visible = True
                Else
                    'Si hay menos de 8 notas voy a esconder los paneles sobrantes
                    _control.Visible = False
                End If

            End If
        Next
    End Sub
    Public Sub eliminarNota(ByRef id As Integer)
        If MsgBox("¿Desea dar de baja esta nota?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Notas") = MsgBoxResult.Yes Then
            eNotas.bajaNota(id)
            cargarNotas(0)
            paginaActual = 1
            If paginaActual < cantidadPaginas Then
                linkSiguiente.Enabled = True
            End If
            pag1.BackColor = Color.DarkOrange
            pag2.BackColor = Color.Transparent
            pag3.BackColor = Color.Transparent
        End If
    End Sub
    Public Sub modificarNota(ByRef id As Integer)
        Dim mdfNota As New frmNuevaNota(id, True)
        mdfNota.ShowDialog()
        If mdfNota.DialogResult = DialogResult.OK Then
            cargarNotas(0)
        End If
    End Sub
    Private Sub picEliminar1_Click(sender As Object, e As EventArgs) Handles picEliminar1.Click
        eliminarNota(nota1.Tag)
    End Sub

    Private Sub picEliminar2_Click(sender As Object, e As EventArgs) Handles picEliminar2.Click
        eliminarNota(nota2.Tag)
    End Sub

    Private Sub picEliminar3_Click(sender As Object, e As EventArgs) Handles picEliminar3.Click
        eliminarNota(nota3.Tag)
    End Sub

    Private Sub picEliminar4_Click(sender As Object, e As EventArgs) Handles picEliminar4.Click
        eliminarNota(nota4.Tag)
    End Sub

    Private Sub picEliminar5_Click(sender As Object, e As EventArgs) Handles picEliminar5.Click
        eliminarNota(nota5.Tag)
    End Sub

    Private Sub picEliminar6_Click(sender As Object, e As EventArgs) Handles picEliminar6.Click
        eliminarNota(nota6.Tag)
    End Sub

    Private Sub btnAgregarSeleccionar_Click(sender As Object, e As EventArgs) Handles btnAgregarSeleccionar.Click
        Dim nuevaNota As New frmNuevaNota
        nuevaNota.ShowDialog()
        If nuevaNota.DialogResult = DialogResult.OK Then
            cargarNotas(0)
        End If
    End Sub
    Private Sub picEliminar7_Click(sender As Object, e As EventArgs) Handles picEliminar7.Click
        eliminarNota(nota7.Tag)
    End Sub


    Private Sub picEliminar8_Click(sender As Object, e As EventArgs) Handles picEliminar8.Click
        eliminarNota(nota8.Tag)
    End Sub


    Private Sub picEditar1_Click(sender As Object, e As EventArgs) Handles picEditar1.Click
        modificarNota(nota1.Tag)
    End Sub
    Private Sub picEditar2_Click(sender As Object, e As EventArgs) Handles picEditar2.Click
        modificarNota(nota2.Tag)
    End Sub
    Private Sub picEditar3_Click(sender As Object, e As EventArgs) Handles picEditar3.Click
        modificarNota(nota3.Tag)
    End Sub

    Private Sub picEditar4_Click(sender As Object, e As EventArgs) Handles picEditar4.Click
        modificarNota(nota4.Tag)
    End Sub

    Private Sub picEditar5_Click(sender As Object, e As EventArgs) Handles picEditar5.Click
        modificarNota(nota5.Tag)
    End Sub
    Private Sub picEditar6_Click(sender As Object, e As EventArgs) Handles picEditar6.Click
        modificarNota(nota6.Tag)
    End Sub
    Private Sub linkAnterior_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkAnterior.LinkClicked
        paginaActual = paginaActual - 1
        If paginaActual = 1 Then
            If paginaActual = cantidadPaginas Then
                linkSiguiente.Enabled = False
            Else
                linkSiguiente.Enabled = True
            End If
            linkAnterior.Enabled = False
            pag1.BackColor = Color.DarkOrange
            pag2.BackColor = Color.Transparent
            pag1.Text = "1"
            cargarNotas(0)
        End If
        If paginaActual = 2 Then
            pag2.BackColor = Color.DarkOrange
            pag1.BackColor = Color.Transparent
            pag3.BackColor = Color.Transparent
            pag2.Text = "2"
            linkAnterior.Enabled = True
            cargarNotas(8 + 1)
        ElseIf paginaActual = 3 Then
            pag2.BackColor = Color.Transparent
            pag1.Text = "1"
            pag2.Text = "2"
            pag3.Text = "3"
            pag3.BackColor = Color.DarkOrange
            linkAnterior.Enabled = True
            cargarNotas(16 + 1)
        ElseIf paginaActual > 3 Then
            pag1.Text = CInt(pag1.Text) - 1
            pag2.Text = CInt(pag2.Text) - 1
            pag3.Text = CInt(pag3.Text) - 1
            cargarNotas((paginaActual * 8) + 1)
        End If
    End Sub
    Private Sub linkSiguiente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSiguiente.LinkClicked
        paginaActual = paginaActual + 1
        If paginaActual = cantidadPaginas Then
            linkSiguiente.Enabled = False
        End If
        If paginaActual = 2 Then
            pag2.BackColor = Color.DarkOrange
            pag1.BackColor = Color.Transparent
            linkAnterior.Enabled = True
            cargarNotas(8 + 1)
        ElseIf paginaActual = 3 Then
            pag2.BackColor = Color.Transparent
            pag3.BackColor = Color.DarkOrange
            linkAnterior.Enabled = True
            cargarNotas(16 + 1)
        ElseIf paginaActual > 3 Then
            pag1.Text = pag2.Text
            pag2.Text = pag3.Text
            pag3.Text = paginaActual
            linkAnterior.Enabled = True
            cargarNotas((8 * paginaActual) + 1)
        End If
    End Sub

    Private Sub picEditar7_Click(sender As Object, e As EventArgs) Handles picEditar7.Click
        modificarNota(nota7.Tag)
    End Sub
    Private Sub picEditar8_Click(sender As Object, e As EventArgs) Handles picEditar8.Click
        modificarNota(nota8.Tag)
    End Sub
End Class