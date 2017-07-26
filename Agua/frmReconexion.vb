Public Class frmReconexion

    Dim tbl As New clsDevuelveTabla
    Dim Reconexion As New clsReconexion

    Private Sub llenaGrid()

        '        tbl.sqlString = "select " _
        '& "r.idReconexion IdReconexion,r.fecha Fecha,r.idusuario IdUsuario," _
        '& "r.idContador IdContador,r.idLectura IdLectura,r.monto Monto,r.observacion Observacion," _
        '& "c.numero Numero,u.nombre Nombre from tblReconexion r " _
        '& "inner join tblContador c on r.idContador = c.idContador " _
        '& "inner join tblUsuarios u on r.idUsuario = u.idUsuario " _
        '& "order by r.idReconexion desc"
        tbl.sqlString = "select r.idReconexion IdReconexion,r.Fecha,r.Monto,r.Observacion,r.Usuario from tblReconexion r order by r.idReconexion desc "

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmReconexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtIdContador, "contador")
            .Controls.Add(Me.txtMonto, "Monto")
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
        Reconexion.monto = Me.txtMonto.Text
        Reconexion.observacion = Me.txtObservacion.Text
        Reconexion.usuario = mdlPublicVars.usuario
        Reconexion.idAsignacionContador = Me.txtIdContador.Text

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
        Reconexion.idAsignacionContador = Me.txtIdContador.Text
        Reconexion.monto = Me.txtMonto.Text
        Reconexion.observacion = Me.txtObservacion.Text
        Reconexion.usuario = Me.txtUsuario.Text

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
        frmSuperSearch.sqlString = "select idAsignacionContador,numero +' - '+ cl.nombre numero from tblasignacionContador ac " _
                                & " inner join tblContador c on ac.idContador = c.idContador inner join tblAsignacion a on ac.idAsignacion = a.idAsignacion " _
                                & " inner join tblCliente cl on a.idCliente = cl.idCliente "

        frmSuperSearch.nombre = "numero"
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
        Try
            Dim sql As String = ""
            Dim t As New clsDevuelveTabla
            Dim r As New clsReporte
            Dim idReconexion As Integer = Me.txtIdReconexion.Text

            If MsgBox("Desea imprimir la factura ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "!!!") = MsgBoxResult.Yes Then
                sql = "exec sp_imprimeReconexion " & idReconexion
                r.tabla = tbl.tablaSP(sql)
                r.reporte = "rptImprimeReconexion.rpt"
                r.imprimirReporte("AGUA")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        If Me.txtMonto.Text = "" Then
            Me.txtMonto.BackColor = Color.Aqua
        ElseIf Me.txtMonto.Text > "" Then
            Me.txtMonto.BackColor = Color.White
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim sql As String
            Dim t As New clsDevuelveTabla
            Dim r As New clsReporte
            Dim idReconexion As Integer = 0

            If MsgBox("Desea imprimir la factura ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "!!!") = MsgBoxResult.Yes Then
                r.reporte = "rptFactura.rpt"
                r.tabla = tbl.tablaSP("exec sp_imprimeFactura " & idReconexion)
                r.imprimirReporte("AGUA")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtIdReconexion_TextChanged(sender As Object, e As System.EventArgs) Handles txtIdReconexion.TextChanged
        If Me.txtIdReconexion.Text = "" Then
            Me.btnReporte.Visible = False
            Exit Sub
        Else
            Me.btnReporte.Visible = True
        End If
    End Sub
End Class
