Public Class SemTwoReportViewer

    Private Sub SemTwoReportViewer_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'mbsystemDataSet.DataTable3' table. You can move, or remove it, as needed.

    End Sub
    Public Shared Sub getVal(ByVal value As String)
        SemTwoReportViewer.DataTable3TableAdapter.Fill(SemTwoReportViewer.mbsystemDataSet.DataTable3, value)
        SemTwoReportViewer.ReportViewer1.RefreshReport()
        SemTwoReportViewer.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

    End Sub
        

End Class