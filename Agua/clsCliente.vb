'------------------------------------------------------------------------------
' Clase clsCliente generada automáticamente con CrearClaseSQL
' de la tabla 'tblCliente' de la base 'Agua'
' Fecha: 04/ene/2017 16:55:12
'
' ©Guillermo 'guille' Som, 2004-2017
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class clsCliente
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idCliente As System.Int32
    Private _codigo As System.String
    Private _nombre As System.String
    Private _direccion As System.String
    Private _telefono As System.String
    Private _facturarA As System.String
    Private _nit As System.String
    Private _email As System.String
    Private _facturacionA As System.Boolean
    '
    ' Este método se usará para ajustar los anchos de las propiedades
    Private Function ajustarAncho(cadena As String, ancho As Integer) As String
        Dim sb As New System.Text.StringBuilder(New String(" "c, ancho))
        ' devolver la cadena quitando los espacios en blanco
        ' esto asegura que no se devolverá un tamaño mayor ni espacios "extras"
        Return (cadena & sb.ToString()).Substring(0, ancho).Trim()
    End Function
    '
    ' Las propiedades públicas
    ' TODO: Revisar los tipos de las propiedades
    Public Property idCliente() As System.Int32
        Get
            Return _idCliente
        End Get
        Set(value As System.Int32)
            _idCliente = value
        End Set
    End Property
    Public Property codigo() As System.String
        Get
            Return ajustarAncho(_codigo, 100)
        End Get
        Set(value As System.String)
            _codigo = value
        End Set
    End Property
    Public Property nombre() As System.String
        Get
            Return ajustarAncho(_nombre, 100)
        End Get
        Set(value As System.String)
            _nombre = value
        End Set
    End Property
    Public Property direccion() As System.String
        Get
            Return ajustarAncho(_direccion, 150)
        End Get
        Set(value As System.String)
            _direccion = value
        End Set
    End Property
    Public Property telefono() As System.String
        Get
            Return ajustarAncho(_telefono, 50)
        End Get
        Set(value As System.String)
            _telefono = value
        End Set
    End Property
    Public Property facturarA() As System.String
        Get
            Return ajustarAncho(_facturarA, 100)
        End Get
        Set(value As System.String)
            _facturarA = value
        End Set
    End Property
    Public Property nit() As System.String
        Get
            Return ajustarAncho(_nit, 50)
        End Get
        Set(value As System.String)
            _nit = value
        End Set
    End Property
    Public Property email() As System.String
        Get
            Return ajustarAncho(_email, 100)
        End Get
        Set(value As System.String)
            _email = value
        End Set
    End Property
    Public Property facturacionA() As System.Boolean
        Get
            Return _facturacionA
        End Get
        Set(value As System.Boolean)
            _facturacionA = value
        End Set
    End Property
    '
    Default Public Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idCliente.ToString()
            ElseIf index = 1 Then
                Return Me.codigo.ToString()
            ElseIf index = 2 Then
                Return Me.nombre.ToString()
            ElseIf index = 3 Then
                Return Me.direccion.ToString()
            ElseIf index = 4 Then
                Return Me.telefono.ToString()
            ElseIf index = 5 Then
                Return Me.facturarA.ToString()
            ElseIf index = 6 Then
                Return Me.nit.ToString()
            ElseIf index = 7 Then
                Return Me.email.ToString()
            ElseIf index = 8 Then
                Return Me.facturacionA.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.idCliente = System.Int32.Parse("0" & value)
                Catch
                    Me.idCliente = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.codigo = value
            ElseIf index = 2 Then
                Me.nombre = value
            ElseIf index = 3 Then
                Me.direccion = value
            ElseIf index = 4 Then
                Me.telefono = value
            ElseIf index = 5 Then
                Me.facturarA = value
            ElseIf index = 6 Then
                Me.nit = value
            ElseIf index = 7 Then
                Me.email = value
            ElseIf index = 8 Then
                Try
                    Me.facturacionA = System.Boolean.Parse(value)
                Catch
                    Me.facturacionA = False
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idCliente" Then
                Return Me.idCliente.ToString()
            ElseIf index = "codigo" Then
                Return Me.codigo.ToString()
            ElseIf index = "nombre" Then
                Return Me.nombre.ToString()
            ElseIf index = "direccion" Then
                Return Me.direccion.ToString()
            ElseIf index = "telefono" Then
                Return Me.telefono.ToString()
            ElseIf index = "facturarA" Then
                Return Me.facturarA.ToString()
            ElseIf index = "nit" Then
                Return Me.nit.ToString()
            ElseIf index = "email" Then
                Return Me.email.ToString()
            ElseIf index = "facturacionA" Then
                Return Me.facturacionA.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "idCliente" Then
                Try
                    Me.idCliente = System.Int32.Parse("0" & value)
                Catch
                    Me.idCliente = System.Int32.Parse("0")
                End Try
            ElseIf index = "codigo" Then
                Me.codigo = value
            ElseIf index = "nombre" Then
                Me.nombre = value
            ElseIf index = "direccion" Then
                Me.direccion = value
            ElseIf index = "telefono" Then
                Me.telefono = value
            ElseIf index = "facturarA" Then
                Me.facturarA = value
            ElseIf index = "nit" Then
                Me.nit = value
            ElseIf index = "email" Then
                Me.email = value
            ElseIf index = "facturacionA" Then
                Try
                    Me.facturacionA = System.Boolean.Parse(value)
                Catch
                    Me.facturacionA = False
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
    Public Shared CadenaSelect As String = "SELECT * FROM tblCliente"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsCliente
    Private Shared Function row2clsCliente(r As DataRow) As clsCliente
        ' asigna a un objeto clsCliente los datos del dataRow indicado
        Dim oclsCliente As New clsCliente
        '
        oclsCliente.idCliente = System.Int32.Parse("0" & r("idCliente").ToString())
        oclsCliente.codigo = r("codigo").ToString()
        oclsCliente.nombre = r("nombre").ToString()
        oclsCliente.direccion = r("direccion").ToString()
        oclsCliente.telefono = r("telefono").ToString()
        oclsCliente.facturarA = r("facturarA").ToString()
        oclsCliente.nit = r("nit").ToString()
        oclsCliente.email = r("email").ToString()
        Try
            oclsCliente.facturacionA = System.Boolean.Parse(r("facturacionA").ToString())
        Catch
            oclsCliente.facturacionA = False
        End Try
        '
        Return oclsCliente
    End Function
    '
    ' asigna un objeto clsCliente a la fila indicada
    Private Shared Sub clsCliente2Row(oclsCliente As clsCliente, r As DataRow)
        ' asigna un objeto clsCliente al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idCliente") = oclsCliente.idCliente
        r("codigo") = oclsCliente.codigo
        r("nombre") = oclsCliente.nombre
        r("direccion") = oclsCliente.direccion
        r("telefono") = oclsCliente.telefono
        r("facturarA") = oclsCliente.facturarA
        r("nit") = oclsCliente.nit
        r("email") = oclsCliente.email
        r("facturacionA") = oclsCliente.facturacionA
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsCliente
    Private Shared Sub nuevoclsCliente(dt As DataTable, oclsCliente As clsCliente)
        ' Crear un nuevo clsCliente
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsCliente = row2clsCliente(dr)
        '
        oc.idCliente = oclsCliente.idCliente
        oc.codigo = oclsCliente.codigo
        oc.nombre = oclsCliente.nombre
        oc.direccion = oclsCliente.direccion
        oc.telefono = oclsCliente.telefono
        oc.facturarA = oclsCliente.facturarA
        oc.nit = oclsCliente.nit
        oc.email = oclsCliente.email
        oc.facturacionA = oclsCliente.facturacionA
        '
        clsCliente2Row(oc, dr)
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
    Public Shared Function Tabla(sel As String) As DataTable
        ' devuelve una tabla con los datos de la tabla tblCliente
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsCliente")
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
    Public Shared Function Buscar(sWhere As String) As clsCliente
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsCliente As clsCliente = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsCliente")
        Dim sel As String = "SELECT * FROM tblCliente WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsCliente = row2clsCliente(dt.Rows(0))
        End If
        Return oclsCliente
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idCliente existe en la tabla.
    '             TODO: Si en lugar de idCliente usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idCliente que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblCliente WHERE idCliente = " & Me.idCliente.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsCliente")
        '
        cnn = New SqlConnection(cadenaConexion)
        'da = New SqlDataAdapter(CadenaSelect, cnn)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.UpdateCommand = cb.GetUpdateCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando UPDATE
        '' TODO: Comprobar cual es el campo de índice principal (sin duplicados)
        ''       Yo compruebo que sea un campo llamado idCliente, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso idCliente) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE tblCliente SET codigo = @codigo, nombre = @nombre, direccion = @direccion, telefono = @telefono, facturarA = @facturarA, nit = @nit, email = @email, facturacionA = @facturacionA  WHERE (idCliente = @idCliente)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@idCliente", SqlDbType.Int, 0, "idCliente")
        'da.UpdateCommand.Parameters.Add("@codigo", SqlDbType.NVarChar, 100, "codigo")
        'da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        'da.UpdateCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 150, "direccion")
        'da.UpdateCommand.Parameters.Add("@telefono", SqlDbType.NVarChar, 50, "telefono")
        'da.UpdateCommand.Parameters.Add("@facturarA", SqlDbType.NVarChar, 100, "facturarA")
        'da.UpdateCommand.Parameters.Add("@nit", SqlDbType.NVarChar, 50, "nit")
        'da.UpdateCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "email")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@facturacionA", SqlDbType.Bit, 0, "facturacionA")
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
            clsCliente2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsCliente")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(CadenaSelect, cnn)
        'da = New SqlDataAdapter(CadenaSelect, cadenaConexion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.InsertCommand = cb.GetInsertCommand()
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando INSERT
        '' TODO: No incluir el campo de clave primaria incremental
        ''       Yo compruebo que sea un campo llamado idCliente, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO tblCliente (codigo, nombre, direccion, telefono, facturarA, nit, email, facturacionA)  VALUES(@codigo, @nombre, @direccion, @telefono, @facturarA, @nit, @email, @facturacionA)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@idCliente", SqlDbType.Int, 0, "idCliente")
        'da.InsertCommand.Parameters.Add("@codigo", SqlDbType.NVarChar, 100, "codigo")
        'da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        'da.InsertCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 150, "direccion")
        'da.InsertCommand.Parameters.Add("@telefono", SqlDbType.NVarChar, 50, "telefono")
        'da.InsertCommand.Parameters.Add("@facturarA", SqlDbType.NVarChar, 100, "facturarA")
        'da.InsertCommand.Parameters.Add("@nit", SqlDbType.NVarChar, 50, "nit")
        'da.InsertCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "email")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@facturacionA", SqlDbType.Bit, 0, "facturacionA")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsCliente(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsCliente"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idCliente que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblCliente WHERE idCliente = " & Me.idCliente.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsCliente")
        '
        cnn = New SqlConnection(cadenaConexion)
        da = New SqlDataAdapter(sel, cnn)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        '
        '-------------------------------------------
        ' Esta no es la más óptima, pero funcionará
        '-------------------------------------------
        Dim cb As New SqlCommandBuilder(da)
        da.DeleteCommand = cb.GetDeleteCommand()
        '
        '
        '--------------------------------------------------------------------
        ' Esta está más optimizada pero debes comprobar que funciona bien...
        '--------------------------------------------------------------------
        'Dim sCommand As String
        ''
        '' El comando DELETE
        '' TODO: Sólo incluir el campo de clave primaria incremental
        ''       Yo compruebo que sea un campo llamado idCliente, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM tblCliente WHERE (idCliente = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "idCliente")
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