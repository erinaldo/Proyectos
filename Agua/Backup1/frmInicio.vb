Public NotInheritable Class frmInicio

    'TODO: Este formulario se puede establecer fácilmente como pantalla de bienvenida para la aplicación desde la ficha "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub frmInicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure el texto del cuadro de diálogo en tiempo de ejecución según la información del ensamblado de la aplicación.  

        'TODO: Personalice la información del ensamblado de la aplicación en el panel "Aplicación" del cuadro de diálogo 
        '  propiedades del proyecto (bajo el menú "Proyecto").

        'Título de la aplicación
        If My.Application.Info.Title <> "" Then
            'ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            'ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Dé formato a la información de versión usando el texto establecido en el control de versión en tiempo de diseño como
        '  cadena de formato. Esto le permite una localización efectiva si lo desea.
        '  Se pudo incluir la información de generación y revisión usando el siguiente código y cambiando el 
        '  texto en tiempo de diseño del control de versión a "Versión {0}.{1:00}.{2}.{3}" o algo parecido. Consulte
        '  String.Format() en la Ayuda para obtener más información.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Información de Copyright
        'Copyright.Text = My.Application.Info.Copyright

        If llenaPublicVars() = False Then
            MsgBox("Ocurrio un error al conectar BD !!!", MsgBoxStyle.Critical, "!!!")
            Exit Sub
        End If

    End Sub

    Protected Function llenaPublicVars() As Boolean
        llenaPublicVars = False
        Try
            Dim xmlConfig As String = "config.xml"
            Dim ds As New System.Data.DataSet
            ds.ReadXml(xmlConfig)
            Dim dr As System.Data.DataRow
            For Each dr In ds.Tables(0).Rows
                mdlPublicVars.servidor = dr.Item(0)
                mdlPublicVars.bd = dr.Item(1)
            Next
            llenaPublicVars = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
        End Try



    End Function
End Class
