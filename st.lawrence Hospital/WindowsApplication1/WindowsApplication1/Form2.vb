Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet.Patient_Registration' table. You can move, or remove it, as needed.
        Me.Patient_RegistrationTableAdapter.Fill(Me.SystemDataSet.Patient_Registration)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()


        Me.Hide()


    End Sub
End Class