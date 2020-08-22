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
        If producto = True Then
            'btnAgregar2.Visible = True
            picCerrar.Visible = True
            btnAgregar.Visible = False
            btnBajaCliente.Visible = False
            btnModificar.Visible = False
            btnAceptar.Visible = True
            btnCancelar.Visible = True
            pnlHeader.Visible = True
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmPrincipal.Hide()
        Dim nuevoProovedor As New frmNuevoProveedor
        nuevoProovedor.ShowDialog()
        If nuevoProovedor.DialogResult = DialogResult.OK Then
            frmPrincipal.Show()
        End If
    End Sub

    Public Sub actualizarProveedores()
        Dim tabla As New DataTable
        eProveedor.recuperarProveedores(tabla)
        bsProveedores.DataSource = tabla
        dgvProveedores.DataSource = bsProveedores
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
        If dgvRubros.Visible = False Then
            eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
            dgvProveedores.Width = 790%
            dgvRubros.Visible = True
            btnOcultarRubros.Visible = True
            actualizarRubros()
        Else
            eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
            dgvProveedores.Width = 1000%
            dgvRubros.Visible = False
            btnOcultarRubros.Visible = False

        End If


    End Sub

    Private Sub picCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmNuevoProducto.Show()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If dgvProveedores.CurrentRow.Selected = False Then
            MsgBox("No ha seleccionado ningún cliente", MsgBoxStyle.Exclamation, "Proveedores")
        Else
            eProveedor.idProveedor = dgvProveedores.CurrentRow.Cells("idproveedor").Value
            eProveedor.nombre = dgvProveedores.CurrentRow.Cells("nombre").Value
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        filtroBS = "nombreProveedor like '%" & txtBuscar.Text & "%'"
        bsProveedores.Filter = filtroBS
    End Sub

    Private Sub BtnAgregar2_Click(sender As Object, e As EventArgs)
        frmPrincipal.Hide()
        Dim nuevoProovedor As New frmNuevoProveedor
        nuevoProovedor.ShowDialog()
        If nuevoProovedor.DialogResult = DialogResult.OK Then
            frmPrincipal.Show()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class