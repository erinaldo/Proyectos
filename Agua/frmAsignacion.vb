Public Class frmAsignacion

    Dim tbl As New clsDevuelveTabla
    Dim Asignacion As New clsAsignacion

    Private Sub llenaGrid()

        tbl.sqlString = "select a.idAsignacion IdAsignacion,a.idProyecto IdProyecto," _
& "p.nombre Proyecto,a.idCliente IdCliente,c.nombre Cliente,a.noServicios NoServicios," _
& "a.fecha Fecha,a.direccion Direccion,a.fechaInstalacion FechaInstalacion," _
& "a.observacion Observacion,a.manzana Manzana,a.lote Lote,a.lecturaInicial LecturaInicial,a.saldoInicial SaldoInicial " _
& "from tblAsignacion a inner join tblProyecto p " _
& "on a.idProyecto = p.idProyecto inner join tblCliente c " _
& "on a.idCliente = c.idCliente order by a.idAsignacion desc"


        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmAsignacion_grdDatosDobleClik() Handles Me.grdDatosDobleClik
        If Me.txtIdAsignacion.Text = "" Then
            Exit Sub
        End If
        frmAsignacionContador.Text = "Asignar contadores"
        frmAsignacionContador.StartPosition = FormStartPosition.CenterScreen
        frmAsignacionContador.idAsignacion = Me.txtIdAsignacion.Text
        frmAsignacionContador.Show()
    End Sub


    Private Sub frmAsignacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtIdProyecto, "Nombre")
            .Controls.Add(Me.txtFecha, "Fecha")
            .Controls.Add(Me.txtFechaInstalacion, "Fecha Instalacion")
            
            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmAsignacion_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdAsignacion.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            Asignacion.idAsignacion = Me.txtIdAsignacion.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(Asignacion.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmAsignacion_grabaRegistro() Handles Me.grabaRegistro
        Try
            Asignacion.fecha = Me.txtFecha.Text
            Asignacion.idProyecto = Me.txtIdProyecto.Text
            Asignacion.idCliente = Me.txtIdCliente.Text
            Asignacion.direccion = Me.txtDireccion.Text
            Asignacion.fechaInstalacion = Me.txtFechaInstalacion.Text
            Asignacion.observacion = Me.txtObservacion.Text
            Asignacion.lote = Me.txtLote.Text
            Asignacion.noServicios = Me.txtNoServicios.Text
            Asignacion.manzana = Me.txtManzana.Text
            Asignacion.lecturaInicial = Me.txtLecturaInicial.Text
            Asignacion.saldoInicial = Nz(Me.txtSaldoInicial.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End Try

        If Me.txtIdAsignacion.Text = "" Then
            MsgBox(Asignacion.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub

    Private Sub frmAsignacion_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtFecha.Text = Today
        Me.txtFechaInstalacion.Text = Today
        Me.txtFecha.Focus()


    End Sub



    Private Sub frmAsignacion_modificaRegistro() Handles Me.modificaRegistro
        Try
            Asignacion.fecha = Me.txtFecha.Text
            Asignacion.idProyecto = Me.txtIdProyecto.Text
            Asignacion.idCliente = Me.txtIdCliente.Text
            Asignacion.direccion = Me.txtDireccion.Text
            Asignacion.noServicios = Me.txtNoServicios.Text
            Asignacion.fechaInstalacion = Me.txtFechaInstalacion.Text
            Asignacion.observacion = Me.txtObservacion.Text
            Asignacion.lote = Me.txtLote.Text
            Asignacion.manzana = Me.txtManzana.Text
            Asignacion.lecturaInicial = Me.txtLecturaInicial.Text
            Asignacion.saldoInicial = Nz(Me.txtSaldoInicial.Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End Try
        If Me.txtIdAsignacion.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            Asignacion.idAsignacion = Me.txtIdAsignacion.Text
            MsgBox(Asignacion.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmAsignacion_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de Asignacions"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub

    Private Sub txtIdProyecto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdProyecto.LostFocus
        If Not IsNumeric(Me.txtIdProyecto.Text) And Me.txtIdProyecto.Text <> "" Then
            Me.txtIdProyecto.Text = ""
            Me.txtIdProyecto.Focus()
            Exit Sub
        End If
        If Me.txtIdProyecto.Text <> "" Then
            If mdlPublicVars.RevisaCampo("tblProyecto", "IdProyecto", "nombre", Me.txtIdProyecto.Text) = False Then
                MsgBox("Proyecto no valido !!!", MsgBoxStyle.Critical, "!!!")
                Me.txtIdProyecto.Text = ""
                Me.txtProyecto.Text = ""
                Me.txtIdProyecto.Focus()
            Else
                Me.txtProyecto.Text = mdlPublicVars.superSearchNombre
            End If
        End If
    End Sub



    Private Sub txtIdProyecto_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtIdProyecto.MouseDoubleClick
        frmSuperSearch.sqlString = "select IdProyecto,nombre from tblProyecto"
        frmSuperSearch.nombre = "nombre"
        frmSuperSearch.Text = "Proyecto Actividad"

        frmSuperSearch.ShowDialog()
        If mdlPublicVars.superSearchId = 0 Then
            Exit Sub
        Else
            Me.txtIdProyecto.Text = mdlPublicVars.superSearchId
            Me.txtProyecto.Text = mdlPublicVars.superSearchNombre
        End If
    End Sub

    Private Sub txtIdCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCliente.LostFocus
        If Not IsNumeric(Me.txtIdCliente.Text) And Me.txtIdCliente.Text <> "" Then
            Me.txtIdCliente.Text = ""
            Me.txtIdCliente.Focus()
            Exit Sub
        End If
        If Me.txtIdCliente.Text <> "" Then
            If mdlPublicVars.RevisaCampo("tblCliente", "IdCliente", "nombre", Me.txtIdCliente.Text) = False Then
                MsgBox("Cliente no valido !!!", MsgBoxStyle.Critical, "!!!")
                Me.txtIdCliente.Text = ""
                Me.txtCliente.Text = ""
                Me.txtIdCliente.Focus()
            Else
                Me.txtCliente.Text = mdlPublicVars.superSearchNombre
            End If
        End If
    End Sub



    Private Sub txtIdCliente_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtIdCliente.MouseDoubleClick
        frmSuperSearch.sqlString = "select IdCliente,nombre from tblCliente"
        frmSuperSearch.nombre = "nombre"
        frmSuperSearch.Text = "Cliente Actividad"

        frmSuperSearch.ShowDialog()
        If mdlPublicVars.superSearchId = 0 Then
            Exit Sub
        Else
            Me.txtIdCliente.Text = mdlPublicVars.superSearchId
            Me.txtCliente.Text = mdlPublicVars.superSearchNombre
        End If
    End Sub

    Private Sub btnAsignarContador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarContador.Click
        If Me.txtIdAsignacion.Text = "" Then
            MsgBox("Muevas a un registro con informacion", MsgBoxStyle.Critical, "!!!")
        End If
        frmAsignacionContador.Text = "Asignar contadores"
        frmAsignacionContador.StartPosition = FormStartPosition.CenterScreen
        frmAsignacionContador.idAsignacion = Me.txtIdAsignacion.Text
        frmAsignacionContador.Show()
    End Sub

    Private Sub btnContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContrato.Click
        If Me.txtIdAsignacion.Text = "" Then
            MsgBox("Muevase a un registro con informacion", MsgBoxStyle.Exclamation, "!!!")
            Exit Sub
        End If
        frmContrato.Text = "Contrato"
        frmContrato.idAsignacion = Me.txtIdAsignacion.Text
        frmContrato.MdiParent = MDIPrincipal
        frmContrato.Show()
    End Sub

    Private Sub btnVerReporte_Click(sender As Object, e As EventArgs) Handles btnVerReporte.Click
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        r.reporte = "rptReporteAsignaciones.rpt"
        r.tabla = t.tablaSP("exec sp_reporteFacturacion " & mdlPublicVars.fechaSQL(Me.dtpDesde.Value) & "," & mdlPublicVars.fechaSQL(Me.dtpHasta.Value))
        r.verReporte()
        Me.pnlReporte.Visible = False
    End Sub

    Private Sub btnReporte2_Click(sender As Object, e As EventArgs) Handles btnReporte2.Click
        Me.pnlReporte.Visible = True
    End Sub
End Class
