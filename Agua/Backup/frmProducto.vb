Public Class frmProducto

    Dim tbl As New clsDevuelveTabla
    Dim producto As New clsproducto

    Private Sub llenaGrid()

        tbl.sqlString = "select idproducto IdProducto," _
    & "nombre Nombre,precio Precio,existencia Existencia " _
        & "from tblproducto"

        Me.grdDatos.DataSource = tbl.Tabla.DefaultView
        Me.llenaFiltro()
        Me.tblView = tbl.Tabla

    End Sub

    Private Sub frmproducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaGrid()
        With Me.errores

            .Controls.Add(Me.txtNombre, "Nombre")
            .Controls.Add(Me.txtPrecio, "Precio")
            .SummaryMessage = "Por favor llene los siguientes campos"

        End With
    End Sub


    Private Sub frmproducto_eliminaRegistro() Handles Me.eliminaRegistro
        If Me.txtIdproducto.Text = "" Then
            MsgBox("Muevase a un registro con Informacion", MsgBoxStyle.Information, "!!!")

        Else
            producto.idproducto = Me.txtIdproducto.Text
            If MsgBox("Esta seguro de eliminar este Registro", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            MsgBox(producto.Borrar, MsgBoxStyle.Critical, "!!!")
            Call llenaGrid()
        End If
    End Sub

    Private Sub frmproducto_grabaRegistro() Handles Me.grabaRegistro

        producto.nombre = Me.txtNombre.Text
        producto.precio = Me.txtPrecio.Text
        producto.existencia = 0
        
        If Me.txtIdproducto.Text = "" Then
            MsgBox(producto.Crear, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        Else
            MsgBox("Para actualizar presione Modificar", MsgBoxStyle.Critical, "!!!")
        End If
    End Sub



    Private Sub frmproducto_nuevoRegistro() Handles Me.nuevoRegistro
        mdlPublicVars.limpiaCampos(Me)

    End Sub



    Private Sub frmproducto_modificaRegistro() Handles Me.modificaRegistro
        producto.nombre = Me.txtNombre.Text
        producto.precio = Me.txtPrecio.Text

        If Me.txtIdproducto.Text = "" Then
            MsgBox("Para crear presiones Nuevo", MsgBoxStyle.Critical, "!!!")
        Else
            producto.idproducto = Me.txtIdproducto.Text
            MsgBox(producto.Actualizar, MsgBoxStyle.Information, "!!!")
            Call llenaGrid()
        End If
    End Sub


    Private Sub frmproducto_reporte() Handles Me.reporte
        'Dim t As New clsDevuelveTabla
        'Dim r As New clsReporte
        'r.nombreParametro = "filtro"
        'r.parametro = "Listado de productos"
        'r.reporte = "rptListados.rpt"
        'r.tabla = t.tablaSP("exec sp_reportes 11")
        'r.verReporte()
    End Sub

End Class
