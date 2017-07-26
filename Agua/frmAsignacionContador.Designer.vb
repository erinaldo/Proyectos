<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionContador
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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.txtLecturaInicial = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContador = New System.Windows.Forms.TextBox()
        Me.txtIdContador = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdAsignacionContador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.txtLecturaInicial)
        Me.pnl1.Controls.Add(Me.Label11)
        Me.pnl1.Controls.Add(Me.txtContador)
        Me.pnl1.Controls.Add(Me.txtIdContador)
        Me.pnl1.Controls.Add(Me.Label12)
        Me.pnl1.Controls.Add(Me.txtIdAsignacionContador)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(3, 45)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(492, 97)
        Me.pnl1.TabIndex = 45
        '
        'txtLecturaInicial
        '
        Me.txtLecturaInicial.Location = New System.Drawing.Point(85, 63)
        Me.txtLecturaInicial.Name = "txtLecturaInicial"
        Me.txtLecturaInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtLecturaInicial.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Lectura Inicial"
        '
        'txtContador
        '
        Me.txtContador.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtContador.Enabled = False
        Me.txtContador.Location = New System.Drawing.Point(117, 37)
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(346, 20)
        Me.txtContador.TabIndex = 23
        '
        'txtIdContador
        '
        Me.txtIdContador.Location = New System.Drawing.Point(85, 37)
        Me.txtIdContador.Name = "txtIdContador"
        Me.txtIdContador.Size = New System.Drawing.Size(26, 20)
        Me.txtIdContador.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Contador"
        '
        'txtIdAsignacionContador
        '
        Me.txtIdAsignacionContador.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdAsignacionContador.Enabled = False
        Me.txtIdAsignacionContador.Location = New System.Drawing.Point(85, 11)
        Me.txtIdAsignacionContador.Name = "txtIdAsignacionContador"
        Me.txtIdAsignacionContador.Size = New System.Drawing.Size(100, 20)
        Me.txtIdAsignacionContador.TabIndex = 7
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
        'frmAsignacionContador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(524, 355)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmAsignacionContador"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtLecturaInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContador As System.Windows.Forms.TextBox
    Friend WithEvents txtIdContador As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIdAsignacionContador As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
