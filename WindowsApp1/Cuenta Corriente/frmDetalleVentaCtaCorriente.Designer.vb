<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalleVentaCtaCorriente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVentaCtaCorriente))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(537, 10)
        Me.pnlHeader.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 44)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Detalle de venta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 26)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "ID Venta: "
        '
        'txtIDVenta
        '
        Me.txtIDVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDVenta.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDVenta.Location = New System.Drawing.Point(138, 80)
        Me.txtIDVenta.MaxLength = 45
        Me.txtIDVenta.Name = "txtIDVenta"
        Me.txtIDVenta.ReadOnly = True
        Me.txtIDVenta.Size = New System.Drawing.Size(113, 28)
        Me.txtIDVenta.TabIndex = 39
        Me.txtIDVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Productos: "
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToOrderColumns = True
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductos.CausesValidation = False
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.marca, Me.modelo, Me.cantidad, Me.precio})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.Location = New System.Drawing.Point(24, 168)
        Me.dgvProductos.Margin = New System.Windows.Forms.Padding(20, 5, 18, 0)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(486, 239)
        Me.dgvProductos.TabIndex = 50
        '
        'idProducto
        '
        Me.idProducto.DataPropertyName = "producto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.idProducto.DefaultCellStyle = DataGridViewCellStyle2
        Me.idProducto.HeaderText = "    ID"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Width = 59
        '
        'marca
        '
        Me.marca.DataPropertyName = "marca"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.marca.DefaultCellStyle = DataGridViewCellStyle3
        Me.marca.HeaderText = "    Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 120
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "modelo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.modelo.DefaultCellStyle = DataGridViewCellStyle4
        Me.modelo.HeaderText = "      Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        Me.modelo.Width = 121
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 75
        '
        'precio
        '
        Me.precio.DataPropertyName = "precioProducto"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.precio.DefaultCellStyle = DataGridViewCellStyle6
        Me.precio.HeaderText = "Precio unitario"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 110
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 26)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Descuento: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(289, 467)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 26)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Recargo: "
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubtotal.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(355, 513)
        Me.txtSubtotal.MaxLength = 45
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(155, 28)
        Me.txtSubtotal.TabIndex = 54
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 514)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 26)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Subtotal: "
        '
        'txtDescuento
        '
        Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuento.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(158, 466)
        Me.txtDescuento.MaxLength = 45
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(110, 28)
        Me.txtDescuento.TabIndex = 55
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRecargo
        '
        Me.txtRecargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecargo.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(400, 466)
        Me.txtRecargo.MaxLength = 45
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.ReadOnly = True
        Me.txtRecargo.Size = New System.Drawing.Size(110, 28)
        Me.txtRecargo.TabIndex = 56
        Me.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Moccasin
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(355, 560)
        Me.txtTotal.MaxLength = 45
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(155, 28)
        Me.txtTotal.TabIndex = 58
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(284, 561)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 26)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Total: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(257, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 26)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Fecha: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 26)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Forma de pago: "
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormaPago.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaPago.Location = New System.Drawing.Point(213, 419)
        Me.txtFormaPago.MaxLength = 45
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(297, 28)
        Me.txtFormaPago.TabIndex = 61
        Me.txtFormaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFecha
        '
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(350, 82)
        Me.txtFecha.MaxLength = 45
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(160, 26)
        Me.txtFecha.TabIndex = 62
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.Image = Global.WindowsApp1.My.Resources.Resources.close
        Me.btnCerrar.Location = New System.Drawing.Point(510, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(27, 26)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 63
        Me.btnCerrar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'frmDetalleVentaCtaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 607)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtFormaPago)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRecargo)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIDVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmDetalleVentaCtaCorriente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleVenta"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIDVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFormaPago As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
End Class
