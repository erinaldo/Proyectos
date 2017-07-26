Public Class frmEliminaNotaCredito
    Private _idNotaCredito As Integer
    Public Property idNotaCredito() As Integer
        Get
            idNotaCredito = _idNotaCredito
        End Get
        Set(ByVal value As Integer)
            _idNotaCredito = value
        End Set
    End Property


    Private Sub btnElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimina.Click
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "exec sp_eliminaNotacredito " & Me.idNotaCredito

        If tbl.ejecutaSQL = 0 Then
            MsgBox("Ocurrio un error al eliminar la nota de credito", MsgBoxStyle.Critical, "!!!")
        Else
            MsgBox("Nota de credito eliminada satisfactoriamente", MsgBoxStyle.Exclamation, "!!!")
        End If
        Me.Close()

    End Sub
End Class