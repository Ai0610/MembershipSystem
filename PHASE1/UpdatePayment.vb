Public Class UpdatePayment
    Public sy As String
    Public stat As String
    Public exp As String
    'ADMIN BUTTON
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminButton.Click
        If ComboBox1.Text = Nothing Then
            Label1.Text = "Choose a Semester"
        Else
            Label1.Text = "Semester"
        End If

          If paymentbox.Text = Nothing Then
            MsgBox("Please input the right amount", , "Warning")
        ElseIf paymentbox.Text.Length <= 1 Then

        ElseIf paymentbox.Text.Length > 3 Then

        ElseIf paymentbox.Text > Int(Settings.showbox.Text) Then
            MsgBox("You input too much amount", , "Warning")
            paymentbox.Clear()
            paymentbox.Focus()
        ElseIf paymentbox.Text < 10 Then
            MsgBox("Must Input at least 10.00", , "Warning")
            paymentbox.Clear()
            paymentbox.Focus()

        Else
            '|| ------------------------------------------------------------------------------------------------------------------||'
            '===>FIRST SEMESTER<==='
            If ComboBox1.Text = "1st Semester" Then
                If paymentbox.Text <> "50" Then

                    stat = "NOT REGISTERED"
                Else
                    stat = "NOT REGISTERED"
                End If

                'EXPIRATION DATE
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "select expiredDate from expiration where schoolYear = '" & UpdateStudentAdmin.SYbox.Text & "'"

                    sqlcondr = sqlcmd.ExecuteReader
                    If sqlcondr.HasRows = 0 Then
                        MsgBox("There's no default expiration date on the said schoolYear/Please contact the admin", vbExclamation)
                        Me.Close()
                        mainform.Show()
                    Else
                        While sqlcondr.Read()
                            exp = sqlcondr("expiredDate")
                        End While
                        sqlcondr.Close()
                        sqlcmd.Dispose()
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                'CHECK IF THERE IS AN ALREADY EXISTING REGISTRATION
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()

                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    Dim temp As String = "select * from 1stsemster where Stud_id like '%" & UpdateStudentAdmin.studbox.Text & "%'"
                    sqlcmd.CommandText = temp
                    sqlcmd.Connection = sqlcon

                    sqlcondr = sqlcmd.ExecuteReader

                    If sqlcondr.HasRows = 0 Then
                        MsgBox("There's no data found!")
                        'SAVE FOR FIRST SEM
                        UpdateSemOneAdmin()
                        Me.Close()
                        mainform.Show()
                    Else
                        While sqlcondr.Read()
                            If UpdateFormUser.SYbox.Text = sqlcondr("SchoolYearOne") Then
                                MsgBox("You're already registered in that same year in 1st Semester", vbInformation)
                                paymentbox.Clear()
                                paymentbox.Focus()
                            End If
                        End While
                        sqlcmd.Dispose()
                        sqlcondr.Close()

                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                '|| ------------------------------------------------------------------------------------------------------------------||'
                '===>SECOND SEMESTER<==='
            ElseIf ComboBox1.Text = "2nd Semester" Then
                If paymentbox.Text <> "50" Then

                    stat = "NOT REGISTERED"
                Else
                    stat = "NOT REGISTERED"
                End If
                'EXPIRATION DATE 2ND SEM
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "select expiredDate from expiration where schoolYear = '" & UpdateStudentAdmin.SYbox.Text & "'"

                    sqlcondr = sqlcmd.ExecuteReader
                    If sqlcondr.HasRows = 0 Then
                        MsgBox("There's no default expiration date on the said schoolYear/Please contact the admin", vbExclamation)
                        Me.Close()
                        mainform.Show()
                    Else
                        While sqlcondr.Read()
                            exp = sqlcondr("expiredDate")
                        End While
                        sqlcondr.Close()
                        sqlcmd.Dispose()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                '===>CHECK IF THERE IS AN ALREADY EXISTING REGISTRATION IN SECOND SEM<==='
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    Dim temp As String = "select * from 2ndsemester where Stud_id like '%" & UpdateStudentAdmin.studbox.Text & "%'"
                    sqlcmd.CommandText = temp
                    sqlcmd.Connection = sqlcon

                    sqlcondr = sqlcmd.ExecuteReader

                    If sqlcondr.HasRows = 0 Then
                        MsgBox("There's no data found!")
                        '===>SAVE FOR SECOND SEM<==='
                        UpdateSemTwoAdmin()
                        Me.Close()
                        mainform.Show()
                    Else
                        While sqlcondr.Read()
                            If UpdateFormUser.SYbox.Text = sqlcondr("SchoolYearTwo") Then
                                MsgBox("You're already registered in that same year in 2nd Semester", vbInformation)
                                paymentbox.Clear()
                                paymentbox.Focus()
                            End If

                        End While
                        sqlcmd.Dispose()
                        sqlcondr.Close()

                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If
            '|| ------------------------------------------------------------------------------------------------------------------||'

        End If




    End Sub

    'USER BUTTON
    Private Sub Userbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Userbutton.Click
      
        If paymentbox.Text = Nothing Then
            MsgBox("Please input the right amount", , "Warning")
        ElseIf paymentbox.Text.Length <= 1 Then

        ElseIf paymentbox.Text.Length > 3 Then

        ElseIf paymentbox.Text > Int(Settings.showbox.Text) Then
            MsgBox("You input too much amount", , "Warning")
            paymentbox.Clear()
            paymentbox.Focus()
        ElseIf paymentbox.Text < 10 Then
            MsgBox("Must Input at least 10.00", , "Warning")
            paymentbox.Clear()
            paymentbox.Focus()
        Else
            '|| ------------------------------------------------------------------------------------------------------------------||'
            'FIRST SEMESTER
            If ComboBox1.Text = "1st Semester" Then
                If paymentbox.Text <> "50" Then

                    stat = "NOT REGISTERED"
                Else
                    stat = "NOT REGISTERED"
                End If

                'EXPIRATION DATE
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "select expiredDate from expiration where schoolYear = '" & UpdateFormUser.SYbox.Text & "'"

                    sqlcondr = sqlcmd.ExecuteReader
                    If sqlcondr.HasRows = 0 Then
                        MsgBox("Please give the default expiration date", vbExclamation)
                        Me.Close()
                        mainform.Show()
                    Else
                        While sqlcondr.Read()
                            exp = sqlcondr("expiredDate")
                        End While
                        sqlcondr.Close()
                        sqlcmd.Dispose()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                'CHECK IF THERE IS AN ALREADY EXISTING REGISTRATION
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    Dim temp As String = "select * from 1stsemster where Stud_id like '%" & UpdateFormUser.studbox.Text & "%'"
                    sqlcmd.CommandText = temp
                    sqlcmd.Connection = sqlcon

                    sqlcondr = sqlcmd.ExecuteReader

                    If sqlcondr.HasRows = 0 Then
                        MsgBox("There's no data found!")
                        'SAVE FOR FIRST SEM
                        UpdateSemOneUser()
                        Me.Close()
                        mainform.Show()
                    Else
                        While sqlcondr.Read()
                            If UpdateFormUser.SYbox.Text = sqlcondr("SchoolYearOne") Then
                                MsgBox("You're already registered in that same year in 1st Semester", vbInformation)
                                paymentbox.Clear()
                                paymentbox.Focus()
                            End If
                        End While
                        sqlcmd.Dispose()
                        sqlcondr.Close()
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try


                '|| ------------------------------------------------------------------------------------------------------------------||'

                '===>SECOND SEMESTER COMBO<===
            ElseIf ComboBox1.Text = "2nd Semester" Then
                If paymentbox.Text <> "50" Then

                    stat = "NOT REGISTERED"
                Else
                    stat = "NOT REGISTERED"
                End If
                '===>EXPIRATION DATE 2ND SEM<====
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "select expiredDate from expiration where schoolYear = '" & UpdateFormUser.SYbox.Text & "'"

                    sqlcondr = sqlcmd.ExecuteReader
                    If sqlcondr.HasRows = 0 Then
                        MsgBox("Please give the default expiration date", vbExclamation)
                        Me.Close()
                        mainform.Show()
                    Else
                        While sqlcondr.Read()
                            exp = sqlcondr("expiredDate")
                        End While
                        sqlcondr.Close()
                        sqlcmd.Dispose()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                '===>CHECK IF THERE IS AN ALREADY EXISTING REGISTRATION IN SECOND SEM<===
                Try
                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If

                    Dim temp As String = "select * from 2ndsemester where Stud_id like '%" & UpdateFormUser.studbox.Text & "%'"
                    sqlcmd.CommandText = temp
                    sqlcmd.Connection = sqlcon

                    sqlcondr = sqlcmd.ExecuteReader

                    If sqlcondr.HasRows = 0 Then
                        MsgBox("There's no data found!")
                        '===>SAVE FOR SECOND SEM<===
                        UpdateSemTwoUser()
                        Me.Close()
                        mainform.Show()
                    Else
                        While sqlcondr.Read()
                            If UpdateFormUser.SYbox.Text = sqlcondr("SchoolYearTwo") Then
                                MsgBox("You're already registered in that same year in 2nd Semester", vbInformation)
                                paymentbox.Clear()
                                paymentbox.Focus()
                            End If
                        End While
                        sqlcmd.Dispose()
                        sqlcondr.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            '|| ------------------------------------------------------------------------------------------------------------------||'

        End If



    End Sub

   
    Private Sub UpdatePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        module2.updateFeeShow()
    End Sub
End Class