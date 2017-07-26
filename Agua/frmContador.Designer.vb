<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContador
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
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.txtIdContador = New System.Windows.Forms.TextBox
        Me.chkAnulado = New System.Windows.Forms.CheckBox
        Me.chkBloqueado = New System.Windows.Forms.CheckBox
        Me.chkDisponible = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.txtObservacion)
        Me.pnl1.Controls.Add(Me.txtNumero)
        Me.pnl1.Controls.Add(Me.txtFecha)
        Me.pnl1.Controls.Add(Me.txtIdContador)
        Me.pnl1.Controls.Add(Me.chkAnulado)
        Me.pnl1.Controls.Add(Me.chkBloqueado)
        Me.pnl1.Controls.Add(Me.chkDisponible)
        Me.pnl1.Controls.Add(Me.Label5)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(3, 45)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(389, 160)
        Me.pnl1.TabIndex = 45
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(85, 90)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(282, 20)
        Me.txtObservacion.TabIndex = 10
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(85, 66)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 9
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(85, 40)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 8
        '
        'txtIdContador
        '
        Me.txtIdContador.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdContador.Enabled = False
        Me.txtIdContador.Location = New System.Drawing.Point(85, 11)
        Me.txtIdContador.Name = "txtIdContador"
        Me.txtIdContador.Size = New System.Drawing.Size(100, 20)
        Me.txtIdContador.TabIndex = 7
        '
        'chkAnulado
        '
        Me.chkAnulado.AutoSize = True
        Me.chkAnulado.Location = New System.Drawing.Point(195, 127)
        Me.chkAnulado.Name = "chkAnulado"
        Me.chkAnulado.Size = New System.Drawing.Size(65, 17)
        Me.chkAnulado.TabIndex = 6
        Me.chkAnulado.Text = "Anulado"
        Me.chkAnulado.UseVisualStyleBackColor = True
        '
        'chkBloqueado
        '
        Me.chkBloqueado.AutoSize = True
        Me.chkBloqueado.Location = New System.Drawing.Point(108, 127)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(77, 17)
        Me.chkBloqueado.TabIndex = 5
        Me.chkBloqueado.Text = "Bloqueado"
        Me.chkBloqueado.UseVisualStyleBackColor = True
        '
        'chkDisponible
        '
        Me.chkDisponible.AutoSize = True
        Me.chkDisponible.Location = New System.Drawing.Point(21, 127)
        Me.chkDisponible.Name = "chkDisponible"
        Me.chkDisponible.Size = New System.Drawing.Size(75, 17)
        Me.chkDisponible.TabIndex = 4
        Me.chkDisponible.Text = "Disponible"
        Me.chkDisponible.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Observacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha"
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
        'frmContador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(409, 425)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmContador"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtIdContador As System.Windows.Forms.TextBox
    Friend WithEvents chkAnulado As System.Windows.Forms.CheckBox
    Friend WithEvents chkBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisponible As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox

End Class
