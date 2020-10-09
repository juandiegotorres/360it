<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacion
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
        Dim gbProductos As System.Windows.Forms.GroupBox
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.xd = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbFormPago = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.rbRecargoPorcentaje = New System.Windows.Forms.RadioButton()
        Me.rbRecargoPlata = New System.Windows.Forms.RadioButton()
        Me.rbDescuentoPorcentaje = New System.Windows.Forms.RadioButton()
        Me.rbDescuentoPlata = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCuentaCorriente = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnVender = New System.Windows.Forms.Button()
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
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNroVenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        gbProductos = New System.Windows.Forms.GroupBox()
        gbProductos.SuspendLayout()
        CType(Me.dgvProductosLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xd.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbProductos
        '
        gbProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        gbProductos.Location = New System.Drawing.Point(20, 100)
        gbProductos.Margin = New System.Windows.Forms.Padding(20, 14, 3, 6)
        gbProductos.Name = "gbProductos"
        gbProductos.Size = New System.Drawing.Size(473, 455)
        gbProductos.TabIndex = 16
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
        Me.dgvProductosLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductosLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductosLista.CausesValidation = False
        Me.dgvProductosLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle51.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle51.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle51
        Me.dgvProductosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductoLista, Me.tipoProductoLista, Me.marcaProductoLista, Me.modeloProductoLista, Me.cantidadProductoLista, Me.precioCostoLista, Me.precioVentaLista})
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle53.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle53.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle53.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductosLista.DefaultCellStyle = DataGridViewCellStyle53
        Me.dgvProductosLista.EnableHeadersVisualStyles = False
        Me.dgvProductosLista.Location = New System.Drawing.Point(11, 68)
        Me.dgvProductosLista.MultiSelect = False
        Me.dgvProductosLista.Name = "dgvProductosLista"
        Me.dgvProductosLista.ReadOnly = True
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle54.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle54.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle54
        Me.dgvProductosLista.RowHeadersVisible = False
        Me.dgvProductosLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosLista.Size = New System.Drawing.Size(456, 343)
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
        DataGridViewCellStyle52.Format = "C2"
        DataGridViewCellStyle52.NullValue = Nothing
        Me.precioVentaLista.DefaultCellStyle = DataGridViewCellStyle52
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
        Me.cbBuscarCategoria.Location = New System.Drawing.Point(318, 30)
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
        Me.TextBox1.Size = New System.Drawing.Size(226, 26)
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
        Me.btnAgregar.Location = New System.Drawing.Point(11, 417)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(456, 29)
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
        Me.Label1.Margin = New System.Windows.Forms.Padding(21, 9, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 74)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "FACTURACIÓN"
        '
        'xd
        '
        Me.xd.ColumnCount = 3
        Me.xd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.45164!))
        Me.xd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.xd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.54836!))
        Me.xd.Controls.Add(Me.Label1, 0, 0)
        Me.xd.Controls.Add(gbProductos, 0, 1)
        Me.xd.Controls.Add(Me.GroupBox1, 2, 1)
        Me.xd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xd.Location = New System.Drawing.Point(0, 0)
        Me.xd.Name = "xd"
        Me.xd.RowCount = 2
        Me.xd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.02919!))
        Me.xd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.01003!))
        Me.xd.Size = New System.Drawing.Size(1019, 561)
        Me.xd.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbFormPago)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.dgvCarrito)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNroVenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(525, 100)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(14, 14, 20, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(474, 458)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                   "
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(3, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 21)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Forma pago:"
        '
        'cbFormPago
        '
        Me.cbFormPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbFormPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormPago.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormPago.FormattingEnabled = True
        Me.cbFormPago.Location = New System.Drawing.Point(120, 263)
        Me.cbFormPago.Name = "cbFormPago"
        Me.cbFormPago.Size = New System.Drawing.Size(158, 26)
        Me.cbFormPago.TabIndex = 61
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 294)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(468, 87)
        Me.TableLayoutPanel3.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtSubtotal)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(272, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 81)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Subtotal:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(92, 8)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(89, 26)
        Me.txtSubtotal.TabIndex = 55
        Me.txtSubtotal.Text = "0"
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(92, 44)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(89, 26)
        Me.txtTotal.TabIndex = 54
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(79, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 18)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "$"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(79, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 18)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "$"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtRecargo)
        Me.Panel1.Controls.Add(Me.txtDescuento)
        Me.Panel1.Controls.Add(Me.rbRecargoPorcentaje)
        Me.Panel1.Controls.Add(Me.rbRecargoPlata)
        Me.Panel1.Controls.Add(Me.rbDescuentoPorcentaje)
        Me.Panel1.Controls.Add(Me.rbDescuentoPlata)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 81)
        Me.Panel1.TabIndex = 0
        '
        'txtRecargo
        '
        Me.txtRecargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRecargo.Enabled = False
        Me.txtRecargo.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(102, 45)
        Me.txtRecargo.MaxLength = 9
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(73, 26)
        Me.txtRecargo.TabIndex = 61
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.BackColor = System.Drawing.Color.White
        Me.txtDescuento.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(102, 9)
        Me.txtDescuento.MaxLength = 9
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(73, 26)
        Me.txtDescuento.TabIndex = 59
        '
        'rbRecargoPorcentaje
        '
        Me.rbRecargoPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbRecargoPorcentaje.AutoSize = True
        Me.rbRecargoPorcentaje.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecargoPorcentaje.Location = New System.Drawing.Point(177, 41)
        Me.rbRecargoPorcentaje.Name = "rbRecargoPorcentaje"
        Me.rbRecargoPorcentaje.Size = New System.Drawing.Size(34, 19)
        Me.rbRecargoPorcentaje.TabIndex = 66
        Me.rbRecargoPorcentaje.TabStop = True
        Me.rbRecargoPorcentaje.Text = "%"
        Me.rbRecargoPorcentaje.UseVisualStyleBackColor = True
        '
        'rbRecargoPlata
        '
        Me.rbRecargoPlata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbRecargoPlata.AutoSize = True
        Me.rbRecargoPlata.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecargoPlata.Location = New System.Drawing.Point(177, 57)
        Me.rbRecargoPlata.Name = "rbRecargoPlata"
        Me.rbRecargoPlata.Size = New System.Drawing.Size(32, 19)
        Me.rbRecargoPlata.TabIndex = 65
        Me.rbRecargoPlata.TabStop = True
        Me.rbRecargoPlata.Text = "$"
        Me.rbRecargoPlata.UseVisualStyleBackColor = True
        '
        'rbDescuentoPorcentaje
        '
        Me.rbDescuentoPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDescuentoPorcentaje.AutoSize = True
        Me.rbDescuentoPorcentaje.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoPorcentaje.Location = New System.Drawing.Point(177, 3)
        Me.rbDescuentoPorcentaje.Name = "rbDescuentoPorcentaje"
        Me.rbDescuentoPorcentaje.Size = New System.Drawing.Size(34, 19)
        Me.rbDescuentoPorcentaje.TabIndex = 64
        Me.rbDescuentoPorcentaje.TabStop = True
        Me.rbDescuentoPorcentaje.Text = "%"
        Me.rbDescuentoPorcentaje.UseVisualStyleBackColor = True
        '
        'rbDescuentoPlata
        '
        Me.rbDescuentoPlata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbDescuentoPlata.AutoSize = True
        Me.rbDescuentoPlata.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoPlata.Location = New System.Drawing.Point(177, 19)
        Me.rbDescuentoPlata.Name = "rbDescuentoPlata"
        Me.rbDescuentoPlata.Size = New System.Drawing.Size(32, 19)
        Me.rbDescuentoPlata.TabIndex = 63
        Me.rbDescuentoPlata.TabStop = True
        Me.rbDescuentoPlata.Text = "$"
        Me.rbDescuentoPlata.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Descuento:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 21)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Recargo:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnCuentaCorriente, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnLimpiar, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 381)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(468, 36)
        Me.TableLayoutPanel2.TabIndex = 44
        '
        'btnCuentaCorriente
        '
        Me.btnCuentaCorriente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentaCorriente.Font = New System.Drawing.Font("Montserrat SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuentaCorriente.ForeColor = System.Drawing.Color.Black
        Me.btnCuentaCorriente.Location = New System.Drawing.Point(3, 4)
        Me.btnCuentaCorriente.Name = "btnCuentaCorriente"
        Me.btnCuentaCorriente.Size = New System.Drawing.Size(228, 29)
        Me.btnCuentaCorriente.TabIndex = 46
        Me.btnCuentaCorriente.Text = "Cuenta corriente"
        Me.btnCuentaCorriente.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Montserrat SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(237, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(228, 29)
        Me.btnLimpiar.TabIndex = 47
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnVender, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 417)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(468, 35)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'btnVender
        '
        Me.btnVender.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVender.Font = New System.Drawing.Font("Montserrat SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVender.ForeColor = System.Drawing.Color.Black
        Me.btnVender.Location = New System.Drawing.Point(3, 3)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(462, 29)
        Me.btnVender.TabIndex = 45
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'dgvCarrito
        '
        Me.dgvCarrito.AllowUserToAddRows = False
        Me.dgvCarrito.AllowUserToDeleteRows = False
        Me.dgvCarrito.AllowUserToOrderColumns = True
        Me.dgvCarrito.AllowUserToResizeRows = False
        Me.dgvCarrito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle55.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle55.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarrito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle55
        Me.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductoCarrito, Me.tipoCarrito, Me.marcaCarrito, Me.modeloCarrito, Me.cantidadCarrito, Me.precioTotalCarrito, Me.precioVentaCarrito, Me.precioCostoCarrito, Me.btnEliminarDGV})
        Me.dgvCarrito.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle58.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle58.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCarrito.DefaultCellStyle = DataGridViewCellStyle58
        Me.dgvCarrito.EnableHeadersVisualStyles = False
        Me.dgvCarrito.Location = New System.Drawing.Point(6, 62)
        Me.dgvCarrito.MultiSelect = False
        Me.dgvCarrito.Name = "dgvCarrito"
        Me.dgvCarrito.ReadOnly = True
        Me.dgvCarrito.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle59.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle59.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarrito.RowHeadersDefaultCellStyle = DataGridViewCellStyle59
        Me.dgvCarrito.RowHeadersVisible = False
        Me.dgvCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle60.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black
        Me.dgvCarrito.RowsDefaultCellStyle = DataGridViewCellStyle60
        Me.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCarrito.Size = New System.Drawing.Size(461, 190)
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
        DataGridViewCellStyle56.Format = "C2"
        DataGridViewCellStyle56.NullValue = Nothing
        Me.precioTotalCarrito.DefaultCellStyle = DataGridViewCellStyle56
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
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle57.Format = "Eliminar"
        Me.btnEliminarDGV.DefaultCellStyle = DataGridViewCellStyle57
        Me.btnEliminarDGV.HeaderText = "Eliminar"
        Me.btnEliminarDGV.Name = "btnEliminarDGV"
        Me.btnEliminarDGV.ReadOnly = True
        Me.btnEliminarDGV.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnEliminarDGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnEliminarDGV.Text = "Eliminar"
        '
        'txtFecha
        '
        Me.txtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFecha.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(351, 30)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(117, 26)
        Me.txtFecha.TabIndex = 29
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(286, 33)
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
        Me.txtNroVenta.Size = New System.Drawing.Size(109, 26)
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
        'frmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 561)
        Me.Controls.Add(Me.xd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFacturacion"
        Me.Text = "Form1"
        gbProductos.ResumeLayout(False)
        gbProductos.PerformLayout()
        CType(Me.dgvProductosLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xd.ResumeLayout(False)
        Me.xd.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As Label
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
    Friend WithEvents Label1 As Label
    Friend WithEvents xd As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbFormPago As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents rbRecargoPorcentaje As RadioButton
    Friend WithEvents rbRecargoPlata As RadioButton
    Friend WithEvents rbDescuentoPorcentaje As RadioButton
    Friend WithEvents rbDescuentoPlata As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnCuentaCorriente As Button
    Private WithEvents btnLimpiar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnVender As Button
    Public WithEvents dgvCarrito As DataGridView
    Friend WithEvents idProductoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents tipoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents marcaCarrito As DataGridViewTextBoxColumn
    Friend WithEvents modeloCarrito As DataGridViewTextBoxColumn
    Friend WithEvents cantidadCarrito As DataGridViewTextBoxColumn
    Friend WithEvents precioTotalCarrito As DataGridViewTextBoxColumn
    Friend WithEvents precioVentaCarrito As DataGridViewTextBoxColumn
    Friend WithEvents precioCostoCarrito As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminarDGV As DataGridViewButtonColumn
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNroVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
End Class
