<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cmbIdProyecto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdLecturas = New System.Windows.Forms.DataGridView()
        Me.Imprimir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.NoBoleta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rebajar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnNuevaLectura = New System.Windows.Forms.Button()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdLecturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbFechaInicio)
        Me.GroupBox1.Controls.Add(Me.cmbIdProyecto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 68)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'cmbFechaFin
        '
        Me.cmbFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFechaFin.Location = New System.Drawing.Point(101, 33)
        Me.cmbFechaFin.Name = "cmbFechaFin"
        Me.cmbFechaFin.Size = New System.Drawing.Size(89, 20)
        Me.cmbFechaFin.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.agua.My.Resources.Resources.document_zoom
        Me.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltrar.Location = New System.Drawing.Point(382, 19)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 34)
        Me.btnFiltrar.TabIndex = 1
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Proyecto"
        '
        'cmbFechaInicio
        '
        Me.cmbFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFechaInicio.Location = New System.Drawing.Point(6, 33)
        Me.cmbFechaInicio.Name = "cmbFechaInicio"
        Me.cmbFechaInicio.Size = New System.Drawing.Size(89, 20)
        Me.cmbFechaInicio.TabIndex = 0
        '
        'cmbIdProyecto
        '
        Me.cmbIdProyecto.BackColor = System.Drawing.SystemColors.Info
        Me.cmbIdProyecto.FormattingEnabled = True
        Me.cmbIdProyecto.Location = New System.Drawing.Point(196, 32)
        Me.cmbIdProyecto.Name = "cmbIdProyecto"
        Me.cmbIdProyecto.Size = New System.Drawing.Size(180, 21)
        Me.cmbIdProyecto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
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
        Me.grdLecturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imprimir, Me.NoBoleta, Me.NoRecibo, Me.Rebajar})
        Me.grdLecturas.GridColor = System.Drawing.Color.White
        Me.grdLecturas.Location = New System.Drawing.Point(12, 86)
        Me.grdLecturas.Name = "grdLecturas"
        Me.grdLecturas.Size = New System.Drawing.Size(1057, 360)
        Me.grdLecturas.TabIndex = 6
        '
        'Imprimir
        '
        Me.Imprimir.DividerWidth = 15
        Me.Imprimir.Frozen = True
        Me.Imprimir.HeaderText = "Imprimir"
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.ToolTipText = "Imprimir factura actual"
        Me.Imprimir.Width = 63
        '
        'NoBoleta
        '
        Me.NoBoleta.DividerWidth = 15
        Me.NoBoleta.Frozen = True
        Me.NoBoleta.HeaderText = "NoBoleta"
        Me.NoBoleta.Name = "NoBoleta"
        Me.NoBoleta.Width = 91
        '
        'NoRecibo
        '
        Me.NoRecibo.DividerWidth = 15
        Me.NoRecibo.Frozen = True
        Me.NoRecibo.HeaderText = "NoRecibo"
        Me.NoRecibo.Name = "NoRecibo"
        Me.NoRecibo.Width = 95
        '
        'Rebajar
        '
        Me.Rebajar.DividerWidth = 15
        Me.Rebajar.Frozen = True
        Me.Rebajar.HeaderText = "Rebajar"
        Me.Rebajar.Name = "Rebajar"
        Me.Rebajar.Width = 65
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProducto)
        Me.GroupBox2.Controls.Add(Me.btnAnular)
        Me.GroupBox2.Controls.Add(Me.btnNuevaLectura)
        Me.GroupBox2.Location = New System.Drawing.Point(493, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 68)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnProducto
        '
        Me.btnProducto.Image = Global.agua.My.Resources.Resources.blank
        Me.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.Location = New System.Drawing.Point(169, 17)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(75, 38)
        Me.btnProducto.TabIndex = 8
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProducto.UseVisualStyleBackColor = True
        Me.btnProducto.Visible = False
        '
        'btnAnular
        '
        Me.btnAnular.Image = Global.agua.My.Resources.Resources.agt_action_fail1
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnular.Location = New System.Drawing.Point(89, 17)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(75, 38)
        Me.btnAnular.TabIndex = 7
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'btnNuevaLectura
        '
        Me.btnNuevaLectura.Image = Global.agua.My.Resources.Resources.blank
        Me.btnNuevaLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaLectura.Location = New System.Drawing.Point(8, 15)
        Me.btnNuevaLectura.Name = "btnNuevaLectura"
        Me.btnNuevaLectura.Size = New System.Drawing.Size(75, 38)
        Me.btnNuevaLectura.TabIndex = 5
        Me.btnNuevaLectura.Text = "Servicio"
        Me.btnNuevaLectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevaLectura.UseVisualStyleBackColor = True
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Location = New System.Drawing.Point(781, 42)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigoCliente.TabIndex = 16
        Me.txtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(792, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Codigo Cliente"
        '
        'frmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 458)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grdLecturas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFacturas"
        Me.Text = "frmListadoFacturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdLecturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbIdProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnNuevaLectura As System.Windows.Forms.Button
    Friend WithEvents grdLecturas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProducto As System.Windows.Forms.Button
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Imprimir As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents NoBoleta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rebajar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
