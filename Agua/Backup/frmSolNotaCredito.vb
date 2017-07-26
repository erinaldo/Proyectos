Public Class frmSolNotaCredito
    Private Sub frmLecturaAgrega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'Llenamos el combo contadores
        str = "select distinct a.idAsignacion,ct.numero + ' (' + cl.nombre + ')' numero " _
& "from tblAsignacion a " _
& "inner join tblAsignacionContador ac " _
& "on a.idAsignacion = ac.idAsignacion " _
& "inner join tblContador ct " _
& "on ct.idContador = ac.idContador " _
& "inner join tblProyecto p " _
& "on a.idProyecto = p.idProyecto " _
& "inner join tblCliente cl " _
& "on a.idCliente = cl.idCliente " _
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



    Private Sub btnAgregarLectura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLectura.Click
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

        If Me.cmbTipo.Text = "" Then
            MsgBox("Debe de seleccionar un rubro", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

        'Insertamos  la lectura
        tbl.sqlString = "exec sp_insertaSolNotaCredito " & fechaSQL(Me.txtFecha.Text) & "," & Me.cmbIdContador.SelectedValue & "," & mdlPublicVars.idUsuario & "," & Me.txtLectura.Text & ",'" & Me.txtObservacion.Text & "'," & Me.cmbTipo.SelectedIndex + 1
        If tbl.ejecutaSQL = 0 Then
            MsgBox("Ocurrio un error al insertar la solicitud", MsgBoxStyle.Critical, "!!!")
        End If
        MsgBox("Nota Solicitud de credito ingresada satisfactoriamente", MsgBoxStyle.Exclamation, "!!!")
        'regresamos el control al combo contador
        Me.txtLectura.Text = ""
        Me.cmbIdContador.Focus()
        Me.cmbIdContador.DroppedDown = True
        Me.txtObservacion.Text = ""



    End Sub
End Class