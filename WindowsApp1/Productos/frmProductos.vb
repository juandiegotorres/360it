Public Class frmProductos
    Public eProducto As New Entidades.Producto
    Dim bsProductos As New BindingSource
    Dim filtroBS As String
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
        frmNuevoProducto.Show()
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarProductos()
    End Sub
    Public Sub actualizarProductos()
        Dim tabla As New DataTable
        eProducto.recuperarProductos(tabla)
        bsProductos.DataSource = tabla
        dgvProductos.DataSource = bsProductos
    End Sub

    Private Sub btnAgregar_Click_2(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmPrincipal.Hide()
        Dim nuevoProducto As New frmNuevoProducto
        nuevoProducto.ShowDialog()
        If nuevoProducto.DialogResult = DialogResult.OK Then
            frmPrincipal.Show()
            actualizarProductos()
        End If
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        eProducto.idProducto = dgvProductos.CurrentRow.Cells("id").Value
        If MsgBox("¿Desea dar de baja este producto?", MsgBoxStyle.YesNo, "Productos") = MsgBoxResult.Yes Then
            eProducto.bajaProducto()
            actualizarProductos()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
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

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub
End Class