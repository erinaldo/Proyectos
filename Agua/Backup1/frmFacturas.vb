Public Class frmFacturas
    Dim idFactura As Int32
    Dim anulado As Boolean
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Call llenaGrid()
    End Sub
    Private Sub bloqueaColumnas()
        Dim col As DataGridViewColumn

        For Each col In Me.grdLecturas.Columns
            col.ReadOnly = True
            col.DefaultCellStyle.BackColor = Color.LightGray
        Next

        For Each col In Me.grdLecturas.Columns
            col.ReadOnly = True
            col.DefaultCellStyle.BackColor = Color.LightGray
        Next
    End Sub
    Private Sub llenaGrid()
        Dim tbl As New clsDevuelveTabla
        If IsDBNull(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un proyecto valido", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        Dim str As String
        Me.grdLecturas.DataSource = Nothing

        str = "sp_listadoFactura " & fechaSQL(Me.cmbFechaInicio.Text) & "," & fechaSQL(Me.cmbFechaFin.Text) & "," & Me.cmbIdProyecto.SelectedValue
        Me.grdLecturas.DataSource = tbl.tablaSP(str)
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
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnNuevaLectura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaLectura.Click
        frmFactura.Text = "Captura de factura"
        frmFactura.MdiParent = MDIPrincipal
        frmFactura.Show()
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If Me.grdLecturas.RowCount = 0 Then
            MsgBox("No existe ninguna factura para anular", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        If MsgBox("Esta seguro de anular esta factura", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "!!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        If anulado = True Then
            MsgBox("Esta factura ya ha sido anulada", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        frmAnulaFactura.Text = "Anular Factura"
        frmAnulaFactura.idFActura = idFactura
        Permiso.PermisoSimple(frmAnulaFactura)
        Call llenaGrid()



    End Sub

    Private Sub grdLecturas_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.CellContentClick
        Dim montoFactura As Decimal
        Dim idFactura As Integer
        If e.RowIndex = -1 Then
            Exit Sub
        End If
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        If Me.grdLecturas.Columns(e.ColumnIndex).Name = "Imprimir" Then
            If Me.grdLecturas.Rows(e.RowIndex).Cells("anulado").Value = True Then
                Exit Sub
            End If

            montoFactura = Me.grdLecturas.Rows(e.RowIndex).Cells("Monto").Value
            idFactura = Me.grdLecturas.Rows(e.RowIndex).Cells("idFactura").Value
            r.nombreParametro = "filtro"
            r.parametro = mdlLetras.Letras(CStr(montoFactura))
            r.reporte = "rptImprimeFactura.rpt"
            r.tabla = t.tablaSP("exec sp_imprimeFactura " & idFactura)
            r.verReporte()



        End If
    End Sub

    Private Sub grdLecturas_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.RowEnter
        idFactura = Me.grdLecturas.Rows(e.RowIndex).Cells(1).Value
        anulado = Me.grdLecturas.Rows(e.RowIndex).Cells("anulado").Value
        Call bloqueaColumnas()
    End Sub


   
    Private Sub btnProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducto.Click
        frmFacturaProducto.Text = "Captura de factura"
        frmFacturaProducto.MdiParent = MDIPrincipal
        frmFacturaProducto.Show()
    End Sub
End Class