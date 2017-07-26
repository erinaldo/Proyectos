Public Class frmReportePagos

    Private Sub frmReportePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpDesde.Value = Today
        Me.dtpHasta.Value = Today
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim r As New clsReporte
        Dim t As New clsDevuelveTabla
        Dim sql As String

        sql = "exec sp_reporteCobrosDia " & mdlPublicVars.fechaSQL(Me.dtpDesde.Value) & "," & mdlPublicVars.fechaSQL(Me.dtpHasta.Value)
        r.tabla = t.tablaSP(sql)
        r.reporte = "rptCobroDelDia.rpt"
        If r.tabla.Rows.Count = 0 Then
            MsgBox("No hay datos", MsgBoxStyle.Exclamation, "!!!")
            Exit Sub
        End If
        r.verReporte()

    End Sub

    Private Sub btnReporteFacturas_Click(sender As Object, e As EventArgs) Handles btnReporteFacturas.Click
        Dim r As New clsReporte
        Dim t As New clsDevuelveTabla
        Dim sql As String

        sql = "exec sp_listadoFacturas " & mdlPublicVars.fechaSQL(Me.dtpDesde.Value) & "," & mdlPublicVars.fechaSQL(Me.dtpHasta.Value)
        r.tabla = t.tablaSP(sql)
        r.reporte = "rptListadoFactura.rpt"
        If r.tabla.Rows.Count = 0 Then
            MsgBox("No hay datos", MsgBoxStyle.Exclamation, "!!!")
            Exit Sub
        End If
        r.verReporte()

    End Sub
End Class