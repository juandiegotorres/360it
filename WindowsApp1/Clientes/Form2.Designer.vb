<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBuscarFecha = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtClienteCtaCorriente = New System.Windows.Forms.TextBox()
        Me.dgvCajaMovimientos = New System.Windows.Forms.DataGridView()
        Me.nombreApel1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCajaMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarFecha
        '
        Me.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarFecha.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarFecha.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarFecha.Location = New System.Drawing.Point(436, 354)
        Me.btnBuscarFecha.Margin = New System.Windows.Forms.Padding(10, 10, 0, 10)
        Me.btnBuscarFecha.Name = "btnBuscarFecha"
        Me.btnBuscarFecha.Size = New System.Drawing.Size(213, 30)
        Me.btnBuscarFecha.TabIndex = 45
        Me.btnBuscarFecha.Text = "Buscar Fecha"
        Me.btnBuscarFecha.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.CalendarFont = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.CalendarTitleBackColor = System.Drawing.Color.Moccasin
        Me.dtpHasta.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(505, 306)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(144, 27)
        Me.dtpHasta.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(430, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 22)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Hasta:"
        '
        'dtpDesde
        '
        Me.dtpDesde.CalendarFont = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.CalendarTitleBackColor = System.Drawing.Color.Moccasin
        Me.dtpDesde.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDesde.Location = New System.Drawing.Point(505, 264)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(144, 27)
        Me.dtpDesde.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Desde:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(0, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 46
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.Location = New System.Drawing.Point(403, 70)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(49, 46)
        Me.RadioButton2.TabIndex = 47
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "$"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtClienteCtaCorriente
        '
        Me.txtClienteCtaCorriente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClienteCtaCorriente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClienteCtaCorriente.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteCtaCorriente.Location = New System.Drawing.Point(0, 0)
        Me.txtClienteCtaCorriente.Margin = New System.Windows.Forms.Padding(15, 8, 3, 3)
        Me.txtClienteCtaCorriente.Name = "txtClienteCtaCorriente"
        Me.txtClienteCtaCorriente.ReadOnly = True
        Me.txtClienteCtaCorriente.Size = New System.Drawing.Size(1073, 26)
        Me.txtClienteCtaCorriente.TabIndex = 48
        Me.txtClienteCtaCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtClienteCtaCorriente.Visible = False
        '
        'dgvCajaMovimientos
        '
        Me.dgvCajaMovimientos.AllowUserToAddRows = False
        Me.dgvCajaMovimientos.AllowUserToDeleteRows = False
        Me.dgvCajaMovimientos.AllowUserToOrderColumns = True
        Me.dgvCajaMovimientos.AllowUserToResizeRows = False
        Me.dgvCajaMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCajaMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCajaMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCajaMovimientos.CausesValidation = False
        Me.dgvCajaMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCajaMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCajaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCajaMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreApel1, Me.total1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCajaMovimientos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCajaMovimientos.EnableHeadersVisualStyles = False
        Me.dgvCajaMovimientos.Location = New System.Drawing.Point(306, 260)
        Me.dgvCajaMovimientos.Margin = New System.Windows.Forms.Padding(25, 30, 25, 25)
        Me.dgvCajaMovimientos.MultiSelect = False
        Me.dgvCajaMovimientos.Name = "dgvCajaMovimientos"
        Me.dgvCajaMovimientos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCajaMovimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCajaMovimientos.RowHeadersVisible = False
        Me.dgvCajaMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCajaMovimientos.Size = New System.Drawing.Size(460, 129)
        Me.dgvCajaMovimientos.TabIndex = 52
        '
        'nombreApel1
        '
        Me.nombreApel1.DataPropertyName = "nombreApel"
        Me.nombreApel1.HeaderText = "Nombre y Apellido"
        Me.nombreApel1.Name = "nombreApel1"
        Me.nombreApel1.ReadOnly = True
        '
        'total1
        '
        Me.total1.DataPropertyName = "Total"
        DataGridViewCellStyle2.Format = "C2"
        Me.total1.DefaultCellStyle = DataGridViewCellStyle2
        Me.total1.HeaderText = "Total"
        Me.total1.Name = "total1"
        Me.total1.ReadOnly = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 648)
        Me.Controls.Add(Me.dgvCajaMovimientos)
        Me.Controls.Add(Me.txtClienteCtaCorriente)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnBuscarFecha)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvCajaMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscarFecha As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtClienteCtaCorriente As TextBox
    Friend WithEvents dgvCajaMovimientos As DataGridView
    Friend WithEvents nombreApel1 As DataGridViewTextBoxColumn
    Friend WithEvents total1 As DataGridViewTextBoxColumn
End Class
