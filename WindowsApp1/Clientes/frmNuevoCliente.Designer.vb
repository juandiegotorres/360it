<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNomApel = New System.Windows.Forms.TextBox()
        Me.cbProvincias = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnLocalidades = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 12)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.Image = Global.WindowsApp1.My.Resources.Resources.close
        Me.btnCerrar.Location = New System.Drawing.Point(489, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(27, 26)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Montserrat ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(138, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(285, 44)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Agregar cliente"
        '
        'txtNomApel
        '
        Me.txtNomApel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomApel.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomApel.Location = New System.Drawing.Point(148, 88)
        Me.txtNomApel.MaxLength = 45
        Me.txtNomApel.Name = "txtNomApel"
        Me.txtNomApel.Size = New System.Drawing.Size(291, 31)
        Me.txtNomApel.TabIndex = 0
        '
        'cbProvincias
        '
        Me.cbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvincias.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProvincias.FormattingEnabled = True
        Me.cbProvincias.Location = New System.Drawing.Point(148, 243)
        Me.cbProvincias.Name = "cbProvincias"
        Me.cbProvincias.Size = New System.Drawing.Size(219, 34)
        Me.cbProvincias.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 26)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nombre: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Teléfono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 26)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Provincia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 26)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Localidad"
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(148, 139)
        Me.txtTelefono.MaxLength = 25
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(237, 31)
        Me.txtTelefono.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(147, 191)
        Me.txtDireccion.MaxLength = 60
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(264, 31)
        Me.txtDireccion.TabIndex = 2
        '
        'txtLocalidad
        '
        Me.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalidad.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalidad.Location = New System.Drawing.Point(147, 298)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.ReadOnly = True
        Me.txtLocalidad.Size = New System.Drawing.Size(247, 31)
        Me.txtLocalidad.TabIndex = 22
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
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(344, 5)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(18, 5, 18, 15)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(128, 43)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        Me.btnGuardar.Location = New System.Drawing.Point(181, 5)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(18, 5, 18, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(127, 43)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
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
        Me.btnLimpiar.Size = New System.Drawing.Size(127, 43)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnLocalidades
        '
        Me.btnLocalidades.Location = New System.Drawing.Point(400, 298)
        Me.btnLocalidades.Name = "btnLocalidades"
        Me.btnLocalidades.Size = New System.Drawing.Size(38, 31)
        Me.btnLocalidades.TabIndex = 4
        Me.btnLocalidades.Text = "..."
        Me.btnLocalidades.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelar, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnGuardar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLimpiar, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 360)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(490, 63)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'frmNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 428)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnLocalidades)
        Me.Controls.Add(Me.txtLocalidad)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbProvincias)
        Me.Controls.Add(Me.txtNomApel)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmNuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNuevoCliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNomApel As TextBox
    Friend WithEvents cbProvincias As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnLocalidades As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
