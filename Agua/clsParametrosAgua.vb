Option Strict On
Option Explicit On
'
Imports System
Imports System.Data
Imports System.Data.SqlClient
'
Public Class clsParametrosAgua
    ' Las variables privadas
    ' TODO: Revisar los tipos de los campos
    Private _codigo As System.Int32
    Private _parametroInicio As System.String
    Private _Inicio As System.Decimal
    Private _parametroFin As System.String
    Private _Fin As System.Decimal
    Private _valor As System.Decimal
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
    Public Property parametroInicio() As System.String
        Get
            Return ajustarAncho(_parametroInicio, 100)
        End Get
        Set(value As System.String)
            _parametroInicio = value
        End Set
    End Property
    Public Property Inicio() As System.Decimal
        Get
            Return _Inicio
        End Get
        Set(value As System.Decimal)
            _Inicio = value
        End Set
    End Property
    Public Property parametroFin() As System.String
        Get
            Return ajustarAncho(_parametroFin, 100)
        End Get
        Set(value As System.String)
            _parametroFin = value
        End Set
    End Property
    Public Property Fin() As System.Decimal
        Get
            Return _Fin
        End Get
        Set(value As System.Decimal)
            _Fin = value
        End Set
    End Property
    Public Property valor() As System.Decimal
        Get
            Return _valor
        End Get
        Set(value As System.Decimal)
            _valor = value
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
                Return Me.parametroInicio.ToString()
            ElseIf index = 2 Then
                Return Me.Inicio.ToString()
            ElseIf index = 3 Then
                Return Me.parametroFin.ToString()
            ElseIf index = 4 Then
                Return Me.Fin.ToString()
            ElseIf index = 5 Then
                Return Me.valor.ToString()
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
                Me.parametroInicio = value
            ElseIf index = 2 Then
                Try
                    Me.Inicio = System.Decimal.Parse("0" & value)
                Catch
                    Me.Inicio = System.Decimal.Parse("0")
                End Try
            ElseIf index = 3 Then
                Me.parametroFin = value
            ElseIf index = 4 Then
                Try
                    Me.Fin = System.Decimal.Parse("0" & value)
                Catch
                    Me.Fin = System.Decimal.Parse("0")
                End Try
            ElseIf index = 5 Then
                Try
                    Me.valor = System.Decimal.Parse("0" & value)
                Catch
                    Me.valor = System.Decimal.Parse("0")
                End Try
            End If
        End Set
    End Property
    Default Public Property Item(index As String) As String
        ' Devuelve el contenido del campo indicado en index
        ' (el índice corresponde al nombre de la columna)
        Get
            If index = "codigo" Then
                Return Me.codigo.ToString()
            ElseIf index = "parametroInicio" Then
                Return Me.parametroInicio.ToString()
            ElseIf index = "Inicio" Then
                Return Me.Inicio.ToString()
            ElseIf index = "parametroFin" Then
                Return Me.parametroFin.ToString()
            ElseIf index = "Fin" Then
                Return Me.Fin.ToString()
            ElseIf index = "valor" Then
                Return Me.valor.ToString()
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
            ElseIf index = "parametroInicio" Then
                Me.parametroInicio = value
            ElseIf index = "Inicio" Then
                Try
                    Me.Inicio = System.Decimal.Parse("0" & value)
                Catch
                    Me.Inicio = System.Decimal.Parse("0")
                End Try
            ElseIf index = "parametroFin" Then
                Me.parametroFin = value
            ElseIf index = "Fin" Then
                Try
                    Me.Fin = System.Decimal.Parse("0" & value)
                Catch
                    Me.Fin = System.Decimal.Parse("0")
                End Try
            ElseIf index = "valor" Then
                Try
                    Me.valor = System.Decimal.Parse("0" & value)
                Catch
                    Me.valor = System.Decimal.Parse("0")
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
    Public Shared CadenaSelect As String = "SELECT * FROM parametrosAgua"
    '
    Public Sub New()
    End Sub
    Public Sub New(conex As String)
        cadenaConexion = conex
    End Sub
    '
    ' Métodos compartidos (estáticos) privados
    '
    ' asigna una fila de la tabla a un objeto clsParametrosAgua
    Private Shared Function row2clsParametrosAgua(r As DataRow) As clsParametrosAgua
        ' asigna a un objeto clsParametrosAgua los datos del dataRow indicado
        Dim oclsParametrosAgua As New clsParametrosAgua
        '
        oclsParametrosAgua.codigo = System.Int32.Parse("0" & r("codigo").ToString())
        oclsParametrosAgua.parametroInicio = r("parametroInicio").ToString()
        oclsParametrosAgua.Inicio = System.Decimal.Parse("0" & r("Inicio").ToString())
        oclsParametrosAgua.parametroFin = r("parametroFin").ToString()
        oclsParametrosAgua.Fin = System.Decimal.Parse("0" & r("Fin").ToString())
        oclsParametrosAgua.valor = System.Decimal.Parse("0" & r("valor").ToString())
        '
        Return oclsParametrosAgua
    End Function
    '
    ' asigna un objeto clsParametrosAgua a la fila indicada
    Private Shared Sub clsParametrosAgua2Row(oclsParametrosAgua As clsParametrosAgua, r As DataRow)
        ' asigna un objeto clsParametrosAgua al dataRow indicado
        ' TODO: Comprueba si esta asignación debe hacerse
        '       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        'r("codigo") = oclsParametrosAgua.codigo
        r("parametroInicio") = oclsParametrosAgua.parametroInicio
        r("Inicio") = oclsParametrosAgua.Inicio
        r("parametroFin") = oclsParametrosAgua.parametroFin
        r("Fin") = oclsParametrosAgua.Fin
        r("valor") = oclsParametrosAgua.valor
    End Sub
    '
    ' crea una nueva fila y la asigna a un objeto clsParametrosAgua
    Private Shared Sub nuevoclsParametrosAgua(dt As DataTable, oclsParametrosAgua As clsParametrosAgua)
        ' Crear un nuevo clsParametrosAgua
        Dim dr As DataRow = dt.NewRow()
        Dim oc As clsParametrosAgua = row2clsParametrosAgua(dr)
        '
        oc.codigo = oclsParametrosAgua.codigo
        oc.parametroInicio = oclsParametrosAgua.parametroInicio
        oc.Inicio = oclsParametrosAgua.Inicio
        oc.parametroFin = oclsParametrosAgua.parametroFin
        oc.Fin = oclsParametrosAgua.Fin
        oc.valor = oclsParametrosAgua.valor
        '
        clsParametrosAgua2Row(oc, dr)
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
        ' devuelve una tabla con los datos de la tabla parametrosAgua
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsParametrosAgua")
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
    Public Shared Function Buscar(sWhere As String) As clsParametrosAgua
        ' Busca en la tabla los datos indicados en el parámetro
        ' el parámetro contendrá lo que se usará después del WHERE
        Dim oclsParametrosAgua As clsParametrosAgua = Nothing
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsParametrosAgua")
        Dim sel As String = "SELECT * FROM parametrosAgua WHERE " & sWhere
        '
        da = New SqlDataAdapter(sel, cadenaConexion)
        da.Fill(dt)
        '
        If dt.Rows.Count > 0 Then
            oclsParametrosAgua = row2clsParametrosAgua(dt.Rows(0))
        End If
        Return oclsParametrosAgua
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
        Dim sel As String = "SELECT * FROM parametrosAgua WHERE codigo = " & Me.codigo.ToString()
        Return Actualizar(sel)
    End Function
    Public Function Actualizar(sel As String) As String
        ' Actualiza los datos indicados
        ' El parámetro, que es una cadena de selección, indicará el criterio de actualización
        '
        ' En caso de error, devolverá la cadena empezando por ERROR.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsParametrosAgua")
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
        'sCommand = "UPDATE parametrosAgua SET parametroInicio = @parametroInicio, Inicio = @Inicio, parametroFin = @parametroFin, Fin = @Fin, valor = @valor  WHERE (codigo = @codigo)"
        'da.UpdateCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        'da.UpdateCommand.Parameters.Add("@parametroInicio", SqlDbType.NVarChar, 100, "parametroInicio")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@Inicio", SqlDbType.Decimal, 0, "Inicio")
        'da.UpdateCommand.Parameters.Add("@parametroFin", SqlDbType.NVarChar, 100, "parametroFin")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@Fin", SqlDbType.Decimal, 0, "Fin")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.UpdateCommand.Parameters.Add("@valor", SqlDbType.Decimal, 0, "valor")
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
            clsParametrosAgua2Row(Me, dt.Rows(0))
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
        Dim dt As New DataTable("clsParametrosAgua")
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
        'sCommand = "INSERT INTO parametrosAgua (parametroInicio, Inicio, parametroFin, Fin, valor)  VALUES(@parametroInicio, @Inicio, @parametroFin, @Fin, @valor)"
        'da.InsertCommand = New SqlCommand(sCommand, cnn)
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        'da.InsertCommand.Parameters.Add("@parametroInicio", SqlDbType.NVarChar, 100, "parametroInicio")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@Inicio", SqlDbType.Decimal, 0, "Inicio")
        'da.InsertCommand.Parameters.Add("@parametroFin", SqlDbType.NVarChar, 100, "parametroFin")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@Fin", SqlDbType.Decimal, 0, "Fin")
        '' TODO: Comprobar el tipo de datos a usar...
        'da.InsertCommand.Parameters.Add("@valor", SqlDbType.Decimal, 0, "valor")
        '
        '
        Try
            da.Fill(dt)
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
        '
        nuevoclsParametrosAgua(dt, Me)
        '
        Try
            da.Update(dt)
            dt.AcceptChanges()
            Return "Se ha creado un nuevo clsParametrosAgua"
        Catch ex As Exception
            Return "ERROR: " & ex.Message
        End Try
    End Function
    '
    Public Function Borrar() As String
        ' TODO: Poner aquí la selección a realizar para acceder a este registro
        '       yo uso el codigo que es el identificador único de cada registro
        Dim sel As String = "SELECT * FROM parametrosAgua WHERE codigo = " & Me.codigo.ToString()
        '
        Return Borrar(sel)
    End Function
    Public Function Borrar(sel As String) As String
        ' Borrar el registro al que apunta esta clase
        ' En caso de error, devolverá la cadena de error empezando por ERROR:.
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable("clsParametrosAgua")
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
        'sCommand = "DELETE FROM parametrosAgua WHERE (codigo = @p1)"
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

