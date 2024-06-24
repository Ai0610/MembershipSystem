Public Class UpdateSecondSem

    Private Sub UpdateSecondSem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If
        ListView1.Columns.Add("Student Number", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Name", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Year Level", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("School Year", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Payment", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Status", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        If searchbox.MaskCompleted = False Then
            MsgBox("Complete the Reuqired Fied!")
            searchbox.Clear()
            searchbox.Focus()
        ElseIf searchbox.Text = Nothing Then
            MsgBox("There's no input")
            searchbox.Clear()
            searchbox.Focus()
        Else
            module2.SemTwoValue()
        End If
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select payment, YearLevelTwo = '" & ListView1.SelectedItems(0).SubItems(2).Text & "' from 1stSemster  where stud_id = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'"


        sqlcondr = sqlcmd.ExecuteReader
        While sqlcondr.Read()
            If sqlcondr.HasRows = 0 Then
                MsgBox("There's no data")
            Else
                MemPayment.TextBox1.Text = sqlcondr.Item("SecondPayment")
                MemPayment.Label1.Text = "2nd Semester"
                MemPayment.Show()
            End If
        End While
    End Sub




End Class