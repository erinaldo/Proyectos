<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacion
    Inherits agua.frmBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignacion))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnContrato = New System.Windows.Forms.Button()
        Me.txtNoServicios = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLecturaInicial = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtManzana = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFechaInstalacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtIdProyecto = New System.Windows.Forms.TextBox()
        Me.txtIdAsignacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAsignarContador = New System.Windows.Forms.Button()
        Me.btnReporte2 = New System.Windows.Forms.Button()
        Me.pnlReporte = New System.Windows.Forms.Panel()
        Me.btnVerReporte = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.pnlReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.btnContrato)
        Me.pnl1.Controls.Add(Me.txtNoServicios)
        Me.pnl1.Controls.Add(Me.Label12)
        Me.pnl1.Controls.Add(Me.txtSaldoInicial)
        Me.pnl1.Controls.Add(Me.Label13)
        Me.pnl1.Controls.Add(Me.txtLecturaInicial)
        Me.pnl1.Controls.Add(Me.Label11)
        Me.pnl1.Controls.Add(Me.txtLote)
        Me.pnl1.Controls.Add(Me.Label10)
        Me.pnl1.Controls.Add(Me.txtManzana)
        Me.pnl1.Controls.Add(Me.Label9)
        Me.pnl1.Controls.Add(Me.txtCliente)
        Me.pnl1.Controls.Add(Me.txtProyecto)
        Me.pnl1.Controls.Add(Me.txtFecha)
        Me.pnl1.Controls.Add(Me.Label8)
        Me.pnl1.Controls.Add(Me.txtObservacion)
        Me.pnl1.Controls.Add(Me.Label7)
        Me.pnl1.Controls.Add(Me.txtFechaInstalacion)
        Me.pnl1.Controls.Add(Me.Label6)
        Me.pnl1.Controls.Add(Me.txtDireccion)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.txtIdCliente)
        Me.pnl1.Controls.Add(Me.txtIdProyecto)
        Me.pnl1.Controls.Add(Me.txtIdAsignacion)
        Me.pnl1.Controls.Add(Me.Label5)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(6, 41)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(492, 302)
        Me.pnl1.TabIndex = 0
        '
        'btnContrato
        '
        Me.btnContrato.Image = CType(resources.GetObject("btnContrato.Image"), System.Drawing.Image)
        Me.btnContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContrato.Location = New System.Drawing.Point(388, 9)
        Me.btnContrato.Name = "btnContrato"
        Me.btnContrato.Size = New System.Drawing.Size(75, 23)
        Me.btnContrato.TabIndex = 34
        Me.btnContrato.Text = "Contrato"
        Me.btnContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnContrato.UseVisualStyleBackColor = True
        '
        'txtNoServicios
        '
        Me.txtNoServicios.Location = New System.Drawing.Point(85, 120)
        Me.txtNoServicios.Name = "txtNoServicios"
        Me.txtNoServicios.Size = New System.Drawing.Size(26, 20)
        Me.txtNoServicios.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "# Servicios"
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(285, 224)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoInicial.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(206, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Saldo Inicial"
        '
        'txtLecturaInicial
        '
        Me.txtLecturaInicial.Location = New System.Drawing.Point(85, 224)
        Me.txtLecturaInicial.Name = "txtLecturaInicial"
        Me.txtLecturaInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtLecturaInicial.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Lectura Inicial"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(187, 146)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(26, 20)
        Me.txtLote.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(116, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Lote"
        '
        'txtManzana
        '
        Me.txtManzana.Location = New System.Drawing.Point(85, 146)
        Me.txtManzana.Name = "txtManzana"
        Me.txtManzana.Size = New System.Drawing.Size(26, 20)
        Me.txtManzana.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Manzana"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(117, 94)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(346, 20)
        Me.txtCliente.TabIndex = 22
        '
        'txtProyecto
        '
        Me.txtProyecto.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtProyecto.Enabled = False
        Me.txtProyecto.Location = New System.Drawing.Point(117, 68)
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.Size = New System.Drawing.Size(346, 20)
        Me.txtProyecto.TabIndex = 21
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(85, 42)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Fecha"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(85, 266)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(378, 20)
        Me.txtObservacion.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Observacion"
        '
        'txtFechaInstalacion
        '
        Me.txtFechaInstalacion.Location = New System.Drawing.Point(85, 198)
        Me.txtFechaInstalacion.Name = "txtFechaInstalacion"
        Me.txtFechaInstalacion.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaInstalacion.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Fecha Inst"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(85, 172)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(378, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Direccion"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(85, 94)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(26, 20)
        Me.txtIdCliente.TabIndex = 2
        '
        'txtIdProyecto
        '
        Me.txtIdProyecto.Location = New System.Drawing.Point(85, 68)
        Me.txtIdProyecto.Name = "txtIdProyecto"
        Me.txtIdProyecto.Size = New System.Drawing.Size(26, 20)
        Me.txtIdProyecto.TabIndex = 1
        '
        'txtIdAsignacion
        '
        Me.txtIdAsignacion.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdAsignacion.Enabled = False
        Me.txtIdAsignacion.Location = New System.Drawing.Point(85, 11)
        Me.txtIdAsignacion.Name = "txtIdAsignacion"
        Me.txtIdAsignacion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdAsignacion.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Proyecto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id"
        '
        'btnAsignarContador
        '
        Me.btnAsignarContador.Image = Global.agua.My.Resources.Resources.refresh
        Me.btnAsignarContador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignarContador.Location = New System.Drawing.Point(399, 1)
        Me.btnAsignarContador.Name = "btnAsignarContador"
        Me.btnAsignarContador.Size = New System.Drawing.Size(99, 35)
        Me.btnAsignarContador.TabIndex = 45
        Me.btnAsignarContador.Text = "Contadores"
        Me.btnAsignarContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignarContador.UseVisualStyleBackColor = True
        '
        'btnReporte2
        '
        Me.btnReporte2.Location = New System.Drawing.Point(504, 1)
        Me.btnReporte2.Name = "btnReporte2"
        Me.btnReporte2.Size = New System.Drawing.Size(75, 38)
        Me.btnReporte2.TabIndex = 47
        Me.btnReporte2.Text = "Reporte"
        Me.btnReporte2.UseVisualStyleBackColor = True
        '
        'pnlReporte
        '
        Me.pnlReporte.Controls.Add(Me.btnVerReporte)
        Me.pnlReporte.Controls.Add(Me.Label14)
        Me.pnlReporte.Controls.Add(Me.Label15)
        Me.pnlReporte.Controls.Add(Me.dtpHasta)
        Me.pnlReporte.Controls.Add(Me.dtpDesde)
        Me.pnlReporte.Location = New System.Drawing.Point(410, 4)
        Me.pnlReporte.Name = "pnlReporte"
        Me.pnlReporte.Size = New System.Drawing.Size(220, 96)
        Me.pnlReporte.TabIndex = 48
        Me.pnlReporte.Visible = False
        '
        'btnVerReporte
        '
        Me.btnVerReporte.Location = New System.Drawing.Point(83, 64)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(75, 22)
        Me.btnVerReporte.TabIndex = 47
        Me.btnVerReporte.Text = "Ver"
        Me.btnVerReporte.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Hasta"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Desde"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(78, 35)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(107, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(78, 9)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(107, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'frmAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(689, 552)
        Me.Controls.Add(Me.pnlReporte)
        Me.Controls.Add(Me.btnReporte2)
        Me.Controls.Add(Me.btnAsignarContador)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmAsignacion"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        Me.Controls.SetChildIndex(Me.btnAsignarContador, 0)
        Me.Controls.SetChildIndex(Me.btnReporte2, 0)
        Me.Controls.SetChildIndex(Me.pnlReporte, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnlReporte.ResumeLayout(False)
        Me.pnlReporte.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFechaInstalacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtIdAsignacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtProyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtManzana As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLecturaInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnAsignarContador As System.Windows.Forms.Button
    Friend WithEvents txtNoServicios As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnContrato As System.Windows.Forms.Button
    Friend WithEvents btnReporte2 As System.Windows.Forms.Button
    Friend WithEvents pnlReporte As System.Windows.Forms.Panel
    Friend WithEvents btnVerReporte As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker

End Class
