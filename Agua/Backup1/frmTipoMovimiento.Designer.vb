<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoMovimiento
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
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtIdTipoMovimiento = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkEntrada = New System.Windows.Forms.CheckBox
        Me.chkGeneraFactura = New System.Windows.Forms.CheckBox
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.chkGeneraFactura)
        Me.pnl1.Controls.Add(Me.chkEntrada)
        Me.pnl1.Controls.Add(Me.txtNombre)
        Me.pnl1.Controls.Add(Me.txtIdTipoMovimiento)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(6, 45)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(389, 160)
        Me.pnl1.TabIndex = 47
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(270, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtIdTipoMovimiento
        '
        Me.txtIdTipoMovimiento.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdTipoMovimiento.Enabled = False
        Me.txtIdTipoMovimiento.Location = New System.Drawing.Point(85, 11)
        Me.txtIdTipoMovimiento.Name = "txtIdTipoMovimiento"
        Me.txtIdTipoMovimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtIdTipoMovimiento.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre"
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
        'chkEntrada
        '
        Me.chkEntrada.AutoSize = True
        Me.chkEntrada.Location = New System.Drawing.Point(85, 64)
        Me.chkEntrada.Name = "chkEntrada"
        Me.chkEntrada.Size = New System.Drawing.Size(86, 17)
        Me.chkEntrada.TabIndex = 10
        Me.chkEntrada.Text = "Es entrada ?"
        Me.chkEntrada.UseVisualStyleBackColor = True
        '
        'chkGeneraFactura
        '
        Me.chkGeneraFactura.AutoSize = True
        Me.chkGeneraFactura.Location = New System.Drawing.Point(246, 63)
        Me.chkGeneraFactura.Name = "chkGeneraFactura"
        Me.chkGeneraFactura.Size = New System.Drawing.Size(109, 17)
        Me.chkGeneraFactura.TabIndex = 11
        Me.chkGeneraFactura.Text = "Genera Factura ?"
        Me.chkGeneraFactura.UseVisualStyleBackColor = True
        '
        'frmTipoMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(421, 425)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmTipoMovimiento"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdTipoMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkGeneraFactura As System.Windows.Forms.CheckBox
    Friend WithEvents chkEntrada As System.Windows.Forms.CheckBox

End Class
