Public Class Form1

    Private Sub Student_DbBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Student_DbBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Student_DbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDBDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDBDataSet.student_Db' table. You can move, or remove it, as needed.
        Me.Student_DbTableAdapter.Fill(Me.StudentDBDataSet.student_Db)

    End Sub
End Class