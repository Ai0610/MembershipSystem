<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainReport
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.InfoBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.paymentbox = New System.Windows.Forms.MaskedTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 68)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(769, 307)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(527, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 41)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "SEARCH"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'InfoBox
        '
        Me.InfoBox.BackColor = System.Drawing.SystemColors.Window
        Me.InfoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InfoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.InfoBox.FormattingEnabled = True
        Me.InfoBox.Items.AddRange(New Object() {"School Year", "Semester"})
        Me.InfoBox.Location = New System.Drawing.Point(12, 28)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(141, 28)
        Me.InfoBox.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(9, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Search by:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.ComboBox1.Location = New System.Drawing.Point(176, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 28)
        Me.ComboBox1.TabIndex = 33
        '
        'paymentbox
        '
        Me.paymentbox.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentbox.Location = New System.Drawing.Point(176, 27)
        Me.paymentbox.Mask = "0000-0000"
        Me.paymentbox.Name = "paymentbox"
        Me.paymentbox.Size = New System.Drawing.Size(167, 25)
        Me.paymentbox.TabIndex = 34
        Me.paymentbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(637, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 41)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusBox
        '
        Me.StatusBox.BackColor = System.Drawing.SystemColors.Window
        Me.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.StatusBox.FormattingEnabled = True
        Me.StatusBox.Items.AddRange(New Object() {"REGISTERED", "NOT REGISTERED", "EXPIRED"})
        Me.StatusBox.Location = New System.Drawing.Point(349, 25)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.Size = New System.Drawing.Size(141, 28)
        Me.StatusBox.TabIndex = 36
        '
        'MainReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(793, 384)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.paymentbox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "MainReport"
        Me.Text = "MainReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents InfoBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents paymentbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StatusBox As System.Windows.Forms.ComboBox
End Class
