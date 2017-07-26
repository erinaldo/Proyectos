Public Class frmCreaFacturacion

    Dim tbl As New clsDevuelveTabla
    Dim f As New clsCreaFactura
    Dim sql As String

    Private Sub frmCreaFacturacion_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdFactura.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            f.codigo = Me.txtIdFactura.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(f.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmCreaFacturacion_grabaRegistro() Handles Me.grabaRegistro
        'If Me.grdDetalle.Rows.Count = 0 Then
        '    MsgBox("Debe de agregar almenos un detalle a la factura ", MsgBoxStyle.Exclamation, "!!!")
        '    Exit Sub
        'End If

        f.fecha = Me.dtpFecha.Value.ToShortDateString
        f.nombre = Me.txtNombre.Text
        f.direccion = Me.txtDireccion.Text
        f.telefono = Me.txtTelefono.Text
        f.noFactura = Me.txtNoFactura.Text
        f.nit = Me.txtnit.text

        If Me.txtIdFactura.Text = "" Then
            f.Crear()

            Call llenaGrid()
            
            MsgBox("Factura Creada exitosamente ", MsgBoxStyle.Information, "!!!")
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub

    Private Sub detalleFactura()
        Dim t As New clsDevuelveTabla
        Dim d As New DataTable

        If Me.txtIdFactura.Text = "" Then
            Exit Sub
        End If

        'sql = "select max(codigo)codigo from tblCreaFactura "
        'd = t.tablaSP(sql)
        'Dim codigo As Integer = d.Rows(0).Item("codigo").ToString

        'Dim i As New DataGridViewRow
        'For Each i In Me.grdDetalle.Rows

        '    t.sqlString = "insert into tblCreaFacturaDetalle (cantidad,descripcion,valor,creaFactura) " _
        '                & " values(" & i.Cells("Cantidad").Value & ",'" _
        '                & i.Cells("Descripcion").Value & "'," _
        '                & i.Cells("Valor").Value & "," & CInt(codigo) & ")"
        '    t.ejecutaSQL()
        'Next i

        Dim dr As DataGridViewRow = Nothing
        For Each dr In Me.grdDetalle.Rows
            'Si codigo es igual a 0 son registros nuevos por lo tanto deja grabar.
            If dr.Cells("codigo").Value = 0 Then
                t.sqlString = "exec sp_grabaDetalleFactura " & dr.Cells("cantidad").Value & ",'" & dr.Cells("descripcion").Value & "'," & dr.Cells("valor").Value & "," & CInt(Me.txtIdFactura.Text)
                t.ejecutaSQL()
            End If

        Next

        Me.txtCantidad.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtValor.Text = ""
        Me.grdDetalle.DataSource = Nothing
        Me.grdDetalle.Rows.Clear()
        MsgBox("Registros creados correctamente ", MsgBoxStyle.Information, "!!!")
        Call llenaDetalle()
    End Sub
    Private Sub frmCreaFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtNombre, "Nombre")
            .Controls.Add(Me.txtDireccion, "Direccion")
            .Controls.Add(Me.txtNoFactura, "NoFactura")

            .SummaryMessage = "Por favor llene los siguientes campos"

        End With

        Me.btnReporte.Visible = True
    End Sub

    Private Sub llenaGrid()

        tbl.sqlString = "select Codigo IdFactura,Fecha,Nombre,Direccion,Nit,Telefono,NoFactura from tblCreaFactura order by codigo desc"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmCreaFacturacion_modificaRegistro() Handles Me.modificaRegistro
        f.nombre = Me.txtNombre.Text
        f.direccion = Me.txtDireccion.Text
        f.telefono = Me.txtTelefono.Text
        f.noFactura = Me.txtNoFactura.Text
        f.fecha = Me.dtpFecha.Value.ToShortDateString
        f.nit = Me.txtNit.Text

        If Me.txtIdFactura.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            f.codigo = Me.txtIdFactura.Text
            MsgBox(f.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmCreaFacturacion_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.grdDetalle.DataSource = Nothing
        Me.grdDetalle.Rows.Clear()
        Me.txtNombre.Focus()
    End Sub


    Private Sub txtIdFactura_TextChanged(sender As Object, e As EventArgs) Handles txtIdFactura.TextChanged
        If Me.txtIdFactura.Text > "" Then
            Me.btnReporte.Visible = True
        Else
            Me.btnReporte.Visible = False
        End If
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        Call llenaDetalle()
    End Sub

    Private Sub llenaDetalle()
        Me.pnlDetalle.Visible = True
        Dim t As New clsDevuelveTabla
        Dim d As New DataTable
        Dim dr As DataGridViewRow = Nothing

        If Me.txtIdFactura.Text = "" Then
            Exit Sub
        Else
            sql = "select codigo,Cantidad,Descripcion,Valor from tblCreaFacturaDetalle where creaFactura = " & CInt(Me.txtIdFactura.Text)
            Me.grdDetalle.DataSource = Nothing
            Me.grdDetalle.Rows.Clear()
            d = t.tablaSP(sql)

            Dim i As Integer = 0
            For i = 0 To d.Rows.Count - 1
                Dim codigo As Integer = d.Rows(i).Item("codigo").ToString
                Dim cantidad As Integer = d.Rows(i).Item("cantidad").ToString
                Dim descripcion As String = d.Rows(i).Item("descripcion").ToString
                Dim valor As Decimal = d.Rows(i).Item("valor").ToString

                Me.grdDetalle.Rows.Add(codigo, cantidad, descripcion, valor)
            Next

            'For Each dr In d.Rows

            '    Dim cantidad As Integer = dr.Cells("cantidad").Value
            '    Dim descripcion As String = dr.Cells("descripcion").Value
            '    Dim valor As Decimal = dr.Cells("valor").Value

            '    Me.grdDetalle.Rows.Add(cantidad, descripcion, valor)

            'Next
            Me.txtCantidad.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call detalleFactura()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.txtCantidad.Text = "" Or Me.txtDescripcion.Text = "" Or Me.txtValor.Text = "" Then
            MsgBox("Falta un campo ", MsgBoxStyle.Exclamation, "!!!")
            Exit Sub
        End If

        If Me.grdDetalle.Rows.Count = 0 Then
            Me.grdDetalle.DataSource = Nothing
            Me.grdDetalle.Rows.Clear()
        End If

        Me.grdDetalle.Rows.Add(0, Me.txtCantidad.Text, Me.txtDescripcion.Text, Me.txtValor.Text)
        Me.txtCantidad.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtValor.Text = ""
        Me.txtCantidad.Focus()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.pnlDetalle.Visible = False
        Me.grdDetalle.DataSource = Nothing
        Me.txtCantidad.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtValor.Text = ""
    End Sub

    Private Sub grdDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdDetalle.CellValueChanged
        Try

            Dim cantidad As Integer = Me.grdDetalle.CurrentRow.Cells("cantidad").Value
            Dim descripcion As String = Me.grdDetalle.CurrentRow.Cells("descripcion").Value
            Dim valor As Decimal = Me.grdDetalle.CurrentRow.Cells("valor").Value
            Dim codigo As Integer = Me.grdDetalle.CurrentRow.Cells("codigo").Value

            sql = "update tblcreaFacturaDetalle set cantidad = " & cantidad & ", descripcion = '" & descripcion & "', valor = " & valor & "" _
                & " where codigo = " & codigo & " and creaFactura = " & CInt(Me.txtIdFactura.Text)
            tbl.tablaSP(sql)


        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MsgBox("Esta seguro de eliminar la fila seleccionada ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                Exit Sub
            End If

            sql = "delete from tblCreaFacturaDetalle where codigo = " & Me.grdDetalle.CurrentRow.Cells("codigo").Value & " and creaFactura = " & CInt(Me.txtIdFactura.Text)
            tbl.tablaSP(sql)

            MsgBox("Fila eliminada correctamente ", MsgBoxStyle.Information, "!!!")

            Me.grdDetalle.DataSource = Nothing
            Me.grdDetalle.Rows.Clear()
            Call llenaDetalle()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        End If

        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If

        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        End If

        If Char.IsPunctuation(e.KeyChar) Then
            If e.KeyChar = "," Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
        'If Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'End If

        'If Char.IsLetter(e.KeyChar) Then
        '    e.Handled = True
        'End If

        'If Char.IsDigit(e.KeyChar) Then
        '    e.Handled = False
        'End If

        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'End If

        'If Char.IsPunctuation(e.KeyChar) Then
        '    e.Handled = False
        'End If

        'If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And Not Char.IsNumber(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
        '    e.Handled = True
        'End If

    End Sub

    Private Sub frmCreaFacturacion_reporte() Handles Me.reporte
        Try
            If MsgBox("Esta seguro de imprimir la factura ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = vbNo Then
                Exit Sub
            End If

            Dim r As New clsReporte
            Dim t As New clsDevuelveTabla
            Dim sql As String = ""

            If Me.chkColinasSantiago.Checked = True Then
                sql = "exec sp_imprimeFacturaNormal " & CInt(Me.txtIdFactura.Text)
                r.tabla = t.tablaSP(sql)
                r.reporte = "rptImprimeFacturaNormalColinaSantiago.rpt"
                r.imprimir("POS")
                ' r.verReporte()
            ElseIf Me.chkAgricolaGardenias.Checked = True Then
                sql = "exec sp_imprimeFacturaNormal " & CInt(Me.txtIdFactura.Text)
                r.tabla = t.tablaSP(sql)
                r.reporte = "rptImprimeFacturaNormalAgricolaGardenias.rpt"
                r.imprimir("POS")
                ' r.verReporte()
            ElseIf Me.chkAgricolaGardenias.Checked = False And Me.chkColinasSantiago.Checked = False Then
                sql = "exec sp_imprimeFacturaNormal " & CInt(Me.txtIdFactura.Text)
                r.tabla = t.tablaSP(sql)
                r.reporte = "rptImprimeFacturaNormal.rpt"
                r.imprimir("POS")
                ' r.verReporte()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkAgricolaGardenias_Click(sender As Object, e As EventArgs) Handles chkAgricolaGardenias.Click
        Me.chkColinasSantiago.Checked = False
    End Sub

    Private Sub chkColinasSantiago_Click(sender As Object, e As EventArgs) Handles chkColinasSantiago.Click
        Me.chkAgricolaGardenias.Checked = False
    End Sub
End Class
