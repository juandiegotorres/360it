Public Class frmProveedores
    Public eProveedor As New Entidades.Proveedor
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmPrincipal.Hide()
        Dim nuevoProovedor As New frmNuevoProveedor
        nuevoProovedor.ShowDialog()
        If nuevoProovedor.DialogResult = DialogResult.OK Then
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarProveedores()
    End Sub
    Public Sub actualizarProveedores()
        Dim tabla As New DataTable
        eProveedor.recuperarProveedores(tabla)
        dgvProveedores.DataSource = tabla
        dgvProveedores.ClearSelection()
    End Sub
    'Dim a As UInt16 = dgvProveedores.Width
    Public Sub actualizarRubros()
        Dim tabla As New DataTable
        eProveedor.verRubrosProveedor(tabla)
        dgvRubros.DataSource = tabla
        dgvRubros.ClearSelection()
    End Sub



    Private Sub dgvProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idProveedor").Value
        actualizarRubros()
    End Sub

    Private Sub BtnOcultarRubros_Click(sender As Object, e As EventArgs) Handles btnOcultarRubros.Click
        dgvProveedores.Width = 1000%
        dgvRubros.Visible = False
        btnOcultarRubros.Visible = False
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim modificarProveedor As New frmNuevoProveedor
        frmPrincipal.Hide()
        modificarProveedor.eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
        With modificarProveedor
            .modificar = True
            .ShowDialog()
            If DialogResult.OK Then
                actualizarProveedores()
            End If
        End With
        frmPrincipal.Show()
    End Sub

    Private Sub BtnBajaCliente_Click(sender As Object, e As EventArgs) Handles btnBajaCliente.Click
        If MsgBox("¿Desea dar de baja este proveedor?", MsgBoxStyle.YesNo, "Proveedores") = MsgBoxResult.Yes Then
            eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
            eProveedor.bajaProveedor()
            actualizarProveedores()
        End If
    End Sub

    Private Sub BtnVerRubros_Click(sender As Object, e As EventArgs) Handles btnVerRubros.Click
        eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
        dgvProveedores.Width = 750%
        dgvRubros.Visible = True
        btnOcultarRubros.Visible = True
        actualizarRubros()

    End Sub
End Class