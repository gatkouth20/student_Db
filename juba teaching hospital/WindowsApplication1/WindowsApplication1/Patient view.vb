Public Class Patient_view


    Private Sub Patient_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet16.Patient_Registration' table. You can move, or remove it, as needed.
        Me.Patient_RegistrationTableAdapter.Fill(Me.Hospital_management_systemDataSet16.Patient_Registration)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home__Page.Show()
        Me.Hide()


    End Sub
End Class