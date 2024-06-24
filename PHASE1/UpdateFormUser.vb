Public Class UpdateFormUser
    Public user As String
    'FORM LOAD
    Private Sub UpdateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Student Number", CInt(ListView1.Width / 5))
        ListView1.Columns.Add("Name", CInt(ListView1.Width / 2))
        ListView1.Columns.Add("Course", CInt(ListView1.Width / 5))
        ListView1.Columns.Add("Year Level", CInt(ListView1.Width / 5))
    End Sub

    'SEARCH BUTTON
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

                Dim tmp As String = "select * from info where Course like '%" & Sbox.Text & "%'"
                sqlcmd.CommandText = tmp
                sqlcmd.Connection = sqlcon

                sqlcondr = sqlcmd.ExecuteReader

                ListView1.Items.Clear()
                If sqlcondr.HasRows = 0 Then
                    MsgBox("No data found", vbExclamation)
                    Sbox.Clear()
                    Sbox.Focus()
                ElseIf Sbox.Text.Trim = "" Then
                    MsgBox("No data found", vbExclamation)
                    Sbox.Clear()
                    Sbox.Focus()
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
            '===>STUDENT NUMBER<==='
        ElseIf InfoBox.Text = "Student Number" Then
            Try
                sqlcmd.Dispose()
                sqlcondr.Close()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                Dim tmp As String = "select * from info where StudentNo like '%" & Sbox.Text & "%'"
                sqlcmd.CommandText = tmp
                sqlcmd.Connection = sqlcon

                sqlcondr = sqlcmd.ExecuteReader

                ListView1.Items.Clear()
                If sqlcondr.HasRows = 0 Then
                    MsgBox("No data found", vbExclamation)
                    Sbox.Clear()
                    Sbox.Focus()
                ElseIf Sbox.Text.Trim = "" Then
                    MsgBox("No data found", vbExclamation)
                    Sbox.Clear()
                    Sbox.Focus()
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

            '===>YEAR LEVEL<==='
        ElseIf InfoBox.Text = "Year Level" Then
            Try
                sqlcmd.Dispose()
                sqlcondr.Close()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                Dim tmp As String = "select * from info where YL like '%" & Sbox.Text & "%'"
                sqlcmd.CommandText = tmp
                sqlcmd.Connection = sqlcon

                sqlcondr = sqlcmd.ExecuteReader

                ListView1.Items.Clear()
                If sqlcondr.HasRows = 0 Then
                    MsgBox("No data found", vbExclamation)
                    Sbox.Clear()
                    Sbox.Focus()
                ElseIf Sbox.Text.Trim = "" Then
                    MsgBox("No data found", vbExclamation)
                    Sbox.Clear()
                    Sbox.Focus()
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

            '===>SCHOOL YEAR<==='
        ElseIf InfoBox.Text = "School Year" Then
            Try
                sqlcmd.Dispose()
                sqlcondr.Close()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                Dim tmp As String = "select * from info where SY like '%" & Sbox.Text & "%'"
                sqlcmd.CommandText = tmp
                sqlcmd.Connection = sqlcon

                sqlcondr = sqlcmd.ExecuteReader

                ListView1.Items.Clear()
                If sqlcondr.HasRows = 0 Then
                    MsgBox("No data found", vbExclamation)
                    Sbox.Clear()
                    Sbox.Focus()
                ElseIf Sbox.Text.Trim = "" Then
                    MsgBox("No data found", vbExclamation)
                    Sbox.Clear()
                    Sbox.Focus()
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
    'LISTVIEW
    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        '===>STUDENT PERSONAL INFORMATION<==='
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "select * from info where StudentNo = '" & ListView1.FocusedItem.Text & "'"

            sqlcondr = sqlcmd.ExecuteReader

            While sqlcondr.Read()
                If sqlcondr.HasRows Then
                    namebox.Text = sqlcondr.Item("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename")
                    studbox.Text = sqlcondr.Item("StudentNo")
                    cobox.Text = sqlcondr.Item("Course")
                    emailbox.Text = sqlcondr.Item("email")
                    ylbox.Text = sqlcondr.Item("YL")
                    SYbox.Text = sqlcondr.Item("SY")
                    secbox.Text = sqlcondr.Item("Section")
                End If
            End While
            sqlcondr.Close()
            sqlcmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        '===>STUDENT CONTACT INFORMATION<==='
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
                    cnum.Text = sqlcondr.Item("ConNumber")
                    cpersonbox.Text = sqlcondr.Item("ConPerson")
                    caddbox.Text = sqlcondr.Item("ConAddress")
                    cnbox.Text = sqlcondr.Item("PhoneNumber")
                    Addbox.Text = sqlcondr.Item("Address")
                End If
            End While

            sqlcondr.Close()
            sqlcmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    'UPDATE BUTTON
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If studbox.Text = Nothing Then
            MsgBox("Please Select information to be updated!")
        Else

            If GroupBox1.Enabled = False Then
                GroupBox1.Enabled = True
                closebutton.Enabled = True
            Else
                '===>UPDATE STUDENT PERSONAL INFORMATION<==='
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "update info set email= '" & emailbox.Text & "',YL= '" & ylbox.SelectedItem & "',Section= '" & secbox.SelectedItem & "'," & _
                                                                 "SY= '" & SYbox.SelectedItem & "' where StudentNo='" & studbox.Text & "'"
                    sqlcmd.ExecuteNonQuery()
                    sqlcondr.Close()
                    sqlcmd.Dispose()

                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try
                '===>UPDATE CONTACT INFORMATION<==='
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If

                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "update cntact_tbl set ConAddress= '" & caddbox.Text & "',ConPerson= '" & cpersonbox.Text & "',ConNumber= '" & cnum.Text & "'," & _
                                                                 "PhoneNumber= '" & cnbox.Text & "',Address= '" & Addbox.Text & "' where Stud_id='" & studbox.Text & "'"
                    sqlcmd.ExecuteNonQuery()
                    sqlcondr.Close()
                    sqlcmd.Dispose()

                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try

                GroupBox1.Enabled = False
                closebutton.Enabled = True
                MsgBox("RECORD HAS BEEN SUCCESSFULLY UPDATED!", vbOKOnly + vbInformation)
                StudListViewUser()

                emailbox.Clear()
                ylbox.Text = ""
                secbox.Text = ""
                SYbox.Text = ""
                caddbox.Clear()
                cpersonbox.Clear()
                cnum.Clear()
                cnbox.Clear()
                Addbox.Clear()
                studbox.Text = ""
                namebox.Text = ""
                cobox.Text = ""

                End If
            End If

    End Sub
    'CLOSE BUTTON
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        Me.Close()
        mainform.Show()
    End Sub

    'TRAPPING
    Private Sub cnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cnum.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cnbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cnbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cnbox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnbox.Leave
        If cnbox.Text.StartsWith("09") = False Then
            MsgBox("The contact number you input is invalid")
            cnbox.Clear()
            cnbox.Focus()
        ElseIf cnbox.Text = ("00000000000") Then
        End If
    End Sub

    Private Sub cnum_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnum.Leave
        If cnum.Text.StartsWith("09") = False Then
            MsgBox("The contact number you input is invalid")
            cnum.Clear()
            cnum.Focus()
        ElseIf cnbox.Text = ("00000000000") Then
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        user = "User"
        If SYbox.Text = Nothing Then
            MsgBox("You must input a school year first")
        Else
            UpdatePayment.Show()
            UpdatePayment.Userbutton.Show()
            UpdatePayment.AdminButton.Enabled = False
            UpdatePayment.AdminButton.Hide()
        End If
    End Sub
End Class