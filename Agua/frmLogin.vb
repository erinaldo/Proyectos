Public Class frmLogin

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        usuario = Me.txtUsuario.Text
        contraseña = Me.txtContraseña.Text
        mdlPublicVars.conexion()

        Dim cnn As New System.Data.SqlClient.SqlConnection
        Try
            cnn.ConnectionString = mdlPublicVars.cnn
            cnn.Open()
            cnn.Close()
            cnn.Dispose()
            'Revisamos la existencia del usuario en la BD de configuraciones
            If verificaUsuario() = False Then
                Exit Sub
            End If

            proyecto = "Cond. Santiago"
            Me.Hide()

            MDIPrincipal.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
        End Try


    End Sub


 



    Private Function verificaUsuario() As Boolean
        verificaUsuario = False
        Dim tbl As New clsDevuelveTabla
        tbl.sqlString = "select idUsuario,nombre,superUsuario from tblUsuarios where bloqueado = 0 and nombre = '" & Me.txtUsuario.Text & "'"
        If tbl.Tabla.Rows.Count = 0 Then
            MessageBox.Show("Solicite privilegios a su administrador !!!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Function
        End If

        mdlPublicVars.idUsuario = tbl.Tabla.Rows(0).Item(0)
        mdlPublicVars.superUsuario = tbl.Tabla.Rows(0).Item(2)
        Return True

    End Function

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtUsuario.Focus()
        Me.txtUsuario.Focus()
    End Sub
End Class
