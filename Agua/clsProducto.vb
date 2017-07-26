'------------------------------------------------------------------------------
' Clase clsProducto generada automáticamente con CrearClaseSQL
' de la tabla 'tblProducto' de la base 'bdagua'
' Fecha: 01/may/2010 18:05:59
'
' ©Guillermo 'guille' Som, 2004-2010
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class clsProducto
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idProducto As System.Int64
    Private _nombre As System.String
    Private _precio As System.Decimal
    Private _existencia As System.Int64
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
    Public Property idProducto() As System.Int64
        Get
            Return _idProducto
        End Get
        Set(ByVal value As System.Int64)
            _idProducto = value
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
    Public Property precio() As System.Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As System.Decimal)
            _precio = value
        End Set
    End Property
    Public Property existencia() As System.Int64
        Get
            Return _existencia
        End Get
        Set(ByVal value As System.Int64)
            _existencia = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idProducto.ToString()
            ElseIf index = 1 Then
                Return Me.nombre.ToString()
            ElseIf index = 2 Then
                Return Me.precio.ToString()
            ElseIf index = 3 Then
                Return Me.existencia.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idProducto = System.Int64.Parse("0" & value)
                Catch
                    Me.idProducto = System.Int64.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.nombre = value
            ElseIf index = 2 Then
                Try
                    Me.precio = System.Decimal.Parse("0" & value)
                Catch
                    Me.precio = System.Decimal.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.existencia = System.Int64.Parse("0" & value)
                Catch
                    Me.existencia = System.Int64.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idProducto" Then
                Return Me.idProducto.ToString()
            ElseIf index = "nombre" Then
                Return Me.nombre.ToString()
            ElseIf index = "precio" Then
                Return Me.precio.ToString()
            ElseIf index = "existencia" Then
                Return Me.existencia.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idProducto" Then
                Try
                    Me.idProducto = System.Int64.Parse("0" & value)
                Catch
                    Me.idProducto = System.Int64.Parse("0")
                End Try
            ElseIf index = "nombre" Then
                Me.nombre = value
            ElseIf index = "precio" Then
                Try
                    Me.precio = System.Decimal.Parse("0" & value)
                Catch
                    Me.precio = System.Decimal.Parse("0")
                End Try
            ElseIf index = "existencia" Then
                Try
                    Me.existencia = System.Int64.Parse("0" & value)
                Catch
                    Me.existencia = System.Int64.Parse("0")
                End Try
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = mdlPublicVars.cnn
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM tblProducto"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsProducto
    Private Shared Function row2clsProducto(ByVal r As DataRow) As clsProducto
        ' asigna a un objeto clsProducto los datos del dataRow indicado
        Dim oclsProducto As New clsProducto
        '
        oclsProducto.idProducto = System.Int64.Parse("0" & r("idProducto").ToString())
        oclsProducto.nombre = r("nombre").ToString()
        oclsProducto.precio = System.Decimal.Parse("0" & r("precio").ToString())
        oclsProducto.existencia = System.Int64.Parse("0" & r("existencia").ToString())
        '
        Return oclsProducto
    End Function
    '
    ' asigna un objeto clsProducto a la fila indicada
    Private Shared Sub clsProducto2Row(ByVal oclsProducto As clsProducto, ByVal r As DataRow)
        ' asigna un objeto clsProducto al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idProducto") = oclsProducto.idProducto
        r("nombre") = oclsProducto.nombre
        r("precio") = oclsProducto.precio
        r("existencia") = oclsProducto.existencia
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsProducto
    Private Shared Sub nuevoclsProducto(ByVal dt As DataTable, ByVal oclsProducto As clsProducto)
        ' Crear un nuevo clsProducto
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsProducto = row2clsProducto(dr)
        '
        oc.idProducto = oclsProducto.idProducto
        oc.nombre = oclsProducto.nombre
        oc.precio = oclsProducto.precio
        oc.existencia = oclsProducto.existencia
        '
        clsProducto2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblProducto
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsProducto")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsProducto
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsProducto As clsProducto = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsProducto")
        Dim sel As String = "SELECT * FROM tblProducto WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsProducto = row2clsProducto(dt.Rows(0))
        End If
        Return oclsProducto
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idProducto existe en la tabla.
    '             TODO: Si en lugar de idProducto usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idProducto que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblProducto WHERE idProducto = " & Me.idProducto.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsProducto")
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
        '       Yo compruebo que sea un campo llamado idProducto, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idProducto) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblProducto SET nombre = @nombre, precio = @precio   WHERE (idProducto = @idProducto)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idProducto", SqlDbType.BigInt, 0, "idProducto")
        da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@precio", SqlDbType.Decimal, 0, "precio")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@existencia", SqlDbType.BigInt, 0, "existencia")
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
            clsProducto2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsProducto")
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
        '       Yo compruebo que sea un campo llamado idProducto, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblProducto (nombre, precio, existencia)  VALUES(@nombre, @precio, @existencia)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idProducto", SqlDbType.BigInt, 0, "idProducto")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@precio", SqlDbType.Decimal, 0, "precio")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@existencia", SqlDbType.BigInt, 0, "existencia")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsProducto(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsProducto"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idProducto que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblProducto WHERE idProducto = " & Me.idProducto.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsProducto")
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
        '       Yo compruebo que sea un campo llamado idProducto, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblProducto WHERE (idProducto = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.BigInt, 0, "idProducto")
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
