
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
    Private _idReconexion As System.Int64
    Private _fecha As System.DateTime
    Private _idLectura As System.Int32
    Private _idAsignacion As System.Int64
    Private _idFactura As System.Int64
    Private _idAsignacionContador As System.Int64
    Private _monto As System.Decimal
    Private _Observacion As System.String
    Private _usuario As System.String
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
    Public Property idReconexion() As System.Int64
        Get
            Return _idReconexion
        End Get
        Set(value As System.Int64)
            _idReconexion = value
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
    Public Property idLectura() As System.Int32
        Get
            Return _idLectura
        End Get
        Set(value As System.Int32)
            _idLectura = value
        End Set
    End Property
    Public Property idAsignacion() As System.Int64
        Get
            Return _idAsignacion
        End Get
        Set(value As System.Int64)
            _idAsignacion = value
        End Set
    End Property
    Public Property idFactura() As System.Int64
        Get
            Return _idFactura
        End Get
        Set(value As System.Int64)
            _idFactura = value
        End Set
    End Property
    Public Property idAsignacionContador() As System.Int64
        Get
            Return _idAsignacionContador
        End Get
        Set(value As System.Int64)
            _idAsignacionContador = value
        End Set
    End Property
    Public Property monto() As System.Decimal
        Get
            Return _monto
        End Get
        Set(value As System.Decimal)
            _monto = value
        End Set
    End Property
    Public Property Observacion() As System.String
        Get
            Return ajustarAncho(_Observacion, 100)
        End Get
        Set(value As System.String)
            _Observacion = value
        End Set
    End Property
    Public Property usuario() As System.String
        Get
            Return ajustarAncho(_usuario, 50)
        End Get
        Set(value As System.String)
            _usuario = value
        End Set
    End Property
    '
    Default Public Property Item(index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idReconexion.ToString()
            ElseIf index = 1 Then
                Return Me.fecha.ToString()
            ElseIf index = 2 Then
                Return Me.idLectura.ToString()
            ElseIf index = 3 Then
                Return Me.idAsignacion.ToString()
            ElseIf index = 4 Then
                Return Me.idFactura.ToString()
            ElseIf index = 5 Then
                Return Me.idAsignacionContador.ToString()
            ElseIf index = 6 Then
                Return Me.monto.ToString()
            ElseIf index = 7 Then
                Return Me.Observacion.ToString()
            ElseIf index = 8 Then
                Return Me.usuario.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = 0 Then
                Try
                    Me.idReconexion = System.Int64.Parse("0" & value)
                Catch
                    Me.idReconexion = System.Int64.Parse("0")
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
                    Me.idLectura = System.Int32.Parse("0" & value)
                Catch
                    Me.idLectura = System.Int32.Parse("0")
                End Try
            ElseIf index = 3 Then
                Try
                    Me.idAsignacion = System.Int64.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int64.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.idFactura = System.Int64.Parse("0" & value)
                Catch
                    Me.idFactura = System.Int64.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.idAsignacionContador = System.Int64.Parse("0" & value)
                Catch
                    Me.idAsignacionContador = System.Int64.Parse("0")
                End Try
            ElseIf index = 6 Then
                Try
                    Me.monto = System.Decimal.Parse("0" & value)
                Catch
                    Me.monto = System.Decimal.Parse("0")
                End Try
            ElseIf index = 7 Then
                Me.Observacion = value
            ElseIf index = 8 Then
                Me.usuario = value
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idReconexion" Then
                Return Me.idReconexion.ToString()
            ElseIf index = "fecha" Then
                Return Me.fecha.ToString()
            ElseIf index = "idLectura" Then
                Return Me.idLectura.ToString()
            ElseIf index = "idAsignacion" Then
                Return Me.idAsignacion.ToString()
            ElseIf index = "idFactura" Then
                Return Me.idFactura.ToString()
            ElseIf index = "idAsignacionContador" Then
                Return Me.idAsignacionContador.ToString()
            ElseIf index = "monto" Then
                Return Me.monto.ToString()
            ElseIf index = "Observacion" Then
                Return Me.Observacion.ToString()
            ElseIf index = "usuario" Then
                Return Me.usuario.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(value As String)
            If index = "idReconexion" Then
                Try
                    Me.idReconexion = System.Int64.Parse("0" & value)
                Catch
                    Me.idReconexion = System.Int64.Parse("0")
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
            ElseIf index = "idLectura" Then
                Try
                    Me.idLectura = System.Int32.Parse("0" & value)
                Catch
                    Me.idLectura = System.Int32.Parse("0")
                End Try
            ElseIf index = "idAsignacion" Then
                Try
                    Me.idAsignacion = System.Int64.Parse("0" & value)
                Catch
                    Me.idAsignacion = System.Int64.Parse("0")
                End Try
            ElseIf index = "idFactura" Then
                Try
                    Me.idFactura = System.Int64.Parse("0" & value)
                Catch
                    Me.idFactura = System.Int64.Parse("0")
                End Try
            ElseIf index = "idAsignacionContador" Then
                Try
                    Me.idAsignacionContador = System.Int64.Parse("0" & value)
                Catch
                    Me.idAsignacionContador = System.Int64.Parse("0")
                End Try
            ElseIf index = "monto" Then
                Try
                    Me.monto = System.Decimal.Parse("0" & value)
                Catch
                    Me.monto = System.Decimal.Parse("0")
                End Try
            ElseIf index = "Observacion" Then
                Me.Observacion = value
            ElseIf index = "usuario" Then
                Me.usuario = value
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
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsReconexion
    Private Shared Function row2clsReconexion(r As DataRow) As clsReconexion
        ' asigna a un objeto clsReconexion los datos del dataRow indicado
        Dim oclsReconexion As New clsReconexion
        '
        oclsReconexion.idReconexion = System.Int64.Parse("0" & r("idReconexion").ToString())
        Try
            oclsReconexion.fecha = DateTime.Parse(r("fecha").ToString())
        Catch
            ' TODO: Usa el valor de fecha que quieras predeterminar
            '       Una fecha ficticia:
            'oclsReconexion.fecha = New DateTime(1900, 1, 1)
            '       o la fecha de hoy:
            oclsReconexion.fecha = DateTime.Now
        End Try
        oclsReconexion.idLectura = System.Int32.Parse("0" & r("idLectura").ToString())
        oclsReconexion.idAsignacion = System.Int64.Parse("0" & r("idAsignacion").ToString())
        oclsReconexion.idFactura = System.Int64.Parse("0" & r("idFactura").ToString())
        oclsReconexion.idAsignacionContador = System.Int64.Parse("0" & r("idAsignacionContador").ToString())
        oclsReconexion.monto = System.Decimal.Parse("0" & r("monto").ToString())
        oclsReconexion.Observacion = r("Observacion").ToString()
        oclsReconexion.usuario = r("usuario").ToString()
        '
        Return oclsReconexion
    End Function
    '
    ' asigna un objeto clsReconexion a la fila indicada
    Private Shared Sub clsReconexion2Row(oclsReconexion As clsReconexion, r As DataRow)
        ' asigna un objeto clsReconexion al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idReconexion") = oclsReconexion.idReconexion
        r("fecha") = oclsReconexion.fecha
        r("idLectura") = oclsReconexion.idLectura
        r("idAsignacion") = oclsReconexion.idAsignacion
        r("idFactura") = oclsReconexion.idFactura
        r("idAsignacionContador") = oclsReconexion.idAsignacionContador
        r("monto") = oclsReconexion.monto
        r("Observacion") = oclsReconexion.Observacion
        r("usuario") = oclsReconexion.usuario
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsReconexion
    Private Shared Sub nuevoclsReconexion(dt As DataTable, oclsReconexion As clsReconexion)
        ' Crear un nuevo clsReconexion
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsReconexion = row2clsReconexion(dr)
        '
        oc.idReconexion = oclsReconexion.idReconexion
        oc.fecha = oclsReconexion.fecha
        oc.idLectura = oclsReconexion.idLectura
        oc.idAsignacion = oclsReconexion.idAsignacion
        oc.idFactura = oclsReconexion.idFactura
        oc.idAsignacionContador = oclsReconexion.idAsignacionContador
        oc.monto = oclsReconexion.monto
        oc.Observacion = oclsReconexion.Observacion
        oc.usuario = oclsReconexion.usuario
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
    Public Shared Function Tabla(sel As String) As DataTable
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
    Public Shared Function Buscar(sWhere As String) As clsReconexion
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
    Public Function Actualizar(sel As String) As String
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
        ''       Yo compruebo que sea un campo llamado idReconexion, pero en tu caso puede ser otro
        ''       Ese campo, (en mi caso idReconexion) será el que hay que poner al final junto al WHERE.
        'sCommand = "UPDATE tblReconexion SET fecha = @fecha, idLectura = @idLectura, idAsignacion = @idAsignacion, idFactura = @idFactura, idAsignacionContador = @idAsignacionContador, monto = @monto, Observacion = @Observacion, usuario = @usuario  WHERE (idReconexion = @idReconexion)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@idReconexion", SqlDbType.BigInt, 0, "idReconexion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@idLectura", SqlDbType.Int, 0, "idLectura")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@idAsignacion", SqlDbType.BigInt, 0, "idAsignacion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@idFactura", SqlDbType.BigInt, 0, "idFactura")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@idAsignacionContador", SqlDbType.BigInt, 0, "idAsignacionContador")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@monto", SqlDbType.Decimal, 0, "monto")
        'da.UpdateCommand.Parameters.Add("@Observacion", SqlDbType.NVarChar, 100, "Observacion")
        'da.UpdateCommand.Parameters.Add("@usuario", SqlDbType.NVarChar, 50, "usuario")
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
        ''       Yo compruebo que sea un campo llamado idReconexion, pero en tu caso puede ser otro
        'sCommand = "INSERT INTO tblReconexion (fecha, idLectura, idAsignacion, idFactura, idAsignacionContador, monto, Observacion, usuario)  VALUES(@fecha, @idLectura, @idAsignacion, @idFactura, @idAsignacionContador, @monto, @Observacion, @usuario)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@idReconexion", SqlDbType.BigInt, 0, "idReconexion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 0, "fecha")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@idLectura", SqlDbType.Int, 0, "idLectura")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@idAsignacion", SqlDbType.BigInt, 0, "idAsignacion")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@idFactura", SqlDbType.BigInt, 0, "idFactura")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@idAsignacionContador", SqlDbType.BigInt, 0, "idAsignacionContador")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@monto", SqlDbType.Decimal, 0, "monto")
        'da.InsertCommand.Parameters.Add("@Observacion", SqlDbType.NVarChar, 100, "Observacion")
        'da.InsertCommand.Parameters.Add("@usuario", SqlDbType.NVarChar, 50, "usuario")
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
    Public Function Borrar(sel As String) As String
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
        ''       Yo compruebo que sea un campo llamado idReconexion, pero en tu caso puede ser otro
        'sCommand = "DELETE FROM tblReconexion WHERE (idReconexion = @p1)"
        'da.DeleteCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.DeleteCommand.Parameters.Add("@p1", SqlDbType.BigInt, 0, "idReconexion")
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
