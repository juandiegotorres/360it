<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevaReparacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaReparacion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTipoArticulo = New System.Windows.Forms.ComboBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtAccesorios = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chbSinFecha = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 10)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Montserrat ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(138, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(352, 44)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Agregar reparación"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderSize = 2
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(18, 5)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(18, 5, 18, 15)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(147, 43)
        Me.btnLimpiar.TabIndex = 56
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 2
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(201, 5)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(18, 5, 18, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(147, 43)
        Me.btnGuardar.TabIndex = 54
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(384, 5)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(18, 5, 18, 15)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(147, 43)
        Me.btnCancelar.TabIndex = 55
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(192, 193)
        Me.txtMarca.MaxLength = 25
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(291, 31)
        Me.txtMarca.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 26)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 26)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Cliente:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(192, 87)
        Me.txtNombreCliente.MaxLength = 45
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(291, 31)
        Me.txtNombreCliente.TabIndex = 50
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(489, 87)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(44, 31)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "..."
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 26)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Tipo artículo:"
        '
        'cbTipoArticulo
        '
        Me.cbTipoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoArticulo.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoArticulo.FormattingEnabled = True
        Me.cbTipoArticulo.Location = New System.Drawing.Point(192, 140)
        Me.cbTipoArticulo.Name = "cbTipoArticulo"
        Me.cbTipoArticulo.Size = New System.Drawing.Size(234, 34)
        Me.cbTipoArticulo.TabIndex = 2
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(192, 246)
        Me.txtModelo.MaxLength = 25
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(291, 31)
        Me.txtModelo.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 26)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Modelo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 26)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(192, 299)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(234, 34)
        Me.cbEstado.TabIndex = 5
        '
        'txtAccesorios
        '
        Me.txtAccesorios.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccesorios.Location = New System.Drawing.Point(190, 483)
        Me.txtAccesorios.MaxLength = 99
        Me.txtAccesorios.Multiline = True
        Me.txtAccesorios.Name = "txtAccesorios"
        Me.txtAccesorios.Size = New System.Drawing.Size(341, 60)
        Me.txtAccesorios.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(190, 573)
        Me.txtDescripcion.MaxLength = 149
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(341, 96)
        Me.txtDescripcion.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 576)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 26)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 486)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 26)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Accesorios:"
        '
        'dtEntrega
        '
        Me.dtEntrega.CalendarFont = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEntrega.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntrega.Location = New System.Drawing.Point(192, 420)
        Me.dtEntrega.Name = "dtEntrega"
        Me.dtEntrega.Size = New System.Drawing.Size(157, 31)
        Me.dtEntrega.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 26)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "entrega"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 26)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Fecha de :"
        '
        'dtRecepcion
        '
        Me.dtRecepcion.CalendarFont = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRecepcion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtRecepcion.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRecepcion.Location = New System.Drawing.Point(190, 360)
        Me.dtRecepcion.Name = "dtRecepcion"
        Me.dtRecepcion.Size = New System.Drawing.Size(159, 31)
        Me.dtRecepcion.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 26)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "recepción"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 26)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Fecha de :"
        '
        'chbSinFecha
        '
        Me.chbSinFecha.AutoSize = True
        Me.chbSinFecha.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSinFecha.Location = New System.Drawing.Point(192, 457)
        Me.chbSinFecha.Name = "chbSinFecha"
        Me.chbSinFecha.Size = New System.Drawing.Size(139, 19)
        Me.chbSinFecha.TabIndex = 99
        Me.chbSinFecha.Text = "Sin fecha de entrega"
        Me.chbSinFecha.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLimpiar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnGuardar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelar, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 685)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(549, 63)
        Me.TableLayoutPanel1.TabIndex = 100
        '
        'frmNuevaReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 753)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.chbSinFecha)
        Me.Controls.Add(Me.dtEntrega)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtRecepcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAccesorios)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbTipoArticulo)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmNuevaReparacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNuevaReparacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents btnClientes As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTipoArticulo As ComboBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents txtAccesorios As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtEntrega As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtRecepcion As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chbSinFecha As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
