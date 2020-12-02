﻿Public Class frmEtiqueta
    Dim idReparacion As UInt64
    Dim eServTec As New Entidades.ServTecnico
    Dim tablaInformacion As New DataTable
    Public Sub New(ByRef idReparacion_ As UInt64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idReparacion = idReparacion_
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    'Private Sub lblID_Paint(sender As Object, e As PaintEventArgs) Handles lblID.Paint
    '    lblID.Text = "123"
    '    e.Graphics.TranslateTransform(lblID.ClientSize.Width, lblID.ClientSize.Height)
    '    e.Graphics.RotateTransform(180)
    '    e.Graphics.DrawString("Rotado 180 grados", lblID.Font,
    '    Brushes.Black, RectangleF.op_Implicit(lblID.ClientRectangle))
    '    lblID.BringToFront()
    'End Sub

    Private Sub frmEtiqueta_Load(sender As Object, e As EventArgs) Handles Me.Load
        timerImprimir.Start()
        lblID.Select()
        eServTec.generarEtiqueta(tablaInformacion, idReparacion)
        lblTipoArticulo.Text = "Tipo: " & tablaInformacion.Rows(0).Item("tipoArticulo").ToString
        lblMarca.Text = "Marca: " & tablaInformacion.Rows(0).Item("marca").ToString
        lblModelo.Text = "Modelo: " & tablaInformacion.Rows(0).Item("modelo").ToString
        lblFechaRecepcion.Text = "Fecha: " & CDate(tablaInformacion.Rows(0).Item("fechaRecep").ToString)
        lblCliente.Text = "Cliente: " & tablaInformacion.Rows(0).Item("nombreApel").ToString
        lblID.Text = "ID REPARACIÓN: " & tablaInformacion.Rows(0).Item("idReparacion").ToString
    End Sub

    Private Sub timerImprimir_Tick(sender As Object, e As EventArgs) Handles timerImprimir.Tick
        timerImprimir.Stop()
        imprimirEtiqueta.Print()
        Me.Dispose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        imprimirEtiqueta.Print()

    End Sub

    Private Sub frmEtiqueta_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub
End Class