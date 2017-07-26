'------------------------------------------------------------------------------
' Clase clsTipoMovimiento generada autom�ticamente con CrearClaseSQL
' de la tabla 'tblTipoMovimiento' de la base 'bdagua'
' Fecha: 01/may/2010 18:48:15
'
' �Guillermo 'guille' Som, 2004-2010
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class clsTipoMovimiento
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idTipoMovimiento As System.Int16
    Private _nombre As System.String
    Private _entrada As System.Boolean
    Private _generaFactura As System.Boolean
    '
    ' Este m�todo se usar� para ajustar los anchos de las propiedades
    Private Function ajustarAncho(ByVal cadena As String, ByVal ancho As Integer) As String
        Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
        ' devolver la cadena quitando los espacios en blanco
        ' esto asegura que no se devolver� un tama�o mayor ni espacios "extras"
        Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
    End Function
    '
    ' Las propiedades p�blicas
    ' TODO: Revisar los tipos de las propiedades
    Public Property idTipoMovimiento() As System.Int16
        Get
            Return _idTipoMovimiento
        End Get
        Set(ByVal value As System.Int16)
            _idTipoMovimiento = value
        End Set
    End Property
    Public Property nombre() As System.String
        Get
            Return ajustarAncho(_nombre, 100)
        End Get
        Set(ByVal value As System.String)
            _nombre = value
        End Set
    End Property
    Public Property entrada() As System.Boolean
        Get
            Return _entrada
        End Get
        Set(ByVal value As System.Boolean)
            _entrada = value
        End Set
    End Property
    Public Property generaFactura() As System.Boolean
        Get
            Return _generaFactura
        End Get
        Set(ByVal value As System.Boolean)
            _generaFactura = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el �ndice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idTipoMovimiento.ToString()
            ElseIf index = 1 Then
                Return Me.nombre.ToString()
            ElseIf index = 2 Then
                Return Me.entrada.ToString()
            ElseIf index = 3 Then
                Return Me.generaFactura.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idTipoMovimiento = System.Int16.Parse("0" & value)
                Catch
                    Me.idTipoMovimiento = System.Int16.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.nombre = value
            ElseIf index = 2 Then
                Try
                    Me.entrada = System.Boolean.Parse(value)
                Catch
                    Me.entrada = False
                End Try
            ElseIf index = 3 Then
                Try
                    Me.generaFactura = System.Boolean.Parse(value)
                Catch
                    Me.generaFactura = False
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el �ndice corresponde al nombre de la columna)
        Get
            If index = "idTipoMovimiento" Then
                Return Me.idTipoMovimiento.ToString()
            ElseIf index = "nombre" Then
                Return Me.nombre.ToString()
            ElseIf index = "entrada" Then
                Return Me.entrada.ToString()
            ElseIf index = "generaFactura" Then
                Return Me.generaFactura.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idTipoMovimiento" Then
                Try
                    Me.idTipoMovimiento = System.Int16.Parse("0" & value)
                Catch
                    Me.idTipoMovimiento = System.Int16.Parse("0")
                End Try
            ElseIf index = "nombre" Then
                Me.nombre = value
            ElseIf index = "entrada" Then
                Try
                    Me.entrada = System.Boolean.Parse(value)
                Catch
                    Me.entrada = False
                End Try
            ElseIf index = "generaFactura" Then
                Try
                    Me.generaFactura = System.Boolean.Parse(value)
                Catch
                    Me.generaFactura = False
                End Try
            End If
        End Set
    End Property
    '
    ' Campos y m�todos compartidos (est�ticos) para gestionar la base de datos
    '
    ' La cadena de conexi�n a la base de datos
    Private Shared cadenaConexion As String = mdlPublicVars.cnn
    ' La cadena de selecci�n
    Public Shared CadenaSelect As String = "SELECT * FROM tblTipoMovimiento"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' M�todos compartidos (est�ticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsTipoMovimiento
    Private Shared Function row2clsTipoMovimiento(ByVal r As DataRow) As clsTipoMovimiento
        ' asigna a un objeto clsTipoMovimiento los datos del dataRow indicado
        Dim oclsTipoMovimiento As New clsTipoMovimiento
        '
        oclsTipoMovimiento.idTipoMovimiento = System.Int16.Parse("0" & r("idTipoMovimiento").ToString())
        oclsTipoMovimiento.nombre = r("nombre").ToString()
        Try
            oclsTipoMovimiento.entrada = System.Boolean.Parse(r("entrada").ToString())
        Catch
            oclsTipoMovimiento.entrada = False
        End Try
        Try
            oclsTipoMovimiento.generaFactura = System.Boolean.Parse(r("generaFactura").ToString())
        Catch
            oclsTipoMovimiento.generaFactura = False
        End Try
        '
        Return oclsTipoMovimiento
    End Function
    '
    ' asigna un objeto clsTipoMovimiento a la fila indicada
    Private Shared Sub clsTipoMovimiento2Row(ByVal oclsTipoMovimiento As clsTipoMovimiento, ByVal r As DataRow)
        ' asigna un objeto clsTipoMovimiento al dataRow indicado
        ' TODO: Comprueba si esta asignaci�n debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o �nico
        'r("idTipoMovimiento") = oclsTipoMovimiento.idTipoMovimiento
        r("nombre") = oclsTipoMovimiento.nombre
        r("entrada") = oclsTipoMovimiento.entrada
        r("generaFactura") = oclsTipoMovimiento.generaFactura
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsTipoMovimiento
    Private Shared Sub nuevoclsTipoMovimiento(ByVal dt As DataTable, ByVal oclsTipoMovimiento As clsTipoMovimiento)
        ' Crear un nuevo clsTipoMovimiento
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsTipoMovimiento = row2clsTipoMovimiento(dr)
        '
        oc.idTipoMovimiento = oclsTipoMovimiento.idTipoMovimiento
        oc.nombre = oclsTipoMovimiento.nombre
        oc.entrada = oclsTipoMovimiento.entrada
        oc.generaFactura = oclsTipoMovimiento.generaFactura
        '
        clsTipoMovimiento2Row(oc, dr)
        '
        dt.Rows.Add(dr)
    End Sub
    '
    ' M�todos p�blicos
    '
    ' devuelve una tabla con los datos indicados en la cadena de selecci�n
    Public Shared Function Tabla() As DataTable
        Return Tabla(CadenaSelect)
    End Function
    Public Shared Function Tabla(ByVal sel As String) As DataTable
        ' devuelve una tabla con los datos de la tabla tblTipoMovimiento
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsTipoMovimiento")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsTipoMovimiento
        ' Busca en la tabla los datos indicados en el par�metro
        ' el par�metro contendr� lo que se usar� despu�s del WHERE
        Dim oclsTipoMovimiento As clsTipoMovimiento = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsTipoMovimiento")
        Dim sel As String = "SELECT * FROM tblTipoMovimiento WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsTipoMovimiento = row2clsTipoMovimiento(dt.Rows(0))
        End If
        Return oclsTipoMovimiento
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se crear� uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idTipoMovimiento existe en la tabla.
    '             TODO: Si en lugar de idTipoMovimiento usas otro campo, indicalo en la cadena SELECT
    '                   Tambi�n puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        '       yo uso el idTipoMovimiento que es el identificador �nico de cada registro
        Dim sel As String = "SELECT * FROM tblTipoMovimiento WHERE idTipoMovimiento = " & Me.idTipoMovimiento.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El par�metro, que es una cadena de selecci�n, indicar� el criterio de actualizaci�n
        '
        ' En caso de error, devolver� la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsTipoMovimiento")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando UPDATE
        ' TODO: Comprobar cual es el campo de �ndice principal (sin duplicados)
        '       Yo compruebo que sea un campo llamado idTipoMovimiento, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idTipoMovimiento) ser� el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblTipoMovimiento SET nombre = @nombre, entrada = @entrada, generaFactura = @generaFactura  WHERE (idTipoMovimiento = @idTipoMovimiento)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idTipoMovimiento", SqlDbType.SmallInt, 0, "idTipoMovimiento")
        da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@entrada", SqlDbType.Bit, 0, "entrada")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@generaFactura", SqlDbType.Bit, 0, "generaFactura")
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
            clsTipoMovimiento2Row(Me, dt.Rows(0))
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
        ' En caso de error, devolver� la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsTipoMovimiento")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando INSERT
        ' TODO: No incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado idTipoMovimiento, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblTipoMovimiento (nombre, entrada, generaFactura)  VALUES(@nombre, @entrada, @generaFactura)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idTipoMovimiento", SqlDbType.SmallInt, 0, "idTipoMovimiento")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@entrada", SqlDbType.Bit, 0, "entrada")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@generaFactura", SqlDbType.Bit, 0, "generaFactura")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsTipoMovimiento(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsTipoMovimiento"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        '       yo uso el idTipoMovimiento que es el identificador �nico de cada registro
        Dim sel As String = "SELECT * FROM tblTipoMovimiento WHERE idTipoMovimiento = " & Me.idTipoMovimiento.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolver� la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsTipoMovimiento")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la m�s �ptima, pero funcionar�
        '-------------------------------------------
        'Dim cb As New SqlCommandBuilder(da)
        'da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta est� m�s optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        Dim sCommand As String
        '
        ' El comando DELETE
        ' TODO: S�lo incluir el campo de clave primaria incremental
        '       Yo compruebo que sea un campo llamado idTipoMovimiento, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblTipoMovimiento WHERE (idTipoMovimiento = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.SmallInt, 0, "idTipoMovimiento")
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
