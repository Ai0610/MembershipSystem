Public Class Settings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        If CourseBox.Text = "" Then
            MsgBox("Please Enter Required Field!", vbOKOnly + vbCritical)
            Return
        ElseIf CodeBox.Text = "" Then
            MsgBox("Please Enter Required Field!", vbOKOnly + vbCritical)
            Return
        Else
            course()
            MsgBox("New Record has been Added", vbOKOnly + vbInformation)
            Me.Close()
        End If
    End Sub

    Private Sub Exbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exbutton.Click
        
        If SYbox.Text = ("0000-0000") Then
            MsgBox("Please enter the required field")
            Return
        ElseIf sembox.Text = Nothing Then
            MsgBox("Please enter the required field")
            Return
        ElseIf sembox.Text = "1st Semester" Then
            If DateTimePicker1.Value.Year < SYbox.Text.Substring(0, 4) Then
                MsgBox("The year you entered  do not correspond with the school year you enter", vbExclamation)
                Return
            ElseIf DateTimePicker1.Value.Year > SYbox.Text.Substring(0, 4) Then
                MsgBox("The year you entered  do not correspond with the school year you enter", vbExclamation)
                Return
            Else
                ExpireDate()
                MsgBox("New Record has been Added", vbOKOnly + vbInformation)
                Me.Close()
            End If
        ElseIf sembox.Text = "2nd Semester" Then

            If DateTimePicker1.Value.Year > SYbox.Text.Substring(5, 4) Then
                MsgBox("The year you entered  do not correspond with the school year you enter", vbExclamation)
                Return
            ElseIf DateTimePicker1.Value.Year < SYbox.Text.Substring(5, 4) Then
                MsgBox("The year you entered  do not correspond with the school year you enter", vbExclamation)
                Return
            Else
                ExpireDate()
                MsgBox("New Record has been Added", vbOKOnly + vbInformation)
                Me.Close()
            End If
       
        End If




    End Sub

    Private Sub CourseBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CourseBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SYbox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYbox.Leave
        If SYbox.MaskCompleted = False Then
            MsgBox("Please enter the required field")
            Return
        End If
    End Sub

   
    Private Sub feeupdatebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles feeupdatebutton.Click
        feebox.Focus()

        If feebox.Text.Length <= 1 Then
            MsgBox(feebox.Text.Length, vbInformation)
            feebox.Clear()
            feebox.Focus()
        ElseIf feebox.Text.Length > 3 Then
            MsgBox("GREATER", vbInformation)
            feebox.Clear()
            feebox.Focus()
        Else
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

                If sqlcondr.Read Then


                    If feebox.Text = sqlcondr("payment") Then
                        MsgBox("The membership fee is already the same no need to update!", vbInformation)
                        showbox.Show()
                        feebox.Hide()
                        feeupdatebutton.Hide()
                        Button2.Show()
                    ElseIf feebox.Text = Nothing Then
                        MsgBox("Input the right fee for the system", vbExclamation)
                    Else
                        updateFee()
                        updateFeeShow()
                        showbox.Show()
                        feebox.Hide()
                        feeupdatebutton.Hide()
                        Button2.Show()
                    End If

                End If

                sqlcondr.Close()
                sqlcon.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        End If



    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateFeeShow()
        feeupdatebutton.Hide()
        feebox.Hide()
        showbox.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        feebox.Show()
        showbox.Hide()
        Button2.Hide()
        feeupdatebutton.Show()
    End Sub


    Private Sub feebox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles feebox.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class