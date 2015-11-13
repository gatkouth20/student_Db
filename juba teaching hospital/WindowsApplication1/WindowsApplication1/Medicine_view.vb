Public Class Medicine_view

    Private Sub Medicine_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet.Medicine_Update' table. You can move, or remove it, as needed.
        Me.Medicine_UpdateTableAdapter.Fill(Me.Hospital_management_systemDataSet.Medicine_Update)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Medicine_Update.Show()
        Me.Hide()


    End Sub
End Class