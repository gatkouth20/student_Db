Public Class Room_view

    Private Sub Room_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet.Rooms_allocation' table. You can move, or remove it, as needed.
        Me.Rooms_allocationTableAdapter.Fill(Me.SystemDataSet.Rooms_allocation)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Rooms.Show()
        Me.Hide()

    End Sub
End Class