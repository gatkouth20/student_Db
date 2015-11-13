Public Class Deposit_View

    Private Sub Deposite_informationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deposite_informationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Deposite_informationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Banking_managmentDataSet)

    End Sub

    Private Sub Deposit_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Banking_managmentDataSet.Deposite_information' table. You can move, or remove it, as needed.
        Me.Deposite_informationTableAdapter.Fill(Me.Banking_managmentDataSet.Deposite_information)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Deposit_form.Show()
        Me.Hide()


    End Sub
End Class