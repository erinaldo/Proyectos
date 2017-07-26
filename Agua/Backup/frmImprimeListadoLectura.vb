Public Class frmImprimeListadoLectura

    Private Sub llenaProyecto()
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select idProyecto,nombre from tblproyecto"
        Me.cmbIdProyecto.DataSource = tbl.Tabla
        Me.cmbIdProyecto.ValueMember = "idProyecto"
        Me.cmbIdProyecto.DisplayMember = "nombre"

        Call llenaAsignacion(Me.cmbIdProyecto.SelectedValue)

    End Sub

    Private Sub llenaAsignacion(ByVal idProyecto As Int16)
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select 0 idAsignacion,'<Todas>' nombre from tblasignacion union select a.idAsignacion,c.nombre " _
& "from tblasignacion a " _
& "inner join tblCliente c " _
& "on a.idCliente = c.idCliente " _
& "where a.idProyecto = " & idProyecto

        Me.cmbIdAsignacion.DataSource = tbl.Tabla
        Me.cmbIdAsignacion.ValueMember = "idAsignacion"
        Me.cmbIdAsignacion.DisplayMember = "nombre"
    End Sub

    Private Sub cmbIdProyecto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIdProyecto.SelectedIndexChanged
        Me.cmbIdAsignacion.Text = ""
        Me.cmbIdAsignacion.SelectedText = ""


        If IsNumeric(Me.cmbIdProyecto.SelectedValue) Then
            Call llenaAsignacion(CInt(Me.cmbIdProyecto.SelectedValue))


        End If
    End Sub

    Private Sub frmImprimeListadoLectura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call llenaProyecto()
    End Sub

    
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim filtro As String = ""
        Dim str As String = ""
        Dim proyecto As String = ""
        Dim asignacion As String = ""

        filtro = "Desde " & Me.txtFechaInicio.Text & " Hasta " & Me.txtFechaFin.Text

        proyecto = Me.cmbIdProyecto.SelectedValue
        filtro = filtro & " Proyecto " & Me.cmbIdProyecto.Text

        If Me.cmbIdAsignacion.SelectedIndex = 0 Then
            asignacion = ",0,0"
            filtro = filtro & "Todas las asignaciones"
        Else
            asignacion = ",1," & Me.cmbIdAsignacion.SelectedValue
            filtro = filtro & " Asignacion: " & Me.cmbIdAsignacion.SelectedText
        End If



        str = "exec sp_EstadoCta " & fechaSQL(Me.txtFechaInicio.Text) & "," & fechaSQL(Me.txtFechaFin.Text) & asignacion & "," & proyecto

        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        r.nombreParametro = "filtro"
        r.parametro = filtro
        r.reporte = "rptListadoLecturas.rpt"
        r.tabla = t.tablaSP(str)
        r.verReporte()
    End Sub
End Class