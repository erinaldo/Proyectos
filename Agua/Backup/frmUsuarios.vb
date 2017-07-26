Public Class frmUsuarios
    Dim tbl As New clsDevuelveTabla
    Dim usuario As New clsUsuarios 
    
    Private Sub llenaGrid()

        tbl.sqlString = "select idUsuario IdUsuario,nombre as Nombre,bloqueado Bloqueado,superUsuario SuperUsuario " _
        & "from tblUsuarios"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub
    
        Private Sub frmProyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
    End Sub

    Private Sub frmUsuarios_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdUsuario.Text = "" Then
            MsgBox("Muevase a un registro con informacion", MsgBoxStyle.Information, "!!!")

        Else
            usuario.idUsuario  = Me.txtIdUsuario.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(usuario.Borrar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmUsuarios_grabaRegistro() Handles Me.grabaRegistro
        usuario.nombre = Me.txtNombre.Text
        usuario.bloqueado = Me.chkBloqueado.Checked
        usuario.superUsuario = Me.chkSuperUsuario.Checked

        If Me.txtIdUsuario.Text = "" Then
            MsgBox(usuario.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione modificar", MsgBoxStyle.Critical, "!!!")

        End If
    End Sub



    Private Sub frmUsuarios_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
    End Sub

    Private Sub frmUsuarios_reporte() Handles Me.reporte
        Dim t As New clsDevuelveTabla
        Dim r As New clsReporte
        t.sqlString = "select * from tblUsuarios"
        r.nombreParametro = ""
        r.parametro = ""
        r.reporte = "rptUsuarios.rpt"
        r.tabla = t.Tabla
        r.verReporte()
    End Sub
    

    Private Sub frmUsuarios_modificaRegistro() Handles Me.modificaRegistro
        usuario.nombre = Me.txtNombre.Text
        usuario.bloqueado = Me.chkBloqueado.Checked
        usuario.superUsuario = Me.chkSuperUsuario.Checked

        If Me.txtIdUsuario.Text = "" Then
            MsgBox("Para crear presione nuevo", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        Else
            usuario.idUsuario = Me.txtIdUsuario.Text
            MsgBox(usuario.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub btnDetalleRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleRecibo.Click
        If Me.txtIdUsuario.Text = "" Then
            MsgBox("Muevase a un registro con informacion", MsgBoxStyle.Critical, "!!!")
        End If
        frmPermisoUsuario.Text = "Permisos sobre Formas"
        frmPermisoUsuario.MdiParent = MDIPrincipal
        frmPermisoUsuario.idUsuario = Me.txtIdUsuario.Text
        Permiso.Permiso(frmPermisoUsuario)

    End Sub
End Class
