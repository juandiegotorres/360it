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
        Dim gbProductos As System.Windows.Forms.GroupBox
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvProductosLista = New System.Windows.Forms.DataGridView()
        Me.idProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcaProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modeloProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadProductoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCostoLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioVentaLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbBuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbFormPago = New System.Windows.Forms.ComboBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblRecargo = New System.Windows.Forms.Label()
        Me.rbRecargoPorcentaje = New System.Windows.Forms.RadioButton()
        Me.rbRecargoPlata = New System.Windows.Forms.RadioButton()
        Me.rbDescuentoPorcentaje = New System.Windows.Forms.RadioButton()
        Me.rbDescuentoPlata = New System.Windows.Forms.RadioButton()
        Me.dgvCarrito = New System.Windows.Forms.DataGridView()
        Me.idProductoCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcaCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modeloCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotalCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioVentaCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCostoCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminarDGV = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.idProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        gbProductos = New System.Windows.Forms.GroupBox()
        gbProductos.SuspendLayout()
        CType(Me.dgvProductosLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbProductos
        '
        gbProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        gbProductos.CausesValidation = False
        gbProductos.Controls.Add(Me.Label12)
        gbProductos.Controls.Add(Me.dgvProductosLista)
        gbProductos.Controls.Add(Me.cbBuscarCategoria)
        gbProductos.Controls.Add(Me.TextBox1)
        gbProductos.Controls.Add(Me.Label2)
        gbProductos.Controls.Add(Me.btnAgregar)
        gbProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        gbProductos.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        gbProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        gbProductos.Location = New System.Drawing.Point(34, 82)
        gbProductos.Name = "gbProductos"
        gbProductos.Size = New System.Drawing.Size(469, 506)
        gbProductos.TabIndex = 15
        gbProductos.TabStop = False
        gbProductos.Text = "         "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, -6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 26)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Productos"
        '
        'dgvProductosLista
        '
        Me.dgvProductosLista.AllowUserToAddRows = False
        Me.dgvProductosLista.AllowUserToDeleteRows = False
        Me.dgvProductosLista.AllowUserToOrderColumns = True
        Me.dgvProductosLista.AllowUserToResizeRows = False
        Me.dgvProductosLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosLista.CausesValidation = False
        Me.dgvProductosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductoLista, Me.tipoProductoLista, Me.marcaProductoLista, Me.modeloProductoLista, Me.cantidadProductoLista, Me.precioCostoLista, Me.precioVentaLista})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductosLista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductosLista.Location = New System.Drawing.Point(6, 68)
        Me.dgvProductosLista.MultiSelect = False
        Me.dgvProductosLista.Name = "dgvProductosLista"
        Me.dgvProductosLista.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductosLista.RowHeadersVisible = False
        Me.dgvProductosLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosLista.Size = New System.Drawing.Size(452, 394)
        Me.dgvProductosLista.TabIndex = 21
        '
        'idProductoLista
        '
        Me.idProductoLista.DataPropertyName = "idProducto"
        Me.idProductoLista.HeaderText = "ID"
        Me.idProductoLista.Name = "idProductoLista"
        Me.idProductoLista.ReadOnly = True
        '
        'tipoProductoLista
        '
        Me.tipoProductoLista.DataPropertyName = "tipoProducto"
        Me.tipoProductoLista.HeaderText = "Tipo"
        Me.tipoProductoLista.Name = "tipoProductoLista"
        Me.tipoProductoLista.ReadOnly = True
        '
        'marcaProductoLista
        '
        Me.marcaProductoLista.DataPropertyName = "marca"
        Me.marcaProductoLista.HeaderText = "Marca"
        Me.marcaProductoLista.Name = "marcaProductoLista"
        Me.marcaProductoLista.ReadOnly = True
        '
        'modeloProductoLista
        '
        Me.modeloProductoLista.DataPropertyName = "modelo"
        Me.modeloProductoLista.HeaderText = "Modelo"
        Me.modeloProductoLista.Name = "modeloProductoLista"
        Me.modeloProductoLista.ReadOnly = True
        '
        'cantidadProductoLista
        '
        Me.cantidadProductoLista.DataPropertyName = "cantidad"
        Me.cantidadProductoLista.HeaderText = "Cantidad"
        Me.cantidadProductoLista.Name = "cantidadProductoLista"
        Me.cantidadProductoLista.ReadOnly = True
        '
        'precioCostoLista
        '
        Me.precioCostoLista.DataPropertyName = "precioCosto"
        Me.precioCostoLista.HeaderText = "Precio Costo"
        Me.precioCostoLista.Name = "precioCostoLista"
        Me.precioCostoLista.ReadOnly = True
        Me.precioCostoLista.Visible = False
        '
        'precioVentaLista
        '
        Me.precioVentaLista.DataPropertyName = "precioVenta"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.precioVentaLista.DefaultCellStyle = DataGridViewCellStyle1
        Me.precioVentaLista.HeaderText = "Precio"
        Me.precioVentaLista.Name = "precioVentaLista"
        Me.precioVentaLista.ReadOnly = True
        '
        'cbBuscarCategoria
        '
        Me.cbBuscarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscarCategoria.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscarCategoria.FormattingEnabled = True
        Me.cbBuscarCategoria.Location = New System.Drawing.Point(314, 30)
        Me.cbBuscarCategoria.Name = "cbBuscarCategoria"
        Me.cbBuscarCategoria.Size = New System.Drawing.Size(149, 26)
        Me.cbBuscarCategoria.TabIndex = 20
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
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(6, 468)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(452, 29)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbFormPago)
        Me.GroupBox1.Controls.Add(Me.lblDescuento)
        Me.GroupBox1.Controls.Add(Me.lblRecargo)
        Me.GroupBox1.Controls.Add(Me.rbRecargoPorcentaje)
        Me.GroupBox1.Controls.Add(Me.rbRecargoPlata)
        Me.GroupBox1.Controls.Add(Me.rbDescuentoPorcentaje)
        Me.GroupBox1.Controls.Add(Me.rbDescuentoPlata)
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
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(519, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 462)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                   "
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 21)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Forma pago:"
        '
        'cbFormPago
        '
        Me.cbFormPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFormPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormPago.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormPago.FormattingEnabled = True
        Me.cbFormPago.Location = New System.Drawing.Point(123, 296)
        Me.cbFormPago.Name = "cbFormPago"
        Me.cbFormPago.Size = New System.Drawing.Size(158, 26)
        Me.cbFormPago.TabIndex = 41
        '
        'lblDescuento
        '
        Me.lblDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(101, 335)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(19, 18)
        Me.lblDescuento.TabIndex = 38
        Me.lblDescuento.Text = "%"
        '
        'lblRecargo
        '
        Me.lblRecargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecargo.AutoSize = True
        Me.lblRecargo.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecargo.Location = New System.Drawing.Point(101, 371)
        Me.lblRecargo.Name = "lblRecargo"
        Me.lblRecargo.Size = New System.Drawing.Size(19, 18)
        Me.lblRecargo.TabIndex = 39
        Me.lblRecargo.Text = "%"
        '
        'rbRecargoPorcentaje
        '
        Me.rbRecargoPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbRecargoPorcentaje.AutoSize = True
        Me.rbRecargoPorcentaje.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecargoPorcentaje.Location = New System.Drawing.Point(201, 364)
        Me.rbRecargoPorcentaje.Name = "rbRecargoPorcentaje"
        Me.rbRecargoPorcentaje.Size = New System.Drawing.Size(34, 19)
        Me.rbRecargoPorcentaje.TabIndex = 37
        Me.rbRecargoPorcentaje.TabStop = True
        Me.rbRecargoPorcentaje.Text = "%"
        Me.rbRecargoPorcentaje.UseVisualStyleBackColor = True
        '
        'rbRecargoPlata
        '
        Me.rbRecargoPlata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbRecargoPlata.AutoSize = True
        Me.rbRecargoPlata.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecargoPlata.Location = New System.Drawing.Point(201, 380)
        Me.rbRecargoPlata.Name = "rbRecargoPlata"
        Me.rbRecargoPlata.Size = New System.Drawing.Size(32, 19)
        Me.rbRecargoPlata.TabIndex = 36
        Me.rbRecargoPlata.TabStop = True
        Me.rbRecargoPlata.Text = "$"
        Me.rbRecargoPlata.UseVisualStyleBackColor = True
        '
        'rbDescuentoPorcentaje
        '
        Me.rbDescuentoPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbDescuentoPorcentaje.AutoSize = True
        Me.rbDescuentoPorcentaje.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoPorcentaje.Location = New System.Drawing.Point(201, 326)
        Me.rbDescuentoPorcentaje.Name = "rbDescuentoPorcentaje"
        Me.rbDescuentoPorcentaje.Size = New System.Drawing.Size(34, 19)
        Me.rbDescuentoPorcentaje.TabIndex = 35
        Me.rbDescuentoPorcentaje.TabStop = True
        Me.rbDescuentoPorcentaje.Text = "%"
        Me.rbDescuentoPorcentaje.UseVisualStyleBackColor = True
        '
        'rbDescuentoPlata
        '
        Me.rbDescuentoPlata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbDescuentoPlata.AutoSize = True
        Me.rbDescuentoPlata.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoPlata.Location = New System.Drawing.Point(201, 342)
        Me.rbDescuentoPlata.Name = "rbDescuentoPlata"
        Me.rbDescuentoPlata.Size = New System.Drawing.Size(32, 19)
        Me.rbDescuentoPlata.TabIndex = 34
        Me.rbDescuentoPlata.TabStop = True
        Me.rbDescuentoPlata.Text = "$"
        Me.rbDescuentoPlata.UseVisualStyleBackColor = True
        '
        'dgvCarrito
        '
        Me.dgvCarrito.AllowUserToAddRows = False
        Me.dgvCarrito.AllowUserToDeleteRows = False
        Me.dgvCarrito.AllowUserToOrderColumns = True
        Me.dgvCarrito.AllowUserToResizeColumns = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCarrito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarrito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductoCarrito, Me.tipoCarrito, Me.marcaCarrito, Me.modeloCarrito, Me.cantidadCarrito, Me.precioTotalCarrito, Me.precioVentaCarrito, Me.precioCostoCarrito, Me.btnEliminarDGV})
        Me.dgvCarrito.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCarrito.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCarrito.EnableHeadersVisualStyles = False
        Me.dgvCarrito.Location = New System.Drawing.Point(11, 62)
        Me.dgvCarrito.MultiSelect = False
        Me.dgvCarrito.Name = "dgvCarrito"
        Me.dgvCarrito.ReadOnly = True
        Me.dgvCarrito.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarrito.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCarrito.RowHeadersVisible = False
        Me.dgvCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.dgvCarrito.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCarrito.Size = New System.Drawing.Size(474, 222)
        Me.dgvCarrito.TabIndex = 22
        '
        'idProductoCarrito
        '
        Me.idProductoCarrito.DataPropertyName = "idProducto"
        Me.idProductoCarrito.HeaderText = "ID"
        Me.idProductoCarrito.Name = "idProductoCarrito"
        Me.idProductoCarrito.ReadOnly = True
        Me.idProductoCarrito.Visible = False
        '
        'tipoCarrito
        '
        Me.tipoCarrito.DataPropertyName = "tipo"
        Me.tipoCarrito.HeaderText = "Tipo"
        Me.tipoCarrito.Name = "tipoCarrito"
        Me.tipoCarrito.ReadOnly = True
        '
        'marcaCarrito
        '
        Me.marcaCarrito.DataPropertyName = "marca"
        Me.marcaCarrito.HeaderText = "Marca"
        Me.marcaCarrito.Name = "marcaCarrito"
        Me.marcaCarrito.ReadOnly = True
        '
        'modeloCarrito
        '
        Me.modeloCarrito.DataPropertyName = "modelo"
        Me.modeloCarrito.HeaderText = "Modelo"
        Me.modeloCarrito.Name = "modeloCarrito"
        Me.modeloCarrito.ReadOnly = True
        '
        'cantidadCarrito
        '
        Me.cantidadCarrito.DataPropertyName = "cantidadSeleccionada"
        Me.cantidadCarrito.HeaderText = "Cantidad"
        Me.cantidadCarrito.Name = "cantidadCarrito"
        Me.cantidadCarrito.ReadOnly = True
        '
        'precioTotalCarrito
        '
        Me.precioTotalCarrito.DataPropertyName = "precioTotal"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.precioTotalCarrito.DefaultCellStyle = DataGridViewCellStyle6
        Me.precioTotalCarrito.HeaderText = "Precio"
        Me.precioTotalCarrito.Name = "precioTotalCarrito"
        Me.precioTotalCarrito.ReadOnly = True
        '
        'precioVentaCarrito
        '
        Me.precioVentaCarrito.DataPropertyName = "precioVenta"
        Me.precioVentaCarrito.HeaderText = "Precio Venta"
        Me.precioVentaCarrito.Name = "precioVentaCarrito"
        Me.precioVentaCarrito.ReadOnly = True
        Me.precioVentaCarrito.Visible = False
        '
        'precioCostoCarrito
        '
        Me.precioCostoCarrito.DataPropertyName = "precioCosto"
        Me.precioCostoCarrito.HeaderText = "Precio Costo"
        Me.precioCostoCarrito.Name = "precioCostoCarrito"
        Me.precioCostoCarrito.ReadOnly = True
        Me.precioCostoCarrito.Visible = False
        '
        'btnEliminarDGV
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "Eliminar"
        Me.btnEliminarDGV.DefaultCellStyle = DataGridViewCellStyle7
        Me.btnEliminarDGV.HeaderText = "Eliminar"
        Me.btnEliminarDGV.Name = "btnEliminarDGV"
        Me.btnEliminarDGV.ReadOnly = True
        Me.btnEliminarDGV.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnEliminarDGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnEliminarDGV.Text = "Eliminar"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 21)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Recargo:"
        '
        'txtRecargo
        '
        Me.txtRecargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecargo.Enabled = False
        Me.txtRecargo.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(123, 368)
        Me.txtRecargo.MaxLength = 9
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(73, 26)
        Me.txtRecargo.TabIndex = 31
        '
        'txtFecha
        '
        Me.txtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFecha.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(353, 30)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(132, 26)
        Me.txtFecha.TabIndex = 29
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(288, 33)
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
        Me.txtNroVenta.Size = New System.Drawing.Size(126, 26)
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
        Me.btnCuentaCorriente.Location = New System.Drawing.Point(6, 418)
        Me.btnCuentaCorriente.Name = "btnCuentaCorriente"
        Me.btnCuentaCorriente.Size = New System.Drawing.Size(237, 38)
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
        Me.btnVender.Location = New System.Drawing.Point(248, 418)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(237, 38)
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
        Me.Label5.Location = New System.Drawing.Point(7, 335)
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
        Me.Label4.Location = New System.Drawing.Point(299, 374)
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
        Me.Label3.Location = New System.Drawing.Point(272, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Subtotal:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.BackColor = System.Drawing.Color.White
        Me.txtDescuento.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(123, 332)
        Me.txtDescuento.MaxLength = 9
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(73, 26)
        Me.txtDescuento.TabIndex = 24
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(364, 335)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(121, 26)
        Me.txtSubtotal.TabIndex = 23
        Me.txtSubtotal.Text = "0"
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(364, 371)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(121, 26)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(350, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 18)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "$"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(350, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, -6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 26)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Venta"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(525, 550)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(479, 38)
        Me.btnLimpiar.TabIndex = 29
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'idProduct
        '
        Me.idProduct.DataPropertyName = "idProducto"
        Me.idProduct.HeaderText = "ID"
        Me.idProduct.Name = "idProduct"
        Me.idProduct.Width = 75
        '
        'frmFacturacion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1035, 600)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(gbProductos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFacturacion"
        Me.Text = "Form1"
        gbProductos.ResumeLayout(False)
        gbProductos.PerformLayout()
        CType(Me.dgvProductosLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCuentaCorriente As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNroVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRecargo As TextBox
    Public WithEvents dgvCarrito As DataGridView
    Friend WithEvents idProduct As DataGridViewTextBoxColumn
    Friend WithEvents dgvProductosLista As DataGridView
    Friend WithEvents cbBuscarCategoria As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents idProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents tipoProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents marcaProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents modeloProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents cantidadProductoLista As DataGridViewTextBoxColumn
    Friend WithEvents precioCostoLista As DataGridViewTextBoxColumn
    Friend WithEvents precioVentaLista As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents rbDescuentoPlata As RadioButton
    Friend WithEvents rbRecargoPorcentaje As RadioButton
    Friend WithEvents rbRecargoPlata As RadioButton
    Friend WithEvents rbDescuentoPorcentaje As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblRecargo As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbFormPago As ComboBox
    Friend WithEvents idProductoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents tipoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents marcaCarrito As DataGridViewTextBoxColumn
    Friend WithEvents modeloCarrito As DataGridViewTextBoxColumn
    Friend WithEvents cantidadCarrito As DataGridViewTextBoxColumn
    Friend WithEvents precioTotalCarrito As DataGridViewTextBoxColumn
    Friend WithEvents precioVentaCarrito As DataGridViewTextBoxColumn
    Friend WithEvents precioCostoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminarDGV As DataGridViewButtonColumn
End Class
