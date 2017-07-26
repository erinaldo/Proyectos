Public Class frmNotasCreditos
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

        str = "sp_listadoNotaCredito 1," & fechaSQL(Me.cmbFechaInicio.Text) & "," & fechaSQL(Me.cmbFechaFin.Text) & "," & Me.cmbIdProyecto.SelectedValue
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

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Me.grdLecturas.RowCount = 0 Then
            MsgBox("No existe ninguna nota de credito en el filtro", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        If MsgBox("Esta seguro de eliminar esta nota de credito", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "!!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        frmEliminaNotaCredito.Text = "Eliminar nota de credito"
        frmEliminaNotaCredito.idNotaCredito = idNotaCredito
        Permiso.PermisoSimple(frmEliminaNotaCredito)
        Call llenaGrid()



    End Sub

    Private Sub grdLecturas_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.CellEnter
        idNotaCredito = Me.grdLecturas.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        frmNotaCredito.Text = "Captura de notas de credito"
        frmNotaCredito.MdiParent = MDIPrincipal
        frmNotaCredito.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmListadoNotaCredito.Text = "Listados de Notas de credito"
        frmListadoNotaCredito.MdiParent = MDIPrincipal
        Permiso.PermisoSimple(frmListadoNotaCredito)
    End Sub
End Class