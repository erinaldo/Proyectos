'------------------------------------------------------------------------------
' Clase clsEmpleado generada automáticamente con CrearClaseSQL
' de la tabla 'tblEmpleado' de la base 'bdAgua'
' Fecha: 12/abr/2009 21:23:31
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
Public Class clsEmpleado
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idEmpleado As System.Int32
    Private _nombre As System.String
    Private _direccion As System.String
    Private _telefono As System.String
    Private _bloqueado As System.Boolean
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
    Public Property idEmpleado() As System.Int32
        Get
            Return _idEmpleado
        End Get
        Set(ByVal value As System.Int32)
            _idEmpleado = value
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
    Public Property direccion() As System.String
        Get
            Return ajustarAncho(_direccion, 100)
        End Get
        Set(ByVal value As System.String)
            _direccion = value
        End Set
    End Property
    Public Property telefono() As System.String
        Get
            Return ajustarAncho(_telefono, 50)
        End Get
        Set(ByVal value As System.String)
            _telefono = value
        End Set
    End Property
    Public Property bloqueado() As System.Boolean
        Get
            Return _bloqueado
        End Get
        Set(ByVal value As System.Boolean)
            _bloqueado = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idEmpleado.ToString()
            ElseIf index = 1 Then
                Return Me.nombre.ToString()
            ElseIf index = 2 Then
                Return Me.direccion.ToString()
            ElseIf index = 3 Then
                Return Me.telefono.ToString()
            ElseIf index = 4 Then
                Return Me.bloqueado.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idEmpleado = System.Int32.Parse("0" & value)
                Catch
                    Me.idEmpleado = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.nombre = value
            ElseIf index = 2 Then
                Me.direccion = value
            ElseIf index = 3 Then
                Me.telefono = value
            ElseIf index = 4 Then
                Try
                    Me.bloqueado = System.Boolean.Parse(value)
                Catch
                    Me.bloqueado = False
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idEmpleado" Then
                Return Me.idEmpleado.ToString()
            ElseIf index = "nombre" Then
                Return Me.nombre.ToString()
            ElseIf index = "direccion" Then
                Return Me.direccion.ToString()
            ElseIf index = "telefono" Then
                Return Me.telefono.ToString()
            ElseIf index = "bloqueado" Then
                Return Me.bloqueado.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idEmpleado" Then
                Try
                    Me.idEmpleado = System.Int32.Parse("0" & value)
                Catch
                    Me.idEmpleado = System.Int32.Parse("0")
                End Try
            ElseIf index = "nombre" Then
                Me.nombre = value
            ElseIf index = "direccion" Then
                Me.direccion = value
            ElseIf index = "telefono" Then
                Me.telefono = value
            ElseIf index = "bloqueado" Then
                Try
                    Me.bloqueado = System.Boolean.Parse(value)
                Catch
                    Me.bloqueado = False
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
    Public Shared CadenaSelect As String = "SELECT * FROM tblEmpleado"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsEmpleado
    Private Shared Function row2clsEmpleado(ByVal r As DataRow) As clsEmpleado
        ' asigna a un objeto clsEmpleado los datos del dataRow indicado
        Dim oclsEmpleado As New clsEmpleado
        '
        oclsEmpleado.idEmpleado = System.Int32.Parse("0" & r("idEmpleado").ToString())
        oclsEmpleado.nombre = r("nombre").ToString()
        oclsEmpleado.direccion = r("direccion").ToString()
        oclsEmpleado.telefono = r("telefono").ToString()
        Try
            oclsEmpleado.bloqueado = System.Boolean.Parse(r("bloqueado").ToString())
        Catch
            oclsEmpleado.bloqueado = False
        End Try
        '
        Return oclsEmpleado
    End Function
    '
    ' asigna un objeto clsEmpleado a la fila indicada
    Private Shared Sub clsEmpleado2Row(ByVal oclsEmpleado As clsEmpleado, ByVal r As DataRow)
        ' asigna un objeto clsEmpleado al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idEmpleado") = oclsEmpleado.idEmpleado
        r("nombre") = oclsEmpleado.nombre
        r("direccion") = oclsEmpleado.direccion
        r("telefono") = oclsEmpleado.telefono
        r("bloqueado") = oclsEmpleado.bloqueado
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsEmpleado
    Private Shared Sub nuevoclsEmpleado(ByVal dt As DataTable, ByVal oclsEmpleado As clsEmpleado)
        ' Crear un nuevo clsEmpleado
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsEmpleado = row2clsEmpleado(dr)
        '
        oc.idEmpleado = oclsEmpleado.idEmpleado
        oc.nombre = oclsEmpleado.nombre
        oc.direccion = oclsEmpleado.direccion
        oc.telefono = oclsEmpleado.telefono
        oc.bloqueado = oclsEmpleado.bloqueado
        '
        clsEmpleado2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblEmpleado
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsEmpleado")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsEmpleado
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsEmpleado As clsEmpleado = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsEmpleado")
        Dim sel As String = "SELECT * FROM tblEmpleado WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsEmpleado = row2clsEmpleado(dt.Rows(0))
        End If
        Return oclsEmpleado
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idEmpleado existe en la tabla.
    '             TODO: Si en lugar de idEmpleado usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idEmpleado que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblEmpleado WHERE idEmpleado = " & Me.idEmpleado.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsEmpleado")
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
        '       Yo compruebo que sea un campo llamado idEmpleado, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idEmpleado) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblEmpleado SET nombre = @nombre, direccion = @direccion, telefono = @telefono, bloqueado = @bloqueado  WHERE (idEmpleado = @idEmpleado)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idEmpleado", SqlDbType.Int, 0, "idEmpleado")
        da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        da.UpdateCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 100, "direccion")
        da.UpdateCommand.Parameters.Add("@telefono", SqlDbType.NVarChar, 50, "telefono")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@bloqueado", SqlDbType.Bit, 0, "bloqueado")
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
            clsEmpleado2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsEmpleado")
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
        '       Yo compruebo que sea un campo llamado idEmpleado, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblEmpleado (nombre, direccion, telefono, bloqueado)  VALUES(@nombre, @direccion, @telefono, @bloqueado)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idEmpleado", SqlDbType.Int, 0, "idEmpleado")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        da.InsertCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 100, "direccion")
        da.InsertCommand.Parameters.Add("@telefono", SqlDbType.NVarChar, 50, "telefono")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@bloqueado", SqlDbType.Bit, 0, "bloqueado")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsEmpleado(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsEmpleado"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idEmpleado que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblEmpleado WHERE idEmpleado = " & Me.idEmpleado.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsEmpleado")
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
        '       Yo compruebo que sea un campo llamado idEmpleado, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblEmpleado WHERE (idEmpleado = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "idEmpleado")
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
