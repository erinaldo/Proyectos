Public Class frmEmpleado
    Dim tbl As New clsDevuelveTabla
    Dim empleado As New clsempleado

    Private Sub llenaGrid()

        tbl.sqlString = "select idEmpleado IdEmpleado,nombre Nombre,direccion Direccion,telefono Telefono,bloqueado Bloqueado from tblEmpleado"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmempleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtNombre, "Nombre")
            .Controls.Add(Me.txtDireccion, "Direccion")
            .Controls.Add(Me.txtTelefono, "Telefono")
 

            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmempleado_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdempleado.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            empleado.idempleado = Me.txtIdempleado.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(empleado.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmempleado_grabaRegistro() Handles Me.grabaRegistro
        empleado.nombre = Me.txtNombre.Text
        empleado.direccion = Me.txtDireccion.Text
        empleado.telefono = Me.txtTelefono.Text
        empleado.bloqueado = Me.chkBloqueado.Checked

        If Me.txtIdempleado.Text = "" Then
            MsgBox(empleado.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub

    Private Sub frmempleado_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)
        Me.txtNombre.Focus()

    End Sub



    Private Sub frmempleado_modificaRegistro() Handles Me.modificaRegistro
        empleado.nombre = Me.txtNombre.Text
        empleado.direccion = Me.txtDireccion.Text
        empleado.telefono = Me.txtTelefono.Text
        empleado.bloqueado = Me.chkBloqueado.Checked

        If Me.txtIdempleado.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            empleado.idempleado = Me.txtIdempleado.Text
            MsgBox(empleado.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmempleado_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de empleados"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub
End Class
