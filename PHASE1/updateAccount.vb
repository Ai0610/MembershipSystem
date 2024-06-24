Public Class updateAccount
    
    'FORM LOAD
    Private Sub updateAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        ListView1.Columns.Add("NAME", CInt(ListView1.Width / 2))
        ListView1.Columns.Add("Authority", CInt(ListView1.Width / 2))

        ListView()
    End Sub

    'UPDATE BUTTON
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        If Label6.Text = Nothing Then
            MsgBox("Please Select information to be updated!")
        Else
            If GroupBox1.Enabled = False Then
                GroupBox1.Enabled = True
                DeleteButton.Enabled = False
                CloseButton.Enabled = True

            Else
                Try
                    sqlcondr.Close()
                    sqlcmd.Dispose()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    '===>UPDATING ACCOUNT<==='
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = "update tbl_account set Username= '" & accuser.Text & "',Password= '" & accpass.Text & "',Name= '" & accname.Text & "'," & _
                                                                 "Authority= '" & authoritybox.SelectedItem & "' where Account_ID='" & Label6.Text & "'"
                    sqlcmd.ExecuteNonQuery()
                    MsgBox("RECORD HAS BEEN SUCCESSFULLY UPDATED!", vbOKOnly + vbInformation)

                    sqlcmd.Dispose()

                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try

                GroupBox1.Enabled = False
                DeleteButton.Enabled = True
                CloseButton.Enabled = True
                ListView()
                Label6.Text = ""
                accuser.Clear()
                accpass.Clear()
                accname.Clear()
                authoritybox.Text = ""
            End If
        End If
    End Sub

    'LISTVIEW
    Private Sub ListView1_ItemSelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        Try
            sqlcondr.Close()
            sqlcmd.Dispose()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If

            Label6.Text = e.Item.Text
            '===>SELECTING THE NAME AND SHOWING THE INFO OF ACCOUNT IN A GROUPBOX<==='
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "select * from TBL_account where Name = '" & Label6.Text & "'"

            sqlcondr = sqlcmd.ExecuteReader


            While sqlcondr.Read()
                If sqlcondr.HasRows Then
                    Label6.Text = sqlcondr.Item("Account_ID")
                    accuser.Text = sqlcondr.Item("Username")
                    accpass.Text = sqlcondr.Item("Password")
                    accname.Text = sqlcondr.Item("Name")
                    authoritybox.Text = sqlcondr.Item("Authority")
                End If
            End While
            sqlcondr.Close()
            sqlcmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    'SEARCHBOX
    Private Sub searchbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbox.TextChanged
        Try
            sqlcondr.Close()
            sqlcmd.Dispose()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            '===>SEARCHING NAME<==='
            Dim tmp As String = "select * from tbl_account where name like '%" & searchbox.Text & "%'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader


            ListView1.Items.Clear()


            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = ListView1.Items.Add(sqlcondr("Name"))
                NewItem.SubItems.Add(sqlcondr("Authority"))
            End While

            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    'DELETE BUTTON
    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click

        If Label6.Text = Nothing Then
            MsgBox("Please Select information to be deleted!")

        Else
            Dim confirm = MsgBox("Are you sure you want to delete?", vbYesNo + vbQuestion, "DELETE?")
            If confirm = vbNo Then
                Exit Sub

            Else
                Try
                    sqlcondr.Close()
                    sqlcmd.Dispose()
                    If sqlcon.State = ConnectionState.Closed Then
                        sqlcon.Open()
                    End If
                    '===>DELETING THE ACCOUNT<==='
                    sqlcmd.Connection = sqlcon
                    sqlcmd.CommandText = ("delete from tbl_account where Account_ID like '" & Label6.Text & "' ")

                    sqlcmd.ExecuteNonQuery()
                    sqlcmd.Dispose()

                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try

                Label6.Text = ""
                ListView()
                MsgBox("RECORD HAS BEEN DELETED!", vbOKOnly + vbInformation, "Deleted")
                accuser.Text = ""
                accpass.Text = ""
                accname.Text = ""
                authoritybox.Text = ""
            End If
        End If
    End Sub

    'CLOSE BUTTON
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        mainform.Show()
    End Sub

    Private Sub accname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles accname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Tab) And Not e.KeyChar = Chr(Keys.CapsLock) Then
            e.Handled = True
        End If
    End Sub
End Class