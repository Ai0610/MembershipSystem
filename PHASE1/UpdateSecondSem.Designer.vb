<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateSecondSem
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
        Me.search = New System.Windows.Forms.Button()
        Me.searchbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(378, 45)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(95, 34)
        Me.search.TabIndex = 46
        Me.search.Text = "SEARCH"
        Me.search.UseVisualStyleBackColor = True
        '
        'searchbox
        '
        Me.searchbox.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbox.Location = New System.Drawing.Point(189, 51)
        Me.searchbox.Mask = "0000-0000"
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(167, 25)
        Me.searchbox.TabIndex = 45
        Me.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label33.Location = New System.Drawing.Point(22, 58)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(134, 18)
        Me.Label33.TabIndex = 44
        Me.Label33.Text = "2nd SEMESTER"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Lucida Fax", 9.75!)
        Me.ListView1.Location = New System.Drawing.Point(26, 82)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(569, 186)
        Me.ListView1.TabIndex = 43
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(186, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 18)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Input School Year:"
        '
        'UpdateSecondSem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(616, 310)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.searchbox)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "UpdateSecondSem"
        Me.Text = "UpdateSecondSem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents searchbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
