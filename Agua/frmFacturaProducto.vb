Public Class frmFacturaProducto
    Dim diasPago As Integer
    Dim fechaSinMora As Date

    Private Sub frmFacturaAgrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenaCombos()
        Call llenaContador()
    End Sub

  
    '#Region "Llena combos"
    Private Sub llenaCombos()
        Dim tbl As New clsDevuelveTabla
        Dim str As String
        'Llenamos el combo proyecto
        str = "select idProyecto,nombre from tblproyecto"
        tbl.sqlString = str

        Me.cmbIdProyecto.DataSource = Nothing
        Me.cmbIdProyecto.ValueMember = "idProyecto"
        Me.cmbIdProyecto.DisplayMember = "nombre"
        Me.cmbIdProyecto.DataSource = tbl.Tabla

        'Llenamos el combo empleado
        str = "select idEmpleado,nombre from tblEmpleado"
        tbl.sqlString = str

        Me.cmbIdEmpleado.DataSource = Nothing
        Me.cmbIdEmpleado.ValueMember = "idEmpleado"
        Me.cmbIdEmpleado.DisplayMember = "nombre"
        Me.cmbIdEmpleado.DataSource = tbl.Tabla

    End Sub

    Private Sub llenaContador()
        Dim tbl As New clsDevuelveTabla
        Dim str As String

        Me.txtLectura.Text = 0
        'Llenamos el combo contadores
        str = "select distinct a.idAsignacion,c.numero + '   ('+ cl.nombre + ')'  numero from tblContador c " _
            & "inner join tblAsignacionContador ac " _
            & "on c.idContador = ac.idContador " _
            & "inner join tblAsignacion a " _
            & "on ac.idAsignacion = a.idAsignacion " _
            & "inner join tblProyecto p " _
            & "on a.idProyecto = p.idProyecto " _
            & "inner join tblCliente cl " _
            & "on a.idCliente = cl.idCliente " _
            & "where p.idProyecto = " & Me.cmbIdProyecto.SelectedValue

        tbl.sqlString = str
        Me.cmbIdContador.DataSource = Nothing
        Me.cmbIdContador.ValueMember = "idAsignacion"
        Me.cmbIdContador.DisplayMember = "numero"
        Me.cmbIdContador.DataSource = tbl.Tabla

    End Sub
    '#End Region

    Private Sub cmbIdProyecto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIdProyecto.SelectedIndexChanged
        Call llenaContador()
    End Sub

    Private Sub btnAgregarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLectura.Click
        Dim tbl As New clsDevuelveTabla
        If Me.txtNoBoleta.Text = "" Then
            MsgBox("Por favor ingrese un numero de boleta", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        If Not IsNumeric(Me.cmbIdContador.SelectedValue) Then
            MsgBox("Debe de seleccionar un Contador valido", MsgBoxStyle.Critical, "!!!")
            Me.cmbIdContador.DroppedDown = True
            Exit Sub
        End If

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

        If Me.txtLectura.Text = "0" Then
            MsgBox("No existe monto pendiente para facturar", MsgBoxStyle.Exclamation, "!!!")
            Exit Sub
        End If
        'Insertamos  la Factura
        tbl.sqlString = "exec sp_InsertaFacturaProducto " & Me.cmbIdContador.SelectedValue & "," & fechaSQL(Me.txtFecha.Text) & "," & mdlPublicVars.idUsuario & "," & Me.cmbIdProyecto.SelectedValue & "," & Me.cmbIdEmpleado.SelectedValue & "," & fechaSQL(Me.txtFechaBoleta.Text) & ",'" & Me.txtNoBoleta.Text & "','" & Me.txtNoFactura.Text & "'"
        If tbl.ejecutaSQL = 0 Then
            MsgBox("Ocurrio un error al insertar la Factura", MsgBoxStyle.Critical, "!!!")
        Else
            MsgBox("Factura grabada satisfactoriamente", MsgBoxStyle.Exclamation, "!!!")
            'regresamos el control al combo contador
            Me.txtLectura.Text = ""
            Me.cmbIdContador.Focus()
            Me.cmbIdContador.DroppedDown = True
            If CDate(Me.txtFechaBoleta.Text) > fechaSinMora Then
                MsgBox("Pago realizado fuera del rango permitido," & Chr(13) & "se cargara MORA en su proxima lectura", MsgBoxStyle.Critical, "!!!")
            End If
        End If

    End Sub


    Private Sub corrDocumento()
        Dim t As New System.Data.DataTable
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select serieFactura + convert(varchar(10),corrFactura) documento from tblconfiguracion"
        t = tbl.Tabla
        If t.Rows.Count = 0 Then
            Me.txtNoFactura.Text = ""
        Else
            Me.txtNoFactura.Text = t.Rows(0).Item(0)
        End If

    End Sub

    Private Sub cliente()
        Dim t As New System.Data.DataTable
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select distinct c.nombre from " _
        & "tblCliente c " _
        & "inner join tblAsignacion a " _
        & "on c.idCliente = a.idCliente " _
        & "inner join tblAsignacionContador ac " _
        & "on a.idAsignacion = ac.idAsignacion " _
        & " where a.idAsignacion = " & Me.cmbIdContador.SelectedValue
        t = tbl.Tabla
        If t.Rows.Count = 0 Then
            Me.txtNoFactura.Text = ""
        Else
            Me.txtCliente.Text = t.Rows(0).Item(0)
        End If

    End Sub

    Private Sub productos()
        'Dim t As New System.Data.DataTable
        'Dim tbl As New clsDevuelveTabla
        'tbl.sqlString = "select isnull(sum(precio),0) from " _
        '& "tblMovimiento where idAsignacion =  " & Me.cmbIdContador.SelectedValue

        't = tbl.Tabla
        'If t.Rows.Count = 0 Then
        '    Me.txtLectura.Text = ""
        'Else
        '    Me.txtLectura.Text = t.Rows(0).Item(0)
        'End If
    End Sub

    Private Sub cmbIdContador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdContador.SelectedIndexChanged
        Call corrDocumento()
        Call cliente()
        Call productos()
    End Sub

End Class