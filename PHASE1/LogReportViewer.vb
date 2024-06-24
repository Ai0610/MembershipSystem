Public Class LogReportViewer

    Private Sub LogReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'mbsystemDataSet.logrecord' table. You can move, or remove it, as needed.
        Me.logrecordTableAdapter.Fill(Me.mbsystemDataSet.logrecord)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class