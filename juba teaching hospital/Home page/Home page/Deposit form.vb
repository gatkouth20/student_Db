Public Class Deposit_form

    Private Sub Deposited_formBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deposited_formBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Deposited_formBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlineBankingDataSet)

    End Sub

    Private Sub Deposit_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OnlineBankingDataSet.Deposited_form' table. You can move, or remove it, as needed.
        Me.Deposited_formTableAdapter.Fill(Me.OnlineBankingDataSet.Deposited_form)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BindingNavigatorDeleteItem.PerformClick()
        MsgBox("Data successfully deleted")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("Data successfully added")
    End Sub
End Class