'------------------------------------------------------------------------------
' Clase clsProyecto generada automáticamente con CrearClaseSQL
' de la tabla 'tblProyecto' de la base 'bdagua'
' Fecha: 01/abr/2009 05:54:37
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
Public Class clsProyecto
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _idProyecto As System.Int16
    Private _nombre As System.String
    Private _direccion As System.String
    Private _cuotaFija As System.Decimal
    Private _aguaFija As System.Decimal
    Private _precioExceso As System.Decimal
    Private _diasPago As System.Int32
    Private _planta As System.Decimal
    Private _reconexion As System.Decimal
    Private _multiplicador As System.Decimal
    Private _mora As System.Decimal
    Private _iva As System.Decimal
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
    Public Property idProyecto() As System.Int16
        Get
            Return _idProyecto
        End Get
        Set(ByVal value As System.Int16)
            _idProyecto = value
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
    Public Property cuotaFija() As System.Decimal
        Get
            Return _cuotaFija
        End Get
        Set(ByVal value As System.Decimal)
            _cuotaFija = value
        End Set
    End Property
    Public Property aguaFija() As System.Decimal
        Get
            Return _aguaFija
        End Get
        Set(ByVal value As System.Decimal)
            _aguaFija = value
        End Set
    End Property
    Public Property precioExceso() As System.Decimal
        Get
            Return _precioExceso
        End Get
        Set(ByVal value As System.Decimal)
            _precioExceso = value
        End Set
    End Property
    Public Property diasPago() As System.Int32
        Get
            Return _diasPago
        End Get
        Set(ByVal value As System.Int32)
            _diasPago = value
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
    Public Property reconexion() As System.Decimal
        Get
            Return _reconexion
        End Get
        Set(ByVal value As System.Decimal)
            _reconexion = value
        End Set
    End Property
    Public Property multiplicador() As System.Decimal
        Get
            Return _multiplicador
        End Get
        Set(ByVal value As System.Decimal)
            _multiplicador = value
        End Set
    End Property
    Public Property mora() As System.Decimal
        Get
            Return _mora
        End Get
        Set(ByVal value As System.Decimal)
            _mora = value
        End Set
    End Property
    Public Property iva() As System.Decimal
        Get
            Return _iva
        End Get
        Set(ByVal value As System.Decimal)
            _iva = value
        End Set
    End Property
    '
    Default Public Property Item(ByVal index As Integer) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde con la columna de la tabla)
        Get
            If index = 0 Then
                Return Me.idProyecto.ToString()
            ElseIf index = 1 Then
                Return Me.nombre.ToString()
            ElseIf index = 2 Then
                Return Me.direccion.ToString()
            ElseIf index = 3 Then
                Return Me.cuotaFija.ToString()
            ElseIf index = 4 Then
                Return Me.aguaFija.ToString()
            ElseIf index = 5 Then
                Return Me.precioExceso.ToString()
            ElseIf index = 6 Then
                Return Me.diasPago.ToString()
            ElseIf index = 7 Then
                Return Me.planta.ToString()
            ElseIf index = 8 Then
                Return Me.reconexion.ToString()
            ElseIf index = 9 Then
                Return Me.multiplicador.ToString()
            ElseIf index = 10 Then
                Return Me.mora.ToString()
            ElseIf index = 11 Then
                Return Me.iva.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = 0 Then
                Try
                    Me.idProyecto = System.Int16.Parse("0" & value)
                Catch
                    Me.idProyecto = System.Int16.Parse("0")
                End Try
            ElseIf index = 1 Then
                Me.nombre = value
            ElseIf index = 2 Then
                Me.direccion = value
            ElseIf index = 3 Then
                Try
                    Me.cuotaFija = System.Decimal.Parse("0" & value)
                Catch
                    Me.cuotaFija = System.Decimal.Parse("0")
                End Try
            ElseIf index = 4 Then
                Try
                    Me.aguaFija = System.Decimal.Parse("0" & value)
                Catch
                    Me.aguaFija = System.Decimal.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.precioExceso = System.Decimal.Parse("0" & value)
                Catch
                    Me.precioExceso = System.Decimal.Parse("0")
                End Try
            ElseIf index = 6 Then
                Try
                    Me.diasPago = System.Int32.Parse("0" & value)
                Catch
                    Me.diasPago = System.Int32.Parse("0")
                End Try
            ElseIf index = 7 Then
                Try
                    Me.planta = System.Decimal.Parse("0" & value)
                Catch
                    Me.planta = System.Decimal.Parse("0")
                End Try
            ElseIf index = 8 Then
                Try
                    Me.reconexion = System.Decimal.Parse("0" & value)
                Catch
                    Me.reconexion = System.Decimal.Parse("0")
                End Try
            ElseIf index = 9 Then
                Try
                    Me.multiplicador = System.Decimal.Parse("0" & value)
                Catch
                    Me.multiplicador = System.Decimal.Parse("0")
                End Try
            ElseIf index = 10 Then
                Try
                    Me.mora = System.Decimal.Parse("0" & value)
                Catch
                    Me.mora = System.Decimal.Parse("0")
                End Try
            ElseIf index = 11 Then
                Try
                    Me.iva = System.Decimal.Parse("0" & value)
                Catch
                    Me.iva = System.Decimal.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(ByVal index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "idProyecto" Then
                Return Me.idProyecto.ToString()
            ElseIf index = "nombre" Then
                Return Me.nombre.ToString()
            ElseIf index = "direccion" Then
                Return Me.direccion.ToString()
            ElseIf index = "cuotaFija" Then
                Return Me.cuotaFija.ToString()
            ElseIf index = "aguaFija" Then
                Return Me.aguaFija.ToString()
            ElseIf index = "precioExceso" Then
                Return Me.precioExceso.ToString()
            ElseIf index = "diasPago" Then
                Return Me.diasPago.ToString()
            ElseIf index = "planta" Then
                Return Me.planta.ToString()
            ElseIf index = "reconexion" Then
                Return Me.reconexion.ToString()
            ElseIf index = "multiplicador" Then
                Return Me.multiplicador.ToString()
            ElseIf index = "mora" Then
                Return Me.mora.ToString()
            ElseIf index = "iva" Then
                Return Me.iva.ToString()
            End If
            ' Para que no de error el compilador de C#
            Return ""
        End Get
        Set(ByVal value As String)
            If index = "idProyecto" Then
                Try
                    Me.idProyecto = System.Int16.Parse("0" & value)
                Catch
                    Me.idProyecto = System.Int16.Parse("0")
                End Try
            ElseIf index = "nombre" Then
                Me.nombre = value
            ElseIf index = "direccion" Then
                Me.direccion = value
            ElseIf index = "cuotaFija" Then
                Try
                    Me.cuotaFija = System.Decimal.Parse("0" & value)
                Catch
                    Me.cuotaFija = System.Decimal.Parse("0")
                End Try
            ElseIf index = "aguaFija" Then
                Try
                    Me.aguaFija = System.Decimal.Parse("0" & value)
                Catch
                    Me.aguaFija = System.Decimal.Parse("0")
                End Try
            ElseIf index = "precioExceso" Then
                Try
                    Me.precioExceso = System.Decimal.Parse("0" & value)
                Catch
                    Me.precioExceso = System.Decimal.Parse("0")
                End Try
            ElseIf index = "diasPago" Then
                Try
                    Me.diasPago = System.Int32.Parse("0" & value)
                Catch
                    Me.diasPago = System.Int32.Parse("0")
                End Try
            ElseIf index = "planta" Then
                Try
                    Me.planta = System.Decimal.Parse("0" & value)
                Catch
                    Me.planta = System.Decimal.Parse("0")
                End Try
            ElseIf index = "reconexion" Then
                Try
                    Me.reconexion = System.Decimal.Parse("0" & value)
                Catch
                    Me.reconexion = System.Decimal.Parse("0")
                End Try
            ElseIf index = "multiplicador" Then
                Try
                    Me.multiplicador = System.Decimal.Parse("0" & value)
                Catch
                    Me.multiplicador = System.Decimal.Parse("0")
                End Try
            ElseIf index = "mora" Then
                Try
                    Me.mora = System.Decimal.Parse("0" & value)
                Catch
                    Me.mora = System.Decimal.Parse("0")
                End Try
            ElseIf index = "iva" Then
                Try
                    Me.iva = System.Decimal.Parse("0" & value)
                Catch
                    Me.iva = System.Decimal.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM tblProyecto"
    '
    Public Sub New()
    End Sub
    Public Sub New(ByVal conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsProyecto
    Private Shared Function row2clsProyecto(ByVal r As DataRow) As clsProyecto
        ' asigna a un objeto clsProyecto los datos del dataRow indicado
        Dim oclsProyecto As New clsProyecto
        '
        oclsProyecto.idProyecto = System.Int16.Parse("0" & r("idProyecto").ToString())
        oclsProyecto.nombre = r("nombre").ToString()
        oclsProyecto.direccion = r("direccion").ToString()
        oclsProyecto.cuotaFija = System.Decimal.Parse("0" & r("cuotaFija").ToString())
        oclsProyecto.aguaFija = System.Decimal.Parse("0" & r("aguaFija").ToString())
        oclsProyecto.precioExceso = System.Decimal.Parse("0" & r("precioExceso").ToString())
        oclsProyecto.diasPago = System.Int32.Parse("0" & r("diasPago").ToString())
        oclsProyecto.planta = System.Decimal.Parse("0" & r("planta").ToString())
        oclsProyecto.reconexion = System.Decimal.Parse("0" & r("reconexion").ToString())
        oclsProyecto.multiplicador = System.Decimal.Parse("0" & r("multiplicador").ToString())
        oclsProyecto.mora = System.Decimal.Parse("0" & r("mora").ToString())
        oclsProyecto.iva = System.Decimal.Parse("0" & r("iva").ToString())
        '
        Return oclsProyecto
    End Function
    '
    ' asigna un objeto clsProyecto a la fila indicada
    Private Shared Sub clsProyecto2Row(ByVal oclsProyecto As clsProyecto, ByVal r As DataRow)
        ' asigna un objeto clsProyecto al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("idProyecto") = oclsProyecto.idProyecto
        r("nombre") = oclsProyecto.nombre
        r("direccion") = oclsProyecto.direccion
        r("cuotaFija") = oclsProyecto.cuotaFija
        r("aguaFija") = oclsProyecto.aguaFija
        r("precioExceso") = oclsProyecto.precioExceso
        r("diasPago") = oclsProyecto.diasPago
        r("planta") = oclsProyecto.planta
        r("reconexion") = oclsProyecto.reconexion
        r("multiplicador") = oclsProyecto.multiplicador
        r("mora") = oclsProyecto.mora
        r("iva") = oclsProyecto.iva
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsProyecto
    Private Shared Sub nuevoclsProyecto(ByVal dt As DataTable, ByVal oclsProyecto As clsProyecto)
        ' Crear un nuevo clsProyecto
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsProyecto = row2clsProyecto(dr)
        '
        oc.idProyecto = oclsProyecto.idProyecto
        oc.nombre = oclsProyecto.nombre
        oc.direccion = oclsProyecto.direccion
        oc.cuotaFija = oclsProyecto.cuotaFija
        oc.aguaFija = oclsProyecto.aguaFija
        oc.precioExceso = oclsProyecto.precioExceso
        oc.diasPago = oclsProyecto.diasPago
        oc.planta = oclsProyecto.planta
        oc.reconexion = oclsProyecto.reconexion
        oc.multiplicador = oclsProyecto.multiplicador
        oc.mora = oclsProyecto.mora
        oc.iva = oclsProyecto.iva
        '
        clsProyecto2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla tblProyecto
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsProyecto")
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
    Public Shared Function Buscar(ByVal sWhere As String) As clsProyecto
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsProyecto As clsProyecto = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsProyecto")
        Dim sel As String = "SELECT * FROM tblProyecto WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsProyecto = row2clsProyecto(dt.Rows(0))
        End If
        Return oclsProyecto
    End Function
    '
    ' Actualizar: Actualiza los datos en la tabla usando la instancia actual
    '             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    '             Para comprobar si el objeto en memoria coincide con uno existente,
    '             se comprueba si el idProyecto existe en la tabla.
    '             TODO: Si en lugar de idProyecto usas otro campo, indicalo en la cadena SELECT
    '                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    Public Function Actualizar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idProyecto que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblProyecto WHERE idProyecto = " & Me.idProyecto.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(ByVal sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsProyecto")
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
        '       Yo compruebo que sea un campo llamado idProyecto, pero en tu caso puede ser otro
        '       Ese campo, (en mi caso idProyecto) será el que hay que poner al final junto al WHERE.
        sCommand = "UPDATE tblProyecto SET nombre = @nombre, direccion = @direccion, cuotaFija = @cuotaFija, aguaFija = @aguaFija, precioExceso = @precioExceso, diasPago = @diasPago, planta = @planta, reconexion = @reconexion, multiplicador = @multiplicador, mora = @mora, iva = @iva  WHERE (idProyecto = @idProyecto)"
        da.UpdateCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@idProyecto", SqlDbType.SmallInt, 0, "idProyecto")
        da.UpdateCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        da.UpdateCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 100, "direccion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@cuotaFija", SqlDbType.Decimal, 0, "cuotaFija")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@aguaFija", SqlDbType.Decimal, 0, "aguaFija")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@precioExceso", SqlDbType.Decimal, 0, "precioExceso")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@diasPago", SqlDbType.Int, 0, "diasPago")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@planta", SqlDbType.Decimal, 0, "planta")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@reconexion", SqlDbType.Decimal, 0, "reconexion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@multiplicador", SqlDbType.Decimal, 0, "multiplicador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@mora", SqlDbType.Decimal, 0, "mora")
        ' TODO: Comprobar el tipo de datos a usar...
        da.UpdateCommand.Parameters.Add("@iva", SqlDbType.Decimal, 0, "iva")
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
            clsProyecto2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsProyecto")
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
        '       Yo compruebo que sea un campo llamado idProyecto, pero en tu caso puede ser otro
        sCommand = "INSERT INTO tblProyecto (nombre, direccion, cuotaFija, aguaFija, precioExceso, diasPago, planta, reconexion, multiplicador, mora, iva)  VALUES(@nombre, @direccion, @cuotaFija, @aguaFija, @precioExceso, @diasPago, @planta, @reconexion, @multiplicador, @mora, @iva)"
        da.InsertCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@idProyecto", SqlDbType.SmallInt, 0, "idProyecto")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100, "nombre")
        da.InsertCommand.Parameters.Add("@direccion", SqlDbType.NVarChar, 100, "direccion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@cuotaFija", SqlDbType.Decimal, 0, "cuotaFija")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@aguaFija", SqlDbType.Decimal, 0, "aguaFija")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@precioExceso", SqlDbType.Decimal, 0, "precioExceso")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@diasPago", SqlDbType.Int, 0, "diasPago")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@planta", SqlDbType.Decimal, 0, "planta")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@reconexion", SqlDbType.Decimal, 0, "reconexion")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@multiplicador", SqlDbType.Decimal, 0, "multiplicador")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@mora", SqlDbType.Decimal, 0, "mora")
        ' TODO: Comprobar el tipo de datos a usar...
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.Decimal, 0, "iva")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsProyecto(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsProyecto"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el idProyecto que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM tblProyecto WHERE idProyecto = " & Me.idProyecto.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(ByVal sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsProyecto")
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
        '       Yo compruebo que sea un campo llamado idProyecto, pero en tu caso puede ser otro
        sCommand = "DELETE FROM tblProyecto WHERE (idProyecto = @p1)"
        da.DeleteCommand = New SqlCommand(sCommand, cnn)
        ' TODO: Comprobar el tipo de datos a usar...
        da.DeleteCommand.Parameters.Add("@p1", SqlDbType.SmallInt, 0, "idProyecto")
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
