Public Class frmContador


    Dim tbl As New clsDevuelveTabla
    Dim contador As New clsContador

    Private Sub llenaGrid()

        tbl.sqlString = "select idContador IdContador," _
    & "fecha Fecha,numero Numero,disponible Disponible," _
& "bloqueado Bloqueado,anulado Anulado,Observacion Observacion " _
        & "from tblContador"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmcontador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtFecha, "Fecha")
            .Controls.Add(Me.txtNumero, "Numero")
            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmcontador_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdContador.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            contador.idcontador = Me.txtIdcontador.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(contador.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmcontador_grabaRegistro() Handles Me.grabaRegistro
        contador.fecha = Today()
        contador.numero = Me.txtNumero.Text
        contador.disponible = Me.chkDisponible.Checked
        contador.bloqueado = Me.chkBloqueado.Checked
        contador.anulado = Me.chkAnulado.Checked
        contador.observacion = Me.txtObservacion.Text
        If Me.txtIdcontador.Text = "" Then
            MsgBox(contador.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub



    Private Sub frmcontador_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtFecha.Text = Today()
        Me.chkDisponible.Checked = True
    End Sub



    Private Sub frmcontador_modificaRegistro() Handles Me.modificaRegistro
        contador.fecha = Today()
        contador.numero = Me.txtNumero.Text
        contador.disponible = Me.chkDisponible.Checked
        contador.bloqueado = Me.chkBloqueado.Checked
        contador.anulado = Me.chkAnulado.Checked
        contador.observacion = Me.txtObservacion.Text
        If Me.txtIdcontador.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            contador.idcontador = Me.txtIdcontador.Text
            MsgBox(contador.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmcontador_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de contadors"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub

End Class
