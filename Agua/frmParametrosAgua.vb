Public Class frmParametrosAgua
    Dim t As New clsDevuelveTabla
    Dim p As New clsParametrosAgua

    Private Sub frmParametrosAgua_eliminaRegistro() Handles Me.eliminaRegistro
        'If Me.txtId.Text = "" Then
        '    MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")
        'Else
        '    p.codigo = Me.txtId.Text
        '    If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        '    MsgBox(p.Borrar, MsgBoxStyle.Critical, "!!!")
        '    Call llenaGrid()
        'End If
        MsgBox("No disponible ", MsgBoxStyle.Information, "!!!")
        Exit Sub
    End Sub

    Private Sub frmParametrosAgua_grabaRegistro() Handles Me.grabaRegistro

        If Me.txtInicio.Text = "" Or Me.txtFin.Text = "" Or Me.txtValor.Text = "" Then
            MsgBox("Falta campos vacios !", MsgBoxStyle.Information, "!!!")
            Exit Sub
        End If

        p.Inicio = Me.txtInicio.Text
        p.Fin = Me.txtFin.Text
        p.valor = Me.txtValor.Text

        If Me.txtId.Text = "" Then
            MsgBox(p.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub
    Private Sub frmParametrosAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenaGrid()
    End Sub
    Private Sub llenaGrid()

        t.sqlString = "select Codigo Id, ParametroInicio, Inicio, ParametroFin, Fin, Valor from parametrosAgua"

        Me.grdDatos.DataSource = t.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = t.Tabla

    End Sub

    Private Sub frmParametrosAgua_modificaRegistro() Handles Me.modificaRegistro

        If Me.txtInicio.Text = "" Or Me.txtFin.Text = "" Or Me.txtValor.Text = "" Then
            MsgBox("Revise los campos vacios !", MsgBoxStyle.Information, "!!!")
            Exit Sub
        End If

        p.Inicio = Me.txtInicio.Text
        p.Fin = Me.txtFin.Text
        p.valor = Me.txtValor.Text

        If Me.txtId.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            p.codigo = Me.txtId.Text
            MsgBox(p.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmParametrosAgua_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtInicio.Focus()
    End Sub

    Private Sub frmParametrosAgua_reporte() Handles Me.reporte
        MsgBox("No disponible !!!", MsgBoxStyle.Exclamation, "!!!")
        Exit Sub
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs)

        If Me.grdDatos.Rows.Count = 0 Then
            Exit Sub
        End If

        If Me.txtId.Text = "" Then
            Me.lblParametroInicio.Text = "Inicio"
            Me.lblParametroFin.Text = "Fin"
        End If

        Me.lblParametroInicio.Text = Me.grdDatos.CurrentRow.Cells("ParametroInicio").Value
        Me.lblParametroFin.Text = Me.grdDatos.CurrentRow.Cells("ParametroFin").Value

    End Sub
End Class
