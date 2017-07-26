<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProyecto
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
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdProyecto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.txtMultiplicador = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtReconexion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiasPago = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecioExceso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAguaFija = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuotaFija = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPlanta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnl3 = New System.Windows.Forms.Panel()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMora = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.pnl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl1.Controls.Add(Me.txtDireccion)
        Me.pnl1.Controls.Add(Me.txtNombre)
        Me.pnl1.Controls.Add(Me.txtIdProyecto)
        Me.pnl1.Controls.Add(Me.Label5)
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Location = New System.Drawing.Point(6, 45)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(492, 135)
        Me.pnl1.TabIndex = 0
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(85, 63)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(378, 20)
        Me.txtDireccion.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(378, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtIdProyecto
        '
        Me.txtIdProyecto.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtIdProyecto.Enabled = False
        Me.txtIdProyecto.Location = New System.Drawing.Point(85, 11)
        Me.txtIdProyecto.Name = "txtIdProyecto"
        Me.txtIdProyecto.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProyecto.TabIndex = 7
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
        'pnl2
        '
        Me.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl2.Controls.Add(Me.txtMultiplicador)
        Me.pnl2.Controls.Add(Me.Label11)
        Me.pnl2.Controls.Add(Me.txtReconexion)
        Me.pnl2.Controls.Add(Me.Label10)
        Me.pnl2.Controls.Add(Me.txtDiasPago)
        Me.pnl2.Controls.Add(Me.Label8)
        Me.pnl2.Controls.Add(Me.txtAguaFija)
        Me.pnl2.Controls.Add(Me.Label3)
        Me.pnl2.Controls.Add(Me.txtCuotaFija)
        Me.pnl2.Controls.Add(Me.Label7)
        Me.pnl2.Location = New System.Drawing.Point(6, 186)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(492, 74)
        Me.pnl2.TabIndex = 1
        '
        'txtMultiplicador
        '
        Me.txtMultiplicador.Location = New System.Drawing.Point(305, 34)
        Me.txtMultiplicador.Name = "txtMultiplicador"
        Me.txtMultiplicador.Size = New System.Drawing.Size(51, 20)
        Me.txtMultiplicador.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(302, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Multiplicador"
        '
        'txtReconexion
        '
        Me.txtReconexion.Location = New System.Drawing.Point(244, 34)
        Me.txtReconexion.Name = "txtReconexion"
        Me.txtReconexion.Size = New System.Drawing.Size(51, 20)
        Me.txtReconexion.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(231, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Reconexion"
        '
        'txtDiasPago
        '
        Me.txtDiasPago.Location = New System.Drawing.Point(164, 34)
        Me.txtDiasPago.Name = "txtDiasPago"
        Me.txtDiasPago.Size = New System.Drawing.Size(51, 20)
        Me.txtDiasPago.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(171, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 26)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "#Dias" & Global.Microsoft.VisualBasic.ChrW(10) & "Pago"
        '
        'txtPrecioExceso
        '
        Me.txtPrecioExceso.Location = New System.Drawing.Point(256, 34)
        Me.txtPrecioExceso.Name = "txtPrecioExceso"
        Me.txtPrecioExceso.Size = New System.Drawing.Size(51, 20)
        Me.txtPrecioExceso.TabIndex = 13
        Me.txtPrecioExceso.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(253, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Precio " & Global.Microsoft.VisualBasic.ChrW(10) & "Exceso"
        Me.Label6.Visible = False
        '
        'txtAguaFija
        '
        Me.txtAguaFija.Location = New System.Drawing.Point(85, 34)
        Me.txtAguaFija.Name = "txtAguaFija"
        Me.txtAguaFija.Size = New System.Drawing.Size(51, 20)
        Me.txtAguaFija.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mts Agua"
        '
        'txtCuotaFija
        '
        Me.txtCuotaFija.Location = New System.Drawing.Point(22, 34)
        Me.txtCuotaFija.Name = "txtCuotaFija"
        Me.txtCuotaFija.Size = New System.Drawing.Size(51, 20)
        Me.txtCuotaFija.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cuota Fija"
        '
        'txtPlanta
        '
        Me.txtPlanta.Location = New System.Drawing.Point(178, 34)
        Me.txtPlanta.Name = "txtPlanta"
        Me.txtPlanta.Size = New System.Drawing.Size(51, 20)
        Me.txtPlanta.TabIndex = 17
        Me.txtPlanta.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Planta"
        Me.Label9.Visible = False
        '
        'pnl3
        '
        Me.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl3.Controls.Add(Me.txtIva)
        Me.pnl3.Controls.Add(Me.Label18)
        Me.pnl3.Controls.Add(Me.txtMora)
        Me.pnl3.Controls.Add(Me.Label19)
        Me.pnl3.Controls.Add(Me.txtPlanta)
        Me.pnl3.Controls.Add(Me.Label9)
        Me.pnl3.Controls.Add(Me.txtPrecioExceso)
        Me.pnl3.Controls.Add(Me.Label6)
        Me.pnl3.Location = New System.Drawing.Point(6, 266)
        Me.pnl3.Name = "pnl3"
        Me.pnl3.Size = New System.Drawing.Size(492, 74)
        Me.pnl3.TabIndex = 2
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(85, 34)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(51, 20)
        Me.txtIva.TabIndex = 11
        Me.txtIva.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(82, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "% Iva"
        Me.Label18.Visible = False
        '
        'txtMora
        '
        Me.txtMora.Location = New System.Drawing.Point(22, 34)
        Me.txtMora.Name = "txtMora"
        Me.txtMora.Size = New System.Drawing.Size(51, 20)
        Me.txtMora.TabIndex = 9
        Me.txtMora.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(19, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "% Mora"
        Me.Label19.Visible = False
        '
        'frmProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(520, 572)
        Me.Controls.Add(Me.pnl3)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmProyecto"
        Me.Controls.SetChildIndex(Me.pnl1, 0)
        Me.Controls.SetChildIndex(Me.pnl2, 0)
        Me.Controls.SetChildIndex(Me.pnl3, 0)
        CType(Me.errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        Me.pnl3.ResumeLayout(False)
        Me.pnl3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents txtAguaFija As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCuotaFija As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMultiplicador As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtReconexion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPlanta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDiasPago As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioExceso As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnl3 As System.Windows.Forms.Panel
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtMora As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label

End Class
