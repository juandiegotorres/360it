﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCuentasCorriente
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDetalleVenta = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.picCerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.fechaMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuotas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoRestante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentacorriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtResto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picClientes = New System.Windows.Forms.PictureBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbVentas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEntregaDeDinero = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.picCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10, 10, 11, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1019, 561)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24048!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24048!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.13828!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnEntregaDeDinero, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDetalleVenta, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 475)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 2, 18, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(997, 64)
        Me.TableLayoutPanel2.TabIndex = 41
        '
        'btnDetalleVenta
        '
        Me.btnDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDetalleVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDetalleVenta.FlatAppearance.BorderSize = 2
        Me.btnDetalleVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDetalleVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleVenta.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleVenta.ForeColor = System.Drawing.Color.Black
        Me.btnDetalleVenta.Image = Global.WindowsApp1.My.Resources.Resources.detalles
        Me.btnDetalleVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetalleVenta.Location = New System.Drawing.Point(686, 10)
        Me.btnDetalleVenta.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
        Me.btnDetalleVenta.Name = "btnDetalleVenta"
        Me.btnDetalleVenta.Size = New System.Drawing.Size(311, 44)
        Me.btnDetalleVenta.TabIndex = 1
        Me.btnDetalleVenta.Text = "Detalle Venta"
        Me.btnDetalleVenta.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.437!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.56299!))
        Me.TableLayoutPanel3.Controls.Add(Me.picCerrar, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1016, 79)
        Me.TableLayoutPanel3.TabIndex = 44
        '
        'picCerrar
        '
        Me.picCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCerrar.BackColor = System.Drawing.Color.Transparent
        Me.picCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCerrar.Image = Global.WindowsApp1.My.Resources.Resources.close
        Me.picCerrar.Location = New System.Drawing.Point(989, 0)
        Me.picCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.picCerrar.Name = "picCerrar"
        Me.picCerrar.Size = New System.Drawing.Size(27, 26)
        Me.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCerrar.TabIndex = 41
        Me.picCerrar.TabStop = False
        Me.picCerrar.Visible = False
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
        Me.Label1.Size = New System.Drawing.Size(648, 68)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "CUENTAS CORRIENTE"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgvCuentas, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 140)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.68769!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31231!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1019, 333)
        Me.TableLayoutPanel4.TabIndex = 45
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.AllowUserToOrderColumns = True
        Me.dgvCuentas.AllowUserToResizeRows = False
        Me.dgvCuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCuentas.CausesValidation = False
        Me.dgvCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fechaMovimiento, Me.tipoMovimiento, Me.monto, Me.cuotas, Me.montoRestante, Me.venta, Me.cuentacorriente, Me.idcliente, Me.idMovimiento})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentas.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvCuentas.EnableHeadersVisualStyles = False
        Me.dgvCuentas.Location = New System.Drawing.Point(20, 5)
        Me.dgvCuentas.Margin = New System.Windows.Forms.Padding(20, 5, 18, 0)
        Me.dgvCuentas.MultiSelect = False
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvCuentas.RowHeadersVisible = False
        Me.dgvCuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCuentas.Size = New System.Drawing.Size(981, 287)
        Me.dgvCuentas.TabIndex = 49
        '
        'fechaMovimiento
        '
        Me.fechaMovimiento.DataPropertyName = "fechaMovimiento"
        Me.fechaMovimiento.HeaderText = "Fecha y Hora"
        Me.fechaMovimiento.Name = "fechaMovimiento"
        Me.fechaMovimiento.ReadOnly = True
        '
        'tipoMovimiento
        '
        Me.tipoMovimiento.DataPropertyName = "tipoMovimiento"
        Me.tipoMovimiento.HeaderText = "Tipo de movimiento"
        Me.tipoMovimiento.Name = "tipoMovimiento"
        Me.tipoMovimiento.ReadOnly = True
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        DataGridViewCellStyle14.Format = "C2"
        Me.monto.DefaultCellStyle = DataGridViewCellStyle14
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'cuotas
        '
        Me.cuotas.DataPropertyName = "cuotas"
        Me.cuotas.HeaderText = "Cuotas"
        Me.cuotas.Name = "cuotas"
        Me.cuotas.ReadOnly = True
        '
        'montoRestante
        '
        Me.montoRestante.DataPropertyName = "montoRestante"
        Me.montoRestante.HeaderText = "Monto"
        Me.montoRestante.Name = "montoRestante"
        Me.montoRestante.ReadOnly = True
        Me.montoRestante.Visible = False
        '
        'venta
        '
        Me.venta.DataPropertyName = "venta"
        Me.venta.HeaderText = "Número de venta"
        Me.venta.Name = "venta"
        Me.venta.ReadOnly = True
        '
        'cuentacorriente
        '
        Me.cuentacorriente.DataPropertyName = "cuentacorriente"
        Me.cuentacorriente.HeaderText = "ID Cta Corriente"
        Me.cuentacorriente.Name = "cuentacorriente"
        Me.cuentacorriente.ReadOnly = True
        Me.cuentacorriente.Visible = False
        '
        'idcliente
        '
        Me.idcliente.DataPropertyName = "idcliente"
        Me.idcliente.HeaderText = "ID Cliente"
        Me.idcliente.Name = "idcliente"
        Me.idcliente.ReadOnly = True
        Me.idcliente.Visible = False
        '
        'idMovimiento
        '
        Me.idMovimiento.DataPropertyName = "idmovimiento"
        Me.idMovimiento.HeaderText = "ID Movimiento"
        Me.idMovimiento.Name = "idMovimiento"
        Me.idMovimiento.ReadOnly = True
        Me.idMovimiento.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(682, 293)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(1, 1, 16, 1)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(321, 39)
        Me.TableLayoutPanel5.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtResto)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 39)
        Me.Panel2.TabIndex = 0
        '
        'txtResto
        '
        Me.txtResto.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResto.Location = New System.Drawing.Point(152, 8)
        Me.txtResto.Name = "txtResto"
        Me.txtResto.ReadOnly = True
        Me.txtResto.Size = New System.Drawing.Size(167, 27)
        Me.txtResto.TabIndex = 2
        Me.txtResto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(31, 8, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Resto: "
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 101)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1019, 39)
        Me.TableLayoutPanel6.TabIndex = 46
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.picClientes)
        Me.Panel1.Controls.Add(Me.txtNombreCliente)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 39)
        Me.Panel1.TabIndex = 44
        '
        'picClientes
        '
        Me.picClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picClientes.Image = Global.WindowsApp1.My.Resources.Resources.pngtree_find_search_view_glass_blue_dotted_line_line_icon_png_image_1622078
        Me.picClientes.Location = New System.Drawing.Point(449, 2)
        Me.picClientes.Name = "picClientes"
        Me.picClientes.Size = New System.Drawing.Size(36, 35)
        Me.picClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClientes.TabIndex = 45
        Me.picClientes.TabStop = False
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(147, 6)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(298, 27)
        Me.txtNombreCliente.TabIndex = 0
        Me.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Buscar cliente:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbVentas)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(572, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(447, 39)
        Me.Panel3.TabIndex = 45
        '
        'cbVentas
        '
        Me.cbVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbVentas.BackColor = System.Drawing.SystemColors.Window
        Me.cbVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVentas.Font = New System.Drawing.Font("Montserrat", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVentas.FormattingEnabled = True
        Me.cbVentas.Location = New System.Drawing.Point(254, 7)
        Me.cbVentas.Name = "cbVentas"
        Me.cbVentas.Size = New System.Drawing.Size(175, 29)
        Me.cbVentas.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(187, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 22)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Venta:"
        '
        'btnEntregaDeDinero
        '
        Me.btnEntregaDeDinero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEntregaDeDinero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEntregaDeDinero.FlatAppearance.BorderSize = 2
        Me.btnEntregaDeDinero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEntregaDeDinero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnEntregaDeDinero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregaDeDinero.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregaDeDinero.ForeColor = System.Drawing.Color.Black
        Me.btnEntregaDeDinero.Image = Global.WindowsApp1.My.Resources.Resources.hand_money
        Me.btnEntregaDeDinero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntregaDeDinero.Location = New System.Drawing.Point(10, 10)
        Me.btnEntregaDeDinero.Margin = New System.Windows.Forms.Padding(10)
        Me.btnEntregaDeDinero.Name = "btnEntregaDeDinero"
        Me.btnEntregaDeDinero.Size = New System.Drawing.Size(318, 44)
        Me.btnEntregaDeDinero.TabIndex = 3
        Me.btnEntregaDeDinero.Text = "Entrega de Dinero"
        Me.btnEntregaDeDinero.UseVisualStyleBackColor = True
        '
        'frmCuentasCorriente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1019, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCuentasCorriente"
        Me.Text = "frmCuentasCorriente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.picCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnDetalleVenta As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents picCerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents monton As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dgvCuentas As DataGridView
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtResto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fechaMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents tipoMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents cuotas As DataGridViewTextBoxColumn
    Friend WithEvents montoRestante As DataGridViewTextBoxColumn
    Friend WithEvents venta As DataGridViewTextBoxColumn
    Friend WithEvents cuentacorriente As DataGridViewTextBoxColumn
    Friend WithEvents idcliente As DataGridViewTextBoxColumn
    Friend WithEvents idMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picClientes As PictureBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbVentas As ComboBox
    Friend WithEvents btnEntregaDeDinero As Button
End Class
