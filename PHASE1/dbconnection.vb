Imports MySql.Data.MySqlClient '<===IMPORTING MY SQL DATABASE<===='

Module dbconnection

    Public sqlcon As MySqlConnection = New MySqlConnection
    Public sqlcmd As New MySqlCommand
    Public sqlcondr As MySqlDataReader
    Dim ds As New DataSet
    Dim sqlQuery As String = ""

    '|| ------------------------------------------------------------------------------------------------------------------||'

    'CONNECTION SA DATABASE
    Sub connect()

        sqlcon.ConnectionString = "Server=localhost;Database=mbsystem;Uid=root;Pwd="

    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===ADDING StudentInfo (AddStudentInfo FORM)<===='
    'SAVE THE Student Personal Information
    Public Sub savePersonalInfo()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If

            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO info (Lastname,Firstname,Middlename,Birthdate,YL,Section,Age,Gender,email,Course,SY,StudentNo) VALUES ('" & _
                         StudentAdd.Lnbox.Text.ToUpper & "','" & _
                         StudentAdd.Fnbox.Text.ToUpper & "','" & _
                         StudentAdd.Mnbox.Text.ToUpper & "','" & _
                         StudentAdd.bdaybox.Text & "','" & _
                         StudentAdd.ylbox.SelectedItem & "','" & _
                         StudentAdd.secbox.SelectedItem & "','" & _
                         StudentAdd.agebox.Text & "','" & _
                         StudentAdd.gendercombobox.Text & "','" & _
                         StudentAdd.emailbox.Text & "','" & _
                         StudentAdd.Coursebox.SelectedItem & "','" & _
                         StudentAdd.SYbox.SelectedItem & "','" & _
                         StudentNumber.StudIDbox.Text & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'SAVE THE Student Contact Information
    Public Sub saveContactInfo()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO cntact_tbl (Address, PhoneNumber, ConNumber, ConPerson, ConAddress, stud_id) VALUES ('" & _
                         StudentAdd.addressbox.Text.ToUpper & "','" & _
                         StudentAdd.cnbox.Text & "','" & _
                         StudentAdd.cnumbox.Text & "','" & _
                         StudentAdd.cpersonbox.Text.ToUpper & "','" & _
                         StudentAdd.caddbox.Text.ToUpper & "','" & _
                         StudentNumber.StudIDbox.Text & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===ADDING COURSE(Settings FORM)<===='
    'ADD COURSE
    Public Sub course()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO course (Cname,Ccode) VALUES ('" & _
                         Settings.CourseBox.Text & "','" & _
                         Settings.CodeBox.Text & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===>UPDATE ACCOUNT(updateAccount FORM)<==='
    'UPDATE ACCOUNT LISTVIEW
    Public Sub ListView()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select * from tbl_account"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader


            updateAccount.ListView1.Items.Clear()


            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = updateAccount.ListView1.Items.Add(sqlcondr("Name"))
                NewItem.SubItems.Add(sqlcondr("Authority"))
            End While

            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===>ADDING ACCOUNT(AddAcount FORM)<==='
    'SAVE NEW ACCOUNT
    Public Sub SaveAccount()
        Try
            sqlcon.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO tbl_account(Username,Password,Name,Authority)" & _
            "VALUES('" & AddAccount.adduser.Text & "', '" & AddAccount.addpass.Text & "', '" & AddAccount.addname.Text.ToUpper & "','" & AddAccount.addauthority.Text & "') "


            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        MsgBox("New Record has been Added", vbOKOnly + vbInformation)
        AddAccount.Close()
        mainform.Show()
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===>ADDING MEMBERSHIP FEE(payment FORM)<==='
    'FIRST SEMESTER
    Public Sub FirstSem()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO 1stsemster (Ccode,YearLevelOne,SchoolYearOne,Payment,ExpiredDate,stud_id,STATUS) VALUES ('" & _
                         StudentAdd.Coursebox.SelectedItem & "','" & _
                         StudentAdd.ylbox.SelectedItem & "','" & _
                         StudentAdd.SYbox.SelectedItem & "','" & _
                         Payment.paymentbox.Text & "','" & _
                         Payment.exp & "','" & _
                         StudentAdd.Label15.Text & "','" & _
                           Payment.stat & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'SECOND SEMESTER
    Public Sub SecondSem()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO 2ndsemester (course, YearLevelTwo, SchoolYearTwo,SecondPayment,expiredDate,stud_id, SecondSTATUS) VALUES ('" & _
                         StudentAdd.Coursebox.SelectedItem & "','" & _
                         StudentAdd.ylbox.SelectedItem & "','" & _
                         StudentAdd.SYbox.SelectedItem & "','" & _
                         Payment.paymentbox.Text & "','" & _
                         Payment.exp & "','" & _
                         StudentAdd.Label15.Text & "','" & _
                         Payment.stat & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '====>UPDATE FORM ADMIN TO(UpdateStudentAdmin FORM)<===='
    'UPDATE FIRST SEMESTER ADMIN
    Public Sub UpdateSemOneAdmin()

        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If

            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO 1stsemster (Ccode,YearLevelOne,SchoolYearOne,Payment,ExpiredDate,stud_id,STATUS) VALUES ('" & _
                         UpdateStudentAdmin.course.SelectedItem & "','" & _
                         UpdateStudentAdmin.ylbox.SelectedItem & "','" & _
                         UpdateStudentAdmin.SYbox.SelectedItem & "','" & _
                         UpdatePayment.paymentbox.Text & "','" & _
                         UpdatePayment.exp & "','" & _
                         UpdateStudentAdmin.studbox.Text & "','" & _
                           Payment.stat & "')"
            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub
    'UPDATE SECOND SEMESTER ADMIN
    Public Sub UpdateSemTwoAdmin()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If

            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO 2ndsemester (course, YearLevelTwo, SchoolYearTwo,SecondPayment,expiredDate,stud_id, SecondSTATUS) VALUES ('" & _
                         UpdateStudentAdmin.course.SelectedItem & "','" & _
                         UpdateStudentAdmin.ylbox.SelectedItem & "','" & _
                         UpdateStudentAdmin.SYbox.SelectedItem & "','" & _
                         UpdatePayment.paymentbox.Text & "','" & _
                         UpdatePayment.exp & "','" & _
                         UpdateStudentAdmin.studbox.Text & "','" & _
                           Payment.stat & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    'UPDATE STUDENT RECORD VIEW ADMIN
    Public Sub StudListViewAdmin()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select * from info"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader


            UpdateStudentAdmin.ListView1.Items.Clear()


            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = UpdateStudentAdmin.ListView1.Items.Add(sqlcondr("StudentNo"))
                NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                NewItem.SubItems.Add(sqlcondr("Course"))
                NewItem.SubItems.Add(sqlcondr("YL"))
            End While

            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===>UPDATE FORM USER TO(UpdateFormUser FORM)<==='
    'UPDATE SECOND SEMESTER USER
    Public Sub UpdateSemTwoUser()
        Try
            sqlcmd.Dispose()
            sqlcon.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO 2ndsemester (course, YearLevelTwo, SchoolYearTwo,SecondPayment,expiredDate,stud_id, SecondSTATUS) VALUES ('" & _
                         UpdateFormUser.cobox.Text & "','" & _
                         UpdateFormUser.ylbox.SelectedItem & "','" & _
                         UpdateFormUser.SYbox.SelectedItem & "','" & _
                         UpdatePayment.paymentbox.Text & "','" & _
                         UpdatePayment.exp & "','" & _
                         UpdateFormUser.studbox.Text & "','" & _
                           UpdatePayment.stat & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    'UPDATE FIRST SEMESTER USER
    Public Sub UpdateSemOneUser()
        Try
            sqlcmd.Dispose()
            sqlcon.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO 1stsemster (Ccode,YearLevelOne,SchoolYearOne,Payment,ExpiredDate,stud_id,STATUS) VALUES ('" & _
                         UpdateFormUser.cobox.Text & "','" & _
                         UpdateFormUser.ylbox.SelectedItem & "','" & _
                         UpdateFormUser.SYbox.SelectedItem & "','" & _
                         UpdatePayment.paymentbox.Text & "','" & _
                         UpdatePayment.exp & "','" & _
                         UpdateFormUser.studbox.Text & "','" & _
                           Payment.stat & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    'UPDATE STUDENT RECORD VIEW user
    Public Sub StudListViewUser()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select * from info"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader


            UpdateFormUser.ListView1.Items.Clear()


            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = UpdateFormUser.ListView1.Items.Add(sqlcondr("StudentNo"))
                NewItem.SubItems.Add(sqlcondr("Lastname") + " " + sqlcondr("Firstname") + " " + sqlcondr("Middlename"))
                NewItem.SubItems.Add(sqlcondr("Course"))
                NewItem.SubItems.Add(sqlcondr("YL"))
            End While

            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===>ADDING THE EXPIRED DATE(Settings FORM)<===='
    'EXPIRED DATE
    Public Sub ExpireDate()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO expiration (semester, SchoolYear, expiredDate) VALUES ('" & _
                         Settings.sembox.Text & "','" & _
                         Settings.SYbox.Text & "','" & _
                         Settings.DateTimePicker1.Value.Date & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===> ADDING LOG RECORD(DATABASE TO) <==='
    'LOG RECORD IN
    Public Sub logIn()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO logrecord (Name, DateLog, TimeLog,Status) VALUES ('" & _
                         Form1.userbox.Text.ToUpper & "','" & _
                         FormatDateTime(Now, vbLongDate) & "','" & _
                         Format(Now, "h:mm tt") & "','" & _
                         Form1.LoginButton.Text.ToUpper & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    'LOG RECORD OUT
    Public Sub logOut()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            sqlcmd.Connection = sqlcon
            sqlcmd.CommandText = "INSERT INTO logrecord (Name, DateLog, TimeLog,Status) VALUES ('" & _
                         Form1.userbox.Text.ToUpper & "','" & _
                         FormatDateTime(Now, vbLongDate) & "','" & _
                         Format(Now, "h:mm tt") & "','" & _
                         mainform.ToolStripStatusLabel5.Text.ToUpper & "')"

            sqlcmd.ExecuteNonQuery()

            sqlcmd.Dispose()
            sqlcon.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===SHOWING LOG RECORD(LogRecordForm FORM)<==='
    'LOG VIEW FORM
    Public Sub LogView()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select * from logrecord ORDER BY l_id DESC"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader


            updateAccount.ListView1.Items.Clear()


            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = LogRecodForm.ListView1.Items.Add(sqlcondr("l_id"))
                NewItem.SubItems.Add(sqlcondr("Name"))
                NewItem.SubItems.Add(sqlcondr("DateLog"))
                NewItem.SubItems.Add(sqlcondr("TimeLog"))
                NewItem.SubItems.Add(sqlcondr("Status"))
            End While

            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

    '===> MEMBERSHIP FORM <==='
    '2ndSemView
    Public Sub SemTwoView()

        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If

            Dim temp As String = "select * from 2ndSemester where Stud_id like '%" & View_Student.Label2.Text & "%'"
            sqlcmd.CommandText = temp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = Membership.ListView2.Items.Add(sqlcondr("YearLevelTwo"))
                NewItem.SubItems.Add(sqlcondr("SchoolYearTwo"))
                NewItem.SubItems.Add(sqlcondr("SecondPayment"))
                NewItem.SubItems.Add(sqlcondr("SecondSTATUS"))
            End While
            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    '1stSemView
    Public Sub SemOneView()
        Try
            sqlcmd.Dispose()
            sqlcondr.Close()
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If
            Dim tmp As String = "select * from 1stSemster where Stud_id like '%" & View_Student.Label2.Text & "%'"
            sqlcmd.CommandText = tmp
            sqlcmd.Connection = sqlcon

            sqlcondr = sqlcmd.ExecuteReader

            While (sqlcondr.Read())
                Dim NewItem As ListViewItem
                NewItem = Membership.ListView1.Items.Add(sqlcondr("YearLevelOne"))
                NewItem.SubItems.Add(sqlcondr("SchoolYearOne"))
                NewItem.SubItems.Add(sqlcondr("Payment"))
                NewItem.SubItems.Add(sqlcondr("STATUS"))
            End While

            sqlcmd.Dispose()
            sqlcondr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub

    '|| ------------------------------------------------------------------------------------------------------------------||'

End Module
