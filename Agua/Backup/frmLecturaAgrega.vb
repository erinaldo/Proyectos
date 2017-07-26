Public Class frmLecturaAgrega

    Private Sub frmLecturaAgrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenaCombos()

    End Sub

    Private Sub bloqueaColumnas()
        Dim col As New DataGridViewColumn
        For Each col In Me.grdLecturas.Columns
            If col.Index > 0 Then
                col.ReadOnly = True
                col.DefaultCellStyle.BackColor = Color.Gray
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
        Dim tbl As New clsDevuelveTabla
        Dim tblEjecuta As New clsDevuelveTabla

        Dim dr As DataGridViewRow = Nothing
        Dim drEjecuta As System.Data.DataRow
        If Me.grdLecturas.Rows.Count = 0 Then
            MsgBox("No existen datos de lectura", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        For Each dr In Me.grdLecturas.Rows
            If Not IsNumeric(dr.Cells(0).Value) Then
                MsgBox("Existen valores no Numericos en lecturas", MsgBoxStyle.Critical, "!!!")
                Exit Sub
            End If
        Next
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
            tbl.sqlString = "exec sp_InsertaLectura " & drEjecuta.Item(1) & "," & drEjecuta.Item(2) & "," & fechaSQL(Me.txtFecha.Text) & "," & Me.cmbIdEmpleado.SelectedValue & "," & mdlPublicVars.idUsuario & "," & drEjecuta.Item(0) & "," & fechaSQL(Me.txtConsumo.Text)
            If tbl.ejecutaSQL = 0 Then
                strError = strError & dr.Cells("Contador").Value & Chr(13)
            End If
        Next
        If strError <> "" Then
            MsgBox(strError, MsgBoxStyle.Critical, "Se encontraron los errores siguientes")
        End If

        MsgBox("Proceso terminado", MsgBoxStyle.Information, "!!!")
        Me.grdLecturas.DataSource = ""

    End Sub

    Private Function llenaTablaTemporal() As Boolean
        Dim tbl As New clsDevuelveTabla
        Dim dr As DataGridViewRow


        Dim strError As String = ""
        For Each dr In Me.grdLecturas.Rows
            'Insertamos  la lectura
            tbl.sqlString = "exec sp_tmpLecturaLLenado " & dr.Cells(1).Value & "," & dr.Cells(2).Value & "," & dr.Cells(0).Value & "," & Me.cmbIdProyecto.SelectedValue
            If tbl.ejecutaSQL = 0 Then
                strError = strError & dr.Cells("Contador").Value & Chr(13)
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
End Class