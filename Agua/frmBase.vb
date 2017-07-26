Public Class frmBase
    'Creamos los eventos publicos para agregar, grabar y modificar
    Public Event nuevoRegistro()
    Public Event grabaRegistro()
    Public Event eliminaRegistro()
    Public Event modificaRegistro()
    Public Event reporte()
    Public Event cambiaFilaGrdDatos()
    Public Event grdDatosDobleClik()
    Public errores As New ErrorProviderExtended

    Private _tblView As DataTable
    Private _nuevo As Boolean
    Private _id As Integer
    Private _modificar As Boolean
    Private _eliminar As Boolean
    Private _grabar As Boolean
    'Control de fila actual
    Private _filaActual As Integer = 0
    Dim s As System.Type

    Public Property filaActual() As Integer
        Get
            filaActual = _filaActual
        End Get
        Set(ByVal value As Integer)
            _filaActual = value
        End Set
    End Property

    Public Property Id() As Boolean
        Get
            Id = _id
        End Get
        Set(ByVal value As Boolean)
            _id = Id
        End Set
    End Property

    Public Property nuevo() As Boolean
        Get
            nuevo = _nuevo
        End Get
        Set(ByVal value As Boolean)
            _nuevo = value
        End Set
    End Property

    Public Property modificar() As Boolean
        Get
            modificar = _modificar
        End Get
        Set(ByVal value As Boolean)
            _modificar = value
        End Set
    End Property

    Public Property eliminar() As Boolean
        Get
            eliminar = _eliminar
        End Get
        Set(ByVal value As Boolean)
            _eliminar = value
        End Set
    End Property
   
    Public Property tblView() As DataTable
        Get
            tblView = _tblView
        End Get
        Set(ByVal value As DataTable)
            _tblView = value
        End Set
    End Property

    Public Property grabar() As Boolean
        Get
            grabar = _grabar
        End Get
        Set(ByVal value As Boolean)
            _grabar = value
        End Set
    End Property

    Public Sub textoImpresion(ByVal texto As String)
        Me.btnReporte.Text = texto
    End Sub



    Private Sub frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        'Me._filaSeleccionada = 0
        'If permisosUsuario() = False Then
        '    Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        'End If
        With Me.grdDatos
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
        End With

        '28 de Octubre de 2008
        'Habilitamos los botones de registros
        If mdlPublicVars.superUsuario = False Then
            If Me.nuevo = False Then
                Me.btnNuevo.Enabled = False
            End If

            If Me.eliminar = False Then
                Me.btnBorrar.Enabled = False
            End If

            If Me.modificar = False Then
                Me.btnModificar.Enabled = False
            End If

            If Me.grabar = False Then
                Me.btnGrabar.Enabled = False

            End If
        End If

    End Sub


    Public Sub seleccionaFila()
        If Me.filaActual <> 0 Then
            Me.grdDatos.Rows(Me.filaActual).Selected = True
            Me.grdDatos.CurrentCell = grdDatos.Rows(Me.filaActual).Cells(0)
        End If
    End Sub

    Public Sub llenaFiltro()
        Dim i As Integer
        Dim j As Integer
        Me.ColumnaFiltros.Items.Clear()
        i = Me.grdDatos.Columns.Count
        For j = 0 To i - 1
            Me.ColumnaFiltros.Items.Add(Me.grdDatos.Columns(j).Name)

        Next


    End Sub


    Private Sub txtValorFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorFiltro.TextChanged
        If Me.ColumnaFiltros.Text = "" Then
            MessageBox.Show("Falta informacion para filtrar !!!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If


        If Me.ValorFiltro.Text = "" Then
            Me.tblView.DefaultView.RowFilter = Nothing
            Me.grdDatos.DataSource = Me.tblView.DefaultView
            Exit Sub
        End If

        Dim tbl As New System.Data.DataView
        tbl = Me.grdDatos.DataSource


        Try
            If tbl.Count > 0 Then
                'identificamos el tipo de dato de la columna escogida
                s = tbl.Item(0).Item(Me.ColumnaFiltros.Text).GetType()
            End If


            If s.Name = "String" Then
                tbl.RowFilter = Me.ColumnaFiltros.Text & " like '%" & CStr(Me.ValorFiltro.Text) & "%'"
            ElseIf s.Name = "Int32" Or s.Name = "Boolean" Then
                tbl.RowFilter = Me.ColumnaFiltros.Text & "=" & CInt(Me.ValorFiltro.Text)
            ElseIf s.Name = "DateTime" Then
                tbl.RowFilter = Me.ColumnaFiltros.Text & "=" & mdlPublicVars.fechaSQL(Me.ValorFiltro.Text) & ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
        End Try


        ' Are there any matching products?
        'If tbl.Count = 0 Then
        '    MessageBox.Show("No se encontraron ocurrencias !!!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        '    Exit Sub
        'End If


        Me.grdDatos.DataSource = tbl
    End Sub





    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        RaiseEvent nuevoRegistro()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If errores.CheckAndShowSummaryErrorMessage = False Then Exit Sub
        RaiseEvent grabaRegistro()

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        RaiseEvent eliminaRegistro()
    End Sub


    Private Sub grdDatos_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDatos.CellEnter
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Call obtieneCelda(e.RowIndex, e.ColumnIndex)
            Me.status1.Text = "Registro " & e.RowIndex + 1 & " de " & Me.grdDatos.RowCount
        End If

        If e.RowIndex > 0 Then
            Me.filaActual = e.RowIndex
        Else
            Me.filaActual = 0
        End If

        RaiseEvent cambiaFilaGrdDatos()

    End Sub


    Private Sub grdDatos_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdDatos.CellMouseClick

        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Call obtieneCelda(e.RowIndex, e.ColumnIndex)

        End If
    End Sub



    Private Sub obtieneCelda(ByVal rowIndex As Integer, ByVal colIndex As Integer)
        Dim colsGrid As Integer
        Dim i As Integer
        Dim celda As DataGridViewCell
        Dim columna As DataGridViewColumn
        colsGrid = Me.grdDatos.Columns.Count
        For i = 0 To colsGrid - 1
            celda = Me.grdDatos.Item(i, rowIndex)
            columna = Me.grdDatos.Columns.Item(i)
            Call llenaCampos(celda, columna)
        Next
    End Sub


    Public Sub llenaCampos(ByVal celda As DataGridViewCell, ByVal columna As DataGridViewColumn)
        Dim ctl As New Control
        Dim nombre As String
        Dim txt As TextBox
        Dim cmb As ComboBox
        Dim chk As CheckBox
        Dim pnl As Panel
        Dim msk As MaskedTextBox


        For Each ctl In Me.Controls
            nombre = ctl.Name
            If nombre <> "" Then
                If tipoControl(nombre) = "txt" Then
                    txt = ctl
                    If txt.Name.Substring(3, txt.Name.Length - 3) = columna.Name Then
                        If IsDBNull(celda.Value) Then
                            ctl.Text = ""
                        Else
                            ctl.Text = celda.Value
                        End If

                    End If
                ElseIf tipoControl(nombre) = "cmb" Then
                    cmb = ctl
                    cmb.Text = ""
                    'cmb.Text = CInt(dr.Item(nombrecampo(nombre)))
                ElseIf tipoControl(nombre) = "chk" Then
                    chk = ctl
                    If chk.Name.Substring(3, chk.Name.Length - 3) = columna.Name Then
                        If IsDBNull(celda.Value) Then
                            chk.Checked = False
                        Else
                            chk.Checked = celda.Value
                        End If


                    End If
                ElseIf tipoControl(nombre) = "pnl" Then
                    pnl = ctl
                    Call llenaCamposPanel(pnl, celda, columna)
                ElseIf tipoControl(nombre) = "msk" Then
                    msk = ctl
                    If msk.Name.Substring(3, msk.Name.Length - 3) = columna.Name Then
                        If IsDBNull(celda.Value) Then
                            msk.Text = ""
                        Else
                            msk.Text = celda.Value
                        End If


                    End If
                End If
            End If

        Next
    End Sub

    Public Sub llenaCamposPanel(ByVal panel As Panel, ByVal celda As DataGridViewCell, ByVal columna As DataGridViewColumn)
        Dim ctl As New Control
        Dim nombre As String
        Dim txt As TextBox
        Dim cmb As ComboBox
        Dim chk As CheckBox
        Dim msk As MaskedTextBox
        Dim lbl As Label


        For Each ctl In panel.Controls
            nombre = ctl.Name
            If nombre <> "" Then
                If tipoControl(nombre) = "txt" Then
                    txt = ctl
                    If txt.Name.Substring(3, txt.Name.Length - 3) = columna.Name Then
                        If IsDBNull(celda.Value) Then
                            ctl.Text = ""
                        Else
                            ctl.Text = celda.Value
                        End If
                    End If
                ElseIf tipoControl(nombre) = "lbl" Then
                    lbl = ctl
                    If lbl.Name.Substring(3, lbl.Name.Length - 3) = columna.Name Then
                        If IsDBNull(celda.Value) Then
                            ctl.Text = ""
                        Else
                            ctl.Text = celda.Value
                        End If
                    End If
                ElseIf tipoControl(nombre) = "cmb" Then
                    cmb = ctl
                    cmb.Text = ""
                    'cmb.Text = CInt(dr.Item(nombrecampo(nombre)))
                ElseIf tipoControl(nombre) = "chk" Then
                    chk = ctl
                    If chk.Name.Substring(3, chk.Name.Length - 3) = columna.Name Then
                        If IsDBNull(celda.Value) Then
                            chk.Checked = False
                        Else
                            chk.Checked = celda.Value
                        End If
                    End If
                ElseIf tipoControl(nombre) = "msk" Then
                    msk = ctl
                    If msk.Name.Substring(3, msk.Name.Length - 3) = columna.Name Then
                        If IsDBNull(celda.Value) Then
                            msk.Text = ""
                        Else
                            msk.Text = celda.Value
                        End If
                    End If
                End If
            End If

        Next
    End Sub
    Private Function tipoControl(ByVal nombre As String) As String
        Dim acronimo As String
        acronimo = nombre.Substring(0, 3)
        Return acronimo
    End Function

    Private Function nombrecampo(ByVal nombre As String) As String
        Dim campo As String
        campo = nombre.Substring(3, nombre.Length - 3)
        Return campo
    End Function




    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        RaiseEvent reporte()
    End Sub

    'Private Function permisosUsuario() As Boolean
    '    permisosUsuario = False
    '    Dim tbl As New clsDevuelveTabla
    '    Dim dr As System.Data.DataRow
    '    Dim t As System.Data.DataTable

    '    tbl.sqlString = "select u.nuevo,u.modifica,u.elimina,u.crear,f.nombre" _
    '    & " from tblUsuariosFormas u " _
    '    & " inner join tblFormas f on u.idForma = f.idForma" _
    '    & " and u.idUsuario = " & mdlPublicVars.idUsuario _
    '    & " and f.nombre = '" & Me.Name & "'"

    '    t = tbl.Tabla
    '    If t.Rows.Count = 0 Then

    '        MsgBox("Sin permisos para esta opcion !!!", MsgBoxStyle.Critical, "!!!")
    '        Return False
    '    End If

    '    dr = t.Rows(0)
    '    If dr.Item("nuevo") = False Then
    '        Me.btnNuevo.Enabled = False
    '    End If

    '    If dr.Item("modifica") = False Then
    '        Me.btnModificar.Enabled = False
    '    End If

    '    If dr.Item("elimina") = False Then
    '        Me.btnBorrar.Enabled = False
    '    End If

    '    If dr.Item("crear") = False Then
    '        Me.btnGrabar.Enabled = False
    '    End If

    '    Return True
    'End Function



    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If errores.CheckAndShowSummaryErrorMessage = False Then Exit Sub

        RaiseEvent modificaRegistro()
    End Sub


    Private Sub ocultarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ocultarFiltro.Click
        Me.TableLayoutPanel1.Visible = False
        Me.grdDatos.Visible = True

    End Sub

    Private Sub mostrarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mostrarFiltro.Click
        Me.TableLayoutPanel1.Visible = True
        Me.grdDatos.Visible = True
    End Sub

    Private Sub grdDatos_DoubleClick(sender As Object, e As EventArgs) Handles grdDatos.DoubleClick
        RaiseEvent grdDatosDobleClik()
    End Sub

End Class
