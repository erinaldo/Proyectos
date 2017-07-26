'------------------------------------------------------------------------------
' Clase clsContrato generada automáticamente con CrearClaseSQL
' de la tabla 'tblContrato' de la base 'bdAgua'
' Fecha: 15/sep/2009 21:09:14
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
Public Class clsContrato
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idContrato As System.Int32
    Private _nombreApellido As System.String
    Private _identificacion As System.String
    Private _domicilio As System.String
    Private _localidad As System.String
    Private _telefono As System.String
    Private _direccionSuministro As System.String
    Private _numeroContador As System.String
    Private _cuotaMensual As System.Decimal
    Private _planta As System.Decimal
    Private _exceso As System.Decimal
    Private _reconexion As System.Decimal
    Private _cedulaOrden As System.String
    Private _cedulaOrdenNumero As System.String
    Private _registro As System.String
    Private _extendidaEn As System.String
    Private _numeroContrato As System.Int32
    Private _idAsignacion As System.Int32
    Private _fecha As System.DateTime
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
    Public Property idContrato() As System.Int32
        Get
            Return _idContrato
        End Get
        Set(ByVal value As System.Int32)
            _idContrato = value
        End Set
    End Property
    Public Property nombreApellido() As System.String
        Get
            Return ajustarAncho(_nombreApellido, 100)
        End Get
        Set(ByVal value As System.String)
            _nombreApellido = value
        End Set
    End Property
    Public Property identificacion() As System.String
        Get
            Return ajustarAncho(_identificacion, 50)
        End Get
        Set(ByVal value As System.String)
            _identificacion = value
        End Set
    End Property
    Public Property domicilio() As System.String
        Get
            Return ajustarAncho(_domicilio, 100)
        End Get
        Set(ByVal value As System.String)
            _domicilio = value
        End Set
    End Property
    Public Property localidad() As System.String
        Get
            Return ajustarAncho(_localidad, 50)
        End Get
        Set(ByVal value As System.String)
            _localidad = value
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
    Public Property direccionSuministro() As System.String
        Get
            Return ajustarAncho(_direccionSuministro, 100)
        End Get
        Set(ByVal value As System.String)
            _direccionSuministro = value
        End Set
    End Property
    Public Property numeroContador() As System.String
        Get
            Return ajustarAncho(_numeroContador, 100)
        End Get
        Set(ByVal value As System.String)
            _numeroContador = value
        End Set
    End Property
    Public Property cuotaMensual() As System.Decimal
        Get
            Return _cuotaMensual
        End Get
        Set(ByVal value As System.Decimal)
            _cuotaMensual = value
        End Set
    End Property
    Public Property planta() As System.Decimal
        Get
            Return _planta
        End Get
        Set(ByVal value As System.Decimal)
            _planta = value
        End Set
    End Property
    Public Property exceso() As System.Decimal
        Get
            Return _exceso
        End Get
        Set(ByVal value As System.Decimal)
            _exceso = value
        End Set
    End Property
    Public Property reconexion() As System.Decimal
        Get
            Return _reconexion
        End Get
        Set(ByVal value As System.Decimal)
            _reconexion = value
        End Set
    End Property
    Public Property cedulaOrden() As System.String
        Get
            Return ajustarAncho(_cedulaOrden, 50)
        End Get
        Set(ByVal value As System.String)
            _cedulaOrden = value
        End Set
    End Property
    Public Property cedulaOrdenNumero() As System.String
        Get
            Return ajustarAncho(_cedulaOrdenNumero, 50)
        End Get
        Set(ByVal value As System.String)
            _cedulaOrdenNumero = value
        End Set
    End Property
    Public Property registro() As System.String
        Get
            Return ajustarAncho(_registro, 50)
        End Get
        Set(ByVal value As System.String)
            _registro = value
        End Set
    End Property
    Public Property extendidaEn() As System.String
        Get
            Return ajustarAncho(_extendidaEn, 50)
        End Get
        Set(ByVal value As System.String)
            _extendidaEn = value
        End Set
    End Property
    Public Property numeroContrato() As System.Int32
        Get
            Return _numeroContrato
        End Get
        Set(ByVal value As System.Int32)
            _numeroContrato = value
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
    Public Property fecha() As System.DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As System.DateTime)
            _fecha = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idContrato.ToString()
            ElseIf index = 1 Then
                Return Me.nombreApellido.ToString()
            ElseIf index = 2 Then
                Return Me.identificacion.ToString()
            ElseIf index = 3 Then
                Return Me.domicilio.ToString()
            ElseIf index = 4 Then
                Return Me.localidad.ToString()
            ElseIf index = 5 Then
                Return Me.telefono.ToString()
            ElseIf index = 6 Then
                Return Me.direccionSuministro.ToString()
            ElseIf index = 7 Then
                Return Me.numeroContador.ToString()
            ElseIf index = 8 Then
                Return Me.cuotaMensual.ToString()
            ElseIf index = 9 Then
                Return Me.planta.ToString()
            ElseIf index = 10 Then
                Return Me.exceso.ToString()
            ElseIf index = 11 Then
                Return Me.reconexion.ToString()
            ElseIf index = 12 Then
                Return Me.cedulaOrden.ToString()
            ElseIf index = 13 Then
                Return Me.cedulaOrdenNumero.ToString()
            ElseIf index = 14 Then
                Return Me.registro.ToString()
            ElseIf index = 15 Then
                Return Me.extendidaEn.ToString()
            ElseIf index = 16 Then
                Return Me.numeroContrato.ToString()
            ElseIf index = 17 Then
                Return Me.idAsignacion.ToString()
            ElseIf index = 18 Then
                Return Me.fecha.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idContrato = System.Int32.Parse("0" & value)
                Catch
                    Me.idContrato = System.Int32.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.nombreApellido = value
            ElseIf index = 2 Then
                Me.identificacion = value
            ElseIf index = 3 Then
                Me.domicilio = value
            ElseIf index = 4 Then
                Me.localidad = value
            ElseIf index = 5 Then
                Me.telefono = value
            ElseIf index = 6 Then
                Me.direccionSuministro = value
            ElseIf index = 7 Then
                Me.numeroContador = value
            ElseIf index = 8 Then
                Try
                    Me.cuotaMensual = System.Decimal.Parse("0" & value)
                Catch
                    Me.cuotaMensual = System.Decimal.Parse("0")
                End Try
            ElseIf index = 9 Then
                Try
                    Me.planta = System.Decimal.Parse("0" & value)
                Catch
                    Me.planta = System.Decimal.Parse("0")
                End Try
            ElseIf index = 10 Then
                Try
                    Me.exceso = System.Decimal.Parse("0" & value)
                Catch
                    Me.exceso = System.Decimal.Parse("0")
                End Try
            ElseIf index = 11 Then
                Try
                    Me.reconexion = System.Decimal.Parse("0" & value)
                Catch
                    Me.reconexion = System.Decimal.Parse("0")
                End Try
            ElseIf index = 12 Then
                Me.cedulaOrden = value
            ElseIf index = 13 Then
                Me.cedulaOrdenNumero = value
            ElseIf index = 14 Then
                Me.registro = value
            ElseIf index = 15 Then
                Me.extendidaEn = value
            ElseIf index = 16 Then
                Try
                    Me.numeroContrato = System.Int32.Parse("0" & value)
                Catch
                    Me.numeroContrato = System.Int32.Parse("0")
                End Try
            ElseIf index = 17 Then
                Try
                    Me.idAsignacion = System.Int32.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int32.Parse("0")
                End Try
            ElseIf index = 18 Then
                Try
                    Me.fecha = System.DateTime.Parse(value)
                Catch
                    ' TODO: Usa el valor de fecha que quieras predeterminar
                    '       Una fecha ficticia:
                    'Me.fecha = New System.DateTime(1900, 1, 1)
                    '       o la fecha de hoy:
                    Me.fecha = System.DateTime.Now
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idContrato" Then
                Return Me.idContrato.ToString()
            ElseIf index = "nombreApellido" Then
                Return Me.nombreApellido.ToString()
            ElseIf index = "identificacion" Then
                Return Me.identificacion.ToString()
            ElseIf index = "domicilio" Then
                Return Me.domicilio.ToString()
            ElseIf index = "localidad" Then
                Return Me.localidad.ToString()
            ElseIf index = "telefono" Then
                Return Me.telefono.ToString()
            ElseIf index = "direccionSuministro" Then
                Return Me.direccionSuministro.ToString()
            ElseIf index = "numeroContador" Then
                Return Me.numeroContador.ToString()
            ElseIf index = "cuotaMensual" Then
                Return Me.cuotaMensual.ToString()
            ElseIf index = "planta" Then
                Return Me.planta.ToString()
            ElseIf index = "exceso" Then
                Return Me.exceso.ToString()
            ElseIf index = "reconexion" Then
                Return Me.reconexion.ToString()
            ElseIf index = "cedulaOrden" Then
                Return Me.cedulaOrden.ToString()
            ElseIf index = "cedulaOrdenNumero" Then
                Return Me.cedulaOrdenNumero.ToString()
            ElseIf index = "registro" Then
                Return Me.registro.ToString()
            ElseIf index = "extendidaEn" Then
                Return Me.extendidaEn.ToString()
            ElseIf index = "numeroContrato" Then
                Return Me.numeroContrato.ToString()
            ElseIf index = "idAsignacion" Then
                Return Me.idAsignacion.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idContrato" Then
                Try
                    Me.idContrato = System.Int32.Parse("0" & value)
                Catch
                    Me.idContrato = System.Int32.Parse("0")
                End Try
            ElseIf index = "nombreApellido" Then
                Me.nombreApellido = value
            ElseIf index = "identificacion" Then
                Me.identificacion = value
            ElseIf index = "domicilio" Then
                Me.domicilio = value
            ElseIf index = "localidad" Then
                Me.localidad = value
            ElseIf index = "telefono" Then
                Me.telefono = value
            ElseIf index = "direccionSuministro" Then
                Me.direccionSuministro = value
            ElseIf index = "numeroContador" Then
                Me.numeroContador = value
            ElseIf index = "cuotaMensual" Then
                Try
                    Me.cuotaMensual = System.Decimal.Parse("0" & value)
                Catch
                    Me.cuotaMensual = System.Decimal.Parse("0")
                End Try
            ElseIf index = "planta" Then
                Try
                    Me.planta = System.Decimal.Parse("0" & value)
                Catch
                    Me.planta = System.Decimal.Parse("0")
                End Try
            ElseIf index = "exceso" Then
                Try
                    Me.exceso = System.Decimal.Parse("0" & value)
                Catch
                    Me.exceso = System.Decimal.Parse("0")
                End Try
            ElseIf index = "reconexion" Then
                Try
                    Me.reconexion = System.Decimal.Parse("0" & value)
                Catch
                    Me.reconexion = System.Decimal.Parse("0")
                End Try
            ElseIf index = "cedulaOrden" Then
                Me.cedulaOrden = value
            ElseIf index = "cedulaOrdenNumero" Then
                Me.cedulaOrdenNumero = value
            ElseIf index = "registro" Then
                Me.registro = value
            ElseIf index = "extendidaEn" Then
                Me.extendidaEn = value
            ElseIf index = "numeroContrato" Then
                Try
                    Me.numeroContrato = System.Int32.Parse("0" & value)
                Catch
                    Me.numeroContrato = System.Int32.Parse("0")
                End Try
            ElseIf index = "idAsignacion" Then
                Try
                    Me.idAsignacion = System.Int32.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int32.Parse("0")
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
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = mdlPublicVars.cnn
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM tblContrato"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsContrato
    Private Shared Function row2clsContrato(ByVal r As DataRow) As clsContrato
        ' asigna a un objeto clsContrato los datos del dataRow indicado
        Dim oclsContrato As New clsContrato
        '
        oclsContrato.idContrato = System.Int32.Parse("0" & r("idContrato").ToString())
        oclsContrato.nombreApellido = r("nombreApellido").ToString()
        oclsContrato.identificacion = r("identificacion").ToString()
        oclsContrato.domicilio = r("domicilio").ToString()
        oclsContrato.localidad = r("localidad").ToString()
        oclsContrato.telefono = r("telefono").ToString()
        oclsContrato.direccionSuministro = r("direccionSuministro").ToString()
        oclsContrato.numeroContador = r("numeroContador").ToString()
        oclsContrato.cuotaMensual = System.Decimal.Parse("0" & r("cuotaMensual").ToString())
        oclsContrato.planta = System.Decimal.Parse("0" & r("planta").ToString())
        oclsContrato.exceso = System.Decimal.Parse("0" & r("exceso").ToString())
        oclsContrato.reconexion = System.Decimal.Parse("0" & r("reconexion").ToString())
        oclsContrato.cedulaOrden = r("cedulaOrden").ToString()
        oclsContrato.cedulaOrdenNumero = r("cedulaOrdenNumero").ToString()
        oclsContrato.registro = r("registro").ToString()
        oclsContrato.extendidaEn = r("extendidaEn").ToString()
        oclsContrato.numeroContrato = System.Int32.Parse("0" & r("numeroContrato").ToString())
        oclsContrato.idAsignacion = System.Int32.Parse("0" & r("idAsignacion").ToString())
        Try
            oclsContrato.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsContrato.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsContrato.fecha = DateTime.Now
        End Try
        '
        Return oclsContrato
    End Function
    '
    ' asigna un objeto clsContrato a la fila indicada
    Private Shared Sub clsContrato2Row(ByVal oclsContrato As clsContrato, ByVal r As DataRow)
        ' asigna un objeto clsContrato al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idContrato") = oclsContrato.idContrato
        r("nombreApellido") = oclsContrato.nombreApellido
        r("identificacion") = oclsContrato.identificacion
        r("domicilio") = oclsContrato.domicilio
        r("localidad") = oclsContrato.localidad
        r("telefono") = oclsContrato.telefono
        r("direccionSuministro") = oclsContrato.direccionSuministro
        r("numeroContador") = oclsContrato.numeroContador
        r("cuotaMensual") = oclsContrato.cuotaMensual
        r("planta") = oclsContrato.planta
        r("exceso") = oclsContrato.exceso
        r("reconexion") = oclsContrato.reconexion
        r("cedulaOrden") = oclsContrato.cedulaOrden
        r("cedulaOrdenNumero") = oclsContrato.cedulaOrdenNumero
        r("registro") = oclsContrato.registro
        r("extendidaEn") = oclsContrato.extendidaEn
        r("numeroContrato") = oclsContrato.numeroContrato
        r("idAsignacion") = oclsContrato.idAsignacion
        r("fecha") = oclsContrato.fecha
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsContrato
    Private Shared Sub nuevoclsContrato(ByVal dt As DataTable, ByVal oclsContrato As clsContrato)
        ' Crear un nuevo clsContrato
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsContrato = row2clsContrato(dr)
        '
        oc.idContrato = oclsContrato.idContrato
        oc.nombreApellido = oclsContrato.nombreApellido
        oc.identificacion = oclsContrato.identificacion
        oc.domicilio = oclsContrato.domicilio
        oc.localidad = oclsContrato.localidad
        oc.telefono = oclsContrato.telefono
        oc.direccionSuministro = oclsContrato.direccionSuministro
        oc.numeroContador = oclsContrato.numeroContador
        oc.cuotaMensual = oclsContrato.cuotaMensual
        oc.planta = oclsContrato.planta
        oc.exceso = oclsContrato.exceso
        oc.reconexion = oclsContrato.reconexion
        oc.cedulaOrden = oclsContrato.cedulaOrden
        oc.cedulaOrdenNumero = oclsContrato.cedulaOrdenNumero
        oc.registro = oclsContrato.registro
        oc.extendidaEn = oclsContrato.extendidaEn
        oc.numeroContrato = oclsContrato.numeroContrato
        oc.idAsignacion = oclsContrato.idAsignacion
        oc.fecha = oclsContrato.fecha
        '
        clsContrato2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblContrato
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsContrato")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsContrato
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsContrato As clsContrato = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsContrato")
        Dim sel As String = "SELECT * FROM tblContrato WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsContrato = row2clsContrato(dt.Rows(0))
        End If
        Return oclsContrato
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idContrato existe en la tabla.
    '             TODO: Si en lugar de idContrato usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idContrato que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblContrato WHERE idContrato = " & Me.idContrato.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsContrato")
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
        '       Yo compruebo que sea un campo llamado idContrato, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idContrato) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblContrato SET nombreApellido = @nombreApellido, identificacion = @identificacion, domicilio = @domicilio, localidad = @localidad, telefono = @telefono, direccionSuministro = @direccionSuministro, numeroContador = @numeroContador, cuotaMensual = @cuotaMensual, planta = @planta, exceso = @exceso, reconexion = @reconexion, cedulaOrden = @cedulaOrden, cedulaOrdenNumero = @cedulaOrdenNumero, registro = @registro, extendidaEn = @extendidaEn, numeroContrato = @numeroContrato, idAsignacion = @idAsignacion, fecha = @fecha  WHERE (idContrato = @idContrato)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idContrato", SqlDbType.Int, 0, "idContrato")
        da.UpdateCommand.Parameters.Add("@nombreApellido", SqlDbType.NVarChar, 100, "nombreApellido")
        da.UpdateCommand.Parameters.Add("@identificacion", SqlDbType.NVarChar, 50, "identificacion")
        da.UpdateCommand.Parameters.Add("@domicilio", SqlDbType.NVarChar, 100, "domicilio")
        da.UpdateCommand.Parameters.Add("@localidad", SqlDbType.NVarChar, 50, "localidad")
        da.UpdateCommand.Parameters.Add("@telefono", SqlDbType.NVarChar, 50, "telefono")
        da.UpdateCommand.Parameters.Add("@direccionSuministro", SqlDbType.NVarChar, 100, "direccionSuministro")
        da.UpdateCommand.Parameters.Add("@numeroContador", SqlDbType.NVarChar, 100, "numeroContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@cuotaMensual", SqlDbType.Decimal, 0, "cuotaMensual")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@planta", SqlDbType.Decimal, 0, "planta")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@exceso", SqlDbType.Decimal, 0, "exceso")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@reconexion", SqlDbType.Decimal, 0, "reconexion")
        da.UpdateCommand.Parameters.Add("@cedulaOrden", SqlDbType.NVarChar, 50, "cedulaOrden")
        da.UpdateCommand.Parameters.Add("@cedulaOrdenNumero", SqlDbType.NVarChar, 50, "cedulaOrdenNumero")
        da.UpdateCommand.Parameters.Add("@registro", SqlDbType.NVarChar, 50, "registro")
        da.UpdateCommand.Parameters.Add("@extendidaEn", SqlDbType.NVarChar, 50, "extendidaEn")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@numeroContrato", SqlDbType.Int, 0, "numeroContrato")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idAsignacion", SqlDbType.Int, 0, "idAsignacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
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
            clsContrato2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsContrato")
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
        '       Yo compruebo que sea un campo llamado idContrato, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblContrato (nombreApellido, identificacion, domicilio, localidad, telefono, direccionSuministro, numeroContador, cuotaMensual, planta, exceso, reconexion, cedulaOrden, cedulaOrdenNumero, registro, extendidaEn, numeroContrato, idAsignacion, fecha)  VALUES(@nombreApellido, @identificacion, @domicilio, @localidad, @telefono, @direccionSuministro, @numeroContador, @cuotaMensual, @planta, @exceso, @reconexion, @cedulaOrden, @cedulaOrdenNumero, @registro, @extendidaEn, @numeroContrato, @idAsignacion, @fecha)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idContrato", SqlDbType.Int, 0, "idContrato")
        da.InsertCommand.Parameters.Add("@nombreApellido", SqlDbType.NVarChar, 100, "nombreApellido")
        da.InsertCommand.Parameters.Add("@identificacion", SqlDbType.NVarChar, 50, "identificacion")
        da.InsertCommand.Parameters.Add("@domicilio", SqlDbType.NVarChar, 100, "domicilio")
        da.InsertCommand.Parameters.Add("@localidad", SqlDbType.NVarChar, 50, "localidad")
        da.InsertCommand.Parameters.Add("@telefono", SqlDbType.NVarChar, 50, "telefono")
        da.InsertCommand.Parameters.Add("@direccionSuministro", SqlDbType.NVarChar, 100, "direccionSuministro")
        da.InsertCommand.Parameters.Add("@numeroContador", SqlDbType.NVarChar, 100, "numeroContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@cuotaMensual", SqlDbType.Decimal, 0, "cuotaMensual")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@planta", SqlDbType.Decimal, 0, "planta")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@exceso", SqlDbType.Decimal, 0, "exceso")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@reconexion", SqlDbType.Decimal, 0, "reconexion")
        da.InsertCommand.Parameters.Add("@cedulaOrden", SqlDbType.NVarChar, 50, "cedulaOrden")
        da.InsertCommand.Parameters.Add("@cedulaOrdenNumero", SqlDbType.NVarChar, 50, "cedulaOrdenNumero")
        da.InsertCommand.Parameters.Add("@registro", SqlDbType.NVarChar, 50, "registro")
        da.InsertCommand.Parameters.Add("@extendidaEn", SqlDbType.NVarChar, 50, "extendidaEn")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@numeroContrato", SqlDbType.Int, 0, "numeroContrato")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idAsignacion", SqlDbType.Int, 0, "idAsignacion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsContrato(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsContrato"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idContrato que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblContrato WHERE idContrato = " & Me.idContrato.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsContrato")
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
        '       Yo compruebo que sea un campo llamado idContrato, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblContrato WHERE (idContrato = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "idContrato")
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
