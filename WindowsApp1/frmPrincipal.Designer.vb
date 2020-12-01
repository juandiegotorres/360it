<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelCost = New System.Windows.Forms.Panel()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnServTecnico = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.pnlSubMenuVentas = New System.Windows.Forms.Panel()
        Me.btnHistorialVentas = New System.Windows.Forms.Button()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.btnCuentaCorriente = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnWEB = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnAgrandar = New System.Windows.Forms.PictureBox()
        Me.btnAchicar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.pnlSubMenuVentas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgrandar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAchicar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.panelCost)
        Me.Panel1.Controls.Add(Me.btnProveedores)
        Me.Panel1.Controls.Add(Me.btnServTecnico)
        Me.Panel1.Controls.Add(Me.btnProductos)
        Me.Panel1.Controls.Add(Me.btnClientes)
        Me.Panel1.Controls.Add(Me.pnlSubMenuVentas)
        Me.Panel1.Controls.Add(Me.btnVentas)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btnWEB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 703)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(52, 595)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 28)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "WEB"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(52, 629)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 28)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "WEB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'panelCost
        '
        Me.panelCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelCost.Location = New System.Drawing.Point(0, 101)
        Me.panelCost.Name = "panelCost"
        Me.panelCost.Size = New System.Drawing.Size(8, 45)
        Me.panelCost.TabIndex = 31
        Me.panelCost.Visible = False
        '
        'btnProveedores
        '
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Image = Global.WindowsApp1.My.Resources.Resources.baseline_local_shipping_white_18dp
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(0, 443)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnProveedores.Size = New System.Drawing.Size(209, 45)
        Me.btnProveedores.TabIndex = 35
        Me.btnProveedores.Text = "     Proveedores"
        Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnServTecnico
        '
        Me.btnServTecnico.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnServTecnico.FlatAppearance.BorderSize = 0
        Me.btnServTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServTecnico.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServTecnico.ForeColor = System.Drawing.Color.White
        Me.btnServTecnico.Image = CType(resources.GetObject("btnServTecnico.Image"), System.Drawing.Image)
        Me.btnServTecnico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServTecnico.Location = New System.Drawing.Point(0, 398)
        Me.btnServTecnico.Name = "btnServTecnico"
        Me.btnServTecnico.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnServTecnico.Size = New System.Drawing.Size(209, 45)
        Me.btnServTecnico.TabIndex = 41
        Me.btnServTecnico.Text = "     Serv. Técnico"
        Me.btnServTecnico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnServTecnico.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 353)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnProductos.Size = New System.Drawing.Size(209, 45)
        Me.btnProductos.TabIndex = 36
        Me.btnProductos.Text = "     Productos"
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 308)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnClientes.Size = New System.Drawing.Size(209, 45)
        Me.btnClientes.TabIndex = 33
        Me.btnClientes.Text = "     Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'pnlSubMenuVentas
        '
        Me.pnlSubMenuVentas.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pnlSubMenuVentas.Controls.Add(Me.btnHistorialVentas)
        Me.pnlSubMenuVentas.Controls.Add(Me.btnCaja)
        Me.pnlSubMenuVentas.Controls.Add(Me.btnCuentaCorriente)
        Me.pnlSubMenuVentas.Controls.Add(Me.btnVender)
        Me.pnlSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSubMenuVentas.Location = New System.Drawing.Point(0, 146)
        Me.pnlSubMenuVentas.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSubMenuVentas.Name = "pnlSubMenuVentas"
        Me.pnlSubMenuVentas.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.pnlSubMenuVentas.Size = New System.Drawing.Size(209, 162)
        Me.pnlSubMenuVentas.TabIndex = 32
        Me.pnlSubMenuVentas.Visible = False
        '
        'btnHistorialVentas
        '
        Me.btnHistorialVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistorialVentas.FlatAppearance.BorderSize = 0
        Me.btnHistorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialVentas.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialVentas.ForeColor = System.Drawing.Color.White
        Me.btnHistorialVentas.Image = Global.WindowsApp1.My.Resources.Resources.baseline_history_white_18dpx28
        Me.btnHistorialVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistorialVentas.Location = New System.Drawing.Point(28, 120)
        Me.btnHistorialVentas.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btnHistorialVentas.Name = "btnHistorialVentas"
        Me.btnHistorialVentas.Size = New System.Drawing.Size(181, 40)
        Me.btnHistorialVentas.TabIndex = 32
        Me.btnHistorialVentas.Text = "     Historial"
        Me.btnHistorialVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistorialVentas.UseVisualStyleBackColor = True
        '
        'btnCaja
        '
        Me.btnCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCaja.FlatAppearance.BorderSize = 0
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaja.ForeColor = System.Drawing.Color.White
        Me.btnCaja.Image = Global.WindowsApp1.My.Resources.Resources.caja36dpx28
        Me.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCaja.Location = New System.Drawing.Point(28, 80)
        Me.btnCaja.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(181, 40)
        Me.btnCaja.TabIndex = 36
        Me.btnCaja.Text = "     Caja"
        Me.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCaja.UseVisualStyleBackColor = True
        '
        'btnCuentaCorriente
        '
        Me.btnCuentaCorriente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCuentaCorriente.FlatAppearance.BorderSize = 0
        Me.btnCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentaCorriente.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuentaCorriente.ForeColor = System.Drawing.Color.White
        Me.btnCuentaCorriente.Image = Global.WindowsApp1.My.Resources.Resources.ctacorriente36dpx28
        Me.btnCuentaCorriente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuentaCorriente.Location = New System.Drawing.Point(28, 40)
        Me.btnCuentaCorriente.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btnCuentaCorriente.Name = "btnCuentaCorriente"
        Me.btnCuentaCorriente.Size = New System.Drawing.Size(181, 40)
        Me.btnCuentaCorriente.TabIndex = 31
        Me.btnCuentaCorriente.Text = "     Ctas. Corriente"
        Me.btnCuentaCorriente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCuentaCorriente.UseVisualStyleBackColor = True
        '
        'btnVender
        '
        Me.btnVender.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVender.FlatAppearance.BorderSize = 0
        Me.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVender.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVender.ForeColor = System.Drawing.Color.White
        Me.btnVender.Image = Global.WindowsApp1.My.Resources.Resources.vender36dpx28
        Me.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVender.Location = New System.Drawing.Point(28, 0)
        Me.btnVender.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(181, 40)
        Me.btnVender.TabIndex = 30
        Me.btnVender.Text = "     Vender"
        Me.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 101)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnVentas.Size = New System.Drawing.Size(209, 45)
        Me.btnVentas.TabIndex = 29
        Me.btnVentas.Text = "     Ventas"
        Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(209, 101)
        Me.Panel5.TabIndex = 6
        '
        'btnWEB
        '
        Me.btnWEB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWEB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWEB.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWEB.Location = New System.Drawing.Point(52, 663)
        Me.btnWEB.Name = "btnWEB"
        Me.btnWEB.Size = New System.Drawing.Size(84, 28)
        Me.btnWEB.TabIndex = 5
        Me.btnWEB.Text = "WEB"
        Me.btnWEB.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(209, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1025, 12)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(21, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 77)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(215, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 54)
        Me.Panel4.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(321, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "360 Informática y tecnología"
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedor.Controls.Add(Me.PictureBox3)
        Me.pnlContenedor.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlContenedor.Location = New System.Drawing.Point(209, 53)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1025, 650)
        Me.pnlContenedor.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(209, 114)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(590, 250)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMinimizar.Image = Global.WindowsApp1.My.Resources.Resources.minimize
        Me.btnMinimizar.Location = New System.Drawing.Point(1121, 13)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 34)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 9
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.Image = Global.WindowsApp1.My.Resources.Resources.close
        Me.btnCerrar.Location = New System.Drawing.Point(1200, 13)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 34)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.TabStop = False
        '
        'btnAgrandar
        '
        Me.btnAgrandar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgrandar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgrandar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgrandar.Image = Global.WindowsApp1.My.Resources.Resources.maximized
        Me.btnAgrandar.Location = New System.Drawing.Point(1161, 13)
        Me.btnAgrandar.Name = "btnAgrandar"
        Me.btnAgrandar.Size = New System.Drawing.Size(34, 34)
        Me.btnAgrandar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgrandar.TabIndex = 7
        Me.btnAgrandar.TabStop = False
        Me.btnAgrandar.Visible = False
        '
        'btnAchicar
        '
        Me.btnAchicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAchicar.BackColor = System.Drawing.Color.Transparent
        Me.btnAchicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAchicar.Image = Global.WindowsApp1.My.Resources.Resources.maximize
        Me.btnAchicar.Location = New System.Drawing.Point(1161, 13)
        Me.btnAchicar.Name = "btnAchicar"
        Me.btnAchicar.Size = New System.Drawing.Size(34, 34)
        Me.btnAchicar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAchicar.TabIndex = 8
        Me.btnAchicar.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1234, 703)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.btnAgrandar)
        Me.Controls.Add(Me.btnAchicar)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnlSubMenuVentas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgrandar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAchicar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnWEB As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnAgrandar As PictureBox
    Friend WithEvents btnAchicar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnlSubMenuVentas As Panel
    Friend WithEvents btnHistorialVentas As Button
    Friend WithEvents btnCaja As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents panelCost As Panel
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnCuentaCorriente As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnServTecnico As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
