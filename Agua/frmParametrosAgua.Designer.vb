<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosAgua
    Inherits agua.frmBase

    'Form invalida a Dispose para limpiar la lista de componentes.
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblParametroFin = New System.Windows.Forms.Label()
        Me.lblParametroInicio = New System.Windows.Forms.Label()
        Me.txtFin = New System.Windows.Forms.TextBox()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Controls.Add(Me.txtId)
        Me.pnl1.Controls.Add(Me.Label8)
        Me.pnl1.Controls.Add(Me.Label7)
        Me.pnl1.Controls.Add(Me.Label6)
        Me.pnl1.Controls.Add(Me.Label5)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.txtValor)
        Me.pnl1.Controls.Add(Me.lblParametroFin)
        Me.pnl1.Controls.Add(Me.lblParametroInicio)
        Me.pnl1.Controls.Add(Me.txtFin)
        Me.pnl1.Controls.Add(Me.txtInicio)
        Me.pnl1.Location = New System.Drawing.Point(12, 45)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(662, 168)
        Me.pnl1.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Id"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(116, 33)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(41, 20)
        Me.txtId.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(333, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "<= Menor, Igual que"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(332, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = ">= Mayor, Igual que"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(333, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "<  Menor que "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = ">  Mayor que "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Valor"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(118, 115)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(98, 20)
        Me.txtValor.TabIndex = 15
        '
        'lblParametroFin
        '
        Me.lblParametroFin.AutoSize = True
        Me.lblParametroFin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParametroFin.ForeColor = System.Drawing.Color.Red
        Me.lblParametroFin.Location = New System.Drawing.Point(43, 85)
        Me.lblParametroFin.Name = "lblParametroFin"
        Me.lblParametroFin.Size = New System.Drawing.Size(60, 25)
        Me.lblParametroFin.TabIndex = 16
        Me.lblParametroFin.Text = "Valor"
        '
        'lblParametroInicio
        '
        Me.lblParametroInicio.AutoSize = True
        Me.lblParametroInicio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParametroInicio.ForeColor = System.Drawing.Color.Red
        Me.lblParametroInicio.Location = New System.Drawing.Point(44, 58)
        Me.lblParametroInicio.Name = "lblParametroInicio"
        Me.lblParametroInicio.Size = New System.Drawing.Size(60, 25)
        Me.lblParametroInicio.TabIndex = 13
        Me.lblParametroInicio.Text = "Valor"
        '
        'txtFin
        '
        Me.txtFin.Location = New System.Drawing.Point(116, 89)
        Me.txtFin.Name = "txtFin"
        Me.txtFin.Size = New System.Drawing.Size(100, 20)
        Me.txtFin.TabIndex = 14
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(116, 63)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtInicio.TabIndex = 12
        '
        'frmParametrosAgua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(686, 425)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmParametrosAgua"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lblParametroFin As System.Windows.Forms.Label
    Friend WithEvents lblParametroInicio As System.Windows.Forms.Label
    Friend WithEvents txtFin As System.Windows.Forms.TextBox
    Friend WithEvents txtInicio As System.Windows.Forms.TextBox

End Class
