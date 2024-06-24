Module module2

    '|| ------------------------------------------------------------------------------------------------------------------||'
    '===VIEW AND FORM LOAD (UpdatFirstSem FORM)<===='
    'VIEW UPDATE FIRST SEM VALUE
    Public Sub SemOneValue()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select a.*,b.* from 1stSemster a JOIN info b ON a.stud_id=b.StudentNo where a.SchoolYearOne like '%" & UpdateFirstSem.searchbox.Text & "%'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data")
            Else

                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = UpdateFirstSem.ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("YearLevelOne"))
                    NewItem.SubItems.Add(sqlcondr("SchoolYearOne"))
                    NewItem.SubItems.Add(sqlcondr("Payment"))
                    NewItem.SubItems.Add(sqlcondr("STATUS"))
                End While
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'FORM LOAD OF UPDATING THE MEMBERSHIP FEE FIRST SEMESTER
    Public Sub loadOne()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select a.*,b.* from 1stSemster a JOIN info b ON a.stud_id=b.StudentNo where a.STATUS ='" & "NOT REGISTERED" & "' ORDER BY `firstsem_id` ASC"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data to update")
            Else
                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = UpdateFirstSem.ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("YearLevelOne"))
                    NewItem.SubItems.Add(sqlcondr("SchoolYearOne"))
                    NewItem.SubItems.Add(sqlcondr("Payment"))
                    NewItem.SubItems.Add(sqlcondr("STATUS"))
                End While
                UpdateFirstSem.Show()
            End If


            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===VIEW AND FORM LOAD (UpdateSecondSem FORM)<===='
    'VIEW UPDATE SECOND SEM VALUE
    Public Sub SemTwoValue()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select * from 2ndSemester where SchoolYearTwo like '%" & UpdateSecondSem.searchbox.Text & "%'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = UpdateSecondSem.ListView1.Items.Add(sqlcondr("YearLevelOne"))
                NewItem.SubItems.Add(sqlcondr("SchoolYearOne"))
                NewItem.SubItems.Add(sqlcondr("Payment"))
                NewItem.SubItems.Add(sqlcondr("STATUS"))
            End While

            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'FORM LOAD OF UPDATING THE MEMBERSHIP FEE SECOND SEMESTER
    Public Sub loadTwo()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select a.*,b.* from 2ndSemester a JOIN info b ON a.stud_id=b.StudentNo where a.SecondSTATUS ='" & "NOT REGISTERED" & "' ORDER BY `SecondSem_id` ASC"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data to update")
            Else

                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = UpdateSecondSem.ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("YearLevelTwo"))
                    NewItem.SubItems.Add(sqlcondr("SchoolYearTwo"))
                    NewItem.SubItems.Add(sqlcondr("Payment"))
                    NewItem.SubItems.Add(sqlcondr("STATUS"))
                End While
                UpdateSecondSem.Show()
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===DELETE AND VIEWER (Alumni FORM)<===='
    'DELETE ALUNMI FORM
    Public Sub alumDelete()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select * from info"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader


            AlumniForm.ListView1.Items.Clear()


            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = AlumniForm.ListView1.Items.Add(sqlcondr("StudentNo"))
                NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                NewItem.SubItems.Add(sqlcondr("Course"))
                NewItem.SubItems.Add(sqlcondr("YL"))
            End While

            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'VIEWER NG ALUMNI FORM
    Public Sub Viewer()
        sqlcondr.Close()
        Dim tmp As String = "select * from info"
        sqlcmd.CommandText = tmp
        sqlcmd.Connection = sqlcon

        sqlcondr = sqlcmd.ExecuteReader


        AlumniForm.ListView1.Items.Clear()


        While (sqlcondr.Read())
            Dim NewItem As ListViewItem
            NewItem = AlumniForm.ListView1.Items.Add(sqlcondr("StudentNo"))
            NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
            NewItem.SubItems.Add(sqlcondr("Course"))
            NewItem.SubItems.Add(sqlcondr("YL"))
        End While

        sqlcmd.Dispose()
        sqlcondr.Close()

    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'
    '===SEMESTER VIEWR (MainReport FORM)<===='
    'MAIN REPORT FIRST SEMESTER VIEWWER
    Public Sub MaiReportSemOne()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select a.*,b.* FROM info a JOIN 1stsemster b ON a.StudentNo=b.stud_id where STATUS ='" & MainReport.StatusBox.SelectedItem & "'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            MainReport.ListView1.Items.Clear()
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data found", vbExclamation)
            Else
                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = MainReport.ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("Course"))
                    NewItem.SubItems.Add(sqlcondr("YL"))
                End While
                MainReport.Button2.Enabled = True
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'MAIN REPORT FIRST SEMESTER VIEWWER
    Public Sub MainReportSemTwo()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim temp As String = "select a.*,b.* FROM info a JOIN 2ndSemester b ON a.StudentNo=b.stud_id where SecondSTATUS ='" & MainReport.StatusBox.SelectedItem & "'"
            sqlcmd.CommandText = temp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            MainReport.ListView1.Items.Clear()
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data found", vbExclamation)
            Else
                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = MainReport.ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("Course"))
                    NewItem.SubItems.Add(sqlcondr("YL"))
                End While
                MainReport.Button2.Enabled = True
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===>UPDATE IN MEMBERSHI FEE(Settings FORM)<==='
    'UPDATE THE FEE
    Public Sub updateFee()
        Try
            sqlcondr.Close()
            sqlcmd.Dispose()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            '===>UPDATING ACCOUNT<==='
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "update mem_fee set payment= '" & Settings.feebox.Text & "' where m_id='" & "1" & "'"
            sqlcmd.ExecuteNonQuery()
            MsgBox("RECORD HAS BEEN SUCCESSFULLY UPDATED!", vbOKOnly + vbInformation)

            sqlcmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'SHOW THE UPDATED FEE
    Public Sub updateFeeShow()
        Try
            sqlcondr.Close()
            sqlcon.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select * from mem_fee"

            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            While sqlcondr.Read
                Settings.feebox.Hide()
                Settings.showbox.Text = sqlcondr("payment")
                Settings.feebox.Text = sqlcondr("Payment")
            End While


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'
End Module
