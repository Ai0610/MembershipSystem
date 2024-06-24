Public Class UpdateStudentAdmin
    Public user As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If studbox.Text = Nothing Then
            MsgBox("Please Select information to be updated!")
        Else
            If GroupBox1.Enabled = False Then
                GroupBox1.Enabled = True
                deletebutton.Enabled = False
                closebutton.Enabled = True

            Else
                Dim ncount = 0
                'GROUPBOX1
                For Each c As Control In (GroupBox1.Controls)
                    If (TypeOf c Is TextBox) Then
                        Dim ctext As TextBox = CType(c, TextBox)

                        If (ctext.Text.Equals("")) Then

                            MsgBox("All fields must be filled")
                            Return

                        End If

                    ElseIf (TypeOf c Is MaskedTextBox) Then
                        Dim emask As MaskedTextBox = CType(c, MaskedTextBox)

                        If (emask.MaskCompleted = False) Then

                            MsgBox("All fields must be filled")
                            Return

                        ElseIf (emask.Text.Equals("")) Then
                            MsgBox("All fields must be filled")
                            Return

                        End If

                    ElseIf (TypeOf c Is ComboBox) Then
                        Dim ecombo As ComboBox = CType(c, ComboBox)

                        If (ecombo.Text.Equals("")) Then
                            MsgBox("All fields must be filled")
                            Return
                        End If

                    Else
                        ncount = ncount + 1
                    End If
                Next

                If ncount <> 0 Then

                    'UPDATE INFO
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "update info set email= '" & emailbox.Text & "',YL= '" & ylbox.SelectedItem & "',Section= '" & secbox.SelectedItem & "'," & _
                                                                 "SY= '" & SYbox.SelectedItem & "',Lastname= '" & ln.Text & "',Firstname= '" & fn.Text & "'," & _
                                                                "Middlename= '" & mn.Text & "',Course= '" & course.SelectedItem & "',Birthdate= '" & bd.Text & "'," & _
                                                                "Age= '" & agebox.Text & "',Gender= '" & gen.Text & "' where Stud_id='" & studbox.Text & "'"

                    sqlcmd.ExecuteNonQuery()
                    sqlcmd.Dispose()

                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If

                    'UPDATE CNTACT_TBL
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "update cntact_tbl set ConAddress= '" & caddbox.Text & "',ConPerson= '" & cpersonbox.Text & "',ConNumber= '" & cnum.Text & "'," & _
                                                                 "PhoneNumber= '" & cnbox.Text & "',Address= '" & Addbox.Text & "' where Stud_id='" & studbox.Text & "'"
                    sqlcmd.ExecuteNonQuery()
                    sqlcmd.Dispose()

                    GroupBox1.Enabled = False
                    deletebutton.Enabled = True
                    closebutton.Enabled = True
                    MsgBox("RECORD HAS BEEN SUCCESSFULLY UPDATED!", vbOKOnly + vbInformation)
                    StudListViewAdmin()
                    'CLEAR INFO IN GROUPBOX
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
                    fn.Clear()
                    ln.Clear()
                    agebox.Clear()
                    bd.Value = Now
                    mn.Clear()
                    gen.Text = ""
                    course.Text = ""

                End If

            End If
        End If
    End Sub

    'TRAPPING
    Private Sub ln_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ln.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub

    Private Sub fn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fn.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mn.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bd.Leave
        Dim age As Integer = DateTime.Today.Year - bd.Value.Year
        Dim num1 As Boolean
        Dim num2 As Boolean
        If DateTime.Today.Month = bd.Value.Month Then
            num1 = True
            If DateTime.Today.Day = bd.Value.Day Then
                num2 = True

            Else
                num2 = False



            End If
        Else
            num1 = False
        End If

        If num1 And num2 = True Then
            If age <= 16 Then
                MsgBox("The age in not right", vbInformation)
            Else
                agebox.Text = Str(age)
            End If

        Else
            If age <= 16 Then
                MsgBox("The age in not right", vbInformation)
            Else
                agebox.Text = Str(age - 1)
            End If
        End If
    End Sub

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

    'DELETE BUTTON
    Private Sub deletebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletebutton.Click
        If studbox.Text = Nothing Then
            MsgBox("Please Select information to be deleted!")

        Else
            Dim confirm = MsgBox("Are you sure you want to delete?", vbYesNo + vbQuestion, "DELETE?")
            If confirm = vbNo Then
                Exit Sub

            Else
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = ("delete from info where StudentNo like '" & studbox.Text & "' ")
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()

                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = ("delete from cntact_tbl where Stud_id like '" & studbox.Text & "' ")
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()

                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = ("delete from 1stsemster where Stud_id like '" & studbox.Text & "' ")
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()

                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = ("delete from 2ndsemester where Stud_id like '" & studbox.Text & "' ")
                sqlcmd.ExecuteNonQuery()
                sqlcmd.Dispose()

                StudListViewAdmin()
                MsgBox("RECORD HAS BEEN DELETED!", vbOKOnly + vbInformation, "Deleted")

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
                fn.Clear()
                ln.Clear()
                agebox.Clear()
                bd.Value = Now
                mn.Clear()
                gen.Text = ""
                course.Text = ""

            End If
        End If
    End Sub
    'CLOSE BUTTON
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        Me.Close()
        mainform.Show()
    End Sub
    'SEARCH BUTTON
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If InfoBox.Text = Nothing Then
            MsgBox("You must choose first what you want to search", vbExclamation)
            'COURSE
        ElseIf InfoBox.Text = "Course" Then
            Dim tmp As String = "select * from info where Course like '%" & search.Text & "%'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            ListView1.Items.Clear()
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data found", vbExclamation)
                search.Clear()
                search.Focus()
            ElseIf search.Text.Trim = "" Then
                MsgBox("No data found", vbExclamation)
                search.Clear()
                search.Focus()
            Else
                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("Course"))
                    NewItem.SubItems.Add(sqlcondr("YL"))
                End While
                search.Clear()
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()
            'STUDENT NUMBER
        ElseIf InfoBox.Text = "Student Number" Then
            Dim tmp As String = "select * from info where StudentNo like '%" & search.Text & "%'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            ListView1.Items.Clear()
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data found", vbExclamation)
                search.Clear()
                search.Focus()
            ElseIf search.Text.Trim = "" Then
                MsgBox("No data found", vbExclamation)
                search.Clear()
                search.Focus()
            Else
                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("Course"))
                    NewItem.SubItems.Add(sqlcondr("YL"))
                End While
                search.Clear()
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()
            'YEAR LEVEL
        ElseIf InfoBox.Text = "Year Level" Then
            Dim tmp As String = "select * from info where YL like '%" & search.Text & "%'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            ListView1.Items.Clear()
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data found", vbExclamation)
                search.Clear()
                search.Focus()
            ElseIf search.Text.Trim = "" Then
                MsgBox("No data found", vbExclamation)
                search.Clear()
                search.Focus()
            Else
                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("Course"))
                    NewItem.SubItems.Add(sqlcondr("YL"))
                End While
                search.Clear()
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()
            'SCHOOL YEAR
        ElseIf InfoBox.Text = "School Year" Then
            Dim tmp As String = "select * from info where SY like '%" & search.Text & "%'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            ListView1.Items.Clear()
            If sqlcondr.HasRows = 0 Then
                MsgBox("No data found", vbExclamation)
                search.Clear()
                search.Focus()
            ElseIf search.Text.Trim = "" Then
                MsgBox("No data found", vbExclamation)
                search.Clear()
                search.Focus()
            Else
                While (sqlcondr.Read())
                    Dim NewItem As ListViewItem
                    NewItem = ListView1.Items.Add(sqlcondr("StudentNo"))
                    NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                    NewItem.SubItems.Add(sqlcondr("Course"))
                    NewItem.SubItems.Add(sqlcondr("YL"))
                End While
                search.Clear()
            End If
            sqlcmd.Dispose()
            sqlcondr.Close()

        Else
            MsgBox("No data found", vbExclamation)
            search.Clear()
        End If
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = "select * from info where StudentNo = '" & ListView1.FocusedItem.Text & "'"

        sqlcondr = sqlcmd.ExecuteReader

        While sqlcondr.Read()
            If sqlcondr.HasRows Then
                fn.Text = sqlcondr.Item("Firstname")
                mn.Text = sqlcondr.Item("Middlename")
                ln.Text = sqlcondr.Item("Lastname")
                studbox.Text = sqlcondr.Item("StudentNo")
                course.Text = sqlcondr.Item("Course")
                emailbox.Text = sqlcondr.Item("email")
                ylbox.Text = sqlcondr.Item("YL")
                SYbox.Text = sqlcondr.Item("SY")
                secbox.Text = sqlcondr.Item("Section")
                agebox.Text = sqlcondr.Item("age")
                bd.Value = sqlcondr.Item("birthdate")
                gen.Text = sqlcondr.Item("gender")
            End If
        End While
        sqlcondr.Close()
        sqlcmd.Dispose()

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

    End Sub

    Private Sub UpdateStudentAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Student Number", CInt(ListView1.Width / 4))
        ListView1.Columns.Add("Name", CInt(ListView1.Width / 2.5))
        ListView1.Columns.Add("Course", CInt(ListView1.Width / 5))
        ListView1.Columns.Add("Year Level", CInt(ListView1.Width / 5))

        sqlcmd.Dispose()
        sqlcondr.Close()
        Dim tmp As String = "SELECT * FROM Course"
        sqlcmd.CommandText = tmp
        sqlcmd.Connection = sqlcon

        sqlcondr = sqlcmd.ExecuteReader

        While (sqlcondr.Read())
            course.Items.Add(sqlcondr("Ccode"))
        End While
        sqlcmd.Dispose()
        sqlcondr.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        user = "Admin"
        If SYbox.Text = Nothing Then
            MsgBox("You must input a school year first")
        Else
            UpdatePayment.Show()
            UpdatePayment.AdminButton.Show()
            UpdatePayment.Userbutton.Enabled = False
            UpdatePayment.Userbutton.Hide()
        End If
    End Sub
End Class