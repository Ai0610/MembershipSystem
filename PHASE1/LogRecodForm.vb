Public Class LogRecodForm

    Private Sub LogRecodForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogView()
        ListView1.Columns.Add("No.", CInt(ListView1.Width / 12), HorizontalAlignment.Center)
        ListView1.Columns.Add("NAME", CInt(ListView1.Width / 5), HorizontalAlignment.Center)
        ListView1.Columns.Add("Date Log", CInt(ListView1.Width / 2.5), HorizontalAlignment.Center)
        ListView1.Columns.Add("Time Log", CInt(ListView1.Width / 8), HorizontalAlignment.Center)
        ListView1.Columns.Add("Status", CInt(ListView1.Width / 8), HorizontalAlignment.Center)

   
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LogReportViewer.Show()
        Me.Hide()
    End Sub
End Class