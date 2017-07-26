Public Class frmConvenios

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Me.grdPagosConvenio.DataSource = ""
        Call llenaGrid()
        Call bloqueaColumnas()
    End Sub

    Private Sub llenaGrid()
        Dim tbl As New clsDevuelveTabla
        If IsDBNull(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un proyecto valido", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        Dim str As String
        Me.grdLecturas.DataSource = Nothing

        str = "sp_listadoConvenio " & fechaSQL(Me.cmbFechaInicio.Text) & "," & fechaSQL(Me.cmbFechaFin.Text) & "," & Me.cmbIdProyecto.SelectedValue
        Me.grdLecturas.DataSource = tbl.tablaSP(str)

    End Sub

    Private Sub llenaSubGrid(ByVal idConvenio As String)
        Dim str As String
        Dim tbl As New clsDevuelveTabla
        str = "select isnull(convert(varchar(10),l.fecha),'') Fecha,cp.monto Monto," _
        & "case " _
& "when cp.idLectura is null then 'No' " _
& "when cp.idLectura  is not null then 'Si' " _
& "end Pagado, " _
& "isnull(convert(varchar(10),cp.idLectura),'') IdLectura " _
& "from tblconveniopago cp " _
& "left join tblLectura l " _
& "on cp.idLectura = l.idLectura where cp.idConvenio = " & idConvenio & " " _
& "order by cp.idConvenioPago asc"

        tbl.sqlString = str
        Me.grdPagosConvenio.DataSource = tbl.Tabla

    End Sub
    Private Sub llenaProyecto()
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select idProyecto,nombre from tblproyecto"
        Me.cmbIdProyecto.DataSource = tbl.Tabla
        Me.cmbIdProyecto.ValueMember = "idProyecto"
        Me.cmbIdProyecto.DisplayMember = "nombre"


    End Sub
    Private Sub frmFacturas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call llenaProyecto()
    End Sub


    Private Sub bloqueaColumnas()
        Dim col As New DataGridViewColumn
        For Each col In Me.grdLecturas.Columns

            col.ReadOnly = True
            col.DefaultCellStyle.BackColor = Color.Gray

        Next

        For Each col In Me.grdPagosConvenio.Columns
            col.ReadOnly = True
            col.DefaultCellStyle.BackColor = Color.Gray
        Next
    End Sub

    

    Private Sub grdLecturas_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.RowEnter
        Call llenaSubGrid(Me.grdLecturas.Rows(e.RowIndex).Cells(0).Value)
    End Sub




    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmConvenio.Text = "Nuevo convenio Total Factura"
        frmConvenio.MdiParent = MDIPrincipal
        Permiso.PermisoSimple(frmConvenio)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmConvenioLibre.Text = "Nuevo convenio Monto Variable"
        frmConvenioLibre.MdiParent = MDIPrincipal
        Permiso.PermisoSimple(frmConvenioLibre)

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmListadoConvenio.Text = "Listado de convenios"
        frmListadoConvenio.MdiParent = MDIPrincipal
        Permiso.PermisoSimple(frmListadoConvenio)
    End Sub
End Class