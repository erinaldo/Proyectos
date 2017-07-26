'------------------------------------------------------------------------------
' Clase clsAsignacionContador generada autom�ticamente con CrearClaseSQL
' de la tabla 'tblAsignacionContador' de la base 'bdAgua'
' Fecha: 04/may/2009 14:30:05
'
' �Guillermo 'guille' Som, 2004-2009
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class clsAsignacionContador
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idAsignacionContador As System.Int64
    Private _idAsignacion As System.Int32
    Private _idContador As System.Int32
    Private _lecturaInicial As System.Decimal
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
    Public Property idAsignacionContador() As System.Int64
        Get
            Return _idAsignacionContador
        End Get
        Set(ByVal value As System.Int64)
            _idAsignacionContador = value
        End Set
    End Property
    Public Property idAsignacion() As System.Int32
        Get
            Return _idAsignacion
        End Get
        Set(ByVal value As System.Int32)
            _idAsignacion = value
        End Set
    End Property
    Public Property idContador() As System.Int32
        Get
            Return _idContador
        End Get
        Set(ByVal value As System.Int32)
            _idContador = value
        End Set
    End Property
    Public Property lecturaInicial() As System.Decimal
        Get
            Return _lecturaInicial
        End Get
        Set(ByVal value As System.Decimal)
            _lecturaInicial = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el �ndice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idAsignacionContador.ToString()
            ElseIf index = 1 Then
                Return Me.idAsignacion.ToString()
            ElseIf index = 2 Then
                Return Me.idContador.ToString()
            ElseIf index = 3 Then
                Return Me.lecturaInicial.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idAsignacionContador = System.Int64.Parse("0" & value)
                Catch
                    Me.idAsignacionContador = System.Int64.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.idAsignacion = System.Int32.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int32.Parse("0")
                End Try
            ElseIf index = 2 Then
                Try
                    Me.idContador = System.Int32.Parse("0" & value)
                Catch
                    Me.idContador = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.lecturaInicial = System.Decimal.Parse("0" & value)
                Catch
                    Me.lecturaInicial = System.Decimal.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el �ndice corresponde al nombre de la columna)
        Get
            If index = "idAsignacionContador" Then
                Return Me.idAsignacionContador.ToString()
            ElseIf index = "idAsignacion" Then
                Return Me.idAsignacion.ToString()
            ElseIf index = "idContador" Then
                Return Me.idContador.ToString()
            ElseIf index = "lecturaInicial" Then
                Return Me.lecturaInicial.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idAsignacionContador" Then
                Try
                    Me.idAsignacionContador = System.Int64.Parse("0" & value)
                Catch
                    Me.idAsignacionContador = System.Int64.Parse("0")
                End Try
            ElseIf index = "idAsignacion" Then
                Try
                    Me.idAsignacion = System.Int32.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int32.Parse("0")
                End Try
            ElseIf index = "idContador" Then
                Try
                    Me.idContador = System.Int32.Parse("0" & value)
                Catch
                    Me.idContador = System.Int32.Parse("0")
                End Try
            ElseIf index = "lecturaInicial" Then
                Try
                    Me.lecturaInicial = System.Decimal.Parse("0" & value)
                Catch
                    Me.lecturaInicial = System.Decimal.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM tblAsignacionContador"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' M�todos compartidos (est�ticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsAsignacionContador
    Private Shared Function row2clsAsignacionContador(ByVal r As DataRow) As clsAsignacionContador
        ' asigna a un objeto clsAsignacionContador los datos del dataRow indicado
        Dim oclsAsignacionContador As New clsAsignacionContador
        '
        oclsAsignacionContador.idAsignacionContador = System.Int64.Parse("0" & r("idAsignacionContador").ToString())
        oclsAsignacionContador.idAsignacion = System.Int32.Parse("0" & r("idAsignacion").ToString())
        oclsAsignacionContador.idContador = System.Int32.Parse("0" & r("idContador").ToString())
        oclsAsignacionContador.lecturaInicial = System.Decimal.Parse("0" & r("lecturaInicial").ToString())
        '
        Return oclsAsignacionContador
    End Function
    '
    ' asigna un objeto clsAsignacionContador a la fila indicada
    Private Shared Sub clsAsignacionContador2Row(ByVal oclsAsignacionContador As clsAsignacionContador, ByVal r As DataRow)
        ' asigna un objeto clsAsignacionContador al dataRow indicado
        ' TODO: Comprueba si esta asignaci�n debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o �nico
        'r("idAsignacionContador") = oclsAsignacionContador.idAsignacionContador
        r("idAsignacion") = oclsAsignacionContador.idAsignacion
        r("idContador") = oclsAsignacionContador.idContador
        r("lecturaInicial") = oclsAsignacionContador.lecturaInicial
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsAsignacionContador
    Private Shared Sub nuevoclsAsignacionContador(ByVal dt As DataTable, ByVal oclsAsignacionContador As clsAsignacionContador)
        ' Crear un nuevo clsAsignacionContador
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsAsignacionContador = row2clsAsignacionContador(dr)
        '
        oc.idAsignacionContador = oclsAsignacionContador.idAsignacionContador
        oc.idAsignacion = oclsAsignacionContador.idAsignacion
        oc.idContador = oclsAsignacionContador.idContador
        oc.lecturaInicial = oclsAsignacionContador.lecturaInicial
        '
        clsAsignacionContador2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblAsignacionContador
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsAsignacionContador")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsAsignacionContador
        ' Busca en la tabla los datos indicados en el par�metro
        ' el par�metro contendr� lo que se usar� despu�s del WHERE
        Dim oclsAsignacionContador As clsAsignacionContador = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsAsignacionContador")
        Dim sel As String = "SELECT * FROM tblAsignacionContador WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsAsignacionContador = row2clsAsignacionContador(dt.Rows(0))
        End If
        Return oclsAsignacionContador
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se crear� uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idAsignacionContador existe en la tabla.
    '             TODO: Si en lugar de idAsignacionContador usas otro campo, indicalo en la cadena SELECT
    '                   Tambi�n puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        '       yo uso el idAsignacionContador que es el identificador �nico de cada registro
        Dim sel As String = "SELECT * FROM tblAsignacionContador WHERE idAsignacionContador = " & Me.idAsignacionContador.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El par�metro, que es una cadena de selecci�n, indicar� el criterio de actualizaci�n
        '
        ' En caso de error, devolver� la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsAsignacionContador")
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
        '       Yo compruebo que sea un campo llamado idAsignacionContador, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idAsignacionContador) ser� el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblAsignacionContador SET idAsignacion = @idAsignacion, idContador = @idContador, lecturaInicial = @lecturaInicial  WHERE (idAsignacionContador = @idAsignacionContador)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idAsignacionContador", SqlDbType.BigInt, 0, "idAsignacionContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idAsignacion", SqlDbType.Int, 0, "idAsignacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idContador", SqlDbType.Int, 0, "idContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@lecturaInicial", SqlDbType.Decimal, 0, "lecturaInicial")
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
            clsAsignacionContador2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsAsignacionContador")
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
        '       Yo compruebo que sea un campo llamado idAsignacionContador, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblAsignacionContador (idAsignacion, idContador, lecturaInicial)  VALUES(@idAsignacion, @idContador, @lecturaInicial)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idAsignacionContador", SqlDbType.BigInt, 0, "idAsignacionContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idAsignacion", SqlDbType.Int, 0, "idAsignacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idContador", SqlDbType.Int, 0, "idContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@lecturaInicial", SqlDbType.Decimal, 0, "lecturaInicial")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsAsignacionContador(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsAsignacionContador"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        '       yo uso el idAsignacionContador que es el identificador �nico de cada registro
        Dim sel As String = "SELECT * FROM tblAsignacionContador WHERE idAsignacionContador = " & Me.idAsignacionContador.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolver� la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsAsignacionContador")
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
        '       Yo compruebo que sea un campo llamado idAsignacionContador, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblAsignacionContador WHERE (idAsignacionContador = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.BigInt, 0, "idAsignacionContador")
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
