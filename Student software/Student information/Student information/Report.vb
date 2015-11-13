Public Class Report

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'studentDBDataSet.student_Db' table. You can move, or remove it, as needed.
        Me.student_DbTableAdapter.Fill(Me.studentDBDataSet.student_Db)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class