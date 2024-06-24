Public Class AddAccount
    'ADD BUTTON
    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        If addpass.Text <> repassbox.Text Then
            MsgBox("The password does not match")
            addpass.Clear()
            repassbox.Clear()
            addpass.Focus()
        End If

        If addname.Text.Trim = "" Then
            MsgBox("Please Enter Required Field!", vbOKOnly + vbCritical)
            Return
        ElseIf adduser.Text.Trim = "" Then
            MsgBox("Please Enter Required Field!", vbOKOnly + vbCritical)
            Return
        ElseIf addpass.Text.Trim = "" Then
            MsgBox("Please Enter Required Field!", vbOKOnly + vbCritical)
            Return
        ElseIf addauthority.Text.Trim = "" Then
            MsgBox("Please Enter Required Field!", vbOKOnly + vbCritical)
            Return
        Else
            SaveAccount()
        End If




    End Sub

    'TRAPPING
    Private Sub addname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addname.Leave

        If addname.Text.ToLower = "admin" Then
            MsgBox("The word admin is not valid in name")
            addname.Clear()
            addname.Focus()
        End If

        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            '===>CHECK IF THERE IS ALREADY AN EXISTING USERNAME<==='
            Dim tmp As String = "select * from tbl_account"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon
            sqlcondr = sqlcmd.ExecuteReader

            While (sqlcondr.Read())
                If adduser.Text.ToLower = sqlcondr("Username") Then
                    MsgBox("There's already an existing username")
                    adduser.Clear()
                    adduser.Focus()
                    Return
                End If
            End While

            sqlcmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub adduser_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adduser.Leave
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            '===>CHECK IF THERE IS ALREADY AN EXISTING NAME<==='
            Dim tmp As String = "select * from tbl_account"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon
            sqlcondr = sqlcmd.ExecuteReader

            While (sqlcondr.Read())
                If addname.Text.ToUpper = sqlcondr("Name") Then
                    MsgBox("There's already an existing Name")
                    addname.Clear()
                    addname.Focus()
                    Return
                End If
            End While

            sqlcmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub addpass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addpass.Leave
        If addpass.Text.Length <= 8 Then
            MsgBox("Type at least 8 letters")
            addpass.Clear()
            addpass.Focus()
        End If
    End Sub

    Private Sub addname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles addname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub

   
    'CLOSE BUTTON
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        mainform.Show()
    End Sub
End Class