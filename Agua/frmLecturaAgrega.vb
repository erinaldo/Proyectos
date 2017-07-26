Imports System
Imports System.Text.RegularExpressions

Public Class frmLecturaAgrega

    Private Sub frmLecturaAgrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenaCombos()

    End Sub

    Private Sub bloqueaColumnas()
        Dim col As New DataGridViewColumn
        For Each col In Me.grdLecturas.Columns
            If col.Index > 2 Then
                col.ReadOnly = True
                col.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub
#Region "Llena combos"
    Private Sub llenaCombos()
        Dim tbl As New clsDevuelveTabla
        Dim str As String
        'Llenamos el combo proyecto
        str = "select idProyecto,nombre from tblproyecto"
        tbl.sqlString = str

        Me.cmbIdProyecto.ValueMember = "idProyecto"
        Me.cmbIdProyecto.DisplayMember = "nombre"
        Me.cmbIdProyecto.DataSource = tbl.Tabla

        'Llenamos el combo empleado
        str = "select idEmpleado,nombre from tblEmpleado"
        tbl.sqlString = str

        Me.cmbIdEmpleado.ValueMember = "idEmpleado"
        Me.cmbIdEmpleado.DisplayMember = "nombre"
        Me.cmbIdEmpleado.DataSource = tbl.Tabla


    End Sub


#End Region
    Private Sub btnAgregarLectura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLectura.Click
        Call Agregar()
    End Sub
    Private Sub Agregar()
        Dim tbl As New clsDevuelveTabla
        Dim tblEjecuta As New clsDevuelveTabla
        Dim sql As String
        Dim lecturaAnterior As String
        Dim d As New DataTable

        Dim dr As DataGridViewRow = Nothing
        Dim drEjecuta As System.Data.DataRow
        If Me.grdLecturas.Rows.Count = 0 Then
            MsgBox("No existen datos de lectura", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        'For Each dr In Me.grdLecturas.Rows
        '    If Not IsNumeric(dr.Cells(0).Value) Then
        '        MsgBox("Existen valores no Numericos en lecturas", MsgBoxStyle.Critical, "!!!")
        '        Exit Sub
        '    End If
        'Next

        For Each dr In Me.grdLecturas.Rows
            If ((dr.Cells("Lectura").Value) > "" Or (dr.Cells("Lectura").Value) > 0) And ((dr.Cells("NoFactura").Value) > "" Or (dr.Cells("NoFactura").Value > 0)) Then

                'eliminamos registros del proceso actual
                Dim idProceso As String
                idProceso = Me.cmbIdProyecto.SelectedValue & Year(Today()).ToString & Month(Today()).ToString & Today().Day.ToString
                tbl.sqlString = "delete from tmpLectura where idProceso = " & idProceso
                tbl.ejecutaSQL()

                If llenaTablaTemporal() = False Then
                    Exit Sub
                End If

                Dim strError As String = ""
                tblEjecuta.sqlString = "exec sp_lecturasResumidas " & idProceso


                For Each drEjecuta In tblEjecuta.tablaSP(tblEjecuta.sqlString).Rows
                    'Insertamos  la lectura
                    tbl.sqlString = "exec sp_InsertaLectura " & Me.grdLecturas.CurrentRow.Cells("Id").Value & "," & drEjecuta.Item(2) & "," & fechaSQL(Me.txtFecha.Text) & "," & Me.cmbIdEmpleado.SelectedValue & "," & mdlPublicVars.idUsuario & "," & drEjecuta.Item(0) & "," & fechaSQL(Me.txtConsumo.Text) & "," & Me.grdLecturas.CurrentRow.Cells("Id2").Value
                    If tbl.ejecutaSQL = 0 Then
                        strError = strError & dr.Cells("Contador").Value & Chr(13)
                    End If

                    sql = "select top 1 isnull(lecturaActual,0)l from tblLectura where idAsignacion = " & Me.grdLecturas.CurrentRow.Cells("Id").Value & " order by idLectura desc "
                    d = tbl.tablaSP(sql)
                    Dim ultimaLectura As String = d.Rows(0).Item("l").ToString
                    If ultimaLectura < Me.grdLecturas.CurrentRow.Cells("Lectura").Value Then
                        Exit Sub
                    End If

                Next

                If strError <> "" Then
                    MsgBox(strError, MsgBoxStyle.Critical, "Se encontraron los errores siguientes")
                End If

            End If
        Next

        Call facturacion()

            ' MsgBox("Proceso terminado", MsgBoxStyle.Information, "!!!")

    End Sub

    Private Function llenaTablaTemporal() As Boolean
        Dim tbl As New clsDevuelveTabla
        Dim dr As DataGridViewRow


        Dim strError As String = ""
        For Each dr In Me.grdLecturas.Rows
            Dim lectura As String
            lectura = dr.Cells("Lectura").Value
            'Insertamos  la lectura
            If lectura > "" Or lectura > 0 Then
                tbl.sqlString = "exec sp_tmpLecturaLLenado " & dr.Cells("Id").Value & "," & dr.Cells("Id2").Value & "," & dr.Cells("Lectura").Value & "," & Me.cmbIdProyecto.SelectedValue
                If tbl.ejecutaSQL = 0 Then
                    strError = strError & dr.Cells("Contador").Value & Chr(13)
                End If
            End If
        Next
        If strError <> "" Then
            MsgBox(strError, MsgBoxStyle.Critical, "Se encontraron los errores siguientes")
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Call llenaGrid()
    End Sub
    Private Sub llenaGrid()
        Dim tbl As New clsDevuelveTabla

        If Not IsNumeric(Me.cmbIdEmpleado.SelectedValue) Then
            MsgBox("Debe de seleccionar un Empleado valido", MsgBoxStyle.Critical, "!!!")
            Me.cmbIdEmpleado.DroppedDown = True
            Exit Sub
        End If

        If Not IsNumeric(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un Proyecto valido", MsgBoxStyle.Critical, "!!!")
            Me.cmbIdProyecto.DroppedDown = True
            Exit Sub
        End If

        Me.grdLecturas.DataSource = tbl.tablaSP("exec sp_capturaLectura " & Me.cmbIdProyecto.SelectedValue)
        Call bloqueaColumnas()
    End Sub

    Private Sub txtCodigoCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoCliente.TextChanged
        Dim tbl As New clsDevuelveTabla

        Me.grdLecturas.DataSource = tbl.tablaSP("exec sp_capturaLecturaCodigoCliente " & Me.cmbIdProyecto.SelectedValue & ",'" & Me.txtCodigoCliente.Text & "'")
        Call bloqueaColumnas()
    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        frmFactura.Text = "Captura de factura"
        frmFactura.MdiParent = MDIPrincipal
        frmFactura.WindowState = FormWindowState.Maximized
        frmFactura.Show()
    End Sub

    Private Sub grdLecturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLecturas.CellContentClick
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte

        If e.RowIndex = -1 Then
            Exit Sub
        End If

        If Me.grdLecturas.Columns(e.ColumnIndex).Name = "Facturar" Then
            'If Me.grdLecturas.Rows(e.RowIndex).Cells("anulado").Value = True Then
            '    Exit Sub
            'End If
            If Me.grdLecturas.CurrentRow.Cells("Lectura").Value = "" Then
                MsgBox("Debe ingresar lectura ", MsgBoxStyle.Exclamation, "!!!")
                Exit Sub
            End If

            If Me.grdLecturas.CurrentRow.Cells("NoFactura").Value = "" Then
                MsgBox("Debe ingresar un numero de Factura ", MsgBoxStyle.Exclamation, "!!!")
                Exit Sub
            End If

            Call Agregar()
            
        End If
    End Sub
    Private Sub facturacion()
        Dim tbl As New clsDevuelveTabla
        Dim t As New System.Data.DataTable
        Dim noFactura As String

        If Not IsNumeric(Me.cmbIdEmpleado.SelectedValue) Then
            MsgBox("Debe de seleccionar un Empleado valido", MsgBoxStyle.Critical, "!!!")
            Me.cmbIdEmpleado.DroppedDown = True
            Exit Sub
        End If

        If Not IsNumeric(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un Proyecto valido", MsgBoxStyle.Critical, "!!!")
            Me.cmbIdProyecto.DroppedDown = True
            Exit Sub
        End If

        Dim i As Integer = 0
        Dim lectura As String
        
        For i = 0 To Me.grdLecturas.Rows.Count - 1
            lectura = Me.grdLecturas.Rows(i).Cells("Lectura").Value
            noFactura = Me.grdLecturas.Rows(i).Cells("NoFactura").Value
            lectura = IIf(IsDBNull(lectura), 0, lectura)
            noFactura = IIf(IsDBNull(noFactura), 0, noFactura)


            If (lectura > "" Or lectura > 0) And (noFactura > "" Or noFactura > 0) Then

                'Insertamos  la Factura
                tbl.sqlString = "exec sp_InsertaFactura " & Me.grdLecturas.Rows(i).Cells("Id").Value & "," & fechaSQL(Me.txtFecha.Text) & "," & mdlPublicVars.idUsuario & "," & Me.cmbIdProyecto.SelectedValue & "," & Me.cmbIdEmpleado.SelectedValue & "," & fechaSQL(Me.txtFecha.Text) & ",'" & 0 & "','" & 0 & "'," & Me.grdLecturas.Rows(i).Cells("Id2").Value & "," & noFactura

                If Not IsDBNull(lectura) Then
                    If tbl.ejecutaSQL = 0 Then
                        MsgBox("Ocurrio un error al insertar la Factura", MsgBoxStyle.Critical, "!!!")
                    Else
                        MsgBox("Factura grabada satisfactoriamente", MsgBoxStyle.Information, "!!!")

                        'Imprimimos el Reporte
                        Dim r As New clsReporte
                        Dim montoFactura = 0
                        Dim idFactura As Integer

                        tbl.sqlString = "select MAX(idFactura)idFactura from tblfactura "
                        t = tbl.Tabla
                        If t.Rows.Count = 0 Then
                            idFactura = 0
                        Else
                            idFactura = t.Rows(0).Item(0)
                        End If

                        If MsgBox("Desea imprimir la factura ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "!!!") = MsgBoxResult.Yes Then
                            'r.nombreParametro = "filtro"
                            'r.parametro = mdlLetras.Letras(CStr(montoFactura))
                            r.reporte = "rptFactura.rpt"
                            r.tabla = tbl.tablaSP("exec sp_imprimeFactura " & idFactura)
                            ' r.verReporte()
                            r.imprimirReporte("AGUA")
                        End If

                    End If
                End If

            End If
        Next
        Call llenaGrid()
    End Sub
End Class