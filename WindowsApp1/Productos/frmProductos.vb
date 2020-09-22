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
        dgvProductos.ClearSelection()
    End Sub

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmPrincipal.Hide()
        Dim nuevoProducto As New frmNuevoProducto
        nuevoProducto.ShowDialog()
        If nuevoProducto.DialogResult = DialogResult.OK Then
            frmPrincipal.Show()
            actualizarProductos()
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtroBS = "modelo like '%" & txtBuscar.Text & "%'"
        bsProductos.Filter = filtroBS
    End Sub
End Class