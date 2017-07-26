'------------------------------------------------------------------------------
' Clase clsConfiguracion generada automáticamente con CrearClaseSQL
' de la tabla 'tblConfiguracion' de la base 'bdAgua'
' Fecha: 12/abr/2009 21:34:09
'
' ©Guillermo 'guille' Som, 2004-2009
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class clsConfiguracion
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idConfiguracion As System.Int16
    Private _iva As System.Decimal
    Private _corrConvenio As System.Int32
    Private _corrFactura As System.Int32
    Private _corrNotaCobro As System.Int32
    Private _corrNotaCredito As System.Int32
    Private _serieFactura As System.String
    '
    ' Este método se usará para ajustar los anchos de las propiedades
    Private Function ajustarAncho(ByVal cadena As String, ByVal ancho As Integer) As String
        Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
        ' devolver la cadena quitando los espacios en blanco
        ' esto asegura que no se devolverá un tamaño mayor ni espacios "extras"
        Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
    End Function
    '
    ' Las propiedades públicas
    ' TODO: Revisar los tipos de las propiedades
    Public Property idConfiguracion() As System.Int16
        Get
            Return _idConfiguracion
        End Get
        Set(ByVal value As System.Int16)
            _idConfiguracion = value
        End Set
    End Property
    Public Property iva() As System.Decimal
        Get
            Return _iva
        End Get
        Set(ByVal value As System.Decimal)
            _iva = value
        End Set
    End Property
    Public Property corrConvenio() As System.Int32
        Get
            Return _corrConvenio
        End Get
        Set(ByVal value As System.Int32)
            _corrConvenio = value
        End Set
    End Property
    Public Property corrFactura() As System.Int32
        Get
            Return _corrFactura
        End Get
        Set(ByVal value As System.Int32)
            _corrFactura = value
        End Set
    End Property
    Public Property corrNotaCobro() As System.Int32
        Get
            Return _corrNotaCobro
        End Get
        Set(ByVal value As System.Int32)
            _corrNotaCobro = value
        End Set
    End Property
    Public Property corrNotaCredito() As System.Int32
        Get
            Return _corrNotaCredito
        End Get
        Set(ByVal value As System.Int32)
            _corrNotaCredito = value
        End Set
    End Property
    Public Property serieFactura() As System.String
        Get
            Return ajustarAncho(_serieFactura, 25)
        End Get
        Set(ByVal value As System.String)
            _serieFactura = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idConfiguracion.ToString()
            ElseIf index = 1 Then
                Return Me.iva.ToString()
            ElseIf index = 2 Then
                Return Me.corrConvenio.ToString()
            ElseIf index = 3 Then
                Return Me.corrFactura.ToString()
            ElseIf index = 4 Then
                Return Me.corrNotaCobro.ToString()
            ElseIf index = 5 Then
                Return Me.corrNotaCredito.ToString()
            ElseIf index = 6 Then
                Return Me.serieFactura.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idConfiguracion = System.Int16.Parse("0" & value)
                Catch
                    Me.idConfiguracion = System.Int16.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.iva = System.Decimal.Parse("0" & value)
                Catch
                    Me.iva = System.Decimal.Parse("0")
                End Try
            ElseIf index = 2 Then
                Try
                    Me.corrConvenio = System.Int32.Parse("0" & value)
                Catch
                    Me.corrConvenio = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.corrFactura = System.Int32.Parse("0" & value)
                Catch
                    Me.corrFactura = System.Int32.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.corrNotaCobro = System.Int32.Parse("0" & value)
                Catch
                    Me.corrNotaCobro = System.Int32.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.corrNotaCredito = System.Int32.Parse("0" & value)
                Catch
                    Me.corrNotaCredito = System.Int32.Parse("0")
                End Try
            ElseIf index = 6 Then
                Me.serieFactura = value
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idConfiguracion" Then
                Return Me.idConfiguracion.ToString()
            ElseIf index = "iva" Then
                Return Me.iva.ToString()
            ElseIf index = "corrConvenio" Then
                Return Me.corrConvenio.ToString()
            ElseIf index = "corrFactura" Then
                Return Me.corrFactura.ToString()
            ElseIf index = "corrNotaCobro" Then
                Return Me.corrNotaCobro.ToString()
            ElseIf index = "corrNotaCredito" Then
                Return Me.corrNotaCredito.ToString()
            ElseIf index = "serieFactura" Then
                Return Me.serieFactura.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idConfiguracion" Then
                Try
                    Me.idConfiguracion = System.Int16.Parse("0" & value)
                Catch
                    Me.idConfiguracion = System.Int16.Parse("0")
                End Try
            ElseIf index = "iva" Then
                Try
                    Me.iva = System.Decimal.Parse("0" & value)
                Catch
                    Me.iva = System.Decimal.Parse("0")
                End Try
            ElseIf index = "corrConvenio" Then
                Try
                    Me.corrConvenio = System.Int32.Parse("0" & value)
                Catch
                    Me.corrConvenio = System.Int32.Parse("0")
                End Try
            ElseIf index = "corrFactura" Then
                Try
                    Me.corrFactura = System.Int32.Parse("0" & value)
                Catch
                    Me.corrFactura = System.Int32.Parse("0")
                End Try
            ElseIf index = "corrNotaCobro" Then
                Try
                    Me.corrNotaCobro = System.Int32.Parse("0" & value)
                Catch
                    Me.corrNotaCobro = System.Int32.Parse("0")
                End Try
            ElseIf index = "corrNotaCredito" Then
                Try
                    Me.corrNotaCredito = System.Int32.Parse("0" & value)
                Catch
                    Me.corrNotaCredito = System.Int32.Parse("0")
                End Try
            ElseIf index = "serieFactura" Then
                Me.serieFactura = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = mdlPublicVars.cnn
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM tblConfiguracion"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsConfiguracion
    Private Shared Function row2clsConfiguracion(ByVal r As DataRow) As clsConfiguracion
        ' asigna a un objeto clsConfiguracion los datos del dataRow indicado
        Dim oclsConfiguracion As New clsConfiguracion
        '
        oclsConfiguracion.idConfiguracion = System.Int16.Parse("0" & r("idConfiguracion").ToString())
        oclsConfiguracion.iva = System.Decimal.Parse("0" & r("iva").ToString())
        oclsConfiguracion.corrConvenio = System.Int32.Parse("0" & r("corrConvenio").ToString())
        oclsConfiguracion.corrFactura = System.Int32.Parse("0" & r("corrFactura").ToString())
        oclsConfiguracion.corrNotaCobro = System.Int32.Parse("0" & r("corrNotaCobro").ToString())
        oclsConfiguracion.corrNotaCredito = System.Int32.Parse("0" & r("corrNotaCredito").ToString())
        oclsConfiguracion.serieFactura = r("serieFactura").ToString()
        '
        Return oclsConfiguracion
    End Function
    '
    ' asigna un objeto clsConfiguracion a la fila indicada
    Private Shared Sub clsConfiguracion2Row(ByVal oclsConfiguracion As clsConfiguracion, ByVal r As DataRow)
        ' asigna un objeto clsConfiguracion al dataRow indicado
        r("idConfiguracion") = oclsConfiguracion.idConfiguracion
        r("iva") = oclsConfiguracion.iva
        r("corrConvenio") = oclsConfiguracion.corrConvenio
        r("corrFactura") = oclsConfiguracion.corrFactura
        r("corrNotaCobro") = oclsConfiguracion.corrNotaCobro
        r("corrNotaCredito") = oclsConfiguracion.corrNotaCredito
        r("serieFactura") = oclsConfiguracion.serieFactura
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsConfiguracion
    Private Shared Sub nuevoclsConfiguracion(ByVal dt As DataTable, ByVal oclsConfiguracion As clsConfiguracion)
        ' Crear un nuevo clsConfiguracion
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsConfiguracion = row2clsConfiguracion(dr)
        '
        oc.idConfiguracion = oclsConfiguracion.idConfiguracion
        oc.iva = oclsConfiguracion.iva
        oc.corrConvenio = oclsConfiguracion.corrConvenio
        oc.corrFactura = oclsConfiguracion.corrFactura
        oc.corrNotaCobro = oclsConfiguracion.corrNotaCobro
        oc.corrNotaCredito = oclsConfiguracion.corrNotaCredito
        oc.serieFactura = oclsConfiguracion.serieFactura
        '
        clsConfiguracion2Row(oc, dr)
        '
        dt.Rows.Add(dr)
    End Sub
    '
    ' Métodos públicos
    '
    ' devuelve una tabla con los datos indicados en la cadena de selección
    Public Shared Function Tabla() As DataTable
        Return Tabla(CadenaSelect)
    End Function
    Public Shared Function Tabla(ByVal sel As String) As DataTable
        ' devuelve una tabla con los datos de la tabla tblConfiguracion
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsConfiguracion")
        '
        Try
            da = New SqlDataAdapter(sel, cadenaConexion)
            da.Fill(dt)
        Catch
            Return Nothing
        End Try
        '
        Return dt
    End Function
    '
    Public Shared Function Buscar(ByVal sWhere As String) As clsConfiguracion
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsConfiguracion As clsConfiguracion = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsConfiguracion")
        Dim sel As String = "SELECT * FROM tblConfiguracion WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsConfiguracion = row2clsConfiguracion(dt.Rows(0))
        End If
        Return oclsConfiguracion
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idConfiguracion existe en la tabla.
    '             TODO: Si en lugar de idConfiguracion usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idConfiguracion que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblConfiguracion WHERE idConfiguracion = " & Me.idConfiguracion.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsConfiguracion")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando UPDATE
        ' TODO: Comprobar cual es el campo de índice principal (sin duplicados)
        '       Yo compruebo que sea un campo llamado idConfiguracion, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idConfiguracion) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblConfiguracion SET iva = @iva, corrConvenio = @corrConvenio, corrFactura = @corrFactura, corrNotaCobro = @corrNotaCobro, corrNotaCredito = @corrNotaCredito, serieFactura = @serieFactura  WHERE (idConfiguracion = @idConfiguracion)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idConfiguracion", SqlDbType.SmallInt, 0, "idConfiguracion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@iva", SqlDbType.Decimal, 0, "iva")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@corrConvenio", SqlDbType.Int, 0, "corrConvenio")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@corrFactura", SqlDbType.Int, 0, "corrFactura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@corrNotaCobro", SqlDbType.Int, 0, "corrNotaCobro")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@corrNotaCredito", SqlDbType.Int, 0, "corrNotaCredito")
        da.UpdateCommand.Parameters.Add("@serieFactura", SqlDbType.NVarChar, 25, "serieFactura")
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        If dt.Rows.Count = 0 Then
            ' crear uno nuevo
            Return Crear()
        Else
            clsConfiguracion2Row(Me, dt.Rows(0))
        End If
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Actualizado correctamente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Crear() As String
        ' Crear un nuevo registro
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsConfiguracion")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando INSERT
        ' TODO: No incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado idConfiguracion, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblConfiguracion (idConfiguracion, iva, corrConvenio, corrFactura, corrNotaCobro, corrNotaCredito, serieFactura)  VALUES(@idConfiguracion, @iva, @corrConvenio, @corrFactura, @corrNotaCobro, @corrNotaCredito, @serieFactura)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idConfiguracion", SqlDbType.SmallInt, 0, "idConfiguracion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.Decimal, 0, "iva")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@corrConvenio", SqlDbType.Int, 0, "corrConvenio")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@corrFactura", SqlDbType.Int, 0, "corrFactura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@corrNotaCobro", SqlDbType.Int, 0, "corrNotaCobro")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@corrNotaCredito", SqlDbType.Int, 0, "corrNotaCredito")
        da.InsertCommand.Parameters.Add("@serieFactura", SqlDbType.NVarChar, 25, "serieFactura")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsConfiguracion(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsConfiguracion"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idConfiguracion que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblConfiguracion WHERE idConfiguracion = " & Me.idConfiguracion.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsConfiguracion")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando DELETE
        ' TODO: Sólo incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado idConfiguracion, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblConfiguracion WHERE (idConfiguracion = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.SmallInt, 0, "idConfiguracion")
        'da.DeleteCommand.Parameters.Add("@p2", SqlDbType.Int, 0, "")
        '
        '
        da.Fill(dt)
        '
        If dt.Rows.Count = 0 Then
            Return "ERROR: No hay datos"
        Else
            dt.Rows(0).Delete()
        End If
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Borrado satisfactoriamente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
End Class
