Public Class StudentNumber

    'SAVE BUTTON
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If StudIDbox.MaskCompleted = False Then
            MsgBox("Please complete the student number")
            StudIDbox.Clear()
            StudIDbox.Focus()
        ElseIf StudIDbox.Text = "00-00000-0" Then
            MsgBox("Not a Valid stuID")
            StudIDbox.Clear()
            StudIDbox.Focus()
            Else
                Me.Hide()
                StudentAdd.Show()
        End If
    End Sub

    ' FORM LOAD
    Private Sub StudentNumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If
    End Sub

    Private Sub StudIDbox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudIDbox.Leave
        Dim tmp As String = "SELECT * FROM Info "
        sqlcmd.CommandText = tmp
        sqlcmd.Connection = sqlcon

        sqlcondr = sqlcmd.ExecuteReader
        While (sqlcondr.Read())

            If StudIDbox.Text = sqlcondr("StudentNo") Then

                MsgBox("The student number already exist!")

                StudIDbox.Clear()
            End If
        End While
        sqlcmd.Dispose()
        sqlcondr.Close()
    End Sub
End Class