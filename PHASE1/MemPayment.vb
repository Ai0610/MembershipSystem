Public Class MemPayment
    Public value As Integer
    Public output As String
    Public status As String

    Private Sub MemPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        value = Int(TextBox1.Text)
        module2.updateFeeShow()
    End Sub
    'SAVE BUTTON
    Private Sub Userbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        '||IF ONE STATEMENT----------------------------------------------------------------------------------------------------------||'
        If paymentbox.Text = Nothing Then
            MsgBox("Please input the right amount", , "Warning")
        ElseIf paymentbox.Text.Length < 1 Then
            MsgBox(output, , "Warning")
        ElseIf paymentbox.Text.Length > 3 Then
            MsgBox(output, , "Warning")
        ElseIf paymentbox.Text < 10 Then
            MsgBox("Must Input at least 10.00", , "Warning")
            paymentbox.Clear()
            paymentbox.Focus()
        Else
            output = value + Int(paymentbox.Text)
            '|| IF TWO STATEMENT--------------------------------------------------------------------------------------------------------||'
            If output > Int(Settings.showbox.Text) Then
                MsgBox(output, , "Warning")
                paymentbox.Clear()
                paymentbox.Focus()
            Else
                If output <> Settings.showbox.Text Then
                    status = "NOT REGISTERED"
                Else
                    status = "REGISTERED"

                End If
                '|| IF THREE STATEMENT------------------------------------------------------------------------------------------------------||'
                If Label1.Text = "1st Semester" Then

                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = " update 1stSemster a set payment= '" & output & "',STATUS='" & status & "'  where Stud_id='" & UpdateFirstSem.ListView1.SelectedItems(0).SubItems(0).Text & "' and YearLevelOne = '" & UpdateFirstSem.ListView1.SelectedItems(0).SubItems(2).Text & "'"

                    sqlcmd.ExecuteNonQuery()
                    sqlcmd.Dispose()
                    MsgBox("Membership Updated", , " ")
                    Me.Close()
                    UpdateFirstSem.Close()
                    mainform.Show()


                ElseIf Label1.Text = "2nd Semester" Then

                    sqlcmd.Dispose()
                    sqlcondr.Close()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "update 2ndSemester set SecondPayment= '" & output & "',SecondSTATUS'" & status & "' where Stud_id='" & UpdateSecondSem.ListView1.SelectedItems(0).SubItems(0).Text & "' and YearLevelTwo = '" & UpdateSecondSem.ListView1.SelectedItems(0).SubItems(2).Text & "'"

                    sqlcmd.ExecuteNonQuery()
                    sqlcmd.Dispose()
                    MsgBox("Membership Updated", , " ")
                    Me.Close()
                    UpdateFirstSem.Close()
                    mainform.Show()
                    '|| END IF ONE STATEMENT------------------------------------------------------------------------------------------------------||'
                End If
                '|| END IF TWO STATEMENT----------------------------------------------------------------------------------------------||'
            End If
            '|| END IF THREE STATEMENT-------------------------------------------------------------------------------------------------||'
        End If

    End Sub
End Class