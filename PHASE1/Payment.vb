Public Class Payment
    Public stat As String '===>Variable ng Status<==='
    Public exp As String '===> Variable pra sa expiration date<==='

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        module2.updateFeeShow()
    End Sub

    'TRAPPING
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = Nothing Then
            Label1.Text = "Choose a Semester"
        Else
            Label1.Text = "Semester"
        End If
        If paymentbox.Text = Nothing Then
            MsgBox("Please input the right amount", , "Warning")
        ElseIf paymentbox.Text.Length <= 1 Then

        ElseIf paymentbox.Text.Length > 3 Then

        ElseIf paymentbox.Text > Settings.showbox.Text Then
            MsgBox("You input too much amount", , "Warning")
            paymentbox.Clear()
            paymentbox.Focus()
        ElseIf paymentbox.Text < 10 Then
            MsgBox("Must Input at least 10.00", , "Warning")
            paymentbox.Clear()
            paymentbox.Focus()
            Else
            'FIRST SEMESTER
            If ComboBox1.Text = "1st Semester" Then
                If paymentbox.Text <> Settings.showbox.Text Then

                    stat = "NOT REGISTERED"
                Else
                    stat = "NOT REGISTERED"
                End If

                'EXPIRED DATE FIRST SEM
                sqlcondr.Close()
                sqlcmd.Dispose()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If

                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "select expiredDate from expiration where schoolYear = '" & StudentAdd.SYbox.SelectedItem & "'"

                sqlcondr = sqlcmd.ExecuteReader

                If sqlcondr.HasRows = 0 Then
                    MsgBox("Please give the default expiration date", vbExclamation)
                    Return
                Else
                    While sqlcondr.Read()
                        exp = sqlcondr("expiredDate")
                    End While
                    sqlcondr.Close()
                    sqlcmd.Dispose()

                    'SAVE IN FIRST SEM
                    FirstSem()
                    savePersonalInfo()
                    saveContactInfo()
                    Me.Close()
                    StudentNumber.Close()
                    AddAccount.Close()
                    mainform.Show()
                End If


                '2ND SEMESTER
            ElseIf ComboBox1.Text = "2nd Semester" Then
                If paymentbox.Text <> Settings.showbox.Text Then

                    stat = "NOT REGISTERED"
                Else
                    stat = "NOT REGISTERED"
                End If

                'EXPIRED DATE SECOND SEM
                sqlcondr.Close()
                sqlcmd.Dispose()
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If

                sqlcmd.Connection = sqlcon
                sqlcmd.CommandText = "select expiredDate from expiration where schoolYear = '" & StudentAdd.SYbox.SelectedItem & "'"

                sqlcondr = sqlcmd.ExecuteReader

                If sqlcondr.HasRows = 0 Then
                    MsgBox("There's no expiration date for you membership, Please contact the admin to default it", vbInformation, "Information")
                    Me.Close()
                    mainform.Show()
                Else
                    While sqlcondr.Read()
                        exp = sqlcondr("expiredDate")
                    End While
                    sqlcondr.Close()
                    sqlcmd.Dispose()

                    'SAVE FOR SECOND SEM
                    SecondSem()
                    savePersonalInfo()
                    saveContactInfo()
                    Me.Close()
                    StudentNumber.Close()
                    AddAccount.Close()
                    mainform.Show()
                End If

            End If


        End If

    End Sub

    Private Sub paymentbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles paymentbox.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class