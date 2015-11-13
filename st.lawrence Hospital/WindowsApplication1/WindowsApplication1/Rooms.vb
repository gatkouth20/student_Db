Public Class Rooms

    Private Sub Rooms_allocationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rooms_allocationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Rooms_allocationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SystemDataSet)

    End Sub

    Private Sub Rooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet.Rooms_allocation' table. You can move, or remove it, as needed.
        Me.Rooms_allocationTableAdapter.Fill(Me.SystemDataSet.Rooms_allocation)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home_Page.Show()

        Me.Hide()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Room_view.Show()
        Me.Hide()

    End Sub
End Class