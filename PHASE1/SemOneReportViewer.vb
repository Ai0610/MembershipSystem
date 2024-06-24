Public Class SemOneReportViewer

    Private Sub SemOneReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'mbsystemDataSet.DataTable2' table. You can move, or remove it, as needed.
        'Me.DataTable2TableAdapter.Fill(Me.mbsystemDataSet.DataTable2)
    End Sub

    Public Shared Sub getVal(ByVal value As String)
        SemOneReportViewer.DataTable2TableAdapter.Fill(SemOneReportViewer.mbsystemDataSet.DataTable2, value)
        SemOneReportViewer.ReportViewer1.RefreshReport()
        SemOneReportViewer.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

    End Sub

End Class