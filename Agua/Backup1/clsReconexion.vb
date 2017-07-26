'------------------------------------------------------------------------------
' Clase clsReconexion generada automáticamente con CrearClaseSQL
' de la tabla 'tblReconexion' de la base 'bdagua'
' Fecha: 10/feb/2009 05:58:30
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
Public Class clsReconexion
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idReconexion As System.Int32
    Private _fecha As System.DateTime
    Private _idUsuario As System.Int16
    Private _idContador As System.Int32
    Private _idLectura As System.Int32
    Private _monto As System.Decimal
    Private _observacion As System.String
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
    Public Property idReconexion() As System.Int32
        Get
            Return _idReconexion
        End Get
        Set(ByVal value As System.Int32)
            _idReconexion = value
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
    Public Property idContador() As System.Int32
        Get
            Return _idContador
        End Get
        Set(ByVal value As System.Int32)
            _idContador = value
        End Set
    End Property
    Public Property idLectura() As System.Int32
        Get
            Return _idLectura
        End Get
        Set(ByVal value As System.Int32)
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
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idReconexion.ToString()
            ElseIf index = 1 Then
                Return Me.fecha.ToString()
            ElseIf index = 2 Then
                Return Me.idUsuario.ToString()
            ElseIf index = 3 Then
                Return Me.idContador.ToString()
            ElseIf index = 4 Then
                Return Me.idLectura.ToString()
            ElseIf index = 5 Then
                Return Me.monto.ToString()
            ElseIf index = 6 Then
                Return Me.observacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idReconexion = System.Int32.Parse("0" & value)
                Catch
                    Me.idReconexion = System.Int32.Parse("0")
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
                    Me.idContador = System.Int32.Parse("0" & value)
                Catch
                    Me.idContador = System.Int32.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.idLectura = System.Int32.Parse("0" & value)
                Catch
                    Me.idLectura = System.Int32.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.monto = System.Decimal.Parse("0" & value)
                Catch
                    Me.monto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 6 Then
                Me.observacion = value
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idReconexion" Then
                Return Me.idReconexion.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            ElseIf index = "idUsuario" Then
                Return Me.idUsuario.ToString()
            ElseIf index = "idContador" Then
                Return Me.idContador.ToString()
            ElseIf index = "idLectura" Then
                Return Me.idLectura.ToString()
            ElseIf index = "monto" Then
                Return Me.monto.ToString()
            ElseIf index = "observacion" Then
                Return Me.observacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idReconexion" Then
                Try
                    Me.idReconexion = System.Int32.Parse("0" & value)
                Catch
                    Me.idReconexion = System.Int32.Parse("0")
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
            ElseIf index = "idContador" Then
                Try
                    Me.idContador = System.Int32.Parse("0" & value)
                Catch
                    Me.idContador = System.Int32.Parse("0")
                End Try
            ElseIf index = "idLectura" Then
                Try
                    Me.idLectura = System.Int32.Parse("0" & value)
                Catch
                    Me.idLectura = System.Int32.Parse("0")
                End Try
            ElseIf index = "monto" Then
                Try
                    Me.monto = System.Decimal.Parse("0" & value)
                Catch
                    Me.monto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "observacion" Then
                Me.observacion = value
            End If
        End Set
    End Property
    '
    ' Campos y métodos compartidos (estáticos) para gestionar la base de datos
    '
    ' La cadena de conexión a la base de datos
    Private Shared cadenaConexion As String = mdlPublicVars.cnn
    ' La cadena de selección
    Public Shared CadenaSelect As String = "SELECT * FROM tblReconexion"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsReconexion
    Private Shared Function row2clsReconexion(ByVal r As DataRow) As clsReconexion
        ' asigna a un objeto clsReconexion los datos del dataRow indicado
        Dim oclsReconexion As New clsReconexion
        '
        oclsReconexion.idReconexion = System.Int32.Parse("0" & r("idReconexion").ToString())
        Try
            oclsReconexion.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsReconexion.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsReconexion.fecha = DateTime.Now
        End Try
        oclsReconexion.idUsuario = System.Int16.Parse("0" & r("idUsuario").ToString())
        oclsReconexion.idContador = System.Int32.Parse("0" & r("idContador").ToString())
        oclsReconexion.idLectura = System.Int32.Parse("0" & r("idLectura").ToString())
        oclsReconexion.monto = System.Decimal.Parse("0" & r("monto").ToString())
        oclsReconexion.observacion = r("observacion").ToString()
        '
        Return oclsReconexion
    End Function
    '
    ' asigna un objeto clsReconexion a la fila indicada
    Private Shared Sub clsReconexion2Row(ByVal oclsReconexion As clsReconexion, ByVal r As DataRow)
        ' asigna un objeto clsReconexion al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idReconexion") = oclsReconexion.idReconexion
        r("fecha") = oclsReconexion.fecha
        r("idUsuario") = oclsReconexion.idUsuario
        r("idContador") = oclsReconexion.idContador
        r("idLectura") = oclsReconexion.idLectura
        r("monto") = oclsReconexion.monto
        r("observacion") = oclsReconexion.observacion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsReconexion
    Private Shared Sub nuevoclsReconexion(ByVal dt As DataTable, ByVal oclsReconexion As clsReconexion)
        ' Crear un nuevo clsReconexion
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsReconexion = row2clsReconexion(dr)
        '
        oc.idReconexion = oclsReconexion.idReconexion
        oc.fecha = oclsReconexion.fecha
        oc.idUsuario = oclsReconexion.idUsuario
        oc.idContador = oclsReconexion.idContador
        oc.idLectura = oclsReconexion.idLectura
        oc.monto = oclsReconexion.monto
        oc.observacion = oclsReconexion.observacion
        '
        clsReconexion2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblReconexion
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsReconexion")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsReconexion
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsReconexion As clsReconexion = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsReconexion")
        Dim sel As String = "SELECT * FROM tblReconexion WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsReconexion = row2clsReconexion(dt.Rows(0))
        End If
        Return oclsReconexion
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idReconexion existe en la tabla.
    '             TODO: Si en lugar de idReconexion usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idReconexion que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblReconexion WHERE idReconexion = " & Me.idReconexion.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsReconexion")
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
        '       Yo compruebo que sea un campo llamado idReconexion, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idReconexion) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblReconexion SET fecha = @fecha, idUsuario = @idUsuario, idContador = @idContador, idLectura = @idLectura, monto = @monto, observacion = @observacion  WHERE (idReconexion = @idReconexion)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idReconexion", SqlDbType.Int, 0, "idReconexion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idUsuario", SqlDbType.SmallInt, 0, "idUsuario")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idContador", SqlDbType.Int, 0, "idContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idLectura", SqlDbType.Int, 0, "idLectura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@monto", SqlDbType.Decimal, 0, "monto")
        da.UpdateCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 200, "observacion")
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
            clsReconexion2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsReconexion")
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
        '       Yo compruebo que sea un campo llamado idReconexion, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblReconexion (fecha, idUsuario, idContador, idLectura, monto, observacion)  VALUES(@fecha, @idUsuario, @idContador, @idLectura, @monto, @observacion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idReconexion", SqlDbType.Int, 0, "idReconexion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idUsuario", SqlDbType.SmallInt, 0, "idUsuario")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idContador", SqlDbType.Int, 0, "idContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idLectura", SqlDbType.Int, 0, "idLectura")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@monto", SqlDbType.Decimal, 0, "monto")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 200, "observacion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsReconexion(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsReconexion"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idReconexion que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblReconexion WHERE idReconexion = " & Me.idReconexion.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsReconexion")
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
        '       Yo compruebo que sea un campo llamado idReconexion, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblReconexion WHERE (idReconexion = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "idReconexion")
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
