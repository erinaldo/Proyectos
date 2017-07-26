Public Class frmConvenioLibre
    Private Sub frmFacturaAgrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenaCombos()
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


        Call llenaContador()

    End Sub

    Private Sub llenaContador()
        Dim tbl As New clsDevuelveTabla
        Dim str As String

        Me.txtLectura.Text = 0
        'Llenamos el combo contadores
        str = "select distinct a.idAsignacion,c.numero from tblContador c " _
& "inner join tblAsignacionContador ac " _
& "on ac.idContador = c.idContador " _
& "inner join tblAsignacion a " _
& "on ac.idAsignacion = a.idAsignacion " _
& "inner join tblProyecto p " _
& "on a.idProyecto = p.idProyecto " _
& "where p.idProyecto = " & Me.cmbIdProyecto.SelectedValue

        tbl.sqlString = str
        Me.cmbIdContador.Text = ""
        Me.cmbIdContador.ValueMember = "idAsignacion"
        Me.cmbIdContador.DisplayMember = "numero"
        Me.cmbIdContador.DataSource = tbl.Tabla
    End Sub
#End Region

    Private Sub cmbIdProyecto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIdProyecto.SelectedIndexChanged
        Call llenaContador()
    End Sub



    Private Sub btnAgregarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLectura.Click
        Dim tbl As New clsDevuelveTabla


        If Not IsNumeric(Me.cmbIdContador.SelectedValue) Then
            MsgBox("Debe de seleccionar un Contador valido", MsgBoxStyle.Critical, "!!!")
            Me.cmbIdContador.DroppedDown = True
            Exit Sub
        End If



        If Not IsNumeric(Me.cmbIdProyecto.SelectedValue) Then
            MsgBox("Debe de seleccionar un Proyecto valido", MsgBoxStyle.Critical, "!!!")
            Me.cmbIdProyecto.DroppedDown = True
            Exit Sub
        End If

        If Me.txtLectura.Text = "0" Or Me.txtLectura.Text = "" Or Not IsNumeric(Me.txtLectura.Text) Then
            MsgBox("No existe ningun saldo pendiente para hacer convenio", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        If Me.txtNoPagos.Text = "" Or Me.txtComentario.Text = "" Then
            MsgBox("Debe de ingresar el Numero de pagos y comentario del convenio", MsgBoxStyle.Exclamation, "!!!")
            Exit Sub
        End If
        'Insertamos  la Factura
        tbl.sqlString = "exec sp_insertaConvenioLibre " & Me.cmbIdContador.SelectedValue & "," & fechaSQL(Me.txtFecha.Text) & "," & mdlPublicVars.idUsuario & ",'" & Me.txtComentario.Text & "'," & Me.txtNoPagos.Text & "," & Me.txtLectura.Text
        If tbl.ejecutaSQL = 0 Then
            MsgBox("Ocurrio un error al insertar el convenio", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        Else

        End If
        MsgBox("Convenio grabado satisfatoriamente", MsgBoxStyle.Information, "!!!")
        'regresamos el control al combo contador
        Me.txtLectura.Text = ""
        Me.cmbIdContador.Focus()
        Me.cmbIdContador.DroppedDown = True



    End Sub

    Private Sub cmbIdContador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIdContador.SelectedIndexChanged
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select top 1 totalFacturar " _
        & "from tbllectura " _
        & "where pagado = 0 " _
        & "and idAsignacion = " & Me.cmbIdContador.SelectedValue _
        & " order by idLectura desc"
        If tbl.Tabla.Rows.Count = 0 Then
            Me.txtLectura.Text = 0
        Else
            Me.txtLectura.Text = Nz(tbl.Tabla.Rows(0).Item(0))
            Me.txtLectura.Enabled = True
            Me.txtLectura.Focus()
            Me.txtLectura.BackColor = Color.Aqua
        End If


    End Sub
End Class