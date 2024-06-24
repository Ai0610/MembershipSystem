Public Class StudentAdd

    'FORM LOAD
    Private Sub StudentAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label15.Text = StudentNumber.StudIDbox.Text

        Try

            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            '====>LOADING OF DROPDOWNLIST OF COURSE<===='
            Dim tmp As String = "SELECT * FROM Course"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            While (sqlcondr.Read())
                Coursebox.Items.Add(sqlcondr("Ccode"))
            End While
            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    'SAVE BUTTON
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        '====>CHECK IF COMPLETE FIELD<===='
        If ncount <> 0 Then
            If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Me.Hide()
                Payment.Show()
                
            End If
        End If


    End Sub

    'TRAPPING
    Private Sub emailbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailbox.TextChanged

        If emailbox.Text.Contains("@") = False Then
            Label12.Text = "Enter a valid email"
            Return
        ElseIf emailbox.Text.Contains(".com") = False Then
            Label12.Text = "Enter a valid email"
            Return
        Else
            Label12.Text = "Validated"
        End If
    End Sub

    Private Sub emailbox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailbox.Leave
        If Label12.Text = "Enter a valid email" Then
            emailbox.Clear()
        Else

        End If
    End Sub

    Private Sub cnbox_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnbox.Leave
        If cnbox.Text.StartsWith("09") = False Then
            MsgBox("The contact number you input is invalid")
            cnbox.Clear()
            cnbox.Focus()
        ElseIf cnbox.Text = ("00000000000") Then
        End If
    End Sub

    Private Sub cnumbox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnumbox.Leave
        If cnumbox.Text.StartsWith("09") = False Then
            MsgBox("The contact number you input is invalid")
            cnumbox.Clear()
            cnumbox.Focus()
        ElseIf cnbox.Text = ("00000000000") Then
        End If
    End Sub

    Private Sub Lnbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Lnbox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Fnbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Fnbox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Mnbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Mnbox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bdaybox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdaybox.Leave
        Dim age As Integer = DateTime.Today.Year - bdaybox.Value.Year
        Dim num1 As Boolean
        Dim num2 As Boolean
        If DateTime.Today.Month = bdaybox.Value.Month Then
            num1 = True
            If DateTime.Today.Day = bdaybox.Value.Day Then
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
                agebox.Clear()
            Else
                agebox.Text = Str(age)
            End If

        Else
            If age <= 16 Then
                MsgBox("The age in not right", vbInformation)
                agebox.Clear()
            Else
                agebox.Text = Str(age - 1)
            End If
        End If
    End Sub

    'CANCEL BUTTON
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        StudentNumber.Close()
        mainform.Show()
    End Sub
End Class