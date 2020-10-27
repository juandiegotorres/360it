<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarPrecios
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
        Me.btnDisminuir = New System.Windows.Forms.Button()
        Me.lblAlerta = New System.Windows.Forms.Label()
        Me.btnAumentar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisminuir
        '
        Me.btnDisminuir.Enabled = False
        Me.btnDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisminuir.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisminuir.Location = New System.Drawing.Point(137, 177)
        Me.btnDisminuir.Name = "btnDisminuir"
        Me.btnDisminuir.Size = New System.Drawing.Size(110, 41)
        Me.btnDisminuir.TabIndex = 56
        Me.btnDisminuir.Text = "Disminuir"
        Me.btnDisminuir.UseVisualStyleBackColor = True
        Me.btnDisminuir.Visible = False
        '
        'lblAlerta
        '
        Me.lblAlerta.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerta.ForeColor = System.Drawing.Color.Red
        Me.lblAlerta.Location = New System.Drawing.Point(12, 64)
        Me.lblAlerta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlerta.Name = "lblAlerta"
        Me.lblAlerta.Size = New System.Drawing.Size(367, 45)
        Me.lblAlerta.TabIndex = 55
        Me.lblAlerta.Text = "El precio de todos los productos aumentará el porcentaje que introduzcas aquí ¡Cu" &
    "idado!"
        Me.lblAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAumentar
        '
        Me.btnAumentar.Enabled = False
        Me.btnAumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAumentar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAumentar.Location = New System.Drawing.Point(137, 177)
        Me.btnAumentar.Name = "btnAumentar"
        Me.btnAumentar.Size = New System.Drawing.Size(110, 41)
        Me.btnAumentar.TabIndex = 53
        Me.btnAumentar.Text = "Aumentar"
        Me.btnAumentar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 26)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Porcentaje:   %"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.Location = New System.Drawing.Point(201, 123)
        Me.txtPorcentaje.MaxLength = 2
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(120, 33)
        Me.txtPorcentaje.TabIndex = 51
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.Image = Global.WindowsApp1.My.Resources.Resources.close
        Me.btnCerrar.Location = New System.Drawing.Point(365, 11)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(27, 25)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(392, 10)
        Me.pnlHeader.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 44)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Cambio de precios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCambiarPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 229)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.lblAlerta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAumentar)
        Me.Controls.Add(Me.btnDisminuir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCambiarPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCambiarPrecios"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisminuir As Button
    Friend WithEvents lblAlerta As Label
    Friend WithEvents btnAumentar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label1 As Label
End Class
