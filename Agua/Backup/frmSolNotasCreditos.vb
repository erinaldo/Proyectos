Public Class frmSolNotasCreditos
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

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        frmSolNotaCredito.Text = "Captura Solicitud Nota Credito"
        frmSolNotaCredito.MdiParent = MDIPrincipal
        frmSolNotaCredito.Show()
    End Sub


End Class