<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolNotasCreditosAutoriza
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.cmbIdProyecto = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.grdLecturas = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Contador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Autorizada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rechazada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Autoriza = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Rechaza = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.grdLecturas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Size = New System.Drawing.Size(481, 68)
        Me.GroupBox1.TabIndex = 4
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
        Me.btnFiltrar.Size = New System.Drawing.Size(93, 43)
        Me.btnFiltrar.TabIndex = 1
        Me.btnFiltrar.Text = "Filtrar"
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 349)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(729, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 17)
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
        Me.grdLecturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLecturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Cliente, Me.Direccion, Me.Contador, Me.Monto, Me.Codigo, Me.Tipo, Me.Usuario, Me.Observacion, Me.Autorizada, Me.Rechazada, Me.IdAsignacion, Me.Autoriza, Me.Rechaza})
        Me.grdLecturas.Location = New System.Drawing.Point(12, 89)
        Me.grdLecturas.Name = "grdLecturas"
        Me.grdLecturas.Size = New System.Drawing.Size(708, 255)
        Me.grdLecturas.TabIndex = 5
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Width = 41
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 62
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 64
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Width = 77
        '
        'Contador
        '
        Me.Contador.DataPropertyName = "Contador"
        Me.Contador.HeaderText = "Contador"
        Me.Contador.Name = "Contador"
        Me.Contador.Width = 75
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Width = 62
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 65
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 53
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Width = 68
        '
        'Observacion
        '
        Me.Observacion.DataPropertyName = "Observacion"
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.Width = 92
        '
        'Autorizada
        '
        Me.Autorizada.DataPropertyName = "Autorizada"
        Me.Autorizada.HeaderText = "Autorizada"
        Me.Autorizada.Name = "Autorizada"
        Me.Autorizada.Width = 82
        '
        'Rechazada
        '
        Me.Rechazada.DataPropertyName = "Rechazada"
        Me.Rechazada.HeaderText = "Rechazada"
        Me.Rechazada.Name = "Rechazada"
        Me.Rechazada.Width = 87
        '
        'IdAsignacion
        '
        Me.IdAsignacion.DataPropertyName = "IdAsignacion"
        Me.IdAsignacion.HeaderText = "IdAsignacion"
        Me.IdAsignacion.Name = "IdAsignacion"
        Me.IdAsignacion.Width = 93
        '
        'Autoriza
        '
        Me.Autoriza.HeaderText = ""
        Me.Autoriza.Name = "Autoriza"
        Me.Autoriza.Text = "Autoriza"
        Me.Autoriza.UseColumnTextForButtonValue = True
        Me.Autoriza.Width = 5
        '
        'Rechaza
        '
        Me.Rechaza.HeaderText = ""
        Me.Rechaza.Name = "Rechaza"
        Me.Rechaza.Text = "Rechaza"
        Me.Rechaza.UseColumnTextForButtonValue = True
        Me.Rechaza.Width = 5
        '
        'frmSolNotasCreditosAutoriza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 371)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grdLecturas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSolNotasCreditosAutoriza"
        Me.Text = "Solicitud Notas de credito"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.grdLecturas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grdLecturas As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autorizada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rechazada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAsignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autoriza As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Rechaza As System.Windows.Forms.DataGridViewButtonColumn
End Class
