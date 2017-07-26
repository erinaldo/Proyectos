Imports System.Windows.Forms

Public Class MDIPrincipal

    Dim ctlMDI As MdiClient


    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click

    '    frmDepartamentos.MdiParent = Me
    '    Permiso.Permiso(frmDepartamentos)
    'End Sub

   
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub



    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        '  Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del primario.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub tmrHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHora.Tick
        Me.fecha.Text = Now
    End Sub

    Private Sub MDIPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
           Application.Exit()
    End Sub

    Private Sub MDIPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Esta seguro de salir del sistema ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "!!!") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub MDIPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.usuario.Text = mdlPublicVars.usuario
        Me.servidor.Text = mdlPublicVars.servidor & "\" & mdlPublicVars.bd
        Me.empresa.Text = mdlPublicVars.proyecto
        Me.Text = mdlPublicVars.proyecto

        Dim ctl As Control

        'Estamos buscando en control que representa el area cliente MDI
        For Each ctl In Me.Controls

            Try

                ctlMDI = CType(ctl, MdiClient)

                ' Asignamos el color de fondo
                ctlMDI.BackColor = Color.White

                'Aquí asignamos el manejador para pintar el fondo con degradados o lo que
                'queramos. Si solo queremos cambiar el color de fondo no hace falta, ni las funciones siguientes tampoco AddHandler ctlMDI.Paint, AddressOf PintarFondo

            Catch ex As InvalidCastException

            End Try

        Next

        'Llamamos a la funcion que carga los parametros de configuracion
        'Call mdlPublicVars.configuracion()

    End Sub

    Private Sub PintarFondo(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        On Error Resume Next
        Dim GradientePanel As New System.Drawing.Drawing2D.LinearGradientBrush(New RectangleF(0, 0, ctlMDI.Width, ctlMDI.Height), Color.Blue, Color.Black, System.Drawing.Drawing2D.LinearGradientMode.Vertical)

        e.Graphics.FillRectangle(GradientePanel, New RectangleF(0, 0, ctlMDI.Width, ctlMDI.Height))

    End Sub

    Private Sub MDIPrincipal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Not (Me.ctlMDI Is Nothing) Then

            Me.PintarFondo(Me.ctlMDI, New PaintEventArgs(Me.ctlMDI.CreateGraphics, New Rectangle(Me.ctlMDI.Location, Me.ctlMDI.Size)))

        End If

    End Sub



    Private Sub ContadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContadoresToolStripMenuItem.Click
        frmContador.Text = "Contador"
        frmContador.MdiParent = Me
        Permiso.Permiso(frmContador)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmProyecto.Text = "Proyectos"
        frmProyecto.MdiParent = Me
        Permiso.Permiso(frmProyecto)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmCliente.Text = "Clientes"
        frmCliente.MdiParent = Me
        Permiso.Permiso(frmCliente)
    End Sub

    Private Sub AsignacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignacionToolStripMenuItem.Click
        frmAsignacion.Text = "Asignacion"
        frmAsignacion.MdiParent = Me
        Permiso.Permiso(frmAsignacion)
    End Sub

    Private Sub ReconexionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReconexion.Text = "Reconexion"
        frmReconexion.MdiParent = Me
        Permiso.Permiso(frmReconexion)
    End Sub



    Private Sub OtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrosToolStripMenuItem.Click
        frmOtro.Text = "Otros cargos"
        frmOtro.MdiParent = Me
        Permiso.PermisoSimple(frmOtro)
    End Sub



    Private Sub NotasDeCreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        frmConfiguracion.Text = "Configuracion"
        frmConfiguracion.MdiParent = Me
        Permiso.Permiso(frmConfiguracion)
    End Sub

    Private Sub ConveniosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConveniosToolStripMenuItem.Click
        frmConvenios.Text = "Listado de convenios"
        frmConvenios.MdiParent = Me
        Permiso.PermisoSimple(frmConvenios)

    End Sub



    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmEmpleado.Text = "Empleados"
        frmEmpleado.MdiParent = Me
        Permiso.Permiso(frmEmpleado)
    End Sub



    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuarios.Text = "Usuarios"
        frmUsuarios.MdiParent = Me
        Permiso.Permiso(frmUsuarios)
    End Sub

    Private Sub NuevaLecturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaLecturaToolStripMenuItem.Click
        frmLecturaAgrega.Text = "Capturar Lectura"
        frmLecturaAgrega.MdiParent = Me
        frmLecturaAgrega.WindowState = FormWindowState.Maximized
        Permiso.PermisoSimple(frmLecturaAgrega)
    End Sub

    Private Sub ListadoLecturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoLecturasToolStripMenuItem.Click
        frmLecturas.Text = "Lecturas"
        frmLecturas.MdiParent = Me
        Permiso.PermisoSimple(frmLecturas)
    End Sub

    Private Sub ImprimirMachoteLecturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirMachoteLecturasToolStripMenuItem.Click
        frmImprimeMachote.Text = "Impresion Macho de lectura"
        frmImprimeMachote.MdiParent = Me
        Permiso.PermisoSimple(frmImprimeMachote)
    End Sub

    Private Sub ListadoFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmImprimirFacturas.Text = "Listado de facturas"
        frmImprimirFacturas.MdiParent = Me
        Permiso.PermisoSimple(frmImprimirFacturas)
    End Sub

    Private Sub CrearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFacturas.Text = "Facturas"
        frmFacturas.MdiParent = Me
        Permiso.PermisoSimple(frmFacturas)
    End Sub

    Private Sub ListadoFacturasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmImprimirFacturas.Text = "Impresion de Facturas"
        frmImprimirFacturas.MdiParent = Me
        Permiso.PermisoSimple(frmImprimirFacturas)
    End Sub


    Private Sub ImprimirLecturasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirLecturasToolStripMenuItem1.Click
        frmImprimeListadoLectura.Text = "Impresion de Lecturas"
        frmImprimeListadoLectura.MdiParent = Me
        Permiso.PermisoSimple(frmImprimeListadoLectura)
    End Sub


    Private Sub ReconexionesGeneradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconexionesGeneradasToolStripMenuItem.Click
        frmReconexiones.Text = "Listado de reconexiones"
        frmReconexiones.MdiParent = Me
        Permiso.PermisoSimple(frmReconexiones)
    End Sub








    Private Sub SolicitudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSolNotasCreditos.Text = "Solicitud de Nota de credito"
        frmSolNotasCreditos.MdiParent = Me
        Permiso.PermisoSimple(frmSolNotasCreditos)
    End Sub

    Private Sub IngresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmNotasCreditos.Text = "Notas de credito"
        frmNotasCreditos.MdiParent = Me
        Permiso.PermisoSimple(frmNotasCreditos)
    End Sub

    Private Sub AutorizacionNotasCreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSolNotasCreditosAutoriza.Text = "Autorizacion Notas Credito"
        frmSolNotasCreditosAutoriza.MdiParent = Me
        Permiso.PermisoSimple(frmSolNotasCreditosAutoriza)
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProducto.Text = "Productos"
        frmProducto.MdiParent = Me
        Permiso.Permiso(frmProducto)
    End Sub

    Private Sub TipoMovimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoMovimientoToolStripMenuItem.Click
        frmTipoMovimiento.Text = "Tipo Movimiento"
        frmTipoMovimiento.MdiParent = Me
        Permiso.Permiso(frmTipoMovimiento)
    End Sub

    Private Sub MovimientosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosToolStripMenuItem1.Click
        frmMovimiento.Text = "Movimientos"
        frmMovimiento.MdiParent = Me
        Permiso.PermisoSimple(frmMovimiento)
    End Sub

    Private Sub ReporteContadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteContadoresToolStripMenuItem.Click
        frmReporteContadores.Text = "Reporte Contadores"
        frmReporteContadores.MdiParent = Me
        Permiso.PermisoSimple(frmReporteContadores)
    End Sub

    Private Sub CrearToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        frmFacturas.Text = "Crear Factura"
        frmFacturas.MdiParent = Me
        Permiso.PermisoSimple(frmFacturas)
    End Sub

    Private Sub ParametrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrosToolStripMenuItem.Click
        frmParametrosAgua.Text = "Parametros"
        frmParametrosAgua.MdiParent = Me
        Permiso.PermisoSimple(frmParametrosAgua)
    End Sub

    Private Sub ReconexionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReconexionToolStripMenuItem.Click
        frmReconexion.Text = "Reconexión"
        frmReconexion.MdiParent = Me
        frmReconexion.WindowState = FormWindowState.Maximized
        Permiso.PermisoSimple(frmReconexion)
    End Sub

    Private Sub CrearFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearFacturaToolStripMenuItem.Click
        frmCreaFacturacion.Text = "Crear Factura"
        frmCreaFacturacion.MdiParent = Me
        frmCreaFacturacion.WindowState = FormWindowState.Maximized
        Permiso.PermisoSimple(frmCreaFacturacion)
    End Sub

    Private Sub ReporteDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCajaToolStripMenuItem.Click
        frmReporteContadores.Text = "Reporte"
        frmReportePagos.MdiParent = Me
        frmReportePagos.WindowState = FormWindowState.Normal
        frmReportePagos.StartPosition = FormStartPosition.CenterScreen
        frmReportePagos.Show()
    End Sub
End Class
