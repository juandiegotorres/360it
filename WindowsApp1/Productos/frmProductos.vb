Public Class frmProductos
    Dim cantidadProducto, idProducto As UInt16
    Public eProducto As New Entidades.Producto
    Dim bsProductos As New BindingSource
    Dim filtroBS As String
    Dim tablaProductos As New DataTable
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
        frmNuevoProducto.Show()
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarProductos()
    End Sub
    Public Sub actualizarProductos()
        tablaProductos.Clear()
        bsProductos.Clear()
        eProducto.recuperarProductos(tablaProductos)
        bsProductos.DataSource = tablaProductos
        dgvProductos.DataSource = bsProductos
    End Sub

    Private Sub btnAgregar_Click_2(sender As Object, e As EventArgs)
        frmPrincipal.Hide()
        Dim nuevoProducto As New frmNuevoProducto
        nuevoProducto.ShowDialog()
        If nuevoProducto.DialogResult = DialogResult.OK Then
            frmPrincipal.Show()
            actualizarProductos()
        End If
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs)
        eProducto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
        If MsgBox("¿Desea dar de baja este producto?", MsgBoxStyle.YesNo, "Productos") = MsgBoxResult.Yes Then
            eProducto.bajaProducto()
            actualizarProductos()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
        Dim modificarProducto As New frmNuevoProducto
        modificarProducto.eProducto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
        frmPrincipal.Hide()

        With modificarProducto
            .modificar = True
            .ShowDialog()
            If DialogResult.OK Then
                actualizarProductos()
            End If
        End With
        frmPrincipal.Show()
    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtroBS = "modelo like '%" & txtBuscar.Text & "%'"
        bsProductos.Filter = filtroBS
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        eProducto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
    End Sub

    Private Sub btnDetalleVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarStock.Click
        If dgvProductos.SelectedRows.Count = 1 Then
            cantidadProducto = dgvProductos.CurrentRow.Cells("cantidad").Value
            Dim cantidadAAgregar As New frmMovimientoDeStock(cantidadProducto)
            With cantidadAAgregar
                .quitar = False
                .e_Producto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    actualizarProductos()
                End If
            End With
        End If
    End Sub
    Private Function verSiHayStock()
        For i = 0 To dgvProductos.Rows.Count - 1
            If dgvProductos.Rows(i).Cells("cantidad").Value = 0 Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function

    Private Sub btnSinStock_Click(sender As Object, e As EventArgs) Handles btnSinStock.Click
        If dgvProductos.Rows(0).Cells("cantidad").Value = 0 Then
            bsProductos.Sort = "cantidad DESC"
            btnSinStock.Text = "Productos sin Stock primero"
            ' actualizarProductos()
        Else
            If verSiHayStock() = True Then
                bsProductos.Sort = "cantidad ASC"
                'bsProductos.Sort = "cantidad ASC"
                btnSinStock.Text = "Productos con Stock primero"
            Else
                MsgBox("Actualmente todos los productos tienen stock", MsgBoxStyle.Information, "Productos")
            End If
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If dgvProductos.SelectedRows.Count = 1 Then
            cantidadProducto = dgvProductos.CurrentRow.Cells("cantidad").Value
            Dim cantidadAQuitar As New frmMovimientoDeStock(cantidadProducto)
            With cantidadAQuitar
                .quitar = True
                .e_Producto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    actualizarProductos()
                End If
            End With
        End If
    End Sub
End Class