<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
    Inherits agua.frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Dise�ador de Windows Forms.  
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.txtNit = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFacturarA = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtIdCliente = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.txtEmail)
        Me.pnl1.Controls.Add(Me.Label7)
        Me.pnl1.Controls.Add(Me.txtNit)
        Me.pnl1.Controls.Add(Me.Label6)
        Me.pnl1.Controls.Add(Me.txtFacturarA)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.txtTelefono)
        Me.pnl1.Controls.Add(Me.Label12)
        Me.pnl1.Controls.Add(Me.txtDireccion)
        Me.pnl1.Controls.Add(Me.txtNombre)
        Me.pnl1.Controls.Add(Me.txtIdCliente)
        Me.pnl1.Controls.Add(Me.Label5)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(6, 45)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(386, 249)
        Me.pnl1.TabIndex = 0
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(117, 141)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(238, 20)
        Me.txtNit.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Nit"
        '
        'txtFacturarA
        '
        Me.txtFacturarA.Location = New System.Drawing.Point(117, 115)
        Me.txtFacturarA.Name = "txtFacturarA"
        Me.txtFacturarA.Size = New System.Drawing.Size(238, 20)
        Me.txtFacturarA.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Facturar A"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(117, 89)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(238, 20)
        Me.txtTelefono.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Telefono"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(117, 63)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(238, 20)
        Me.txtDireccion.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(117, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(238, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtIdCliente
        '
        Me.txtIdCliente.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(117, 11)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Direccion"
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
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(117, 167)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(238, 20)
        Me.txtEmail.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Email"
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(410, 506)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmCliente"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFacturarA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
