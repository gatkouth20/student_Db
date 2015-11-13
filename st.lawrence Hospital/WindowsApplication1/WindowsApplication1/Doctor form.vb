Public Class Doctor_form

    Private Sub Doctor_s_RegistrationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Doctor_s_RegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Doctor_s_RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SystemDataSet)

    End Sub

    Private Sub Doctor_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SystemDataSet._Doctor_s_Registration' table. You can move, or remove it, as needed.
        Me.Doctor_s_RegistrationTableAdapter.Fill(Me.SystemDataSet._Doctor_s_Registration)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Home_Page.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Doctor_view.Show()
        Me.Hide()


    End Sub
End Class