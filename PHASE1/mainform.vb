Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class mainform

    Private Sub mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sqlcmd.Dispose()
        sqlcondr.Close()

        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If

        Dim tmp As String = "SELECT * FROM tbl_account WHERE Username LIKE '" & (Form1.userbox.Text) & "%'"
        sqlcmd.CommandText = tmp
        sqlcmd.Connection = sqlcon
        sqlcondr = sqlcmd.ExecuteReader
        While (sqlcondr.Read())
            ToolStripStatusLabel1.Text = sqlcondr("Name")


        End While

        sqlcmd.Dispose()
        sqlcondr.Close()



    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        StudentNumber.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim StrQuery As String = ""
        Dim Myadapter As New MySqlDataAdapter

        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If
        StrQuery = "Select * from tbl_account WHERE Name='" & ToolStripStatusLabel1.Text & "' "

        'COMMAND
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = StrQuery
        Myadapter.SelectCommand = sqlcmd

        sqlcondr = sqlcmd.ExecuteReader

        If (sqlcondr.Read()) Then
            If sqlcondr("Authority") = "Admin" Then
                UpdateStudentAdmin.Show()
            ElseIf sqlcondr("Authority") = "Officer" Then
               UpdateFormUser.Show()
            End If
        End If
        sqlcmd.Dispose()
        sqlcondr.Close()

    End Sub

    Private Sub ToolStripStatusLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel5.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            dbconnection.logOut()
            Form1.Show()
            Form1.userbox.Clear()
            Form1.passbox.Clear()
            Form1.userbox.Focus()

        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        AddAccount.Show()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        updateAccount.Show()
    End Sub

    Private Sub LogRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogRecordToolStripMenuItem.Click
        LogRecodForm.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Settings.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        SearchStudent.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        MainReport.Show()
    End Sub

    Private Sub AlumniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumniToolStripMenuItem.Click
        AlumniForm.Show()
    End Sub

    Private Sub StSemesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StSemesterToolStripMenuItem.Click
        module2.loadOne()

    End Sub

    Private Sub NdSemesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NdSemesterToolStripMenuItem.Click
        module2.loadTwo()
    End Sub
End Class