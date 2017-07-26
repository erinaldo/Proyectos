Public Class frmAnulaFactura
    Private _idFactura As Int16
    Public Property idFActura() As Int16
        Get
            idFActura = _idFactura
        End Get
        Set(ByVal value As Int16)
            _idFactura = value
        End Set
    End Property

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "exec sp_AnulaFactura " & idFActura


        If tbl.ejecutaSQL = 0 Then
            MsgBox("Ocurrio un error al anular esta factura", MsgBoxStyle.Critical, "!!!")
        Else
            MsgBox("Factura Anulada Satisfactoriamente", MsgBoxStyle.Exclamation, "!!!")
            Me.Close()
        End If
    End Sub
End Class