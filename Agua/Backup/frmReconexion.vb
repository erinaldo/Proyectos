Public Class frmReconexion

    Dim tbl As New clsDevuelveTabla
    Dim Reconexion As New clsReconexion

    Private Sub llenaGrid()

        tbl.sqlString = "select " _
& "r.idReconexion IdReconexion,r.fecha Fecha,r.idusuario IdUsuario," _
& "r.idContador IdContador,r.idLectura IdLectura,r.monto Monto,r.observacion Observacion," _
& "c.numero Numero,u.nombre Nombre from tblReconexion r " _
& "inner join tblContador c on r.idContador = c.idContador " _
& "inner join tblUsuarios u on r.idUsuario = u.idUsuario " _
& "order by r.idReconexion desc"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmReconexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtIdContador, "contador")
            .Controls.Add(Me.txtMonto, "Monto")
            .Controls.Add(Me.txtObservacion, "Observacion")
            .Controls.Add(Me.txtFecha, "Fecha")
            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmReconexion_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdReconexion.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            Reconexion.idReconexion = Me.txtIdReconexion.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(Reconexion.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmReconexion_grabaRegistro() Handles Me.grabaRegistro
        Reconexion.fecha = Me.txtFecha.Text
        Reconexion.idContador = Me.txtIdContador.Text
        Reconexion.monto = Me.txtMonto.Text
        Reconexion.observacion = Me.txtObservacion.Text
        Reconexion.idUsuario = mdlPublicVars.idUsuario

        If Me.txtIdReconexion.Text = "" Then
            MsgBox(Reconexion.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub

    Private Sub frmReconexion_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtMonto.Text = 0
        Me.txtFecha.Text = Today
        Me.txtFecha.Focus()


    End Sub



    Private Sub frmReconexion_modificaRegistro() Handles Me.modificaRegistro
        Reconexion.fecha = Me.txtFecha.Text
        Reconexion.idContador = Me.txtIdContador.Text
        Reconexion.monto = Me.txtMonto.Text
        Reconexion.observacion = Me.txtObservacion.Text
        Reconexion.idUsuario = Me.txtUsuario.Text
        If Me.txtIdReconexion.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            Reconexion.idReconexion = Me.txtIdReconexion.Text
            MsgBox(Reconexion.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    

   

    Private Sub txtIdContador_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdContador.LostFocus
        If Not IsNumeric(Me.txtIdContador.Text) And Me.txtIdContador.Text <> "" Then
            Me.txtIdContador.Text = ""
            Me.txtIdContador.Focus()
            Exit Sub
        End If
        If Me.txtIdContador.Text <> "" Then
            If mdlPublicVars.RevisaCampo("tblContador", "IdContador", "numero", Me.txtIdContador.Text) = False Then
                MsgBox("Contador no valido !!!", MsgBoxStyle.Critical, "!!!")
                Me.txtIdContador.Text = ""
                Me.txtContador.Text = ""
                Me.txtIdContador.Focus()
            Else
                Me.txtContador.Text = mdlPublicVars.superSearchNombre
            End If
        End If
    End Sub



    Private Sub txtIdContador_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtIdContador.MouseDoubleClick
        frmSuperSearch.sqlString = "select IdContador,numero from tblContador"
        frmSuperSearch.nombre = "nombre"
        frmSuperSearch.Text = "Contador Actividad"

        frmSuperSearch.ShowDialog()
        If mdlPublicVars.superSearchId = 0 Then
            Exit Sub
        Else
            Me.txtIdContador.Text = mdlPublicVars.superSearchId
            Me.txtContador.Text = mdlPublicVars.superSearchNombre
        End If
    End Sub

    Private Sub frmReconexion_reporte() Handles Me.reporte
        frmListadoReconexion.Text = "Listado de reconexion"
        frmListadoReconexion.MdiParent = Me
        Permiso.PermisoSimple(frmListadoReconexion)

    End Sub
End Class
