<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvenio
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
        Me.Capturar = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLectura = New System.Windows.Forms.TextBox
        Me.txtNoPagos = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtComentario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAgregarLectura = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbIdContador = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbIdProyecto = New System.Windows.Forms.ComboBox
        Me.txtFecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Capturar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Capturar
        '
        Me.Capturar.Controls.Add(Me.Label6)
        Me.Capturar.Controls.Add(Me.txtLectura)
        Me.Capturar.Controls.Add(Me.txtNoPagos)
        Me.Capturar.Controls.Add(Me.Label5)
        Me.Capturar.Controls.Add(Me.txtComentario)
        Me.Capturar.Controls.Add(Me.Label2)
        Me.Capturar.Controls.Add(Me.btnAgregarLectura)
        Me.Capturar.Controls.Add(Me.btnGrabar)
        Me.Capturar.Controls.Add(Me.Label4)
        Me.Capturar.Controls.Add(Me.cmbIdContador)
        Me.Capturar.Controls.Add(Me.Label3)
        Me.Capturar.Controls.Add(Me.cmbIdProyecto)
        Me.Capturar.Controls.Add(Me.txtFecha)
        Me.Capturar.Controls.Add(Me.Label1)
        Me.Capturar.Location = New System.Drawing.Point(12, 12)
        Me.Capturar.Name = "Capturar"
        Me.Capturar.Size = New System.Drawing.Size(234, 260)
        Me.Capturar.TabIndex = 5
        Me.Capturar.TabStop = False
        Me.Capturar.Text = "Captura de Convenio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total Factura"
        '
        'txtLectura
        '
        Me.txtLectura.BackColor = System.Drawing.Color.White
        Me.txtLectura.Enabled = False
        Me.txtLectura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLectura.Location = New System.Drawing.Point(84, 98)
        Me.txtLectura.Name = "txtLectura"
        Me.txtLectura.Size = New System.Drawing.Size(139, 20)
        Me.txtLectura.TabIndex = 3
        '
        'txtNoPagos
        '
        Me.txtNoPagos.Location = New System.Drawing.Point(84, 124)
        Me.txtNoPagos.Name = "txtNoPagos"
        Me.txtNoPagos.Size = New System.Drawing.Size(139, 20)
        Me.txtNoPagos.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "# Pagos"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(84, 150)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(138, 69)
        Me.txtComentario.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Comentario"
        '
        'btnAgregarLectura
        '
        Me.btnAgregarLectura.Location = New System.Drawing.Point(147, 225)
        Me.btnAgregarLectura.Name = "btnAgregarLectura"
        Me.btnAgregarLectura.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarLectura.TabIndex = 6
        Me.btnAgregarLectura.Text = "Agregar"
        Me.btnAgregarLectura.UseVisualStyleBackColor = True
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contador"
        '
        'cmbIdContador
        '
        Me.cmbIdContador.BackColor = System.Drawing.SystemColors.Info
        Me.cmbIdContador.FormattingEnabled = True
        Me.cmbIdContador.Location = New System.Drawing.Point(84, 71)
        Me.cmbIdContador.Name = "cmbIdContador"
        Me.cmbIdContador.Size = New System.Drawing.Size(139, 21)
        Me.cmbIdContador.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Proyecto"
        '
        'cmbIdProyecto
        '
        Me.cmbIdProyecto.FormattingEnabled = True
        Me.cmbIdProyecto.Location = New System.Drawing.Point(84, 44)
        Me.cmbIdProyecto.Name = "cmbIdProyecto"
        Me.cmbIdProyecto.Size = New System.Drawing.Size(139, 21)
        Me.cmbIdProyecto.TabIndex = 1
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(84, 18)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(139, 20)
        Me.txtFecha.TabIndex = 0
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
        'frmConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 281)
        Me.Controls.Add(Me.Capturar)
        Me.Name = "frmConvenio"
        Me.Text = "frmConvenio"
        Me.Capturar.ResumeLayout(False)
        Me.Capturar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Capturar As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarLectura As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbIdContador As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbIdProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoPagos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLectura As System.Windows.Forms.TextBox
End Class
