Public Class AlumniForm

    Private Sub deletebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletebutton.Click
        If search.Text = Nothing Then
            MsgBox("Please Select information to be deleted!")

        Else
            Dim confirm = MsgBox("Are you sure you want to delete?", vbYesNo + vbQuestion, "DELETE?")
            If confirm = vbNo Then
                Exit Sub

            Else
                sqlcondr.Close()
                sqlcmd.Dispose()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = ("delete FROM info where YL like '" & search.Text & "' ")
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()
                '|| ------------------------------------------------------------------------------------------------------------------||'
                sqlcondr.Close()
                sqlcmd.Dispose()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = ("delete a.*,b.* FROM info a JOIN cntact_tbl b ON a.StudentNo=b.stud_id where a.YL like '" & search.Text & "' ")
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()

                '|| ------------------------------------------------------------------------------------------------------------------||'

                sqlcondr.Close()
                sqlcmd.Dispose()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = ("delete from 2ndsemester where SchoolYearTWO like '" & search.Text & "' ")
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()

                alumDelete()
                MsgBox("RECORD HAS BEEN DELETED!", vbOKOnly + vbInformation, "Deleted")
                module2.Viewer()
            End If
        End If
    End Sub

    Private Sub AlumniForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If

        ListView1.Columns.Add("Student Number", CInt(ListView1.Width / 5))
        ListView1.Columns.Add("Name", CInt(ListView1.Width / 2.5))
        ListView1.Columns.Add("Course", CInt(ListView1.Width / 5))
        ListView1.Columns.Add("Year Level", CInt(ListView1.Width / 5))

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        sqlcondr.Close()
        sqlcmd.Dispose()
        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If
        Dim tmp As String = "select * from info where YL like '%" & search.Text & "%'"
        sqlcmd.CommandText = tmp
        sqlcmd.Connection = sqlcon

        sqlcondr = sqlcmd.ExecuteReader

        ListView1.Items.Clear()
        If sqlcondr.HasRows = 0 Then
            MsgBox("No data found", vbExclamation)
            search.Text = ""
            search.Focus()
        ElseIf search.Text.Trim = "" Then
            MsgBox("No data found", vbExclamation)
            search.Text = ""
            search.Focus()
        Else
            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                NewItem.SubItems.Add(sqlcondr("Course"))
                NewItem.SubItems.Add(sqlcondr("YL"))
            End While
            deletebutton.Enabled = True
        End If

    End Sub
End Class