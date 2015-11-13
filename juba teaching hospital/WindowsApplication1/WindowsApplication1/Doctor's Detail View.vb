Public Class Doctor_s_Detail_View

    Private Sub Doctor_s_Detail_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet._Doctor_s_registration' table. You can move, or remove it, as needed.
        Me.Doctor_s_registrationTableAdapter1.Fill(Me.Hospital_management_systemDataSet._Doctor_s_registration)
        'TODO: This line of code loads data into the 'Hospital_management_systemDataSet14._Doctor_s_registration' table. You can move, or remove it, as needed.
        Me.Doctor_s_registrationTableAdapter.Fill(Me.Hospital_management_systemDataSet14._Doctor_s_registration)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home__Page.Show()

        Me.Hide()

    End Sub
End Class