Public Class Open_account_form

    Private Sub Opening_an_accountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opening_an_accountBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Opening_an_accountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OnlineBankingDataSet)

    End Sub

    Private Sub Open_account_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OnlineBankingDataSet.Opening_an_account' table. You can move, or remove it, as needed.
        Me.Opening_an_accountTableAdapter.Fill(Me.OnlineBankingDataSet.Opening_an_account)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("One row affected")


    End Sub
End Class