'------------------------------------------------------------------------------
' Clase clsAsignacion generada automáticamente con CrearClaseSQL
' de la tabla 'tblAsignacion' de la base 'bdAgua'
' Fecha: 24/abr/2009 08:45:49
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
Public Class clsAsignacion
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idAsignacion As System.Int32
    Private _idProyecto As System.Int16
    Private _idCliente As System.Int32
    Private _fecha As System.DateTime
    Private _direccion As System.String
    Private _fechaInstalacion As System.DateTime
    Private _observacion As System.String
    Private _manzana As System.String
    Private _lote As System.Int32
    Private _saldoInicial As System.Decimal
    Private _lecturaInicial As System.Decimal
    Private _noServicios As System.Int16
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
    Public Property idAsignacion() As System.Int32
        Get
            Return _idAsignacion
        End Get
        Set(ByVal value As System.Int32)
            _idAsignacion = value
        End Set
    End Property
    Public Property idProyecto() As System.Int16
        Get
            Return _idProyecto
        End Get
        Set(ByVal value As System.Int16)
            _idProyecto = value
        End Set
    End Property
    Public Property idCliente() As System.Int32
        Get
            Return _idCliente
        End Get
        Set(ByVal value As System.Int32)
            _idCliente = value
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
    Public Property direccion() As System.String
        Get
            Return ajustarAncho(_direccion, 100)
        End Get
        Set(ByVal value As System.String)
            _direccion = value
        End Set
    End Property
    Public Property fechaInstalacion() As System.DateTime
        Get
            Return _fechaInstalacion
        End Get
        Set(ByVal value As System.DateTime)
            _fechaInstalacion = value
        End Set
    End Property
    Public Property observacion() As System.String
        Get
            Return ajustarAncho(_observacion, 10)
        End Get
        Set(ByVal value As System.String)
            _observacion = value
        End Set
    End Property
    Public Property manzana() As System.String
        Get
            Return ajustarAncho(_manzana, 2)
        End Get
        Set(ByVal value As System.String)
            _manzana = value
        End Set
    End Property
    Public Property lote() As System.Int32
        Get
            Return _lote
        End Get
        Set(ByVal value As System.Int32)
            _lote = value
        End Set
    End Property
    Public Property saldoInicial() As System.Decimal
        Get
            Return _saldoInicial
        End Get
        Set(ByVal value As System.Decimal)
            _saldoInicial = value
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
    Public Property noServicios() As System.Int16
        Get
            Return _noServicios
        End Get
        Set(ByVal value As System.Int16)
            _noServicios = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idAsignacion.ToString()
            ElseIf index = 1 Then
                Return Me.idProyecto.ToString()
            ElseIf index = 2 Then
                Return Me.idCliente.ToString()
            ElseIf index = 3 Then
                Return Me.fecha.ToString()
            ElseIf index = 4 Then
                Return Me.direccion.ToString()
            ElseIf index = 5 Then
                Return Me.fechaInstalacion.ToString()
            ElseIf index = 6 Then
                Return Me.observacion.ToString()
            ElseIf index = 7 Then
                Return Me.manzana.ToString()
            ElseIf index = 8 Then
                Return Me.lote.ToString()
            ElseIf index = 9 Then
                Return Me.saldoInicial.ToString()
            ElseIf index = 10 Then
                Return Me.lecturaInicial.ToString()
            ElseIf index = 11 Then
                Return Me.noServicios.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idAsignacion = System.Int32.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Try
                    Me.idProyecto = System.Int16.Parse("0" & value)
                Catch
                    Me.idProyecto = System.Int16.Parse("0")
                End Try
            ElseIf index = 2 Then
                Try
                    Me.idCliente = System.Int32.Parse("0" & value)
                Catch
                    Me.idCliente = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fecha = System.DateTime.Now
                End Try
            ElseIf index = 4 Then
                Me.direccion = value
            ElseIf index = 5 Then
                Try
                    Me.fechaInstalacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fechaInstalacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fechaInstalacion = System.DateTime.Now
                End Try
            ElseIf index = 6 Then
                Me.observacion = value
            ElseIf index = 7 Then
                Me.manzana = value
            ElseIf index = 8 Then
                Try
                    Me.lote = System.Int32.Parse("0" & value)
                Catch
                    Me.lote = System.Int32.Parse("0")
                End Try
            ElseIf index = 9 Then
                Try
                    Me.saldoInicial = System.Decimal.Parse("0" & value)
                Catch
                    Me.saldoInicial = System.Decimal.Parse("0")
                End Try
            ElseIf index = 10 Then
                Try
                    Me.lecturaInicial = System.Decimal.Parse("0" & value)
                Catch
                    Me.lecturaInicial = System.Decimal.Parse("0")
                End Try
            ElseIf index = 11 Then
                Try
                    Me.noServicios = System.Int16.Parse("0" & value)
                Catch
                    Me.noServicios = System.Int16.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idAsignacion" Then
                Return Me.idAsignacion.ToString()
            ElseIf index = "idProyecto" Then
                Return Me.idProyecto.ToString()
            ElseIf index = "idCliente" Then
                Return Me.idCliente.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            ElseIf index = "direccion" Then
                Return Me.direccion.ToString()
            ElseIf index = "fechaInstalacion" Then
                Return Me.fechaInstalacion.ToString()
            ElseIf index = "observacion" Then
                Return Me.observacion.ToString()
            ElseIf index = "manzana" Then
                Return Me.manzana.ToString()
            ElseIf index = "lote" Then
                Return Me.lote.ToString()
            ElseIf index = "saldoInicial" Then
                Return Me.saldoInicial.ToString()
            ElseIf index = "lecturaInicial" Then
                Return Me.lecturaInicial.ToString()
            ElseIf index = "noServicios" Then
                Return Me.noServicios.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idAsignacion" Then
                Try
                    Me.idAsignacion = System.Int32.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int32.Parse("0")
                End Try
            ElseIf index = "idProyecto" Then
                Try
                    Me.idProyecto = System.Int16.Parse("0" & value)
                Catch
                    Me.idProyecto = System.Int16.Parse("0")
                End Try
            ElseIf index = "idCliente" Then
                Try
                    Me.idCliente = System.Int32.Parse("0" & value)
                Catch
                    Me.idCliente = System.Int32.Parse("0")
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
            ElseIf index = "direccion" Then
                Me.direccion = value
            ElseIf index = "fechaInstalacion" Then
                Try
                    Me.fechaInstalacion = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fechaInstalacion = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fechaInstalacion = System.DateTime.Now
                End Try
            ElseIf index = "observacion" Then
                Me.observacion = value
            ElseIf index = "manzana" Then
                Me.manzana = value
            ElseIf index = "lote" Then
                Try
                    Me.lote = System.Int32.Parse("0" & value)
                Catch
                    Me.lote = System.Int32.Parse("0")
                End Try
            ElseIf index = "saldoInicial" Then
                Try
                    Me.saldoInicial = System.Decimal.Parse("0" & value)
                Catch
                    Me.saldoInicial = System.Decimal.Parse("0")
                End Try
            ElseIf index = "lecturaInicial" Then
                Try
                    Me.lecturaInicial = System.Decimal.Parse("0" & value)
                Catch
                    Me.lecturaInicial = System.Decimal.Parse("0")
                End Try
            ElseIf index = "noServicios" Then
                Try
                    Me.noServicios = System.Int16.Parse("0" & value)
                Catch
                    Me.noServicios = System.Int16.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM tblAsignacion"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsAsignacion
    Private Shared Function row2clsAsignacion(ByVal r As DataRow) As clsAsignacion
        ' asigna a un objeto clsAsignacion los datos del dataRow indicado
        Dim oclsAsignacion As New clsAsignacion
        '
        oclsAsignacion.idAsignacion = System.Int32.Parse("0" & r("idAsignacion").ToString())
        oclsAsignacion.idProyecto = System.Int16.Parse("0" & r("idProyecto").ToString())
        oclsAsignacion.idCliente = System.Int32.Parse("0" & r("idCliente").ToString())
        Try
            oclsAsignacion.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsAsignacion.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsAsignacion.fecha = DateTime.Now
        End Try
        oclsAsignacion.direccion = r("direccion").ToString()
        Try
            oclsAsignacion.fechaInstalacion = DateTime.Parse(r("fechaInstalacion").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsAsignacion.fechaInstalacion = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsAsignacion.fechaInstalacion = DateTime.Now
        End Try
        oclsAsignacion.observacion = r("observacion").ToString()
        oclsAsignacion.manzana = r("manzana").ToString()
        oclsAsignacion.lote = System.Int32.Parse("0" & r("lote").ToString())
        oclsAsignacion.saldoInicial = System.Decimal.Parse("0" & r("saldoInicial").ToString())
        oclsAsignacion.lecturaInicial = System.Decimal.Parse("0" & r("lecturaInicial").ToString())
        oclsAsignacion.noServicios = System.Int16.Parse("0" & r("noServicios").ToString())
        '
        Return oclsAsignacion
    End Function
    '
    ' asigna un objeto clsAsignacion a la fila indicada
    Private Shared Sub clsAsignacion2Row(ByVal oclsAsignacion As clsAsignacion, ByVal r As DataRow)
        ' asigna un objeto clsAsignacion al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idAsignacion") = oclsAsignacion.idAsignacion
        r("idProyecto") = oclsAsignacion.idProyecto
        r("idCliente") = oclsAsignacion.idCliente
        r("fecha") = oclsAsignacion.fecha
        r("direccion") = oclsAsignacion.direccion
        r("fechaInstalacion") = oclsAsignacion.fechaInstalacion
        r("observacion") = oclsAsignacion.observacion
        r("manzana") = oclsAsignacion.manzana
        r("lote") = oclsAsignacion.lote
        r("saldoInicial") = oclsAsignacion.saldoInicial
        r("lecturaInicial") = oclsAsignacion.lecturaInicial
        r("noServicios") = oclsAsignacion.noServicios
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsAsignacion
    Private Shared Sub nuevoclsAsignacion(ByVal dt As DataTable, ByVal oclsAsignacion As clsAsignacion)
        ' Crear un nuevo clsAsignacion
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsAsignacion = row2clsAsignacion(dr)
        '
        oc.idAsignacion = oclsAsignacion.idAsignacion
        oc.idProyecto = oclsAsignacion.idProyecto
        oc.idCliente = oclsAsignacion.idCliente
        oc.fecha = oclsAsignacion.fecha
        oc.direccion = oclsAsignacion.direccion
        oc.fechaInstalacion = oclsAsignacion.fechaInstalacion
        oc.observacion = oclsAsignacion.observacion
        oc.manzana = oclsAsignacion.manzana
        oc.lote = oclsAsignacion.lote
        oc.saldoInicial = oclsAsignacion.saldoInicial
        oc.lecturaInicial = oclsAsignacion.lecturaInicial
        oc.noServicios = oclsAsignacion.noServicios
        '
        clsAsignacion2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblAsignacion
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsAsignacion")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsAsignacion
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsAsignacion As clsAsignacion = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsAsignacion")
        Dim sel As String = "SELECT * FROM tblAsignacion WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsAsignacion = row2clsAsignacion(dt.Rows(0))
        End If
        Return oclsAsignacion
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idAsignacion existe en la tabla.
    '             TODO: Si en lugar de idAsignacion usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idAsignacion que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblAsignacion WHERE idAsignacion = " & Me.idAsignacion.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsAsignacion")
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
        '       Yo compruebo que sea un campo llamado idAsignacion, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idAsignacion) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblAsignacion SET idProyecto = @idProyecto, idCliente = @idCliente, fecha = @fecha, direccion = @direccion, fechaInstalacion = @fechaInstalacion, observacion = @observacion, manzana = @manzana, lote = @lote, saldoInicial = @saldoInicial, lecturaInicial = @lecturaInicial, noServicios = @noServicios  WHERE (idAsignacion = @idAsignacion)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idAsignacion", SqlDbType.Int, 0, "idAsignacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idProyecto", SqlDbType.SmallInt, 0, "idProyecto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idCliente", SqlDbType.Int, 0, "idCliente")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        da.UpdateCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 100, "direccion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@fechaInstalacion", SqlDbType.DateTime, 0, "fechaInstalacion")
        da.UpdateCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 10, "observacion")
        da.UpdateCommand.Parameters.Add("@manzana", SqlDbType.NVarChar, 2, "manzana")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@lote", SqlDbType.Int, 0, "lote")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@saldoInicial", SqlDbType.Decimal, 0, "saldoInicial")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@lecturaInicial", SqlDbType.Decimal, 0, "lecturaInicial")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@noServicios", SqlDbType.SmallInt, 0, "noServicios")
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
            clsAsignacion2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsAsignacion")
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
        '       Yo compruebo que sea un campo llamado idAsignacion, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblAsignacion (idProyecto, idCliente, fecha, direccion, fechaInstalacion, observacion, manzana, lote, saldoInicial, lecturaInicial, noServicios)  VALUES(@idProyecto, @idCliente, @fecha, @direccion, @fechaInstalacion, @observacion, @manzana, @lote, @saldoInicial, @lecturaInicial, @noServicios)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idAsignacion", SqlDbType.Int, 0, "idAsignacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idProyecto", SqlDbType.SmallInt, 0, "idProyecto")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idCliente", SqlDbType.Int, 0, "idCliente")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        da.InsertCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 100, "direccion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@fechaInstalacion", SqlDbType.DateTime, 0, "fechaInstalacion")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 10, "observacion")
        da.InsertCommand.Parameters.Add("@manzana", SqlDbType.NVarChar, 2, "manzana")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@lote", SqlDbType.Int, 0, "lote")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@saldoInicial", SqlDbType.Decimal, 0, "saldoInicial")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@lecturaInicial", SqlDbType.Decimal, 0, "lecturaInicial")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@noServicios", SqlDbType.SmallInt, 0, "noServicios")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsAsignacion(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsAsignacion"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idAsignacion que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblAsignacion WHERE idAsignacion = " & Me.idAsignacion.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsAsignacion")
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
        '       Yo compruebo que sea un campo llamado idAsignacion, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblAsignacion WHERE (idAsignacion = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "idAsignacion")
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
