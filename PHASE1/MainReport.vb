Public Class MainReport

    Private Sub MainReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        ListView1.Columns.Add("Student Number", CInt(ListView1.Width / 4.5), HorizontalAlignment.Center)
        ListView1.Columns.Add("Name", CInt(ListView1.Width / 2.5), HorizontalAlignment.Center)
        ListView1.Columns.Add("Course", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Year Level", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)

        ComboBox1.Hide()
        paymentbox.Hide()
        StatusBox.Hide()
    End Sub

 
    Private Sub InfoBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoBox.SelectedValueChanged
        If InfoBox.Text = "School Year" Then
            paymentbox.Show()
            ComboBox1.Hide()
            StatusBox.Hide()
            ListView1.Items.Clear()
            Button2.Enabled = False
        Else
            paymentbox.Hide()
            ComboBox1.Show()
            StatusBox.Show()
            ListView1.Items.Clear()
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If InfoBox.Text = "" Then
            MsgBox("You must choose a selection first!", vbInformation)

        ElseIf InfoBox.Text = "School Year" Then
            If paymentbox.MaskCompleted = False Then
                MsgBox("Please complete the requiered field!", vbExclamation)
                paymentbox.Clear()
                paymentbox.Focus()

            ElseIf paymentbox.Text = Nothing Then
                MsgBox("There's no to search", vbExclamation)
            Else
                '===>SCHOOL YEAR SEARCH<==='
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    Dim tmp As String = "select * from info where SY ='" & paymentbox.Text & "'"
                    sqlcmd.CommandText = tmp
                    sqlcmd.Connection = sqlcon

                    sqlcondr = sqlcmd.ExecuteReader

                    ListView1.Items.Clear()
                    If sqlcondr.HasRows = 0 Then
                        MsgBox("No data found", vbExclamation)
                    Else
                        While (sqlcondr.Read())
                            Dim NewItem As ListViewItem
                            NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                            NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                            NewItem.SubItems.Add(sqlcondr("Course"))
                            NewItem.SubItems.Add(sqlcondr("YL"))
                        End While
                        Button2.Enabled = True
                    End If
                    sqlcmd.Dispose()
                    sqlcondr.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
            End If

        ElseIf InfoBox.Text = "Semester" Then
            If ComboBox1.Text = Nothing Then
                MsgBox("There's no to search", vbExclamation)
            Else
                If ComboBox1.SelectedItem = "1st Semester" Then
                    module2.MaiReportSemOne()

                ElseIf ComboBox1.SelectedItem = "2nd Semester" Then

                    module2.MainReportSemTwo()

                End If
            End If
        End If
    End Sub

    'PRINT BUTTON
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If InfoBox.Text = "School Year" Then
            ReportViwer.getVal(paymentbox.Text)
            ReportViwer.Show()

        ElseIf InfoBox.Text = "Semester" Then
            If ComboBox1.Text = "1st Semester" Then
                SemOneReportViewer.getVal(StatusBox.SelectedItem)
                SemOneReportViewer.Show()

            ElseIf ComboBox1.Text = "2nd Semester" Then
                SemTwoReportViewer.getVal(StatusBox.SelectedItem)
                SemTwoReportViewer.Show()

            Else
                MsgBox("No data")
            End If
        End If
    End Sub

    'SELECTING DROPDOWNLIST
    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        ListView1.Items.Clear()
        Button2.Enabled = False
    End Sub
End Class