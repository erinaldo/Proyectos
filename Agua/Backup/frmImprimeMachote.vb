Public Class frmImprimeMachote
    Private Sub llenaProyecto()
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select idProyecto,nombre from tblproyecto"
        Me.cmbIdProyecto.DataSource = tbl.Tabla
        Me.cmbIdProyecto.ValueMember = "idProyecto"
        Me.cmbIdProyecto.DisplayMember = "nombre"


    End Sub

    Private Sub frmImprimeMachote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call llenaProyecto()
    End Sub

    Private Sub btnImprimeMachote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimeMachote.Click
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        r.nombreParametro = "filtro"
        r.parametro = "Proyecto: " & Me.cmbIdProyecto.Text
        r.reporte = "rptMachoteLectura.rpt"
        r.tabla = t.tablaSP("exec sp_machoteLectura " & Me.cmbIdProyecto.SelectedValue)
        r.verReporte()
    End Sub
End Class