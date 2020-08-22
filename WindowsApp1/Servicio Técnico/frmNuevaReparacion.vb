Public Class frmNuevaReparacion
    Dim eServTecnico As New Entidades.ServTecnico
    Private Sub frmNuevaReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipoArticulo()
        estadoArticulo()
    End Sub
    Public Sub tipoArticulo()
        Dim tablaArticulo As New DataTable
        eServTecnico.tipoArticulo(tablaArticulo)
        cbTipoArticulo.DataSource = tablaArticulo
        cbTipoArticulo.DisplayMember = "nombreTipo"
        cbTipoArticulo.ValueMember = "idTipo"
    End Sub
    Public Sub estadoArticulo()
        Dim tablaEstadoArticulo As New DataTable
        eServTecnico.estadoArticulo(tablaEstadoArticulo)
        cbEstado.DataSource = tablaEstadoArticulo
        cbEstado.DisplayMember = "nombre"
        cbEstado.ValueMember = "id"
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim clientes As New frmClientes
        Me.Hide()
        With clientes
            .reparacion = True
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                eServTecnico.idCliente = clientes.eCliente.idCliente
                txtNombreCliente.Text = clientes.eCliente.nombApel
            End If
            If .DialogResult = DialogResult.Cancel Then
                txtNombreCliente.Text = ""
            End If
            Me.Show()
        End With
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
