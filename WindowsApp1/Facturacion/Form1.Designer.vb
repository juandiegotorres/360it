<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbFormPago = New System.Windows.Forms.ComboBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblRecargo = New System.Windows.Forms.Label()
        Me.rbRecargoPorcentaje = New System.Windows.Forms.RadioButton()
        Me.rbRecargoPlata = New System.Windows.Forms.RadioButton()
        Me.rbDescuentoPorcentaje = New System.Windows.Forms.RadioButton()
        Me.rbDescuentoPlata = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(173, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 21)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Forma pago:"
        '
        'cbFormPago
        '
        Me.cbFormPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbFormPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormPago.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormPago.FormattingEnabled = True
        Me.cbFormPago.Location = New System.Drawing.Point(290, 173)
        Me.cbFormPago.Name = "cbFormPago"
        Me.cbFormPago.Size = New System.Drawing.Size(158, 26)
        Me.cbFormPago.TabIndex = 59
        '
        'lblDescuento
        '
        Me.lblDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(267, 213)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(19, 18)
        Me.lblDescuento.TabIndex = 57
        Me.lblDescuento.Text = "%"
        '
        'lblRecargo
        '
        Me.lblRecargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRecargo.AutoSize = True
        Me.lblRecargo.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecargo.Location = New System.Drawing.Point(267, 249)
        Me.lblRecargo.Name = "lblRecargo"
        Me.lblRecargo.Size = New System.Drawing.Size(19, 18)
        Me.lblRecargo.TabIndex = 58
        Me.lblRecargo.Text = "%"
        '
        'rbRecargoPorcentaje
        '
        Me.rbRecargoPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbRecargoPorcentaje.AutoSize = True
        Me.rbRecargoPorcentaje.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecargoPorcentaje.Location = New System.Drawing.Point(367, 242)
        Me.rbRecargoPorcentaje.Name = "rbRecargoPorcentaje"
        Me.rbRecargoPorcentaje.Size = New System.Drawing.Size(34, 19)
        Me.rbRecargoPorcentaje.TabIndex = 56
        Me.rbRecargoPorcentaje.TabStop = True
        Me.rbRecargoPorcentaje.Text = "%"
        Me.rbRecargoPorcentaje.UseVisualStyleBackColor = True
        '
        'rbRecargoPlata
        '
        Me.rbRecargoPlata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbRecargoPlata.AutoSize = True
        Me.rbRecargoPlata.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecargoPlata.Location = New System.Drawing.Point(367, 258)
        Me.rbRecargoPlata.Name = "rbRecargoPlata"
        Me.rbRecargoPlata.Size = New System.Drawing.Size(32, 19)
        Me.rbRecargoPlata.TabIndex = 55
        Me.rbRecargoPlata.TabStop = True
        Me.rbRecargoPlata.Text = "$"
        Me.rbRecargoPlata.UseVisualStyleBackColor = True
        '
        'rbDescuentoPorcentaje
        '
        Me.rbDescuentoPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDescuentoPorcentaje.AutoSize = True
        Me.rbDescuentoPorcentaje.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoPorcentaje.Location = New System.Drawing.Point(367, 204)
        Me.rbDescuentoPorcentaje.Name = "rbDescuentoPorcentaje"
        Me.rbDescuentoPorcentaje.Size = New System.Drawing.Size(34, 19)
        Me.rbDescuentoPorcentaje.TabIndex = 54
        Me.rbDescuentoPorcentaje.TabStop = True
        Me.rbDescuentoPorcentaje.Text = "%"
        Me.rbDescuentoPorcentaje.UseVisualStyleBackColor = True
        '
        'rbDescuentoPlata
        '
        Me.rbDescuentoPlata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDescuentoPlata.AutoSize = True
        Me.rbDescuentoPlata.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoPlata.Location = New System.Drawing.Point(367, 220)
        Me.rbDescuentoPlata.Name = "rbDescuentoPlata"
        Me.rbDescuentoPlata.Size = New System.Drawing.Size(32, 19)
        Me.rbDescuentoPlata.TabIndex = 53
        Me.rbDescuentoPlata.TabStop = True
        Me.rbDescuentoPlata.Text = "$"
        Me.rbDescuentoPlata.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(173, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 21)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Recargo:"
        '
        'txtRecargo
        '
        Me.txtRecargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRecargo.Enabled = False
        Me.txtRecargo.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(289, 246)
        Me.txtRecargo.MaxLength = 9
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(74, 26)
        Me.txtRecargo.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(173, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Descuento:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(464, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(437, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Subtotal:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.BackColor = System.Drawing.Color.White
        Me.txtDescuento.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(289, 210)
        Me.txtDescuento.MaxLength = 9
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(74, 26)
        Me.txtDescuento.TabIndex = 46
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(523, 212)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(117, 26)
        Me.txtSubtotal.TabIndex = 45
        Me.txtSubtotal.Text = "0"
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(523, 248)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(117, 26)
        Me.txtTotal.TabIndex = 44
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(510, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 18)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "$"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(510, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 18)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbFormPago)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblRecargo)
        Me.Controls.Add(Me.rbRecargoPorcentaje)
        Me.Controls.Add(Me.rbRecargoPlata)
        Me.Controls.Add(Me.rbDescuentoPorcentaje)
        Me.Controls.Add(Me.rbDescuentoPlata)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRecargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents cbFormPago As ComboBox
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblRecargo As Label
    Friend WithEvents rbRecargoPorcentaje As RadioButton
    Friend WithEvents rbRecargoPlata As RadioButton
    Friend WithEvents rbDescuentoPorcentaje As RadioButton
    Friend WithEvents rbDescuentoPlata As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
