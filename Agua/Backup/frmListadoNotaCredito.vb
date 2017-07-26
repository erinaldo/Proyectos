Public Class frmListadoNotaCredito
    Private Sub llenaProyecto()
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select idProyecto,nombre from tblproyecto"
        Me.cmbIdProyecto.DataSource = tbl.Tabla
        Me.cmbIdProyecto.ValueMember = "idProyecto"
        Me.cmbIdProyecto.DisplayMember = "nombre"


    End Sub

    Private Sub rptListadoOtros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call llenaProyecto()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim filtro As String = ""
        Dim str As String = ""
        Dim proyecto As String = ""
        Dim anula As String = ""

        filtro = "Desde " & Me.txtFechaInicio.Text & " Hasta " & Me.txtFechaFin.Text


        proyecto = Me.cmbIdProyecto.SelectedValue
        filtro = filtro & " Proyecto " & Me.cmbIdProyecto.Text





        str = "exec sp_listadoNotaCredito 1," & fechaSQL(Me.txtFechaInicio.Text) & "," & fechaSQL(Me.txtFechaFin.Text) & "," & proyecto

        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        r.nombreParametro = "filtro"
        r.parametro = filtro
        r.reporte = "rptListadoNotaCredito.rpt"
        r.tabla = t.tablaSP(str)
        r.verReporte()
    End Sub
End Class