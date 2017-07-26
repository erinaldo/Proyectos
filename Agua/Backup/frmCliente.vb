Public Class frmCliente
    Dim tbl As New clsDevuelveTabla
    Dim cliente As New clscliente

    Private Sub llenaGrid()

        tbl.sqlString = "select idCliente IdCliente,nombre Nombre,direccion Direccion," _
& "telefono Telefono,facturarA FacturarA,nit Nit,email Email " _
& "from tblCliente"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtNombre, "Nombre")
            .Controls.Add(Me.txtDireccion, "Direccion")
            .Controls.Add(Me.txtTelefono, "Telefono")
            .Controls.Add(Me.txtFacturarA, "Facturar A")
            .Controls.Add(Me.txtNit, "Nit")

            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmcliente_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdCliente.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            cliente.idcliente = Me.txtIdCliente.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(cliente.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmcliente_grabaRegistro() Handles Me.grabaRegistro
        cliente.nombre = Me.txtNombre.Text
        cliente.direccion = Me.txtDireccion.Text
        cliente.telefono = Me.txtTelefono.Text
        cliente.facturarA = Me.txtFacturarA.Text
        cliente.nit = Me.txtNit.Text
        cliente.email = Me.txtEmail.Text

        If Me.txtIdCliente.Text = "" Then
            MsgBox(cliente.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub

    Private Sub frmcliente_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtNombre.Focus()

    End Sub



    Private Sub frmcliente_modificaRegistro() Handles Me.modificaRegistro
        cliente.nombre = Me.txtNombre.Text
        cliente.direccion = Me.txtDireccion.Text
        cliente.telefono = Me.txtTelefono.Text
        cliente.facturarA = Me.txtFacturarA.Text
        cliente.nit = Me.txtNit.Text
        cliente.email = Me.txtEmail.Text


        If Me.txtIdCliente.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            cliente.idcliente = Me.txtIdCliente.Text
            MsgBox(cliente.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmcliente_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de clientes"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub
End Class
