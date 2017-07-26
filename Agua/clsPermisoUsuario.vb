Public Class clsPermisoUsuario



    Public Sub Permiso(ByVal formulario As frmBase)
        If mdlPublicVars.superUsuario = True Then
            formulario.Show()
            Exit Sub
        End If

        Dim str As String
        Dim tbl As New clsDevuelveTabla
        Dim tb As System.Data.DataTable
        str = "sp_permisos " & mdlPublicVars.idUsuario & ",'" & formulario.Name & "'"
        tb = tbl.tablaSP(str)

        If tb.Rows.Count = 0 Then
            MsgBox("Sin permisos para esta opcion", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        Else
            formulario.nuevo = tb.Rows(0).Item("nuevo")
            formulario.modificar = tb.Rows(0).Item("modifica")
            formulario.eliminar = tb.Rows(0).Item("elimina")
            formulario.grabar = tb.Rows(0).Item("crea")
            formulario.Show()
        End If
    End Sub


    Public Sub PermisoDialog(ByVal formulario As frmBase)
        If mdlPublicVars.superUsuario = True Then
            formulario.ShowDialog()
            Exit Sub
        End If

        Dim str As String
        Dim tbl As New clsDevuelveTabla
        Dim tb As System.Data.DataTable
        str = "sp_permisos " & mdlPublicVars.idUsuario & ",'" & formulario.Name & "'"
        tb = tbl.tablaSP(str)

        If tb.Rows.Count = 0 Then
            MsgBox("Sin permisos para esta opcion", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        Else
            formulario.nuevo = tb.Rows(0).Item("nuevo")
            formulario.modificar = tb.Rows(0).Item("modifica")
            formulario.eliminar = tb.Rows(0).Item("elimina")
            formulario.grabar = tb.Rows(0).Item("crea")
            formulario.ShowDialog()
        End If
    End Sub

    Public Sub PermisoSimple(ByVal formulario As Form)
        If mdlPublicVars.superUsuario = True Then
            formulario.Show()
            Exit Sub
        End If

        Dim str As String
        Dim tbl As New clsDevuelveTabla
        Dim tb As System.Data.DataTable
        str = "sp_permisos " & mdlPublicVars.idUsuario & ",'" & formulario.Name & "'"
        tb = tbl.tablaSP(str)

        If tb.Rows.Count = 0 Then
            MsgBox("Sin permisos para esta opcion", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        Else
            formulario.Show()
        End If
    End Sub


    Public Sub PermisoSimpleDialog(ByVal formulario As Form)
        If mdlPublicVars.superUsuario = True Then
            formulario.ShowDialog()
            Exit Sub
        End If

        Dim str As String
        Dim tbl As New clsDevuelveTabla
        Dim tb As System.Data.DataTable
        str = "sp_permisos " & mdlPublicVars.idUsuario & ",'" & formulario.Name & "'"
        tb = tbl.tablaSP(str)

        If tb.Rows.Count = 0 Then
            MsgBox("Sin permisos para esta opcion", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        Else
            formulario.Show()
        End If
    End Sub


End Class
