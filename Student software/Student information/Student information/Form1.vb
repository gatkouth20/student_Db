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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BindingNavigatorDeleteItem.PerformClick()
        MsgBox("data deleted")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Student_DbBindingNavigatorSaveItem.PerformClick()
        MsgBox("New data saved")

    End Sub

    Private Sub Student_DbBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Student_DbBindingNavigator.RefreshItems

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Report.Show()


    End Sub
End Class
