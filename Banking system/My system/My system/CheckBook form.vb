Public Class CheckBook_form

    Private Sub Check_Book_detailBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Book_detailBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Check_Book_detailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Banking_managmentDataSet)

    End Sub

    Private Sub CheckBook_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Banking_managmentDataSet.Check_Book_detail' table. You can move, or remove it, as needed.
        Me.Check_Book_detailTableAdapter.Fill(Me.Banking_managmentDataSet.Check_Book_detail)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BindingNavigatorDeleteItem.PerformClick()
        MsgBox("One Row deleted")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("New Item added")

    End Sub
End Class