<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LecturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaLecturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoLecturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirMachoteLecturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirLecturasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConveniosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReconexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReconexionesGeneradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoMovimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteContadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.fecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.servidor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.empresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.MovimientosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.CrearFacturaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ContadoresToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.AsignacionToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ParametrosToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(60, 20)
        Me.FileMenu.Text = "Archivo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem1.Text = "Proyectos"
        '
        'ContadoresToolStripMenuItem
        '
        Me.ContadoresToolStripMenuItem.Name = "ContadoresToolStripMenuItem"
        Me.ContadoresToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ContadoresToolStripMenuItem.Text = "Contadores"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem2.Text = "Clientes"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem3.Text = "Empleados"
        '
        'AsignacionToolStripMenuItem
        '
        Me.AsignacionToolStripMenuItem.Name = "AsignacionToolStripMenuItem"
        Me.AsignacionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AsignacionToolStripMenuItem.Text = "Asignacion"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ParametrosToolStripMenuItem.Text = "Parametros"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LecturaToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.OtrosToolStripMenuItem, Me.ConveniosToolStripMenuItem, Me.ReconexionToolStripMenuItem, Me.ReconexionesGeneradasToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'LecturaToolStripMenuItem
        '
        Me.LecturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaLecturaToolStripMenuItem, Me.ListadoLecturasToolStripMenuItem, Me.ImprimirMachoteLecturasToolStripMenuItem, Me.ImprimirLecturasToolStripMenuItem1})
        Me.LecturaToolStripMenuItem.Name = "LecturaToolStripMenuItem"
        Me.LecturaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.LecturaToolStripMenuItem.Text = "Lecturas"
        '
        'NuevaLecturaToolStripMenuItem
        '
        Me.NuevaLecturaToolStripMenuItem.Name = "NuevaLecturaToolStripMenuItem"
        Me.NuevaLecturaToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.NuevaLecturaToolStripMenuItem.Text = "Ingreso de Lecturas Mensual"
        '
        'ListadoLecturasToolStripMenuItem
        '
        Me.ListadoLecturasToolStripMenuItem.Name = "ListadoLecturasToolStripMenuItem"
        Me.ListadoLecturasToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ListadoLecturasToolStripMenuItem.Text = "Consulta Impresion Nota Cobro y Pagos"
        '
        'ImprimirMachoteLecturasToolStripMenuItem
        '
        Me.ImprimirMachoteLecturasToolStripMenuItem.Name = "ImprimirMachoteLecturasToolStripMenuItem"
        Me.ImprimirMachoteLecturasToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ImprimirMachoteLecturasToolStripMenuItem.Text = "Machote Lecturas"
        '
        'ImprimirLecturasToolStripMenuItem1
        '
        Me.ImprimirLecturasToolStripMenuItem1.Name = "ImprimirLecturasToolStripMenuItem1"
        Me.ImprimirLecturasToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.ImprimirLecturasToolStripMenuItem1.Text = "Reporte de Lecturas"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearToolStripMenuItem})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CrearToolStripMenuItem.Text = "Ver Facturacion"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.OtrosToolStripMenuItem.Text = "Otros cargos a cliente"
        '
        'ConveniosToolStripMenuItem
        '
        Me.ConveniosToolStripMenuItem.Name = "ConveniosToolStripMenuItem"
        Me.ConveniosToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ConveniosToolStripMenuItem.Text = "Convenios de Pago"
        '
        'ReconexionToolStripMenuItem
        '
        Me.ReconexionToolStripMenuItem.Name = "ReconexionToolStripMenuItem"
        Me.ReconexionToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ReconexionToolStripMenuItem.Text = "Reconexion"
        '
        'ReconexionesGeneradasToolStripMenuItem
        '
        Me.ReconexionesGeneradasToolStripMenuItem.Name = "ReconexionesGeneradasToolStripMenuItem"
        Me.ReconexionesGeneradasToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ReconexionesGeneradasToolStripMenuItem.Text = "Reconexiones Generadas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.TipoMovimientoToolStripMenuItem, Me.MovimientosToolStripMenuItem1, Me.ReporteContadoresToolStripMenuItem, Me.ReporteDeCajaToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'TipoMovimientoToolStripMenuItem
        '
        Me.TipoMovimientoToolStripMenuItem.Name = "TipoMovimientoToolStripMenuItem"
        Me.TipoMovimientoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TipoMovimientoToolStripMenuItem.Text = "Tipo Movimiento"
        '
        'MovimientosToolStripMenuItem1
        '
        Me.MovimientosToolStripMenuItem1.Name = "MovimientosToolStripMenuItem1"
        Me.MovimientosToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.MovimientosToolStripMenuItem1.Text = "Movimientos"
        '
        'ReporteContadoresToolStripMenuItem
        '
        Me.ReporteContadoresToolStripMenuItem.Name = "ReporteContadoresToolStripMenuItem"
        Me.ReporteContadoresToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ReporteContadoresToolStripMenuItem.Text = "Reporte Contadores"
        '
        'ReporteDeCajaToolStripMenuItem
        '
        Me.ReporteDeCajaToolStripMenuItem.Name = "ReporteDeCajaToolStripMenuItem"
        Me.ReporteDeCajaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ReporteDeCajaToolStripMenuItem.Text = "Reporte Pagos"
        '
        'CrearFacturaToolStripMenuItem
        '
        Me.CrearFacturaToolStripMenuItem.Name = "CrearFacturaToolStripMenuItem"
        Me.CrearFacturaToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.CrearFacturaToolStripMenuItem.Text = "Crear Factura"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fecha, Me.usuario, Me.servidor, Me.empresa})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 430)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 23)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.Blue
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(154, 18)
        Me.fecha.Spring = True
        Me.fecha.Text = "fecha"
        Me.fecha.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'usuario
        '
        Me.usuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(154, 18)
        Me.usuario.Spring = True
        Me.usuario.Text = "Usuario"
        '
        'servidor
        '
        Me.servidor.Name = "servidor"
        Me.servidor.Size = New System.Drawing.Size(154, 18)
        Me.servidor.Spring = True
        Me.servidor.Text = "Servidor"
        '
        'empresa
        '
        Me.empresa.Name = "empresa"
        Me.empresa.Size = New System.Drawing.Size(154, 18)
        Me.empresa.Spring = True
        Me.empresa.Text = "Empresa"
        '
        'tmrHora
        '
        Me.tmrHora.Enabled = True
        Me.tmrHora.Interval = 1000
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.HelpButton = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIPrincipal"
        Me.Text = "Menu Principal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents fecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents usuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents servidor As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrHora As System.Windows.Forms.Timer
    Friend WithEvents empresa As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LecturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConveniosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaLecturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoLecturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirMachoteLecturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirLecturasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReconexionesGeneradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoMovimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteContadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParametrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReconexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
