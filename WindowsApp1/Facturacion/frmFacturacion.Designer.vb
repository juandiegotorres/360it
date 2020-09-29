<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturacion
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim gbProductos As System.Windows.Forms.GroupBox
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCarrito = New System.Windows.Forms.DataGridView()
        Me.idProductoCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcaCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modeloCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCostoCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNroVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCuentaCorriente = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.idProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbBuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.precioVentaLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCostoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modeloProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcaProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvProductosLista = New System.Windows.Forms.DataGridView()
        gbProductos = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        gbProductos.SuspendLayout()
        CType(Me.dgvProductosLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 75)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "FACTURACIÓN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvCarrito)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtRecargo)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNroVenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCuentaCorriente)
        Me.GroupBox1.Controls.Add(Me.btnVender)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDescuento)
        Me.GroupBox1.Controls.Add(Me.txtSubtotal)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(541, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 462)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Venta"
        '
        'dgvCarrito
        '
        Me.dgvCarrito.AllowUserToAddRows = False
        Me.dgvCarrito.AllowUserToDeleteRows = False
        Me.dgvCarrito.AllowUserToOrderColumns = True
        Me.dgvCarrito.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCarrito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarrito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductoCarrito, Me.tipoCarrito, Me.marcaCarrito, Me.modeloCarrito, Me.cantidadCarrito, Me.precioCostoCarrito, Me.precioCarrito})
        Me.dgvCarrito.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCarrito.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCarrito.EnableHeadersVisualStyles = False
        Me.dgvCarrito.Location = New System.Drawing.Point(11, 62)
        Me.dgvCarrito.MultiSelect = False
        Me.dgvCarrito.Name = "dgvCarrito"
        Me.dgvCarrito.ReadOnly = True
        Me.dgvCarrito.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarrito.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCarrito.RowHeadersVisible = False
        Me.dgvCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvCarrito.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCarrito.Size = New System.Drawing.Size(452, 262)
        Me.dgvCarrito.TabIndex = 22
        '
        'idProductoCarrito
        '
        Me.idProductoCarrito.DataPropertyName = "precioCostoo"
        Me.idProductoCarrito.HeaderText = "ID"
        Me.idProductoCarrito.Name = "idProductoCarrito"
        Me.idProductoCarrito.ReadOnly = True
        '
        'tipoCarrito
        '
        Me.tipoCarrito.HeaderText = "Tipo"
        Me.tipoCarrito.Name = "tipoCarrito"
        Me.tipoCarrito.ReadOnly = True
        '
        'marcaCarrito
        '
        Me.marcaCarrito.HeaderText = "Marca"
        Me.marcaCarrito.Name = "marcaCarrito"
        Me.marcaCarrito.ReadOnly = True
        '
        'modeloCarrito
        '
        Me.modeloCarrito.HeaderText = "Modelo"
        Me.modeloCarrito.Name = "modeloCarrito"
        Me.modeloCarrito.ReadOnly = True
        '
        'cantidadCarrito
        '
        Me.cantidadCarrito.HeaderText = "Cantidad"
        Me.cantidadCarrito.Name = "cantidadCarrito"
        Me.cantidadCarrito.ReadOnly = True
        '
        'precioCostoCarrito
        '
        Me.precioCostoCarrito.HeaderText = "Precio Costo"
        Me.precioCostoCarrito.Name = "precioCostoCarrito"
        Me.precioCostoCarrito.ReadOnly = True
        Me.precioCostoCarrito.Visible = False
        '
        'precioCarrito
        '
        Me.precioCarrito.HeaderText = "Precio"
        Me.precioCarrito.Name = "precioCarrito"
        Me.precioCarrito.ReadOnly = True
        Me.precioCarrito.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(40, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 21)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Recargo:"
        '
        'txtRecargo
        '
        Me.txtRecargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecargo.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(140, 373)
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(67, 26)
        Me.txtRecargo.TabIndex = 31
        '
        'txtFecha
        '
        Me.txtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFecha.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(331, 30)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(118, 26)
        Me.txtFecha.TabIndex = 29
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(266, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Fecha:"
        '
        'txtNroVenta
        '
        Me.txtNroVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNroVenta.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroVenta.Location = New System.Drawing.Point(103, 30)
        Me.txtNroVenta.Name = "txtNroVenta"
        Me.txtNroVenta.ReadOnly = True
        Me.txtNroVenta.Size = New System.Drawing.Size(104, 26)
        Me.txtNroVenta.TabIndex = 21
        Me.txtNroVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Nro. Venta:"
        '
        'btnCuentaCorriente
        '
        Me.btnCuentaCorriente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentaCorriente.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuentaCorriente.ForeColor = System.Drawing.Color.Black
        Me.btnCuentaCorriente.Location = New System.Drawing.Point(11, 418)
        Me.btnCuentaCorriente.Name = "btnCuentaCorriente"
        Me.btnCuentaCorriente.Size = New System.Drawing.Size(236, 38)
        Me.btnCuentaCorriente.TabIndex = 28
        Me.btnCuentaCorriente.Text = "Cuenta corriente"
        Me.btnCuentaCorriente.UseVisualStyleBackColor = True
        '
        'btnVender
        '
        Me.btnVender.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVender.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVender.ForeColor = System.Drawing.Color.Black
        Me.btnVender.Location = New System.Drawing.Point(253, 418)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(210, 38)
        Me.btnVender.TabIndex = 27
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(40, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Descuento:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(232, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(231, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Subtotal:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(140, 341)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(67, 26)
        Me.txtDescuento.TabIndex = 24
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(331, 341)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(121, 26)
        Me.txtSubtotal.TabIndex = 23
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(331, 373)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(121, 26)
        Me.txtTotal.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(552, 550)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(452, 38)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'idProduct
        '
        Me.idProduct.DataPropertyName = "idProducto"
        Me.idProduct.HeaderText = "ID"
        Me.idProduct.Name = "idProduct"
        Me.idProduct.Width = 75
        '
        'gbProductos
        '
        gbProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        gbProductos.CausesValidation = False
        gbProductos.Controls.Add(Me.dgvProductosLista)
        gbProductos.Controls.Add(Me.cbBuscarCategoria)
        gbProductos.Controls.Add(Me.TextBox1)
        gbProductos.Controls.Add(Me.Label2)
        gbProductos.Controls.Add(Me.btnAgregar)
        gbProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        gbProductos.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        gbProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        gbProductos.Location = New System.Drawing.Point(34, 82)
        gbProductos.Name = "gbProductos"
        gbProductos.Size = New System.Drawing.Size(469, 506)
        gbProductos.TabIndex = 15
        gbProductos.TabStop = False
        gbProductos.Text = "Productos"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(11, 468)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(452, 29)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(77, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 26)
        Me.TextBox1.TabIndex = 19
        '
        'cbBuscarCategoria
        '
        Me.cbBuscarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBuscarCategoria.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscarCategoria.FormattingEnabled = True
        Me.cbBuscarCategoria.Location = New System.Drawing.Point(314, 30)
        Me.cbBuscarCategoria.Name = "cbBuscarCategoria"
        Me.cbBuscarCategoria.Size = New System.Drawing.Size(149, 26)
        Me.cbBuscarCategoria.TabIndex = 20
        '
        'precioVentaLista
        '
        Me.precioVentaLista.DataPropertyName = "precioVenta"
        Me.precioVentaLista.HeaderText = "Precio"
        Me.precioVentaLista.Name = "precioVentaLista"
        Me.precioVentaLista.ReadOnly = True
        '
        'precioCostoLista
        '
        Me.precioCostoLista.DataPropertyName = "precioCosto"
        Me.precioCostoLista.HeaderText = "Precio Costo"
        Me.precioCostoLista.Name = "precioCostoLista"
        Me.precioCostoLista.ReadOnly = True
        Me.precioCostoLista.Visible = False
        '
        'cantidadProductoLista
        '
        Me.cantidadProductoLista.DataPropertyName = "cantidad"
        Me.cantidadProductoLista.HeaderText = "Cantidad"
        Me.cantidadProductoLista.Name = "cantidadProductoLista"
        Me.cantidadProductoLista.ReadOnly = True
        '
        'modeloProductoLista
        '
        Me.modeloProductoLista.DataPropertyName = "modelo"
        Me.modeloProductoLista.HeaderText = "Modelo"
        Me.modeloProductoLista.Name = "modeloProductoLista"
        Me.modeloProductoLista.ReadOnly = True
        '
        'marcaProductoLista
        '
        Me.marcaProductoLista.DataPropertyName = "marca"
        Me.marcaProductoLista.HeaderText = "Marca"
        Me.marcaProductoLista.Name = "marcaProductoLista"
        Me.marcaProductoLista.ReadOnly = True
        '
        'tipoProductoLista
        '
        Me.tipoProductoLista.DataPropertyName = "tipoProducto"
        Me.tipoProductoLista.HeaderText = "Tipo"
        Me.tipoProductoLista.Name = "tipoProductoLista"
        Me.tipoProductoLista.ReadOnly = True
        '
        'idProductoLista
        '
        Me.idProductoLista.DataPropertyName = "idProducto"
        Me.idProductoLista.HeaderText = "ID"
        Me.idProductoLista.Name = "idProductoLista"
        Me.idProductoLista.ReadOnly = True
        '
        'dgvProductosLista
        '
        Me.dgvProductosLista.AllowUserToAddRows = False
        Me.dgvProductosLista.AllowUserToDeleteRows = False
        Me.dgvProductosLista.AllowUserToOrderColumns = True
        Me.dgvProductosLista.AllowUserToResizeRows = False
        Me.dgvProductosLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosLista.CausesValidation = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProductosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductoLista, Me.tipoProductoLista, Me.marcaProductoLista, Me.modeloProductoLista, Me.cantidadProductoLista, Me.precioCostoLista, Me.precioVentaLista})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductosLista.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProductosLista.Location = New System.Drawing.Point(6, 68)
        Me.dgvProductosLista.MultiSelect = False
        Me.dgvProductosLista.Name = "dgvProductosLista"
        Me.dgvProductosLista.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProductosLista.RowHeadersVisible = False
        Me.dgvProductosLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosLista.Size = New System.Drawing.Size(452, 394)
        Me.dgvProductosLista.TabIndex = 21
        '
        'frmFacturacion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1035, 600)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(gbProductos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFacturacion"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        gbProductos.ResumeLayout(False)
        gbProductos.PerformLayout()
        CType(Me.dgvProductosLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCuentaCorriente As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNroVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRecargo As TextBox
    Public WithEvents dgvCarrito As DataGridView
    Friend WithEvents idProduct As DataGridViewTextBoxColumn
    Friend WithEvents idProductoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents tipoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents marcaCarrito As DataGridViewTextBoxColumn
    Friend WithEvents modeloCarrito As DataGridViewTextBoxColumn
    Friend WithEvents cantidadCarrito As DataGridViewTextBoxColumn
    Friend WithEvents precioCostoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents precioCarrito As DataGridViewTextBoxColumn
    Friend WithEvents dgvProductosLista As DataGridView
    Friend WithEvents idProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents tipoProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents marcaProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents modeloProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents cantidadProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents precioCostoLista As DataGridViewTextBoxColumn
    Friend WithEvents precioVentaLista As DataGridViewTextBoxColumn
    Friend WithEvents cbBuscarCategoria As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
End Class
