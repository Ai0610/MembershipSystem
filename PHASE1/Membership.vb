Public Class Membership
    Public value As String
    Public status As String
    Public dates As Date

    Private Sub Membership_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If
        For Each item As ListViewItem In ListView1.Items
            ListView1.Columns.Add("Year Level", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
            ListView1.Columns.Add("School Year", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
            ListView1.Columns.Add("Payment", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
            ListView1.Columns.Add("Status", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        Next
        ListView2.Columns.Add("Year Level", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView2.Columns.Add("School Year", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView2.Columns.Add("Payment", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)
        ListView2.Columns.Add("Status", CInt(ListView1.Width / 5.2), HorizontalAlignment.Center)



        If sqlcon.State = ConnectionState.Closed Then
            sqlcon.Open()
        End If

        status = "EXPIRED"

        Dim temp As String = "select * from 1stSemster where Stud_id like '%" & View_Student.Label2.Text & "%'"
        sqlcmd.CommandText = temp
        sqlcmd.Connection = sqlcon

        sqlcondr = sqlcmd.ExecuteReader

        While (sqlcondr.Read())
            dates = sqlcondr("expiredDate")
        End While
        sqlcmd.Dispose()
        sqlcondr.Close()


        If dates <= DateTime.Now Then


            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "update 1stSemster set STATUS= '" & status & "' where expiredDate='" & dates & "'"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcondr.Close()

        Else

        End If


        Dim tmp As String = "select * from 2ndsemester where Stud_id like '%" & View_Student.Label2.Text & "%'"
        sqlcmd.CommandText = tmp
        sqlcmd.Connection = sqlcon

        sqlcondr = sqlcmd.ExecuteReader

        While (sqlcondr.Read())
            dates = sqlcondr("expiredDate")
        End While
        sqlcmd.Dispose()
        sqlcondr.Close()

        If dates <= DateTime.Now Then

            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "update 2ndSemester set SecondSTATUS= '" & status & "' where expiredDate='" & dates & "'"
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcondr.Close()

        Else

        End If

        SemOneView()
        SemTwoView()
    End Sub

End Class