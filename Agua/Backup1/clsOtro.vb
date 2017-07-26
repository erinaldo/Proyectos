'------------------------------------------------------------------------------
' Clase clsOtro generada automáticamente con CrearClaseSQL
' de la tabla 'tblOtro' de la base 'bdagua'
' Fecha: 29/mar/2009 21:06:08
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
Public Class clsOtro
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idOtro As System.Int32
    Private _fecha As System.DateTime
    Private _idUsuario As System.Int16
    Private _idLectura As System.Int64
    Private _monto As System.Decimal
    Private _observacion As System.String
    Private _idAsignacion As System.Int32
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
    Public Property idOtro() As System.Int32
        Get
            Return _idOtro
        End Get
        Set(ByVal value As System.Int32)
            _idOtro = value
        End Set
    End Property
    Public Property fecha() As System.DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As System.DateTime)
            _fecha = value
        End Set
    End Property
    Public Property idUsuario() As System.Int16
        Get
            Return _idUsuario
        End Get
        Set(ByVal value As System.Int16)
            _idUsuario = value
        End Set
    End Property
    Public Property idLectura() As System.Int64
        Get
            Return _idLectura
        End Get
        Set(ByVal value As System.Int64)
            _idLectura = value
        End Set
    End Property
    Public Property monto() As System.Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As System.Decimal)
            _monto = value
        End Set
    End Property
    Public Property observacion() As System.String
        Get
            Return ajustarAncho(_observacion, 200)
        End Get
        Set(ByVal value As System.String)
            _observacion = value
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
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idOtro.ToString()
            ElseIf index = 1 Then
                Return Me.fecha.ToString()
            ElseIf index = 2 Then
                Return Me.idUsuario.ToString()
            ElseIf index = 3 Then
                Return Me.idLectura.ToString()
            ElseIf index = 4 Then
                Return Me.monto.ToString()
            ElseIf index = 5 Then
                Return Me.observacion.ToString()
            ElseIf index = 6 Then
                Return Me.idAsignacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idOtro = System.Int32.Parse("0" & value)
                Catch
                    Me.idOtro = System.Int32.Parse("0")
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
                Try
                    Me.idUsuario = System.Int16.Parse("0" & value)
                Catch
                    Me.idUsuario = System.Int16.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.idLectura = System.Int64.Parse("0" & value)
                Catch
                    Me.idLectura = System.Int64.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.monto = System.Decimal.Parse("0" & value)
                Catch
                    Me.monto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 5 Then
                Me.observacion = value
            ElseIf index = 6 Then
                Try
                    Me.idAsignacion = System.Int32.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int32.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idOtro" Then
                Return Me.idOtro.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            ElseIf index = "idUsuario" Then
                Return Me.idUsuario.ToString()
            ElseIf index = "idLectura" Then
                Return Me.idLectura.ToString()
            ElseIf index = "monto" Then
                Return Me.monto.ToString()
            ElseIf index = "observacion" Then
                Return Me.observacion.ToString()
            ElseIf index = "idAsignacion" Then
                Return Me.idAsignacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idOtro" Then
                Try
                    Me.idOtro = System.Int32.Parse("0" & value)
                Catch
                    Me.idOtro = System.Int32.Parse("0")
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
            ElseIf index = "idUsuario" Then
                Try
                    Me.idUsuario = System.Int16.Parse("0" & value)
                Catch
                    Me.idUsuario = System.Int16.Parse("0")
                End Try
            ElseIf index = "idLectura" Then
                Try
                    Me.idLectura = System.Int64.Parse("0" & value)
                Catch
                    Me.idLectura = System.Int64.Parse("0")
                End Try
            ElseIf index = "monto" Then
                Try
                    Me.monto = System.Decimal.Parse("0" & value)
                Catch
                    Me.monto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "observacion" Then
                Me.observacion = value
            ElseIf index = "idAsignacion" Then
                Try
                    Me.idAsignacion = System.Int32.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int32.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM tblOtro"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsOtro
    Private Shared Function row2clsOtro(ByVal r As DataRow) As clsOtro
        ' asigna a un objeto clsOtro los datos del dataRow indicado
        Dim oclsOtro As New clsOtro
        '
        oclsOtro.idOtro = System.Int32.Parse("0" & r("idOtro").ToString())
        Try
            oclsOtro.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsOtro.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsOtro.fecha = DateTime.Now
        End Try
        oclsOtro.idUsuario = System.Int16.Parse("0" & r("idUsuario").ToString())
        oclsOtro.idLectura = System.Int64.Parse("0" & r("idLectura").ToString())
        oclsOtro.monto = System.Decimal.Parse("0" & r("monto").ToString())
        oclsOtro.observacion = r("observacion").ToString()
        oclsOtro.idAsignacion = System.Int32.Parse("0" & r("idAsignacion").ToString())
        '
        Return oclsOtro
    End Function
    '
    ' asigna un objeto clsOtro a la fila indicada
    Private Shared Sub clsOtro2Row(ByVal oclsOtro As clsOtro, ByVal r As DataRow)
        ' asigna un objeto clsOtro al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idOtro") = oclsOtro.idOtro
        r("fecha") = oclsOtro.fecha
        r("idUsuario") = oclsOtro.idUsuario
        r("idLectura") = oclsOtro.idLectura
        r("monto") = oclsOtro.monto
        r("observacion") = oclsOtro.observacion
        r("idAsignacion") = oclsOtro.idAsignacion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsOtro
    Private Shared Sub nuevoclsOtro(ByVal dt As DataTable, ByVal oclsOtro As clsOtro)
        ' Crear un nuevo clsOtro
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsOtro = row2clsOtro(dr)
        '
        oc.idOtro = oclsOtro.idOtro
        oc.fecha = oclsOtro.fecha
        oc.idUsuario = oclsOtro.idUsuario
        oc.idLectura = oclsOtro.idLectura
        oc.monto = oclsOtro.monto
        oc.observacion = oclsOtro.observacion
        oc.idAsignacion = oclsOtro.idAsignacion
        '
        clsOtro2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblOtro
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsOtro")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsOtro
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsOtro As clsOtro = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsOtro")
        Dim sel As String = "SELECT * FROM tblOtro WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsOtro = row2clsOtro(dt.Rows(0))
        End If
        Return oclsOtro
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idOtro existe en la tabla.
    '             TODO: Si en lugar de idOtro usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idOtro que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblOtro WHERE idOtro = " & Me.idOtro.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsOtro")
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
        '       Yo compruebo que sea un campo llamado idOtro, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idOtro) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblOtro SET fecha = @fecha, idUsuario = @idUsuario, idLectura = @idLectura, monto = @monto, observacion = @observacion, idAsignacion = @idAsignacion  WHERE (idOtro = @idOtro)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idOtro", SqlDbType.Int, 0, "idOtro")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idUsuario", SqlDbType.SmallInt, 0, "idUsuario")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idLectura", SqlDbType.BigInt, 0, "idLectura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@monto", SqlDbType.Decimal, 0, "monto")
        da.UpdateCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 200, "observacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idAsignacion", SqlDbType.Int, 0, "idAsignacion")
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
            clsOtro2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsOtro")
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
        '       Yo compruebo que sea un campo llamado idOtro, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblOtro (fecha, idUsuario, idLectura, monto, observacion, idAsignacion)  VALUES(@fecha, @idUsuario, @idLectura, @monto, @observacion, @idAsignacion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idOtro", SqlDbType.Int, 0, "idOtro")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idUsuario", SqlDbType.SmallInt, 0, "idUsuario")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idLectura", SqlDbType.BigInt, 0, "idLectura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@monto", SqlDbType.Decimal, 0, "monto")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 200, "observacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idAsignacion", SqlDbType.Int, 0, "idAsignacion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsOtro(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsOtro"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idOtro que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblOtro WHERE idOtro = " & Me.idOtro.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsOtro")
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
        '       Yo compruebo que sea un campo llamado idOtro, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblOtro WHERE (idOtro = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "idOtro")
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

