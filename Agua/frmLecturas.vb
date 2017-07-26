Public Class frmLecturas
    Dim idLectura As Int32




    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Me.grdLecturaContador.DataSource = ""
        Call llenaGrid()
        Me.ToolStripStatusLabel1.Text = "#Registros: " & Me.grdLecturas.RowCount
    End Sub

    Private Sub llenaGrid()
        Dim tbl As New clsDevuelveTabla
        If IsDBNull(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un proyecto valido", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        Dim str As String
        Me.grdLecturas.DataSource = Nothing

        str = "sp_listadoLectura " & fechaSQL(Me.cmbFechaInicio.Text) & "," & fechaSQL(Me.cmbFechaFin.Text) & "," & Me.cmbIdProyecto.SelectedValue
        Me.grdLecturas.DataSource = tbl.tablaSP(str)
    End Sub
    Private Sub llenaProyecto()
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select idProyecto,nombre from tblproyecto"
        Me.cmbIdProyecto.DataSource = tbl.Tabla
        Me.cmbIdProyecto.ValueMember = "idProyecto"
        Me.cmbIdProyecto.DisplayMember = "nombre"


    End Sub
    Private Sub frmLecturas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call llenaProyecto()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub bloqueaColumnas()
        Dim col As DataGridViewColumn

        For Each col In Me.grdLecturas.Columns
            col.ReadOnly = True
            col.DefaultCellStyle.BackColor = Color.LightGray
        Next

        For Each col In Me.grdLecturaContador.Columns
            col.ReadOnly = True
            col.DefaultCellStyle.BackColor = Color.LightGray
        Next
    End Sub


    Private Sub btnNotasCobro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotasCobro.Click
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        'r.nombreParametro = ""
        'r.parametro = ""
        r.reporte = "rptImpresionNotasCobro.rpt"
        r.tabla = t.tablaSP("exec sp_ImprimeNotasCobro " & fechaSQL(Me.cmbFechaInicio.Text) & "," & fechaSQL(Me.cmbFechaFin.Text) & "," & Me.cmbIdProyecto.SelectedValue)
        r.verReporte()
    End Sub

    

    Private Sub grdLecturas_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.RowEnter
        llenaLecturasContador(e)
    End Sub

    Private Sub llenaLecturasContador(ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim str As String
        Dim tbl As New clsDevuelveTabla

        str = "select c.numero Contador,lt.lecturaActual Lectura,lt.consumo Consumo " _
        & "from tmpLectura lt " _
& "inner join tblAsignacionContador ac " _
& "on lt.idAsignacionContador = ac.idAsignacionContador " _
& "inner join tblContador c " _
& "on ac.idContador = c.idcontador " _
& "where lt.idLectura =  " & Me.grdLecturas.Rows(e.RowIndex).Cells(1).Value


        tbl.sqlString = str
        Me.grdLecturaContador.DataSource = tbl.Tabla
        Call bloqueaColumnas()
        idLectura = Me.grdLecturas.Rows(e.RowIndex).Cells(1).Value
    End Sub

 

    Private Sub grdLecturaContador_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturaContador.RowEnter

        '= Me.grdLecturas.Rows(e.RowIndex).Cells("anulado").Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        r.nombreParametro = "filtro"
        r.parametro = "Lecturas desde " & Me.cmbFechaInicio.Text & " Hasta " & Me.cmbFechaFin.Text & " Proyecto: " & Me.cmbIdProyecto.Text
        r.reporte = "rptPagosFactura.rpt"
        r.tabla = t.tablaSP("exec sp_pagosLectura  " & fechaSQL(Me.cmbFechaInicio.Text) & "," & fechaSQL(Me.cmbFechaFin.Text) & "," & Me.cmbIdProyecto.SelectedValue)
        r.verReporte()
    End Sub



    Private Sub grdLecturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.CellContentClick
        If e.RowIndex = -1 Then
            Exit Sub
        End If

        If e.ColumnIndex = 0 Then
            If Me.grdLecturas.RowCount = 0 Then
                MsgBox("No existe ninguna factura para anular", MsgBoxStyle.Critical, "!!!")
                Exit Sub
            End If

            If MsgBox("Esta seguro de anular esta factura", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "!!!") = MsgBoxResult.No Then
                Exit Sub
            End If

            frmEliminaLectura.idLectura = Me.grdLecturas.Rows(e.RowIndex).Cells(1).Value
            Permiso.PermisoSimpleDialog(frmEliminaLectura)
            Call llenaGrid()

        End If
    End Sub
End Class