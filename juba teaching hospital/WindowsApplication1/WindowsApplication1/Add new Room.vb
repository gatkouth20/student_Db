Public Class Add_new_Room

    Private Sub Add_new_RoomBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_new_RoomBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Add_new_RoomBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_management_systemDataSet)

    End Sub

    Private Sub Add_new_Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.Add_new_Room' table. You can move, or remove it, as needed.
        Me.Add_new_RoomTableAdapter.Fill(Me.Hospital_management_systemDataSet.Add_new_Room)

    End Sub
End Class