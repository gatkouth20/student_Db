Public Class CheckBook

    Private Sub CheckBookDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBookDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CheckBookDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlineBankingDataSet)

    End Sub

    Private Sub CheckBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OnlineBankingDataSet.CheckBookDetails' table. You can move, or remove it, as needed.
        Me.CheckBookDetailsTableAdapter.Fill(Me.OnlineBankingDataSet.CheckBookDetails)

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
        MsgBox("data deleted")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("Data successfully added")
    End Sub
End Class