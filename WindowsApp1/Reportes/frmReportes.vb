Public Class frmReportes
    Dim eVentas As New Entidades.Venta
    Dim eProducto As New Entidades.Producto
    Dim tablaVentas, tablaProductos, tablaReportes As New DataTable


    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        eVentas.reporteVentaXMes(tablaVentas)
        eProducto.productoMasVendido(tablaProductos)
        eVentas.reportesGenerales(tablaReportes)
        If tablaReportes.Rows.Count = 0 Then
            MsgBox("No hay nada para mostrar", MsgBoxStyle.Information, "Reportes")
        Else
            lblClientes.Text = tablaReportes.Rows(0).Item("CantidadClientes").ToString & " Cliente(s)"
            lblCantidadProductos.Text = tablaReportes.Rows(1).Item("CantidadProductos").ToString & " Producto(s)"
            lblStockBajo.Text = tablaReportes.Rows(2).Item("bajoStock").ToString & " Producto(s)"
            lblArticulosReparados.Text = tablaReportes.Rows(3).Item("articulosReparados").ToString & " Artículo(s)"
        End If
        If tablaVentas.Rows.Count = 0 Then
            MsgBox("No se encuentran registros de ninguna venta", MsgBoxStyle.Information, "Reportes")
        Else
            graficoVentas.DataSource = tablaVentas
            graficoVentas.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
            graficoVentas.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False

            graficoVentas.ChartAreas(0).AxisX.LabelStyle.Interval = 1

            graficoVentas.ChartAreas(0).AxisX.TitleFont = New Font("Montserrat", 18, FontStyle.Bold, GraphicsUnit.Pixel)


            graficoVentas.ChartAreas(0).AxisY.TitleFont = New Font("Montserrat", 18, FontStyle.Bold, GraphicsUnit.Pixel)
            graficoVentas.ChartAreas(0).AxisY.Title = "Cantidad de Ventas"
            graficoVentas.ChartAreas(0).AxisY.TitleForeColor = Color.FromArgb(255, 156, 0)


        End If
        If tablaProductos.Rows.Count = 0 Then
            MsgBox("No se encuentran registros de ninguna producto", MsgBoxStyle.Information, "Reportes")
        Else
            graficoProductos.DataSource = tablaProductos
            'graficoProductos.Series("Series1")("PieLabelStyle") = "outside"

        End If
    End Sub
End Class