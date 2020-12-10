<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVender
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbBuscador = New System.Windows.Forms.ComboBox()
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xd = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbFormPago = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtClienteCtaCorriente = New System.Windows.Forms.TextBox()
        Me.btnCancelarCtaCorriente = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
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
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
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
        gbProductos.CausesValidation = False
        gbProductos.Controls.Add(Me.cbBuscador)
        gbProductos.Controls.Add(Me.Label12)
        gbProductos.Controls.Add(Me.dgvProductosLista)
        gbProductos.Controls.Add(Me.cbBuscarCategoria)
        gbProductos.Controls.Add(Me.txtBuscar)
        gbProductos.Controls.Add(Me.Label2)
        gbProductos.Controls.Add(Me.btnAgregar)
        gbProductos.Dock = System.Windows.Forms.DockStyle.Fill
        gbProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        gbProductos.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        gbProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        gbProductos.Location = New System.Drawing.Point(10, 107)
        gbProductos.Margin = New System.Windows.Forms.Padding(10, 5, 3, 3)
        gbProductos.Name = "gbProductos"
        gbProductos.Size = New System.Drawing.Size(476, 451)
        gbProductos.TabIndex = 16
        gbProductos.TabStop = False
        gbProductos.Text = "         "
        '
        'cbBuscador
        '
        Me.cbBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscador.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscador.FormattingEnabled = True
        Me.cbBuscador.Items.AddRange(New Object() {"Tipo", "Modelo", "Marca"})
        Me.cbBuscador.Location = New System.Drawing.Point(315, 30)
        Me.cbBuscador.Name = "cbBuscador"
        Me.cbBuscador.Size = New System.Drawing.Size(155, 26)
        Me.cbBuscador.TabIndex = 55
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProductoLista, Me.tipoProductoLista, Me.marcaProductoLista, Me.modeloProductoLista, Me.cantidadProductoLista, Me.precioCostoLista, Me.precioVentaLista})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductosLista.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductosLista.EnableHeadersVisualStyles = False
        Me.dgvProductosLista.Location = New System.Drawing.Point(11, 68)
        Me.dgvProductosLista.MultiSelect = False
        Me.dgvProductosLista.Name = "dgvProductosLista"
        Me.dgvProductosLista.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProductosLista.RowHeadersVisible = False
        Me.dgvProductosLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosLista.Size = New System.Drawing.Size(459, 339)
        Me.dgvProductosLista.TabIndex = 1
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
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.precioVentaLista.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.cbBuscarCategoria.Location = New System.Drawing.Point(791, 30)
        Me.cbBuscarCategoria.Name = "cbBuscarCategoria"
        Me.cbBuscarCategoria.Size = New System.Drawing.Size(149, 26)
        Me.cbBuscarCategoria.TabIndex = 20
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(77, 30)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(232, 26)
        Me.txtBuscar.TabIndex = 0
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
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(11, 413)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(459, 29)
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
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(21, 9, 4, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 71)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "VENDER"
        '
        'xd
        '
        Me.xd.ColumnCount = 3
        Me.xd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.32347!))
        Me.xd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.xd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.67653!))
        Me.xd.Controls.Add(Me.Label1, 0, 1)
        Me.xd.Controls.Add(gbProductos, 0, 2)
        Me.xd.Controls.Add(Me.GroupBox1, 2, 2)
        Me.xd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xd.Location = New System.Drawing.Point(0, 0)
        Me.xd.Name = "xd"
        Me.xd.RowCount = 3
        Me.xd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.xd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.32977!))
        Me.xd.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.67023!))
        Me.xd.Size = New System.Drawing.Size(1019, 561)
        Me.xd.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel4)
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
        Me.GroupBox1.Location = New System.Drawing.Point(499, 107)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 5, 8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(512, 451)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                   "
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98814!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01186!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 251)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(506, 36)
        Me.TableLayoutPanel4.TabIndex = 63
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.cbFormPago, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(257, 36)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'cbFormPago
        '
        Me.cbFormPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFormPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormPago.Enabled = False
        Me.cbFormPago.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormPago.FormattingEnabled = True
        Me.cbFormPago.Location = New System.Drawing.Point(111, 7)
        Me.cbFormPago.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.cbFormPago.Name = "cbFormPago"
        Me.cbFormPago.Size = New System.Drawing.Size(143, 30)
        Me.cbFormPago.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 13)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 13, 3, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 18)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Form. Pago"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.txtClienteCtaCorriente, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnCancelarCtaCorriente, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(257, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(249, 36)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'txtClienteCtaCorriente
        '
        Me.txtClienteCtaCorriente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteCtaCorriente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClienteCtaCorriente.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteCtaCorriente.Location = New System.Drawing.Point(15, 8)
        Me.txtClienteCtaCorriente.Margin = New System.Windows.Forms.Padding(15, 8, 3, 3)
        Me.txtClienteCtaCorriente.Name = "txtClienteCtaCorriente"
        Me.txtClienteCtaCorriente.ReadOnly = True
        Me.txtClienteCtaCorriente.Size = New System.Drawing.Size(190, 26)
        Me.txtClienteCtaCorriente.TabIndex = 49
        Me.txtClienteCtaCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtClienteCtaCorriente.Visible = False
        '
        'btnCancelarCtaCorriente
        '
        Me.btnCancelarCtaCorriente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelarCtaCorriente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelarCtaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarCtaCorriente.Location = New System.Drawing.Point(211, 8)
        Me.btnCancelarCtaCorriente.Margin = New System.Windows.Forms.Padding(3, 8, 15, 6)
        Me.btnCancelarCtaCorriente.Name = "btnCancelarCtaCorriente"
        Me.btnCancelarCtaCorriente.Size = New System.Drawing.Size(23, 22)
        Me.btnCancelarCtaCorriente.TabIndex = 0
        Me.btnCancelarCtaCorriente.Text = "X"
        Me.btnCancelarCtaCorriente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelarCtaCorriente.UseVisualStyleBackColor = True
        Me.btnCancelarCtaCorriente.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.19658!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.80342!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 287)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(506, 87)
        Me.TableLayoutPanel3.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtSubtotal)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(287, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 81)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "TOTAL:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Subtotal:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubtotal.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(84, 8)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(120, 28)
        Me.txtSubtotal.TabIndex = 55
        Me.txtSubtotal.Text = "0"
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(84, 42)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(120, 28)
        Me.txtTotal.TabIndex = 54
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDescuento)
        Me.Panel1.Controls.Add(Me.txtRecargo)
        Me.Panel1.Controls.Add(Me.rbRecargoPorcentaje)
        Me.Panel1.Controls.Add(Me.rbRecargoPlata)
        Me.Panel1.Controls.Add(Me.rbDescuentoPorcentaje)
        Me.Panel1.Controls.Add(Me.rbDescuentoPlata)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 81)
        Me.Panel1.TabIndex = 0
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(109, 12)
        Me.txtDescuento.MaxLength = 9
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(93, 28)
        Me.txtDescuento.TabIndex = 67
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRecargo
        '
        Me.txtRecargo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecargo.Enabled = False
        Me.txtRecargo.Font = New System.Drawing.Font("Montserrat", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(109, 48)
        Me.txtRecargo.MaxLength = 9
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(93, 28)
        Me.txtRecargo.TabIndex = 61
        Me.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbRecargoPorcentaje
        '
        Me.rbRecargoPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbRecargoPorcentaje.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbRecargoPorcentaje.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbRecargoPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRecargoPorcentaje.Font = New System.Drawing.Font("Montserrat SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecargoPorcentaje.Location = New System.Drawing.Point(207, 48)
        Me.rbRecargoPorcentaje.Name = "rbRecargoPorcentaje"
        Me.rbRecargoPorcentaje.Size = New System.Drawing.Size(25, 25)
        Me.rbRecargoPorcentaje.TabIndex = 66
        Me.rbRecargoPorcentaje.TabStop = True
        Me.rbRecargoPorcentaje.Text = "%"
        Me.rbRecargoPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbRecargoPorcentaje.UseVisualStyleBackColor = True
        '
        'rbRecargoPlata
        '
        Me.rbRecargoPlata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbRecargoPlata.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbRecargoPlata.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbRecargoPlata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbRecargoPlata.Font = New System.Drawing.Font("Montserrat SemiBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRecargoPlata.Location = New System.Drawing.Point(239, 48)
        Me.rbRecargoPlata.Name = "rbRecargoPlata"
        Me.rbRecargoPlata.Size = New System.Drawing.Size(25, 25)
        Me.rbRecargoPlata.TabIndex = 65
        Me.rbRecargoPlata.TabStop = True
        Me.rbRecargoPlata.Text = "$"
        Me.rbRecargoPlata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbRecargoPlata.UseVisualStyleBackColor = True
        '
        'rbDescuentoPorcentaje
        '
        Me.rbDescuentoPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbDescuentoPorcentaje.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDescuentoPorcentaje.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbDescuentoPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDescuentoPorcentaje.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoPorcentaje.Location = New System.Drawing.Point(207, 10)
        Me.rbDescuentoPorcentaje.Name = "rbDescuentoPorcentaje"
        Me.rbDescuentoPorcentaje.Size = New System.Drawing.Size(25, 25)
        Me.rbDescuentoPorcentaje.TabIndex = 64
        Me.rbDescuentoPorcentaje.TabStop = True
        Me.rbDescuentoPorcentaje.Text = "%"
        Me.rbDescuentoPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDescuentoPorcentaje.UseVisualStyleBackColor = True
        '
        'rbDescuentoPlata
        '
        Me.rbDescuentoPlata.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbDescuentoPlata.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDescuentoPlata.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbDescuentoPlata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDescuentoPlata.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescuentoPlata.Location = New System.Drawing.Point(239, 10)
        Me.rbDescuentoPlata.Name = "rbDescuentoPlata"
        Me.rbDescuentoPlata.Size = New System.Drawing.Size(25, 25)
        Me.rbDescuentoPlata.TabIndex = 63
        Me.rbDescuentoPlata.TabStop = True
        Me.rbDescuentoPlata.Text = "$"
        Me.rbDescuentoPlata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDescuentoPlata.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Descuento:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 374)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(506, 36)
        Me.TableLayoutPanel2.TabIndex = 44
        '
        'btnCuentaCorriente
        '
        Me.btnCuentaCorriente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCuentaCorriente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCuentaCorriente.FlatAppearance.BorderSize = 2
        Me.btnCuentaCorriente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentaCorriente.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuentaCorriente.ForeColor = System.Drawing.Color.Black
        Me.btnCuentaCorriente.Location = New System.Drawing.Point(3, 4)
        Me.btnCuentaCorriente.Name = "btnCuentaCorriente"
        Me.btnCuentaCorriente.Size = New System.Drawing.Size(247, 29)
        Me.btnCuentaCorriente.TabIndex = 46
        Me.btnCuentaCorriente.Text = "Cuenta corriente"
        Me.btnCuentaCorriente.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderSize = 2
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(256, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(247, 29)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 410)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(506, 35)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'btnVender
        '
        Me.btnVender.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVender.FlatAppearance.BorderSize = 2
        Me.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVender.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVender.ForeColor = System.Drawing.Color.Black
        Me.btnVender.Location = New System.Drawing.Point(3, 3)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(500, 29)
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
        Me.dgvCarrito.Location = New System.Drawing.Point(6, 62)
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
        Me.dgvCarrito.Size = New System.Drawing.Size(499, 169)
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
        Me.btnEliminarDGV.HeaderText = "Opciones"
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
        Me.txtFecha.Location = New System.Drawing.Point(389, 30)
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
        Me.Label7.Location = New System.Drawing.Point(324, 33)
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
        Me.txtNroVenta.Size = New System.Drawing.Size(147, 26)
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
        'frmVender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 561)
        Me.Controls.Add(Me.xd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmVender"
        Me.Text = "Form1"
        gbProductos.ResumeLayout(False)
        gbProductos.PerformLayout()
        CType(Me.dgvProductosLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xd.ResumeLayout(False)
        Me.xd.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
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
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents xd As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRecargo As TextBox
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
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNroVenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents cbFormPago As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnCancelarCtaCorriente As Button
    Friend WithEvents txtClienteCtaCorriente As TextBox
    Friend WithEvents cbBuscador As ComboBox
    Friend WithEvents txtDescuento As TextBox
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
