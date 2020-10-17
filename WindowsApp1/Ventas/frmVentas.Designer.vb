<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvHistorialVentas = New System.Windows.Forms.DataGridView()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articulos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.dgvHistorialVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 3)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1019, 561)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.38314!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.83567!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24048!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24048!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.13828!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnAgregar, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnBaja, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnModificar, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 495)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 2, 18, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(997, 64)
        Me.TableLayoutPanel2.TabIndex = 41
        '
        'btnAgregar
        '
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(815, 10)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(182, 44)
        Me.btnAgregar.TabIndex = 36
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaja.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.ForeColor = System.Drawing.Color.Black
        Me.btnBaja.Location = New System.Drawing.Point(613, 10)
        Me.btnBaja.Margin = New System.Windows.Forms.Padding(10)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(182, 44)
        Me.btnBaja.TabIndex = 37
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(411, 10)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(182, 44)
        Me.btnModificar.TabIndex = 38
        Me.btnModificar.Text = "Modificación"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.6948!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.3052!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 16)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1019, 85)
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
        Me.Label1.Size = New System.Drawing.Size(673, 74)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "HISTORIAL DE VENTAS"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 101)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1019, 39)
        Me.TableLayoutPanel4.TabIndex = 46
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.20903!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.79097!))
        Me.TableLayoutPanel5.Controls.Add(Me.dgvHistorialVentas, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 140)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1019, 353)
        Me.TableLayoutPanel5.TabIndex = 47
        '
        'dgvHistorialVentas
        '
        Me.dgvHistorialVentas.AllowUserToAddRows = False
        Me.dgvHistorialVentas.AllowUserToDeleteRows = False
        Me.dgvHistorialVentas.AllowUserToOrderColumns = True
        Me.dgvHistorialVentas.AllowUserToResizeRows = False
        Me.dgvHistorialVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistorialVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorialVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistorialVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorialVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistorialVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVenta, Me.fecha, Me.hora, Me.articulos, Me.monto})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistorialVentas.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvHistorialVentas.EnableHeadersVisualStyles = False
        Me.dgvHistorialVentas.Location = New System.Drawing.Point(20, 5)
        Me.dgvHistorialVentas.Margin = New System.Windows.Forms.Padding(20, 5, 18, 10)
        Me.dgvHistorialVentas.MultiSelect = False
        Me.dgvHistorialVentas.Name = "dgvHistorialVentas"
        Me.dgvHistorialVentas.ReadOnly = True
        Me.dgvHistorialVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorialVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvHistorialVentas.RowHeadersVisible = False
        Me.dgvHistorialVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgvHistorialVentas.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvHistorialVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorialVentas.Size = New System.Drawing.Size(708, 318)
        Me.dgvHistorialVentas.TabIndex = 46
        '
        'idVenta
        '
        Me.idVenta.DataPropertyName = "venta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.idVenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.idVenta.HeaderText = "Venta"
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'hora
        '
        Me.hora.DataPropertyName = "Hora"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.hora.DefaultCellStyle = DataGridViewCellStyle4
        Me.hora.HeaderText = "Hora"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'articulos
        '
        Me.articulos.DataPropertyName = "articulos"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.articulos.DefaultCellStyle = DataGridViewCellStyle5
        Me.articulos.HeaderText = "Artículos"
        Me.articulos.Name = "articulos"
        Me.articulos.ReadOnly = True
        '
        'monto
        '
        Me.monto.DataPropertyName = "precioFinal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.Format = "C2"
        Me.monto.DefaultCellStyle = DataGridViewCellStyle6
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(746, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(273, 179)
        Me.TableLayoutPanel6.TabIndex = 47
        '
        'frmVentas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1019, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentas"
        Me.Text = "Form3"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.dgvHistorialVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Public WithEvents dgvHistorialVentas As DataGridView
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents hora As DataGridViewTextBoxColumn
    Friend WithEvents articulos As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
End Class
