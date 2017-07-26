<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimeMachote
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbIdProyecto = New System.Windows.Forms.ComboBox
        Me.btnImprimeMachote = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Proyecto"
        '
        'cmbIdProyecto
        '
        Me.cmbIdProyecto.BackColor = System.Drawing.SystemColors.Info
        Me.cmbIdProyecto.FormattingEnabled = True
        Me.cmbIdProyecto.Location = New System.Drawing.Point(17, 35)
        Me.cmbIdProyecto.Name = "cmbIdProyecto"
        Me.cmbIdProyecto.Size = New System.Drawing.Size(180, 21)
        Me.cmbIdProyecto.TabIndex = 7
        '
        'btnImprimeMachote
        '
        Me.btnImprimeMachote.Image = Global.agua.My.Resources.Resources.mail_new
        Me.btnImprimeMachote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimeMachote.Location = New System.Drawing.Point(72, 62)
        Me.btnImprimeMachote.Name = "btnImprimeMachote"
        Me.btnImprimeMachote.Size = New System.Drawing.Size(69, 42)
        Me.btnImprimeMachote.TabIndex = 9
        Me.btnImprimeMachote.Text = "Imprimir"
        Me.btnImprimeMachote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimeMachote.UseVisualStyleBackColor = True
        '
        'frmImprimeMachote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 134)
        Me.Controls.Add(Me.btnImprimeMachote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbIdProyecto)
        Me.Name = "frmImprimeMachote"
        Me.Text = "frmImprimeMachote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbIdProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimeMachote As System.Windows.Forms.Button
End Class
