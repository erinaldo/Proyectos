Public Class frmSuperSearch
    Private _sqlString As String
    Private _id As String
    Private _nombre As String

    Dim tblv As New System.Data.DataView
    Dim tbl As New clsDevuelveTabla


    Public Property id() As String
        Get
            id = _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            nombre = _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property sqlString() As String
        Get
            sqlString = _sqlString
        End Get
        Set(ByVal value As String)
            _sqlString = value
        End Set
    End Property
    Private Sub frmSuperSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tbl.sqlString = Me.sqlString

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        mdlPublicVars.superSearchId = 0
        mdlPublicVars.superSearchNombre = ""
   
    End Sub



    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged

        If Me.txtFiltro.Text = "" Then
            tbl.sqlString = Me.sqlString
            Me.grdDatos.DataSource = tbl.Tabla.DefaultView

            tblv.RowStateFilter = DataViewRowState.None
            tblv = grdDatos.DataSource
            Me.grdDatos.DataSource = tblv
        Else
            tblv = grdDatos.DataSource
            tblv.RowFilter = Me.nombre & " Like '%" & Me.txtFiltro.Text & "%'"
            grdDatos.DataSource = tblv
        End If

    End Sub







    Private Sub grdDatos_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdDatos.CellMouseDoubleClick
        Dim cellId As DataGridViewCell
        Dim cellNombre As DataGridViewCell

        If e.RowIndex >= 0 Then

            cellId = Me.grdDatos.Item(0, e.RowIndex)
            cellNombre = Me.grdDatos.Item(1, e.RowIndex)

            mdlPublicVars.superSearchId = cellId.Value
            mdlPublicVars.superSearchNombre = cellNombre.Value
            Me.txtFiltro.Text = ""
            Me.grdDatos.DataSource = Nothing
            Me.Close()
        End If
    End Sub




End Class
