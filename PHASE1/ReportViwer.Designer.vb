<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViwer
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mbsystemDataSet = New PHASE1.mbsystemDataSet()
        Me.infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.infoTableAdapter = New PHASE1.mbsystemDataSetTableAdapters.infoTableAdapter()
        CType(Me.mbsystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.infoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PHASE1.YearReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(711, 427)
        Me.ReportViewer1.TabIndex = 0
        '
        'mbsystemDataSet
        '
        Me.mbsystemDataSet.DataSetName = "mbsystemDataSet"
        Me.mbsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'infoBindingSource
        '
        Me.infoBindingSource.DataMember = "info"
        Me.infoBindingSource.DataSource = Me.mbsystemDataSet
        '
        'infoTableAdapter
        '
        Me.infoTableAdapter.ClearBeforeFill = True
        '
        'ReportViwer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 427)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportViwer"
        Me.Text = "ReportViwer"
        CType(Me.mbsystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents infoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mbsystemDataSet As PHASE1.mbsystemDataSet
    Friend WithEvents infoTableAdapter As PHASE1.mbsystemDataSetTableAdapters.infoTableAdapter
End Class
