<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReconexion
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
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtIdLectura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContador = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdContador = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdReconexion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.btnImprimir)
        Me.pnl1.Controls.Add(Me.txtIdLectura)
        Me.pnl1.Controls.Add(Me.Label7)
        Me.pnl1.Controls.Add(Me.txtUsuario)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.txtContador)
        Me.pnl1.Controls.Add(Me.txtFecha)
        Me.pnl1.Controls.Add(Me.Label8)
        Me.pnl1.Controls.Add(Me.txtMonto)
        Me.pnl1.Controls.Add(Me.Label6)
        Me.pnl1.Controls.Add(Me.txtObservacion)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.txtIdContador)
        Me.pnl1.Controls.Add(Me.Label12)
        Me.pnl1.Controls.Add(Me.txtIdReconexion)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(6, 45)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(492, 205)
        Me.pnl1.TabIndex = 48
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.agua.My.Resources.Resources.printer
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(363, 11)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(93, 29)
        Me.btnImprimir.TabIndex = 40
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'txtIdLectura
        '
        Me.txtIdLectura.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdLectura.Enabled = False
        Me.txtIdLectura.Location = New System.Drawing.Point(363, 152)
        Me.txtIdLectura.Name = "txtIdLectura"
        Me.txtIdLectura.Size = New System.Drawing.Size(100, 20)
        Me.txtIdLectura.TabIndex = 39
        Me.txtIdLectura.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(314, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Lectura"
        Me.Label7.Visible = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(85, 153)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Usuario"
        '
        'txtContador
        '
        Me.txtContador.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtContador.Enabled = False
        Me.txtContador.Location = New System.Drawing.Point(117, 73)
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(346, 20)
        Me.txtContador.TabIndex = 35
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(85, 46)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Fecha"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.Location = New System.Drawing.Point(85, 101)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Monto"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(85, 127)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(378, 20)
        Me.txtObservacion.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Observacion"
        '
        'txtIdContador
        '
        Me.txtIdContador.Location = New System.Drawing.Point(85, 73)
        Me.txtIdContador.Name = "txtIdContador"
        Me.txtIdContador.Size = New System.Drawing.Size(26, 20)
        Me.txtIdContador.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Contador"
        '
        'txtIdReconexion
        '
        Me.txtIdReconexion.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdReconexion.Enabled = False
        Me.txtIdReconexion.Location = New System.Drawing.Point(85, 15)
        Me.txtIdReconexion.Name = "txtIdReconexion"
        Me.txtIdReconexion.Size = New System.Drawing.Size(100, 20)
        Me.txtIdReconexion.TabIndex = 7
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
        'frmReconexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(515, 469)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmReconexion"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtIdReconexion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdLectura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContador As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdContador As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button

End Class
