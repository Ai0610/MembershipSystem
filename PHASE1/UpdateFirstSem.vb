Public Class UpdateFirstSem

    'FORM LOAD
    Private Sub UpdateFirstSem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        ListView1.Columns.Add("Student Number", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Name", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Year Level", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("School Year", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Payment", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Status", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)

    End Sub

    'SEARCH BUTTON
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        If searchbox.MaskCompleted = False Then
            MsgBox("Complete the Reuqired Fied!")
            searchbox.Clear()
            searchbox.Focus()
        ElseIf searchbox.Text = Nothing Then
            MsgBox("There's no input")
            searchbox.Clear()
            searchbox.Focus()
        Else
            module2.SemOneValue()
        End If
    End Sub

    'DOUBLE CLICK EVENT
    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems(0).SubItems(5).Text = "REGISTERED" Then
            MsgBox("there's no need to update the amount, the member is already Fully Registered", vbInformation)
        End If
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            '===>INFO YOU WANT TO UPDATE<==='
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "select payment, YearLevelOne = '" & ListView1.SelectedItems(0).SubItems(2).Text & "' from 1stSemster  where stud_id = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'"

            sqlcondr = sqlcmd.ExecuteReader

            If sqlcondr.HasRows = 0 Then
                MsgBox("There's no data")
            Else
                While sqlcondr.Read()
                    MemPayment.TextBox1.Text = sqlcondr.Item("Payment")
                    MemPayment.Label1.Text = "1st Semester"
                    MemPayment.Show()
                End While
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class