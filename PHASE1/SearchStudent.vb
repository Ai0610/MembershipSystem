Public Class SearchStudent

    Private Sub SearchStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If
        ListView1.Columns.Add("Student Number", CInt(ListView1.Width / 4.5), HorizontalAlignment.Center)
        ListView1.Columns.Add("Name", CInt(ListView1.Width / 2.5), HorizontalAlignment.Center)
        ListView1.Columns.Add("Course", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView1.Columns.Add("Year Level", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
    End Sub
    'DOUBLE CLICK
    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "select * from info where StudentNo = '" & ListView1.FocusedItem.Text & "'"

            sqlcondr = sqlcmd.ExecuteReader


            While sqlcondr.Read()
                If sqlcondr.HasRows Then
                    View_Student.Label2.Text = sqlcondr.Item("StudentNo")
                    View_Student.Label4.Text = sqlcondr.Item("Firstname") + " " + sqlcondr.Item("Middlename") + " " + sqlcondr.Item("Lastname")
                    View_Student.Label6.Text = sqlcondr.Item("Gender")
                    View_Student.Label9.Text = sqlcondr.Item("Age")
                    View_Student.Label8.Text = sqlcondr.Item("Birthdate")
                    View_Student.Label11.Text = sqlcondr.Item("email")
                    View_Student.Label23.Text = sqlcondr.Item("Course")
                    View_Student.Label21.Text = sqlcondr.Item("section")
                    View_Student.Label25.Text = sqlcondr.Item("SY")
                    View_Student.Label22.Text = sqlcondr.Item("YL")
                End If
            End While
            sqlcondr.Close()
            sqlcmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

      


        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If

            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "select * from cntact_tbl where Stud_id = '" & ListView1.FocusedItem.Text & "'"

            sqlcondr = sqlcmd.ExecuteReader


            While sqlcondr.Read()
                If sqlcondr.HasRows Then
                    View_Student.Label29.Text = sqlcondr.Item("ConPerson")
                    View_Student.Label27.Text = sqlcondr.Item("ConNumber")
                    View_Student.Label24.Text = sqlcondr.Item("ConAddress")
                    View_Student.Label10.Text = sqlcondr.Item("PhoneNumber")
                    View_Student.Label12.Text = sqlcondr.Item("Address")

                End If
            End While
            sqlcondr.Close()
            sqlcmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        View_Student.Show()
    End Sub

    'SAVE BUTTON
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        
        If InfoBox.Text = Nothing Then

            MsgBox("You must choose first what you want to search", vbExclamation)

            '===>COURSE<==='
        ElseIf InfoBox.Text = "Course" Then
            Try

                sqlcmd.Dispose()
                sqlcondr.Close()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                Dim tmp As String = "select * from info where Course like '%" & searchstudbox.Text & "%'"
                sqlcmd.CommandText = tmp
                sqlcmd.Connection = sqlcon

                sqlcondr = sqlcmd.ExecuteReader

                ListView1.Items.Clear()
                If sqlcondr.HasRows = 0 Then
                    MsgBox("No data found", vbExclamation)
                    searchstudbox.Clear()
                    searchstudbox.Focus()
                ElseIf searchstudbox.Text.Trim = "" Then
                    MsgBox("No data found", vbExclamation)
                    searchstudbox.Clear()
                    searchstudbox.Focus()
                Else
                    While (sqlcondr.Read())
                        Dim NewItem As ListViewItem
                        NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                        NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                        NewItem.SubItems.Add(sqlcondr("Course"))
                        NewItem.SubItems.Add(sqlcondr("YL"))
                    End While
                End If
                sqlcmd.Dispose()
                sqlcondr.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            '=====>STUDENT NUMBER<========'
        ElseIf InfoBox.Text = "Student Number" Then
            Try

                sqlcmd.Dispose()
                sqlcondr.Close()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                Dim tmp As String = "select * from info where StudentNo like '%" & searchstudbox.Text & "%'"
                sqlcmd.CommandText = tmp
                sqlcmd.Connection = sqlcon

                sqlcondr = sqlcmd.ExecuteReader

                ListView1.Items.Clear()
                If sqlcondr.HasRows = 0 Then
                    MsgBox("No data found", vbExclamation)
                    searchstudbox.Clear()
                    searchstudbox.Focus()
                ElseIf searchstudbox.Text.Trim = "" Then
                    MsgBox("No data found", vbExclamation)
                    searchstudbox.Clear()
                    searchstudbox.Focus()
                Else
                    While (sqlcondr.Read())
                        Dim NewItem As ListViewItem
                        NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                        NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                        NewItem.SubItems.Add(sqlcondr("Course"))
                        NewItem.SubItems.Add(sqlcondr("YL"))
                    End While
                End If
                sqlcmd.Dispose()
                sqlcondr.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            '====>YEAR LEVEL<===='
        ElseIf InfoBox.Text = "Year Level" Then
            Try

                sqlcmd.Dispose()
                sqlcondr.Close()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                Dim tmp As String = "select * from info where YL like '%" & searchstudbox.Text & "%'"
                sqlcmd.CommandText = tmp
                sqlcmd.Connection = sqlcon

                sqlcondr = sqlcmd.ExecuteReader

                ListView1.Items.Clear()
                If sqlcondr.HasRows = 0 Then
                    MsgBox("No data found", vbExclamation)
                    searchstudbox.Clear()
                    searchstudbox.Focus()
                ElseIf searchstudbox.Text.Trim = "" Then
                    MsgBox("No data found", vbExclamation)
                    searchstudbox.Clear()
                    searchstudbox.Focus()
                Else
                    While (sqlcondr.Read())
                        Dim NewItem As ListViewItem
                        NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                        NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                        NewItem.SubItems.Add(sqlcondr("Course"))
                        NewItem.SubItems.Add(sqlcondr("YL"))
                    End While
                End If
                sqlcmd.Dispose()
                sqlcondr.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            '====>SCHOOL YEAR<===='
        ElseIf InfoBox.Text = "School Year" Then
            Try

                sqlcmd.Dispose()
                sqlcondr.Close()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                Dim tmp As String = "select * from info where SY like '%" & searchstudbox.Text & "%'"
                sqlcmd.CommandText = tmp
                sqlcmd.Connection = sqlcon

                sqlcondr = sqlcmd.ExecuteReader

                ListView1.Items.Clear()
                If sqlcondr.HasRows = 0 Then
                    MsgBox("No data found", vbExclamation)
                    searchstudbox.Clear()
                    searchstudbox.Focus()
                ElseIf searchstudbox.Text.Trim = "" Then
                    MsgBox("No data found", vbExclamation)
                    searchstudbox.Clear()
                    searchstudbox.Focus()
                Else
                    While (sqlcondr.Read())
                        Dim NewItem As ListViewItem
                        NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                        NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                        NewItem.SubItems.Add(sqlcondr("Course"))
                        NewItem.SubItems.Add(sqlcondr("YL"))
                    End While
                End If
                sqlcmd.Dispose()
                sqlcondr.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

        Else
            MsgBox("No data found", vbExclamation)
        End If

    End Sub
End Class