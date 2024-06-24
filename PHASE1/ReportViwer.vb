Public Class ReportViwer

    Private Sub ReportViwer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'mbsystemDataSet.info' table. You can move, or remove it, as needed.
        'Me.infoTableAdapter.Fill(Me.mbsystemDataSet.info)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getVal(ByVal value As String)
        ReportViwer.infoTableAdapter.FillBy(ReportViwer.mbsystemDataSet.info, value)
        ReportViwer.ReportViewer1.RefreshReport()
        ReportViwer.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

    End Sub
End Class