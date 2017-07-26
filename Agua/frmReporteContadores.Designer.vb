<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteContadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtTodos = New System.Windows.Forms.RadioButton
        Me.rbtNoDisponibles = New System.Windows.Forms.RadioButton
        Me.rbtDisponibles = New System.Windows.Forms.RadioButton
        Me.btnReporte = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtDisponibles)
        Me.GroupBox1.Controls.Add(Me.rbtNoDisponibles)
        Me.GroupBox1.Controls.Add(Me.rbtTodos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 54)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Location = New System.Drawing.Point(6, 19)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodos.TabIndex = 0
        Me.rbtTodos.TabStop = True
        Me.rbtTodos.Text = "Todos"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'rbtNoDisponibles
        '
        Me.rbtNoDisponibles.AutoSize = True
        Me.rbtNoDisponibles.Location = New System.Drawing.Point(89, 19)
        Me.rbtNoDisponibles.Name = "rbtNoDisponibles"
        Me.rbtNoDisponibles.Size = New System.Drawing.Size(79, 17)
        Me.rbtNoDisponibles.TabIndex = 1
        Me.rbtNoDisponibles.TabStop = True
        Me.rbtNoDisponibles.Text = "Disponibles"
        Me.rbtNoDisponibles.UseVisualStyleBackColor = True
        '
        'rbtDisponibles
        '
        Me.rbtDisponibles.AutoSize = True
        Me.rbtDisponibles.Location = New System.Drawing.Point(203, 19)
        Me.rbtDisponibles.Name = "rbtDisponibles"
        Me.rbtDisponibles.Size = New System.Drawing.Size(96, 17)
        Me.rbtDisponibles.TabIndex = 2
        Me.rbtDisponibles.TabStop = True
        Me.rbtDisponibles.Text = "No Disponibles"
        Me.rbtDisponibles.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(141, 92)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 1
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'frmReporteContadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 132)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReporteContadores"
        Me.Text = "frmReporteContadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtDisponibles As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNoDisponibles As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Friend WithEvents btnReporte As System.Windows.Forms.Button
End Class
