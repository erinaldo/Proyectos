Public Class frmEliminaLectura
    Private _idLectura As Double
    Public Property idLectura() As Double
        Get
            idLectura = _idLectura
        End Get
        Set(ByVal value As Double)
            _idLectura = value
        End Set
    End Property


    Private Sub btnElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimina.Click
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "exec sp_borraLectura " & Me.idLectura
        If tbl.ejecutaSQL = 0 Then
            MsgBox("Ocurrio un error al eliminar la lectura", MsgBoxStyle.Critical, "!!!")
        Else
            MsgBox("Lectura eliminada satisfactoriamente", MsgBoxStyle.Exclamation, "!!!")
        End If

        Me.Close()

    End Sub


End Class