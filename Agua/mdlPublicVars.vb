Module mdlPublicVars
    Friend usuario As String
    Friend proyecto As String
    Friend idProyecto As Integer
    Friend servidor As String
    Friend bd As String
    Friend cnn As String
    Friend contraseña As String
    Friend superSearchId As String
    Friend superSearchNombre As String
    Friend idUsuario As Int16
    Friend superUsuario As Boolean = False
    'Variables de configuracion
    Friend interes As Decimal
    Friend aguaPotable As Decimal
    Friend Escrituracion As Decimal
    Friend Iva As Decimal

    Friend movEnganche As Int16
    Friend movCuota As Int16
    Friend movMora As Int16
    Friend movAgua As Int16
    Friend edoDisponible As Int16
    Friend edoReservado As Int16
    Friend liberaReserva As Boolean
    Friend Permiso As New clsPermisoUsuario




    Friend Sub conexion()
        cnn = "server=" & servidor & ";database=" & bd & ";uid=" & usuario & ";password=" & contraseña & ";connection timeout = 30000"
    End Sub

    Public Function fechaSQL(ByVal fecha As Date) As String
        Dim dia, mes As String
        If fecha.Day < 10 Then
            dia = "0" & fecha.Day
        Else
            dia = fecha.Day
        End If

        If fecha.Month < 10 Then
            mes = "0" & fecha.Month
        Else
            mes = fecha.Month
        End If

        Return "'" & fecha.Year & mes & dia & "'"
    End Function


    Public Sub limpiaCampos(ByRef frm As Form)
        Dim ctl As New Control
        Dim nombre As String
        Dim txt As TextBox
        Dim cmb As ComboBox
        Dim chk As CheckBox
        Dim pnl As Panel
        Dim msk As MaskedTextBox

        For Each ctl In frm.Controls
            nombre = ctl.Name
            If nombre <> "" Then
                If tipoControl(nombre) = "txt" Then
                    txt = ctl
                    txt.Text = ""
                    'txt.Text = dr.Item(nombrecampo(nombre))
                ElseIf tipoControl(nombre) = "cmb" Then
                    cmb = ctl
                    cmb.Text = ""
                    'cmb.Text = CInt(dr.Item(nombrecampo(nombre)))
                ElseIf tipoControl(nombre) = "chk" Then
                    chk = ctl
                    'If CInt(dr.Item(nombrecampo(nombre))) = 0 Then
                    '    chk.Checked = False
                    'Else
                    '    chk.Checked = True
                    'End If
                    chk.Checked = False
                ElseIf tipoControl(nombre) = "pnl" Then
                    pnl = ctl
                    Call limpiaCamposPanel(pnl)
                ElseIf tipoControl(nombre) = "msk" Then
                    msk = ctl
                    msk.Text = ""
                End If
            End If

        Next
    End Sub

    Public Sub limpiaCamposPanel(ByRef pnl As Panel)
        Dim ctl As New Control
        Dim nombre As String
        Dim txt As TextBox
        Dim cmb As ComboBox
        Dim chk As CheckBox
        Dim msk As MaskedTextBox
        Dim rbt As RadioButton

        For Each ctl In pnl.Controls
            nombre = ctl.Name
            If nombre <> "" Then
                If tipoControl(nombre) = "txt" Then
                    txt = ctl
                    txt.Text = ""
                    'txt.Text = dr.Item(nombrecampo(nombre))
                ElseIf tipoControl(nombre) = "cmb" Then
                    cmb = ctl
                    cmb.Text = ""
                    'cmb.Text = CInt(dr.Item(nombrecampo(nombre)))
                ElseIf tipoControl(nombre) = "chk" Then
                    chk = ctl
                    'If CInt(dr.Item(nombrecampo(nombre))) = 0 Then
                    '    chk.Checked = False
                    'Else
                    '    chk.Checked = True
                    'End If
                    chk.Checked = False
                ElseIf tipoControl(nombre) = "msk" Then
                    msk = ctl
                    msk.Text = ""
                ElseIf tipoControl(nombre) = "rbt" Then
                    rbt = ctl
                    rbt.checked = False

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

    Public Function RevisaCampo(ByVal tabla As String, ByVal id As String, ByVal nombre As String, ByVal idValor As Int16, Optional ByVal filtro As String = "") As Boolean
        RevisaCampo = False
        Dim tbl As New clsDevuelveTabla
        Try
            If filtro = "" Then
                tbl.sqlString = "select " & id & "," & nombre & " from " & tabla & " where " & id & " = " & idValor
            Else
                tbl.sqlString = "select " & id & "," & nombre & " from " & tabla & " where " & id & " = " & idValor & " and " & filtro
            End If
            If tbl.Tabla.Rows.Count = 0 Then
                Return False
            Else
                superSearchNombre = tbl.Tabla.Rows(0).Item(1).ToString
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
            Return False
        End Try
    End Function

    'Esta funcion realiza una revision del valor de un campo en el evento
    'lost focus recibiendo una cadena sql completa
    Public Function RevisaCampoSQL(ByVal str As String, ByVal nombre As String) As Boolean
        RevisaCampoSQL = False
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = str
        Try

            If tbl.Tabla.Rows.Count = 0 Then
                Return False
            Else
                superSearchNombre = tbl.Tabla.Rows(0).Item(nombre).ToString
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
            Return False
        End Try
    End Function

    Public Function Nz(ByVal valor As String) As Decimal
        Nz = 0
        If IsDBNull(valor) Or valor = "" Then
            Nz = 0
        Else
            Nz = CDec(valor)
        End If
    End Function

    'Hace disponible los valores de configuracion para toda la aplicacion
    Public Function configuracion() As Decimal
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select isnull(porcentajeInteres,0) interes,cargoEnganche,cargoCuota,cargoAgua,cargoMora,reservado,disponible,liberaReservaciones from tblConfiguraciones"
        interes = tbl.Tabla.Rows(0).Item("interes")
        movEnganche = tbl.Tabla.Rows(0).Item("cargoEnganche")
        movCuota = tbl.Tabla.Rows(0).Item("cargoCuota")
        edoReservado = tbl.Tabla.Rows(0).Item("reservado")
        edoDisponible = tbl.Tabla.Rows(0).Item("disponible")
        liberaReserva = tbl.Tabla.Rows(0).Item("liberaReservaciones")
        movAgua = tbl.Tabla.Rows(0).Item("cargoAgua")
        movMora = tbl.Tabla.Rows(0).Item("cargoMora")
    End Function

    Public Sub ConfiguracionProyect()

    End Sub

End Module
