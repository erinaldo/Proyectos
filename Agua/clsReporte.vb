Imports Microsoft.VisualBasic

Public Class clsReporte
    Private _tabla As System.Data.DataTable
    Private _reporte As System.String
    Private _nombreParametro As System.String
    Private _parametro As System.String
    Private _subReporte As String = ""
    Private _tablaSubReporte As System.Data.DataTable


    Public Property subReporte() As String
        Get
            subReporte = _subReporte
        End Get
        Set(ByVal value As String)
            _subReporte = value
        End Set
    End Property

    Public Property tablaSubReporte() As System.Data.DataTable
        Get
            tablaSubReporte = _tablaSubReporte
        End Get
        Set(ByVal value As System.Data.DataTable)
            _tablaSubReporte = value
        End Set
    End Property

    Public Property tabla() As System.Data.DataTable
        Get
            tabla = _tabla
        End Get
        Set(ByVal value As System.Data.DataTable)
            _tabla = value
        End Set
    End Property

    Public Property reporte() As System.String
        Get
            reporte = _reporte
        End Get
        Set(ByVal value As System.String)
            _reporte = value
        End Set
    End Property

    Public Property nombreParametro() As System.String
        Get
            nombreParametro = _nombreParametro
        End Get
        Set(ByVal value As System.String)
            _nombreParametro = value
        End Set
    End Property

    Public Property parametro() As System.String
        Get
            parametro = _parametro
        End Get
        Set(ByVal value As System.String)
            _parametro = value
        End Set
    End Property

    Public Sub verReporte()
        'Assign the datasource and set the properties for Report viewer
        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rutaReporte As String
        Dim path As String
        Try
            path = System.AppDomain.CurrentDomain.BaseDirectory()
            rutaReporte = path & "\" & Me.reporte
            rptDocument.Load(rutaReporte)
            rptDocument.SetDataSource(Me.tabla)
            If Me.subReporte <> "" Then
                rptDocument.Subreports(Me.subReporte).SetDataSource(Me.tablaSubReporte)
            End If
            'rptDocument.Subreports("rptResumenFacturaProveedorGastos.rpt").SetDataSource(tblrpt0.tablaSP("exec sp_CmpFacturaProveedorReportes 9," & CInt(Me.txtIdFactura.Text) & ",NULL"))

            ''HttpContext.Current.Session("parametroReporteNombre") = Me.nombreParametro
            ''HttpContext.Current.Session("parametroReporte") = Me.parametro
            ''HttpContext.Current.Session("reporte") = rptDocument

            ''HttpContext.Current.Server.Transfer("frmrptviewver.aspx")

            With frmCrystalViewver
                '.parametroReporteNombre = Me.nombreParametro
                '.parametroReporte = Me.parametro
                .reporte = rptDocument
                .MdiParent = MDIPrincipal
                .WindowState = FormWindowState.Maximized
                .Show()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
        End Try

    End Sub

    Public Sub imprimir(ByVal printerName As String)
        'Assign the datasource and set the properties for Report viewer
        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rutaReporte As String
        Dim path As String
        Try
            path = System.AppDomain.CurrentDomain.BaseDirectory()
            rutaReporte = path & Me.reporte
            rptDocument.Load(rutaReporte)
            rptDocument.SetDataSource(Me.tabla)

            If Me.subReporte <> "" Then
                rptDocument.Subreports(Me.subReporte).SetDataSource(Me.tablaSubReporte)
            End If

            Dim noCopias As Integer = 1
            Dim pagIntercaladas As Boolean = True
            Dim paginaInicio As Integer = 1
            Dim paginaFin As Integer = 1

            ' Seleccionar la impresora.
            rptDocument.PrintOptions.PrinterName = printerName
            ' rptDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            rptDocument.PrintToPrinter(noCopias, pagIntercaladas, paginaInicio, paginaFin)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
        End Try
    End Sub
    Public Sub imprimirReporte(ByVal printerName As String)
        'Assign the datasource and set the properties for Report viewer
        Dim rptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rutaReporte As String
        Dim path As String
        Try
            path = System.AppDomain.CurrentDomain.BaseDirectory()
            rutaReporte = path & Me.reporte
            rptDocument.Load(rutaReporte)
            rptDocument.SetDataSource(Me.tabla)

            If Me.subReporte <> "" Then
                rptDocument.Subreports(Me.subReporte).SetDataSource(Me.tablaSubReporte)
            End If

            Dim noCopias As Integer = 1
            Dim pagIntercaladas As Boolean = True
            Dim paginaInicio As Integer = 1
            Dim paginaFin As Integer = 1

            ' Seleccionar la impresora.
            rptDocument.PrintOptions.PrinterName = printerName
            ' rptDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            rptDocument.PrintToPrinter(noCopias, pagIntercaladas, paginaInicio, paginaFin)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "!!!")
        End Try
    End Sub

End Class
