Imports CrystalDecisions.CrystalReports.Engine

Public Class printing
    Dim t As New Laporan_data
    Public k As String = ""
    Private Sub printing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim riportku As New ReportDocument

        riportku.Load("..\..\report.rpt")
        riportku.SetParameterValue("kode", k)
        CrystalReportViewer1.ReportSource = riportku
        CrystalReportViewer1.Refresh()
    End Sub
End Class