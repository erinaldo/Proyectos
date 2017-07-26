'------------------------------------------------------------------------------
' Clase clsContador generada automáticamente con CrearClaseSQL
' de la tabla 'tblContador' de la base 'bdagua'
' Fecha: 08/feb/2009 19:58:17
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
Public Class clsContador
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idContador As System.Int32
    Private _fecha As System.DateTime
    Private _numero As System.String
    Private _disponible As System.Boolean
    Private _bloqueado As System.Boolean
    Private _anulado As System.Boolean
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
    Public Property idContador() As System.Int32
        Get
            Return _idContador
        End Get
        Set(ByVal value As System.Int32)
            _idContador = value
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
    Public Property numero() As System.String
        Get
            Return ajustarAncho(_numero, 50)
        End Get
        Set(ByVal value As System.String)
            _numero = value
        End Set
    End Property
    Public Property disponible() As System.Boolean
        Get
            Return _disponible
        End Get
        Set(ByVal value As System.Boolean)
            _disponible = value
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
    Public Property anulado() As System.Boolean
        Get
            Return _anulado
        End Get
        Set(ByVal value As System.Boolean)
            _anulado = value
        End Set
    End Property
    Public Property observacion() As System.String
        Get
            Return ajustarAncho(_observacion, 50)
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
                Return Me.idContador.ToString()
            ElseIf index = 1 Then
                Return Me.fecha.ToString()
            ElseIf index = 2 Then
                Return Me.numero.ToString()
            ElseIf index = 3 Then
                Return Me.disponible.ToString()
            ElseIf index = 4 Then
                Return Me.bloqueado.ToString()
            ElseIf index = 5 Then
                Return Me.anulado.ToString()
            ElseIf index = 6 Then
                Return Me.observacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idContador = System.Int32.Parse("0" & value)
                Catch
                    Me.idContador = System.Int32.Parse("0")
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
                Me.numero = value
            ElseIf index = 3 Then
                Try
                    Me.disponible = System.Boolean.Parse(value)
                Catch
                    Me.disponible = False
                End Try
            ElseIf index = 4 Then
                Try
                    Me.bloqueado = System.Boolean.Parse(value)
                Catch
                    Me.bloqueado = False
                End Try
            ElseIf index = 5 Then
                Try
                    Me.anulado = System.Boolean.Parse(value)
                Catch
                    Me.anulado = False
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
            If index = "idContador" Then
                Return Me.idContador.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            ElseIf index = "numero" Then
                Return Me.numero.ToString()
            ElseIf index = "disponible" Then
                Return Me.disponible.ToString()
            ElseIf index = "bloqueado" Then
                Return Me.bloqueado.ToString()
            ElseIf index = "anulado" Then
                Return Me.anulado.ToString()
            ElseIf index = "observacion" Then
                Return Me.observacion.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idContador" Then
                Try
                    Me.idContador = System.Int32.Parse("0" & value)
                Catch
                    Me.idContador = System.Int32.Parse("0")
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
            ElseIf index = "numero" Then
                Me.numero = value
            ElseIf index = "disponible" Then
                Try
                    Me.disponible = System.Boolean.Parse(value)
                Catch
                    Me.disponible = False
                End Try
            ElseIf index = "bloqueado" Then
                Try
                    Me.bloqueado = System.Boolean.Parse(value)
                Catch
                    Me.bloqueado = False
                End Try
            ElseIf index = "anulado" Then
                Try
                    Me.anulado = System.Boolean.Parse(value)
                Catch
                    Me.anulado = False
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
    Public Shared CadenaSelect As String = "SELECT * FROM tblContador"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsContador
    Private Shared Function row2clsContador(ByVal r As DataRow) As clsContador
        ' asigna a un objeto clsContador los datos del dataRow indicado
        Dim oclsContador As New clsContador
        '
        oclsContador.idContador = System.Int32.Parse("0" & r("idContador").ToString())
        Try
            oclsContador.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsContador.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsContador.fecha = DateTime.Now
        End Try
        oclsContador.numero = r("numero").ToString()
        Try
            oclsContador.disponible = System.Boolean.Parse(r("disponible").ToString())
        Catch
            oclsContador.disponible = False
        End Try
        Try
            oclsContador.bloqueado = System.Boolean.Parse(r("bloqueado").ToString())
        Catch
            oclsContador.bloqueado = False
        End Try
        Try
            oclsContador.anulado = System.Boolean.Parse(r("anulado").ToString())
        Catch
            oclsContador.anulado = False
        End Try
        oclsContador.observacion = r("observacion").ToString()
        '
        Return oclsContador
    End Function
    '
    ' asigna un objeto clsContador a la fila indicada
    Private Shared Sub clsContador2Row(ByVal oclsContador As clsContador, ByVal r As DataRow)
        ' asigna un objeto clsContador al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idContador") = oclsContador.idContador
        r("fecha") = oclsContador.fecha
        r("numero") = oclsContador.numero
        r("disponible") = oclsContador.disponible
        r("bloqueado") = oclsContador.bloqueado
        r("anulado") = oclsContador.anulado
        r("observacion") = oclsContador.observacion
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsContador
    Private Shared Sub nuevoclsContador(ByVal dt As DataTable, ByVal oclsContador As clsContador)
        ' Crear un nuevo clsContador
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsContador = row2clsContador(dr)
        '
        oc.idContador = oclsContador.idContador
        oc.fecha = oclsContador.fecha
        oc.numero = oclsContador.numero
        oc.disponible = oclsContador.disponible
        oc.bloqueado = oclsContador.bloqueado
        oc.anulado = oclsContador.anulado
        oc.observacion = oclsContador.observacion
        '
        clsContador2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblContador
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsContador")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsContador
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsContador As clsContador = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsContador")
        Dim sel As String = "SELECT * FROM tblContador WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsContador = row2clsContador(dt.Rows(0))
        End If
        Return oclsContador
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idContador existe en la tabla.
    '             TODO: Si en lugar de idContador usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idContador que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblContador WHERE idContador = " & Me.idContador.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsContador")
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
        '       Yo compruebo que sea un campo llamado idContador, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idContador) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblContador SET fecha = @fecha, numero = @numero, disponible = @disponible, bloqueado = @bloqueado, anulado = @anulado, observacion = @observacion  WHERE (idContador = @idContador)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idContador", SqlDbType.Int, 0, "idContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        da.UpdateCommand.Parameters.Add("@numero", SqlDbType.NVarChar, 50, "numero")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@disponible", SqlDbType.Bit, 0, "disponible")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@bloqueado", SqlDbType.Bit, 0, "bloqueado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@anulado", SqlDbType.Bit, 0, "anulado")
        da.UpdateCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 50, "observacion")
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
            clsContador2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsContador")
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
        '       Yo compruebo que sea un campo llamado idContador, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblContador (fecha, numero, disponible, bloqueado, anulado, observacion)  VALUES(@fecha, @numero, @disponible, @bloqueado, @anulado, @observacion)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idContador", SqlDbType.Int, 0, "idContador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        da.InsertCommand.Parameters.Add("@numero", SqlDbType.NVarChar, 50, "numero")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@disponible", SqlDbType.Bit, 0, "disponible")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@bloqueado", SqlDbType.Bit, 0, "bloqueado")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@anulado", SqlDbType.Bit, 0, "anulado")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.NVarChar, 50, "observacion")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsContador(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsContador"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idContador que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblContador WHERE idContador = " & Me.idContador.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsContador")
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
        '       Yo compruebo que sea un campo llamado idContador, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblContador WHERE (idContador = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 0, "idContador")
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
