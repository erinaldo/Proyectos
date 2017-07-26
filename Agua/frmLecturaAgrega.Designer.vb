<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturaAgrega
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Capturar = New System.Windows.Forms.GroupBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbIdProyecto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbIdEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grdLecturas = New System.Windows.Forms.DataGridView()
        Me.btnAgregarLectura = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFacturas = New System.Windows.Forms.Button()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConsumo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Facturar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Capturar.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.grdLecturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Capturar
        '
        Me.Capturar.Controls.Add(Me.btnFiltrar)
        Me.Capturar.Controls.Add(Me.btnGrabar)
        Me.Capturar.Controls.Add(Me.Label3)
        Me.Capturar.Controls.Add(Me.cmbIdProyecto)
        Me.Capturar.Location = New System.Drawing.Point(12, 13)
        Me.Capturar.Name = "Capturar"
        Me.Capturar.Size = New System.Drawing.Size(342, 72)
        Me.Capturar.TabIndex = 3
        Me.Capturar.TabStop = False
        Me.Capturar.Text = "Captura de Lecturas"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.agua.My.Resources.Resources.document_zoom
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(261, 15)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 45)
        Me.btnFiltrar.TabIndex = 9
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(624, 31)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(55, 21)
        Me.btnGrabar.TabIndex = 10
        Me.btnGrabar.Text = "Agregar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Proyecto"
        '
        'cmbIdProyecto
        '
        Me.cmbIdProyecto.FormattingEnabled = True
        Me.cmbIdProyecto.Location = New System.Drawing.Point(56, 28)
        Me.cmbIdProyecto.Name = "cmbIdProyecto"
        Me.cmbIdProyecto.Size = New System.Drawing.Size(183, 21)
        Me.cmbIdProyecto.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Empleado"
        '
        'cmbIdEmpleado
        '
        Me.cmbIdEmpleado.FormattingEnabled = True
        Me.cmbIdEmpleado.Location = New System.Drawing.Point(76, 50)
        Me.cmbIdEmpleado.Name = "cmbIdEmpleado"
        Me.cmbIdEmpleado.Size = New System.Drawing.Size(176, 21)
        Me.cmbIdEmpleado.TabIndex = 4
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(76, 17)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(95, 20)
        Me.txtFecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-44, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 405)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1175, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel1.Text = "#Lecturas"
        '
        'grdLecturas
        '
        Me.grdLecturas.AllowUserToAddRows = False
        Me.grdLecturas.AllowUserToDeleteRows = False
        Me.grdLecturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLecturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdLecturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdLecturas.BackgroundColor = System.Drawing.Color.White
        Me.grdLecturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLecturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lectura, Me.NoFactura, Me.Facturar})
        Me.grdLecturas.GridColor = System.Drawing.Color.White
        Me.grdLecturas.Location = New System.Drawing.Point(21, 106)
        Me.grdLecturas.Name = "grdLecturas"
        Me.grdLecturas.Size = New System.Drawing.Size(1151, 296)
        Me.grdLecturas.TabIndex = 7
        '
        'btnAgregarLectura
        '
        Me.btnAgregarLectura.Image = Global.agua.My.Resources.Resources.save
        Me.btnAgregarLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarLectura.Location = New System.Drawing.Point(265, 45)
        Me.btnAgregarLectura.Name = "btnAgregarLectura"
        Me.btnAgregarLectura.Size = New System.Drawing.Size(79, 29)
        Me.btnAgregarLectura.TabIndex = 7
        Me.btnAgregarLectura.Text = "Agregar"
        Me.btnAgregarLectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarLectura.UseVisualStyleBackColor = True
        Me.btnAgregarLectura.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFacturas)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtConsumo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAgregarLectura)
        Me.GroupBox1.Controls.Add(Me.cmbIdEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(360, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 78)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grabar Lecturas"
        '
        'btnFacturas
        '
        Me.btnFacturas.Image = Global.agua.My.Resources.Resources.mail_new
        Me.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturas.Location = New System.Drawing.Point(558, 26)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(112, 32)
        Me.btnFacturas.TabIndex = 15
        Me.btnFacturas.Text = "Crear Factura"
        Me.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacturas.UseVisualStyleBackColor = True
        Me.btnFacturas.Visible = False
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Location = New System.Drawing.Point(390, 37)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigoCliente.TabIndex = 14
        Me.txtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Codigo Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Consumo"
        '
        'txtConsumo
        '
        Me.txtConsumo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtConsumo.Location = New System.Drawing.Point(248, 19)
        Me.txtConsumo.Name = "txtConsumo"
        Me.txtConsumo.Size = New System.Drawing.Size(96, 20)
        Me.txtConsumo.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Lectura"
        '
        'lectura
        '
        Me.lectura.DividerWidth = 15
        Me.lectura.Frozen = True
        Me.lectura.HeaderText = "Lectura"
        Me.lectura.Name = "lectura"
        Me.lectura.Width = 83
        '
        'NoFactura
        '
        Me.NoFactura.DividerWidth = 15
        Me.NoFactura.Frozen = True
        Me.NoFactura.HeaderText = "NoFactura"
        Me.NoFactura.Name = "NoFactura"
        Me.NoFactura.Width = 97
        '
        'Facturar
        '
        Me.Facturar.DividerWidth = 15
        Me.Facturar.Frozen = True
        Me.Facturar.HeaderText = "Facturar"
        Me.Facturar.Name = "Facturar"
        Me.Facturar.Text = "Facturar"
        Me.Facturar.ToolTipText = "Facturacion"
        Me.Facturar.Width = 67
        '
        'frmLecturaAgrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 427)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grdLecturas)
        Me.Controls.Add(Me.Capturar)
        Me.Name = "frmLecturaAgrega"
        Me.Text = "frmLecturaAgrega"
        Me.Capturar.ResumeLayout(False)
        Me.Capturar.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.grdLecturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Capturar As System.Windows.Forms.GroupBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbIdEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbIdProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarLectura As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grdLecturas As System.Windows.Forms.DataGridView
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConsumo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnFacturas As System.Windows.Forms.Button
    Friend WithEvents lectura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Facturar As System.Windows.Forms.DataGridViewButtonColumn
End Class
