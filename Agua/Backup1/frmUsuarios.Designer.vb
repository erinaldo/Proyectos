<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.chkBloqueado = New System.Windows.Forms.CheckBox
        Me.chkSuperUsuario = New System.Windows.Forms.CheckBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIdUsuario = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnDetalleRecibo = New System.Windows.Forms.Button
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl1.Controls.Add(Me.chkBloqueado)
        Me.pnl1.Controls.Add(Me.chkSuperUsuario)
        Me.pnl1.Controls.Add(Me.txtNombre)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.txtIdUsuario)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(17, 58)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(617, 120)
        Me.pnl1.TabIndex = 17
        '
        'chkBloqueado
        '
        Me.chkBloqueado.AutoSize = True
        Me.chkBloqueado.Location = New System.Drawing.Point(220, 82)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(86, 17)
        Me.chkBloqueado.TabIndex = 5
        Me.chkBloqueado.Text = "Bloqueado ?"
        Me.chkBloqueado.UseVisualStyleBackColor = True
        '
        'chkSuperUsuario
        '
        Me.chkSuperUsuario.AutoSize = True
        Me.chkSuperUsuario.Location = New System.Drawing.Point(112, 82)
        Me.chkSuperUsuario.Name = "chkSuperUsuario"
        Me.chkSuperUsuario.Size = New System.Drawing.Size(102, 17)
        Me.chkSuperUsuario.TabIndex = 4
        Me.chkSuperUsuario.Text = "Super Usuario ?"
        Me.chkSuperUsuario.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(107, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(299, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtIdUsuario.Enabled = False
        Me.txtIdUsuario.Location = New System.Drawing.Point(107, 21)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(32, 20)
        Me.txtIdUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id"
        '
        'btnDetalleRecibo
        '
        Me.btnDetalleRecibo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDetalleRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleRecibo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDetalleRecibo.Image = CType(resources.GetObject("btnDetalleRecibo.Image"), System.Drawing.Image)
        Me.btnDetalleRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetalleRecibo.Location = New System.Drawing.Point(398, 1)
        Me.btnDetalleRecibo.Name = "btnDetalleRecibo"
        Me.btnDetalleRecibo.Size = New System.Drawing.Size(82, 37)
        Me.btnDetalleRecibo.TabIndex = 19
        Me.btnDetalleRecibo.Text = "Detalles"
        Me.btnDetalleRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDetalleRecibo.UseVisualStyleBackColor = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(686, 425)
        Me.Controls.Add(Me.btnDetalleRecibo)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmUsuarios"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        Me.Controls.SetChildIndex(Me.btnDetalleRecibo, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend pnl1 As System.Windows.Forms.Panel
    Friend txtIdUsuario As System.Windows.Forms.TextBox
    Friend txtNombre As System.Windows.Forms.TextBox
    Friend chkSuperUsuario As System.Windows.Forms.CheckBox
    Friend chkBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDetalleRecibo As System.Windows.Forms.Button

End Class
