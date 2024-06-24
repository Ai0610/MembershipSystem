<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogReportViewer
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.logrecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mbsystemDataSet = New PHASE1.mbsystemDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.logrecordTableAdapter = New PHASE1.mbsystemDataSetTableAdapters.logrecordTableAdapter()
        CType(Me.logrecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mbsystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logrecordBindingSource
        '
        Me.logrecordBindingSource.DataMember = "logrecord"
        Me.logrecordBindingSource.DataSource = Me.mbsystemDataSet
        '
        'mbsystemDataSet
        '
        Me.mbsystemDataSet.DataSetName = "mbsystemDataSet"
        Me.mbsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.logrecordBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PHASE1.logReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(767, 479)
        Me.ReportViewer1.TabIndex = 0
        '
        'logrecordTableAdapter
        '
        Me.logrecordTableAdapter.ClearBeforeFill = True
        '
        'LogReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 479)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LogReportViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogReportViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.logrecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mbsystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents logrecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mbsystemDataSet As PHASE1.mbsystemDataSet
    Friend WithEvents logrecordTableAdapter As PHASE1.mbsystemDataSetTableAdapters.logrecordTableAdapter
End Class
