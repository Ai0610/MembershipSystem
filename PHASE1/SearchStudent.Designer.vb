<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchStudent
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.searchstudbox = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.InfoBox = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(69, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Search by:"
        '
        'searchstudbox
        '
        Me.searchstudbox.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchstudbox.Location = New System.Drawing.Point(246, 61)
        Me.searchstudbox.Multiline = True
        Me.searchstudbox.Name = "searchstudbox"
        Me.searchstudbox.Size = New System.Drawing.Size(233, 32)
        Me.searchstudbox.TabIndex = 20
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Lucida Fax", 9.75!)
        Me.ListView1.Location = New System.Drawing.Point(1, 130)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(691, 335)
        Me.ListView1.TabIndex = 19
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'InfoBox
        '
        Me.InfoBox.BackColor = System.Drawing.SystemColors.Window
        Me.InfoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InfoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.InfoBox.FormattingEnabled = True
        Me.InfoBox.Items.AddRange(New Object() {"Course", "Student Number", "Year Level", "School Year"})
        Me.InfoBox.Location = New System.Drawing.Point(72, 66)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(141, 28)
        Me.InfoBox.TabIndex = 26
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(510, 59)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 34)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "SEARCH"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'SearchStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(694, 465)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.searchstudbox)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "SearchStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEARCH STUDENT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents searchstudbox As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents InfoBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
