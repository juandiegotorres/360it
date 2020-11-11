<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarCuentaCorriente
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCuotas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEntrega = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.Panel3)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(475, 10)
        Me.pnlHeader.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(21, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 77)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 44)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Cuenta corriente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(399, 71)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(56, 31)
        Me.btnClientes.TabIndex = 52
        Me.btnClientes.Text = "..."
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCliente.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(132, 71)
        Me.txtNombreCliente.MaxLength = 60
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(261, 31)
        Me.txtNombreCliente.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 26)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Cliente:"
        '
        'txtCuotas
        '
        Me.txtCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuotas.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotas.Location = New System.Drawing.Point(132, 127)
        Me.txtCuotas.MaxLength = 2
        Me.txtCuotas.Name = "txtCuotas"
        Me.txtCuotas.Size = New System.Drawing.Size(90, 31)
        Me.txtCuotas.TabIndex = 53
        Me.txtCuotas.Text = "1"
        Me.txtCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 26)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Cuotas:"
        '
        'txtEntrega
        '
        Me.txtEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEntrega.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrega.Location = New System.Drawing.Point(132, 185)
        Me.txtEntrega.MaxLength = 60
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(132, 31)
        Me.txtEntrega.TabIndex = 55
        Me.txtEntrega.Text = "0"
        Me.txtEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 26)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Entrega:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.Image = Global.WindowsApp1.My.Resources.Resources.close
        Me.btnCerrar.Location = New System.Drawing.Point(448, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(27, 26)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 58
        Me.btnCerrar.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 2
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(150, 15)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(150, 15, 150, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(155, 43)
        Me.btnGuardar.TabIndex = 59
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnGuardar, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 235)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(455, 63)
        Me.TableLayoutPanel1.TabIndex = 65
        '
        'frmCargarCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 309)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtEntrega)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCuotas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCargarCuentaCorriente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCuentaCorriente"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClientes As Button
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCuotas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEntrega As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
