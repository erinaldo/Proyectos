Public Class frmFacturas
    Dim idFactura As Int32
    Dim anulado As Boolean
    Private _idProyecto As Integer
    Public Property idProyecto() As Integer
        Get
            idProyecto = _idProyecto
        End Get
        Set(ByVal value As Integer)
            _idProyecto = value
        End Set
    End Property
    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Call llenaGrid()
        Call CheckPaga()
    End Sub
    Private Sub bloqueaColumnas()
        Dim col As DataGridViewColumn

        For Each col In Me.grdLecturas.Columns
            If col.Index > 3 Then
                col.ReadOnly = True
                col.DefaultCellStyle.BackColor = Color.White
            End If
        Next

        For Each col In Me.grdLecturas.Columns
            If col.Index > 3 Then
                col.ReadOnly = True
                col.DefaultCellStyle.BackColor = Color.White
            End If
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
    Private Sub llenaGridCodigoCliente()
        Dim tbl As New clsDevuelveTabla
        If IsDBNull(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un proyecto valido", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        Dim str As String
        Me.grdLecturas.DataSource = Nothing

        str = "sp_listadoFacturaCodigoCliente " & fechaSQL(Me.cmbFechaInicio.Text) & "," & fechaSQL(Me.cmbFechaFin.Text) & "," & Me.cmbIdProyecto.SelectedValue & ",'" & Me.txtCodigoCliente.Text & "'"
        Me.grdLecturas.DataSource = tbl.tablaSP(str)
    End Sub

    Public Sub llenaGridSecundario()
        Dim tbl As New clsDevuelveTabla
        If IsDBNull(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un proyecto valido", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        Dim str As String
        Me.grdLecturas.DataSource = Nothing

        str = "sp_listadoFactura " & fechaSQL(Today) & "," & fechaSQL(Today) & "," & Me.idProyecto
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
    Private Sub CheckPaga()
        Dim i As Integer = 0
        Dim nB As String = ""
        Dim nR As String = ""
        Dim sql As String
        Dim d As New DataTable
        Dim t As New clsDevuelveTabla

        For i = 0 To Me.grdLecturas.Rows.Count - 1
            sql = "select noBoleta,documento from tblFactura where idFactura = " & Me.grdLecturas.Rows(i).Cells("idFactura").Value
            d = t.tablaSP(sql)
            nB = d.Rows(0).Item("noBoleta").ToString
            nR = d.Rows(0).Item("documento").ToString

            If Me.grdLecturas.Rows(i).Cells("Pagada").Value = True Then
                Me.grdLecturas.Rows(i).Cells("Rebajar").Value = True
                Me.grdLecturas.Rows(i).Cells("NoBoleta").Value = nB
                Me.grdLecturas.Rows(i).Cells("NoRecibo").Value = nR
                Me.grdLecturas.Rows(i).Cells("NoBoleta").ReadOnly = True
                Me.grdLecturas.Rows(i).Cells("NoRecibo").ReadOnly = True
                Me.grdLecturas.Rows(i).Cells("Rebajar").ReadOnly = True
            Else
                Me.grdLecturas.Rows(i).Cells("Rebajar").Value = False
            End If
        Next
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

        If Me.grdLecturas.CurrentRow.Cells("Anulado").Value = True Then
            MsgBox("Esta factura ya fue anulada", MsgBoxStyle.Exclamation, "!!!")
            Exit Sub
        End If

        Dim t As New clsDevuelveTabla
        Dim idFactura As Integer = 0
        Dim idLectura As Integer = 0
        Dim idAsignacion As Integer = 0

        idFactura = Me.grdLecturas.CurrentRow.Cells("IdFactura").Value
        idLectura = Me.grdLecturas.CurrentRow.Cells("IdLectura").Value
        idAsignacion = Me.grdLecturas.CurrentRow.Cells("IdAsignacion").Value

        If idFactura = 0 Or idFactura = Nothing Then
            MsgBox("No existe el numero de factura ", MsgBoxStyle.Information, "!!!")
            Exit Sub
        End If

        If MsgBox("Esta seguro de anular esta factura", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "!!!") = MsgBoxResult.No Then
            Exit Sub
        ElseIf MsgBoxResult.Yes Then
            t.sqlString = "exec sp_AnulaFactura " & idFactura & "," & idAsignacion & "," & idLectura
            t.ejecutaSQL()
            Call llenaGrid()
            Call CheckPaga()
        End If

    End Sub

    Private Sub grdLecturas_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLecturas.CellContentClick
        Dim montoFactura As Decimal
        Dim idFactura As Integer
        If e.RowIndex = -1 Then
            Exit Sub
        End If
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        Dim rr As New clsReporteFactura

        If Me.grdLecturas.Columns(e.ColumnIndex).Name = "Imprimir" Then
            If Me.grdLecturas.Rows(e.RowIndex).Cells("anulado").Value = True Then
                Exit Sub
            End If

            montoFactura = Me.grdLecturas.Rows(e.RowIndex).Cells("Monto").Value
            idFactura = Me.grdLecturas.Rows(e.RowIndex).Cells("idFactura").Value
            'r.nombreParametro = "filtro"
            ' r.parametro = mdlLetras.Letras(CStr(montoFactura))
            r.reporte = "rptFactura.rpt"
            r.tabla = t.tablaSP("exec sp_imprimeFactura " & idFactura)
            ' r.verReporte()
            r.imprimirReporte("AGUA") 'Se envia como parametro el nombre de la Impresora.
        End If

        If Me.grdLecturas.Columns(e.ColumnIndex).Name = "Rebajar" Then

            If Me.grdLecturas.CurrentRow.Cells("Pagada").Value = True Then
                Exit Sub
            End If

            If Me.grdLecturas.Rows(e.RowIndex).Cells("anulado").Value = True Then
                MsgBox("Este registro esta anulado", MsgBoxStyle.Exclamation, "!!!")
                Exit Sub
            End If

            If Me.grdLecturas.Rows(e.RowIndex).Cells("NoBoleta").Value = "" Or Me.grdLecturas.Rows(e.RowIndex).Cells("NoBoleta").Value = 0 Then
                MsgBox("Debe ingresar un numero de boleta ", MsgBoxStyle.Exclamation, "!!!")
                Me.grdLecturas.Rows(e.RowIndex).Cells("Rebajar").Value = False
                Exit Sub
            End If
            
            If Me.grdLecturas.Rows(e.RowIndex).Cells("NoRecibo").Value = "" Or Me.grdLecturas.Rows(e.RowIndex).Cells("NoRecibo").Value = 0 Then
                MsgBox("Debe ingresar un numero de Recibo ", MsgBoxStyle.Exclamation, "!!!")
                Me.grdLecturas.Rows(e.RowIndex).Cells("Rebajar").Value = False
                Exit Sub
            End If

            If Me.grdLecturas.Rows(e.RowIndex).Cells("Pagada").Value = True Then
                MsgBox("Esta factura ya fue pagada", MsgBoxStyle.Information, "!!!")
                Exit Sub
            End If

            ' If Me.grdLecturas.CurrentRow.Cells("Pagar").Value = True Then
            If MsgBox("Desea registrar como pagada esta factura ", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "???") = MsgBoxResult.No Then
                Exit Sub
            Else
                t.sqlString = "update tblfactura set pagada = 1, Documento = " & Me.grdLecturas.Rows(e.RowIndex).Cells("NoRecibo").Value & ", fechaBoleta = " & mdlPublicVars.fechaSQL(Today) & ", noBoleta = " & Me.grdLecturas.Rows(e.RowIndex).Cells("NoBoleta").Value & " where idFactura = " & Me.grdLecturas.Rows(e.RowIndex).Cells("IdFactura").Value
                t.ejecutaSQL()
                Call llenaGrid()
                Call CheckPaga()
                MsgBox("Proceso terminado con exito ", MsgBoxStyle.Information, "!!!")
            End If

        End If
        ' End If


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

    Private Sub txtCodigoCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoCliente.TextChanged
        Call llenaGridCodigoCliente()
    End Sub
End Class