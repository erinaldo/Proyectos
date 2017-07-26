'------------------------------------------------------------------------------
' Clase clsMovimiento generada automáticamente con CrearClaseSQL
' de la tabla 'tblMovimiento' de la base 'bdagua'
' Fecha: 23/ene/2011 21:25:52
'
' ©Guillermo 'guille' Som, 2004-2011
'------------------------------------------------------------------------------
Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class clsMovimiento
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idMovimiento As System.Int64
    Private _idTipoMovimiento As System.Int16
    Private _fecha As System.DateTime
    Private _idProducto As System.Int64
    Private _precio As System.Decimal
    Private _observacion As System.String
    Private _idUsuario As System.Int16
    Private _idFactura As System.Int64
    Private _idAsignacion As System.Int64
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
    Public Property idMovimiento() As System.Int64
        Get
            Return _idMovimiento
        End Get
        Set(ByVal value As System.Int64)
            _idMovimiento = value
        End Set
    End Property
    Public Property idTipoMovimiento() As System.Int16
        Get
            Return _idTipoMovimiento
        End Get
        Set(ByVal value As System.Int16)
            _idTipoMovimiento = value
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
    Public Property idProducto() As System.Int64
        Get
            Return _idProducto
        End Get
        Set(ByVal value As System.Int64)
            _idProducto = value
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
    Public Property observacion() As System.String
        Get
            Return ajustarAncho(_observacion, 100)
        End Get
        Set(ByVal value As System.String)
            _observacion = value
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
    Public Property idFactura() As System.Int64
        Get
            Return _idFactura
        End Get
        Set(ByVal value As System.Int64)
            _idFactura = value
        End Set
    End Property
    Public Property idAsignacion() As System.Int64
        Get
            Return _idAsignacion
        End Get
        Set(ByVal value As System.Int64)
            _idAsignacion = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idMovimiento.ToString()
            ElseIf index = 1 Then
                Return Me.idTipoMovimiento.ToString()
            ElseIf index = 2 Then
                Return Me.fecha.ToString()
            ElseIf index = 3 Then
                Return Me.idProducto.ToString()
            ElseIf index = 4 Then
                Return Me.precio.ToString()
            ElseIf index = 5 Then
                Return Me.observacion.ToString()
            ElseIf index = 6 Then
                Return Me.idUsuario.ToString()
            ElseIf index = 7 Then
                Return Me.idFactura.ToString()
            ElseIf index = 8 Then
                Return Me.idAsignacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idMovimiento = System.Int64.Parse("0" & value)
                Catch
                    Me.idMovimiento = System.Int64.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.idTipoMovimiento = System.Int16.Parse("0" & value)
                Catch
                    Me.idTipoMovimiento = System.Int16.Parse("0")
                End Try
            ElseIf index = 2 Then
                Try
                    Me.fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fecha = System.DateTime.Now
                End Try
            ElseIf index = 3 Then
                Try
                    Me.idProducto = System.Int64.Parse("0" & value)
                Catch
                    Me.idProducto = System.Int64.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.precio = System.Decimal.Parse("0" & value)
                Catch
                    Me.precio = System.Decimal.Parse("0")
                End Try
            ElseIf index = 5 Then
                Me.observacion = value
            ElseIf index = 6 Then
                Try
                    Me.idUsuario = System.Int16.Parse("0" & value)
                Catch
                    Me.idUsuario = System.Int16.Parse("0")
                End Try
            ElseIf index = 7 Then
                Try
                    Me.idFactura = System.Int64.Parse("0" & value)
                Catch
                    Me.idFactura = System.Int64.Parse("0")
                End Try
            ElseIf index = 8 Then
                Try
                    Me.idAsignacion = System.Int64.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int64.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idMovimiento" Then
                Return Me.idMovimiento.ToString()
            ElseIf index = "idTipoMovimiento" Then
                Return Me.idTipoMovimiento.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            ElseIf index = "idProducto" Then
                Return Me.idProducto.ToString()
            ElseIf index = "precio" Then
                Return Me.precio.ToString()
            ElseIf index = "observacion" Then
                Return Me.observacion.ToString()
            ElseIf index = "idUsuario" Then
                Return Me.idUsuario.ToString()
            ElseIf index = "idFactura" Then
                Return Me.idFactura.ToString()
            ElseIf index = "idAsignacion" Then
                Return Me.idAsignacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idMovimiento" Then
                Try
                    Me.idMovimiento = System.Int64.Parse("0" & value)
                Catch
                    Me.idMovimiento = System.Int64.Parse("0")
                End Try
            ElseIf index = "idTipoMovimiento" Then
                Try
                    Me.idTipoMovimiento = System.Int16.Parse("0" & value)
                Catch
                    Me.idTipoMovimiento = System.Int16.Parse("0")
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
            ElseIf index = "idProducto" Then
                Try
                    Me.idProducto = System.Int64.Parse("0" & value)
                Catch
                    Me.idProducto = System.Int64.Parse("0")
                End Try
            ElseIf index = "precio" Then
                Try
                    Me.precio = System.Decimal.Parse("0" & value)
                Catch
                    Me.precio = System.Decimal.Parse("0")
                End Try
            ElseIf index = "observacion" Then
                Me.observacion = value
            ElseIf index = "idUsuario" Then
                Try
                    Me.idUsuario = System.Int16.Parse("0" & value)
                Catch
                    Me.idUsuario = System.Int16.Parse("0")
                End Try
            ElseIf index = "idFactura" Then
                Try
                    Me.idFactura = System.Int64.Parse("0" & value)
                Catch
                    Me.idFactura = System.Int64.Parse("0")
                End Try
            ElseIf index = "idAsignacion" Then
                Try
                    Me.idAsignacion = System.Int64.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int64.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM tblMovimiento"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsMovimiento
    Private Shared Function row2clsMovimiento(ByVal r As DataRow) As clsMovimiento
        ' asigna a un objeto clsMovimiento los datos del dataRow indicado
        Dim oclsMovimiento As New clsMovimiento
        '
        oclsMovimiento.idMovimiento = System.Int64.Parse("0" & r("idMovimiento").ToString())
        oclsMovimiento.idTipoMovimiento = System.Int16.Parse("0" & r("idTipoMovimiento").ToString())
        Try
            oclsMovimiento.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsMovimiento.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsMovimiento.fecha = DateTime.Now
        End Try
        oclsMovimiento.idProducto = System.Int64.Parse("0" & r("idProducto").ToString())
        oclsMovimiento.precio = System.Decimal.Parse("0" & r("precio").ToString())
        oclsMovimiento.observacion = r("observacion").ToString()
        oclsMovimiento.idUsuario = System.Int16.Parse("0" & r("idUsuario").ToString())
        oclsMovimiento.idFactura = System.Int64.Parse("0" & r("idFactura").ToString())
        oclsMovimiento.idAsignacion = System.Int64.Parse("0" & r("idAsignacion").ToString())
        '
        Return oclsMovimiento
    End Function
    '
    ' asigna un objeto clsMovimiento a la fila indicada
    Private Shared Sub clsMovimiento2Row(ByVal oclsMovimiento As clsMovimiento, ByVal r As DataRow)
        ' asigna un objeto clsMovimiento al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idMovimiento") = oclsMovimiento.idMovimiento
        r("idTipoMovimiento") = oclsMovimiento.idTipoMovimiento
        r("fecha") = oclsMovimiento.fecha
        r("idProducto") = oclsMovimiento.idProducto
        r("precio") = oclsMovimiento.precio
        r("observacion") = oclsMovimiento.observacion
        r("idUsuario") = oclsMovimiento.idUsuario
        r("idFactura") = oclsMovimiento.idFactura
        r("idAsignacion") = oclsMovimiento.idAsignacion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsMovimiento
    Private Shared Sub nuevoclsMovimiento(ByVal dt As DataTable, ByVal oclsMovimiento As clsMovimiento)
        ' Crear un nuevo clsMovimiento
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsMovimiento = row2clsMovimiento(dr)
        '
        oc.idMovimiento = oclsMovimiento.idMovimiento
        oc.idTipoMovimiento = oclsMovimiento.idTipoMovimiento
        oc.fecha = oclsMovimiento.fecha
        oc.idProducto = oclsMovimiento.idProducto
        oc.precio = oclsMovimiento.precio
        oc.observacion = oclsMovimiento.observacion
        oc.idUsuario = oclsMovimiento.idUsuario
        oc.idFactura = oclsMovimiento.idFactura
        oc.idAsignacion = oclsMovimiento.idAsignacion
        '
        clsMovimiento2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblMovimiento
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsMovimiento")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsMovimiento
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsMovimiento As clsMovimiento = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsMovimiento")
        Dim sel As String = "SELECT * FROM tblMovimiento WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsMovimiento = row2clsMovimiento(dt.Rows(0))
        End If
        Return oclsMovimiento
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idMovimiento existe en la tabla.
    '             TODO: Si en lugar de idMovimiento usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idMovimiento que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblMovimiento WHERE idMovimiento = " & Me.idMovimiento.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsMovimiento")
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
        '       Yo compruebo que sea un campo llamado idMovimiento, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idMovimiento) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblMovimiento SET idTipoMovimiento = @idTipoMovimiento, fecha = @fecha, idProducto = @idProducto, precio = @precio, observacion = @observacion, idUsuario = @idUsuario, idFactura = @idFactura, idAsignacion = @idAsignacion  WHERE (idMovimiento = @idMovimiento)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idMovimiento", SqlDbType.BigInt, 0, "idMovimiento")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idTipoMovimiento", SqlDbType.SmallInt, 0, "idTipoMovimiento")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idProducto", SqlDbType.BigInt, 0, "idProducto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@precio", SqlDbType.Decimal, 0, "precio")
        da.UpdateCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 100, "observacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idUsuario", SqlDbType.SmallInt, 0, "idUsuario")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idFactura", SqlDbType.BigInt, 0, "idFactura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idAsignacion", SqlDbType.BigInt, 0, "idAsignacion")
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
            clsMovimiento2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsMovimiento")
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
        '       Yo compruebo que sea un campo llamado idMovimiento, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblMovimiento (idTipoMovimiento, fecha, idProducto, precio, observacion, idUsuario, idFactura, idAsignacion)  VALUES(@idTipoMovimiento, @fecha, @idProducto, @precio, @observacion, @idUsuario, @idFactura, @idAsignacion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idMovimiento", SqlDbType.BigInt, 0, "idMovimiento")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idTipoMovimiento", SqlDbType.SmallInt, 0, "idTipoMovimiento")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idProducto", SqlDbType.BigInt, 0, "idProducto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@precio", SqlDbType.Decimal, 0, "precio")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 100, "observacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idUsuario", SqlDbType.SmallInt, 0, "idUsuario")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idFactura", SqlDbType.BigInt, 0, "idFactura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idAsignacion", SqlDbType.BigInt, 0, "idAsignacion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsMovimiento(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsMovimiento"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idMovimiento que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblMovimiento WHERE idMovimiento = " & Me.idMovimiento.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsMovimiento")
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
        '       Yo compruebo que sea un campo llamado idMovimiento, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblMovimiento WHERE (idMovimiento = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.BigInt, 0, "idMovimiento")
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
