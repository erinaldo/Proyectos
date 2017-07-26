Public Class frmAsignacionContador
    Dim tbl As New clsDevuelveTabla
    Dim Asignacion As New clsAsignacionContador
    Private _idAsignacion As Integer
    Public Property idAsignacion() As Integer
        Get
            idAsignacion = _idAsignacion
        End Get
        Set(ByVal value As Integer)
            _idAsignacion = value
        End Set
    End Property

    Private Sub llenaGrid()

        tbl.sqlString = "select a.idAsignacionContador IdAsignacionContador,a.idContador IdContador," _
& "c.numero Contador,a.lecturaInicial LecturaInicial " _
        & "From tblasignacioncontador a inner join tblcontador c on a.idContador = c.idContador " _
& "where idAsignacion = " & Me.idAsignacion

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmAsignacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtIdContador, "Contador")
            .Controls.Add(Me.txtLecturaInicial, "Lectura Inicial")


            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmAsignacion_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdAsignacionContador.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            Asignacion.idAsignacionContador = Me.txtIdAsignacionContador.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(Asignacion.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmAsignacion_grabaRegistro() Handles Me.grabaRegistro
        Try
            Asignacion.idAsignacion = Me.idAsignacion
            Asignacion.idContador = Me.txtIdContador.Text
            Asignacion.lecturaInicial = Me.txtLecturaInicial.Text

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End Try

        If Me.txtIdAsignacionContador.Text = "" Then
            MsgBox(Asignacion.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub

    Private Sub frmAsignacion_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtIdContador.Focus()


    End Sub



    Private Sub frmAsignacion_modificaRegistro() Handles Me.modificaRegistro
        Try
            Asignacion.idAsignacion = Me.idAsignacion
            Asignacion.idContador = Me.txtIdContador.Text
            Asignacion.lecturaInicial = Me.txtLecturaInicial.Text

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End Try
        If Me.txtIdAsignacionContador.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            Asignacion.idAsignacionContador = Me.txtIdAsignacionContador.Text
            MsgBox(Asignacion.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmAsignacion_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de Asignacions"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub

    Private Sub txtIdContador_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdContador.LostFocus
        If Not IsNumeric(Me.txtIdContador.Text) And Me.txtIdContador.Text <> "" Then
            Me.txtIdContador.Text = ""
            Me.txtIdContador.Focus()
            Exit Sub
        End If
        If Me.txtIdContador.Text <> "" Then
            If mdlPublicVars.RevisaCampo("tblContador", "IdContador", "numero", Me.txtIdContador.Text) = False Then
                MsgBox("Contador no valido !!!", MsgBoxStyle.Critical, "!!!")
                Me.txtIdContador.Text = ""
                Me.txtContador.Text = ""
                Me.txtIdContador.Focus()
            Else
                Me.txtContador.Text = mdlPublicVars.superSearchNombre
            End If
        End If
    End Sub



    Private Sub txtIdContador_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtIdContador.MouseDoubleClick
        frmSuperSearch.sqlString = "select IdContador,numero from tblContador"
        frmSuperSearch.nombre = "nombre"
        frmSuperSearch.Text = "Contador Actividad"

        frmSuperSearch.ShowDialog()
        If mdlPublicVars.superSearchId = 0 Then
            Exit Sub
        Else
            Me.txtIdContador.Text = mdlPublicVars.superSearchId
            Me.txtContador.Text = mdlPublicVars.superSearchNombre
        End If
    End Sub
End Class
