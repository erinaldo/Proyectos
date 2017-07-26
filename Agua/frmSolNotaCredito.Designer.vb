<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolNotaCredito
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
        Me.btnAgregarLectura = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbIdContador = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbIdProyecto = New System.Windows.Forms.ComboBox
        Me.txtFecha = New System.Windows.Forms.DateTimePicker
        Me.txtLectura = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.Capturar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Capturar
        '
        Me.Capturar.Controls.Add(Me.Label6)
        Me.Capturar.Controls.Add(Me.txtObservacion)
        Me.Capturar.Controls.Add(Me.Label5)
        Me.Capturar.Controls.Add(Me.cmbTipo)
        Me.Capturar.Controls.Add(Me.btnAgregarLectura)
        Me.Capturar.Controls.Add(Me.btnGrabar)
        Me.Capturar.Controls.Add(Me.Label4)
        Me.Capturar.Controls.Add(Me.Label2)
        Me.Capturar.Controls.Add(Me.cmbIdContador)
        Me.Capturar.Controls.Add(Me.Label3)
        Me.Capturar.Controls.Add(Me.cmbIdProyecto)
        Me.Capturar.Controls.Add(Me.txtFecha)
        Me.Capturar.Controls.Add(Me.txtLectura)
        Me.Capturar.Controls.Add(Me.Label1)
        Me.Capturar.Location = New System.Drawing.Point(12, 32)
        Me.Capturar.Name = "Capturar"
        Me.Capturar.Size = New System.Drawing.Size(291, 259)
        Me.Capturar.TabIndex = 4
        Me.Capturar.TabStop = False
        Me.Capturar.Text = "Captura de Notas de Credito"
        '
        'btnAgregarLectura
        '
        Me.btnAgregarLectura.Location = New System.Drawing.Point(120, 213)
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
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Monto"
        '
        'cmbIdContador
        '
        Me.cmbIdContador.BackColor = System.Drawing.SystemColors.Info
        Me.cmbIdContador.FormattingEnabled = True
        Me.cmbIdContador.Location = New System.Drawing.Point(56, 76)
        Me.cmbIdContador.Name = "cmbIdContador"
        Me.cmbIdContador.Size = New System.Drawing.Size(205, 21)
        Me.cmbIdContador.TabIndex = 2
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
        Me.cmbIdProyecto.Location = New System.Drawing.Point(56, 49)
        Me.cmbIdProyecto.Name = "cmbIdProyecto"
        Me.cmbIdProyecto.Size = New System.Drawing.Size(205, 21)
        Me.cmbIdProyecto.TabIndex = 1
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(56, 19)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(205, 20)
        Me.txtFecha.TabIndex = 0
        '
        'txtLectura
        '
        Me.txtLectura.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtLectura.Location = New System.Drawing.Point(56, 140)
        Me.txtLectura.Name = "txtLectura"
        Me.txtLectura.Size = New System.Drawing.Size(205, 20)
        Me.txtLectura.TabIndex = 4
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Rubro"
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Cuota Fija", "Exceso", "Planta", "Cuotas Atrasadas", "Mora", "Reconexion", "Otros", "Convenio"})
        Me.cmbTipo.Location = New System.Drawing.Point(56, 103)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(205, 21)
        Me.cmbTipo.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Obs"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtObservacion.Location = New System.Drawing.Point(56, 166)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(205, 41)
        Me.txtObservacion.TabIndex = 5
        '
        'frmNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 303)
        Me.Controls.Add(Me.Capturar)
        Me.Name = "frmNotaCredito"
        Me.Text = "frmNotaCredito"
        Me.Capturar.ResumeLayout(False)
        Me.Capturar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Capturar As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarLectura As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbIdContador As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbIdProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLectura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
End Class
