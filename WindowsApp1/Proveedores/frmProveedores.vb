Public Class frmProveedores
    Dim bsProveedores As New BindingSource
    Dim filtroBS As String

    Public eProveedor As New Entidades.Proveedor
    Private _producto As Boolean
    Public Property producto As Boolean
        Set(value As Boolean)
            _producto = value
        End Set
        Get
            Return _producto
        End Get
    End Property
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarProveedores()
        eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
        actualizarRubros()

        If producto = True Then
            picCerrar.Visible = True
            ' btnAgregarSeleccionar.Text = "Aceptar"
            btnModificar.Visible = False
            ' btnBajaCancelar.Text = "Cancelar"
            pnlHeader.Visible = True
        End If
    End Sub


    Public Sub actualizarProveedores()
        Dim tabla As New DataTable
        eProveedor.recuperarProveedores(tabla)
        bsProveedores.DataSource = tabla
        dgvProveedores.DataSource = bsProveedores
    End Sub
    'Dim a As UInt16 = dgvProveedores.Width
    Public Sub actualizarRubros()
        Dim tabla As New DataTable
        eProveedor.verRubrosProveedor(tabla)
        dgvRubros.DataSource = tabla
        dgvRubros.ClearSelection()
    End Sub

    'Private Sub BtnVerRubros_Click(sender As Object, e As EventArgs)
    '    If dgvRubros.Visible = False Then
    '        eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
    '        dgvProveedores.Width = 790%
    '        dgvRubros.Visible = True
    '        btnOcultarRubros.Visible = True
    '        actualizarRubros()
    '    Else
    '        eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
    '        dgvProveedores.Width = 1000%
    '        dgvRubros.Visible = False
    '        btnOcultarRubros.Visible = False

    '    End If

    'End Sub

    Private Sub picCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmNuevoProducto.Show()
    End Sub


    'Private Sub BtnAgregar2_Click(sender As Object, e As EventArgs)
    '    frmPrincipal.Hide()
    '    Dim nuevoProovedor As New frmNuevoProveedor
    '    nuevoProovedor.ShowDialog()
    '    If nuevoProovedor.DialogResult = DialogResult.OK Then
    '        frmPrincipal.Show()
    '    End If
    'End Sub





    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtroBS = "nombreProveedor like '%" & txtBuscar.Text & "%'"
        bsProveedores.Filter = filtroBS
    End Sub

    Private Sub dgvProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idProveedor").Value
        actualizarRubros()
    End Sub

    Private Sub btnAgregarSeleccionar_Click(sender As Object, e As EventArgs) Handles btnAgregarSeleccionar.Click
        If producto = True Then
            If dgvProveedores.CurrentRow.Selected = False Then
                MsgBox("No ha seleccionado ningún cliente", MsgBoxStyle.Exclamation, "Proveedores")
            Else
                eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
                eProveedor.nombre = dgvProveedores.CurrentRow.Cells("nombre").Value
                Me.DialogResult = DialogResult.OK
            End If
        Else
            frmPrincipal.Hide()
            Dim nuevoProveedor As New frmNuevoProveedor
            nuevoProveedor.ShowDialog()
            If nuevoProveedor.DialogResult = DialogResult.OK Then
                frmPrincipal.Show()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
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

    Private Sub btnBajaCancelar_Click(sender As Object, e As EventArgs) Handles btnBajaCancelar.Click
        If producto = True Then
            Me.Close()
            frmNuevoProducto.Show()
        Else
            If MsgBox("¿Desea dar de baja este proveedor?", MsgBoxStyle.YesNo, "Proveedores") = MsgBoxResult.Yes Then
                eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
                eProveedor.bajaProveedor()
                actualizarProveedores()
            End If
        End If
    End Sub
End Class