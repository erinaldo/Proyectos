'------------------------------------------------------------------------------
' Clase clsCreaFactura generada automáticamente con CrearClaseSQL
' de la tabla 'tblCreaFactura' de la base 'AguaNuevo'
' Fecha: 08/feb/2017 16:25:11
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
Public Class clsCreaFactura
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _codigo As System.Int32
    Private _fecha As System.DateTime
    Private _nombre As System.String
    Private _direccion As System.String
    Private _nit As System.String
    Private _telefono As System.String
    Private _noFactura As System.String
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
    Public Property codigo() As System.Int32
        Get
            Return _codigo
        End Get
        Set(value As System.Int32)
            _codigo = value
        End Set
    End Property
    Public Property fecha() As System.DateTime
        Get
            Return _fecha
        End Get
        Set(value As System.DateTime)
            _fecha = value
        End Set
    End Property
    Public Property nombre() As System.String
        Get
            Return ajustarAncho(_nombre, 200)
        End Get
        Set(value As System.String)
            _nombre = value
        End Set
    End Property
    Public Property direccion() As System.String
        Get
            Return ajustarAncho(_direccion, 200)
        End Get
        Set(value As System.String)
            _direccion = value
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
    Public Property telefono() As System.String
        Get
            Return ajustarAncho(_telefono, 20)
        End Get
        Set(value As System.String)
            _telefono = value
        End Set
    End Property
    Public Property noFactura() As System.String
        Get
            Return ajustarAncho(_noFactura, 100)
        End Get
        Set(value As System.String)
            _noFactura = value
        End Set
    End Property
    '
    Default Public Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.codigo.ToString()
            ElseIf index = 1 Then
                Return Me.fecha.ToString()
            ElseIf index = 2 Then
                Return Me.nombre.ToString()
            ElseIf index = 3 Then
                Return Me.direccion.ToString()
            ElseIf index = 4 Then
                Return Me.nit.ToString()
            ElseIf index = 5 Then
                Return Me.telefono.ToString()
            ElseIf index = 6 Then
                Return Me.noFactura.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.codigo = System.Int32.Parse("0" & value)
                Catch
                    Me.codigo = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fecha = System.DateTime.Now
                End Try
            ElseIf index = 2 Then
                Me.nombre = value
            ElseIf index = 3 Then
                Me.direccion = value
            ElseIf index = 4 Then
                Me.nit = value
            ElseIf index = 5 Then
                Me.telefono = value
            ElseIf index = 6 Then
                Me.noFactura = value
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "codigo" Then
                Return Me.codigo.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            ElseIf index = "nombre" Then
                Return Me.nombre.ToString()
            ElseIf index = "direccion" Then
                Return Me.direccion.ToString()
            ElseIf index = "nit" Then
                Return Me.nit.ToString()
            ElseIf index = "telefono" Then
                Return Me.telefono.ToString()
            ElseIf index = "noFactura" Then
                Return Me.noFactura.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "codigo" Then
                Try
                    Me.codigo = System.Int32.Parse("0" & value)
                Catch
                    Me.codigo = System.Int32.Parse("0")
                End Try
            ElseIf index = "fecha" Then
                Try
                    Me.fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fecha = System.DateTime.Now
                End Try
            ElseIf index = "nombre" Then
                Me.nombre = value
            ElseIf index = "direccion" Then
                Me.direccion = value
            ElseIf index = "nit" Then
                Me.nit = value
            ElseIf index = "telefono" Then
                Me.telefono = value
            ElseIf index = "noFactura" Then
                Me.noFactura = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = mdlPublicVars.cnn
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM tblCreaFactura"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsCreaFactura
    Private Shared Function row2clsCreaFactura(r As DataRow) As clsCreaFactura
        ' asigna a un objeto clsCreaFactura los datos del dataRow indicado
        Dim oclsCreaFactura As New clsCreaFactura
        '
        oclsCreaFactura.codigo = System.Int32.Parse("0" & r("codigo").ToString())
        Try
            oclsCreaFactura.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsCreaFactura.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsCreaFactura.fecha = DateTime.Now
        End Try
        oclsCreaFactura.nombre = r("nombre").ToString()
        oclsCreaFactura.direccion = r("direccion").ToString()
        oclsCreaFactura.nit = r("nit").ToString()
        oclsCreaFactura.telefono = r("telefono").ToString()
        oclsCreaFactura.noFactura = r("noFactura").ToString()
        '
        Return oclsCreaFactura
    End Function
    '
    ' asigna un objeto clsCreaFactura a la fila indicada
    Private Shared Sub clsCreaFactura2Row(oclsCreaFactura As clsCreaFactura, r As DataRow)
        ' asigna un objeto clsCreaFactura al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("codigo") = oclsCreaFactura.codigo
        r("fecha") = oclsCreaFactura.fecha
        r("nombre") = oclsCreaFactura.nombre
        r("direccion") = oclsCreaFactura.direccion
        r("nit") = oclsCreaFactura.nit
        r("telefono") = oclsCreaFactura.telefono
        r("noFactura") = oclsCreaFactura.noFactura
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsCreaFactura
    Private Shared Sub nuevoclsCreaFactura(dt As DataTable, oclsCreaFactura As clsCreaFactura)
        ' Crear un nuevo clsCreaFactura
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsCreaFactura = row2clsCreaFactura(dr)
        '
        oc.codigo = oclsCreaFactura.codigo
        oc.fecha = oclsCreaFactura.fecha
        oc.nombre = oclsCreaFactura.nombre
        oc.direccion = oclsCreaFactura.direccion
        oc.nit = oclsCreaFactura.nit
        oc.telefono = oclsCreaFactura.telefono
        oc.noFactura = oclsCreaFactura.noFactura
        '
        clsCreaFactura2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblCreaFactura
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsCreaFactura")
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
    Public Shared Function Buscar(sWhere As String) As clsCreaFactura
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsCreaFactura As clsCreaFactura = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsCreaFactura")
        Dim sel As String = "SELECT * FROM tblCreaFactura WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsCreaFactura = row2clsCreaFactura(dt.Rows(0))
        End If
        Return oclsCreaFactura
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el codigo existe en la tabla.
    '             TODO: Si en lugar de codigo usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el codigo que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblCreaFactura WHERE codigo = " & Me.codigo.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsCreaFactura")
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
        ''       Yo compruebo que sea un campo llamado codigo, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso codigo) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE tblCreaFactura SET fecha = @fecha, nombre = @nombre, direccion = @direccion, nit = @nit, telefono = @telefono, noFactura = @noFactura  WHERE (codigo = @codigo)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        'da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 200, "nombre")
        'da.UpdateCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 200, "direccion")
        'da.UpdateCommand.Parameters.Add("@nit", SqlDbType.NVarChar, 50, "nit")
        'da.UpdateCommand.Parameters.Add("@telefono", SqlDbType.NVarChar, 20, "telefono")
        'da.UpdateCommand.Parameters.Add("@noFactura", SqlDbType.NVarChar, 100, "noFactura")
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
            clsCreaFactura2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsCreaFactura")
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
        ''       Yo compruebo que sea un campo llamado codigo, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO tblCreaFactura (fecha, nombre, direccion, nit, telefono, noFactura)  VALUES(@fecha, @nombre, @direccion, @nit, @telefono, @noFactura)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        'da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 200, "nombre")
        'da.InsertCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 200, "direccion")
        'da.InsertCommand.Parameters.Add("@nit", SqlDbType.NVarChar, 50, "nit")
        'da.InsertCommand.Parameters.Add("@telefono", SqlDbType.NVarChar, 20, "telefono")
        'da.InsertCommand.Parameters.Add("@noFactura", SqlDbType.NVarChar, 100, "noFactura")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsCreaFactura(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsCreaFactura"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el codigo que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblCreaFactura WHERE codigo = " & Me.codigo.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsCreaFactura")
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
        ''       Yo compruebo que sea un campo llamado codigo, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM tblCreaFactura WHERE (codigo = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "codigo")
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