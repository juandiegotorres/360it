<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiqueta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiqueta))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblFechaRecepcion = New System.Windows.Forms.Label()
        Me.lblTipoArticulo = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.timerImprimir = New System.Windows.Forms.Timer(Me.components)
        Me.imprimirEtiqueta = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources._6GxBTL0h_4x
        Me.PictureBox1.Location = New System.Drawing.Point(8, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblMarca
        '
        Me.lblMarca.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(206, 98)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(217, 22)
        Me.lblMarca.TabIndex = 1
        Me.lblMarca.Text = "Label1"
        Me.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaRecepcion
        '
        Me.lblFechaRecepcion.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRecepcion.Location = New System.Drawing.Point(206, 49)
        Me.lblFechaRecepcion.Name = "lblFechaRecepcion"
        Me.lblFechaRecepcion.Size = New System.Drawing.Size(218, 22)
        Me.lblFechaRecepcion.TabIndex = 2
        Me.lblFechaRecepcion.Text = "Label1"
        Me.lblFechaRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoArticulo
        '
        Me.lblTipoArticulo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoArticulo.Location = New System.Drawing.Point(206, 74)
        Me.lblTipoArticulo.Name = "lblTipoArticulo"
        Me.lblTipoArticulo.Size = New System.Drawing.Size(218, 22)
        Me.lblTipoArticulo.TabIndex = 3
        Me.lblTipoArticulo.Text = "Label1"
        Me.lblTipoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblModelo
        '
        Me.lblModelo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(206, 122)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(217, 27)
        Me.lblModelo.TabIndex = 4
        Me.lblModelo.Text = "Label1"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(1, 3)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(423, 42)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "Label1"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Poppins SemiBold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(2, 159)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(422, 29)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Label1"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'timerImprimir
        '
        Me.timerImprimir.Interval = 1000
        '
        'imprimirEtiqueta
        '
        Me.imprimirEtiqueta.DocumentName = "document"
        Me.imprimirEtiqueta.Form = Me
        Me.imprimirEtiqueta.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.imprimirEtiqueta.PrinterSettings = CType(resources.GetObject("imprimirEtiqueta.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.imprimirEtiqueta.PrintFileName = Nothing
        '
        'frmEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(426, 196)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblTipoArticulo)
        Me.Controls.Add(Me.lblFechaRecepcion)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEtiqueta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEtiqueta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblFechaRecepcion As Label
    Friend WithEvents lblTipoArticulo As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents timerImprimir As Timer
    Friend WithEvents imprimirEtiqueta As PowerPacks.Printing.PrintForm
End Class
