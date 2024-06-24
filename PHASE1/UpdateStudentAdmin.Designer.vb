<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStudentAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cnum = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.TextBox()
        Me.SYbox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.secbox = New System.Windows.Forms.ComboBox()
        Me.deletebutton = New System.Windows.Forms.Button()
        Me.ylbox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.InfoBox = New System.Windows.Forms.ComboBox()
        Me.caddbox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cpersonbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.course = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cnbox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.agebox = New System.Windows.Forms.TextBox()
        Me.studbox = New System.Windows.Forms.Label()
        Me.bd = New System.Windows.Forms.DateTimePicker()
        Me.gen = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mn = New System.Windows.Forms.TextBox()
        Me.Addbox = New System.Windows.Forms.TextBox()
        Me.ln = New System.Windows.Forms.TextBox()
        Me.emailbox = New System.Windows.Forms.TextBox()
        Me.fn = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cnum
        '
        Me.cnum.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnum.Location = New System.Drawing.Point(8, 367)
        Me.cnum.Name = "cnum"
        Me.cnum.Size = New System.Drawing.Size(266, 26)
        Me.cnum.TabIndex = 56
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(800, 38)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(229, 26)
        Me.search.TabIndex = 26
        '
        'SYbox
        '
        Me.SYbox.BackColor = System.Drawing.SystemColors.Window
        Me.SYbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SYbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYbox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.SYbox.FormattingEnabled = True
        Me.SYbox.Items.AddRange(New Object() {"2015-2016", "2016-2017"})
        Me.SYbox.Location = New System.Drawing.Point(414, 472)
        Me.SYbox.Name = "SYbox"
        Me.SYbox.Size = New System.Drawing.Size(182, 26)
        Me.SYbox.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "School Year:"
        '
        'closebutton
        '
        Me.closebutton.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebutton.Location = New System.Drawing.Point(1025, 484)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(94, 46)
        Me.closebutton.TabIndex = 32
        Me.closebutton.Text = "CLOSE"
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'secbox
        '
        Me.secbox.BackColor = System.Drawing.SystemColors.Window
        Me.secbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.secbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secbox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.secbox.FormattingEnabled = True
        Me.secbox.Items.AddRange(New Object() {"A", "B", "NONE"})
        Me.secbox.Location = New System.Drawing.Point(414, 429)
        Me.secbox.Name = "secbox"
        Me.secbox.Size = New System.Drawing.Size(182, 26)
        Me.secbox.TabIndex = 48
        '
        'deletebutton
        '
        Me.deletebutton.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebutton.Location = New System.Drawing.Point(930, 484)
        Me.deletebutton.Name = "deletebutton"
        Me.deletebutton.Size = New System.Drawing.Size(89, 46)
        Me.deletebutton.TabIndex = 30
        Me.deletebutton.Text = "DELETE"
        Me.deletebutton.UseVisualStyleBackColor = True
        '
        'ylbox
        '
        Me.ylbox.BackColor = System.Drawing.SystemColors.Window
        Me.ylbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ylbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ylbox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ylbox.FormattingEnabled = True
        Me.ylbox.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.ylbox.Location = New System.Drawing.Point(412, 381)
        Me.ylbox.Name = "ylbox"
        Me.ylbox.Size = New System.Drawing.Size(182, 26)
        Me.ylbox.TabIndex = 47
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(312, 432)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Section:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(310, 384)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 18)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Year Level:"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(650, 484)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 46)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "MEMBERSHIP FEE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'InfoBox
        '
        Me.InfoBox.BackColor = System.Drawing.SystemColors.Window
        Me.InfoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InfoBox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.InfoBox.FormattingEnabled = True
        Me.InfoBox.Items.AddRange(New Object() {"Course", "Student Number", "Year Level", "School Year"})
        Me.InfoBox.Location = New System.Drawing.Point(650, 38)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(141, 26)
        Me.InfoBox.TabIndex = 34
        '
        'caddbox
        '
        Me.caddbox.BackColor = System.Drawing.SystemColors.Window
        Me.caddbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caddbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.caddbox.Location = New System.Drawing.Point(7, 484)
        Me.caddbox.Name = "caddbox"
        Me.caddbox.Size = New System.Drawing.Size(267, 26)
        Me.caddbox.TabIndex = 38
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(831, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 46)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cpersonbox
        '
        Me.cpersonbox.BackColor = System.Drawing.SystemColors.Window
        Me.cpersonbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpersonbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cpersonbox.Location = New System.Drawing.Point(7, 420)
        Me.cpersonbox.Name = "cpersonbox"
        Me.cpersonbox.Size = New System.Drawing.Size(267, 26)
        Me.cpersonbox.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.course)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.cnbox)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.agebox)
        Me.GroupBox1.Controls.Add(Me.cnum)
        Me.GroupBox1.Controls.Add(Me.studbox)
        Me.GroupBox1.Controls.Add(Me.bd)
        Me.GroupBox1.Controls.Add(Me.SYbox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.gen)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.secbox)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.ylbox)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.caddbox)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.cpersonbox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mn)
        Me.GroupBox1.Controls.Add(Me.Addbox)
        Me.GroupBox1.Controls.Add(Me.ln)
        Me.GroupBox1.Controls.Add(Me.emailbox)
        Me.GroupBox1.Controls.Add(Me.fn)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 519)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PERSONAL INFORMATION"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 321)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(214, 18)
        Me.Label21.TabIndex = 79
        Me.Label21.Text = "IN CASE OF EMERGENCY"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(328, 321)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(212, 18)
        Me.Label23.TabIndex = 78
        Me.Label23.Text = "SCHOOL INFORMATION"
        '
        'course
        '
        Me.course.BackColor = System.Drawing.SystemColors.Window
        Me.course.DisplayMember = "comsci()"
        Me.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.course.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course.ForeColor = System.Drawing.SystemColors.InfoText
        Me.course.FormattingEnabled = True
        Me.course.Location = New System.Drawing.Point(414, 342)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(183, 26)
        Me.course.TabIndex = 76
        Me.course.ValueMember = "comsci()"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(313, 345)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 18)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "Course:"
        '
        'cnbox
        '
        Me.cnbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnbox.Location = New System.Drawing.Point(179, 255)
        Me.cnbox.Name = "cnbox"
        Me.cnbox.Size = New System.Drawing.Size(307, 26)
        Me.cnbox.TabIndex = 73
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(131, 169)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(251, 20)
        Me.Label18.TabIndex = 72
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 255)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 18)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Contact Number:"
        '
        'agebox
        '
        Me.agebox.Enabled = False
        Me.agebox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agebox.Location = New System.Drawing.Point(221, 122)
        Me.agebox.Name = "agebox"
        Me.agebox.Size = New System.Drawing.Size(176, 26)
        Me.agebox.TabIndex = 70
        Me.agebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'studbox
        '
        Me.studbox.AutoSize = True
        Me.studbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studbox.Location = New System.Drawing.Point(168, 23)
        Me.studbox.Name = "studbox"
        Me.studbox.Size = New System.Drawing.Size(2, 20)
        Me.studbox.TabIndex = 69
        '
        'bd
        '
        Me.bd.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bd.Location = New System.Drawing.Point(12, 124)
        Me.bd.Name = "bd"
        Me.bd.Size = New System.Drawing.Size(194, 26)
        Me.bd.TabIndex = 67
        '
        'gen
        '
        Me.gen.BackColor = System.Drawing.SystemColors.Window
        Me.gen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gen.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gen.ForeColor = System.Drawing.SystemColors.InfoText
        Me.gen.FormattingEnabled = True
        Me.gen.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.gen.Location = New System.Drawing.Point(419, 124)
        Me.gen.Name = "gen"
        Me.gen.Size = New System.Drawing.Size(178, 26)
        Me.gen.TabIndex = 60
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(8, 21)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(146, 18)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Student Number:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(217, 100)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(43, 18)
        Me.Label36.TabIndex = 66
        Me.Label36.Text = "Age:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(415, 102)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 18)
        Me.Label38.TabIndex = 65
        Me.Label38.Text = "Gender:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(8, 102)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(87, 18)
        Me.Label39.TabIndex = 64
        Me.Label39.Text = "Birthdate:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 462)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 18)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Contact Address:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(415, 47)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(119, 18)
        Me.Label40.TabIndex = 63
        Me.Label40.Text = "Middle Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 395)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 18)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Contact Person:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 339)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 18)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Contact Number:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(217, 47)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(99, 18)
        Me.Label41.TabIndex = 62
        Me.Label41.Text = "First Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 194)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 18)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Email:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(12, 47)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(96, 18)
        Me.Label42.TabIndex = 61
        Me.Label42.Text = "Last Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Address:"
        '
        'mn
        '
        Me.mn.BackColor = System.Drawing.SystemColors.Window
        Me.mn.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mn.Location = New System.Drawing.Point(419, 70)
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(178, 26)
        Me.mn.TabIndex = 59
        '
        'Addbox
        '
        Me.Addbox.BackColor = System.Drawing.SystemColors.Window
        Me.Addbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Addbox.Location = New System.Drawing.Point(110, 225)
        Me.Addbox.Name = "Addbox"
        Me.Addbox.Size = New System.Drawing.Size(376, 26)
        Me.Addbox.TabIndex = 11
        '
        'ln
        '
        Me.ln.BackColor = System.Drawing.SystemColors.Window
        Me.ln.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ln.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ln.Location = New System.Drawing.Point(16, 69)
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(190, 26)
        Me.ln.TabIndex = 57
        '
        'emailbox
        '
        Me.emailbox.BackColor = System.Drawing.SystemColors.Window
        Me.emailbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.emailbox.Location = New System.Drawing.Point(110, 192)
        Me.emailbox.Name = "emailbox"
        Me.emailbox.Size = New System.Drawing.Size(376, 26)
        Me.emailbox.TabIndex = 10
        '
        'fn
        '
        Me.fn.BackColor = System.Drawing.SystemColors.Window
        Me.fn.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fn.Location = New System.Drawing.Point(221, 70)
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(176, 26)
        Me.fn.TabIndex = 58
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(650, 78)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(485, 395)
        Me.ListView1.TabIndex = 28
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(646, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Search by:"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1035, 33)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 34)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "SEARCH"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'UpdateStudentAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1147, 543)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.closebutton)
        Me.Controls.Add(Me.deletebutton)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Name = "UpdateStudentAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateStudentAdmin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cnum As System.Windows.Forms.TextBox
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents SYbox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents closebutton As System.Windows.Forms.Button
    Friend WithEvents secbox As System.Windows.Forms.ComboBox
    Friend WithEvents deletebutton As System.Windows.Forms.Button
    Friend WithEvents ylbox As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents InfoBox As System.Windows.Forms.ComboBox
    Friend WithEvents caddbox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cpersonbox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Addbox As System.Windows.Forms.TextBox
    Friend WithEvents emailbox As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cnbox As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents agebox As System.Windows.Forms.TextBox
    Friend WithEvents studbox As System.Windows.Forms.Label
    Friend WithEvents bd As System.Windows.Forms.DateTimePicker
    Friend WithEvents gen As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents mn As System.Windows.Forms.TextBox
    Friend WithEvents ln As System.Windows.Forms.TextBox
    Friend WithEvents fn As System.Windows.Forms.TextBox
    Friend WithEvents course As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
