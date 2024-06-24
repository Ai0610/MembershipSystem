Public Class StudentReportViewer

    Private Sub StudentReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'mbsystemDataSet.DataTable1' table. You can move, or remove it, as needed.

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
    Public Shared Sub getVal(ByVal value As String)
        StudentReportViewer.DataTable1TableAdapter.Fill(StudentReportViewer.mbsystemDataSet.DataTable1, value)
        StudentReportViewer.ReportViewer1.RefreshReport()
        StudentReportViewer.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class