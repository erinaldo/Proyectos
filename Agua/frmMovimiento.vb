Public Class frmMovimiento

    Private Sub frmMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call llenaCombos()
    End Sub

    Private Sub llenaCombos()
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select idtipoMovimiento Id,nombre Nombre from tbltipomovimiento"

        Me.cmbIdtTipoMovimiento.DataSource = tbl.Tabla
        Me.cmbIdtTipoMovimiento.ValueMember = "Id"
        Me.cmbIdtTipoMovimiento.DisplayMember = "Nombre"

        tbl.sqlString = "select idProducto Id,nombre Nombre from tblProducto"
        Me.cmbIdProducto.DataSource = tbl.Tabla
        Me.cmbIdProducto.ValueMember = "Id"
        Me.cmbIdProducto.DisplayMember = "Nombre"

        tbl.sqlString = "select idProyecto Id,nombre Nombre from tblProyecto"
        Me.cmbIdProyecto.DataSource = tbl.Tabla
        Me.cmbIdProyecto.ValueMember = "Id"
        Me.cmbIdProyecto.DisplayMember = "Nombre"


    End Sub

    Private Sub llenaAsignacion(ByVal idProyecto As Integer)
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select a.idAsignacion Id," _
& "c.nombre + '  ' + CASE WHEN a.manzana = '0' THEN 'L ' + convert(varchar(5),a.lote ) " _
& " ELSE 'L ' + convert(varchar(5),a.lote) + ' - ' + 'Mz ' + a.manzana " _
& " END AS Nombre " _
& " from tblAsignacion a " _
& " inner join tblCliente c " _
& " on a.idCliente = c.idCliente where a.idProyecto =  " & idProyecto _
& " order by a.Direccion asc"

        Me.cmbIdAsignacion.DataSource = tbl.Tabla
        Me.cmbIdAsignacion.ValueMember = "Id"
        Me.cmbIdAsignacion.DisplayMember = "Nombre"


    End Sub



    Private Sub cmbIdProyecto_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIdProyecto.SelectedValueChanged
        Try
            Call llenaAsignacion(Me.cmbIdProyecto.SelectedValue)
        Catch
        End Try
    End Sub

    Private Sub cmbIdtTipoMovimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIdtTipoMovimiento.SelectedIndexChanged

    End Sub

    Private Sub Facturar()
        Dim tipo As New clsTipoMovimiento

    End Sub

    Private Sub cmbIdProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIdProducto.SelectedIndexChanged
        Dim tbl As New clsDevuelveTabla
        Try
            tbl.sqlString = "select precio from tblProducto where idproducto = " & Me.cmbIdProducto.SelectedValue
            Me.txtPrecio.Text = tbl.Tabla.Rows(0).Item(0).ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim mov As New clsMovimiento
        Try
            mov.fecha = Me.txtFecha.Text
            mov.idProducto = Me.cmbIdProducto.SelectedValue
            mov.idUsuario = mdlPublicVars.idUsuario
            mov.observacion = Me.txtObservacion.Text
            mov.precio = Me.txtPrecio.Text
            mov.idAsignacion = Me.cmbIdAsignacion.SelectedValue
            MsgBox(mov.Crear, MsgBoxStyle.Information, "!!!")
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class