Public Class frmOtro
    Dim tbl As New clsDevuelveTabla
    Dim otro As New clsOtro

    Private Sub llenaGrid()

        tbl.sqlString = "select distinct o.idOtro IdOtro,o.fecha Fecha,u.nombre Usuario,o.monto Monto,o.observacion Observacion, " _
& "o.idAsignacion IdAsignacion,cl.nombre Asignacion " _
& "from tblOtro o " _
& "inner join tblUsuarios u " _
& "on o.idUsuario = u.idUsuario " _
& "inner join tblAsignacion a " _
& "on o.idAsignacion = a.idAsignacion " _
& "inner join tblAsignacionContador ac " _
& "on a.idAsignacion = ac.idAsignacion " _
& "inner join tblContador c  " _
& "on ac.idContador = c.idContador " _
& "inner join tblCliente cl " _
& "on a.idCliente = cl.idCliente "

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmReconexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtIdAsignacion, "Asignacion")
            .Controls.Add(Me.txtMonto, "Monto")
            .Controls.Add(Me.txtObservacion, "Observacion")
            .Controls.Add(Me.txtFecha, "Fecha")
            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmReconexion_eliminaRegistro() Handles Me.eliminaRegistro
        MsgBox("Opcion no disponible, debe de utilizar una nota de credito", MsgBoxStyle.Critical, "!!!")
        'If Me.txtIdOtro.Text = "" Then
        '    MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        'Else
        '    otro.idOtro = Me.txtIdOtro.Text
        '    If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        '    MsgBox(otro.Borrar, MsgBoxStyle.Critical, "!!!")
        '    Call llenaGrid()
        'End If
    End Sub

    Private Sub frmReconexion_grabaRegistro() Handles Me.grabaRegistro
        otro.fecha = Me.txtFecha.Text
        otro.idAsignacion = Me.txtIdAsignacion.Text
        otro.monto = Me.txtMonto.Text
        otro.observacion = Me.txtObservacion.Text
        otro.idUsuario = mdlPublicVars.idUsuario

        If Me.txtIdOtro.Text = "" Then
            MsgBox(otro.Crear, MsgBoxStyle.Information, "!!!")
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
        otro.fecha = Me.txtFecha.Text
        otro.idAsignacion = Me.txtIdAsignacion.Text
        otro.monto = Me.txtMonto.Text
        otro.observacion = Me.txtObservacion.Text
        otro.idUsuario = mdlPublicVars.idUsuario
        If Me.txtIdOtro.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            otro.idOtro = Me.txtIdOtro.Text
            MsgBox(otro.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    



    Private Sub txtIdAsignacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdAsignacion.LostFocus
        Dim str As String
        str = "select distinct a.idAsignacion IdAsignacion,o.numero  + ' ' +  cl.nombre Asignacion " _
& "from tblasignacion a " _
& "inner join tblasignacionContador ac " _
& "on a.idAsignacion = ac.idAsignacion " _
& "inner join tblcontador o " _
& "on ac.idContador = o.idContador " _
& "inner join tblCliente cl " _
& "on a.idCliente = cl.idCliente " _
& "where o.anulado = 0 and a.idAsignacion = " & Me.txtIdAsignacion.Text

        If Not IsNumeric(Me.txtIdAsignacion.Text) And Me.txtIdAsignacion.Text <> "" Then
            Me.txtIdAsignacion.Text = ""
            Me.txtIdAsignacion.Focus()
            Exit Sub
        End If
        If Me.txtIdAsignacion.Text <> "" Then
            If mdlPublicVars.RevisaCampoSQL(str, "Asignacion") = False Then
                MsgBox("Contador no valido !!!", MsgBoxStyle.Critical, "!!!")
                Me.txtIdAsignacion.Text = ""
                Me.txtAsignacion.Text = ""
                Me.txtIdAsignacion.Focus()
            Else
                Me.txtAsignacion.Text = mdlPublicVars.superSearchNombre
            End If
        End If
    End Sub



    Private Sub txtIdAsignacion_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtIdAsignacion.MouseDoubleClick
        frmSuperSearch.sqlString = "select a.idAsignacion IdAsignacion,o.numero  + ' ' +  cl.nombre Asignacion " _
& "from tblasignacion a " _
& "inner join tblasignacionContador ac " _
& "on a.idAsignacion = ac.idAsignacion " _
& "inner join tblcontador o " _
& "on ac.idContador = o.idContador " _
& "inner join tblCliente cl " _
& "on a.idCliente = cl.idCliente " _
& "where o.anulado = 0"

        frmSuperSearch.nombre = "Asignacion"
        frmSuperSearch.Text = "Contador Otro"

        frmSuperSearch.ShowDialog()
        If mdlPublicVars.superSearchId = 0 Then
            Exit Sub
        Else
            Me.txtIdAsignacion.Text = mdlPublicVars.superSearchId
            Me.txtAsignacion.Text = mdlPublicVars.superSearchNombre
        End If
    End Sub



    Private Sub frmOtro_reporte() Handles Me.reporte
        frmListadoOtros.Text = "Reporte de otros cargos"
        frmListadoOtros.MdiParent = MDIPrincipal
        Permiso.PermisoSimple(frmListadoOtros)
    End Sub


End Class
