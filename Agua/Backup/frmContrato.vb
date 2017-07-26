Public Class frmContrato
    Dim tbl As New clsDevuelveTabla
    Dim contrato As New clsContrato
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

        tbl.sqlString = "select " _
& "idContrato IdContrato,nombreApellido NombreApellido,identificacion Identificacion, " _
& "domicilio Domicilio,localidad Localidad,telefono Telefono,direccionSuministro DireccionSuministro, " _
& "numeroContador NumeroContador,cuotaMensual CuotaMensual,planta Planta,exceso Exceso," _
& "reconexion Reconexion,cedulaOrden CedulaOrden,cedulaOrdenNumero CedulaOrdenNumero," _
& "registro Registro,extendidaEn ExtendidaEn,numeroContrato NumeroContrato," _
& "idAsignacion IdAsignacion,fecha Fecha " _
& "from tblContrato where idAsignacion = " & Me.idAsignacion

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtNombreApellido, "Nombre")
            .Controls.Add(Me.txtDireccionSuministro, "Direccion suminisro")
            .Controls.Add(Me.txtIdentificacion, "Identificacion")
            .Controls.Add(Me.txtLocalidad, "Localidad")
            .Controls.Add(Me.txtTelefono, "Telefono")
            .Controls.Add(Me.txtNumeroContador, "Contador(es)")
            .Controls.Add(Me.txtCedulaOrden, "Cedula de Orden")
            .Controls.Add(Me.txtCedulaOrdenNumero, "Cedula Orden Numero")
            .Controls.Add(Me.txtRegistro, "NO ha agregado el Numero de registro")
            .Controls.Add(Me.txtExtendidaEn, "No ha ingresado Extendida en")
            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmcliente_eliminaRegistro() Handles Me.eliminaRegistro
        MsgBox("No es posible eliminar un contrato", MsgBoxStyle.Critical, "!!!")
        'If Me.txtIdContrato.Text = "" Then
        '    MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        'Else
        '    contrato.idContrato = Me.txtIdContrato.Text
        '    If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        '    MsgBox(contrato.Borrar, MsgBoxStyle.Critical, "!!!")
        '    Call llenaGrid()
        'End If
    End Sub

    Private Sub frmcliente_grabaRegistro() Handles Me.grabaRegistro
        With contrato
            .fecha = Me.txtFecha.Text
            .numeroContrato = Me.txtNumeroContrato.Text
            .nombreApellido = Me.txtNombreApellido.Text
            .direccionSuministro = Me.txtDireccionSuministro.Text
            .localidad = Me.txtLocalidad.Text
            .identificacion = Me.txtIdentificacion.Text
            .domicilio = Me.txtDomicilio.Text
            .telefono = Me.txtTelefono.Text
            .numeroContador = Me.txtNumeroContador.Text
            .cuotaMensual = Me.txtCuotaMensual.Text
            .reconexion = Me.txtReconexion.Text
            .planta = Me.txtPlanta.Text
            .exceso = Me.txtExceso.Text
            .cedulaOrden = Me.txtCedulaOrden.Text
            .cedulaOrdenNumero = Me.txtCedulaOrdenNumero.Text
            .registro = Me.txtRegistro.Text
            .extendidaEn = Me.txtExtendidaEn.Text
            .idAsignacion = Me.idAsignacion
        End With

        If Me.txtIdContrato.Text = "" Then
            MsgBox(contrato.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub

    Private Sub frmcliente_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtFecha.Text = Today()
        Call contratoToca()
        Me.txtNombreApellido.Focus()

    End Sub

    Private Sub contratoToca()
        Dim tbl As New clsDevuelveTabla
        Dim sql As String = ""
        Dim idProyecto As Integer = 0
        Dim Proyecto As DataRow = Nothing
        sql = "select * from tblcontrato order by numeroContrato desc"
        tbl.sqlString = sql

        If tbl.Tabla.Rows.Count = 0 Then
            Me.txtNumeroContrato.Text = 1
        Else
            Me.txtNumeroContrato.Text = CInt(tbl.Tabla.Rows(0).Item("numeroContrato").ToString) + 1
        End If

        sql = "select * from tblAsignacion where idAsignacion = " & Me.idAsignacion
        tbl.sqlString = sql

        idProyecto = tbl.Tabla.Rows(0).Item("idProyecto")

        sql = "select * from tblProyecto where idProyecto = " & idProyecto
        tbl.sqlString = sql

        Me.txtCuotaMensual.Text = tbl.Tabla.Rows(0).Item("cuotaFija").ToString
        Me.txtPlanta.Text = tbl.Tabla.Rows(0).Item("planta").ToString
        Me.txtExceso.Text = tbl.Tabla.Rows(0).Item("precioExceso").ToString
        Me.txtReconexion.Text = tbl.Tabla.Rows(0).Item("reconexion").ToString


    End Sub

    Private Sub frmcliente_modificaRegistro() Handles Me.modificaRegistro
        With contrato
            .fecha = Me.txtFecha.Text
            .numeroContrato = Me.txtNumeroContrato.Text
            .nombreApellido = Me.txtNombreApellido.Text
            .direccionSuministro = Me.txtDireccionSuministro.Text
            .localidad = Me.txtLocalidad.Text
            .identificacion = Me.txtIdentificacion.Text
            .domicilio = Me.txtDomicilio.Text
            .telefono = Me.txtTelefono.Text
            .numeroContador = Me.txtNumeroContador.Text
            .cuotaMensual = Me.txtCuotaMensual.Text
            .reconexion = Me.txtReconexion.Text
            .planta = Me.txtPlanta.Text
            .exceso = Me.txtExceso.Text
            .cedulaOrden = Me.txtCedulaOrden.Text
            .cedulaOrdenNumero = Me.txtCedulaOrdenNumero.Text
            .registro = Me.txtRegistro.Text
            .extendidaEn = Me.txtExtendidaEn.Text
            .idAsignacion = Me.idAsignacion
        End With


        If Me.txtIdContrato.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else

            contrato.idContrato = Me.txtIdContrato.Text
            MsgBox(contrato.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmcliente_reporte() Handles Me.reporte
        If Me.txtIdContrato.Text = "" Then
            MsgBox("Muevase a un registro con informacion", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        Dim t As New clsDevuelveTabla
        t.sqlString = "select * from tblContrato where idContrato = " & Me.txtIdContrato.Text
        Dim r As New clsReporte
        r.nombreParametro = ""
        r.parametro = ""
        r.reporte = "rptContratoAgua.rpt"
        r.tabla = t.Tabla
        r.verReporte()
    End Sub

    Private Sub btnImprime2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime2.Click
        If Me.txtIdContrato.Text = "" Then
            MsgBox("Muevase a un registro con informacion", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If
        Dim t As New clsDevuelveTabla
        t.sqlString = "select * from tblContrato where idContrato = " & Me.txtIdContrato.Text
        Dim r As New clsReporte
        r.nombreParametro = ""
        r.parametro = ""
        r.reporte = "rptContratoAguaAtras.rpt"
        r.tabla = t.Tabla
        r.verReporte()
    End Sub
End Class
