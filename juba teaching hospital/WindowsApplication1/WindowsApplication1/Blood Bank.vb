Public Class Blood_Bank

    Private Sub Blood_Bank_RegistrationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blood_Bank_RegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Blood_Bank_RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub Blood_Bank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.Blood_Bank_Registration' table. You can move, or remove it, as needed.
        Me.Blood_Bank_RegistrationTableAdapter.Fill(Me.Hospital_management_systemDataSet.Blood_Bank_Registration)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Home__Page.Show()
        Me.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("Data added Successfully")
    End Sub
End Class