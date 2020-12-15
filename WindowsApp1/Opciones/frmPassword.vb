Public Class frmPassword
    Dim eCapaDatos As New CapaDeNegocios.cdDatosPrueba

    Private Sub chbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles chbMostrar.CheckedChanged
        If chbMostrar.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If eCapaDatos.comprobarPwdEditar(txtPassword.Text) = True Then
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical, "Opciones - Base de Datos")
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnAceptar_Click(btnAceptar, e)
        End If
    End Sub

    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPassword.Text = ""
    End Sub
End Class