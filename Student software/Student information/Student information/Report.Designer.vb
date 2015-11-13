<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.student_DbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.studentDBDataSet = New Student_information.studentDBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.student_DbTableAdapter = New Student_information.studentDBDataSetTableAdapters.student_DbTableAdapter()
        CType(Me.student_DbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'student_DbBindingSource
        '
        Me.student_DbBindingSource.DataMember = "student Db"
        Me.student_DbBindingSource.DataSource = Me.studentDBDataSet
        '
        'studentDBDataSet
        '
        Me.studentDBDataSet.DataSetName = "studentDBDataSet"
        Me.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.student_DbBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Student_information.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(758, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'student_DbTableAdapter
        '
        Me.student_DbTableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 347)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.student_DbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents student_DbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents studentDBDataSet As Student_information.studentDBDataSet
    Friend WithEvents student_DbTableAdapter As Student_information.studentDBDataSetTableAdapters.student_DbTableAdapter
End Class
