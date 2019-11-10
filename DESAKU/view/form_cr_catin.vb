Imports CrystalDecisions.CrystalReports.Engine

Public Class form_cr_catin
    Public k As String
    Private Sub form_cr_catin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim riportku As New ReportDocument
        riportku.Load("..\..\c_catin.rpt")
        riportku.SetParameterValue("kode", k)
        CrystalReportViewer1.ReportSource = riportku
        CrystalReportViewer1.Refresh()

    End Sub
End Class