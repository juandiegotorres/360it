<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClienteCtaCorriente = New System.Windows.Forms.TextBox()
        Me.btnCancelarCtaCorriente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(441, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(335, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad de ventas en un año:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "5 Productos más vendidos:"
        '
        'txtClienteCtaCorriente
        '
        Me.txtClienteCtaCorriente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteCtaCorriente.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteCtaCorriente.Location = New System.Drawing.Point(183, 77)
        Me.txtClienteCtaCorriente.Margin = New System.Windows.Forms.Padding(15, 8, 3, 3)
        Me.txtClienteCtaCorriente.Name = "txtClienteCtaCorriente"
        Me.txtClienteCtaCorriente.ReadOnly = True
        Me.txtClienteCtaCorriente.Size = New System.Drawing.Size(200, 26)
        Me.txtClienteCtaCorriente.TabIndex = 50
        Me.txtClienteCtaCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtClienteCtaCorriente.Visible = False
        '
        'btnCancelarCtaCorriente
        '
        Me.btnCancelarCtaCorriente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelarCtaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarCtaCorriente.Location = New System.Drawing.Point(391, 77)
        Me.btnCancelarCtaCorriente.Margin = New System.Windows.Forms.Padding(5, 8, 3, 6)
        Me.btnCancelarCtaCorriente.Name = "btnCancelarCtaCorriente"
        Me.btnCancelarCtaCorriente.Size = New System.Drawing.Size(23, 26)
        Me.btnCancelarCtaCorriente.TabIndex = 51
        Me.btnCancelarCtaCorriente.Text = "X"
        Me.btnCancelarCtaCorriente.UseVisualStyleBackColor = True
        Me.btnCancelarCtaCorriente.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarCtaCorriente)
        Me.Controls.Add(Me.txtClienteCtaCorriente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtClienteCtaCorriente As Windows.Forms.TextBox
    Friend WithEvents btnCancelarCtaCorriente As Windows.Forms.Button
End Class
