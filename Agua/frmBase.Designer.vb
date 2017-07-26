<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBase))
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.status1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.status2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.status3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grdDatos = New System.Windows.Forms.DataGridView()
        Me.ColumnaFiltros = New System.Windows.Forms.ComboBox()
        Me.ValorFiltro = New System.Windows.Forms.TextBox()
        Me.lblColumnaFiltro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.contMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ocultarFiltro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mostrarFiltro = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusBar.SuspendLayout()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.contMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status1, Me.status2, Me.status3})
        Me.statusBar.Location = New System.Drawing.Point(0, 403)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(686, 22)
        Me.statusBar.TabIndex = 2
        Me.statusBar.Text = "statusBar"
        '
        'status1
        '
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(0, 17)
        '
        'status2
        '
        Me.status2.Name = "status2"
        Me.status2.Size = New System.Drawing.Size(0, 17)
        '
        'status3
        '
        Me.status3.Name = "status3"
        Me.status3.Size = New System.Drawing.Size(0, 17)
        '
        'grdDatos
        '
        Me.grdDatos.AllowUserToAddRows = False
        Me.grdDatos.AllowUserToDeleteRows = False
        Me.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.grdDatos.Location = New System.Drawing.Point(0, 279)
        Me.grdDatos.MultiSelect = False
        Me.grdDatos.Name = "grdDatos"
        Me.grdDatos.ReadOnly = True
        Me.grdDatos.Size = New System.Drawing.Size(686, 124)
        Me.grdDatos.TabIndex = 6
        '
        'ColumnaFiltros
        '
        Me.ColumnaFiltros.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ColumnaFiltros.FormattingEnabled = True
        Me.ColumnaFiltros.Location = New System.Drawing.Point(3, 33)
        Me.ColumnaFiltros.Name = "ColumnaFiltros"
        Me.ColumnaFiltros.Size = New System.Drawing.Size(106, 21)
        Me.ColumnaFiltros.TabIndex = 45
        '
        'ValorFiltro
        '
        Me.ValorFiltro.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ValorFiltro.Location = New System.Drawing.Point(115, 33)
        Me.ValorFiltro.Name = "ValorFiltro"
        Me.ValorFiltro.Size = New System.Drawing.Size(93, 20)
        Me.ValorFiltro.TabIndex = 46
        '
        'lblColumnaFiltro
        '
        Me.lblColumnaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblColumnaFiltro.Location = New System.Drawing.Point(3, 17)
        Me.lblColumnaFiltro.Name = "lblColumnaFiltro"
        Me.lblColumnaFiltro.Size = New System.Drawing.Size(48, 13)
        Me.lblColumnaFiltro.TabIndex = 0
        Me.lblColumnaFiltro.Text = "Columna"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(115, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4723!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.52769!))
        Me.TableLayoutPanel1.Controls.Add(Me.ValorFiltro, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblColumnaFiltro, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ColumnaFiltros, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 219)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(686, 60)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(156, 1)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(80, 38)
        Me.btnModificar.TabIndex = 42
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(312, 1)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(80, 38)
        Me.btnReporte.TabIndex = 44
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReporte.UseVisualStyleBackColor = False
        Me.btnReporte.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(234, 1)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(80, 38)
        Me.btnBorrar.TabIndex = 43
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(78, 1)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(80, 38)
        Me.btnGrabar.TabIndex = 41
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(0, 1)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(80, 38)
        Me.btnNuevo.TabIndex = 40
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'contMenu
        '
        Me.contMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ocultarFiltro, Me.mostrarFiltro})
        Me.contMenu.Name = "contMenu"
        Me.contMenu.Size = New System.Drawing.Size(146, 48)
        '
        'ocultarFiltro
        '
        Me.ocultarFiltro.Name = "ocultarFiltro"
        Me.ocultarFiltro.Size = New System.Drawing.Size(145, 22)
        Me.ocultarFiltro.Text = "Ocultar Filtro"
        '
        'mostrarFiltro
        '
        Me.mostrarFiltro.Name = "mostrarFiltro"
        Me.mostrarFiltro.Size = New System.Drawing.Size(145, 22)
        Me.mostrarFiltro.Text = "Mostrar Filtro"
        '
        'frmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 425)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grdDatos)
        Me.Controls.Add(Me.statusBar)
        Me.Name = "frmBase"
        Me.Text = "frmBase"
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.contMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColumnaFiltros As System.Windows.Forms.ComboBox
    Friend WithEvents ValorFiltro As System.Windows.Forms.TextBox
    Friend WithEvents lblColumnaFiltro As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents contMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ocultarFiltro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mostrarFiltro As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents grdDatos As System.Windows.Forms.DataGridView
End Class
