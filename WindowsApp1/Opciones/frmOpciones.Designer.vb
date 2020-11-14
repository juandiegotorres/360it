<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpciones
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabConfiguraciones = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlEditar = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblEditarAgregar = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditarRecargo = New System.Windows.Forms.Button()
        Me.btnDestacar = New System.Windows.Forms.Button()
        Me.btnDarAlta = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnEditarNombre = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvFormPago = New System.Windows.Forms.DataGridView()
        Me.idformpago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destacado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabConfiguraciones.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlEditar.SuspendLayout()
        CType(Me.dgvFormPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.39894!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.60105!))
        Me.TableLayoutPanel1.Controls.Add(Me.tabConfiguraciones, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1079, 597)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tabConfiguraciones
        '
        Me.tabConfiguraciones.Controls.Add(Me.TabPage1)
        Me.tabConfiguraciones.Controls.Add(Me.TabPage2)
        Me.tabConfiguraciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabConfiguraciones.Location = New System.Drawing.Point(190, 3)
        Me.tabConfiguraciones.Name = "tabConfiguraciones"
        Me.tabConfiguraciones.SelectedIndex = 0
        Me.tabConfiguraciones.Size = New System.Drawing.Size(886, 591)
        Me.tabConfiguraciones.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlEditar)
        Me.TabPage1.Controls.Add(Me.btnAgregar)
        Me.TabPage1.Controls.Add(Me.btnEditarRecargo)
        Me.TabPage1.Controls.Add(Me.btnDestacar)
        Me.TabPage1.Controls.Add(Me.btnDarAlta)
        Me.TabPage1.Controls.Add(Me.btnDarBaja)
        Me.TabPage1.Controls.Add(Me.btnEditarNombre)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dgvFormPago)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(878, 565)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form. Pago"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlEditar
        '
        Me.pnlEditar.Controls.Add(Me.btnCancelar)
        Me.pnlEditar.Controls.Add(Me.btnGuardar)
        Me.pnlEditar.Controls.Add(Me.txtRecargo)
        Me.pnlEditar.Controls.Add(Me.Label3)
        Me.pnlEditar.Controls.Add(Me.Label2)
        Me.pnlEditar.Controls.Add(Me.txtNombre)
        Me.pnlEditar.Controls.Add(Me.lblEditarAgregar)
        Me.pnlEditar.Location = New System.Drawing.Point(45, 265)
        Me.pnlEditar.Name = "pnlEditar"
        Me.pnlEditar.Size = New System.Drawing.Size(584, 66)
        Me.pnlEditar.TabIndex = 8
        Me.pnlEditar.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(451, 34)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 25)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtRecargo
        '
        Me.txtRecargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(356, 36)
        Me.txtRecargo.MaxLength = 2
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(78, 22)
        Me.txtRecargo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Recargo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtNombre.Location = New System.Drawing.Point(70, 36)
        Me.txtNombre.MaxLength = 45
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 22)
        Me.txtNombre.TabIndex = 1
        '
        'lblEditarAgregar
        '
        Me.lblEditarAgregar.AutoSize = True
        Me.lblEditarAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEditarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEditarAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditarAgregar.Location = New System.Drawing.Point(257, 1)
        Me.lblEditarAgregar.Name = "lblEditarAgregar"
        Me.lblEditarAgregar.Size = New System.Drawing.Size(59, 22)
        Me.lblEditarAgregar.TabIndex = 0
        Me.lblEditarAgregar.Text = "Editar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(648, 61)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(196, 28)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar nueva"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditarRecargo
        '
        Me.btnEditarRecargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarRecargo.Location = New System.Drawing.Point(648, 129)
        Me.btnEditarRecargo.Name = "btnEditarRecargo"
        Me.btnEditarRecargo.Size = New System.Drawing.Size(196, 28)
        Me.btnEditarRecargo.TabIndex = 6
        Me.btnEditarRecargo.Text = "Editar Recargo"
        Me.btnEditarRecargo.UseVisualStyleBackColor = True
        '
        'btnDestacar
        '
        Me.btnDestacar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDestacar.Location = New System.Drawing.Point(648, 231)
        Me.btnDestacar.Name = "btnDestacar"
        Me.btnDestacar.Size = New System.Drawing.Size(196, 28)
        Me.btnDestacar.TabIndex = 5
        Me.btnDestacar.Text = "Destacar"
        Me.btnDestacar.UseVisualStyleBackColor = True
        '
        'btnDarAlta
        '
        Me.btnDarAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarAlta.Location = New System.Drawing.Point(648, 197)
        Me.btnDarAlta.Name = "btnDarAlta"
        Me.btnDarAlta.Size = New System.Drawing.Size(196, 28)
        Me.btnDarAlta.TabIndex = 4
        Me.btnDarAlta.Text = "Dar de Alta"
        Me.btnDarAlta.UseVisualStyleBackColor = True
        '
        'btnDarBaja
        '
        Me.btnDarBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarBaja.Location = New System.Drawing.Point(648, 163)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(196, 28)
        Me.btnDarBaja.TabIndex = 3
        Me.btnDarBaja.Text = "Dar de baja"
        Me.btnDarBaja.UseVisualStyleBackColor = True
        '
        'btnEditarNombre
        '
        Me.btnEditarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarNombre.Location = New System.Drawing.Point(648, 95)
        Me.btnEditarNombre.Name = "btnEditarNombre"
        Me.btnEditarNombre.Size = New System.Drawing.Size(196, 28)
        Me.btnEditarNombre.TabIndex = 2
        Me.btnEditarNombre.Text = "Editar nombre"
        Me.btnEditarNombre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Formas de Pago"
        '
        'dgvFormPago
        '
        Me.dgvFormPago.AllowUserToAddRows = False
        Me.dgvFormPago.AllowUserToDeleteRows = False
        Me.dgvFormPago.AllowUserToResizeRows = False
        Me.dgvFormPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFormPago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvFormPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFormPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idformpago, Me.nombFormaPago, Me.destacado, Me.recargo, Me.activo})
        Me.dgvFormPago.Location = New System.Drawing.Point(45, 61)
        Me.dgvFormPago.Name = "dgvFormPago"
        Me.dgvFormPago.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFormPago.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvFormPago.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvFormPago.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvFormPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFormPago.Size = New System.Drawing.Size(584, 198)
        Me.dgvFormPago.TabIndex = 0
        '
        'idformpago
        '
        Me.idformpago.DataPropertyName = "idformpago"
        Me.idformpago.HeaderText = "ID"
        Me.idformpago.Name = "idformpago"
        Me.idformpago.ReadOnly = True
        '
        'nombFormaPago
        '
        Me.nombFormaPago.DataPropertyName = "nombFormaPago"
        Me.nombFormaPago.HeaderText = "Nombre"
        Me.nombFormaPago.Name = "nombFormaPago"
        Me.nombFormaPago.ReadOnly = True
        '
        'destacado
        '
        Me.destacado.DataPropertyName = "destacado"
        Me.destacado.HeaderText = "Destacado"
        Me.destacado.Name = "destacado"
        Me.destacado.ReadOnly = True
        '
        'recargo
        '
        Me.recargo.DataPropertyName = "recargo"
        Me.recargo.HeaderText = "Recargo"
        Me.recargo.Name = "recargo"
        Me.recargo.ReadOnly = True
        '
        'activo
        '
        Me.activo.DataPropertyName = "activo"
        Me.activo.HeaderText = "Activo"
        Me.activo.Name = "activo"
        Me.activo.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(878, 565)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(547, 34)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(34, 25)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "X"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 597)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmOpciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones "
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tabConfiguraciones.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlEditar.ResumeLayout(False)
        Me.pnlEditar.PerformLayout()
        CType(Me.dgvFormPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tabConfiguraciones As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvFormPago As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDestacar As Button
    Friend WithEvents btnDarAlta As Button
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEditarNombre As Button
    Friend WithEvents pnlEditar As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblEditarAgregar As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditarRecargo As Button
    Friend WithEvents idformpago As DataGridViewTextBoxColumn
    Friend WithEvents nombFormaPago As DataGridViewTextBoxColumn
    Friend WithEvents destacado As DataGridViewTextBoxColumn
    Friend WithEvents recargo As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelar As Button
End Class
