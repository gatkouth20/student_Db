Public Class for_official

    Private Sub Official_Use_onlyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Official_Use_onlyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Official_Use_onlyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Banking_managmentDataSet)

    End Sub

    Private Sub for_official_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Banking_managmentDataSet.Official_Use_only' table. You can move, or remove it, as needed.
        Me.Official_Use_onlyTableAdapter.Fill(Me.Banking_managmentDataSet.Official_Use_only)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("Data Added successfully")


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BindingNavigatorDeleteItem.PerformClick()
        MsgBox("data successfully Deleted")


    End Sub
End Class