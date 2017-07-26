Public Class frmImprimirFacturas

    Private Sub frmImprimirFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.chkAnulado.CheckState = CheckState.Indeterminate
        Me.chkAnulado.Text = "Anulados y No Anulados"
        Call llenaProyecto()
    End Sub

    Private Sub chkAnulado_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAnulado.CheckStateChanged
        If Me.chkAnulado.CheckState = CheckState.Checked Then
            Me.chkAnulado.Text = "Anulados"
        ElseIf Me.chkAnulado.CheckState = CheckState.Unchecked Then
            Me.chkAnulado.Text = "No Anulados"
        ElseIf Me.chkAnulado.CheckState = CheckState.Indeterminate Then
            Me.chkAnulado.Text = "Anulados y No Anulados"
        End If
    End Sub

    Private Sub llenaProyecto()
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select 0 idProyecto,'<Todos>' nombre from tblProyecto union  select idProyecto,nombre from tblproyecto"
        Me.cmbIdProyecto.DataSource = tbl.Tabla
        Me.cmbIdProyecto.ValueMember = "idProyecto"
        Me.cmbIdProyecto.DisplayMember = "nombre"


    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim filtro As String = ""
        Dim str As String = ""
        Dim proyecto As String = ""
        Dim anula As String = ""

        filtro = "Desde " & Me.txtFechaInicio.Text & " Hasta " & Me.txtFechaFin.Text

        If Me.cmbIdProyecto.SelectedIndex = "0" Then
            proyecto = "0,0"
            filtro = filtro & " Todos los proyectos"
        Else
            proyecto = "1," & Me.cmbIdProyecto.SelectedValue
            filtro = filtro & " Proyecto " & Me.cmbIdProyecto.Text
        End If


        If Me.chkAnulado.CheckState = CheckState.Indeterminate Then
            anula = "0,0"
            filtro = filtro & " Anulados y No Anulados"
        Else
            If Me.chkAnulado.CheckState = CheckState.Checked Then
                anula = "1,1"
                filtro = filtro & " Anulados"
            Else
                filtro = filtro & " No Anulados"
                anula = "1,0"
            End If

        End If

        
        str = "exec sp_reporteFactura " & fechaSQL(Me.txtFechaInicio.Text) & "," & fechaSQL(Me.txtFechaFin.Text) & "," & proyecto & "," & anula

        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        r.nombreParametro = "filtro"
        r.parametro = filtro
        r.reporte = "rptListadoFacturas.rpt"
        r.tabla = t.tablaSP(str)
        r.verReporte()

    End Sub
End Class