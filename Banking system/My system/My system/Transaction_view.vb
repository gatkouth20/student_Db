Public Class Transaction_view

    Private Sub Transaction_infoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transaction_infoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Transaction_infoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Banking_managmentDataSet)

    End Sub

    Private Sub Transaction_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Banking_managmentDataSet.Transaction_info' table. You can move, or remove it, as needed.
        Me.Transaction_infoTableAdapter.Fill(Me.Banking_managmentDataSet.Transaction_info)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Transaction_form.Show()

    End Sub
End Class