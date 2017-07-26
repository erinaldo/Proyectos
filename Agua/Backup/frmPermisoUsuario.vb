Public Class frmPermisoUsuario

    Dim tbl As New clsDevuelveTabla
    Dim usuario As New clsUsuariosFormas
    Private _idUsuario As Int16
    Public Property idUsuario() As Int16
        Get
            idUsuario = _idUsuario
        End Get
        Set(ByVal value As Int16)
            _idUsuario = value
        End Set
    End Property


    Private Sub llenaGrid()

        tbl.sqlString = "select uf.idUsuarioForma IdUsuarioForma,f.idForma IdForma,f.descripcion Forma," _
& "uf.nuevo Nuevo,uf.modifica Modifica,uf.elimina Elimina," _
& "uf.crea Crea " _
& "from tblUsuariosformas uf " _
& "inner join tblformas f on uf.idForma = f.idForma where  uf.idUsuario = " & Me.idUsuario

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmProyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
    End Sub

    Private Sub frmUsuarios_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdUsuarioForma.Text = "" Then
            MsgBox("Muevase a un registro con informacion", MsgBoxStyle.Information, "!!!")

        Else
            usuario.idUsuarioForma = Me.txtIdUsuarioForma.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(usuario.Borrar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmUsuarios_grabaRegistro() Handles Me.grabaRegistro
        usuario.idUsuario = Me.idUsuario
        usuario.nuevo = Me.chkNuevo.Checked
        usuario.modifica = Me.chkModifica.Checked
        usuario.crea = Me.chkCrea.Checked
        usuario.elimina = Me.chkElimina.Checked
        usuario.idForma = Me.txtIdForma.Text

        If Me.txtIdUsuarioForma.Text = "" Then
            MsgBox(usuario.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione modificar", MsgBoxStyle.Critical, "!!!")

        End If
    End Sub



    Private Sub frmUsuarios_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
    End Sub

    Private Sub frmUsuarios_modificaRegistro() Handles Me.modificaRegistro
        usuario.idUsuario = Me.idUsuario
        usuario.nuevo = Me.chkNuevo.Checked
        usuario.modifica = Me.chkModifica.Checked
        usuario.crea = Me.chkCrea.Checked
        usuario.elimina = Me.chkElimina.Checked
        usuario.idForma = Me.txtIdForma.Text


        If Me.txtIdUsuarioForma.Text = "" Then
            MsgBox("Para crear presione nuevo", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        Else
            usuario.idUsuarioForma = Me.txtIdUsuarioForma.Text
            MsgBox(usuario.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub txtIdForma_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdForma.LostFocus
        If Me.txtIdForma.Text = "" Then
            Exit Sub
        End If

        If mdlPublicVars.RevisaCampo("tblFormas", "IdForma", "descripcion", Me.txtIdForma.Text) = False Then
            MsgBox("Forma no valido !!!", MsgBoxStyle.Critical, "!!!")
            Me.txtIdForma.Text = ""
            Me.txtForma.Text = ""
            Me.txtIdForma.Focus()
        Else
            Me.txtForma.Text = mdlPublicVars.superSearchNombre
        End If
    End Sub
    Private Sub txtIdForma_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtIdForma.MouseDoubleClick
        frmSuperSearch.sqlString = "Select idForma,descripcion from tblFormas"
        frmSuperSearch.nombre = "descripcion"
        frmSuperSearch.Text = "Formas"

        frmSuperSearch.ShowDialog()
        If mdlPublicVars.superSearchId = 0 Then
            Exit Sub
        Else
            Me.txtIdForma.Text = mdlPublicVars.superSearchId
            Me.txtForma.Text = mdlPublicVars.superSearchNombre
        End If
    End Sub


End Class
