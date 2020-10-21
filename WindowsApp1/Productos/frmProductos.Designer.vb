<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoriaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSinStock = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregarStock = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10, 10, 11, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1035, 600)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnAgregar, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBaja, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnModificar, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(150, 534)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(150, 2, 163, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(722, 64)
        Me.TableLayoutPanel2.TabIndex = 46
        '
        'btnAgregar
        '
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Poppins SemiBold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(490, 10)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(222, 44)
        Me.btnAgregar.TabIndex = 36
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaja.Font = New System.Drawing.Font("Poppins SemiBold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.ForeColor = System.Drawing.Color.Black
        Me.btnBaja.Location = New System.Drawing.Point(250, 10)
        Me.btnBaja.Margin = New System.Windows.Forms.Padding(10)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(220, 44)
        Me.btnBaja.TabIndex = 37
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Poppins SemiBold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(10, 10)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(220, 44)
        Me.btnModificar.TabIndex = 38
        Me.btnModificar.Text = "Modificación"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(4, 104)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 33)
        Me.Panel1.TabIndex = 43
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(154, 8)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(200, 23)
        Me.txtBuscar.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 22)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Buscar modelo:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 16)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1035, 85)
        Me.TableLayoutPanel3.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(21, 9, 4, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 74)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "PRODUCTOS"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgvProductos, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1, 141)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1033, 390)
        Me.TableLayoutPanel4.TabIndex = 45
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToOrderColumns = True
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductos.CausesValidation = False
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.marca, Me.categoriaid, Me.idproveedor, Me.modelo, Me.tipoProducto, Me.nombCategoria, Me.nombreProveedor, Me.cantidad, Me.descripcion, Me.precioCosto, Me.precioVenta})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.Location = New System.Drawing.Point(20, 5)
        Me.dgvProductos.Margin = New System.Windows.Forms.Padding(20, 5, 18, 10)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProductos.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(817, 375)
        Me.dgvProductos.TabIndex = 46
        '
        'id
        '
        Me.id.DataPropertyName = "idProducto"
        Me.id.HeaderText = "idProducto"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'marca
        '
        Me.marca.DataPropertyName = "marca"
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'categoriaid
        '
        Me.categoriaid.DataPropertyName = "categoria"
        Me.categoriaid.HeaderText = "categoria"
        Me.categoriaid.Name = "categoriaid"
        Me.categoriaid.ReadOnly = True
        Me.categoriaid.Visible = False
        '
        'idproveedor
        '
        Me.idproveedor.DataPropertyName = "proveedor"
        Me.idproveedor.HeaderText = "idproveedor"
        Me.idproveedor.Name = "idproveedor"
        Me.idproveedor.ReadOnly = True
        Me.idproveedor.Visible = False
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "modelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'tipoProducto
        '
        Me.tipoProducto.DataPropertyName = "tipoProducto"
        Me.tipoProducto.HeaderText = "Tipo"
        Me.tipoProducto.Name = "tipoProducto"
        Me.tipoProducto.ReadOnly = True
        '
        'nombCategoria
        '
        Me.nombCategoria.DataPropertyName = "nombCategoria"
        Me.nombCategoria.HeaderText = "Categoría"
        Me.nombCategoria.Name = "nombCategoria"
        Me.nombCategoria.ReadOnly = True
        '
        'nombreProveedor
        '
        Me.nombreProveedor.DataPropertyName = "nombreProveedor"
        Me.nombreProveedor.HeaderText = "Proveedor"
        Me.nombreProveedor.Name = "nombreProveedor"
        Me.nombreProveedor.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'precioCosto
        '
        Me.precioCosto.DataPropertyName = "precioCosto"
        DataGridViewCellStyle2.Format = "C2"
        Me.precioCosto.DefaultCellStyle = DataGridViewCellStyle2
        Me.precioCosto.HeaderText = "Precio Costo"
        Me.precioCosto.Name = "precioCosto"
        Me.precioCosto.ReadOnly = True
        '
        'precioVenta
        '
        Me.precioVenta.DataPropertyName = "precioVenta"
        DataGridViewCellStyle3.Format = "C2"
        Me.precioVenta.DefaultCellStyle = DataGridViewCellStyle3
        Me.precioVenta.HeaderText = "Precio Venta"
        Me.precioVenta.Name = "precioVenta"
        Me.precioVenta.ReadOnly = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnSinStock, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.btnQuitar, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnAgregarStock, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(855, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(178, 390)
        Me.TableLayoutPanel5.TabIndex = 47
        '
        'btnSinStock
        '
        Me.btnSinStock.BackColor = System.Drawing.Color.Transparent
        Me.btnSinStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSinStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSinStock.FlatAppearance.BorderSize = 2
        Me.btnSinStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnSinStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSinStock.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinStock.ForeColor = System.Drawing.Color.Black
        Me.btnSinStock.Location = New System.Drawing.Point(5, 99)
        Me.btnSinStock.Margin = New System.Windows.Forms.Padding(5, 5, 18, 10)
        Me.btnSinStock.Name = "btnSinStock"
        Me.btnSinStock.Size = New System.Drawing.Size(155, 59)
        Me.btnSinStock.TabIndex = 42
        Me.btnSinStock.Text = "Productos sin Stock primero"
        Me.btnSinStock.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuitar.FlatAppearance.BorderSize = 2
        Me.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.Black
        Me.btnQuitar.Location = New System.Drawing.Point(5, 52)
        Me.btnQuitar.Margin = New System.Windows.Forms.Padding(5, 5, 18, 10)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(155, 32)
        Me.btnQuitar.TabIndex = 41
        Me.btnQuitar.Text = "Quitar Stock"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnAgregarStock
        '
        Me.btnAgregarStock.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregarStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarStock.FlatAppearance.BorderSize = 2
        Me.btnAgregarStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnAgregarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarStock.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarStock.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarStock.Location = New System.Drawing.Point(5, 5)
        Me.btnAgregarStock.Margin = New System.Windows.Forms.Padding(5, 5, 18, 10)
        Me.btnAgregarStock.Name = "btnAgregarStock"
        Me.btnAgregarStock.Size = New System.Drawing.Size(155, 32)
        Me.btnAgregarStock.TabIndex = 40
        Me.btnAgregarStock.Text = "Agregar Stock"
        Me.btnAgregarStock.UseVisualStyleBackColor = False
        '
        'frmProductos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1035, 600)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductos"
        Me.Text = "frmProductos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents categoriaid As DataGridViewTextBoxColumn
    Friend WithEvents idproveedor As DataGridViewTextBoxColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents tipoProducto As DataGridViewTextBoxColumn
    Friend WithEvents nombCategoria As DataGridViewTextBoxColumn
    Friend WithEvents nombreProveedor As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents precioCosto As DataGridViewTextBoxColumn
    Friend WithEvents precioVenta As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregarStock As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnSinStock As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnModificar As Button
End Class
