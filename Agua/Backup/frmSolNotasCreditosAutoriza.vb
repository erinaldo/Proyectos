Public Class frmSolNotasCreditosAutoriza
    Dim idNotaCredito As Integer
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Call llenaGrid()
    End Sub

    Private Sub llenaGrid()
        Dim tbl As New clsDevuelveTabla
        If IsDBNull(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un proyecto valido", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        Dim str As String
        Me.grdLecturas.AutoGenerateColumns = False
        Me.grdLecturas.DataSource = Nothing

        str = "sp_listadoNotaCredito 2, " & fechaSQL(Me.cmbFechaInicio.Text) & "," & fechaSQL(Me.cmbFechaFin.Text) & "," & Me.cmbIdProyecto.SelectedValue
        Me.grdLecturas.DataSource = tbl.tablaSP(str)
        Me.ToolStripStatusLabel1.Text = "# Registros: " & Me.grdLecturas.RowCount
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
    End Sub


    Private Sub grdLecturas_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.CellEnter
        idNotaCredito = Me.grdLecturas.Rows(e.RowIndex).Cells(0).Value
    End Sub





    Private Sub grdLecturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.CellContentClick
        Dim autorizada As Boolean
        Dim rechazada As Boolean
        Dim monto As Double
        Dim observacion As String = ""
        Dim tipo As Int16

        Dim id As Double
        Dim idAsignacion As Double
        Dim sql As String

        Dim t As New clsDevuelveTabla


        If e.RowIndex = -1 Then
            Exit Sub
        End If



        autorizada = Me.grdLecturas.Rows(e.RowIndex).Cells("Autorizada").Value
        rechazada = Me.grdLecturas.Rows(e.RowIndex).Cells("Rechazada").Value
        idAsignacion = Me.grdLecturas.Rows(e.RowIndex).Cells("IdAsignacion").Value
        monto = Me.grdLecturas.Rows(e.RowIndex).Cells("Monto").Value
        id = Me.grdLecturas.Rows(e.RowIndex).Cells("Id").Value
        tipo = Me.grdLecturas.Rows(e.RowIndex).Cells("Codigo").Value
        observacion = "Solicitud Autorizada No. " & id

        If autorizada = True Then
            MsgBox("Nota de credito ya ha sido autorizada", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        If rechazada = True Then
            MsgBox("Nota de credito ya ha sido rechazada", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        If Me.grdLecturas.Columns(e.ColumnIndex).Name = "Autoriza" Then
            If MsgBox("Esta seguro de Autorizar esta Nota de credito", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "!!!") = MsgBoxResult.No Then
                Exit Sub
            End If
            sql = "sp_insertaNotaCredito " & fechaSQL(Today()) & "," & idAsignacion & "," & mdlPublicVars.idUsuario & "," & monto & ",'" & observacion & "'," & tipo
            t.sqlString = sql
            t.ejecutaSQL()
            sql = "update tblSolNotaCredito set autorizada = 1 where idSolNotaCredito = " & id
            t.sqlString = sql
            t.ejecutaSQL()

        End If

        If Me.grdLecturas.Columns(e.ColumnIndex).Name = "Rechaza" Then
            If MsgBox("Esta seguro de Rechazar esta Nota de credito", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "!!!") = MsgBoxResult.No Then
                Exit Sub
            End If

            observacion = ""
            observacion = InputBox("Observacion", "Motivo Rechazo")

            sql = "update tblSolNotaCredito set rechazada = 1 , observacionRechazada = ' " & observacion & "'" & " where idSolNotaCredito = " & id
            t.sqlString = sql
            t.ejecutaSQL()
        End If

        Call llenaGrid()
    End Sub
End Class