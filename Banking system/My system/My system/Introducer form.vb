Public Class Introducer_form

    Private Sub Witness_informationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Witness_informationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Witness_informationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Banking_managmentDataSet)

    End Sub

    Private Sub Introducer_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Banking_managmentDataSet.Witness_information' table. You can move, or remove it, as needed.
        Me.Witness_informationTableAdapter.Fill(Me.Banking_managmentDataSet.Witness_information)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("New Row Added")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BindingNavigatorDeleteItem.PerformClick()
        MsgBox("Data Deleted")
    End Sub
End Class