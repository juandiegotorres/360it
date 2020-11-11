<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarEstado
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
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNotaTecnico = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.Image = Global.WindowsApp1.My.Resources.Resources.close
        Me.btnCerrar.Location = New System.Drawing.Point(491, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(27, 26)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 52
        Me.btnCerrar.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(518, 10)
        Me.pnlHeader.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 42)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Cambiar estado "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 26)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(170, 75)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(281, 34)
        Me.cbEstado.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 26)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Nota del técnico:"
        '
        'txtNotaTecnico
        '
        Me.txtNotaTecnico.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaTecnico.Location = New System.Drawing.Point(69, 181)
        Me.txtNotaTecnico.MaxLength = 209
        Me.txtNotaTecnico.Multiline = True
        Me.txtNotaTecnico.Name = "txtNotaTecnico"
        Me.txtNotaTecnico.Size = New System.Drawing.Size(382, 178)
        Me.txtNotaTecnico.TabIndex = 82
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(204, 378)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 41)
        Me.btnGuardar.TabIndex = 83
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmCambiarEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 431)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtNotaTecnico)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCambiarEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCambiarEstado"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNotaTecnico As TextBox
    Friend WithEvents btnGuardar As Button
End Class
