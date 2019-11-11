<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBajaCliente = New System.Windows.Forms.Button()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvRubros = New System.Windows.Forms.DataGridView()
        Me.rubros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idrubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOcultarRubros = New System.Windows.Forms.Button()
        Me.btnVerRubros = New System.Windows.Forms.Button()
        Me.picCerrar = New System.Windows.Forms.PictureBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRubros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(468, 75)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PROVEEDORES"
        '
        'btnModificar
        '
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(506, 479)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(131, 41)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBajaCliente
        '
        Me.btnBajaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajaCliente.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaCliente.ForeColor = System.Drawing.Color.Black
        Me.btnBajaCliente.Location = New System.Drawing.Point(662, 479)
        Me.btnBajaCliente.Name = "btnBajaCliente"
        Me.btnBajaCliente.Size = New System.Drawing.Size(131, 41)
        Me.btnBajaCliente.TabIndex = 13
        Me.btnBajaCliente.Text = "Baja"
        Me.btnBajaCliente.UseVisualStyleBackColor = True
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.AllowUserToOrderColumns = True
        Me.dgvProveedores.AllowUserToResizeColumns = False
        Me.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProveedor, Me.nombre, Me.telefono, Me.cbu, Me.direccion, Me.formPago, Me.horario})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProveedores.Location = New System.Drawing.Point(21, 93)
        Me.dgvProveedores.MultiSelect = False
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgvProveedores.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(961, 309)
        Me.dgvProveedores.TabIndex = 12
        '
        'idProveedor
        '
        Me.idProveedor.DataPropertyName = "idProveedor"
        Me.idProveedor.HeaderText = "ID"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        Me.idProveedor.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'cbu
        '
        Me.cbu.DataPropertyName = "cbu"
        Me.cbu.HeaderText = "CBU"
        Me.cbu.Name = "cbu"
        Me.cbu.ReadOnly = True
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'formPago
        '
        Me.formPago.DataPropertyName = "pagos"
        Me.formPago.HeaderText = "Pago"
        Me.formPago.Name = "formPago"
        Me.formPago.ReadOnly = True
        Me.formPago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'horario
        '
        Me.horario.DataPropertyName = "horario"
        Me.horario.HeaderText = "Horario"
        Me.horario.Name = "horario"
        Me.horario.ReadOnly = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(815, 479)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(131, 41)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgvRubros
        '
        Me.dgvRubros.AllowUserToAddRows = False
        Me.dgvRubros.AllowUserToDeleteRows = False
        Me.dgvRubros.AllowUserToOrderColumns = True
        Me.dgvRubros.AllowUserToResizeColumns = False
        Me.dgvRubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRubros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRubros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRubros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rubros, Me.idrubro})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRubros.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvRubros.Location = New System.Drawing.Point(790, 93)
        Me.dgvRubros.MultiSelect = False
        Me.dgvRubros.Name = "dgvRubros"
        Me.dgvRubros.ReadOnly = True
        Me.dgvRubros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvRubros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        Me.dgvRubros.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRubros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRubros.Size = New System.Drawing.Size(192, 277)
        Me.dgvRubros.TabIndex = 17
        Me.dgvRubros.Visible = False
        '
        'rubros
        '
        Me.rubros.DataPropertyName = "nombRubro"
        Me.rubros.HeaderText = "Rubros"
        Me.rubros.Name = "rubros"
        Me.rubros.ReadOnly = True
        '
        'idrubro
        '
        Me.idrubro.DataPropertyName = "idRubro"
        Me.idrubro.HeaderText = "idRubro"
        Me.idrubro.Name = "idrubro"
        Me.idrubro.ReadOnly = True
        Me.idrubro.Visible = False
        '
        'btnOcultarRubros
        '
        Me.btnOcultarRubros.BackColor = System.Drawing.SystemColors.Control
        Me.btnOcultarRubros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcultarRubros.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultarRubros.ForeColor = System.Drawing.Color.Black
        Me.btnOcultarRubros.Location = New System.Drawing.Point(790, 377)
        Me.btnOcultarRubros.Name = "btnOcultarRubros"
        Me.btnOcultarRubros.Size = New System.Drawing.Size(192, 25)
        Me.btnOcultarRubros.TabIndex = 18
        Me.btnOcultarRubros.Text = "Ocultar"
        Me.btnOcultarRubros.UseVisualStyleBackColor = False
        Me.btnOcultarRubros.Visible = False
        '
        'btnVerRubros
        '
        Me.btnVerRubros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerRubros.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRubros.ForeColor = System.Drawing.Color.Black
        Me.btnVerRubros.Location = New System.Drawing.Point(815, 432)
        Me.btnVerRubros.Name = "btnVerRubros"
        Me.btnVerRubros.Size = New System.Drawing.Size(131, 41)
        Me.btnVerRubros.TabIndex = 19
        Me.btnVerRubros.Text = "Ver Rubros"
        Me.btnVerRubros.UseVisualStyleBackColor = True
        '
        'picCerrar
        '
        Me.picCerrar.BackColor = System.Drawing.Color.Transparent
        Me.picCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCerrar.Image = CType(resources.GetObject("picCerrar.Image"), System.Drawing.Image)
        Me.picCerrar.Location = New System.Drawing.Point(950, 12)
        Me.picCerrar.Name = "picCerrar"
        Me.picCerrar.Size = New System.Drawing.Size(34, 34)
        Me.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCerrar.TabIndex = 20
        Me.picCerrar.TabStop = False
        Me.picCerrar.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(815, 479)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(131, 41)
        Me.btnAceptar.TabIndex = 21
        Me.btnAceptar.Text = "Seleccionar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(662, 479)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(131, 41)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.Panel3)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(984, 12)
        Me.pnlHeader.TabIndex = 23
        Me.pnlHeader.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(21, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 77)
        Me.Panel3.TabIndex = 2
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.picCerrar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnVerRubros)
        Me.Controls.Add(Me.btnOcultarRubros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBajaCliente)
        Me.Controls.Add(Me.dgvRubros)
        Me.Controls.Add(Me.dgvProveedores)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProveedores"
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRubros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBajaCliente As Button
    Public WithEvents dgvProveedores As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents idProveedor As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents cbu As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents formPago As DataGridViewTextBoxColumn
    Friend WithEvents horario As DataGridViewTextBoxColumn
    Public WithEvents dgvRubros As DataGridView
    Friend WithEvents rubros As DataGridViewTextBoxColumn
    Friend WithEvents idrubro As DataGridViewTextBoxColumn
    Friend WithEvents btnOcultarRubros As Button
    Friend WithEvents btnVerRubros As Button
    Friend WithEvents picCerrar As PictureBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Panel3 As Panel
End Class
