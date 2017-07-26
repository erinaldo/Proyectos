<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.txtCorrNotaCredito = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCorrNotaCobro = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCorrFactura = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCorrConvenio = New System.Windows.Forms.TextBox
        Me.txtIva = New System.Windows.Forms.TextBox
        Me.txtIdConfiguracion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSerieFactura = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.txtSerieFactura)
        Me.pnl1.Controls.Add(Me.Label7)
        Me.pnl1.Controls.Add(Me.txtCorrNotaCredito)
        Me.pnl1.Controls.Add(Me.Label6)
        Me.pnl1.Controls.Add(Me.txtCorrNotaCobro)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.txtCorrFactura)
        Me.pnl1.Controls.Add(Me.Label12)
        Me.pnl1.Controls.Add(Me.txtCorrConvenio)
        Me.pnl1.Controls.Add(Me.txtIva)
        Me.pnl1.Controls.Add(Me.txtIdConfiguracion)
        Me.pnl1.Controls.Add(Me.Label5)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(6, 45)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(273, 205)
        Me.pnl1.TabIndex = 0
        '
        'txtCorrNotaCredito
        '
        Me.txtCorrNotaCredito.Location = New System.Drawing.Point(117, 166)
        Me.txtCorrNotaCredito.Name = "txtCorrNotaCredito"
        Me.txtCorrNotaCredito.Size = New System.Drawing.Size(100, 20)
        Me.txtCorrNotaCredito.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Corr Nota Credito"
        '
        'txtCorrNotaCobro
        '
        Me.txtCorrNotaCobro.Location = New System.Drawing.Point(117, 140)
        Me.txtCorrNotaCobro.Name = "txtCorrNotaCobro"
        Me.txtCorrNotaCobro.Size = New System.Drawing.Size(100, 20)
        Me.txtCorrNotaCobro.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Corr Nota Cobro"
        '
        'txtCorrFactura
        '
        Me.txtCorrFactura.Location = New System.Drawing.Point(117, 89)
        Me.txtCorrFactura.Name = "txtCorrFactura"
        Me.txtCorrFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtCorrFactura.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Corr Factura"
        '
        'txtCorrConvenio
        '
        Me.txtCorrConvenio.Location = New System.Drawing.Point(117, 63)
        Me.txtCorrConvenio.Name = "txtCorrConvenio"
        Me.txtCorrConvenio.Size = New System.Drawing.Size(100, 20)
        Me.txtCorrConvenio.TabIndex = 1
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(117, 37)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(100, 20)
        Me.txtIva.TabIndex = 0
        '
        'txtIdConfiguracion
        '
        Me.txtIdConfiguracion.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdConfiguracion.Enabled = False
        Me.txtIdConfiguracion.Location = New System.Drawing.Point(117, 11)
        Me.txtIdConfiguracion.Name = "txtIdConfiguracion"
        Me.txtIdConfiguracion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdConfiguracion.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Corr Convenio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Iva"
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
        'txtSerieFactura
        '
        Me.txtSerieFactura.Location = New System.Drawing.Point(117, 115)
        Me.txtSerieFactura.Name = "txtSerieFactura"
        Me.txtSerieFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtSerieFactura.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Serie Factura"
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(401, 461)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmConfiguracion"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtCorrNotaCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCorrNotaCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCorrFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCorrConvenio As System.Windows.Forms.TextBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents txtIdConfiguracion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSerieFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
