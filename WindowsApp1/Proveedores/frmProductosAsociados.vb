Public Class frmProductosAsociados
    Dim eProductos As New Entidades.Producto
    Dim tablaProductos As New DataTable
    Dim id_proveedor As UInt64
    Public Sub New(ByRef idProveedor As UInt64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        id_proveedor = idProveedor
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmProductosAsociados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarProductos()
    End Sub
    Public Sub actualizarProductos()
        tablaProductos.Clear()
        eProductos.recuperarProductosXProveedor(tablaProductos, id_proveedor)
        dgvProductos.DataSource = tablaProductos
    End Sub

    Private Sub frmProductosAsociados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Me.Close()
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub picCerrar_Click(sender As Object, e As EventArgs) Handles picCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmProductosAsociados_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        MyBase.OnPaintBackground(e)
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)
        e.Graphics.DrawRectangle(Pens.Black, rect)
    End Sub
End Class