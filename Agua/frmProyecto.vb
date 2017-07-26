Public Class frmProyecto

    Dim tbl As New clsDevuelveTabla
    Dim proyecto As New clsproyecto

    Private Sub llenaGrid()

        tbl.sqlString = "select idProyecto IdProyecto,nombre Nombre,direccion Direccion," _
        & " cuotaFija CuotaFija,aguaFija AguaFija,precioExceso PrecioExceso," _
        & " diasPago DiasPago,planta Planta,reconexion Reconexion," _
        & " multiplicador Multiplicador,mora Mora,iva Iva " _
        & " from tblProyecto "

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmproyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtNombre, "Nombre")
            .Controls.Add(Me.txtDireccion, "Direccion")
            .Controls.Add(Me.txtCuotaFija, "Cuota Fija")
            .Controls.Add(Me.txtAguaFija, "Mts Agua")
            .Controls.Add(Me.txtDiasPago, "Dias para pagar")
            .Controls.Add(Me.txtReconexion, "Reconexion")
            .Controls.Add(Me.txtMultiplicador, "Multiplicador")

            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmproyecto_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdproyecto.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            proyecto.idproyecto = Me.txtIdproyecto.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(proyecto.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmproyecto_grabaRegistro() Handles Me.grabaRegistro
        Try
            proyecto.nombre = Me.txtNombre.Text
            proyecto.direccion = Me.txtDireccion.Text
            proyecto.cuotaFija = Me.txtCuotaFija.Text
            proyecto.aguaFija = Me.txtAguaFija.Text
            proyecto.precioExceso = 0
            proyecto.diasPago = Me.txtDiasPago.Text
            proyecto.planta = 0
            proyecto.reconexion = Me.txtReconexion.Text
            proyecto.multiplicador = Me.txtMultiplicador.Text

            proyecto.mora = 0
            proyecto.iva = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End Try
        If Me.txtIdProyecto.Text = "" Then
            MsgBox(proyecto.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub

    Private Sub frmproyecto_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)

    End Sub



    Private Sub frmproyecto_modificaRegistro() Handles Me.modificaRegistro
        Try
            proyecto.nombre = Me.txtNombre.Text
            proyecto.direccion = Me.txtDireccion.Text
            proyecto.cuotaFija = Me.txtCuotaFija.Text
            proyecto.aguaFija = Me.txtAguaFija.Text
            proyecto.precioExceso = 0
            proyecto.diasPago = Me.txtDiasPago.Text
            proyecto.planta = 0
            proyecto.reconexion = Me.txtReconexion.Text
            proyecto.multiplicador = Me.txtMultiplicador.Text

            proyecto.mora = 0
            proyecto.iva = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End Try

        If Me.txtIdProyecto.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            proyecto.idProyecto = Me.txtIdProyecto.Text
            MsgBox(proyecto.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmproyecto_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de proyectos"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub
End Class
