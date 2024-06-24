Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Form1
    'LOGIN BUTTON
    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        Dim StrQuery As String = ""
        Dim Myadapter As New MySqlDataAdapter

        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If

        'QUERYING
        StrQuery = "Select * from tbl_account WHERE Username='" + userbox.Text + "' And Password='" + passbox.Text + "'"

        'COMMAND
        sqlcmd.Connection = sqlcon
        sqlcmd.CommandText = StrQuery
        Myadapter.SelectCommand = sqlcmd

        sqlcondr = sqlcmd.ExecuteReader

        If (sqlcondr.Read()) Then
            If sqlcondr("Authority") = "Admin" Then

                MsgBox("Welcome admin")
                Me.Hide()
                dbconnection.logIn()
                mainform.Show()
            ElseIf sqlcondr("Authority") = "Officer" Then
                MsgBox("Welcome User")
                mainform.ToolStripSplitButton1.Enabled = False
                mainform.PictureBox4.Enabled = False
                Me.Hide()
                dbconnection.logIn()
                mainform.Show()
            Else
                MsgBox("Welcome User")
                mainform.ToolStripSplitButton1.Enabled = False
                mainform.PictureBox1.Enabled = False
                mainform.PictureBox2.Enabled = False
                mainform.PictureBox3.Enabled = False
                mainform.PictureBox4.Enabled = False
                Me.Hide()
                dbconnection.logIn()
                mainform.Show()
            End If
        Else
            If userbox.Text = "" And passbox.Text = "" Then
                MsgBox("Please fill up the Username and Password")
                userbox.Focus()
            ElseIf userbox.Text = "" Then
                MsgBox("Please fill up Username")
                userbox.Focus()
            ElseIf passbox.Text = "" Then
                MsgBox("Please fill up Password")
                passbox.Focus()
            Else
                MsgBox("Invalid Username or password")
                userbox.Text = ""
                passbox.Text = ""
                userbox.Focus()
            End If
        End If
        sqlcondr.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnection.connect()
        ToolStripStatusLabel1.Text = FormatDateTime(Now, vbLongDate)
        ToolStripStatusLabel3.Text = Format(Now, "h:mm tt")
    End Sub

    Private Sub CanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanButton.Click
        Me.Close()
    End Sub

    Private Sub passbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles passbox.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            LoginButton.PerformClick()
        End If
    End Sub
End Class
