Public Class Doctor_view

    Private Sub Doctor_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet._Doctor_s_Registration' table. You can move, or remove it, as needed.
        Me.Doctor_s_RegistrationTableAdapter.Fill(Me.SystemDataSet._Doctor_s_Registration)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Doctor_form.Show()
        Me.Hide()


    End Sub
End Class