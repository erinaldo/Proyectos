Public Class frmReporteContadores

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        Dim filtro As String = ""
        Dim opcion As Integer
        Dim str As String = ""


        filtro = " "

        If Me.rbtTodos.Checked Then
            filtro = "Todos los contadores"
            opcion = 1
        End If

        If Me.rbtNoDisponibles.Checked Then
            filtro = " Disponibles"
            opcion = 2
        End If

        If Me.rbtDisponibles.Checked Then
            filtro = "No Disponibles"
            opcion = 3
        End If

       




        str = "exec sp_contadores " & opcion
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        r.nombreParametro = "filtro"
        r.parametro = filtro
        r.reporte = "rptContadores.rpt"
        r.tabla = t.tablaSP(str)
        r.verReporte()
    End Sub
End Class