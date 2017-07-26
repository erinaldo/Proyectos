<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaProducto))
        Me.Capturar = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoFactura = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbIdEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbIdProyecto = New System.Windows.Forms.ComboBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtLectura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarLectura = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFechaBoleta = New System.Windows.Forms.DateTimePicker()
        Me.txtNoBoleta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPagoSinMora = New System.Windows.Forms.Label()
        Me.lblFechaLecturaPago = New System.Windows.Forms.Label()
        Me.cmbIdContador = New System.Windows.Forms.ComboBox()
        Me.Capturar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Capturar
        '
        Me.Capturar.Controls.Add(Me.cmbIdContador)
        Me.Capturar.Controls.Add(Me.Label9)
        Me.Capturar.Controls.Add(Me.txtCliente)
        Me.Capturar.Controls.Add(Me.Label6)
        Me.Capturar.Controls.Add(Me.txtNoFactura)
        Me.Capturar.Controls.Add(Me.btnGrabar)
        Me.Capturar.Controls.Add(Me.Label5)
        Me.Capturar.Controls.Add(Me.cmbIdEmpleado)
        Me.Capturar.Controls.Add(Me.Label4)
        Me.Capturar.Controls.Add(Me.Label2)
        Me.Capturar.Controls.Add(Me.Label3)
        Me.Capturar.Controls.Add(Me.cmbIdProyecto)
        Me.Capturar.Controls.Add(Me.txtFecha)
        Me.Capturar.Controls.Add(Me.txtLectura)
        Me.Capturar.Controls.Add(Me.Label1)
        Me.Capturar.Location = New System.Drawing.Point(12, 12)
        Me.Capturar.Name = "Capturar"
        Me.Capturar.Size = New System.Drawing.Size(373, 217)
        Me.Capturar.TabIndex = 4
        Me.Capturar.TabStop = False
        Me.Capturar.Text = "Captura de Facturas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(84, 141)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(283, 20)
        Me.txtCliente.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "#Factura"
        '
        'txtNoFactura
        '
        Me.txtNoFactura.BackColor = System.Drawing.Color.White
        Me.txtNoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoFactura.Location = New System.Drawing.Point(84, 167)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(139, 20)
        Me.txtNoFactura.TabIndex = 12
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Empleado"
        '
        'cmbIdEmpleado
        '
        Me.cmbIdEmpleado.FormattingEnabled = True
        Me.cmbIdEmpleado.Location = New System.Drawing.Point(84, 75)
        Me.cmbIdEmpleado.Name = "cmbIdEmpleado"
        Me.cmbIdEmpleado.Size = New System.Drawing.Size(139, 21)
        Me.cmbIdEmpleado.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Proyecto"
        '
        'cmbIdProyecto
        '
        Me.cmbIdProyecto.FormattingEnabled = True
        Me.cmbIdProyecto.Location = New System.Drawing.Point(84, 48)
        Me.cmbIdProyecto.Name = "cmbIdProyecto"
        Me.cmbIdProyecto.Size = New System.Drawing.Size(139, 21)
        Me.cmbIdProyecto.TabIndex = 3
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(84, 18)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(139, 20)
        Me.txtFecha.TabIndex = 2
        '
        'txtLectura
        '
        Me.txtLectura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLectura.Enabled = False
        Me.txtLectura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLectura.Location = New System.Drawing.Point(84, 193)
        Me.txtLectura.Name = "txtLectura"
        Me.txtLectura.Size = New System.Drawing.Size(139, 20)
        Me.txtLectura.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'btnAgregarLectura
        '
        Me.btnAgregarLectura.Image = CType(resources.GetObject("btnAgregarLectura.Image"), System.Drawing.Image)
        Me.btnAgregarLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarLectura.Location = New System.Drawing.Point(171, 385)
        Me.btnAgregarLectura.Name = "btnAgregarLectura"
        Me.btnAgregarLectura.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarLectura.TabIndex = 7
        Me.btnAgregarLectura.Text = "Agregar"
        Me.btnAgregarLectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarLectura.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFechaBoleta)
        Me.GroupBox1.Controls.Add(Me.txtNoBoleta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 77)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Boleta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "#Boleta"
        '
        'txtFechaBoleta
        '
        Me.txtFechaBoleta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaBoleta.Location = New System.Drawing.Point(85, 19)
        Me.txtFechaBoleta.Name = "txtFechaBoleta"
        Me.txtFechaBoleta.Size = New System.Drawing.Size(139, 20)
        Me.txtFechaBoleta.TabIndex = 4
        '
        'txtNoBoleta
        '
        Me.txtNoBoleta.BackColor = System.Drawing.Color.White
        Me.txtNoBoleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoBoleta.Location = New System.Drawing.Point(85, 45)
        Me.txtNoBoleta.Name = "txtNoBoleta"
        Me.txtNoBoleta.Size = New System.Drawing.Size(139, 20)
        Me.txtNoBoleta.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Fecha"
        '
        'lblPagoSinMora
        '
        Me.lblPagoSinMora.AutoSize = True
        Me.lblPagoSinMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagoSinMora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPagoSinMora.Location = New System.Drawing.Point(18, 248)
        Me.lblPagoSinMora.Name = "lblPagoSinMora"
        Me.lblPagoSinMora.Size = New System.Drawing.Size(0, 13)
        Me.lblPagoSinMora.TabIndex = 10
        '
        'lblFechaLecturaPago
        '
        Me.lblFechaLecturaPago.AutoSize = True
        Me.lblFechaLecturaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaLecturaPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFechaLecturaPago.Location = New System.Drawing.Point(18, 270)
        Me.lblFechaLecturaPago.Name = "lblFechaLecturaPago"
        Me.lblFechaLecturaPago.Size = New System.Drawing.Size(0, 13)
        Me.lblFechaLecturaPago.TabIndex = 11
        '
        'cmbIdContador
        '
        Me.cmbIdContador.BackColor = System.Drawing.SystemColors.Info
        Me.cmbIdContador.FormattingEnabled = True
        Me.cmbIdContador.Location = New System.Drawing.Point(84, 113)
        Me.cmbIdContador.Name = "cmbIdContador"
        Me.cmbIdContador.Size = New System.Drawing.Size(283, 21)
        Me.cmbIdContador.TabIndex = 15
        '
        'frmFacturaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 417)
        Me.Controls.Add(Me.lblFechaLecturaPago)
        Me.Controls.Add(Me.lblPagoSinMora)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Capturar)
        Me.Controls.Add(Me.btnAgregarLectura)
        Me.Name = "frmFacturaProducto"
        Me.Text = "frmFactura"
        Me.Capturar.ResumeLayout(False)
        Me.Capturar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Capturar As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarLectura As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbIdEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbIdProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLectura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFechaBoleta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoBoleta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPagoSinMora As System.Windows.Forms.Label
    Friend WithEvents lblFechaLecturaPago As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents cmbIdContador As System.Windows.Forms.ComboBox
End Class
