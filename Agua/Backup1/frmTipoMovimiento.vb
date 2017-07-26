Public Class frmTipoMovimiento

    Dim tbl As New clsDevuelveTabla
    Dim TipoMovimiento As New clsTipoMovimiento

    Private Sub llenaGrid()

        tbl.sqlString = "select idTipoMovimiento IdTipoMovimiento," _
    & "nombre Nombre,entrada Entrada,generaFactura GeneraFactura " _
        & "from tblTipoMovimiento"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmTipoMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtNombre, "Nombre")

            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmTipoMovimiento_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdTipoMovimiento.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            TipoMovimiento.idTipoMovimiento = Me.txtIdTipoMovimiento.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(TipoMovimiento.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmTipoMovimiento_grabaRegistro() Handles Me.grabaRegistro

        TipoMovimiento.nombre = Me.txtNombre.Text
        TipoMovimiento.entrada = Me.chkEntrada.Checked
        TipoMovimiento.generaFactura = Me.chkGeneraFactura.Checked

        If Me.txtIdTipoMovimiento.Text = "" Then
            MsgBox(TipoMovimiento.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub



    Private Sub frmTipoMovimiento_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)

    End Sub



    Private Sub frmTipoMovimiento_modificaRegistro() Handles Me.modificaRegistro
        TipoMovimiento.nombre = Me.txtNombre.Text
        TipoMovimiento.entrada = Me.chkEntrada.Checked
        TipoMovimiento.generaFactura = Me.chkGeneraFactura.Checked

        If Me.txtIdTipoMovimiento.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            TipoMovimiento.idTipoMovimiento = Me.txtIdTipoMovimiento.Text
            MsgBox(TipoMovimiento.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmTipoMovimiento_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de TipoMovimientos"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub
End Class
