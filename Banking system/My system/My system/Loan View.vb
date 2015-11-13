Public Class Loan_View

    Private Sub Loan_informationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loan_informationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Loan_informationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Banking_managmentDataSet)

    End Sub

    Private Sub Loan_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Banking_managmentDataSet.Loan_information' table. You can move, or remove it, as needed.
        Me.Loan_informationTableAdapter.Fill(Me.Banking_managmentDataSet.Loan_information)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Loan_form.Show()
        Me.Hide()


    End Sub
End Class