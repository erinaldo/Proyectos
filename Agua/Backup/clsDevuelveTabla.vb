Imports Microsoft.VisualBasic
Imports System.Data
Friend Class clsDevuelveTabla
    Private _sqlString As String


    Public Property sqlString() As String
        Get
            sqlString = _sqlString
        End Get
        Set(ByVal value As String)
            _sqlString = value
        End Set
    End Property


    Public Function Tabla() As Data.DataTable
        Dim dt As New Data.DataTable
        Dim adp As New System.Data.SqlClient.SqlDataAdapter(Me.sqlString, mdlPublicVars.cnn)
        adp.Fill(dt)
        adp.Dispose()
        adp = Nothing
        Return dt
    End Function

    Public Function TablaCosto() As Data.DataTable
        Dim dt As New Data.DataTable
        Dim adp As New System.Data.SqlClient.SqlDataAdapter(Me.sqlString, mdlPublicVars.cnn)
        adp.Fill(dt)
        adp.Dispose()
        adp = Nothing
        Return dt
    End Function

    Public Function tablaSP(ByVal spNombre As String) As System.Data.DataTable


        Dim cnString As String
        Dim cn As New SqlClient.SqlConnection
        Dim adp As New SqlClient.SqlDataAdapter
        'Dim adp1 As New SqlClient.SqlDataAdapter
        Dim dt As New DataTable

        cnString = mdlPublicVars.cnn
        'Abrimos la conexion hacia nuestra BD


        cn.ConnectionString = cnString
        cn.Open()


        'Llenamos nuestra data Table con la informacion devuelta por storeProcedure
        adp.SelectCommand = New SqlClient.SqlCommand(spNombre, cn)
        adp.SelectCommand.CommandTimeout = 100000
        adp.Fill(dt)

        'adp.SelectCommand = New SqlCommand("sp_ventasPendientes 1,'20060308','20060301'", cn)
        'adp.SelectCommand = New SqlClient.SqlCommand("sp_ventasPendientes 1,'" & SqlFecha(Me.fechaInicial) & ",'" & SqlFecha(Me.fechaFinal) & "'", cn)
        'adp1.SelectCommand = New SqlClient.SqlCommand("sp_rotate_table @ontable = 'tiendasPendientes',@onrows = 'DescTienda',@oncols = 'convert(varChar(10),fecha,103)',@sumcol = 'CASE day(fecha) WHEN 0 THEN 0 ELSE 1 END'", cn)
        'adp1.Fill(dt)


        adp.Dispose()
        adp = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing
        Return dt


    End Function

    Public Function ejecutaSQL() As Int16
        Dim cnn As New System.Data.SqlClient.SqlConnection
        Try
            cnn.ConnectionString = mdlPublicVars.cnn
            cnn.Open()
            Dim cm As New System.Data.SqlClient.SqlCommand(Me.sqlString, cnn)
            Return cm.ExecuteNonQuery
            cnn.Close()
            cm = Nothing
            cnn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
        End Try
    End Function

End Class
