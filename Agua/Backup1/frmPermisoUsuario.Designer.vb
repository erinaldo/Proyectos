<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisoUsuario
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
        Me.chkCrea = New System.Windows.Forms.CheckBox
        Me.chkElimina = New System.Windows.Forms.CheckBox
        Me.chkModifica = New System.Windows.Forms.CheckBox
        Me.chkNuevo = New System.Windows.Forms.CheckBox
        Me.txtIdUsuarioForma = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtIdForma = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtForma = New System.Windows.Forms.TextBox
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl1.Controls.Add(Me.chkCrea)
        Me.pnl1.Controls.Add(Me.chkElimina)
        Me.pnl1.Controls.Add(Me.chkModifica)
        Me.pnl1.Controls.Add(Me.chkNuevo)
        Me.pnl1.Controls.Add(Me.txtIdUsuarioForma)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Controls.Add(Me.txtIdForma)
        Me.pnl1.Controls.Add(Me.Label11)
        Me.pnl1.Controls.Add(Me.txtForma)
        Me.pnl1.Location = New System.Drawing.Point(8, 46)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(488, 111)
        Me.pnl1.TabIndex = 17
        '
        'chkCrea
        '
        Me.chkCrea.AutoSize = True
        Me.chkCrea.Location = New System.Drawing.Point(403, 68)
        Me.chkCrea.Name = "chkCrea"
        Me.chkCrea.Size = New System.Drawing.Size(48, 17)
        Me.chkCrea.TabIndex = 30
        Me.chkCrea.Text = "Crea"
        Me.chkCrea.UseVisualStyleBackColor = True
        '
        'chkElimina
        '
        Me.chkElimina.AutoSize = True
        Me.chkElimina.Location = New System.Drawing.Point(302, 68)
        Me.chkElimina.Name = "chkElimina"
        Me.chkElimina.Size = New System.Drawing.Size(59, 17)
        Me.chkElimina.TabIndex = 29
        Me.chkElimina.Text = "Elimina"
        Me.chkElimina.UseVisualStyleBackColor = True
        '
        'chkModifica
        '
        Me.chkModifica.AutoSize = True
        Me.chkModifica.Location = New System.Drawing.Point(193, 68)
        Me.chkModifica.Name = "chkModifica"
        Me.chkModifica.Size = New System.Drawing.Size(66, 17)
        Me.chkModifica.TabIndex = 28
        Me.chkModifica.Text = "Modifica"
        Me.chkModifica.UseVisualStyleBackColor = True
        '
        'chkNuevo
        '
        Me.chkNuevo.AutoSize = True
        Me.chkNuevo.Location = New System.Drawing.Point(92, 68)
        Me.chkNuevo.Name = "chkNuevo"
        Me.chkNuevo.Size = New System.Drawing.Size(58, 17)
        Me.chkNuevo.TabIndex = 27
        Me.chkNuevo.Text = "Nuevo"
        Me.chkNuevo.UseVisualStyleBackColor = True
        '
        'txtIdUsuarioForma
        '
        Me.txtIdUsuarioForma.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtIdUsuarioForma.Enabled = False
        Me.txtIdUsuarioForma.Location = New System.Drawing.Point(92, 3)
        Me.txtIdUsuarioForma.Name = "txtIdUsuarioForma"
        Me.txtIdUsuarioForma.Size = New System.Drawing.Size(65, 20)
        Me.txtIdUsuarioForma.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Id"
        '
        'txtIdForma
        '
        Me.txtIdForma.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdForma.Location = New System.Drawing.Point(91, 29)
        Me.txtIdForma.Name = "txtIdForma"
        Me.txtIdForma.Size = New System.Drawing.Size(65, 20)
        Me.txtIdForma.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Forma"
        '
        'txtForma
        '
        Me.txtForma.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtForma.Enabled = False
        Me.txtForma.Location = New System.Drawing.Point(162, 29)
        Me.txtForma.Name = "txtForma"
        Me.txtForma.Size = New System.Drawing.Size(307, 20)
        Me.txtForma.TabIndex = 24
        '
        'frmPermisoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(506, 379)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmPermisoUsuario"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtIdForma As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtForma As System.Windows.Forms.TextBox
    Friend WithEvents txtIdUsuarioForma As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkModifica As System.Windows.Forms.CheckBox
    Friend WithEvents chkNuevo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCrea As System.Windows.Forms.CheckBox
    Friend WithEvents chkElimina As System.Windows.Forms.CheckBox

End Class
