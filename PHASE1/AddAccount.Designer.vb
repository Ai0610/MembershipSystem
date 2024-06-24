<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAccount
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
        Me.AddButton = New System.Windows.Forms.Button()
        Me.addauthority = New System.Windows.Forms.ComboBox()
        Me.addpass = New System.Windows.Forms.TextBox()
        Me.adduser = New System.Windows.Forms.TextBox()
        Me.addname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.repassbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddButton.Location = New System.Drawing.Point(55, 330)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(90, 33)
        Me.AddButton.TabIndex = 5
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'addauthority
        '
        Me.addauthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.addauthority.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addauthority.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addauthority.Items.AddRange(New Object() {"Officer", "Student"})
        Me.addauthority.Location = New System.Drawing.Point(36, 279)
        Me.addauthority.Name = "addauthority"
        Me.addauthority.Size = New System.Drawing.Size(257, 26)
        Me.addauthority.TabIndex = 5
        '
        'addpass
        '
        Me.addpass.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addpass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addpass.Location = New System.Drawing.Point(36, 161)
        Me.addpass.Multiline = True
        Me.addpass.Name = "addpass"
        Me.addpass.Size = New System.Drawing.Size(257, 33)
        Me.addpass.TabIndex = 3
        '
        'adduser
        '
        Me.adduser.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adduser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.adduser.Location = New System.Drawing.Point(36, 101)
        Me.adduser.Multiline = True
        Me.adduser.Name = "adduser"
        Me.adduser.Size = New System.Drawing.Size(257, 33)
        Me.adduser.TabIndex = 2
        '
        'addname
        '
        Me.addname.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addname.Location = New System.Drawing.Point(36, 43)
        Me.addname.Multiline = True
        Me.addname.Name = "addname"
        Me.addname.Size = New System.Drawing.Size(257, 33)
        Me.addname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(32, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(32, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(35, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Authority:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(32, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Password:"
        '
        'repassbox
        '
        Me.repassbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repassbox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.repassbox.Location = New System.Drawing.Point(36, 221)
        Me.repassbox.Multiline = True
        Me.repassbox.Name = "repassbox"
        Me.repassbox.Size = New System.Drawing.Size(257, 33)
        Me.repassbox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(32, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Re-enter Password:"
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CloseButton.Location = New System.Drawing.Point(173, 325)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(95, 38)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "CLOSE"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'AddAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(331, 375)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.repassbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.addauthority)
        Me.Controls.Add(Me.addpass)
        Me.Controls.Add(Me.adduser)
        Me.Controls.Add(Me.addname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "AddAccount"
        Me.Text = "ACCOUNT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents addauthority As System.Windows.Forms.ComboBox
    Friend WithEvents addpass As System.Windows.Forms.TextBox
    Friend WithEvents adduser As System.Windows.Forms.TextBox
    Friend WithEvents addname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents repassbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
