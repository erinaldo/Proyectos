Public Class frmConfiguracion
    Dim tbl As New clsDevuelveTabla
    Dim Configuracion As New clsConfiguracion

    Private Sub llenaGrid()

        tbl.sqlString = "select top 1 idConfiguracion IdConfiguracion,iva Iva,corrConvenio CorrConvenio, " _
& "corrFactura CorrFactura,corrNotaCobro CorrNotaCobro,corrNotaCredito CorrNotaCredito,serieFactura SerieFactura " _
& "from tblconfiguracion " _
& "order by idConfiguracion asc"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtIva, "Iva")
            .Controls.Add(Me.txtCorrConvenio, "Convenio")
            .Controls.Add(Me.txtCorrFactura, "Factura")
            .Controls.Add(Me.txtCorrNotaCobro, "Nota de cobro")
            .Controls.Add(Me.txtCorrNotaCredito, "Nota de credito")
            .Controls.Add(Me.txtSerieFactura, "Serie de Factura")

            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmConfiguracion_eliminaRegistro() Handles Me.eliminaRegistro
        MsgBox("Opcion deshabilitada", MsgBoxStyle.Critical, "!!!")
    End Sub

    Private Sub frmConfiguracion_grabaRegistro() Handles Me.grabaRegistro
        MsgBox("Opcion deshabilitada", MsgBoxStyle.Critical, "!!!")
    End Sub

    Private Sub frmConfiguracion_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtIva.Focus()

    End Sub



    Private Sub frmConfiguracion_modificaRegistro() Handles Me.modificaRegistro
        Configuracion.iva = Me.txtIva.Text
        Configuracion.corrConvenio = Me.txtCorrConvenio.Text
        Configuracion.corrFactura = Me.txtCorrFactura.Text
        Configuracion.corrNotaCobro = Me.txtCorrNotaCobro.Text
        Configuracion.corrNotaCredito = Me.txtCorrNotaCredito.Text
        Configuracion.serieFactura = Me.txtSerieFactura.Text
        If Me.txtIdConfiguracion.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            Configuracion.idConfiguracion = Me.txtIdConfiguracion.Text
            MsgBox(Configuracion.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmConfiguracion_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de Configuracions"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub
End Class
