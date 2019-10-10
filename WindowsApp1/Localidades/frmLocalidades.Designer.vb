<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalidades
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalidades))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvLocalidades = New System.Windows.Forms.DataGridView()
        Me.idLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnNuevaLocalidad = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNuevaLoc = New System.Windows.Forms.TextBox()
        Me.btnGuardarLoc = New System.Windows.Forms.Button()
        Me.btnCancelarLoc = New System.Windows.Forms.Button()
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 12)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 51)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Localidades"
        '
        'dgvLocalidades
        '
        Me.dgvLocalidades.AllowUserToAddRows = False
        Me.dgvLocalidades.AllowUserToDeleteRows = False
        Me.dgvLocalidades.AllowUserToOrderColumns = True
        Me.dgvLocalidades.AllowUserToResizeColumns = False
        Me.dgvLocalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvLocalidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLocalidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idLocalidad, Me.nombLocalidad, Me.provincia})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLocalidades.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLocalidades.Location = New System.Drawing.Point(21, 109)
        Me.dgvLocalidades.MultiSelect = False
        Me.dgvLocalidades.Name = "dgvLocalidades"
        Me.dgvLocalidades.ReadOnly = True
        Me.dgvLocalidades.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvLocalidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        Me.dgvLocalidades.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLocalidades.Size = New System.Drawing.Size(575, 181)
        Me.dgvLocalidades.TabIndex = 2
        '
        'idLocalidad
        '
        Me.idLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.idLocalidad.DataPropertyName = "idLocalidad"
        Me.idLocalidad.HeaderText = "ID "
        Me.idLocalidad.Name = "idLocalidad"
        Me.idLocalidad.ReadOnly = True
        '
        'nombLocalidad
        '
        Me.nombLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombLocalidad.DataPropertyName = "nombLocalidad"
        Me.nombLocalidad.HeaderText = "Nombre"
        Me.nombLocalidad.Name = "nombLocalidad"
        Me.nombLocalidad.ReadOnly = True
        '
        'provincia
        '
        Me.provincia.DataPropertyName = "provincia"
        Me.provincia.HeaderText = "ID Provincia"
        Me.provincia.Name = "provincia"
        Me.provincia.ReadOnly = True
        Me.provincia.Visible = False
        Me.provincia.Width = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(91, 71)
        Me.txtBuscar.MaxLength = 25
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(230, 23)
        Me.txtBuscar.TabIndex = 5
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(588, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 34)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(499, 347)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 32)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(378, 347)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 32)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnNuevaLocalidad
        '
        Me.btnNuevaLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaLocalidad.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaLocalidad.Location = New System.Drawing.Point(482, 71)
        Me.btnNuevaLocalidad.Name = "btnNuevaLocalidad"
        Me.btnNuevaLocalidad.Size = New System.Drawing.Size(114, 25)
        Me.btnNuevaLocalidad.TabIndex = 10
        Me.btnNuevaLocalidad.Text = "Nueva Localidad"
        Me.btnNuevaLocalidad.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(17, 303)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(84, 22)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre: "
        Me.lblNombre.Visible = False
        '
        'txtNuevaLoc
        '
        Me.txtNuevaLoc.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevaLoc.Location = New System.Drawing.Point(107, 304)
        Me.txtNuevaLoc.MaxLength = 25
        Me.txtNuevaLoc.Name = "txtNuevaLoc"
        Me.txtNuevaLoc.Size = New System.Drawing.Size(335, 23)
        Me.txtNuevaLoc.TabIndex = 12
        Me.txtNuevaLoc.Visible = False
        '
        'btnGuardarLoc
        '
        Me.btnGuardarLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarLoc.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarLoc.Location = New System.Drawing.Point(466, 303)
        Me.btnGuardarLoc.Name = "btnGuardarLoc"
        Me.btnGuardarLoc.Size = New System.Drawing.Size(63, 25)
        Me.btnGuardarLoc.TabIndex = 13
        Me.btnGuardarLoc.Text = "Guardar"
        Me.btnGuardarLoc.UseVisualStyleBackColor = True
        Me.btnGuardarLoc.Visible = False
        '
        'btnCancelarLoc
        '
        Me.btnCancelarLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarLoc.Font = New System.Drawing.Font("Montserrat", 8.24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarLoc.Location = New System.Drawing.Point(535, 303)
        Me.btnCancelarLoc.Name = "btnCancelarLoc"
        Me.btnCancelarLoc.Size = New System.Drawing.Size(63, 25)
        Me.btnCancelarLoc.TabIndex = 14
        Me.btnCancelarLoc.Text = "Cerrar"
        Me.btnCancelarLoc.UseVisualStyleBackColor = True
        Me.btnCancelarLoc.Visible = False
        '
        'frmLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 397)
        Me.Controls.Add(Me.btnCancelarLoc)
        Me.Controls.Add(Me.btnGuardarLoc)
        Me.Controls.Add(Me.txtNuevaLoc)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnNuevaLocalidad)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvLocalidades)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLocalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLocalidades"
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents idLocalidad As DataGridViewTextBoxColumn
    Friend WithEvents nombLocalidad As DataGridViewTextBoxColumn
    Friend WithEvents provincia As DataGridViewTextBoxColumn
    Public WithEvents dgvLocalidades As DataGridView
    Friend WithEvents btnNuevaLocalidad As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNuevaLoc As TextBox
    Friend WithEvents btnGuardarLoc As Button
    Friend WithEvents btnCancelarLoc As Button
End Class
