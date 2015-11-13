Public Class Medicine_Update

    Private Sub Medicine_UpdateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Medicine_UpdateBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Medicine_UpdateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub Medicine_Update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.Medicine_Update' table. You can move, or remove it, as needed.
        Me.Medicine_UpdateTableAdapter.Fill(Me.Hospital_management_systemDataSet.Medicine_Update)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingNavigatorAddNewItem.PerformClick()
        MsgBox("One item added")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Home__Page.Show()
        Me.Hide()


    End Sub

    Private Sub Medicine_nameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Medicine_view.Show()
        Me.Hide()


    End Sub
End Class